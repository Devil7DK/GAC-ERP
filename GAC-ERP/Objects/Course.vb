Imports System.Xml.Serialization

Public Class Course
    Property ID As Integer
    <System.ComponentModel.DisplayName("Course ID")>
    Property Code As String
    <System.ComponentModel.DisplayName("Course Name")>
    Property Name As String
    <System.ComponentModel.DisplayName("Medium of Course")>
    Property Medium As String
    Property Shift As String
    <System.ComponentModel.DisplayName("Department / Branch")>
    Property Department As String
    <System.ComponentModel.DisplayName("Duration of Course")>
    Property Duration As String
    <System.ComponentModel.DisplayName("Maximum Seats Available")>
    Property MaxSeats As String
    <System.ComponentModel.DisplayName("Basic Course Fees")>
    ReadOnly Property Fees1 As Integer
        Get
            Return Fees_1
        End Get
    End Property
    Dim Fees_1 As Integer = 0

    <System.ComponentModel.DisplayName("Basic Course Fees (Other State)")>
    ReadOnly Property Fees2 As Integer
        Get
            Return Fees_2
        End Get
    End Property
    Dim Fees_2 As Integer = 0
    Dim FeesStructure As FeesStructure
    Function GetFeesStructure() As FeesStructure
        Return If(FeesStructure Is Nothing, New FeesStructure, FeesStructure)
    End Function
    Sub SetFeesStructure(ByVal XML As String)
        FeesStructure = FeesStructureIO.ReadXML(XML)
        If FeesStructure IsNot Nothing Then
            Fees_1 = 0
            Fees_2 = 0
            For Each i As FeesGroup In FeesStructure.PrimaryFeesGroups
                i.CalculateTotal()
                Fees_1 += i.Total1
                Fees_2 += i.Total2
            Next
            For Each i As FeesHead In FeesStructure.AdditionalFeesHeads
                If Not i.isOptional Then
                    Fees_1 += i.Value1
                    Fees_2 += i.Value2
                End If
            Next
        End If
    End Sub
    Sub SetFeesStructure(ByVal FeesStructure As FeesStructure)
        If FeesStructure IsNot Nothing Then
            Me.FeesStructure = FeesStructure
            Fees_1 = 0
            Fees_2 = 0
            For Each i As FeesGroup In FeesStructure.PrimaryFeesGroups
                i.CalculateTotal()
                Fees_1 += i.Total1
                Fees_2 += i.Total2
            Next
            For Each i As FeesHead In FeesStructure.AdditionalFeesHeads
                If Not i.isOptional Then
                    Fees_1 += i.Value1
                    Fees_2 += i.Value2
                End If
            Next
        End If
    End Sub
    Sub New()
        Me.ID = 0
        Me.Code = ""
        Me.Name = ""
        Me.Medium = ""
        Me.Department = ""
        Me.Duration = ""
        Me.MaxSeats = ""
        Me.Shift = ""
    End Sub
    Sub New(ByVal ID As Integer, ByVal Code As String, ByVal Name As String, ByVal Medium As String, ByVal Shift As String, ByVal Department As String, ByVal Duration As String, ByVal MaxSeats As String, ByVal FeesStructureXML As String)
        Me.ID = ID
        Me.Code = Code
        Me.Name = Name
        Me.Medium = Medium
        Me.Department = Department
        Me.Duration = Duration
        Me.MaxSeats = MaxSeats
        Me.Shift = Shift
        If FeesStructureXML <> "" Then
            Try
                SetFeesStructure(FeesStructureXML)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub Update(ByVal Code As String, ByVal Name As String, ByVal Medium As String, ByVal Shift As String, ByVal Department As String, ByVal Duration As String, ByVal MaxSeats As String, ByVal FeesStructureXML As String)
        Me.Code = Code
        Me.Name = Name
        Me.Medium = Medium
        Me.Department = Department
        Me.Duration = Duration
        Me.MaxSeats = MaxSeats
        Me.Shift = Shift
        If FeesStructureXML <> "" Then
            Try
                SetFeesStructure(FeesStructureXML)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Public Shared Function WriteToXML(ByVal Course As Course) As String
        Dim r As String = ""
        Try
            Dim objStreamWriter As New IO.MemoryStream
            Dim xsSerialize As New XmlSerializer(Course.GetType)
            xsSerialize.Serialize(objStreamWriter, Course)
            r = Text.Encoding.ASCII.GetString(objStreamWriter.ToArray)
            objStreamWriter.Close()
        Catch ex As Exception

        End Try
        Return r
    End Function
    Public Shared Function ReadXML(ByVal XML As String) As Course
        Dim r As New Course
        Try
            Dim objStreamReader As New IO.MemoryStream(Text.Encoding.ASCII.GetBytes(XML))
            Dim xsDeserialize As New XmlSerializer(r.GetType)
            r = xsDeserialize.Deserialize(objStreamReader)
            objStreamReader.Close()
        Catch ex As Exception

        End Try
        Return r
    End Function
End Class
