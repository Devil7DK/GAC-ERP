Imports DevExpress.XtraEditors.Controls

Public Class frm_AdmissionFeesDFC
    Private Sub frm_AdmissionFeesDFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = True
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
        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.Invoke(Sub()
                      Cursor = Cursors.WaitCursor
                      txt_Status.Visible = True
                  End Sub)
        Try
            Dim D As New DFC(txt_FromDate.DateTime, txt_ToDate.DateTime, txt_FilePath.EditValue)
            AddHandler D.StatusChanged, AddressOf DFC_StatusChanged
            AddHandler D.Completed, AddressOf DFC_Completed
            D.GenerateReport()
        Catch ex As Exception
            Me.Invoke(Sub()
                          MsgBox(ex.Message & vbNewLine & vbNewLine & ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                      End Sub)
        End Try
        Me.Invoke(Sub()
                      txt_Status.Visible = False
                      txt_Progress_Determidiate.Visible = False
                      txt_Progress_Indermidiate.Visible = False
                      Cursor = Cursors.Arrow
                  End Sub)
    End Sub
    Sub DFC_StatusChanged(ByVal e As EventArgs, ByVal StatusText As String, ByVal Progress As Integer, ByVal isIndeterminate As Boolean)
        Try
            Me.Invoke(Sub()
                          If isIndeterminate Then
                              txt_Progress_Indermidiate.Visible = True
                              txt_Progress_Determidiate.Visible = False
                          Else
                              txt_Progress_Indermidiate.Visible = False
                              txt_Progress_Determidiate.Visible = True
                              txt_Progress_Determidiate.Position = Progress
                              txt_Progress_Determidiate.Update()
                          End If
                          txt_Status.Text = StatusText
                      End Sub)
        Catch ex As Exception

        End Try
    End Sub
    Sub DFC_Completed(ByVal e As EventArgs, ByVal Status As DFC.Status)
        Me.Invoke(Sub()
                      If Status = DFC.Status.Success Then
                          MsgBox("Report successfully saved to selected path.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                      Else
                          MsgBox("There is no data found between given dates.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                      End If
                  End Sub)
    End Sub
End Class