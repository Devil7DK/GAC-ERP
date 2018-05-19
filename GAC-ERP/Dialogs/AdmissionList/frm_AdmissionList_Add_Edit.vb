Imports DevExpress.XtraBars

Public Class frm_AdmissionList_Add_Edit
    Dim EditEntry As AdmissionEntry
    Dim ValStatus As Status
    Dim Loading As Boolean = False
    Private Printer As Printing.ProvisionalSlip
    Private Property Status_ As Status
        Get
            Return ValStatus
        End Get
        Set(value As Status)
            Select Case value
                Case Status.AddingNew
                    btn_New.Enabled = False
                    btn_Print.Enabled = False
                    btn_Save.Enabled = True
                    btn_Cancel.Enabled = True
                    EnableEditing()
                    ClearControls()
                    txt_Status.Caption = "Adding New Entry"
                Case Status.Editing
                    rpg_New.Visible = False
                    btn_Print.Enabled = False
                    btn_Save.Enabled = True
                    btn_Cancel.Enabled = True
                    LoadValues(EditEntry)
                    EnableEditing()
                    txt_Status.Caption = "Editing Entry"
                Case Status.Saved
                    If ValStatus = Status.AddingNew Then
                        btn_New.Enabled = True
                    End If
                    btn_Print.Enabled = True
                    btn_Save.Enabled = False
                    btn_Cancel.Enabled = False
                    DisableEditing()
                    txt_Status.Caption = "Entry Saved"
            End Select
            ValStatus = value
        End Set
    End Property
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
    End Sub
    Sub EnableEditing()
        ControlBox = False

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
    Enum Status
        AddingNew
        Editing
        Saved
    End Enum

    Sub New()
        InitializeComponent()
    End Sub
    Sub New(ByRef AdmissionEntry As AdmissionEntry)
        InitializeComponent()
        Me.EditEntry = AdmissionEntry
    End Sub
    Private Sub frm_AdmissionList_Add_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If txt_CourseID.Properties.DataSource Is Nothing Then
            txt_CourseID.Properties.DataSource = GetCoureses(True)
            txt_CourseID.Properties.ValueMember = "Code"
            txt_CourseID.Properties.DisplayMember = "Code"
        End If
        If Me.EditEntry IsNot Nothing Then
            Status_ = Status.Editing
        Else
            Status_ = Status.AddingNew
        End If
    End Sub

    Private Sub btn_New_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New.ItemClick
        Status_ = Status.AddingNew
    End Sub

    Private Sub txt_CourseID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CourseID.EditValueChanged
        Try
            If Loading = False Then
                Dim Courses As List(Of Course) = txt_CourseID.Properties.DataSource
                If Courses IsNot Nothing Then
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

    Private Sub btn_Save_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save.ItemClick
        If Status_ = Status.AddingNew Then
            Dim DOA As Date = Now
            Dim r As Integer = NewAdmissionEntry(txt_RegistrationNumber.Text, txt_ApplicationNumber.Text, txt_Name.Text, txt_Gender.EditValue, txt_Stream.EditValue, txt_Rank.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Quota.EditValue, GetString(cb_SpecialQuota.CheckedItems), DOA, txt_CourseID.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, txt_State.EditValue)
            If r > 0 Then
                Status_ = Status.Saved
                Me.EditEntry = New AdmissionEntry(r, txt_Name.Text, txt_Gender.EditValue, txt_RegistrationNumber.Text, txt_Rank.Text, txt_ApplicationNumber.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Stream.EditValue, txt_Quota.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, DOA, False, 0, GetString(cb_SpecialQuota.CheckedItems), txt_CourseID.EditValue, txt_State.EditValue)
            Else
                MsgBox("Unknown error in adding entry.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
        ElseIf Status_ = Status.Editing
            Dim r As Integer = EditAdmissionEntry(EditEntry.ID, txt_RegistrationNumber.Text, txt_ApplicationNumber.Text, txt_Name.Text, txt_Gender.EditValue, txt_Stream.EditValue, txt_Rank.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Quota.EditValue, GetString(cb_SpecialQuota.CheckedItems), txt_CourseID.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, txt_State.EditValue)
            If r > 0 Then
                If EditEntry IsNot Nothing Then
                    EditEntry.Update(txt_Name.Text, txt_Gender.EditValue, txt_RegistrationNumber.Text, txt_Rank.Text, txt_ApplicationNumber.Text, txt_Community.EditValue, txt_CutOff.Text, txt_Course.Text, txt_Shift.Text, txt_Medium.Text, txt_Stream.EditValue, txt_Quota.EditValue, txt_AllottedGender.EditValue, txt_AllottedStream.EditValue, txt_AllottedCommunity.EditValue, txt_Remarks.EditValue, GetString(cb_SpecialQuota.CheckedItems), txt_CourseID.EditValue, txt_State.EditValue)
                    Status_ = Status.Saved
                End If
            Else
                MsgBox("Error while editing entry.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub btn_Cancel_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Cancel.ItemClick
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print.ItemClick
        If EditEntry IsNot Nothing AndAlso txt_CourseID.Properties.DataSource IsNot Nothing Then
            Dim Course As Course = GetCourse(EditEntry.CourseID, txt_CourseID.Properties.DataSource)
            Printer.Print(EditEntry, Course)
        End If
    End Sub

    Private Sub frm_AdmissionList_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Printer Is Nothing Then
            Printer = New Printing.ProvisionalSlip
        End If
    End Sub

    Private Sub btn_PrintPreview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_PrintPreview.ItemClick
        If EditEntry IsNot Nothing AndAlso txt_CourseID.Properties.DataSource IsNot Nothing Then
            Dim Course As Course = GetCourse(EditEntry.CourseID, txt_CourseID.Properties.DataSource)
            Printer.PrintPreview(EditEntry, Course)
        End If
    End Sub

    Private Sub btn_MarginSettings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_MarginSettings.ItemClick
        Dim d As New frm_PageSettings
        d.ShowDialog()
    End Sub
End Class