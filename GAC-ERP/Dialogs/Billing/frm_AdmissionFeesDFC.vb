Imports DevExpress.XtraEditors.Controls

Public Class frm_AdmissionFeesDFC
    Private Sub frm_AdmissionFeesDFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_FromDate.DateTime = Now
        txt_ToDate.DateTime = Now
        txt_FilePath.EditValue = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, "Admission Fees - DFC.xlsx")
    End Sub

    Private Sub txt_FilePath_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txt_FilePath.ButtonClick
        dlg_Save.FileName = txt_FilePath.EditValue
        If dlg_Save.ShowDialog = DialogResult.OK Then
            txt_FilePath.EditValue = dlg_Save.FileName
        End If
    End Sub

    Private Sub btn_Generate_Click(sender As Object, e As EventArgs) Handles btn_Generate.Click
        Dim D As New DFC(txt_FromDate.DateTime, txt_ToDate.DateTime, txt_FilePath.EditValue)
        D.GenerateReport()
    End Sub
End Class