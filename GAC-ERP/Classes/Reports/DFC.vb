Imports DevExpress.Spreadsheet
Public Class DFC
    Dim Courses As List(Of Course)
    Dim FromDate As Date
    Dim ToDate As Date
    Dim SavePath As String = ""
    Dim WorkSheetHeader As String = "GOVERNMENT ARTS COLLEGE (AUTONOMOUS)  COIMBATORE  -  641 018"
    Dim WorkSheetTableTitle As String = "ADMISSION      {0}      DFC  DATE - {1}"

    Event StatusChanged(ByVal e As EventArgs, ByVal StatusText As String, ByVal Progress As Integer, ByVal isIndeterminate As Boolean)
    Event Completed(ByVal e As EventArgs, ByVal Status As Status)
    Enum Status
        Success
        NoData
    End Enum
    Sub New(ByVal FromDate As Date, ByVal ToDate As Date, ByVal SavePath As String)
        Me.FromDate = FromDate
        Me.ToDate = ToDate
        Me.Courses = GetCoureses(True)
        Me.SavePath = SavePath
    End Sub
    Sub GenerateReport()
        RaiseEvent StatusChanged(New EventArgs, "Initializing...", 0, True)
        Dim WorkBook As New Workbook
        Dim Dates As List(Of Date) = GetDates(FromDate, ToDate)
        RaiseEvent StatusChanged(New EventArgs, "Listing Columns...", 0, True)
        Dim Columns As List(Of ColumnObject) = GetColumns()

        Dim ColumnIndex As Integer = 8
        Dim Groups_ As New List(Of String)
        For Each i As ColumnObject In Columns
            If Not Groups_.Contains(i.Group) AndAlso i.Group <> "" Then
                Groups_.Add(i.Group)
            End If
        Next
        For Each i As String In Groups_
            For Each c As ColumnObject In Columns
                If c.Group = i Then
                    If c.Index = 0 Then
                        c.Index = ColumnIndex
                        ColumnIndex += 1
                    End If
                End If
            Next
            Columns.Add(New ColumnObject(i, "Total", ColumnIndex, True, False))
            ColumnIndex += 1
        Next
        For Each c As ColumnObject In Columns
            If c.Index = 0 Then
                c.Index = ColumnIndex
                ColumnIndex += 1
            End If
        Next
        Dim RowStart As Integer = 5

        For date_index As Integer = 0 To Dates.Count - 1
            Dim CurrentDate As Date = Dates(date_index)
            RaiseEvent StatusChanged(New EventArgs, "Fetching bills of " & CurrentDate.ToString("dd/MM/yyyy"), 0, True)
            Dim Bills As List(Of AdmissionReceipt) = GetAdmissionReceipts(CurrentDate, False)
            If Bills.Count > 0 Then
                Dim WorkSheet As Worksheet = WorkBook.Worksheets.Add(CurrentDate.ToString("dd-MM-yyyy"))
                Dim RowIndex As Integer = RowStart

                RaiseEvent StatusChanged(New EventArgs, "Writing Columns...", 0, True)
                For Each i As ColumnObject In Columns
                    If i.Group = "" Then
                        Dim R As Range = WorkSheet.Range(String.Format("{0}3: {0}4", ColumnIndexToColumnLetter(i.Index)))
                        WorkSheet.MergeCells(R)
                        Dim Cell As Cell = WorkSheet.Cells(ColumnIndexToColumnLetter(i.Index) & "3")
                        Cell.SetValue(i.Name)
                        Cell.Alignment.RotationAngle = 90
                        R.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
                        R.Borders.TopBorder.LineStyle = BorderLineStyle.Medium
                        R.Borders.LeftBorder.LineStyle = BorderLineStyle.Medium
                        R.Borders.RightBorder.LineStyle = BorderLineStyle.Medium
                        R.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                    Else
                        Dim Cell As Cell = WorkSheet.Cells(ColumnIndexToColumnLetter(i.Index) & "4")
                        Cell.SetValue(i.Name)
                        Cell.Alignment.RotationAngle = 90
                        Cell.Borders.BottomBorder.LineStyle = BorderLineStyle.Thin
                        Cell.Borders.TopBorder.LineStyle = BorderLineStyle.Thin
                        Cell.Borders.LeftBorder.LineStyle = BorderLineStyle.Thin
                        Cell.Borders.RightBorder.LineStyle = BorderLineStyle.Thin
                        Cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                    End If
                Next
                For Each i As String In Groups_
                    Dim StartIndex As Integer = Integer.MaxValue
                    Dim EndIndex As Integer = 0
                    For Each c As ColumnObject In Columns
                        If c.Group = i Then
                            If StartIndex > c.Index Then StartIndex = c.Index
                            If EndIndex < c.Index Then EndIndex = c.Index
                        End If
                    Next
                    WorkSheet.MergeCells(WorkSheet.Range(String.Format("{0}3:{1}3", ColumnIndexToColumnLetter(StartIndex), ColumnIndexToColumnLetter(EndIndex))))
                    Dim Cell As Cell = WorkSheet.Cells(String.Format("{0}3", ColumnIndexToColumnLetter(StartIndex)))
                    Cell.SetValue(i)
                    Cell.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                    Dim R As Range = WorkSheet.Range(String.Format("{0}3:{1}4", ColumnIndexToColumnLetter(StartIndex), ColumnIndexToColumnLetter(EndIndex)))
                    R.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
                    R.Borders.TopBorder.LineStyle = BorderLineStyle.Medium
                    R.Borders.LeftBorder.LineStyle = BorderLineStyle.Medium
                    R.Borders.RightBorder.LineStyle = BorderLineStyle.Medium
                Next

                RaiseEvent StatusChanged(New EventArgs, "Preparing Sheet...", 0, True)
                WorkSheet.MergeCells(WorkSheet.Range(String.Format("A1:{0}1", ColumnIndexToColumnLetter(Columns.Count))))
                Dim Cell_CollegeName As Cell = WorkSheet.Cells("A1")
                Cell_CollegeName.SetValue(WorkSheetHeader)
                Cell_CollegeName.Font.Bold = True
                Cell_CollegeName.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                Cell_CollegeName.Alignment.Vertical = SpreadsheetHorizontalAlignment.Center
                WorkSheet.MergeCells(WorkSheet.Range(String.Format("A2:{0}2", ColumnIndexToColumnLetter(Columns.Count))))
                Dim Cell_Header As Cell = WorkSheet.Cells("A2")
                Cell_Header.SetValue(String.Format(WorkSheetTableTitle, GetAcadamicYear(CurrentDate), CurrentDate.ToString("dd/MM/yyyy").Replace("-", "/")))
                Cell_Header.Font.Bold = True
                Cell_Header.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                Cell_Header.Alignment.Vertical = SpreadsheetHorizontalAlignment.Center

                Dim GrandTotalColumn As ColumnObject = Columns.Find(Function(c) c.Group = "" And c.Name = "Grand Total")
                For receipt_index As Integer = 0 To Bills.Count - 1
                    Dim Receipt As AdmissionReceipt = Bills(receipt_index)
                    RaiseEvent StatusChanged(New EventArgs, "Writing Entries...", (((receipt_index + 1) / Bills.Count) * 100), False)
                    Dim GrandTotal As Integer = 0
                    WorkSheet.Cells("A" & RowIndex).SetValue(RowIndex - (RowStart - 1))
                    WorkSheet.Cells("B" & RowIndex).SetValue(Receipt.ReceiptNumber)
                    WorkSheet.Cells("C" & RowIndex).SetValue(Receipt.AdmissionEntry.Name)
                    WorkSheet.Cells("D" & RowIndex).SetValue(Receipt.AdmissionEntry.Registration)
                    WorkSheet.Cells("E" & RowIndex).SetValue(Receipt.AdmissionEntry.CourseID)
                    WorkSheet.Cells("F" & RowIndex).SetValue(If(Receipt.AdmissionEntry.Medium = "Tamil", "TM", "EN"))
                    WorkSheet.Cells("G" & RowIndex).SetValue(Receipt.AdmissionEntry.AllottedCommunity)

                    For Each i As FeesGroup In Receipt.AmountDetails.PrimaryFeesGroups
                        i.CalculateTotal()
                        Dim PrimaryValue As Boolean = (Receipt.AdmissionEntry.State = "Tamil Nadu")
                        For Each h As FeesHead In i.FeesHeads
                            GrandTotal += If(PrimaryValue, h.Value1, h.Value2)
                            Dim Column As ColumnObject = Columns.Find(Function(c) c.Group = i.Name And c.Name = h.Name)
                            If Column IsNot Nothing Then
                                Dim ValueCell As Cell = WorkSheet.Cells(ColumnIndexToColumnLetter(Column.Index) & RowIndex)
                                ValueCell.SetValue(If(PrimaryValue, h.Value1, h.Value2))
                                ValueCell.NumberFormat = "0"
                            End If
                        Next
                        Dim TotalColumn As ColumnObject = Columns.Find(Function(c) c.Group = i.Name And c.Name = "Total")
                        If TotalColumn IsNot Nothing Then
                            Dim ValueCell As Cell = WorkSheet.Cells(ColumnIndexToColumnLetter(TotalColumn.Index) & RowIndex)
                            ValueCell.SetValue(If(PrimaryValue, i.Total1, i.Total2))
                            ValueCell.NumberFormat = "0"
                        End If
                    Next
                    If GrandTotalColumn IsNot Nothing Then
                        Dim ValueCell As Cell = WorkSheet.Cells(ColumnIndexToColumnLetter(GrandTotalColumn.Index) & RowIndex)
                        ValueCell.SetValue(GrandTotal)
                        ValueCell.NumberFormat = "0"
                    End If
                    Dim RowRange As Range = WorkSheet.Range(String.Format("A{0}:{1}{0}", RowIndex, ColumnIndexToColumnLetter(GrandTotalColumn.Index)))
                    RowRange.Borders.BottomBorder.LineStyle = BorderLineStyle.Thin
                    RowRange.Borders.TopBorder.LineStyle = BorderLineStyle.Thin
                    RowRange.Borders.LeftBorder.LineStyle = BorderLineStyle.Medium
                    RowRange.Borders.RightBorder.LineStyle = BorderLineStyle.Medium
                    RowRange.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin
                    RowIndex += 1
                Next

                RaiseEvent StatusChanged(New EventArgs, "Finalizing Sheet...", 0, True)
                Dim Cell_ColumnTotal As Cell = WorkSheet.Cells("C" & RowIndex)
                Cell_ColumnTotal.SetValue("Total")
                For i As Integer = 8 To GrandTotalColumn.Index
                    Dim CurrentCell As Cell = WorkSheet.Cells(ColumnIndexToColumnLetter(i) & RowIndex)
                    CurrentCell.Formula = String.Format("=SUM({0}{1}:{0}{2})", ColumnIndexToColumnLetter(i), RowStart, RowIndex - 1)
                Next
                Dim RowTotalRange As Range = WorkSheet.Range(String.Format("A{0}:{1}{0}", RowIndex, ColumnIndexToColumnLetter(GrandTotalColumn.Index)))
                RowTotalRange.Borders.TopBorder.LineStyle = BorderLineStyle.Medium
                RowTotalRange.Font.Bold = True
                RowTotalRange.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin
                RowIndex += 1

                For Each i As ColumnObject In Columns
                    If i.Group = "" Then
                        Dim RowRange As Range = WorkSheet.Range(String.Format("{0}{1}:{0}{2}", ColumnIndexToColumnLetter(i.Index), RowStart, RowIndex - 1))
                        RowRange.Borders.RightBorder.LineStyle = BorderLineStyle.Medium
                    End If
                    If i.IsTotalColumn Then
                        Dim RowRange As Range = WorkSheet.Range(String.Format("{0}{1}:{0}{2}", ColumnIndexToColumnLetter(i.Index), RowStart, RowIndex - 1))
                        RowRange.Borders.RightBorder.LineStyle = BorderLineStyle.Medium
                        RowRange.Font.Bold = True
                    End If
                Next
                Dim LastRowRange As Range = WorkSheet.Range(String.Format("A{0}:{1}{0}", RowIndex - 1, ColumnIndexToColumnLetter(GrandTotalColumn.Index)))
                LastRowRange.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
                Dim WholeTableRange As Range = WorkSheet.Range(String.Format("A1:{1}{0}", RowIndex - 1, ColumnIndexToColumnLetter(GrandTotalColumn.Index)))
                WholeTableRange.AutoFitColumns
                WholeTableRange.AutoFitRows
                WorkSheet.FreezeRows(3)
            End If
        Next
        RaiseEvent StatusChanged(New EventArgs, "Saving Workbook...", 0, True)
        If WorkBook.Worksheets.Count > 1 Then
            WorkBook.Worksheets.RemoveAt(0)
            WorkBook.SaveDocument(SavePath, DevExpress.Spreadsheet.DocumentFormat.Xlsx)
            RaiseEvent Completed(New EventArgs, Status.Success)
        Else
            RaiseEvent Completed(New EventArgs, Status.NoData)
        End If
    End Sub
    Private Function GetColumns() As List(Of ColumnObject)

        Dim R As New List(Of ColumnObject)
        R.Add(New ColumnObject("", "SL.No", 1, False, False))
        R.Add(New ColumnObject("", "Fee receipt No.", 2, False, False))
        R.Add(New ColumnObject("", "Name", 3, False, False))
        R.Add(New ColumnObject("", "Reg No.", 4, False, False))
        R.Add(New ColumnObject("", "Course ID", 5, False, False))
        R.Add(New ColumnObject("", "Medium", 6, False, False))
        R.Add(New ColumnObject("", "Community", 7, False, False))

        For Each Course As Course In Courses
            Dim FS As FeesStructure = Course.GetFeesStructure
            If FS IsNot Nothing Then
                For Each FeesGroup As FeesGroup In FS.PrimaryFeesGroups
                    For Each FeesHead As FeesHead In FeesGroup.FeesHeads
                        If R.Find(Function(c) c.Group = FeesGroup.Name And c.Name = FeesHead.Name) Is Nothing Then
                            R.Add(New ColumnObject(FeesGroup.Name, FeesHead.Name, 0, False, FeesHead.isOptional))
                        End If
                    Next
                Next
            End If
        Next
        R = R.OrderBy(Function(c) c.IsOptional).ToList
        R.Add(New ColumnObject("", "Grand Total", 0, True, False))
        Return R
    End Function
    Private Function ColumnIndexToColumnLetter(colIndex As Integer) As String
        Dim div As Integer = colIndex
        Dim colLetter As String = String.Empty
        Dim modnum As Integer = 0

        While div > 0
            modnum = (div - 1) Mod 26
            colLetter = Chr(65 + modnum) & colLetter
            div = CInt((div - modnum) \ 26)
        End While

        Return colLetter
    End Function
    Private Function GetAcadamicYear(ByVal Value As Date) As String
        If Value.Month > 5 Then
            Return Value.Year & " - " & Value.Year + 1
        Else
            Return Value.Year - 1 & " - " & Value.Year
        End If
    End Function
    Private Class ColumnObject
        Property Group As String
        Property Name As String
        Property Index As Integer
        Property IsTotalColumn As Boolean
        Property IsOptional As Boolean
        Sub New(ByVal Group As String, ByVal Name As String, ByVal Index As Integer, ByVal IsTotalColumn As Boolean, ByVal IsOptional As Boolean)
            Me.Name = Name
            Me.Index = Index
            Me.Group = Group
            Me.IsTotalColumn = IsTotalColumn
            Me.IsOptional = IsOptional
        End Sub
    End Class
End Class
