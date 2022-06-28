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


        Dim dte = "<dte:GTDocumento xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " Version=" & Chr(34) & "0.1" & Chr(34) & ">
    <dte:SAT xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " ClaseDocumento=" & Chr(34) & "dte" & Chr(34) & ">
        <dte:DTE xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " ID=" & Chr(34) & "DatosCertificados" & Chr(34) & ">
            <dte:DatosEmision xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " ID=" & Chr(34) & "DatosEmision" & Chr(34) & ">
                <dte:DatosGenerales xmlns:dte=" & Chr(34) & "http://www.sat.gob.gt/dte/fel/0.2.0" & Chr(34) & " CodigoMoneda=" & Chr(34) & "GTQ" & Chr(34) & " FechaHoraEmision=" & Chr(34) & "2022-06-27T11:33:14.000-06:00" & Chr(34) & " Tipo=" & Chr(34) & "FACT" & Chr(34) & "/>
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

        xmlBody = xmlBody.Replace("{body}", documento.xml_Contenido)


        Dim url = "https://dev2.api.ifacere-fel.com/api/solicitarToken"

        Dim urlFirma = "https://dev.api.soluciones-mega.com/api/solicitaFirma"

        Dim urlUnificado = "http://localhost:9096/api/MegaPrint/Certifica"

        Dim token = "Bearer eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcGVuaWQiXSwiZXhwIjoxNjYzODUyNjA2LCJhdXRob3JpdGllcyI6WyJST0xFX0VNSVNPUiJdLCJqdGkiOiI4YTk0NWE1OS0yMWY3LTQ3OGEtYjA0Zi1iMDljZDk4NWUwMjkiLCJjbGllbnRfaWQiOiI4MzQ2NjM3MSJ9.LlGcIoysSQjrjVRQ4CdnbgKEGn8xlAbLQek1f4_dHyre-ifPGp9MOS32DhAlhdGAzcptllprZyi-MdeLmHAyFnFEhGXPGqCe9Ku-sJsmDLzlfYzK0FTLt9b4bkoz93cOHqOp6j-Kr3LMpd4Un3NO_3APhsfOlqZKL24uwSrHl7TAqWGYHXGsiX8uPqkcY4y537OKgY_kbzNSUQ4s6Co_JXZv2lixQh-1VVUMSSKCLA89cOJu2D4H3t1CE-wBlIxGRhWfegoyTstznM-zmjMFHE1SvtYqiZU-4ZkZn-6WPiSn0HYehKkOZdphcL8I6dICGU6mg5psuoTcH8UAqpUyUg"



        'Dim res = postXMLData(url, xml)
        'Dim res = postXMLDataAuth(urlFirma, xmlBody)
        Dim res = postJsonBody(token, urlUnificado, xmlBody)

        'Dim res = getDataApis(token)
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

                Dim paramValue = replaceValues(parametro.plantilla, token)


                'Config ContentType 5 Json 6 xml 
                If parametro.tipo_Dato = 6 Then
                    'ContentType
                    request.ContentType = "application/xml"

                    'Add param to body api
                    Dim bytes As Byte()
                    bytes = Encoding.ASCII.GetBytes(paramValue)
                    request.ContentLength = bytes.Length

                    Dim streamXml As Stream = request.GetRequestStream()
                    streamXml.Write(bytes, 0, bytes.Length)
                    streamXml.Close()

                Else
                    'ContentType
                    request.ContentType = "application/json"

                    'Add param to body api
                    Using streamWriterJson = New StreamWriter(request.GetRequestStream())
                        streamWriterJson.Write(paramValue)
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

    Public Function replaceValues(ByVal param As String, ByVal token As String) As String



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


    Public Function postJsonBody(ByVal token, ByVal url, ByVal body) As String



        Dim Obj = New Dictionary(Of String, Object) From {
            {"token", token},
            {"body", body},
            {"uiid", "6C27FF05-5BAF-47E5-8A1C-2F67B5FDE270"}
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