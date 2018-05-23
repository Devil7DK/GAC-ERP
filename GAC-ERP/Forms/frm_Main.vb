Imports System.ComponentModel
Imports DevExpress.XtraBars

Public Class frm_Main
    Private CurrentUser As Staff
    Sub New(ByVal User As Staff)
        InitializeComponent()
        CurrentUser = User
    End Sub
    Private Sub btn_AdmissionList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AdmissionList.ItemClick
        If CurrentUser.HasPermission(Permission.Admission) Then
            Try
                frm_AdmissionList_Add_Edit.Show()
            Catch ex As Exception

            End Try
        Else
            ShowPermissionErrorMessage()
        End If
    End Sub
    Public Shared Sub ShowPermissionErrorMessage()
        MsgBox("You don't have enough permission to do this action.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    End Sub

    Private Sub btn_DefaultFeesStructure_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DefaultFeesStructure.ItemClick
        If CurrentUser.HasPermission(Permission.Billing) Then
            Dim XML_Path As String = GetDefaultFeesStructureXMLPath()
            Dim fi As New IO.FileInfo(XML_Path)

            Dim f As FeesStructure = Nothing

            If fi.Exists Then
                Try
                    f = FeesStructureIO.ReadXML(My.Computer.FileSystem.ReadAllText(XML_Path))
                Catch ex As Exception

                End Try
            End If

            Dim d As New frm_FeesStructure("Default Fees Structure", f)
            If d.ShowDialog() = DialogResult.OK AndAlso d.FeesStructure IsNot Nothing Then
                If fi.Directory.Exists = False Then
                    My.Computer.FileSystem.CreateDirectory(fi.Directory.FullName)
                End If
                Try
                    My.Computer.FileSystem.WriteAllText(XML_Path, FeesStructureIO.Write2XML(d.FeesStructure), False)
                Catch ex As Exception

                End Try
            End If
        Else
            ShowPermissionErrorMessage()
        End If
    End Sub

    Private Sub btn_Courses_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Courses.ItemClick
        If CurrentUser.HasPermission(Permission.Billing) Or CurrentUser.HasPermission(Permission.Courses) Then
            Try
                frm_Courses_View.User = CurrentUser
                frm_Courses_View.ShowDialog()
            Catch ex As Exception

            End Try
        Else
            ShowPermissionErrorMessage()
        End If
    End Sub

    Private Sub btn_Exit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Exit.ItemClick
        Me.Close()
    End Sub

    Private Sub btn_AdmissionList_View_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_AdmissionList_View.ItemClick
        If CurrentUser.HasPermission(Permission.Admission) Then
            Try
                frm_AdmissionList_View.ShowDialog()
            Catch ex As Exception

            End Try
        Else
            ShowPermissionErrorMessage()
        End If
    End Sub

    Private Sub btn_AdmissionFees_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_AdmissionFees.ItemClick
        If CurrentUser.HasPermission(Permission.Billing) Then
            Try
                frm_AdmissionFees.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_BillPrinter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_BillPrinter.ItemClick
        Dim XML_Path As String = GetBillPrinterSettingsXMLPath()
        Dim BillPrinerSetting As New BillPrinterSettings
        Dim fi As New IO.FileInfo(XML_Path)
        If Not fi.Directory.Exists Then
            fi.Directory.Create()
        End If
        If fi.Exists Then
            Try
                BillPrinerSetting = BillPrinterSettings.ReadFile(XML_Path)
            Catch ex As Exception

            End Try
        End If
        Dim d As New frm_PropertyEditor(BillPrinerSetting)
        If d.ShowDialog = DialogResult.OK Then
            BillPrinterSettings.Write2File(d.SelectedObject, XML_Path)
        End If
    End Sub

    Private Sub frm_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        On Error Resume Next
        frm_Courses_View.Close()
        frm_AdmissionList_View.Close()
        frm_AdmissionFees.Close()
    End Sub
End Class