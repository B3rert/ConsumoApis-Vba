Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Xml.Serialization
Imports Newtonsoft.Json

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPrueba_Click(sender As Object, e As EventArgs)

        'Dim res = postXMLData(url, xml)
        'Dim res = postXMLDataAuth(urlFirma, xmlBody)
        'Dim res = postJsonBody(token, urlUnificado, documento.xml_Contenido, param)

        Dim res = getDataApis()
        MsgBox(res)

    End Sub

    Public Function getDataApis()


        Dim token As String = ""
        Dim certificador = 3
        Dim apiUse = 4
        'Dim uuidDoc = "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270"
        Dim uuidDoc = "261406A3-8D69-4DD5-B856-3A1F447D5CF3"

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        'Url pruebas
        Dim urlApis = "http://localhost:9096/api/ApiCatalogo/4/155/ds"
        Dim urlParametro = $"http://localhost:9096/api/ParametroCatalogo/{apiUse}/ds"

        'Catalogo apis
        Dim apis = GetRequestApi(urlApis)
        Dim listApis = JsonConvert.DeserializeObject(apis)

        'Api que se va a usar
        Dim api = JsonConvert.DeserializeObject(Of CatalogoApiModel)(listApis(3).ToString())

        'Verificar si es necesario token 
        If api.req_Autorizacion Then
            'Solicitar token
            'certificador/empresa/user
            Dim urlToken = $"http://localhost:9096/api/Tokens/{certificador}/1/sa"
            Dim responseToken = GetRequestApi(urlToken)
            Dim tokenObj = JsonConvert.DeserializeObject(Of ResponseApiModel)(responseToken)

            If tokenObj.response.Length > 7 Then
                'Token obtenido 
                token = tokenObj.response
            Else
                'No se obtubo un token
            End If

        End If

        'Catalogo parametros
        Dim parametros = GetRequestApi(urlParametro)
        Dim listParametros = JsonConvert.DeserializeObject(parametros)

        Dim urlApi = api.url_Api

        'Buscar parametros en url 
        urlApi = replaceValues(urlApi, token, certificador, uuidDoc)



        'Configurar api
        Dim request = CType(WebRequest.Create(urlApi), HttpWebRequest)
        request.Method = api.nom_Tipo_Metodo
        request.Accept = "*/*"
        'request.Headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjY0Mzg1MjYwLCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiJlMjFkNGIyMS1lYWZkLTQzMDctOWNjMC05NzQ0NzIyMzk1MzIiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.3D26kQWXbDz3qIqSXwzl3uIJnHVE-ojpRaprlaOrHbhLKOOiB12jTx0rAPD6tixVuxPTkeg_b5EcsYVx5fDq2ezsFi3bCcg0tr2-qMK3M2Tz4g9k63jtCwmiW4O32EWzVykTZQnghg7sZ4EzTBCSbANfqFI0UYX2CGH-4RRd-N_IbveiapPXemQvYSWTCHu3j3fBZM6upHPSLawqLSLu_fqf1r0IgHu8yF4YeWsXE18PzpMDMmjEZkXOtr7gp_Wt_35ZDCPSByIDmNTJUFn8PoysNZFpbU4NOmIzsNuExCc8h20gmceOa5BYJb4X0krd-4HNvOg2OGhnDqkYddx9zg")
        'Credenciales y docuemnto
        Dim urlDocuemnto = $"http://localhost:9096/api/DocumentoXml/2/{uuidDoc}/sa"
        Dim urlCredenciales = $"http://localhost:9096/api/Credenciales/2/{certificador}/1/sa"

        'Get documento
        Dim documentos = GetRequestApi(urlDocuemnto)
        Dim listDocumento = JsonConvert.DeserializeObject(documentos)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = GetRequestApi(urlCredenciales)
        Dim listCredenciales = JsonConvert.DeserializeObject(credenciales)



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

                    Dim paramValueXml = replaceValues(parametro.plantilla, token, certificador, uuidDoc)

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
                    Dim paramValueJson = replaceValuesJson(parametro.plantilla, token, certificador, uuidDoc)

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
                            Dim responseUpdate = updateDocDatabase(response, documento.d_Id_Unc)

                            Return responseUpdate

                        Else

                            Dim xml As XmlDocument = New XmlDocument()
                            xml.LoadXml(response)
                            Dim xmlNode As XmlNode = xml.SelectSingleNode(api.nodo_FirmaDocumentoResponse)

                            Dim responseUpdate = updateDocDatabase(xmlNode.InnerText, documento.d_Id_Unc)

                            Return responseUpdate
                        End If






                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try


    End Function

    Public Function replaceValuesJson(ByVal param As String, ByVal token As String, ByVal certificador As Integer, ByVal uuidDoc As String)
        Dim urlDocuemnto = $"http://localhost:9096/api/DocumentoXml/2/{uuidDoc}/sa"
        Dim urlCredenciales = $"http://localhost:9096/api/Credenciales/2/{certificador}/1/sa"

        'Get documento
        Dim documentos = GetRequestApi(urlDocuemnto)
        Dim listDocumento = JsonConvert.DeserializeObject(documentos)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = GetRequestApi(urlCredenciales)
        Dim listCredenciales = JsonConvert.DeserializeObject(credenciales)

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



    Public Function replaceValues(ByVal param As String, ByVal token As String, ByVal certificador As Integer, ByVal uuidDoc As String) As String



        Dim urlDocuemnto = $"http://localhost:9096/api/DocumentoXml/2/{uuidDoc}/sa"
        Dim urlCredenciales = $"http://localhost:9096/api/Credenciales/2/{certificador}/1/sa"

        'Get documento
        Dim documentos = GetRequestApi(urlDocuemnto)
        Dim listDocumento = JsonConvert.DeserializeObject(documentos)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = GetRequestApi(urlCredenciales)
        Dim listCredenciales = JsonConvert.DeserializeObject(credenciales)


        'xmlBody = xmlBody.Replace("{body}", dte)

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


    Public Function updateDocDatabase(ByVal doc, ByVal uuid) As String


        Dim url = "http://localhost:9096/api/DocumentoXml"
        Dim Obj = New Dictionary(Of String, Object) From {
            {"usuario", "sa"},
            {"documento", doc},
            {"uuid", uuid}
        }

        Dim strCuenta = JsonConvert.SerializeObject(Obj)

        Dim requestApi = CType(WebRequest.Create(url), HttpWebRequest)
        requestApi.Method = "POST"
        requestApi.ContentType = "application/json"
        requestApi.Accept = "*/*"


        Using streamWriterCuenta = New StreamWriter(requestApi.GetRequestStream())
            streamWriterCuenta.Write(strCuenta)
            streamWriterCuenta.Flush()
            streamWriterCuenta.Close()
        End Using

        Try
            Using responseCuenta As WebResponse = requestApi.GetResponse()
                Using strReaderCuenta As Stream = responseCuenta.GetResponseStream()
                    If strReaderCuenta Is Nothing Then Return ""

                    Using objReaderCuenta As StreamReader = New StreamReader(strReaderCuenta)
                        Dim response As String = objReaderCuenta.ReadToEnd()
                        Return response
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try

    End Function



    Public Function GetRequestApi(ByVal url As String) As String

        Dim requestApiUrl = CType(WebRequest.Create(url), HttpWebRequest)

        requestApiUrl.Method = "GET"
        requestApiUrl.ContentType = "*/*"
        requestApiUrl.Accept = "*/*"

        Try
            Using responseApi As WebResponse = requestApiUrl.GetResponse()
                Using strReaderApi As Stream = responseApi.GetResponseStream()
                    If strReaderApi Is Nothing Then Return ""

                    Using objReaderApi As StreamReader = New StreamReader(strReaderApi)
                        Dim response As String = objReaderApi.ReadToEnd()
                        Return response
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try

    End Function


End Class