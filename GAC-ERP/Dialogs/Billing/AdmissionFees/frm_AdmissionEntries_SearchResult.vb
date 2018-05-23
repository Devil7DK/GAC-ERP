Imports DevExpress.XtraGrid.Views.Base

Public Class frm_AdmissionEntries_SearchResult
    Dim AdmissionEntries As List(Of AdmissionEntry)
    Sub New(ByVal AdmissionEntries As List(Of AdmissionEntry))
        InitializeComponent()
        Me.AdmissionEntries = AdmissionEntries
    End Sub
    Property SelectedEntry As AdmissionEntry = Nothing
    Private Sub frm_AdmissionEntries_SearchResult_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        gc_AdmissionEntries.DataSource = AdmissionEntries
        gc_AdmissionEntries.RefreshDataSource()
    End Sub
    Private Sub gv_AdmissionEntries_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gv_AdmissionEntries.FocusedRowChanged
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            Me.SelectedEntry = gv_AdmissionEntries.GetRow(gv_AdmissionEntries.GetSelectedRows(0))
        End If
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If Me.SelectedEntry IsNot Nothing Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MsgBox("Please kindly select one entry from list.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class