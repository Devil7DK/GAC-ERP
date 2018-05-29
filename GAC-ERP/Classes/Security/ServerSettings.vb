Imports System.Web.Script.Serialization

Public Class ServerSettings
    Property ServerAddress As String
    Property DatabaseName As String
    Property UserName As String
    Property Password As String
    Sub New()
    End Sub
    Sub New(ServerAddress As String, DatabaseName As String, UserName As String, Password As String)
        Me.ServerAddress = ServerAddress
        Me.DatabaseName = DatabaseName
        Me.UserName = UserName
        Me.Password = Password
    End Sub
    Function ToJSon() As String
        Return New JavaScriptSerializer().Serialize(Me)
    End Function
    Public Shared Function ParseJSon(JSON As String) As ServerSettings
        Return New JavaScriptSerializer().Deserialize(Of ServerSettings)(JSON)
    End Function
End Class