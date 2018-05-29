Public Class frm_Main
    Dim API As New RestAPI
    Dim Loading As Boolean = True
    Dim Edited_ As Boolean = False
    Private Property Edited As Boolean
        Get
            Return Edited_
        End Get
        Set(value As Boolean)
            Edited_ = value
            If Not Loading Then btn_Update.Enabled = value
        End Set
    End Property
    Private Sub cb_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ShowPassword.CheckedChanged
        If Not Loading Then txt_Password.Properties.UseSystemPasswordChar = (Not cb_ShowPassword.Checked)
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Loading = True
        cb_ShowPassword.Checked = (Not txt_Password.Properties.UseSystemPasswordChar)
        Try
            Dim Settings As ServerSettings = API.GetSettings
            txt_ServerAddress.EditValue = Settings.ServerAddress
            txt_DatabaseName.EditValue = Settings.DatabaseName
            txt_Username.EditValue = Settings.UserName
            txt_Password.EditValue = Encryption.Decrypt(Settings.Password)
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Loading = False
    End Sub

    Private Sub Fields_EditValueChanged(sender As Object, e As EventArgs) Handles txt_ServerAddress.EditValueChanged, txt_DatabaseName.EditValueChanged, txt_Username.EditValueChanged, txt_Password.EditValueChanged
        If Not Loading Then Edited = True
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        If Not Worker.isBusy Then worker.RunWorkerAsync
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        If Edited Then
            Me.Invoke(Sub()
                          Me.Cursor = Cursors.WaitCursor
                          DisableControls()
                      End Sub)
            Try
                If API.UpdateSettings(txt_ServerAddress.EditValue, txt_DatabaseName.EditValue, txt_Username.EditValue, txt_Password.EditValue) Then
                    Edited = False
                End If
            Catch ex As Exception

            End Try
            Me.Invoke(Sub()
                          Me.Cursor = Cursors.Arrow
                          EnableControls()
                      End Sub)
        End If
    End Sub
    Sub EnableControls()
        txt_ServerAddress.ReadOnly = False
        txt_DatabaseName.ReadOnly = False
        txt_Username.ReadOnly = False
        txt_Password.ReadOnly = False
        cb_ShowPassword.ReadOnly = False
    End Sub
    Sub DisableControls()
        txt_ServerAddress.ReadOnly = True
        txt_DatabaseName.ReadOnly = True
        txt_Username.ReadOnly = True
        txt_Password.ReadOnly = True
        cb_ShowPassword.ReadOnly = True
    End Sub
End Class
