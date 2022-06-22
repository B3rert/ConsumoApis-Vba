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

        Dim dte = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?> 
<FirmaDocumentoRequest id=" & Chr(34) & "EAFAC23F-C30C-4F98-A953-09415A9B9947" & Chr(34) & ">
<xml_dte><![CDATA[<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & " standalone=" & Chr(34) & "no" & Chr(34) & "?>
<dte:GTDocumento xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " Version=" & Chr(34) & "0.1" & Chr(34) & ">
	<dte:SAT ClaseDocumento=" & Chr(34) & "dte" & Chr(34) & ">
		<dte:DTE ID=" & Chr(34) & "DatosCertificados" & Chr(34) & ">
			<dte:DatosEmision ID=" & Chr(34) & "DatosEmision" & Chr(34) & ">
				<dte:DatosGenerales CodigoMoneda=" & Chr(34) & "GTQ" & Chr(34) & " FechaHoraEmision=" & Chr(34) & "2022-06-17T11:33:14.000-06:00" & Chr(34) & " Tipo=" & Chr(34) & "FACT" & Chr(34) & "/>
				<dte:Emisor AfiliacionIVA=" & Chr(34) & "GEN" & Chr(34) & " CodigoEstablecimiento=" & Chr(34) & "1" & Chr(34) & " CorreoEmisor=" & Chr(34) & "" & Chr(34) & " NITEmisor=" & Chr(34) & "83466371" & Chr(34) & " NombreComercial=" & Chr(34) & "D'MOSOFT" & Chr(34) & " NombreEmisor=" & Chr(34) & "DESARROLLO MODERNO DE SOFTWARE, SOCIEDAD ANONIMA" & Chr(34) & ">
					<dte:DireccionEmisor>
						<dte:Direccion>   CIUDAD DE GUATEMALA  Guatemala, GUATEMALA</dte:Direccion>
						<dte:CodigoPostal>0</dte:CodigoPostal>
						<dte:Municipio>Guatemala</dte:Municipio>
						<dte:Departamento>GUATEMALA</dte:Departamento>
						<dte:Pais>GT</dte:Pais>
					</dte:DireccionEmisor>
				</dte:Emisor>
				<dte:Receptor CorreoReceptor=" & Chr(34) & "" & Chr(34) & " IDReceptor=" & Chr(34) & "50510231" & Chr(34) & " NombreReceptor=" & Chr(34) & "MEGAPRINT SOCIEDAD ANONIMA" & Chr(34) & ">
					<dte:DireccionReceptor>
						<dte:Direccion>Ciudad</dte:Direccion>
						<dte:CodigoPostal>0</dte:CodigoPostal>
						<dte:Municipio/>
						<dte:Departamento/>
						<dte:Pais>GT</dte:Pais>
					</dte:DireccionReceptor>
				</dte:Receptor>
				<dte:Frases>
					<dte:Frase CodigoEscenario=" & Chr(34) & "1" & Chr(34) & " TipoFrase=" & Chr(34) & "1" & Chr(34) & "/>
				</dte:Frases>
				<dte:Items>
					<dte:Item BienOServicio=" & Chr(34) & "B" & Chr(34) & " NumeroLinea=" & Chr(34) & "1" & Chr(34) & ">
						<dte:Cantidad>1.00</dte:Cantidad>
						<dte:UnidadMedida>UNI</dte:UnidadMedida>
						<dte:Descripcion>FACTURA DE PRUEBA</dte:Descripcion>
						<dte:PrecioUnitario>100.00</dte:PrecioUnitario>
						<dte:Precio>100.00</dte:Precio>
						<dte:Descuento>0.00</dte:Descuento>
						<dte:Impuestos>
							<dte:Impuesto>
								<dte:NombreCorto>IVA</dte:NombreCorto>
								<dte:CodigoUnidadGravable>1</dte:CodigoUnidadGravable>
								<dte:MontoGravable>89.29</dte:MontoGravable>
								<dte:MontoImpuesto>10.71</dte:MontoImpuesto>
							</dte:Impuesto>
						</dte:Impuestos>
						<dte:Total>100.00</dte:Total>
					</dte:Item>
				</dte:Items>
				<dte:Totales>
					<dte:TotalImpuestos>
						<dte:TotalImpuesto NombreCorto=" & Chr(34) & "IVA" & Chr(34) & " TotalMontoImpuesto=" & Chr(34) & "10.71" & Chr(34) & "/>
					</dte:TotalImpuestos>
					<dte:GranTotal>100.00</dte:GranTotal>
				</dte:Totales>
			</dte:DatosEmision>
		</dte:DTE>
	</dte:SAT>
</dte:GTDocumento>]]> 
</xml_dte>
</FirmaDocumentoRequest>"


        Dim xml = "<?xml version='1.0' encoding='UTF-8'?>
                     <SolicitaTokenRequest>
                    <usuario>83466371</usuario>
                    <apikey>WEl3Zdf9qbKc8mulE0SRK5j</apikey>
                    </SolicitaTokenRequest>"


        Dim url = "https://dev2.api.ifacere-fel.com/api/solicitarToken"
        Dim urlFirma = "https://dev.api.soluciones-mega.com/api/solicitaFirma"


        'Dim res = postXMLData(url, xml)
        Dim res = postXMLDataAuth(urlFirma, dte)
        MsgBox(res)
    End Sub


    Public Function postXMLDataAuth(ByVal destinationUrl As String, ByVal requestXml As String) As String

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        Dim request As HttpWebRequest = CType(WebRequest.Create(destinationUrl), HttpWebRequest)
        Dim bytes As Byte()
        bytes = Encoding.ASCII.GetBytes(requestXml)
        request.ContentType = "application/xml"
        request.Accept = "application/xml"
        request.ContentLength = bytes.Length
        request.Method = "POST"
        request.Headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjYzNjA3MDkxLCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiJkZmZhYTJkNS01YTM1LTQ2NTYtYjMyMS1iYzU0Y2E2NDBkYTkiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.K4nODaoSRTQ2rPTLhXl_cw_aQ0bbZxP2hpf9_G7EnJ7wVdvkn6gXNgy1sqF74Gb8wFm2Rbhb3oIs1XWTz5llteJtNyYyrF4PbpMF5DAb9_ytg4mtQF92aonZ5jmKLUEyVwpLhhXa6s2YyuLHi0NlLJTpB0MSS1jYUlsAuUcpO0ojwVirXnWaUbp8wtV4smB5sw9CkoMgqpF8ZX4b6xk1SHHJYljf0f-vieNsZoV_GglUSujoShCpwqHbDO5s3lbCCb8qEb4rmmDAecJOKklSNMmumgu6O2wn88weybnsa7cyUzLvUPpCWgMrqshDCRkgNLx6_mxHI_bTav9_tjpFEA")
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