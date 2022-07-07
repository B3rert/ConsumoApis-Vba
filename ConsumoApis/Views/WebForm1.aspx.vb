Imports System.IO
Imports System.Net
Imports System.Threading.Tasks
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Net.Http.Headers

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPrueba_Click(sender As Object, e As EventArgs)

        Dim res = getDataApis()
        MsgBox(res.Result)


    End Sub

    Public Async Function getDataApis() As Task(Of String)


        Dim token As String = ""
        Dim certificador = 3
        Dim apiUse = 4
        'Dim uuidDoc = "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270"
        Dim uuidDoc = "261406A3-8D69-4DD5-B856-3A1F447D5CF3"

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        'Url pruebas
        Dim urlApis = "http://localhost:9096/api/ApiCatalogo/4/155/ds"
        Dim urlParametro = $"http://localhost:9096/api/ParametroCatalogo/{apiUse}/ds"
        'Credenciales y docuemnto
        Dim urlDocuemnto = $"http://localhost:9096/api/DocumentoXml/2/{uuidDoc}/sa"
        Dim urlCredenciales = $"http://localhost:9096/api/Credenciales/2/{certificador}/1/sa"

        'Catalogo apis
        Dim apis = Await GetRequestApi(urlApis)

        If apis.statusCode <> 200 Then
            Return apis.response
        End If

        Dim listApis = JsonConvert.DeserializeObject(apis.response)

        'Api que se va a usar
        Dim api = JsonConvert.DeserializeObject(Of CatalogoApiModel)(listApis(3).ToString())


        'Get documento
        Dim documentos = Await GetRequestApi(urlDocuemnto)
        If documentos.statusCode <> 200 Then
            Return documentos.response
        End If
        Dim listDocumento = JsonConvert.DeserializeObject(documentos.response)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = Await GetRequestApi(urlCredenciales)
        If credenciales.statusCode <> 200 Then
            Return credenciales.response
        End If
        Dim listCredenciales = JsonConvert.DeserializeObject(credenciales.response)


        'Verificar si es necesario token 
        If api.req_Autorizacion Then
            'Solicitar token
            'certificador/empresa/user
            Dim urlToken = $"http://localhost:9096/api/Tokens/{certificador}/1/sa"
            Dim responseToken = Await GetRequestApi(urlToken)
            If responseToken.statusCode <> 200 Then
                Return responseToken.response
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
        Dim parametros = Await GetRequestApi(urlParametro)
        If parametros.statusCode <> 200 Then
            Return parametros.response
        End If
        Dim listParametros = JsonConvert.DeserializeObject(parametros.response)

        Dim urlApi = api.url_Api

        'Buscar parametros en url 
        urlApi = replaceValues(urlApi, token, documento, listCredenciales)


        'Configurar api
        Dim request = CType(WebRequest.Create(urlApi), HttpWebRequest)
        request.Method = api.nom_Tipo_Metodo
        request.Accept = "*/*"
        'request.Headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjY0Mzg1MjYwLCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiJlMjFkNGIyMS1lYWZkLTQzMDctOWNjMC05NzQ0NzIyMzk1MzIiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.3D26kQWXbDz3qIqSXwzl3uIJnHVE-ojpRaprlaOrHbhLKOOiB12jTx0rAPD6tixVuxPTkeg_b5EcsYVx5fDq2ezsFi3bCcg0tr2-qMK3M2Tz4g9k63jtCwmiW4O32EWzVykTZQnghg7sZ4EzTBCSbANfqFI0UYX2CGH-4RRd-N_IbveiapPXemQvYSWTCHu3j3fBZM6upHPSLawqLSLu_fqf1r0IgHu8yF4YeWsXE18PzpMDMmjEZkXOtr7gp_Wt_35ZDCPSByIDmNTJUFn8PoysNZFpbU4NOmIzsNuExCc8h20gmceOa5BYJb4X0krd-4HNvOg2OGhnDqkYddx9zg")




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

                            request.Headers.Add(credencial.campo_Nombre, credencial.campo_Valor)

                        End If

                    Next ii

                    If parametro.descripcion = "Authorization" Then
                        request.Headers.Add("Authorization", token)

                    End If
                End If

            Next i
        End If

        'Encontrar parametros en body
        For index = 0 To listParametros.Count - 1
            'Get parametro 
            Dim parametro = JsonConvert.DeserializeObject(Of CatalogoParametrosModel)(listParametros(index).ToString())
            'Param Body
            If parametro.tipo_Parametro = 2 Then
                'Replace values in param 

                'Config ContentType 5 Json 6 xml 
                If parametro.tipo_Dato = 6 Then
                    'ContentType
                    request.ContentType = "application/xml"

                    Dim paramValueXml = replaceValues(parametro.plantilla, token, documento, listCredenciales)

                    'Dim pruebaRes = postXMLDataAuth(urlApi, paramValueXml)

                    'MsgBox(pruebaRes)


                    'Add param to body api
                    Dim bytes As Byte()
                    bytes = Encoding.ASCII.GetBytes(paramValueXml)
                    request.ContentLength = bytes.Length

                    Dim streamXml As Stream = request.GetRequestStream()
                    streamXml.Write(bytes, 0, bytes.Length)
                    streamXml.Close()

                Else
                    'ContentType
                    request.ContentType = "application/json"
                    Dim paramValueJson = replaceValuesJson(parametro.plantilla, token, documento, listCredenciales)

                    'Add param to body api
                    Using streamWriterJson = New StreamWriter(request.GetRequestStream())
                        streamWriterJson.Write(paramValueJson)
                        streamWriterJson.Flush()
                        streamWriterJson.Close()
                    End Using

                End If

                Exit For
            End If
        Next



        'Use api 
        Try
            Using responseApi As WebResponse = request.GetResponse()
                Using streamApi As Stream = responseApi.GetResponseStream()
                    If streamApi Is Nothing Then Return ""

                    Using streamReaderApi As StreamReader = New StreamReader(streamApi)
                        Dim response As String = streamReaderApi.ReadToEnd()


                        If String.IsNullOrEmpty(api.nodo_FirmaDocumentoResponse) Then
                            Dim responseUpdate = Await updateDocDatabase(response, documento.d_Id_Unc)

                            Return responseUpdate.response

                        Else

                            Dim xml As XmlDocument = New XmlDocument()
                            xml.LoadXml(response)
                            Dim xmlNode As XmlNode = xml.SelectSingleNode(api.nodo_FirmaDocumentoResponse)

                            Dim responseUpdate = Await updateDocDatabase(xmlNode.InnerText, documento.d_Id_Unc)

                            Return responseUpdate.response
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try


    End Function

    Public Function replaceValuesJson(ByVal param As String, ByVal token As String, ByVal documento As DocumentoXmlModel, ByVal listCredenciales As Object)

        Dim ObjParam = New Dictionary(Of String, Object)

        Dim subs As String() = param.Split(","c)
        For Each i In subs

            Dim subs2 As String() = i.Split(":"c)

            'No estoy muy seguro de esto, falta probar
            For Each ii In listCredenciales

                Dim credencial = JsonConvert.DeserializeObject(Of CredencialModel)(ii.ToString())
                subs2(1) = subs2(1).Replace("{" + credencial.campo_Nombre + "}", credencial.campo_Valor)

            Next ii

            subs2(1) = subs2(1).Replace("{token}", token)
            subs2(1) = subs2(1).Replace("{xml_Contenido}", documento.xml_Contenido)
            subs2(1) = subs2(1).Replace("{d_Id_Unc}", documento.d_Id_Unc.ToUpper())

            ObjParam.Add(subs2(0), subs2(1))
        Next i

        Return JsonConvert.SerializeObject(ObjParam)
    End Function


    Public Function replaceValues(ByVal param As String, ByVal token As String, ByVal documento As DocumentoXmlModel, ByVal listCredenciales As Object) As String


        'search params and replace with value
        For Each i In listCredenciales

            Dim credencial = JsonConvert.DeserializeObject(Of CredencialModel)(i.ToString())
            param = param.Replace("{" + credencial.campo_Nombre + "}", credencial.campo_Valor)

        Next i

        'documento.xml_Contenido = documento.xml_Contenido.Replace("<", "&lt;")
        'documento.xml_Contenido = documento.xml_Contenido.Replace(">", "&gt;")

        'Replace other values
        param = param.Replace("{xml_Contenido}", documento.xml_Contenido)
        param = param.Replace("{d_Id_Unc}", documento.d_Id_Unc.ToUpper())

        param = param.Replace("{token}", token)
        Return param

    End Function


    Private Async Function updateDocDatabase(ByVal doc, ByVal uuid) As Task(Of ResponseApiModel)

        Dim url = "http://localhost:9096/api/DocumentoXml"
        Dim Obj = New Dictionary(Of String, Object) From {
            {"usuario", "sa"},
            {"documento", doc},
            {"uuid", uuid}
        }

        Dim strCuenta = JsonConvert.SerializeObject(Obj)

        Try
            Dim client = New HttpClient()
            Dim builder As UriBuilder = New UriBuilder(url)
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


    Private Async Function GetRequestApi(ByVal url As String) As Task(Of ResponseApiModel)

        Try
            Dim client = New HttpClient()
            Dim builder As UriBuilder = New UriBuilder(url)
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