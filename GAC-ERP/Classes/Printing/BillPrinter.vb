Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Public Class BillPrinter : Inherits PrintDocument
    Property Receipt As AdmissionReceipt
    Property Settings As New BillPrinterSettings
    Private Sub BillPrinter_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Me.PrintPage
        Dim CutHereLine_MarginAdjustment As Integer = e.PageSettings.Margins.Left - 20
        Dim GapBetweenRect As Integer = Settings.Margin * 2
        Dim RectWidth As Integer = e.MarginBounds.Width
        Dim RectHeight As Integer = (e.MarginBounds.Height / 2) - (GapBetweenRect / 2)

        Dim RectY_1 As Integer = 0
        Dim RectY_2 As Integer = RectHeight + GapBetweenRect
        PrintBill(e.Graphics, New Rectangle(0, RectY_1, RectWidth, RectHeight), Settings.PrintBorder, "Student's Copy", Receipt.ReceiptNumber)
        PrintCutHereLine(e.Graphics, New Rectangle(CutHereLine_MarginAdjustment * -1, RectY_1 + RectHeight, RectWidth + (CutHereLine_MarginAdjustment * 2), GapBetweenRect))
        PrintBill(e.Graphics, New Rectangle(0, RectY_2, RectWidth, RectHeight), Settings.PrintBorder, "Institute's Copy", Receipt.ReceiptNumber)
    End Sub

    Sub PrintBill(ByVal g As Graphics, ByVal Rect As Rectangle, ByVal DrawOutline As Boolean, ByVal BillType As String, ByVal ReceiptNumber As String)
        Dim CurrentX As Integer = Rect.Location.X
        Dim CurrentY As Integer = Rect.Location.Y

        Dim TextMargin As Integer = Settings.TextMargin

        If DrawOutline Then DrawRoundedRectangle(g, Rect.Location.X, Rect.Location.Y, Rect.Size.Width, Rect.Size.Height, 7)

#Region "College Logo & Header"
        CurrentX += TextMargin
        CurrentY += TextMargin
        Dim Logo As Image = My.Resources.GAC_LOGO
        Dim ZoomFactor As Integer = 20
        Dim LogoLocation As New Point(CurrentX, CurrentY)
        Dim LogoSize As New Size(Logo.Width / ZoomFactor, Logo.Height / ZoomFactor)
        g.DrawImage(Logo, New Rectangle(LogoLocation, LogoSize))
        CurrentX += LogoLocation.X + LogoSize.Width

        Dim Head_CollegeName As String = Settings.Heading1
        Dim Head_CollegeName_Font As Font = Settings.Heading1Font
        Dim Head_CollegeName_Size As Size = g.MeasureString(Head_CollegeName, Head_CollegeName_Font).ToSize
        Dim Head_CollegeName_Rect As New Rectangle(CurrentX, CurrentY, (Rect.Size.Width - (CurrentX - Rect.Location.X)), Head_CollegeName_Size.Height)
        Dim Head_CollegeName_StringFormat As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(Head_CollegeName, Head_CollegeName_Font, Brushes.Black, Head_CollegeName_Rect, Head_CollegeName_StringFormat)

        Dim Head_Address As String = Settings.Heading2
        Dim Head_Address_Font As Font = Settings.Heading2Font
        Dim Head_Address_Size As Size = g.MeasureString(Head_Address, Head_Address_Font).ToSize
        Dim Head_Address_Rect As New Rectangle(CurrentX, CurrentY + Head_CollegeName_Size.Height, (Rect.Size.Width - (CurrentX - Rect.Location.X)), Head_Address_Size.Height)
        Dim Head_Address_StringFormat As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(Head_Address, Head_Address_Font, Brushes.Black, Head_Address_Rect, Head_Address_StringFormat)

        CurrentY += LogoSize.Height
        CurrentX = Rect.Location.X
#End Region

#Region "Receipt Header"
        Dim Head_ReceiptHeader As String = Settings.ReceiptTitle
        Dim Head_ReceiptHeader_Font As Font = Settings.ReceiptTitleFont
        Dim Head_ReceiptHeader_Size As Size = g.MeasureString(Head_ReceiptHeader, Head_ReceiptHeader_Font).ToSize
        Dim Head_ReceiptHeader_Rect As New Rectangle(CurrentX, CurrentY, Rect.Size.Width, Head_ReceiptHeader_Size.Height)
        Dim Head_ReceiptHeader_StringFormat As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(Head_ReceiptHeader, Head_ReceiptHeader_Font, Brushes.Black, Head_ReceiptHeader_Rect, Head_ReceiptHeader_StringFormat)

        CurrentY += Head_ReceiptHeader_Size.Height
        CurrentX = Rect.Location.X
#End Region

#Region "Bill  No & Bill Type"
        Dim BillType_Font As Font = Settings.BillCopyFont

        Dim BillType_Size As Size = g.MeasureString(BillType, BillType_Font).ToSize
        g.DrawString(BillType, BillType_Font, Brushes.Black, New Point(CurrentX + TextMargin, CurrentY))

        CurrentY += BillType_Size.Height + 3

        g.DrawLine(New Pen(Color.Black, 1), New Point(CurrentX + TextMargin, CurrentY), New Point(CurrentX + Rect.Size.Width - TextMargin, CurrentY))

        CurrentY += 5
        CurrentX = Rect.Location.X
#End Region

#Region "Student Details"
        Dim FieldFont As Font = Settings.FieldNameFont
        Dim ValueFont As Font = Settings.FieldValueFont
        Dim LineHeight As Integer = g.MeasureString("T", FieldFont).ToSize.Height + 5

        Dim Details As New Specialized.NameValueCollection
        Dim FieldSize1 As Integer = 0
        Dim FieldSize2 As Integer = 0
        Dim Part2Size As Integer = 0
        Dim FieldX_2 As Integer = 0

        Details.Add("Receipt No.", ReceiptNumber)
        Details.Add("Date", Now.ToString("dd/MM/yyyy"))
        Details.Add("Student Name", Receipt.AdmissionEntry.Name)
        Details.Add("Reg. No.", Receipt.AdmissionEntry.Registration)
        Details.Add("Course", Receipt.Course.Name)
        Details.Add("Department / Branch", Receipt.Course.Department)

        For i As Integer = 0 To Details.Count - 1 Step 2
            Dim size As Size = g.MeasureString(Details.GetKey(i), FieldFont).ToSize
            If FieldSize1 < (size.Width + 20) Then
                FieldSize1 = (size.Width + 20)
            End If
            If LineHeight < (size.Height + 5) Then
                LineHeight = (size.Height + 5)
            End If
        Next
        For i As Integer = 1 To Details.Count - 1 Step 2
            Dim field_size As Size = g.MeasureString(Details.GetKey(i), FieldFont).ToSize
            Dim value_size As Size = g.MeasureString(": " & Details(i), FieldFont).ToSize
            If FieldSize2 < (field_size.Width + 20) Then
                FieldSize2 = (field_size.Width + 20)
            End If
            If Part2Size < ((field_size.Width + 20) + value_size.Width + TextMargin) Then
                Part2Size = ((field_size.Width + 20) + value_size.Width + TextMargin)
            End If
            If LineHeight < (field_size.Height + 5) Then
                LineHeight = (field_size.Height + 5)
            End If
        Next

        FieldX_2 = CurrentX + (Rect.Width - Part2Size)

        For i As Integer = 0 To Details.Count - 1 Step 2
            g.DrawString(Details.GetKey(i), FieldFont, Brushes.Black, New Point(CurrentX + TextMargin, CurrentY))
            g.DrawString(Details(i), ValueFont, Brushes.Black, New Point(CurrentX + TextMargin + FieldSize1, CurrentY))

            g.DrawString(Details.GetKey(i + 1), FieldFont, Brushes.Black, New Point(FieldX_2, CurrentY))
            g.DrawString(Details(i + 1), ValueFont, Brushes.Black, New Point(FieldX_2 + FieldSize2, CurrentY))

            CurrentY += LineHeight
        Next
        CurrentX += Rect.Location.X
#End Region

#Region "SignatureLine"
        Dim SignatureLine As String = Settings.SignatureLine
        Dim SignatureLine_Font As Font = Settings.SignatureLineFont
        Dim SignatureSize As Size = g.MeasureString(SignatureLine, SignatureLine_Font).ToSize
        Dim SignatureLocation As New Point(Rect.Location.X + Rect.Size.Width - SignatureSize.Width - 30, Rect.Location.Y + Rect.Size.Height - SignatureSize.Height - 20)
        g.DrawString(SignatureLine, SignatureLine_Font, Brushes.Black, SignatureLocation)
#End Region

#Region "Table"
        Dim HeadingFont As Font = Settings.TableHeadingFont
        Dim BodyFont As Font = Settings.TableBodyFont
        Dim HeadingStringFormat As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        Dim AmountStringFormat As New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center}
        Dim FeesHeadStringFormat As New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center}

        Dim Height_Header As Integer = 0
        Dim Height_Total As Integer = 0
        Dim Width_SNo As Integer = 0
        Dim Width_Amount As Integer = 0
        Dim Width_FeesHead As Integer = 0
        Dim Width_Total As Integer = 0
        Dim Width_SubTotal As Integer = 0
        Dim Fees_X_Adjustment As Integer = 50
        Dim Table_Height As Integer = (SignatureLocation.Y - CurrentY) - 40
        Dim Height_Body As Integer = g.MeasureString("T", BodyFont).Height + 3
        Dim Fees_X As Integer = 0
        Dim Amount_X As Integer = 0
        Dim Fees_Amount_Width As Integer = 0
        Dim SNo_X As Integer = 0
        Dim Total_Y

        Dim Total As Integer = 0
        Dim SNo As Integer = 0
        Dim PrimaryTotal As Boolean = (Receipt.AdmissionEntry.State = "Tamil Nadu")

        Dim SNo_Text As String = Settings.TitleSerialNo
        Dim Amount As String = Settings.TitleAmount
        Dim FeesHead As String = Settings.TitleFeesHead
        Dim Total_Text As String = Settings.TitleTotal

        Width_SNo = g.MeasureString(SNo_Text, HeadingFont).Width + 20
        Width_Amount = g.MeasureString(Amount, HeadingFont).Width + 40
        Width_FeesHead = Rect.Size.Width - ((TextMargin * 2) + Width_SNo + Width_Amount + 50)
        Width_Total = g.MeasureString(Total_Text, HeadingFont).Width + 20
        Height_Header = g.MeasureString(SNo_Text, HeadingFont).Height + 5
        Height_Total = g.MeasureString(Total_Text, HeadingFont).Height + 5
        Fees_X = CurrentX + TextMargin + Width_SNo + Fees_X_Adjustment
        Amount_X = Fees_X + Width_FeesHead
        SNo_X = CurrentX + TextMargin
        Fees_Amount_Width = Width_Amount - 10
        Total_Y = CurrentY + Table_Height - Height_Total

        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin, CurrentY), New Point(CurrentX + Rect.Width - TextMargin, CurrentY))
        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin + Width_SNo, CurrentY), New Point(CurrentX + TextMargin + Width_SNo, CurrentY + Table_Height))
        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin + Width_SNo + Fees_X_Adjustment + Width_FeesHead, CurrentY), New Point(CurrentX + TextMargin + Width_SNo + Fees_X_Adjustment + Width_FeesHead, CurrentY + Table_Height))
        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin, CurrentY + Table_Height), New Point(CurrentX + Rect.Width - TextMargin, CurrentY + Table_Height))

        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin, CurrentY + Table_Height - Height_Total), New Point(CurrentX + Rect.Width - TextMargin, CurrentY + Table_Height - Height_Total))
        g.DrawString(Total_Text, HeadingFont, Brushes.Black, New Rectangle(CurrentX + TextMargin + Width_SNo + Fees_X_Adjustment + Width_FeesHead - Width_Total, CurrentY + Table_Height - Height_Total, Width_Total, Height_Total), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})

        CurrentY += 5
        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin, CurrentY), New Point(CurrentX + Rect.Width - TextMargin, CurrentY))
        CurrentY += 1

        g.DrawString(SNo_Text, HeadingFont, Brushes.Black, New Rectangle(SNo_X, CurrentY, Width_SNo, Height_Header), HeadingStringFormat)
        g.DrawString(Amount, HeadingFont, Brushes.Black, New Rectangle(CurrentX + Rect.Width - TextMargin - Width_Amount, CurrentY, Width_Amount, Height_Header), HeadingStringFormat)
        g.DrawString(FeesHead, HeadingFont, Brushes.Black, New Rectangle(Fees_X, CurrentY, Width_FeesHead, Height_Header), FeesHeadStringFormat)

        CurrentY += Height_Header
        g.DrawLine(New Pen(Color.Black, 2), New Point(CurrentX + TextMargin, CurrentY), New Point(CurrentX + Rect.Width - TextMargin, CurrentY))
        CurrentY += 5

        For Each i As FeesGroup In Receipt.AmountDetails.PrimaryFeesGroups
            i.CalculateTotal()
            Dim FeesAmount As Integer = If(PrimaryTotal, i.Total1, i.Total2)
            SNo += 1
            Total += FeesAmount
            g.DrawString(SNo, BodyFont, Brushes.Black, New Rectangle(SNo_X, CurrentY, Width_SNo, Height_Body), HeadingStringFormat)
            g.DrawString(i.Name, BodyFont, Brushes.Black, New Rectangle(Fees_X, CurrentY, Width_FeesHead, Height_Body), FeesHeadStringFormat)
            g.DrawString(AmountToComma(FeesAmount), BodyFont, Brushes.Black, New Rectangle(Amount_X, CurrentY, Fees_Amount_Width, Height_Body), AmountStringFormat)
            CurrentY += Height_Body
        Next
        For Each i As FeesHead In Receipt.AmountDetails.AdditionalFeesHeads
            Dim FeesAmount As Integer = If(PrimaryTotal, i.Value1, i.Value2)
            SNo += 1
            Total += FeesAmount
            g.DrawString(SNo, BodyFont, Brushes.Black, New Rectangle(SNo_X, CurrentY, Width_SNo, Height_Body), HeadingStringFormat)
            g.DrawString(i.Name, BodyFont, Brushes.Black, New Rectangle(Fees_X, CurrentY, Width_FeesHead, Height_Body), FeesHeadStringFormat)
            g.DrawString(AmountToComma(FeesAmount), BodyFont, Brushes.Black, New Rectangle(Amount_X, CurrentY, Fees_Amount_Width, Height_Body), AmountStringFormat)
            CurrentY += Height_Body
        Next
        g.DrawString(AmountToComma(Total), HeadingFont, Brushes.Black, New Rectangle(Amount_X, Total_Y, Fees_Amount_Width, Height_Total), AmountStringFormat)
#End Region
    End Sub

    Public Sub PrintCutHereLine(ByVal g As Graphics, ByVal Rect As Rectangle)
        Dim ScissorCount As Integer = 3
        Dim Font As New Font("Wingdings", 12)
        Dim Scissor As String = """"
        Dim Size As Size = g.MeasureString(Scissor, Font).ToSize
        Dim ScissorGap As Integer = Rect.Size.Width / ScissorCount

        Dim DashWidth As Integer = 2
        Dim DashPen As New Pen(Color.Black, DashWidth)
        DashPen.DashStyle = Drawing2D.DashStyle.Dash
        Dim DashPoint_1 As New Point(Rect.Location.X, Rect.Location.Y + ((Rect.Size.Height - DashWidth) / 2))
        Dim DashPoint_2 As New Point(Rect.Location.X + Rect.Size.Width, Rect.Location.Y + ((Rect.Size.Height - DashWidth) / 2))

        For i As Integer = 0 To ScissorCount - 1
            Dim ScissorPoint As New Point(((Rect.Location.X + 10) + (ScissorGap * i)), (Rect.Location.Y + ((Rect.Size.Height - Size.Height) / 2)))
            g.DrawString(Scissor, Font, New SolidBrush(Color.Black), ScissorPoint)
        Next

        g.DrawLine(DashPen, DashPoint_1, DashPoint_2)
    End Sub

    Private Sub BillPrinter_BeginPrint(sender As Object, e As PrintEventArgs) Handles Me.BeginPrint
        DefaultPageSettings.Margins.Left = Settings.Margin
        DefaultPageSettings.Margins.Right = Settings.Margin
        DefaultPageSettings.Margins.Top = Settings.Margin
        DefaultPageSettings.Margins.Bottom = Settings.Margin
    End Sub
End Class

<Serializable>
Public Class BillPrinterSettings
    Sub New()
    End Sub
    Sub New(ByVal Margin As Integer, ByVal ScissorsCount As Integer, ByVal TextMargin As Integer, ByVal Heading1 As String, ByVal Heading1Font As Font, ByVal Heading2 As String, ByVal Heading2Font As Font, ByVal ReceiptTitle As String, ByVal ReceiptTitleFont As Font, ByVal BillCopyFont As Font, ByVal FieldNameFont As Font, ByVal FieldValueFont As Font, ByVal SignatureLine As String, ByVal SignatureLineFont As Font, ByVal TableHeadingFont As Font, ByVal TableBodyFont As Font, ByVal TitleSerialNo As String, ByVal TitleFeesHead As String, ByVal TitleAmount As String, ByVal TitleTotal As String, ByVal PrintBorder As Boolean)
        Me.Margin = Margin
        Me.ScissorsCount = ScissorsCount
        Me.TextMargin = TextMargin
        Me.Heading1 = Heading1
        Me.Heading1Font = Heading1Font
        Me.Heading2 = Heading2
        Me.Heading2Font = Heading2Font
        Me.ReceiptTitle = ReceiptTitle
        Me.ReceiptTitleFont = ReceiptTitleFont
        Me.BillCopyFont = BillCopyFont
        Me.FieldNameFont = FieldNameFont
        Me.FieldValueFont = FieldValueFont
        Me.SignatureLine = SignatureLine
        Me.SignatureLineFont = SignatureLineFont
        Me.TableHeadingFont = TableHeadingFont
        Me.TableBodyFont = TableBodyFont
        Me.TitleSerialNo = TitleSerialNo
        Me.TitleFeesHead = TitleFeesHead
        Me.TitleAmount = TitleAmount
        Me.TitleTotal = TitleTotal
        Me.PrintBorder = PrintBorder
    End Sub
    Property Margin As Integer = 50
    Property ScissorsCount As Integer = 3
    Property TextMargin As Integer = 10
    Property Heading1 As String = "Government Arts College (Autonomous)"
    Property Heading1Font As New Font("Consolas", 18, FontStyle.Bold)
    Property Heading2 As String = "Coimbatore - 641 018"
    Property Heading2Font As New Font("Consolas", 12, FontStyle.Regular)
    Property ReceiptTitle As String = "Admission Fees Receipt"
    Property ReceiptTitleFont As New Font("Consolas", 15, FontStyle.Bold)
    Property BillCopyFont As New Font("Consolas", 12, FontStyle.Bold)
    Property FieldNameFont As New Font("Consolas", 12, FontStyle.Bold)
    Property FieldValueFont As New Font("Consolas", 12, FontStyle.Regular)
    Property SignatureLine As String = "Received By"
    Property SignatureLineFont As New Font("Consolas", 12, FontStyle.Bold)
    Property TableHeadingFont As New Font("Consolas", 12, FontStyle.Bold)
    Property TableBodyFont As New Font("Consolas", 12, FontStyle.Regular)
    Property TitleSerialNo As String = "S.No."
    Property TitleFeesHead As String = "Fees Head"
    Property TitleAmount As String = "Amount"
    Property TitleTotal As String = "Total Amount"
    Property PrintBorder As Boolean = True
    Function Clone() As BillPrinterSettings
        Return New BillPrinterSettings(Margin, ScissorsCount, TextMargin, Heading1, Heading1Font, Heading2, Heading2Font, ReceiptTitle, ReceiptTitleFont, BillCopyFont, FieldNameFont, FieldValueFont, SignatureLine, SignatureLineFont, TableHeadingFont, TableBodyFont, TitleSerialNo, TitleFeesHead, TitleAmount, TitleTotal, PrintBorder)
    End Function
    Public Shared Sub Write2File(ByVal BillPrinterSettings As BillPrinterSettings, ByVal Path As String)
        Dim stream As FileStream = File.Create(Path)
        Dim formatter As New BinaryFormatter()
        formatter.Serialize(stream, BillPrinterSettings)
        stream.Close()
    End Sub
    Public Shared Function ReadFile(ByVal Path As String) As BillPrinterSettings
        Dim formatter As New BinaryFormatter()
        Dim Stream = File.OpenRead(Path)
        Dim v As BillPrinterSettings = formatter.Deserialize(Stream)
        Stream.Close()
        Return v
    End Function
End Class