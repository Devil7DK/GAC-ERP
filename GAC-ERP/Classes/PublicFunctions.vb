Module PublicFunctions
    Private ReadOnly Key() As Byte = {68, 101, 118, 105, 108, 55, 68, 75, 64, 71, 65, 67, 45, 69, 82, 80, 45, 50, 48, 49, 56, 95, 49, 57}
    Private ReadOnly IV() As Byte = {8, 7, 6, 5, 4, 3, 2, 1}
    Private ReadOnly crypt As New TripleDES(Key, IV)

    Public Function EncryptString(ByVal Text As String) As String
        Return System.Text.Encoding.Unicode.GetString(crypt.Encrypt(System.Text.Encoding.Unicode.GetBytes(Text)))
    End Function
    Public Function DecryptString(ByVal Text As String) As String
        Return System.Text.Encoding.Unicode.GetString(crypt.Decrypt(System.Text.Encoding.Unicode.GetBytes(Text)))
    End Function
End Module
