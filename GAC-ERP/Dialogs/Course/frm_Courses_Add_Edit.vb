Public Class frm_Courses_Add_Edit
    Enum Mode
        Add
        Edit
    End Enum
    Dim CurrentMode As Mode = Mode.Add
    Property Course As Course
    Sub New()
        InitializeComponent()
    End Sub
    Sub New(ByRef Course As Course)
        InitializeComponent()
        Me.Course = Course
    End Sub
    Private Sub frm_Courses_Add_Edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Course Is Nothing Then
            CurrentMode = Mode.Add
            Text = "Add New Course"
            btn_OK.Text = "Add"
        Else
            CurrentMode = Mode.Edit
            Text = "Edit Course"
            btn_OK.Text = "Edit"
            LoadValues()
        End If
    End Sub
    Sub LoadValues()
        On Error Resume Next
        txt_CourseID.Text = Course.Code
        txt_CourseName.Text = Course.Name
        txt_Department.EditValue = Course.Department
        txt_Duration.Value = CInt(Course.Duration)
        txt_MaxSeats.Value = CInt(Course.MaxSeats)
        txt_Medium.EditValue = Course.Medium
        txt_Shift.EditValue = Course.Shift
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If CurrentMode = Mode.Add Then
            Dim r As Integer = NewCourse(txt_CourseID.Text, txt_CourseName.Text, txt_Medium.EditValue, txt_Shift.EditValue, txt_Department.EditValue, txt_Duration.Value, txt_MaxSeats.Value)
            If r > 0 Then
                Course = New Course(r, txt_CourseID.Text, txt_CourseName.Text, txt_Medium.EditValue, txt_Shift.EditValue, txt_Department.EditValue, txt_Duration.Value, txt_MaxSeats.Value, "")
                MsgBox("New course successfully added.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Unknown error in adding entry.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
        ElseIf CurrentMode = Mode.Edit Then
            Dim r As Integer = EditCourse(Course.ID, txt_CourseID.Text, txt_CourseName.Text, txt_Medium.EditValue, txt_Shift.EditValue, txt_Department.EditValue, txt_Duration.Value, txt_MaxSeats.Value)
            If r > 0 Then
                Course.Update(txt_CourseID.Text, txt_CourseName.Text, txt_Medium.EditValue, txt_Shift.EditValue, txt_Department.EditValue, txt_Duration.Value, txt_MaxSeats.Value, "")
                MsgBox("Course edited successfully added.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Unknown error in editing entry.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub
End Class