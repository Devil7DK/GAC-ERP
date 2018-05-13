Imports DevExpress.XtraBars

Public Class frm_Courses
    Dim Loading As Boolean = False
    Sub DisableControls()
        grp_Controls.Enabled = False
        grp_Courses.Enabled = False
    End Sub
    Sub EnableControls()
        grp_Controls.Enabled = True
        grp_Courses.Enabled = True
    End Sub

    Private Sub Worker_LoadCourses_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker_LoadCourses.DoWork
        Loading = True
        DisableControls()
        Me.Cursor = Cursors.WaitCursor
        Dim t As New Stopwatch
        t.Start()
        Try
            Dim Courses = GetCoureses()
            gc_Courses.DataSource = Courses
            t.Stop()
            ReleaseMemory()
            MsgBox(Courses.Count & " Records loaded in " & t.Elapsed.Minutes & " minutes and " & t.Elapsed.Seconds & " seconds.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
        Catch ex As Exception
            If t.IsRunning Then t.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
        End Try
        Me.Cursor = Cursors.Arrow
        EnableControls()
        Loading = False
    End Sub

    Private Sub btn_Reload_Click(sender As Object, e As EventArgs) Handles btn_Reload.Click
        Worker_LoadCourses.RunWorkerAsync()
    End Sub

    Private Sub frm_Courses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Worker_LoadCourses.RunWorkerAsync()
    End Sub

    Private Sub btn_FeesStructure_Click(sender As Object, e As EventArgs) Handles btn_FeesStructure.Click
        If gv_Courses.SelectedRowsCount = 1 Then
            Try
                Dim course As Course = gv_Courses.GetRow(gv_Courses.GetSelectedRows(0))
                Dim d As New frm_FeesStructure("Edit Course Fees Details", course.GetFeesStructure)
                If d.ShowDialog = DialogResult.OK Then
                    If MsgBox("Are you sure to update fees details...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
                        Dim NewFeesStructureXML As String = FeesStructureIO.Write2XML(d.FeesStructure)
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
    End Sub

    Private Sub btn_DefaultFeesStructure_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_DefaultFeesStructure.ItemClick
        If gv_Courses.SelectedRowsCount = 1 Then
            Dim fi As New IO.FileInfo(GetDefaultFeesStructureXMLPath())
            If fi.Exists Then
                Dim FS As FeesStructure = Nothing
                Try
                    FS = FeesStructureIO.ReadXML(My.Computer.FileSystem.ReadAllText(fi.FullName))
                Catch ex As Exception

                End Try
                If FS IsNot Nothing Then
                    If MsgBox("Are you sure to reset fees details to default...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sure?") = MsgBoxResult.Yes Then
                        Try
                            Dim course As Course = gv_Courses.GetRow(gv_Courses.GetSelectedRows(0))

                            Dim NewFeesStructureXML As String = FeesStructureIO.Write2XML(FS)
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
    End Sub
End Class