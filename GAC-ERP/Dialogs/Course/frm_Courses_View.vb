Imports DevExpress.XtraBars

Public Class frm_Courses_View
    Dim LoadingData As Boolean = False
    Property User As Staff = Nothing

    Private Sub Worker_LoadCourses_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_LoadCourses.DoWork
        LoadingData = True
        Me.Cursor = Cursors.WaitCursor
        Dim t As New Stopwatch
        t.Start()
        Try
            Dim Courses = GetCoureses(True)
            gc_Courses.DataSource = Courses
            t.Stop()
            ReleaseMemory()
            MsgBox(Courses.Count & " Records loaded in " & t.Elapsed.Minutes & " minutes and " & t.Elapsed.Seconds & " seconds.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        Catch ex As Exception
            If t.IsRunning Then t.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try
        Me.Cursor = Cursors.Arrow
        LoadingData = False
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As EventArgs) Handles btn_Reload.ItemClick
        If Worker_LoadCourses.IsBusy = False Then
            Worker_LoadCourses.RunWorkerAsync()
        End If
    End Sub

    Private Sub frm_Courses_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Worker_LoadCourses.RunWorkerAsync()
    End Sub

    Private Sub btn_FeesStructure_ItemClick(sender As Object, e As EventArgs) Handles btn_FeesStructure.ItemClick
        If Not LoadingData Then
            If User.HasPermission(Permission.Billing) Then
                If gv_Courses.SelectedRowsCount = 1 Then
                    Try
                        Dim course As Course = gv_Courses.GetRow(gv_Courses.GetSelectedRows(0))
                        Dim d As New frm_FeesStructure("Edit Course Fees Details", course.GetFeesStructure)
                        If d.ShowDialog = DialogResult.OK Then
                            If MsgBox("Are you sure to update fees details...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
                                Dim NewFeesStructureXML As String = FeesStructure.Write2XML(d.FeesStructure)
                                Dim r As Integer = UpdateCourseFeesDetails(course.ID, NewFeesStructureXML)
                                If r > 0 Then
                                    course.SetFeesStructure(d.FeesStructure)
                                    gc_Courses.RefreshDataSource()
                                    MsgBox("Fees Details Successfully Updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                                Else
                                    MsgBox("Fees details not properly updated to server.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Unknown error while updating fees details." & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                    End Try
                End If
            Else
                frm_Main.ShowPermissionErrorMessage()
            End If
        End If
    End Sub

    Private Sub btn_DefaultFeesStructure_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_DefaultFeesStructure.ItemClick
        If Not LoadingData Then
            If User.HasPermission(Permission.Billing) Then
                If gv_Courses.SelectedRowsCount = 1 Then
                    Dim fi As New IO.FileInfo(GetDefaultFeesStructureXMLPath())
                    If fi.Exists Then
                        Dim FS As FeesStructure = Nothing
                        Try
                            FS = FeesStructure.ReadXML(My.Computer.FileSystem.ReadAllText(fi.FullName))
                        Catch ex As Exception

                        End Try
                        If FS IsNot Nothing Then
                            If MsgBox("Are you sure to reset fees details to default...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
                                Try
                                    Dim course As Course = gv_Courses.GetRow(gv_Courses.GetSelectedRows(0))

                                    Dim NewFeesStructureXML As String = FeesStructure.Write2XML(FS)
                                    Dim r As Integer = UpdateCourseFeesDetails(course.ID, NewFeesStructureXML)
                                    If r > 0 Then
                                        course.SetFeesStructure(FS)
                                        gc_Courses.RefreshDataSource()
                                        MsgBox("Fees Details Successfully Updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                                    Else
                                        MsgBox("Fees details not properly updated to server.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                                    End If

                                Catch ex As Exception
                                    MsgBox("Unknown error while updating fees details." & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                                End Try
                            End If
                        Else
                            MsgBox("Unable to load default fees details. Please delete the xml file and recreate again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                        End If

                    Else
                        MsgBox("Default fees details doesn't exit. Please create one first.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                    End If
                End If
            Else
                frm_Main.ShowPermissionErrorMessage()
            End If
        End If
    End Sub

    Private Sub btn_New_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New.ItemClick
        If Not LoadingData Then
            Dim d As New frm_Courses_Add_Edit
            If d.ShowDialog = DialogResult.OK Then
                CType(gv_Courses.DataSource, List(Of Course)).Add(d.Course)
            End If
        End If
    End Sub

    Private Sub btn_Edit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Edit.ItemClick
        If Not LoadingData Then
            If gv_Courses.SelectedRowsCount = 1 Then
                Dim d As New frm_Courses_Add_Edit(gv_Courses.GetRow(gv_Courses.GetSelectedRows(0)))
                d.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btn_Remove_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Remove.ItemClick
        If Not LoadingData Then
            If MsgBox("Are you sure to delete " & gv_Courses.SelectedRowsCount & " course(s)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure...?") = MsgBoxResult.Yes Then
                Dim Deleted As Integer = 0
                Dim Errors As Integer = 0
                LoadingData = True
                For Each i As Integer In gv_Courses.GetSelectedRows
                    Dim Course As Course = CType(gv_Courses.GetRow(i), Course)
                    Dim r As Integer = DeleteCourse(Course.ID)
                    If r > 0 Then
                        CType(gc_Courses.DataSource, List(Of Course)).Remove(Course)
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
                gc_Courses.RefreshDataSource()
                LoadingData = False
            End If
        End If
    End Sub
End Class