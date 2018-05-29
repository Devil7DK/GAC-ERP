Imports System.Data.SqlClient

Module PublicFunctions
    Private ReadOnly Key() As Byte = {68, 101, 118, 105, 108, 55, 68, 75, 64, 71, 65, 67, 45, 69, 82, 80, 45, 50, 48, 49, 56, 95, 49, 57}
    Private ReadOnly IV() As Byte = {8, 7, 6, 5, 4, 3, 2, 1}
    Private MySqlConnection As SqlConnection

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    Public Function GetConnection() As SqlConnection
        If MySqlConnection Is Nothing Then
            MySqlConnection = New SqlConnection(String.Format("Server={0};Initial Catalog={1};User ID={2};Password={3};Pooling={4};", My.Settings.Server, My.Settings.Database, My.Settings.Username, Encryption.Decrypt(My.Settings.Password), If(My.Settings.Pooling, "true", "false")))
        End If
        Return MySqlConnection
    End Function
    Sub ReleaseMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Function GetString(ByVal CheckedItems As DevExpress.XtraEditors.BaseCheckedListBoxControl.CheckedItemCollection) As String
        Try
            If CheckedItems Is Nothing Then
                Return ""
            Else
                Dim s As String = ""
                For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In CheckedItems
                    s &= i.Value.ToString & ";"
                Next
                Return s
            End If
        Catch ex As Exception

        End Try
        Return ""
    End Function

    Function GetCourse(ByVal CourseID As String, ByVal Courses As List(Of Course))
        Return Courses.Find(Function(c) c.Code = CourseID)
    End Function

    Function GetDefaultFeesStructureXMLPath() As String
        Return IO.Path.Combine(Application.StartupPath, "Templates", "DefaultFeesStructure.xml")
    End Function
    Function GetBillPrinterSettingsPath() As String
        Return IO.Path.Combine(Application.StartupPath, "Settings", "BillPrinter.settings")
    End Function
    Function GetProvisionalSlipPrinterSettingsPath() As String
        Return IO.Path.Combine(Application.StartupPath, "Settings", "ProvisionalSlipPrinter.settings")
    End Function
    Function GetReceiptNumber(ByVal ID As Int64)
        Return ID.ToString("000000")
    End Function
    Function GetDates(ByVal FromDate As Date, ByVal ToDate As Date) As List(Of Date)
        Dim Dates As New List(Of Date)
        Dim CurrentDate As Date = FromDate
        While (CurrentDate <= ToDate)
            Dates.Add(CurrentDate)
            CurrentDate = CurrentDate.AddDays(1)
        End While
        Return Dates
    End Function
End Module
