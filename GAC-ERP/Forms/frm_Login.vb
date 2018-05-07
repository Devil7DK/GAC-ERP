Imports System.Data.SqlClient

Public Class frm_Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_ServerSettings_Click(sender As Object, e As EventArgs) Handles btn_ServerSettings.Click
        Dim d As New frm_ServerSettings
        d.ShowDialog()
    End Sub

    Private Sub txt_Username_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Username.KeyUp
        If e.KeyCode = Keys.Enter Then
            txt_Password.Focus()
        End If
    End Sub

    Private Sub txt_Password_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Password.KeyUp
        If e.KeyCode = Keys.Enter Then
            If e.Control AndAlso e.Alt AndAlso e.Shift Then
                Dim p As String = EncryptString(txt_Password.Text)
                InputBox("Copy the encrypted string :", DefaultResponse:=p)
            Else
                btn_Login.PerformClick()
            End If
        End If
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        ErrorProvider.ClearErrors()
        Dim connection As New SqlConnection(String.Format("Server={0};Initial Catalog={1};User ID={2};Password={3};", My.Settings.Server, My.Settings.Database, My.Settings.Username, DecryptString(My.Settings.Password)))
        If (connection.State = ConnectionState.Closed) Then connection.Open()

        Dim cmd1 As New SqlCommand("SELECT COUNT(*) FROM Staffs WHERE Username = @Username", connection)
        cmd1.Parameters.Add(New SqlParameter("@Username", txt_Username.Text))
        Dim count1 As Integer = cmd1.ExecuteScalar

        If count1 = 1 Then
            Dim cmd2 As New SqlCommand("SELECT COUNT(*) FROM Staffs WHERE Username = @Username AND Password = @Password", connection)
            cmd2.Parameters.Add(New SqlParameter("@Username", txt_Username.Text))
            cmd2.Parameters.Add(New SqlParameter("@Password", EncryptString(txt_Password.Text)))
            Dim count2 As Integer = cmd2.ExecuteScalar
            If count2 = 1 Then
                'Login success
            Else
                ErrorProvider.SetIconAlignment(txt_Password, ErrorIconAlignment.MiddleRight)
                ErrorProvider.SetError(txt_Password, "Invalid password!")
            End If
        Else
            ErrorProvider.SetIconAlignment(txt_Username, ErrorIconAlignment.MiddleRight)
            ErrorProvider.SetError(txt_Username, "Invalid username!")
        End If

        connection.Close()

        Threading.Thread.Sleep(3000)

    End Sub
End Class
