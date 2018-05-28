Imports System.Data.SqlClient

Public Class frm_Login
    Dim Staffs As New List(Of Staff)
    Dim Loading As Boolean = False
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
        Worker_Login.RunWorkerAsync()
    End Sub

    Sub EnableControls()
        txt_Username.Enabled = True
        txt_Password.Enabled = True
        btn_Login.Enabled = True
        btn_ServerSettings.Enabled = True
        ControlBox = True
    End Sub
    Sub DisableControls()
        txt_Username.Enabled = False
        txt_Password.Enabled = False
        btn_Login.Enabled = False
        btn_ServerSettings.Enabled = False
        ControlBox = False
    End Sub
    Private Sub Worker_Login_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_Login.DoWork
        DisableControls()
        Me.Cursor = Cursors.WaitCursor
        Try
            If txt_Username.SelectedIndex > -1 Then
                ErrorProvider.ClearErrors()
                Dim connection As SqlConnection = GetConnection()
                If (connection.State = ConnectionState.Closed) Then connection.Open()
                Dim Staff As Staff = Staffs.Find(Function(c) c.Username = txt_Username.Text)
                If Staff IsNot Nothing Then
                    Dim cmd2 As New SqlCommand("SELECT COUNT(*) FROM Staffs WHERE Username = @Username AND Password = @Password", connection)
                    cmd2.Parameters.Add(New SqlParameter("@Username", txt_Username.Text.Trim.ToLower))
                    cmd2.Parameters.Add(New SqlParameter("@Password", EncryptString(txt_Password.Text)))
                    Dim count2 As Integer = cmd2.ExecuteScalar
                    If count2 = 1 Then
                        Try
                            Me.Invoke(Sub()
                                          Loading = True
                                          Dim d As New frm_Main(Staff)
                                          d.Show()
                                          Me.Close()
                                      End Sub)
                        Catch ex As Exception

                        End Try
                    Else
                        ErrorProvider.SetIconAlignment(txt_Password, ErrorIconAlignment.MiddleRight)
                        ErrorProvider.SetError(txt_Password, "Invalid password!")
                    End If
                Else
                    ErrorProvider.SetIconAlignment(txt_Username, ErrorIconAlignment.MiddleRight)
                    ErrorProvider.SetError(txt_Username, "Invalid username!")
                End If
                connection.Close()
            End If
        Catch ex As Exception
            ShowError(ex)
        End Try
        Me.Cursor = Cursors.Default
        EnableControls()
    End Sub

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Try
            Staffs = GetStaffs(False)
            For Each i As Staff In Staffs
                txt_Username.Properties.Items.Add(i.Username)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub frm_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Loading Then End
    End Sub
End Class
