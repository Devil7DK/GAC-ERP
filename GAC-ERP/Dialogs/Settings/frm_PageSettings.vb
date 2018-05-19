Public Class frm_PageSettings
    Private Sub frm_PageSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_TopMargin.Value = My.Settings.ProvisonalSlip_TopMargin
        txt_BottomMargin.Value = My.Settings.ProvisonalSlip_BottomMargin
        txt_LeftMargin.Value = My.Settings.ProvisonalSlip_LeftMargin
        txt_RightMargin.Value = My.Settings.ProvisonalSlip_RightMargin
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        My.Settings.ProvisonalSlip_TopMargin = txt_TopMargin.Value
        My.Settings.ProvisonalSlip_BottomMargin = txt_BottomMargin.Value
        My.Settings.ProvisonalSlip_RightMargin = txt_RightMargin.Value
        My.Settings.ProvisonalSlip_LeftMargin = txt_LeftMargin.Value
        My.Settings.Save()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class