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



        'Dim urlApis As String = "https://localhost:7156/api/ApiCatalogo/4/565/sa"
        'Dim requestApi = CType(WebRequest.Create(urlApis), HttpWebRequest)

        'Dim headers As NameValueCollection = New NameValueCollection From {
        '    {"Authorization", "bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJ2ZW50YXMiLCJuYmYiOjE2NTUzMzAzMDUsImV4cCI6MTY4NjQzNDMwNSwiaWF0IjoxNjU1MzMwMzA1fQ.TcT7AvG06yNJM0sRpc6694_RNY71kpkMpAxRH2vJ4Ic"}
        '}


        'requestApi.Method = "GET"
        'requestApi.ContentType = "application/json"
        'requestApi.Accept = "application/json"

        'requestApi.Headers.Add(headers)
        'Dim api As CatalogoApiModel
        'Try
        '    Using responseApi As WebResponse = requestApi.GetResponse()
        '        Using strReaderApi As Stream = responseApi.GetResponseStream()
        '            If strReaderApi Is Nothing Then Return

        '            Using objReaderApi As StreamReader = New StreamReader(strReaderApi)
        '                Dim response As String = objReaderApi.ReadToEnd()
        '                Dim list = JsonConvert.DeserializeObject(response)
        '                api = JsonConvert.DeserializeObject(Of CatalogoApiModel)(list(0).ToString())

        '            End Using
        '        End Using
        '    End Using

        'Catch ex As Exception
        '    MsgBox("Can't load Web api" & vbCrLf & ex.Message)
        'End Try


        'Dim api = RequestApi("http://localhost:9096/api/ApiCatalogo/4/565/sa")
        'Dim parametroApi = RequestApi("http://localhost:9096/api/ParametroCatalogo/1/sa")

        'Dim request As HttpWebRequest = CType(WebRequest.Create(New Uri(url)), HttpWebRequest)
        'request.Method = "POST"
        'request.ContentType = "application/xml"
        'request.Accept = "application/xml"
        'Dim redmineRequestXML As XElement = New XElement("SolicitaTokenRequest", New XElement("usuario", "83466371"), New XElement("apikey", "WEl3Zdf9qbKc8mulE0SRK5j"))
        'Dim bytes As Byte() = Encoding.UTF8.GetBytes(redmineRequestXML.ToString())
        'request.ContentLength = bytes.Length

        'Using putStream As Stream = request.GetRequestStream()
        '    putStream.Write(bytes, 0, bytes.Length)
        'End Using

        'Try
        '    Using responseApi As WebResponse = request.GetResponse()
        '        Using strReaderApi As Stream = responseApi.GetResponseStream()
        '            If strReaderApi Is Nothing Then Return

        '            Using objReaderApi As StreamReader = New StreamReader(strReaderApi)
        '                Dim response As String = objReaderApi.ReadToEnd()
        '                MsgBox(response)
        '            End Using
        '        End Using
        '    End Using

        'Catch ex As Exception
        '    MsgBox("Can't load Web api" & vbCrLf & ex.Message)
        'End Try

        Dim xml = "<?xml version='1.0' encoding='UTF-8'?>
<SolicitaTokenRequest>
<usuario>83466371</usuario>
<apikey>WEl3Zdf9qbKc8mulE0SRK5j</apikey>
</SolicitaTokenRequest>"

        Dim xmlExample = "<ParametroCatalogoModel  xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.datacontract.org/2004/07/ApiDocs.Models'>
   <Api xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:int'>1</Api>
   <Descripcion xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:string'>Nombre de usuario</Descripcion>
   <Nom_Tipo_Dato xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:string'>STRING</Nom_Tipo_Dato>
   <Nom_Tipo_Parametro xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:string'>Header_Url</Nom_Tipo_Parametro>
   <Parametro xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:int'>1</Parametro>
   <Plantilla xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:string'></Plantilla>
   <Tipo_Dato xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:unsignedByte'>1</Tipo_Dato>
   <Tipo_Parametro xmlns:d3p1='http://www.w3.org/2001/XMLSchema' i:type='d3p1:unsignedByte'>1</Tipo_Parametro>
</ParametroCatalogoModel>"

        Dim url = "https://dev2.api.ifacere-fel.com/api/solicitarToken"
        Dim urlExample = " http://localhost:9096/api/ParametroCatalogo"

        'Dim res = postXMLData(urlExample, xmlExample)
        Dim res = postXMLData(url, xml)
        MsgBox(res)
    End Sub


    Public Function postXMLData(ByVal destinationUrl As String, ByVal requestXml As String) As String




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

    Public Function RequestApiGeneric(ByVal apis As String, ByVal parametros As String) As String

        Dim listApis = JsonConvert.DeserializeObject(apis)
        Dim api = JsonConvert.DeserializeObject(Of CatalogoApiModel)(listApis(0).ToString())
        'Dim listParametros As New List(Of CatalogoParametrosModel)
        Dim listParametros = JsonConvert.DeserializeObject(parametros)

        Dim urlApi = api.url_Api

        If listParametros.Count <> 0 Then

            For Each i In listParametros
                Dim parametro = JsonConvert.DeserializeObject(Of CatalogoParametrosModel)(listParametros(i).ToString())

                Select Case parametro.tipo_Parametro
                    Case 1
                         'Header_url

                    Case 2
                        'Body

                    Case 3
                        'Headers

                    Case Else
                        'Parametro deesconocido
                End Select

            Next i
        End If


        Dim requestApiUrl = CType(WebRequest.Create(api.url_Api), HttpWebRequest)

        requestApiUrl.Method = api.nom_Tipo_Metodo
        requestApiUrl.ContentType = "application/json"
        requestApiUrl.Accept = "application/json"



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

    Public Function RequestApi(ByVal url As String) As String

        Dim requestApiUrl = CType(WebRequest.Create(url), HttpWebRequest)

        requestApiUrl.Method = "GET"
        requestApiUrl.ContentType = "application/json"
        requestApiUrl.Accept = "application/json"

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