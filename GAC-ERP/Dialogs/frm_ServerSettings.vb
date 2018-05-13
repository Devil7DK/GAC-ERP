Imports System.Data.SqlClient

Public Class frm_ServerSettings
    Private Sub frm_ServerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Server.Text = My.Settings.Server
        txt_Username.Text = My.Settings.Username
        txt_Password.Text = If(My.Settings.Password <> "", DecryptString(My.Settings.Password), "")
        txt_Database.Text = My.Settings.Database
        cb_Pooling.Checked = My.Settings.Pooling
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        My.Settings.Server = txt_Server.Text
        My.Settings.Username = txt_Username.Text
        My.Settings.Password = EncryptString(txt_Password.Text)
        My.Settings.Database = txt_Database.Text
        My.Settings.Pooling = cb_Pooling.Checked
        My.Settings.Save()
        MsgBox("Server settings saved successfully.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub btn_TestConnection_Click(sender As Object, e As EventArgs) Handles btn_TestConnection.Click
        Try
            Dim connection As New SqlConnection(String.Format("Server={0};Initial Catalog={1};User ID={2};Password={3};Pooling={4};", txt_Server.Text, txt_Database.Text, txt_Username.Text, txt_Password.Text, If(cb_Pooling.Checked, "true", "false")))

            If connection.State = ConnectionState.Closed Then
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
                MsgBox("Connection working perfectly.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Test completed")
            End If
        Catch ex As Exception
            MsgBox("Connection not working.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Test completed")
        End Try
    End Sub
End Class