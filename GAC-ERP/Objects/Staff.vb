Public Class Staff
    Property Name As String
    Property Username As String
    Property Permissions As List(Of Permission)
    Sub New()
        Name = ""
        Username = ""
        Permissions = New List(Of Permission)
    End Sub
    Sub New(ByVal Name As String, Username As String, Permissions As List(Of Permission))
        Me.Name = Name
        Me.Username = Username
        Me.Permissions = Permissions
    End Sub
    Function HasPermission(ByVal Permission As Permission) As Boolean
        If Permissions.Contains(Permission.SuperUser) Then
            Return True
        End If
        Try
            Return Permissions.Contains(Permission)
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Overrides Function ToString() As String
        Return Username
    End Function
End Class
