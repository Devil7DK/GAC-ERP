Imports DevExpress.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Printing

Public Class frm_AdmissionList
    Dim Courses As New List(Of Course)
    Dim Loading As Boolean = False
    Dim Action As String = ""
    Dim ID As Integer = -1
    Dim Slip_Base As String
    Dim Loaded As Boolean = False
    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click
        Worker_LoadEntries.RunWorkerAsync()
    End Sub
    Sub EnableControls()
        On Error Resume Next
        grp_Controls.Enabled = True
        grp_Data.Enabled = True
        grp_Entries.Enabled = True
    End Sub
    Sub DisableControls()
        On Error Resume Next
        grp_Controls.Enabled = False
        grp_Data.Enabled = False
        grp_Entries.Enabled = False
    End Sub
    Sub DisableEditing()
        btn_New.Visible = True
        btn_Edit.Visible = True
        btn_Remove.Visible = True
        btn_Cancel.Visible = False
        btn_Save.Visible = False
        btn_Load.Enabled = True

        grp_Entries.Enabled = True
        Me.ControlBox = True

        txt_Name.ReadOnly = True
        txt_RegistrationNumber.ReadOnly = True
        txt_ApplicationNumber.ReadOnly = True
        txt_Rank.ReadOnly = True
        txt_Gender.ReadOnly = True
        txt_Community.ReadOnly = True
        txt_CutOff.ReadOnly = True
        txt_CourseID.ReadOnly = True
        txt_Stream.ReadOnly = True
        txt_Quota.ReadOnly = True
        txt_AllottedGender.ReadOnly = True
        txt_AllottedCommunity.ReadOnly = True
        txt_AllottedStream.ReadOnly = True
        cb_SpecialQuota.Enabled = False
        txt_Remarks.ReadOnly = True
    End Sub
    Sub EnableEditing()
        btn_New.Visible = False
        btn_Edit.Visible = False
        btn_Remove.Visible = False
        btn_Save.Visible = True
        btn_Cancel.Visible = True
        btn_Load.Enabled = False

        grp_Entries.Enabled = False
        Me.ControlBox = False

        txt_Name.ReadOnly = False
        txt_RegistrationNumber.ReadOnly = False
        txt_ApplicationNumber.ReadOnly = False
        txt_Rank.ReadOnly = False
        txt_Gender.ReadOnly = False
        txt_Community.ReadOnly = False
        txt_CutOff.ReadOnly = False
        txt_CourseID.ReadOnly = False
        txt_Stream.ReadOnly = False
        txt_Quota.ReadOnly = False
        txt_AllottedGender.ReadOnly = False
        txt_AllottedCommunity.ReadOnly = False
        txt_AllottedStream.ReadOnly = False
        cb_SpecialQuota.Enabled = True
        txt_Remarks.ReadOnly = False
    End Sub

    Sub ClearControls()
        Loading = True
        txt_Name.Text = ""
        txt_RegistrationNumber.Text = ""
        txt_ApplicationNumber.Text = ""
        txt_Rank.Text = ""
        txt_Gender.SelectedIndex = -1
        txt_Community.SelectedIndex = -1
        txt_CutOff.Text = ""
        txt_CourseID.EditValue = Nothing
        txt_Stream.SelectedIndex = -1
        txt_Quota.SelectedIndex = -1
        txt_AllottedGender.SelectedIndex = -1
        txt_AllottedCommunity.SelectedIndex = -1
        txt_AllottedStream.SelectedIndex = -1
        For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cb_SpecialQuota.Items
            i.CheckState = CheckState.Unchecked
        Next
        txt_Remarks.Text = ""
        Loading = False
    End Sub
    Private Sub Worker_LoadEntries_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_LoadEntries.DoWork
        Loading = True
        DisableControls()
        Me.Cursor = Cursors.WaitCursor
        Dim t As New Stopwatch
        t.Start()
        Try
            Dim entries As List(Of AdmissionEntry) = GetAdmissionEntries()
            Dim Courses = GetCoureses()
            txt_CourseID.Properties.DataSource = Courses
            txt_CourseID.Properties.ValueMember = "Code"
            txt_CourseID.Properties.DisplayMember = "Code"
            gc_AdmissionEntries.DataSource = entries
            gc_AdmissionEntries.RefreshDataSource()
            Me.Courses.AddRange(Courses.ToArray)
            t.Stop()
            ReleaseMemory()

            MsgBox(entries.Count & " Records loaded in " & t.Elapsed.Minutes & " minutes and " & t.Elapsed.Seconds & " seconds.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        Catch ex As Exception
            If t.IsRunning Then t.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try
        Me.Cursor = Cursors.Arrow
        EnableControls()
        Loading = False
    End Sub

    Private Sub frm_AdmissionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        CheckForIllegalCrossThreadCalls = False
        DisableEditing()
        Slip_Base = My.Computer.FileSystem.ReadAllText(System.IO.Path.Combine(Application.StartupPath, "Templates", "Admission_Slip_Template.rtf"))
        If Loaded = False Then
            Worker_LoadEntries.RunWorkerAsync()
            Loaded = True
        End If
    End Sub

    Private Sub txt_CourseID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CourseID.EditValueChanged
        Try
            If Loading = False Then
                If Courses.Count > 0 Then
                    Dim val As Course = Courses.Find(Function(p) p.Code = txt_CourseID.EditValue)
                    If val IsNot Nothing Then
                        txt_Course.Text = val.Name
                        txt_Department.Text = val.Department
                        txt_Shift.Text = val.Shift
                        txt_Medium.Text = val.Medium
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Gender.SelectedIndexChanged
        If Loading = False Then
            If txt_AllottedGender.SelectedIndex = -1 Then
                If txt_Gender.SelectedItem = "Male" Then
                    txt_AllottedGender.SelectedItem = "Male"
                ElseIf txt_Gender.SelectedItem = "Female" Or txt_Gender.SelectedItem = "Transgender"
                    txt_AllottedGender.SelectedItem = "Female"
                End If
            End If
        End If
    End Sub

    Private Sub txt_Community_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Community.SelectedIndexChanged
        If Loading = False Then
            Try
                If txt_Quota.SelectedIndex = -1 Then
                    txt_Quota.SelectedIndex = txt_Quota.Properties.Items.IndexOf(txt_Community.SelectedItem)
                End If
            Catch ex As Exception

            End Try
            Try
                If txt_AllottedCommunity.SelectedIndex = -1 Then
                    txt_AllottedCommunity.SelectedIndex = txt_AllottedCommunity.Properties.Items.IndexOf(txt_Community.SelectedItem)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txt_Stream_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Stream.SelectedIndexChanged
        If Loading = False Then
            Try
                If txt_AllottedStream.SelectedIndex = -1 Then
                    txt_AllottedStream.SelectedIndex = txt_AllottedStream.Properties.Items.IndexOf(txt_Stream.SelectedItem)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub gv_AdmissionEntries_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gv_AdmissionEntries.FocusedRowChanged
        If Loading = False Then
            LoadValues()
        End If
    End Sub
    Sub LoadValues()
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            Dim entry As AdmissionEntry = gv_AdmissionEntries.GetRow(gv_AdmissionEntries.GetSelectedRows(0))
            txt_Name.Text = entry.Name
            txt_RegistrationNumber.Text = entry.Registration
            txt_ApplicationNumber.Text = entry.Application
            txt_Rank.Text = entry.Rank
            txt_Gender.EditValue = entry.Gender
            txt_Community.EditValue = entry.Community
            txt_CutOff.Text = entry.CutOff
            txt_CourseID.EditValue = entry.CourseID
            txt_Stream.EditValue = entry.Stream
            txt_Quota.EditValue = entry.Quota
            txt_AllottedGender.EditValue = entry.AllottedGender
            txt_AllottedCommunity.EditValue = entry.AllottedCommunity
            txt_AllottedStream.EditValue = entry.AllottedStream
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cb_SpecialQuota.Items
                i.CheckState = CheckState.Unchecked
            Next
            For Each i As String In entry.SpecialQuota.Split(";")
                Try
                    Dim item = cb_SpecialQuota.Items.Item(i)
                    If item IsNot Nothing Then item.CheckState = CheckState.Checked
                Catch ex As Exception

                End Try
            Next
            txt_Remarks.Text = entry.Remarks
        End If
    End Sub
    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        Action = "NEW"
        EnableEditing()
        ClearControls()
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Action = ""
        ClearControls()
        DisableEditing()
        Try
            LoadValues()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If Action = "NEW" Then
            Dim DOA As Date = Now
            Dim r As Integer = NewAdmissionEntry(txt_RegistrationNumber.Text, txt_ApplicationNumber.Text, txt_Name.Text, txt_Gender.EditValue, txt_Stream.EditValue, txt_Rank.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Quota.EditValue, GetString(cb_SpecialQuota.CheckedItems), DOA, txt_CourseID.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, txt_State.EditValue)
            If r > 0 Then
                Loading = True
                CType(gc_AdmissionEntries.DataSource, List(Of AdmissionEntry)).Add(New AdmissionEntry(r, txt_Name.Text, txt_Gender.EditValue, txt_RegistrationNumber.Text, txt_Rank.Text, txt_ApplicationNumber.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Stream.EditValue, txt_Quota.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, DOA, False, 0, GetString(cb_SpecialQuota.CheckedItems), txt_CourseID.EditValue, txt_State.EditValue))
                gc_AdmissionEntries.RefreshDataSource()
                Loading = False
            Else
                MsgBox("Unknown error in adding entry.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
            Action = ""
            DisableEditing()
        ElseIf Action = "EDIT"
            Dim r As Integer = EditAdmissionEntry(ID, txt_RegistrationNumber.Text, txt_ApplicationNumber.Text, txt_Name.Text, txt_Gender.EditValue, txt_Stream.EditValue, txt_Rank.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Quota.EditValue, GetString(cb_SpecialQuota.CheckedItems), txt_CourseID.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, txt_State.EditValue)
            If r > 0 Then
                Loading = True
                Dim f As AdmissionEntry = CType(gc_AdmissionEntries.DataSource, List(Of AdmissionEntry)).Find(Function(c) c.ID = ID)
                If f IsNot Nothing Then
                    f.Update(txt_Name.Text, txt_Gender.EditValue, txt_RegistrationNumber.Text, txt_Rank.Text, txt_ApplicationNumber.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Stream.EditValue, txt_Quota.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, GetString(cb_SpecialQuota.CheckedItems), txt_CourseID.EditValue, txt_State.EditValue)
                    gc_AdmissionEntries.RefreshDataSource()
                    Loading = False
                End If

            Else
                MsgBox("Error while editing entry.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
            Action = ""
            ID = -1
            DisableEditing()
        End If
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            Try
                LoadValues()
                Dim f As AdmissionEntry = gv_AdmissionEntries.GetRow(gv_AdmissionEntries.GetSelectedRows(0))
                ID = f.ID
                Action = "EDIT"
                EnableEditing()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim f As AdmissionEntry = gv_AdmissionEntries.GetRow(gv_AdmissionEntries.GetSelectedRows(0))
                Dim r As Integer = DeleteAdmissionEntry(f.ID)
                If r > 0 Then
                    Loading = True
                    CType(gc_AdmissionEntries.DataSource, List(Of AdmissionEntry)).Remove(f)
                    gc_AdmissionEntries.RefreshDataSource()
                    Loading = False
                    MsgBox(r & " record(s) successfully removed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Else
                    MsgBox("Error deleting entries.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End If
            End If
        End If
    End Sub

    Private RTC As New RichTextBoxPrintCtrl
    Private checkPrint As Integer

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        checkPrint = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        checkPrint = RTC.Print(checkPrint, RTC.TextLength, e)

        If checkPrint < RTC.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
    Sub PrepareRTF()
        Dim f As AdmissionEntry = gv_AdmissionEntries.GetRow(gv_AdmissionEntries.GetSelectedRows(0))
        Dim course As Course = GetCourse(f.CourseID, Courses)

        Dim RTF As String = Slip_Base

        RTF = RTF.Replace("<<ACADEMIC YEAR>>", Now.Year & "-" & Now.Year - 1)
        RTF = RTF.Replace("<<NAME>>", f.Name)
        RTF = RTF.Replace("<<GENDER>>", f.Gender)
        RTF = RTF.Replace("<<REGNO>>", f.Registration)
        RTF = RTF.Replace("<<RANK>>", f.Rank)
        RTF = RTF.Replace("<<APPLICATION>>", f.Application)
        RTF = RTF.Replace("<<COMMUNITY>>", f.Community)
        RTF = RTF.Replace("<<CUTOFF>>", f.CutOff)
        RTF = RTF.Replace("<<COURSE>>", If(course Is Nothing, f.Course, String.Format("{0} ({1})", f.Course, course.Department)))
        RTF = RTF.Replace("<<SHIFT>>", f.Shift)
        RTF = RTF.Replace("<<MEDIUM>>", f.Medium)
        RTF = RTF.Replace("<<STREAM>>", f.Stream)
        RTF = RTF.Replace("<<QUOTA>>", f.Quota)
        RTF = RTF.Replace("<<ALLOT_GENDER>>", f.AllottedGender)
        RTF = RTF.Replace("<<ALLOT_STREAM>>", f.AllottedStream)
        RTF = RTF.Replace("<<ALLOT_COMMUNITY>>", f.AllottedCommunity)
        RTF = RTF.Replace("<<REMARKS>>", f.Remarks)
        RTF = RTF.Replace("<<DOA>>", f.AdmissionDate)
        RTF = RTF.Replace("<<FEES>>", If(f.State = "Tamil Nadu", course.Fees1, course.Fees2))
        RTF = RTF.Replace("<<CLPFEES>>", "700")
        RTC.Rtf = RTF

        PrintDocument1.DefaultPageSettings.Margins.Top = My.Settings.ProvisonalSlip_TopMargin
        PrintDocument1.DefaultPageSettings.Margins.Bottom = My.Settings.ProvisonalSlip_BottomMargin
        PrintDocument1.DefaultPageSettings.Margins.Left = My.Settings.ProvisonalSlip_LeftMargin
        PrintDocument1.DefaultPageSettings.Margins.Right = My.Settings.ProvisonalSlip_RightMargin

    End Sub
    Private Sub btn_PrintSlip_Click(sender As Object, e As EventArgs) Handles btn_PrintSlip.Click
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            PrepareRTF
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        End If

    End Sub

    Private Sub btn_PageSetup_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_PageSetup.ItemClick
        Dim d As New frm_PageSettings
        d.ShowDialog()
    End Sub

    Private Sub btn_PrintPreview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_PrintPreview.ItemClick
        If gv_AdmissionEntries.SelectedRowsCount = 1 Then
            PrepareRTF()
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
End Class