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

        Dim urlApis As String = "http://localhost:9095/api/User/empresa/ds"
        Dim requestApi = CType(WebRequest.Create(urlApis), HttpWebRequest)
        Dim headers As NameValueCollection = New NameValueCollection From {
    {"Authorization", "bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJ2ZW50YXMiLCJuYmYiOjE2NTUzMzAzMDUsImV4cCI6MTY4NjQzNDMwNSwiaWF0IjoxNjU1MzMwMzA1fQ.TcT7AvG06yNJM0sRpc6694_RNY71kpkMpAxRH2vJ4Ic"}
        }


        requestApi.Method = "GET"
        requestApi.ContentType = "application/json"
        requestApi.Accept = "application/json"
        requestApi.Headers.Add(headers)

        Try
            Using responseCuenta As WebResponse = requestApi.GetResponse()
                Using strReaderCuenta As Stream = responseCuenta.GetResponseStream()
                    If strReaderCuenta Is Nothing Then Return

                    Using objReaderCuenta As StreamReader = New StreamReader(strReaderCuenta)
                        Dim response As String = objReaderCuenta.ReadToEnd()
                        MsgBox(response)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Can't load Web api" & vbCrLf & ex.Message)
        End Try


    End Sub
End Class