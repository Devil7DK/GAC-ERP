Public Class AdmissionReceipt
    Property ID As Int64
    Property ReceiptDate As Date
    Property AmountDetails As FeesStructure
    Property AdmissionEntry As AdmissionEntry
    Property Course As Course
    Property ReceiptNumber As String
    Sub New(ByVal ID As Int64, ByVal ReceiptDate As Date, ByVal AmountDetails As FeesStructure, ByVal AdmissionEntry As AdmissionEntry, ByVal Course As Course, ByVal ReceiptNumber As String)
        Me.ID = ID
        Me.ReceiptDate = ReceiptDate
        Me.AmountDetails = AmountDetails
        Me.AdmissionEntry = AdmissionEntry
        Me.Course = Course
        Me.ReceiptNumber = ReceiptNumber
    End Sub
    Sub New(ByVal ID As Int64, ByVal ReceiptDate As Date, ByVal AmountDetailsXML As String, ByVal AdmissionEntryXML As String, ByVal CourseXML As String, ByVal ReceiptNumber As String)
        Me.ID = ID
        Me.ReceiptDate = ReceiptDate
        Me.AmountDetails = AmountDetails
        Me.Course = Course
        Me.ReceiptNumber = ReceiptNumber
        If AmountDetailsXML <> "" Then
            Me.AmountDetails = FeesStructureIO.ReadXML(AmountDetailsXML)
        End If
        If AdmissionEntryXML <> "" Then
            Me.AdmissionEntry = AdmissionEntry.ReadXML(AdmissionEntryXML)
        End If
        If CourseXML <> "" Then
            Me.Course = Course.ReadXML(CourseXML)
        End If
    End Sub
End Class
