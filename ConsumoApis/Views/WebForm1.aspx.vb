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

        Dim dte = "<dte:GTDocumento xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " Version=" & Chr(34) & "0.1" & Chr(34) & ">
    <dte:SAT xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " ClaseDocumento=" & Chr(34) & "dte" & Chr(34) & ">
        <dte:DTE xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " ID=" & Chr(34) & "DatosCertificados" & Chr(34) & ">
            <dte:DatosEmision xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " ID=" & Chr(34) & "DatosEmision" & Chr(34) & ">
                <dte:DatosGenerales xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " CodigoMoneda=" & Chr(34) & "GTQ" & Chr(34) & " FechaHoraEmision=" & Chr(34) & "2022-06-17T11:33:14.000-06:00" & Chr(34) & " Tipo=" & Chr(34) & "FACT" & Chr(34) & "/>
                <dte:Emisor xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " AfiliacionIVA=" & Chr(34) & "GEN" & Chr(34) & " CodigoEstablecimiento=" & Chr(34) & "1" & Chr(34) & " CorreoEmisor=" & Chr(34) & "" & Chr(34) & " NITEmisor=" & Chr(34) & "83466371" & Chr(34) & " NombreComercial=" & Chr(34) & "D'MOSOFT" & Chr(34) & " NombreEmisor=" & Chr(34) & "DESARROLLO MODERNO DE SOFTWARE, SOCIEDAD ANONIMA" & Chr(34) & ">
                    <dte:DireccionEmisor xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                        <dte:Direccion>   CIUDAD DE GUATEMALA  Guatemala, GUATEMALA</dte:Direccion>
                        <dte:CodigoPostal>0</dte:CodigoPostal>
                        <dte:Municipio>Guatemala</dte:Municipio>
                        <dte:Departamento>GUATEMALA</dte:Departamento>
                        <dte:Pais>GT</dte:Pais>
                    </dte:DireccionEmisor>
                </dte:Emisor>
                <dte:Receptor xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " CorreoReceptor=" & Chr(34) & "" & Chr(34) & " IDReceptor=" & Chr(34) & "96874996" & Chr(34) & " NombreReceptor=" & Chr(34) & "INNOVACIONES MAUFLO S. A" & Chr(34) & ">
                    <dte:DireccionReceptor xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                        <dte:Direccion>CIUDAD</dte:Direccion>
                        <dte:CodigoPostal>01007</dte:CodigoPostal>
                        <dte:Municipio>Guatemala</dte:Municipio>
                        <dte:Departamento>Guatemala</dte:Departamento>
                        <dte:Pais>GT</dte:Pais>
                    </dte:DireccionReceptor>
                </dte:Receptor>
                <dte:Frases xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                    <dte:Frase CodigoEscenario=" & Chr(34) & "1" & Chr(34) & " TipoFrase=" & Chr(34) & "1" & Chr(34) & " />
                </dte:Frases>
                <dte:Items xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                    <dte:Item NumeroLinea=" & Chr(34) & "1" & Chr(34) & " BienOServicio=" & Chr(34) & "B" & Chr(34) & ">
                        <dte:Cantidad>360.0000</dte:Cantidad>
                        <dte:UnidadMedida>UND</dte:UnidadMedida>
                        <dte:Descripcion>830000|TAZA 11OZ BLANCA (PARA SUBLIMACIÓN)</dte:Descripcion>
                        <dte:PrecioUnitario>6.7500</dte:PrecioUnitario>
                        <dte:Precio>2430.0000</dte:Precio>
                        <dte:Descuento>0</dte:Descuento>
                        <dte:Impuestos xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                            <dte:Impuesto>
                                <dte:NombreCorto>IVA</dte:NombreCorto>
                                <dte:CodigoUnidadGravable>1</dte:CodigoUnidadGravable>
                                <dte:MontoGravable>2169.64</dte:MontoGravable>
                                <dte:MontoImpuesto>260.3571</dte:MontoImpuesto>
                            </dte:Impuesto>
                        </dte:Impuestos>
                        <dte:Total>2430</dte:Total>
                    </dte:Item>
                    <dte:Item NumeroLinea=" & Chr(34) & "2" & Chr(34) & " BienOServicio=" & Chr(34) & "B" & Chr(34) & ">
                        <dte:Cantidad>72.0000</dte:Cantidad>
                        <dte:UnidadMedida>UND</dte:UnidadMedida>
                        <dte:Descripcion>834301|TAZA BLANCA 11 OZ CON ASA DE CORAZON</dte:Descripcion>
                        <dte:PrecioUnitario>10.0000</dte:PrecioUnitario>
                        <dte:Precio>720.0000</dte:Precio>
                        <dte:Descuento>0</dte:Descuento>
                        <dte:Impuestos xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                            <dte:Impuesto>
                                <dte:NombreCorto>IVA</dte:NombreCorto>
                                <dte:CodigoUnidadGravable>1</dte:CodigoUnidadGravable>
                                <dte:MontoGravable>642.857</dte:MontoGravable>
                                <dte:MontoImpuesto>77.1429</dte:MontoImpuesto>
                            </dte:Impuesto>
                        </dte:Impuestos>
                        <dte:Total>720</dte:Total>
                    </dte:Item>
                    <dte:Item NumeroLinea=" & Chr(34) & "3" & Chr(34) & " BienOServicio=" & Chr(34) & "B" & Chr(34) & ">
                        <dte:Cantidad>1.0000</dte:Cantidad>
                        <dte:UnidadMedida>UND</dte:UnidadMedida>
                        <dte:Descripcion>931100|CINTA-SUBLIMABLES-1-50YD-BLANCA (LANYARD)</dte:Descripcion>
                        <dte:PrecioUnitario>71.0000</dte:PrecioUnitario>
                        <dte:Precio>71.0000</dte:Precio>
                        <dte:Descuento>0</dte:Descuento>
                        <dte:Impuestos xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                            <dte:Impuesto>
                                <dte:NombreCorto>IVA</dte:NombreCorto>
                                <dte:CodigoUnidadGravable>1</dte:CodigoUnidadGravable>
                                <dte:MontoGravable>63.3929</dte:MontoGravable>
                                <dte:MontoImpuesto>7.6071</dte:MontoImpuesto>
                            </dte:Impuesto>
                        </dte:Impuestos>
                        <dte:Total>71</dte:Total>
                    </dte:Item>
                    <dte:Item NumeroLinea=" & Chr(34) & "4" & Chr(34) & " BienOServicio=" & Chr(34) & "B" & Chr(34) & ">
                        <dte:Cantidad>1.0000</dte:Cantidad>
                        <dte:UnidadMedida>UND</dte:UnidadMedida>
                        <dte:Descripcion>931000|CINTA-SUBLIMABLES-3/4-50YD-BLANCA (LANYARD)</dte:Descripcion>
                        <dte:PrecioUnitario>56.0000</dte:PrecioUnitario>
                        <dte:Precio>56.0000</dte:Precio>
                        <dte:Descuento>0</dte:Descuento>
                        <dte:Impuestos xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                            <dte:Impuesto>
                                <dte:NombreCorto>IVA</dte:NombreCorto>
                                <dte:CodigoUnidadGravable>1</dte:CodigoUnidadGravable>
                                <dte:MontoGravable>50</dte:MontoGravable>
                                <dte:MontoImpuesto>6.0000</dte:MontoImpuesto>
                            </dte:Impuesto>
                        </dte:Impuestos>
                        <dte:Total>56</dte:Total>
                    </dte:Item>
                </dte:Items>
                <dte:Totales xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                    <dte:TotalImpuestos xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & ">
                        <dte:TotalImpuesto NombreCorto=" & Chr(34) & "IVA" & Chr(34) & " TotalMontoImpuesto=" & Chr(34) & "351.1071" & Chr(34) & " />
                    </dte:TotalImpuestos>
                    <dte:GranTotal>3277.00</dte:GranTotal>
                </dte:Totales>
            </dte:DatosEmision>
        </dte:DTE>
    </dte:SAT>
</dte:GTDocumento>"

        Dim xmlBody = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?> 
<FirmaDocumentoRequest id=" & Chr(34) & "EAFAC23F-C30C-4F98-A953-09415A9B9947" & Chr(34) & ">
<xml_dte><![CDATA[{body}]]> 
</xml_dte>
</FirmaDocumentoRequest>"

        Dim xml = "<?xml version='1.0' encoding='UTF-8'?>
                     <SolicitaTokenRequest>
                    <usuario>83466371</usuario>
                    <apikey>WEl3Zdf9qbKc8mulE0SRK5j</apikey>
                    </SolicitaTokenRequest>"

        xmlBody = xmlBody.Replace("{body}", dte)


        Dim url = "https://dev2.api.ifacere-fel.com/api/solicitarToken"



        Dim urlFirma = "https://dev.api.soluciones-mega.com/api/solicitaFirma"

        Dim urlUnificado = "https://localhost:7156/api/MegaPrint/Certifica"

        Dim token = "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjYzODUyNjA2LCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiI4YTk0NWE1OS0yMWY3LTQ3OGEtYjA0Zi1iMDljZDk4NWUwMjkiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.LlGcIoysSQjrjVRQ4CdnbgKEGn8xlAbLQek1f4_dHyre-ifPGp9MOS32DhAlhdGAzcptllprZyi-MdeLmHAyFnFEhGXPGqCe9Ku-sJsmDLzlfYzK0FTLt9b4bkoz93cOHqOp6j-Kr3LMpd4Un3NO_3APhsfOlqZKL24uwSrHl7TAqWGYHXGsiX8uPqkcY4y537OKgY_kbzNSUQ4s6Co_JXZv2lixQh-1VVUMSSKCLA89cOJu2D4H3t1CE-wBlIxGRhWfegoyTstznM-zmjMFHE1SvtYqiZU-4ZkZn-6WPiSn0HYehKkOZdphcL8I6dICGU6mg5psuoTcH8UAqpUyUg"

        'Dim res = postXMLData(url, xml)
        'Dim res = postXMLDataAuth(urlFirma, xmlBody)
        Dim res = postJsonBody(token, urlUnificado, xmlBody)


        MsgBox(res)
    End Sub


    Public Function postJsonBody(ByVal token, ByVal url, ByVal body) As String

        Dim requestApi = CType(WebRequest.Create(url), HttpWebRequest)
        Dim Obj = New Dictionary(Of String, Object) From {
            {"token", token},
            {"body", body},
            {"uiid", "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270"}
        }

        Dim strCuenta = JsonConvert.SerializeObject(Obj)
        requestApi.Method = "POST"
        requestApi.ContentType = "application/json"
        requestApi.Accept = "application/json"


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
                        MsgBox(response)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Return "Can't load Web api" & vbCrLf & ex.Message
        End Try

    End Function


    Public Function postXMLDataAuth(ByVal destinationUrl As String, ByVal requestXml As String) As String

        ServicePointManager.SecurityProtocol = CType((768 Or 3072), SecurityProtocolType)

        Dim request As HttpWebRequest = CType(WebRequest.Create(destinationUrl), HttpWebRequest)
        Dim bytes As Byte()
        bytes = Encoding.ASCII.GetBytes(requestXml)
        request.ContentType = "application/xml"
        request.Accept = "application/xml"
        request.ContentLength = bytes.Length
        request.Method = "POST"
        request.Headers.Add("Authorization", "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjYzODUyNjA2LCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiI4YTk0NWE1OS0yMWY3LTQ3OGEtYjA0Zi1iMDljZDk4NWUwMjkiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.LlGcIoysSQjrjVRQ4CdnbgKEGn8xlAbLQek1f4_dHyre-ifPGp9MOS32DhAlhdGAzcptllprZyi-MdeLmHAyFnFEhGXPGqCe9Ku-sJsmDLzlfYzK0FTLt9b4bkoz93cOHqOp6j-Kr3LMpd4Un3NO_3APhsfOlqZKL24uwSrHl7TAqWGYHXGsiX8uPqkcY4y537OKgY_kbzNSUQ4s6Co_JXZv2lixQh-1VVUMSSKCLA89cOJu2D4H3t1CE-wBlIxGRhWfegoyTstznM-zmjMFHE1SvtYqiZU-4ZkZn-6WPiSn0HYehKkOZdphcL8I6dICGU6mg5psuoTcH8UAqpUyUg")
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