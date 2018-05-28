Imports DevExpress.XtraBars

Public Class frm_AdmissionList_View
    Private LoadingData As Boolean = False
    Private Loaded As Boolean = False
    Private Courses As List(Of Course)
    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        If Not Worker_LoadData.IsBusy Then
            Worker_LoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub frm_AdmissionList_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Worker_LoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_LoadData.DoWork
        LoadingData = True
        Me.Cursor = Cursors.WaitCursor
        Dim t As New Stopwatch
        t.Start()
        Try
            Dim entries As List(Of AdmissionEntry) = GetAdmissionEntries(False)
            Courses = GetCoureses(False)
            gc_AdmissionEntries.DataSource = entries
            gc_AdmissionEntries.RefreshDataSource()
            t.Stop()
            ReleaseMemory()
            MsgBox(entries.Count & " Records loaded in " & t.Elapsed.Minutes & " minutes and " & t.Elapsed.Seconds & " seconds.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        Catch ex As Exception
            If t.IsRunning Then t.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try
        Try
            Dim XML_Path As String = GetProvisionalSlipPrinterSettingsPath()
            Dim fi As New System.IO.FileInfo(XML_Path)
            If fi.Exists Then
                Try
                    ProvisionalSlip_Printer.Settings = ProvisionalAdmissionSlipPrinterSettings.ReadFile(XML_Path)
                Catch ex As Exception

                End Try
            Else
                ProvisionalSlip_Printer.Settings = New ProvisionalAdmissionSlipPrinterSettings
            End If
        Catch ex As Exception

        End Try
        Me.Cursor = Cursors.Arrow
        LoadingData = False
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Remove.ItemClick
        If (Not LoadingData) AndAlso gv_AdmissionEntries.SelectedRowsCount > 0 Then
            If MessageBox.Show("Do you really want to delete " & gv_AdmissionEntries.SelectedRowsCount & " record(s)..?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim Deleted As Integer = 0
                Dim Errors As Integer = 0
                LoadingData = True
                For Each i As Integer In gv_AdmissionEntries.GetSelectedRows
                    Dim f As AdmissionEntry = gv_AdmissionEntries.GetRow(i)
                    Dim r As Integer = DeleteAdmissionEntry(f.ID)
                    If r > 0 Then
                        CType(gc_AdmissionEntries.DataSource, List(Of AdmissionEntry)).Remove(f)
                        Deleted += 1
                    Else
                        Errors += 1
                    End If
                Next
                If Deleted > 0 AndAlso Errors = 0 Then
                    MsgBox(Deleted & " record(s) successfully removed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                ElseIf Deleted > 0 AndAlso Errors > 0
                    MsgBox(Deleted & " record(s) successfully removed and unable to remove " & Errors & " record(s).", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Done")
                ElseIf Deleted = 0 AndAlso Errors > 0 Then
                    MsgBox("Unable to remove records.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End If
                gc_AdmissionEntries.RefreshDataSource()
                LoadingData = False
            End If
        End If
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print.ItemClick
        If gv_AdmissionEntries.SelectedRowsCount > 0 Then
            Dim AdmissionEntries As New List(Of AdmissionEntry)
            For Each i As Integer In gv_AdmissionEntries.GetSelectedRows
                AdmissionEntries.Add(gv_AdmissionEntries.GetRow(i))
            Next
            ProvisionalSlip_Printer.Courses = Courses
            ProvisionalSlip_Printer.AdmissionEntries = AdmissionEntries
            If ProvisionalSlip_PrintDialog.ShowDialog = DialogResult.OK Then
                ProvisionalSlip_Printer.Print()
            End If
        End If
    End Sub

    Private Sub btn_PrintPreview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_PrintPreview.ItemClick
        If gv_AdmissionEntries.SelectedRowsCount > 0 Then
            Dim AdmissionEntries As New List(Of AdmissionEntry)
            For Each i As Integer In gv_AdmissionEntries.GetSelectedRows
                AdmissionEntries.Add(gv_AdmissionEntries.GetRow(i))
            Next
            ProvisionalSlip_Printer.Courses = Courses
            ProvisionalSlip_Printer.AdmissionEntries = AdmissionEntries
            Dim d As New PrintPreviewDialogEx(Me)
            d.Document = ProvisionalSlip_Printer
            d.ShowDialog()
        End If
    End Sub

    Private Sub frm_AdmissionList_View_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not Loaded Then
            Loaded = True
            Worker_LoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Edit.ItemClick
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            Dim d As New frm_AdmissionList_Add_Edit(gv_AdmissionEntries.GetRow(gv_AdmissionEntries.GetSelectedRows(0)))
            d.ShowDialog()
        End If
    End Sub
End Class