Namespace Printing
    Public Class ProvisionalSlip
        Private WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
        Private WithEvents PrintDialog1 As PrintDialog
        Private WithEvents PrintPreviewDialog1 As PrintPreviewDialog
        Private WithEvents RTB As RichTextBoxPrintCtrl

        Private Slip_Base As String
        Private checkPrint As Integer
        Private Sub InitializeComponent()
            Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
            Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
            Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
            Me.RTB = New RichTextBoxPrintCtrl
            '
            'PrintDialog1
            '
            Me.PrintDialog1.Document = Me.PrintDocument1
            Me.PrintDialog1.UseEXDialog = True
            '
            'PrintPreviewDialog1
            '
            Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
            Me.PrintPreviewDialog1.Document = Me.PrintDocument1
            Me.PrintPreviewDialog1.Enabled = True
            Me.PrintPreviewDialog1.Icon = My.Resources.print_preview
            Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
            Me.PrintPreviewDialog1.Visible = False
        End Sub
        Sub New()
            InitializeComponent()
            Slip_Base = My.Computer.FileSystem.ReadAllText(System.IO.Path.Combine(Application.StartupPath, "Templates", "Admission_Slip_Template.rtf"))
        End Sub
        Sub PrepareRTF(ByVal AdmissionEntry As AdmissionEntry, ByVal Course As Course)
            Dim RTF As String = Slip_Base

            RTF = RTF.Replace("<<ACADEMIC YEAR>>", Now.Year & "-" & Now.Year - 1)
            RTF = RTF.Replace("<<NAME>>", AdmissionEntry.Name)
            RTF = RTF.Replace("<<GENDER>>", AdmissionEntry.Gender)
            RTF = RTF.Replace("<<REGNO>>", AdmissionEntry.Registration)
            RTF = RTF.Replace("<<RANK>>", AdmissionEntry.Rank)
            RTF = RTF.Replace("<<APPLICATION>>", AdmissionEntry.Application)
            RTF = RTF.Replace("<<COMMUNITY>>", AdmissionEntry.Community)
            RTF = RTF.Replace("<<CUTOFF>>", AdmissionEntry.CutOff)
            RTF = RTF.Replace("<<COURSE>>", If(Course Is Nothing, AdmissionEntry.Course, String.Format("{0} ({1})", AdmissionEntry.Course, Course.Department)))
            RTF = RTF.Replace("<<SHIFT>>", AdmissionEntry.Shift)
            RTF = RTF.Replace("<<MEDIUM>>", AdmissionEntry.Medium)
            RTF = RTF.Replace("<<STREAM>>", AdmissionEntry.Stream)
            RTF = RTF.Replace("<<QUOTA>>", AdmissionEntry.Quota)
            RTF = RTF.Replace("<<ALLOT_GENDER>>", AdmissionEntry.AllottedGender)
            RTF = RTF.Replace("<<ALLOT_STREAM>>", AdmissionEntry.AllottedStream)
            RTF = RTF.Replace("<<ALLOT_COMMUNITY>>", AdmissionEntry.AllottedCommunity)
            RTF = RTF.Replace("<<REMARKS>>", AdmissionEntry.Remarks)
            RTF = RTF.Replace("<<DOA>>", AdmissionEntry.AdmissionDate)
            RTF = RTF.Replace("<<FEES>>", If(AdmissionEntry.State = "Tamil Nadu", Course.Fees1, Course.Fees2))
            RTF = RTF.Replace("<<CLPFEES>>", "700")
            RTB.Rtf = RTF

            PrintDocument1.DefaultPageSettings.Margins.Top = My.Settings.ProvisonalSlip_TopMargin
            PrintDocument1.DefaultPageSettings.Margins.Bottom = My.Settings.ProvisonalSlip_BottomMargin
            PrintDocument1.DefaultPageSettings.Margins.Left = My.Settings.ProvisonalSlip_LeftMargin
            PrintDocument1.DefaultPageSettings.Margins.Right = My.Settings.ProvisonalSlip_RightMargin

        End Sub
        Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
            checkPrint = 0
        End Sub
        Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
            checkPrint = RTB.Print(checkPrint, RTB.TextLength, e)

            If checkPrint < RTB.TextLength Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        End Sub
        Friend Sub Print(ByVal AdmissionEntry As AdmissionEntry, ByVal Course As Course)
            PrepareRTF(AdmissionEntry, Course)
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                PrintDocument1.Print()
            End If
        End Sub
        Friend Sub Print(ByVal AdmissionEntries As List(Of AdmissionEntry), ByVal Courses As List(Of Course))
            If PrintDialog1.ShowDialog() = DialogResult.OK Then
                For Each AdmissionEntry As AdmissionEntry In AdmissionEntries
                    PrepareRTF(AdmissionEntry, GetCourse(AdmissionEntry.CourseID, Courses))
                    PrintDocument1.Print()
                Next
            End If
        End Sub
        Friend Sub PrintPreview(ByVal AdmissionEntry As AdmissionEntry, ByVal Course As Course)
            PrepareRTF(AdmissionEntry, Course)
            PrintPreviewDialog1.ShowDialog()
        End Sub
    End Class
End Namespace