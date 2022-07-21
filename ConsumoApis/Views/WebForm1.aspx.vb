Imports System.Net
Imports System.Threading.Tasks
Imports System.Xml
Imports Newtonsoft.Json
Imports System.Net.Http

Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim urlApiServer As String = ConfigurationManager.AppSettings.Get("serverApi")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPrueba_Click(sender As Object, e As EventArgs) Handles btnPrueba.Click

        'LLamar funcion 
        Dim res = getDataApis()

        'Respuestas
        If res.Result.Code <> 200 Then
            'Error
            MsgBox(res.Result.Message, vbCritical, $"{res.Result.Api} ({ res.Result.Code})")
        Else
            MsgBox(res.Result.Message, vbDefaultButton1, res.Result.Code)

        End If
    End Sub

    Private Async Function getDataApis() As Task(Of ErrorModel)

        'Variables
        Dim token As String = ""
        Dim usuario = "sa"
        Dim certificador = 3
        Dim apiUse = 4
        Dim uuidDoc = "261406A3-8D69-4DD5-B856-3A1F447D5CF3"
        Dim connectionStr = "Data Source=ds.demosoftonline.com,1541;Initial Catalog=MODEGT;User ID=devtecpan;Password=devtecpan*%"
        Dim apiToken = 6
        'Dim uuidDoc = "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270"

        'Protocolo de seguridad
        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        'Urls
        Dim urlApis = $"{urlApiServer}ApiCatalogo/3/{apiUse}/{usuario}"
        Dim urlParametro = $"{urlApiServer}ParametroCatalogo/{apiUse}/{usuario}"
        Dim urlDocumento = $"{urlApiServer}DocumentoXml/2/{uuidDoc}/{usuario}"
        Dim urlCredenciales = $"{urlApiServer}Credenciales/2/{certificador}/1/{usuario}"

        'Catalogo apis
        Dim apis = Await GetRequestApi(urlApis, connectionStr, 0)

        If apis.statusCode <> 200 Then
            Return New ErrorModel() With {
                .Code = apis.statusCode,
                .Api = urlApis,
                .Message = apis.response
            }
        End If

        Dim listApis = JsonConvert.DeserializeObject(apis.response)

        'Api que se va a usar
        Dim api = JsonConvert.DeserializeObject(Of CatalogoApiModel)(listApis(0).ToString())


        'Get documento
        Dim documentos = Await GetRequestApi(urlDocumento, connectionStr, 0)
        If documentos.statusCode <> 200 Then
            Return New ErrorModel() With {
                .Code = documentos.statusCode,
                .Api = urlDocumento,
                .Message = documentos.response
            }
        End If
        Dim listDocumento = JsonConvert.DeserializeObject(documentos.response)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = Await GetRequestApi(urlCredenciales, connectionStr, 0)
        If credenciales.statusCode <> 200 Then
            Return New ErrorModel() With {
                .Code = credenciales.statusCode,
                .Api = urlCredenciales,
                .Message = credenciales.response
            }
        End If
        Dim listCredenciales = JsonConvert.DeserializeObject(credenciales.response)


        'Verificar si es necesario token 
        If api.req_Autorizacion Then
            'Solicitar token
            'certificador/empresa/user
            Dim urlToken = $"{urlApiServer}Tokens/{certificador}/1/{usuario}"
            Dim responseToken = Await GetRequestApi(urlToken, connectionStr, apiToken)
            If responseToken.statusCode <> 200 Then
                Return New ErrorModel() With {
                .Code = responseToken.statusCode,
                .Api = urlToken,
                .Message = responseToken.response
            }
            End If

            Dim tokenObj = JsonConvert.DeserializeObject(Of ResponseApiModel)(responseToken.response)

            If tokenObj.response.Length > 7 Then
                'Token obtenido 
                token = tokenObj.response
            Else
                'No se obtubo un token
            End If

        End If

        'Catalogo parametros
        Dim parametros = Await GetRequestApi(urlParametro, connectionStr, 0)
        If parametros.statusCode <> 200 Then
            Return New ErrorModel() With {
                .Code = parametros.statusCode,
                .Api = urlParametro,
                .Message = parametros.response
            }
        End If
        Dim listParametros = JsonConvert.DeserializeObject(parametros.response)

        Dim urlApi = api.url_Api

        'Buscar parametros en url 
        urlApi = replaceValues(urlApi, token, documento, listCredenciales)


        Try
            'Configurar api
            Dim client = New HttpClient()
            Dim builder As UriBuilder = New UriBuilder(urlApi)

            'Verificar headers
            If listParametros.Count <> 0 Then

                For Each i In listParametros

                    Dim parametro = JsonConvert.DeserializeObject(Of CatalogoParametrosModel)(i.ToString())

                    If parametro.tipo_Parametro = 3 Then
                        'Header 
                        'Replace params to value and add headers
                        For Each ii In listCredenciales

                            Dim credencial = JsonConvert.DeserializeObject(Of CredencialModel)(ii.ToString())
                            If credencial.campo_Nombre = parametro.descripcion And parametro.descripcion <> "Authorization" Then

                                client.DefaultRequestHeaders.Add(credencial.campo_Nombre, credencial.campo_Valor)
                            End If

                        Next ii

                    End If

                Next i
            End If

            client.DefaultRequestHeaders.Add("Authorization", token)
            client.DefaultRequestHeaders.Add("connectionStr", connectionStr)

            Dim contentType = 0
            Dim content = ""

            'Encontrar parametros en body
            For index = 0 To listParametros.Count - 1
                'Get parametro 
                Dim parametro = JsonConvert.DeserializeObject(Of CatalogoParametrosModel)(listParametros(index).ToString())
                'Param Body
                If parametro.tipo_Parametro = 2 Then
                    'Replace values in param 

                    'Config ContentType 5 Json 6 xml 
                    If parametro.tipo_Dato = 6 Then
                        'ContentType xml
                        contentType = 6
                        content = replaceValues(parametro.plantilla, token, documento, listCredenciales)

                    Else
                        'ContentType json
                        contentType = 5
                        content = replaceValuesJson(parametro.plantilla, token, documento, listCredenciales)

                    End If

                    Exit For
                End If
            Next

            'Agregar contenido
            Dim httpContent = New StringContent("", Encoding.UTF8, "application/json")

            If contentType <> 0 Then
                If contentType = 5 Then
                    httpContent = New StringContent(content, Encoding.UTF8, "application/json")

                ElseIf contentType = 6 Then
                    httpContent = New StringContent(content, Encoding.UTF8, "application/xml")

                End If
            End If

            Dim response

            'Verificar metodo api
            Select Case api.tipo_Metodo
                Case 1 'POST
                    response = Await client.PostAsync(builder.Uri, httpContent)
                Case 2 'PUT
                    response = Await client.PutAsync(builder.Uri, httpContent)
                Case 3 'GET
                    response = Await client.GetAsync(builder.Uri)

                Case 4 'DELETE
                    response = Await client.DeleteAsync(builder.Uri)

                Case Else
                    Return New ErrorModel() With {
                .Code = 500,
                .Api = "None",
                .Message = "Solo se permiten los metodos POST, PUT, GET y DELETE"
            }
            End Select

            'Consumir apis
            Dim result = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                Return New ErrorModel() With {
              .Code = 500,
              .Api = api.url_Api,
              .Message = result}
            End If

            'Verificar respuespuestas
            If String.IsNullOrEmpty(api.nodo_FirmaDocumentoResponse) Then
                Dim responseUpdate = Await updateDocDatabase(result, documento.d_Id_Unc, connectionStr)

                If responseUpdate.statusCode <> 200 Then
                    Return New ErrorModel() With {
              .Code = responseUpdate.statusCode,
              .Api = $"{urlApiServer}DocumentoXml",
              .Message = responseUpdate.response}
                End If
                Return New ErrorModel() With {
             .Code = responseUpdate.statusCode,
             .Api = $"{urlApiServer}DocumentoXml",
             .Message = responseUpdate.response}


            Else

                'Buscar respuesta en nodo especifico 
                Dim xml As XmlDocument = New XmlDocument()
                xml.LoadXml(result)
                Dim xmlNode As XmlNode = xml.SelectSingleNode(api.nodo_FirmaDocumentoResponse)

                'Actualizar campo tabñas
                Dim responseUpdate = Await updateDocDatabase(xmlNode.InnerText, documento.d_Id_Unc, connectionStr)

                'Verificar respiuestas
                If responseUpdate.statusCode <> 200 Then
                    Return New ErrorModel() With {
              .Code = responseUpdate.statusCode,
              .Api = $"{urlApiServer}DocumentoXml",
              .Message = responseUpdate.response}
                End If
                Return New ErrorModel() With {
             .Code = responseUpdate.statusCode,
             .Api = $"{urlApiServer}DocumentoXml",
             .Message = responseUpdate.response}

            End If

        Catch ex As Exception


            Return New ErrorModel() With {
             .Code = 500,
             .Api = "None",
             .Message = ex.Message}

        End Try


    End Function

    Private Function replaceValuesJson(ByVal param As String, ByVal token As String, ByVal documento As DocumentoXmlModel, ByVal listCredenciales As Object)
        'Remplazar y armat json para param body
        Dim ObjParam = New Dictionary(Of String, Object)

        Dim subs As String() = param.Split(","c)
        For Each i In subs

            Dim subs2 As String() = i.Split(":"c)

            'No estoy muy seguro de esto, falta probar
            For Each ii In listCredenciales

                Dim credencial = JsonConvert.DeserializeObject(Of CredencialModel)(ii.ToString())
                subs2(1) = subs2(1).Replace("{" + credencial.campo_Nombre + "}", credencial.campo_Valor)

            Next ii

            'Agregar propiedades y valores al objeto
            subs2(1) = subs2(1).Replace("{token}", token)
            subs2(1) = subs2(1).Replace("{xml_Contenido}", documento.xml_Contenido)
            subs2(1) = subs2(1).Replace("{d_Id_Unc}", documento.d_Id_Unc.ToUpper())

            ObjParam.Add(subs2(0), subs2(1))
        Next i

        Return JsonConvert.SerializeObject(ObjParam)
    End Function


    Private Function replaceValues(ByVal param As String, ByVal token As String, ByVal documento As DocumentoXmlModel, ByVal listCredenciales As Object) As String

        'search params and replace with value
        For Each i In listCredenciales

            Dim credencial = JsonConvert.DeserializeObject(Of CredencialModel)(i.ToString())
            param = param.Replace("{" + credencial.campo_Nombre + "}", credencial.campo_Valor)

        Next i

        'Replace other values
        param = param.Replace("{xml_Contenido}", documento.xml_Contenido)
        param = param.Replace("{d_Id_Unc}", documento.d_Id_Unc.ToUpper())

        param = param.Replace("{token}", token)
        Return param

    End Function


    Private Async Function updateDocDatabase(ByVal doc, ByVal uuid, ByVal connectionStr) As Task(Of ResponseApiModel)

        'Url acrualizar
        Dim url = $"{urlApiServer}DocumentoXml"
        Dim Obj = New Dictionary(Of String, Object) From {
            {"usuario", "sa"},
            {"documento", doc},
            {"uuid", uuid}
        }

        Dim strCuenta = JsonConvert.SerializeObject(Obj)

        'Usar Apis
        Try
            Dim client = New HttpClient()
            Dim builder As UriBuilder = New UriBuilder(url)
            client.DefaultRequestHeaders.Add("connectionStr", connectionStr)
            Dim content = New StringContent(strCuenta, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync(builder.Uri, content)
            Dim result = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                Dim message = result
                Return New ResponseApiModel() With {
                .statusCode = CInt(response.StatusCode),
                .response = message
            }
            End If

            Return New ResponseApiModel() With {
            .statusCode = 200,
            .response = result
        }
        Catch ex As Exception
            Dim msgError As String

            Select Case ex.Message
                Case "No such host is known"
                    msgError = "No se encontro el servidor"
                Case Else
                    msgError = ex.Message
            End Select

            Return New ResponseApiModel() With {
            .statusCode = 500,
            .response = msgError
        }
        End Try
    End Function


    Private Async Function GetRequestApi(ByVal url As String, ByVal connectionStr As String, ByVal apiToken As Integer) As Task(Of ResponseApiModel)

        'Api get usar
        'Api get usar
        Try
            Dim client = New HttpClient()
            Dim builder As UriBuilder = New UriBuilder(url)
            client.DefaultRequestHeaders.Add("connectionStr", connectionStr)
            client.DefaultRequestHeaders.Add("apiToken", apiToken)
            Dim response = Await client.GetAsync(builder.Uri)
            Dim result = Await response.Content.ReadAsStringAsync()

            If Not response.IsSuccessStatusCode Then
                Dim message = result
                Return New ResponseApiModel() With {
                    .statusCode = CInt(response.StatusCode),
                    .response = message
                }
            End If

            Return New ResponseApiModel() With {
                .statusCode = 200,
                .response = result
            }
        Catch ex As Exception
            Dim msgError As String

            Select Case ex.Message
                Case "No such host is known"
                    msgError = "No se encontro el servidor"
                Case Else
                    msgError = ex.Message
            End Select

            Return New ResponseApiModel() With {
                .statusCode = 500,
                .response = msgError
            }
        End Try
    End Function

End Class