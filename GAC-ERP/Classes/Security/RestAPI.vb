Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Web.Script.Serialization

Public Class RestAPI
    Private BaseURL As String = "https://gacerp-e7c7.restdb.io/"
    Private API_KEY As String = "4a25d6f3da4ec1be0c633ddcfacefc1d81277"
    Private CollectionName As String = "constantants"
    Private ValueName As String = "ServerSettings"
    Private ValueID As String = "5b0d67402d16123c00009bf1"
    Sub AddNew(ServerAddress As String, DatabaseName As String, UserName As String, Password As String)
        Try
            Dim client As HttpClient = New HttpClient()
            client.BaseAddress = New Uri(BaseURL)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            client.DefaultRequestHeaders.CacheControl = New CacheControlHeaderValue With {.NoCache = True}
            client.DefaultRequestHeaders.Add("x-apikey", API_KEY)
            Dim response = client.PostAsync("rest/" & CollectionName, New StringContent(New DataVariable(ValueName, Encryption.Encrypt(New ServerSettings(ServerAddress, DatabaseName, UserName, Encryption.Encrypt(Password)).ToJSon)).ToJSon, System.Text.Encoding.UTF8, "application/json")).Result
            If response.IsSuccessStatusCode Then
                MsgBox("Server Settings Successfully Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
            Else
                MsgBox("Error Code" & response.StatusCode & " : Message - " + response.ReasonPhrase, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Function UpdateSettings(ServerAddress As String, DatabaseName As String, UserName As String, Password As String) As Boolean
        Try
            Dim client As HttpClient = New HttpClient()
            client.BaseAddress = New Uri(BaseURL)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            client.DefaultRequestHeaders.CacheControl = New CacheControlHeaderValue With {.NoCache = True}
            client.DefaultRequestHeaders.Add("x-apikey", API_KEY)
            Dim response = client.PutAsync(String.Format("rest/{0}/{1}", CollectionName, ValueID), New StringContent(New DataVariable(ValueName, Encryption.Encrypt(New ServerSettings(ServerAddress, DatabaseName, UserName, Encryption.Encrypt(Password)).ToJSon)).ToJSon, System.Text.Encoding.UTF8, "application/json")).Result
            If response.IsSuccessStatusCode Then
                MsgBox("Server Settings Successfully Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Return True
            Else
                MsgBox("Error Code" & response.StatusCode & " : Message - " + response.ReasonPhrase, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return False
    End Function
    Function GetSettings() As ServerSettings
        Try
            Dim client As HttpClient = New HttpClient()
            client.BaseAddress = New Uri(BaseURL)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
            client.DefaultRequestHeaders.CacheControl = New CacheControlHeaderValue With {.NoCache = True}
            client.DefaultRequestHeaders.Add("x-apikey", API_KEY)
            Dim response = client.GetAsync(String.Format("rest/{0}/{1}", CollectionName, ValueID)).Result
            If response.IsSuccessStatusCode Then
                Return ServerSettings.ParseJSon(Encryption.Decrypt(DataVariable.ParseJSon(response.Content.ReadAsStringAsync().Result).value))
            Else
                MsgBox("Error Code" & response.StatusCode & " : Message - " + response.ReasonPhrase, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return Nothing
    End Function
    Public Class DataVariable
        Property name As String
        Property value As String
        Sub New()
        End Sub
        Sub New(Name As String, Value As String)
            Me.name = Name
            Me.value = Value
        End Sub
        Function ToJSon() As String
            Return New JavaScriptSerializer().Serialize(Me)
        End Function
        Public Shared Function ParseJSon(JSON As String) As DataVariable
            Return New JavaScriptSerializer().Deserialize(Of DataVariable)(JSON)
        End Function
    End Class
End Class
