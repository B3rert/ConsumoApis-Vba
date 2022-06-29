Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPrueba_Click(sender As Object, e As EventArgs)

        'Api post Body

        'Dim urlApis As String = "http://localhost:9095/api/CuentaCorrentista"
        'Dim requestApi = CType(WebRequest.Create(urlApis), HttpWebRequest)
        'Dim Obj = New Dictionary(Of String, Object) From {
        '    {"name", "prueba"},
        '    {"email", "prubea@gmail.com"},
        '    {"phone", "484848"},
        '    {"adress", "Ciudad"},
        '    {"country", 1}
        '}


        'Dim strCuenta = JsonConvert.SerializeObject(Obj)
        'requestApi.Method = "POST"
        'requestApi.ContentType = "application/json"
        'requestApi.Accept = "application/json"


        'Using streamWriterCuenta = New StreamWriter(requestApi.GetRequestStream())
        '    streamWriterCuenta.Write(strCuenta)
        '    streamWriterCuenta.Flush()
        '    streamWriterCuenta.Close()
        'End Using

        'Try
        '    Using responseCuenta As WebResponse = requestApi.GetResponse()
        '        Using strReaderCuenta As Stream = responseCuenta.GetResponseStream()
        '            If strReaderCuenta Is Nothing Then Return

        '            Using objReaderCuenta As StreamReader = New StreamReader(strReaderCuenta)
        '                Dim response As String = objReaderCuenta.ReadToEnd()
        '                MsgBox(response)
        '            End Using
        '        End Using
        '    End Using

        'Catch ex As Exception
        '    MsgBox("Can't load Web api" & vbCrLf & ex.Message)
        'End Try




        Dim urlDocuemnto = "http://localhost:9096/api/DocumentoXml/2/6c27ff05-5baf-47e5-8a1c-2f67b5fde270/sa"
        Dim urlCredenciales = "http://localhost:9096/api/Credenciales/2/3/1/sa"

        'Get documento
        Dim documentos = RequestApi(urlDocuemnto)
        Dim listDocumento = JsonConvert.DeserializeObject(documentos)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        Dim xml = "<?xml version='1.0' encoding='UTF-8'?>
                     <SolicitaTokenRequest>
                    <usuario>83466371</usuario>
                    <apikey>WEl3Zdf9qbKc8mulE0SRK5j</apikey>
                    </SolicitaTokenRequest>"

        Dim xmlBody = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?> 
<FirmaDocumentoRequest id=" & Chr(34) & "EAFAC23F-C30C-4F98-A953-09415A9B9947" & Chr(34) & ">
<xml_dte><![CDATA[{body}]]> 
</xml_dte>
</FirmaDocumentoRequest>"
        xmlBody = xmlBody.Replace("{body}", documento.xml_Contenido)


        Dim url = "https://dev2.api.ifacere-fel.com/api/solicitarToken"

        Dim urlFirma = "https://dev.api.soluciones-mega.com/api/solicitaFirma"

        Dim urlUnificado = "http://localhost:9096/api/MegaPrint/Certifica"

        Dim token = "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjYzODUyNjA2LCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiI4YTk0NWE1OS0yMWY3LTQ3OGEtYjA0Zi1iMDljZDk4NWUwMjkiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.LlGcIoysSQjrjVRQ4CdnbgKEGn8xlAbLQek1f4_dHyre-ifPGp9MOS32DhAlhdGAzcptllprZyi-MdeLmHAyFnFEhGXPGqCe9Ku-sJsmDLzlfYzK0FTLt9b4bkoz93cOHqOp6j-Kr3LMpd4Un3NO_3APhsfOlqZKL24uwSrHl7TAqWGYHXGsiX8uPqkcY4y537OKgY_kbzNSUQ4s6Co_JXZv2lixQh-1VVUMSSKCLA89cOJu2D4H3t1CE-wBlIxGRhWfegoyTstznM-zmjMFHE1SvtYqiZU-4ZkZn-6WPiSn0HYehKkOZdphcL8I6dICGU6mg5psuoTcH8UAqpUyUg"

        Dim urlParametro = "http://localhost:9096/api/ParametroCatalogo/2/ds"


        'Catalogo parametros
        Dim parametros = RequestApi(urlParametro)
        Dim listParametros = JsonConvert.DeserializeObject(parametros)
        Dim parametro = JsonConvert.DeserializeObject(Of CatalogoParametrosModel)(listParametros(0).ToString())
        Dim param = parametro.plantilla

        'Dim res = postXMLData(url, xml)
        'Dim res = postXMLDataAuth(urlFirma, xmlBody)
        'Dim res = postJsonBody(token, urlUnificado, documento.xml_Contenido, param)

        Dim res = getDataApis(token)
        MsgBox(res)

    End Sub

    Public Function getDataApis(ByVal token)

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        'Url pruebas
        Dim urlApis = "http://localhost:9096/api/ApiCatalogo/4/155/ds"
        Dim urlParametro = "http://localhost:9096/api/ParametroCatalogo/2/ds"

        'Catalogo apis
        Dim apis = RequestApi(urlApis)
        Dim listApis = JsonConvert.DeserializeObject(apis)

        'Api que se va a usar
        Dim api = JsonConvert.DeserializeObject(Of CatalogoApiModel)(listApis(1).ToString())

        'Catalogo parametros
        Dim parametros = RequestApi(urlParametro)
        Dim listParametros = JsonConvert.DeserializeObject(parametros)

        Dim urlApi = api.url_Api

        'Buscar parametros en url 
        If listParametros.Count <> 0 Then

            For Each i In listParametros

                Dim parametro = JsonConvert.DeserializeObject(Of CatalogoParametrosModel)(i.ToString())

                If parametro.tipo_Parametro = 1 Then
                    'Header url
                    'Replace params to value
                End If

            Next i
        End If


        'Configurar api
        Dim request = CType(WebRequest.Create(urlApi), HttpWebRequest)
        request.Method = api.nom_Tipo_Metodo
        request.Accept = "*/*"

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

                    Dim paramValueXml = replaceValuesXml(parametro.plantilla, token)

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
                    Dim paramValueJson = replaceValuesJson(parametro.plantilla, token)

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
                        Return response
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try


    End Function

    Public Function replaceValuesJson(ByVal param As String, ByVal token As String)
        Dim urlDocuemnto = "http://localhost:9096/api/DocumentoXml/2/6c27ff05-5baf-47e5-8a1c-2f67b5fde270/sa"
        Dim urlCredenciales = "http://localhost:9096/api/Credenciales/2/3/1/sa"

        'Get documento
        Dim documentos = RequestApi(urlDocuemnto)
        Dim listDocumento = JsonConvert.DeserializeObject(documentos)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = RequestApi(urlCredenciales)
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
            subs2(1) = subs2(1).Replace("{d_Id_Unc}", "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270")

            ObjParam.Add(subs2(0), subs2(1))
        Next i



        Return JsonConvert.SerializeObject(ObjParam)
    End Function

    Public Function replaceValuesXml(ByVal param As String, ByVal token As String) As String



        Dim urlDocuemnto = "http://localhost:9096/api/DocumentoXml/2/6c27ff05-5baf-47e5-8a1c-2f67b5fde270/sa"
        Dim urlCredenciales = "http://localhost:9096/api/Credenciales/2/3/1/sa"

        'Get documento
        Dim documentos = RequestApi(urlDocuemnto)
        Dim listDocumento = JsonConvert.DeserializeObject(documentos)

        'Documento que se va a usar
        Dim documento = JsonConvert.DeserializeObject(Of DocumentoXmlModel)(listDocumento(0).ToString())

        'Get params values (credenciales)
        Dim credenciales = RequestApi(urlCredenciales)
        Dim listCredenciales = JsonConvert.DeserializeObject(credenciales)


        'xmlBody = xmlBody.Replace("{body}", dte)

        'search params and replace with value
        For Each i In listCredenciales

            Dim credencial = JsonConvert.DeserializeObject(Of CredencialModel)(i.ToString())
            param = param.Replace("{" + credencial.campo_Nombre + "}", credencial.campo_Valor)

        Next i

        'Replace other values
        param = param.Replace("{xml_Contenido}", documento.xml_Contenido)
        param = param.Replace("{d_Id_Unc}", documento.d_Id_Unc)
        param = param.Replace("{token}", token)

        Return param

    End Function


    Public Function postJsonBody(ByVal token, ByVal url, ByVal body, ByVal param) As String

        Dim ObjParam = New Dictionary(Of String, Object)

        Dim subs As String() = param.Split(","c)
        For Each i In subs

            Dim subs2 As String() = i.Split(":"c)

            subs2(1) = subs2(1).Replace("{token}", token)
            subs2(1) = subs2(1).Replace("{xml_Contenido}", body)
            subs2(1) = subs2(1).Replace("{d_Id_Unc}", "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270")

            ObjParam.Add(subs2(0), subs2(1))
        Next i



        Dim Obj = New Dictionary(Of String, Object) From {
            {"token", token},
            {"body", body},
            {"uiid", "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270"}
        }

        Dim strCuenta = JsonConvert.SerializeObject(ObjParam)
        Dim strCuenta2 = JsonConvert.SerializeObject(ObjParam)

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




    Public Function postXMLDataAuth(ByVal destinationUrl As String, ByVal requestXml As String) As String

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        Dim request = CType(WebRequest.Create(destinationUrl), HttpWebRequest)

        request.ContentType = "application/xml"
        request.Accept = "*/*"
        request.Method = "POST"

        request.Headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjYzODUyNjA2LCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiI4YTk0NWE1OS0yMWY3LTQ3OGEtYjA0Zi1iMDljZDk4NWUwMjkiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.LlGcIoysSQjrjVRQ4CdnbgKEGn8xlAbLQek1f4_dHyre-ifPGp9MOS32DhAlhdGAzcptllprZyi-MdeLmHAyFnFEhGXPGqCe9Ku-sJsmDLzlfYzK0FTLt9b4bkoz93cOHqOp6j-Kr3LMpd4Un3NO_3APhsfOlqZKL24uwSrHl7TAqWGYHXGsiX8uPqkcY4y537OKgY_kbzNSUQ4s6Co_JXZv2lixQh-1VVUMSSKCLA89cOJu2D4H3t1CE-wBlIxGRhWfegoyTstznM-zmjMFHE1SvtYqiZU-4ZkZn-6WPiSn0HYehKkOZdphcL8I6dICGU6mg5psuoTcH8UAqpUyUg")

        Dim bytes As Byte()
        bytes = Encoding.ASCII.GetBytes(requestXml)
        request.ContentLength = bytes.Length

        Dim requestStream As Stream = request.GetRequestStream()
        requestStream.Write(bytes, 0, bytes.Length)
        requestStream.Close()

        Try
            Using response As WebResponse = request.GetResponse()
                Using responseStream As Stream = response.GetResponseStream()
                    If responseStream Is Nothing Then Return ""

                    Using objReaderCuenta As StreamReader = New StreamReader(responseStream)
                        Dim strResponse As String = objReaderCuenta.ReadToEnd()
                        Return strResponse
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try

    End Function

    Public Function postXMLData(ByVal destinationUrl As String, ByVal requestXml As String) As String

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        Dim request As HttpWebRequest = CType(WebRequest.Create(destinationUrl), HttpWebRequest)
        Dim bytes As Byte()
        bytes = System.Text.Encoding.ASCII.GetBytes(requestXml)
        request.ContentType = "application/xml"
        request.Accept = "application/xml"
        request.ContentLength = bytes.Length
        request.Method = "POST"
        Dim requestStream As Stream = request.GetRequestStream()
        requestStream.Write(bytes, 0, bytes.Length)
        requestStream.Close()
        Dim response As HttpWebResponse
        response = CType(request.GetResponse(), HttpWebResponse)

        If response.StatusCode = HttpStatusCode.OK Then
            Dim responseStream As Stream = response.GetResponseStream()
            Dim responseStr As String = New StreamReader(responseStream).ReadToEnd()
            Return responseStr
        End If

        Return Nothing
    End Function

    Public Function RequestApi(ByVal url As String) As String

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