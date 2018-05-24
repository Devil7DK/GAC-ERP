Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls

Public Class frm_AdmissionFees
    Dim Courses As List(Of Course)
    Dim LoadingData As Boolean = False
    Dim CurrentEntry As AdmissionEntry
    Dim CurrentCourse As Course
    Dim CurrentReceipt As AdmissionReceipt
    Dim BillPrinerSetting As New BillPrinterSettings
    Sub DisableEditing()
        ControlBox = True

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
        txt_State.ReadOnly = True
    End Sub
    Sub ClearControls()
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
        txt_State.SelectedItem = "Tamil Nadu"
    End Sub
    Sub LoadValues(ByVal AdmissionEntry As AdmissionEntry)
        txt_Name.Text = AdmissionEntry.Name
        txt_RegistrationNumber.Text = AdmissionEntry.Registration
        txt_ApplicationNumber.Text = AdmissionEntry.Application
        txt_Rank.Text = AdmissionEntry.Rank
        txt_Gender.EditValue = AdmissionEntry.Gender
        txt_Community.EditValue = AdmissionEntry.Community
        txt_CutOff.Text = AdmissionEntry.CutOff
        txt_CourseID.EditValue = AdmissionEntry.CourseID
        Try
            Dim val As Course = GetCourse(AdmissionEntry.CourseID, Courses)
            txt_Course.Text = Val.Name
            txt_Department.Text = Val.Department
            txt_Shift.Text = Val.Shift
            txt_Medium.Text = Val.Medium
        Catch ex As Exception

        End Try
        txt_Stream.EditValue = AdmissionEntry.Stream
        txt_Quota.EditValue = AdmissionEntry.Quota
        txt_AllottedGender.EditValue = AdmissionEntry.AllottedGender
        txt_AllottedCommunity.EditValue = AdmissionEntry.AllottedCommunity
        txt_AllottedStream.EditValue = AdmissionEntry.AllottedStream
        For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In cb_SpecialQuota.Items
            i.CheckState = CheckState.Unchecked
        Next
        For Each i As String In AdmissionEntry.SpecialQuota.Split(";")
            Try
                Dim item = cb_SpecialQuota.Items.Item(i)
                If item IsNot Nothing Then item.CheckState = CheckState.Checked
            Catch ex As Exception

            End Try
        Next
        txt_Remarks.Text = AdmissionEntry.Remarks
    End Sub
    Private Sub frm_AdmissionFees_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DisableEditing()
        ClearControls()
        Worker_LoadCourses.RunWorkerAsync()
    End Sub

    Private Sub Worker_LoadCourses_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_LoadCourses.DoWork
        Cursor = Cursors.WaitCursor
        LoadingData = True
        Try
            Dim XML_Path As String = GetBillPrinterSettingsXMLPath()
            Dim fi As New System.IO.FileInfo(XML_Path)
            If fi.Exists Then
                Try
                    BillPrinerSetting = BillPrinterSettings.ReadFile(XML_Path)
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception

        End Try
        Courses = GetCoureses(False)
        txt_CourseID.Properties.DataSource = Courses
        txt_CourseID.Properties.ValueMember = "Code"
        txt_CourseID.Properties.DisplayMember = "Code"
        LoadingData = False
        Cursor = Cursors.Default
    End Sub

    Private Sub frm_AdmissionFees_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Sub CalculateTotal(ByVal Entry As AdmissionEntry)
        Dim total As Integer = 0
        If gc_FeesGroup.DataSource IsNot Nothing Then
            Try
                For Each i As FeesGroup In gc_FeesGroup.DataSource
                    i.CalculateTotal()
                    If Entry.State = "Tamil Nadu" Then
                        total += i.Total1
                    Else
                        total += i.Total2
                    End If
                Next
            Catch ex As Exception

            End Try
        End If
        If gc_OptionalFees.DataSource IsNot Nothing Then
            Try
                For Each RH As Integer In gv_OptionalFees.GetSelectedRows
                    Dim i As FeesHead = gv_OptionalFees.GetRow(RH)
                    If Entry.State = "Tamil Nadu" Then
                        total += i.Value1
                    Else
                        total += i.Value2
                    End If
                Next
            Catch ex As Exception

            End Try
        End If
        txt_Total.Text = "`. " & total.ToString
    End Sub
    Private Sub Worker_FetchData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_FetchData.DoWork
        Cursor = Cursors.WaitCursor
        LoadingData = True
        Try
            Dim Entries As List(Of AdmissionEntry) = GetAdmissionEntriesByRegNo(txt_RegNo2Fetch.Text, False)
            Dim Entry As AdmissionEntry = Nothing
            If Entries.Count = 0 Then
                MsgBox("No entries found with giving Registration Number.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            ElseIf Entries.Count = 1
                Entry = Entries(0)
            Else
                Dim d As New frm_AdmissionEntries_SearchResult(Entries)
                If d.ShowDialog = DialogResult.OK Then
                    Entry = d.SelectedEntry
                End If
            End If
            If Entry IsNot Nothing Then
                Try
                    CurrentReceipt = GetAdmissionReceipt(Entry.ID, False)
                Catch ex As Exception

                End Try
                LoadValues(Entry)
                CurrentEntry = Entry
                Dim Course As Course = GetCourse(Entry.CourseID, Courses)
                CurrentCourse = Course
                Try
                    gc_FeesGroup.DataSource = Course.GetFeesStructure.PrimaryFeesGroups
                    Dim OptionalFeesHeads As New List(Of FeesHead)
                    For Each g As FeesGroup In Course.GetFeesStructure.PrimaryFeesGroups
                        For Each h As FeesHead In g.FeesHeads
                            If h.isOptional Then
                                OptionalFeesHeads.Add(h)
                            End If
                        Next
                    Next
                    gc_OptionalFees.DataSource = OptionalFeesHeads
                    gc_OptionalFees.RefreshDataSource()
                    gv_OptionalFees.Columns.Item("isOptional").Visible = False
                Catch ex As Exception

                End Try
                CalculateTotal(Entry)
                If CurrentReceipt IsNot Nothing Then
                    txt_FeesStatus.Text = "Paid"
                    txt_FeesStatus.ForeColor = Color.Green
                    btn_MarkPaid.Enabled = False
                    btn_MarkUnpaid.Enabled = True
                    btn_PrintBill.Enabled = True
                    gc_OptionalFees.Enabled = False
                    If CurrentReceipt.AmountDetails IsNot Nothing Then
                        For Each g As FeesGroup In CurrentReceipt.AmountDetails.PrimaryFeesGroups
                            For Each i As FeesHead In g.FeesHeads
                                If i.isOptional Then
                                    If gc_OptionalFees.DataSource IsNot Nothing Then
                                        Dim RH As Integer = gv_OptionalFees.LocateByValue("Name", i.Name)
                                        If RH <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                                            gv_OptionalFees.SelectRow(RH)
                                        End If
                                    End If
                                End If
                            Next
                        Next
                    End If
                Else
                    txt_FeesStatus.Text = "Unpaid"
                    txt_FeesStatus.ForeColor = Color.Red
                    btn_MarkPaid.Enabled = True
                    btn_MarkUnpaid.Enabled = False
                    btn_PrintBill.Enabled = False
                    gc_OptionalFees.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        Finally
            LoadingData = False
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btn_Fetch_Click(sender As Object, e As EventArgs) Handles btn_Fetch.Click
        If Worker_FetchData.IsBusy = False AndAlso LoadingData = False Then
            Worker_FetchData.RunWorkerAsync()
        End If
    End Sub

    Private Sub btn_MarkPaid_Click(sender As Object, e As EventArgs) Handles btn_MarkPaid.Click
        Dim FS As New FeesStructure
        FS.PrimaryFeesGroups = gc_FeesGroup.DataSource
        For Each i As FeesGroup In FS.PrimaryFeesGroups
            Dim Heads2Remove As New List(Of FeesHead)
            For Each h As FeesHead In i.FeesHeads
                If h.isOptional Then
                    Dim isSelected As Boolean = False
                    For Each s As Integer In gv_OptionalFees.GetSelectedRows
                        Dim SelectedItem As FeesHead = gv_OptionalFees.GetRow(s)
                        If Not (h.Name = SelectedItem.Name AndAlso h.Value1 = SelectedItem.Value1 AndAlso h.Value2 = SelectedItem.Value2) Then
                            isSelected = True
                        End If
                    Next
                    If Not isSelected Then
                        Heads2Remove.Add(h)
                    End If
                End If
            Next
            For Each h As FeesHead In Heads2Remove
                i.FeesHeads.Remove(h)
            Next
        Next
        Dim XML As String = FeesStructure.Write2XML(FS)
        Dim Receipt As AdmissionReceipt = NewAdmissionReceipt(FS, CurrentEntry, CurrentCourse)
        CurrentReceipt = Receipt
        If Receipt IsNot Nothing Then
            txt_FeesStatus.Text = "Paid"
            txt_FeesStatus.ForeColor = Color.Green
            btn_MarkPaid.Enabled = False
            btn_MarkUnpaid.Enabled = True
            btn_PrintBill.Enabled = True
            gc_OptionalFees.Enabled = False
        Else
            txt_FeesStatus.Text = "Unpaid"
            txt_FeesStatus.ForeColor = Color.Red
            btn_MarkPaid.Enabled = True
            btn_MarkUnpaid.Enabled = False
            btn_PrintBill.Enabled = False
            gc_OptionalFees.Enabled = True
        End If
    End Sub

    Private Sub gv_OptionalFees_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gv_OptionalFees.SelectionChanged
        Try
            CalculateTotal(CurrentEntry)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_MarkUnpaid_Click(sender As Object, e As EventArgs) Handles btn_MarkUnpaid.Click
        Dim r As Integer = DeleteAdmissionReceipt(CurrentReceipt.ID, False)
        If r > 0 Then
            txt_FeesStatus.Text = "Unpaid"
            txt_FeesStatus.ForeColor = Color.Red
            btn_MarkPaid.Enabled = True
            btn_MarkUnpaid.Enabled = False
            btn_PrintBill.Enabled = False
            gc_OptionalFees.Enabled = True
        Else
            txt_FeesStatus.Text = "Paid"
            txt_FeesStatus.ForeColor = Color.Green
            btn_MarkPaid.Enabled = False
            btn_MarkUnpaid.Enabled = True
            btn_PrintBill.Enabled = True
            gc_OptionalFees.Enabled = False
        End If
    End Sub

    Private Sub btn_PrintBill_Click(sender As Object, e As EventArgs) Handles btn_PrintBill.Click
        Dim FS As New FeesStructure
        FS.PrimaryFeesGroups = gc_FeesGroup.DataSource
        For Each i As FeesGroup In FS.PrimaryFeesGroups
            For Each h As FeesHead In i.FeesHeads
                If h.isOptional Then
                    For Each s As Integer In gv_OptionalFees.GetSelectedRows
                        Dim Selected As FeesHead = gv_OptionalFees.GetRow(s)
                        If Not (h.Name = Selected.Name AndAlso h.Value1 = Selected.Value1 AndAlso h.Value2 = Selected.Value2) Then
                            i.FeesHeads.Remove(h)
                        End If
                    Next
                End If
            Next
        Next
        BillPrinter_LaserJet.Receipt = CurrentReceipt
        BillPrinter_LaserJet.Settings = BillPrinerSetting
        If ReceiptPrintDialog.ShowDialog = DialogResult.OK Then
            BillPrinter_LaserJet.Print()
        End If
    End Sub

    Private Sub btn_PrintPreview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_PrintPreview.ItemClick
        Dim FS As New FeesStructure
        FS.PrimaryFeesGroups = gc_FeesGroup.DataSource
        For Each i As FeesGroup In FS.PrimaryFeesGroups
            For Each h As FeesHead In i.FeesHeads
                If h.isOptional Then
                    For Each s As Integer In gv_OptionalFees.GetSelectedRows
                        Dim Selected As FeesHead = gv_OptionalFees.GetRow(s)
                        If Not (h.Name = Selected.Name AndAlso h.Value1 = Selected.Value1 AndAlso h.Value2 = Selected.Value2) Then
                            i.FeesHeads.Remove(h)
                        End If
                    Next
                End If
            Next
        Next
        BillPrinter_LaserJet.Receipt = CurrentReceipt
        BillPrinter_LaserJet.Settings = BillPrinerSetting
        Dim d As New PrintPreviewDialogEx(Me)
        d.Document = BillPrinter_LaserJet
        d.ShowDialog()
    End Sub
End Class