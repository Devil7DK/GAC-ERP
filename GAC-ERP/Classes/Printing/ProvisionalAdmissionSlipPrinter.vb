Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ProvisionalAdmissionSlipPrinter : Inherits PrintDocument
    Dim CurrentIndex As Integer = 0
    Property AdmissionEntries As List(Of AdmissionEntry)
    Property Courses As List(Of Course)
    Property Settings As New ProvisionalAdmissionSlipPrinterSettings
    Private Sub BillPrinter_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Me.PrintPage
        Dim AdmissionEntry As AdmissionEntry = AdmissionEntries(CurrentIndex)
        Dim Course As Course = GetCourse(AdmissionEntry.CourseID, Courses)

        Dim CurrentX As Integer = e.MarginBounds.Location.X
        Dim CurrentY As Integer = e.MarginBounds.Location.Y


#Region "Header & Title"
        Dim Heading_StringFormat As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

        Dim Heading1_Size As Size = e.Graphics.MeasureString(Settings.Heading1, Settings.Heading1Font).ToSize
        Dim Heading1_Rect As New Rectangle(CurrentX, CurrentY, e.MarginBounds.Size.Width, Heading1_Size.Height)
        e.Graphics.DrawString(Settings.Heading1, Settings.Heading1Font, Brushes.Black, Heading1_Rect, Heading_StringFormat)
        CurrentY += Heading1_Size.Height + 5

        Dim Heading2_Size As Size = e.Graphics.MeasureString(Settings.Heading2, Settings.Heading2Font).ToSize
        Dim Heading2_Rect As New Rectangle(CurrentX, CurrentY, e.MarginBounds.Size.Width, Heading2_Size.Height)
        e.Graphics.DrawString(Settings.Heading2, Settings.Heading2Font, Brushes.Black, Heading2_Rect, Heading_StringFormat)
        CurrentY += Heading2_Size.Height + 5

        Dim Title_Size As Size = e.Graphics.MeasureString(Settings.ReceiptTitle, Settings.ReceiptTitleFont).ToSize
        Dim Title_Rect As New Rectangle(CurrentX, CurrentY, e.MarginBounds.Size.Width, Title_Size.Height)
        e.Graphics.DrawString(Settings.ReceiptTitle, Settings.ReceiptTitleFont, Brushes.Black, Title_Rect, Heading_StringFormat)
        CurrentY += Title_Size.Height + 30
#End Region

#Region "Student Details"
        Dim FieldFont As Font = Settings.FieldNameFont
        Dim ValueFont As Font = Settings.FieldValueFont
        Dim LineHeight As Integer = e.Graphics.MeasureString("T", FieldFont).ToSize.Height + 5

        Dim Details As New Specialized.NameValueCollection
        Dim FieldNameSize As Integer = 0

        Details.Add("Name of the Candidate", AdmissionEntry.Name)
        Details.Add("Gender", AdmissionEntry.Gender)
        Details.Add("Registration Number", AdmissionEntry.Registration)
        Details.Add("Rank No.", AdmissionEntry.Rank)
        Details.Add("Application Number", AdmissionEntry.Application)
        Details.Add("Community", AdmissionEntry.Community)
        Details.Add("Cut Off", AdmissionEntry.CutOff)
        Details.Add("Course", If(Course Is Nothing, AdmissionEntry.Course, String.Format("{0} ({1})", AdmissionEntry.Course, Course.Department)))
        Details.Add("Shift", AdmissionEntry.Shift)
        Details.Add("Medium", AdmissionEntry.Medium)
        Details.Add("Stream", AdmissionEntry.Stream)
        Details.Add("Quota", AdmissionEntry.Quota)
        Details.Add("Allotted Gender", AdmissionEntry.AllottedGender)
        Details.Add("Allotted Stream", AdmissionEntry.AllottedStream)
        Details.Add("Allotted Community", AdmissionEntry.AllottedCommunity)
        Details.Add("Remarks", AdmissionEntry.Remarks)
        Details.Add("Date of Admission", AdmissionEntry.AdmissionDate.ToString("dd/MM/yyyy"))

        For i As Integer = 0 To Details.Count - 1
            Dim size As Size = e.Graphics.MeasureString(Details.GetKey(i), FieldFont).ToSize
            If FieldNameSize < (size.Width + 30) Then
                FieldNameSize = (size.Width + 30)
            End If
            If LineHeight < (size.Height + 7) Then
                LineHeight = (size.Height + 7)
            End If
        Next

        Dim SnoSize As Size = e.Graphics.MeasureString("00.", Settings.FieldNameFont).ToSize
        Dim Spliter_Start As New Point(CurrentX + SnoSize.Width + FieldNameSize, CurrentY)
        SnoSize.Width += 10
        For i As Integer = 0 To Details.Count - 1
            e.Graphics.DrawString(i + 1 & ".", FieldFont, Brushes.Black, New Point(CurrentX, CurrentY))
            e.Graphics.DrawString(Details.GetKey(i), FieldFont, Brushes.Black, New Point(CurrentX + SnoSize.Width, CurrentY))
            e.Graphics.DrawString(Details(i), ValueFont, Brushes.Black, New Point(CurrentX + SnoSize.Width + FieldNameSize, CurrentY))
            CurrentY += LineHeight
        Next
        Dim Spliter_End As New Point(Spliter_Start.X, CurrentY)
        e.Graphics.DrawLine(Pens.DimGray, Spliter_Start, Spliter_End)
        CurrentY += 20
#End Region

#Region "Tamil Notes"
        Dim Description1Size As Size = e.Graphics.MeasureString(Settings.DescriptionText1, Settings.DescriptionFont, e.MarginBounds.Width).ToSize
        Dim Description1Rect As New Rectangle(CurrentX, CurrentY, e.MarginBounds.Width, Description1Size.Height)
        e.Graphics.DrawString(Settings.DescriptionText1, Settings.DescriptionFont, Brushes.Black, Description1Rect)
        CurrentY += Description1Size.Height + 10

        Dim Sno As Integer = 1
        Dim Items As New List(Of String)
        Items.AddRange(Settings.DescriptionDocumentsList.Trim.Split(vbNewLine))
        Items.Add(Settings.FeesLine & " " & If(AdmissionEntry.State = "Tamil Nadu", Course.Fees1, Course.Fees2))
        For Each i As String In Items
            Dim DocumentSize As Size = e.Graphics.MeasureString(i.Trim, Settings.DescriptionFont, e.MarginBounds.Width).ToSize
            Dim DocumentRect As New Rectangle(CurrentX + 20, CurrentY, e.MarginBounds.Width, DocumentSize.Height)
            e.Graphics.DrawString(Sno & ". " & i.Trim, Settings.DescriptionFont, Brushes.Black, DocumentRect)
            Sno += 1
            CurrentY += DocumentSize.Height + 7
        Next

        Dim Description2Size As Size = e.Graphics.MeasureString(Settings.DescriptionText2, Settings.DescriptionFont, e.MarginBounds.Width).ToSize
        Dim Description2Rect As New Rectangle(CurrentX, CurrentY, e.MarginBounds.Width, Description2Size.Height)
        e.Graphics.DrawString(Settings.DescriptionText2, Settings.DescriptionFont, Brushes.Black, Description2Rect)
        CurrentY += Description2Size.Height + 30
#End Region

#Region "SignatureLine"
        Dim SignatureLine As String = Settings.SignatureLine
        Dim SignatureLine_Font As Font = Settings.SignatureLineFont
        Dim SignatureSize As Size = e.Graphics.MeasureString(SignatureLine, SignatureLine_Font).ToSize
        Dim SignatureLocation As New Point(e.MarginBounds.Location.X, e.MarginBounds.Location.Y + e.MarginBounds.Size.Height - SignatureSize.Height - 30)
        Dim SignatureStringFormat As New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center}
        e.Graphics.DrawString(SignatureLine, SignatureLine_Font, Brushes.Black, New Rectangle(SignatureLocation, New Size(e.MarginBounds.Width, SignatureSize.Height)), SignatureStringFormat)
#End Region

        CurrentIndex += 1
        If CurrentIndex < AdmissionEntries.Count Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
    Private Sub BillPrinter_BeginPrint(sender As Object, e As PrintEventArgs) Handles Me.BeginPrint
        If Settings Is Nothing Then Settings = New ProvisionalAdmissionSlipPrinterSettings
        DefaultPageSettings.Margins.Left = Settings.LeftAndRightMargin
        DefaultPageSettings.Margins.Right = Settings.LeftAndRightMargin
        DefaultPageSettings.Margins.Top = Settings.TopAndBottomMargin
        DefaultPageSettings.Margins.Bottom = Settings.TopAndBottomMargin
        CurrentIndex = 0
    End Sub

End Class

<Serializable>
Public Class ProvisionalAdmissionSlipPrinterSettings
    Sub New()
    End Sub
    Sub New(ByVal Margin As Integer, ByVal ScissorsCount As Integer, ByVal TextMargin As Integer, ByVal Heading1 As String, ByVal Heading1Font As Font, ByVal Heading2 As String, ByVal Heading2Font As Font, ByVal ReceiptTitle As String, ByVal ReceiptTitleFont As Font, ByVal BillCopyFont As Font, ByVal FieldNameFont As Font, ByVal FieldValueFont As Font, ByVal SignatureLine As String, ByVal SignatureLineFont As Font, ByVal TableHeadingFont As Font, ByVal TableBodyFont As Font, ByVal TitleSerialNo As String, ByVal TitleFeesHead As String, ByVal TitleAmount As String, ByVal TitleTotal As String, ByVal PrintBorder As Boolean, ByVal PutInstituteCopyInFirst As Boolean, ByVal PrintAmountInWords As Boolean, ByVal AmountInWordsFont As Font)
        Me.Heading1 = Heading1
        Me.Heading1Font = Heading1Font
        Me.Heading2 = Heading2
        Me.Heading2Font = Heading2Font
        Me.ReceiptTitle = ReceiptTitle
        Me.ReceiptTitleFont = ReceiptTitleFont
        Me.FieldNameFont = FieldNameFont
        Me.FieldValueFont = FieldValueFont
        Me.SignatureLine = SignatureLine
        Me.SignatureLineFont = SignatureLineFont
    End Sub
    Property TopAndBottomMargin As Integer = 50
    Property LeftAndRightMargin As Integer = 70
    Property Heading1 As String = "Government Arts College (Autonomous), Coimbatore – 641 018."
    Property Heading1Font As New Font("Calibri", 14, FontStyle.Bold)
    Property Heading2 As String = "UG – Admission - 2015 - 2017"
    Property Heading2Font As New Font("Calibri", 14, FontStyle.Regular)
    Property ReceiptTitle As String = "PROVISIONAL ADMISSION SLIP"
    Property ReceiptTitleFont As New Font("Calibri", 14, FontStyle.Bold)
    Property FieldNameFont As New Font("Calibri", 12, FontStyle.Bold)
    Property FieldValueFont As New Font("Calibri", 12, FontStyle.Regular)
    Property SignatureLine As String = "For Principal"
    Property SignatureLineFont As New Font("Calibri", 12, FontStyle.Bold)
    Property DescriptionText1 As String
    <Editor(GetType(Design.MultilineStringEditor), GetType(Drawing.Design.UITypeEditor))>
    Property DescriptionDocumentsList As String
    Property DescriptionText2 As String
    Property DescriptionFont As New Font("Bamini", 12, FontStyle.Regular)
    Property FeesLine As String
    Public Shared Sub Write2File(ByVal PrinterSettings As ProvisionalAdmissionSlipPrinterSettings, ByVal Path As String)
        Dim stream As FileStream = File.Create(Path)
        Dim formatter As New BinaryFormatter()
        formatter.Serialize(stream, PrinterSettings)
        stream.Close()
    End Sub
    Public Shared Function ReadFile(ByVal Path As String) As ProvisionalAdmissionSlipPrinterSettings
        Dim formatter As New BinaryFormatter()
        Dim Stream = File.OpenRead(Path)
        Dim v As ProvisionalAdmissionSlipPrinterSettings = formatter.Deserialize(Stream)
        Stream.Close()
        Return v
    End Function
End Class