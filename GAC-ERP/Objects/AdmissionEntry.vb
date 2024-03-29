﻿Imports System.ComponentModel
Imports System.Xml.Serialization

Public Class AdmissionEntry
    Property ID As Int64

    <DisplayName("Name of Candidate")>
    Property Name As String
    Property Gender As String

    <DisplayName("Registration No.")>
    Property Registration As String
    Property Rank As Integer
    Property Application As String
    Property Community As String
    Property CutOff As Integer
    Property Course As String
    Property Shift As String
    Property Medium As String
    Property Stream As String
    Property Quota As String
    Property AllottedGender As String
    Property AllottedStream As String
    Property AllottedCommunity As String
    Property Remarks As String
    Property AdmissionDate As Date
    Property SpecialQuota As String
    Property CourseID As String
    Property State As String
    Sub New()
        Me.AdmissionDate = Now
        Me.AllottedCommunity = ""
        Me.AllottedGender = ""
        Me.AllottedStream = ""
        Me.Application = ""
        Me.Community = ""
        Me.Course = ""
        Me.CourseID = ""
        Me.CutOff = 0
        Me.Gender = ""
        Me.ID = 0
        Me.Medium = ""
        Me.Name = ""
        Me.Quota = ""
        Me.Rank = 0
        Me.Registration = ""
        Me.Remarks = ""
        Me.Shift = ""
        Me.SpecialQuota = ""
        Me.Stream = ""
        Me.State = ""
    End Sub
    Sub New(ByVal ID As Int64, ByVal Name As String, ByVal Gender As String, ByVal Registration As String, ByVal Rank As Integer, ByVal Application As String, ByVal Community As String, ByVal CutOff As Integer, ByVal Course As String, ByVal Shift As String, ByVal Medium As String, ByVal Stream As String, ByVal Quota As String, ByVal AllottedGender As String, ByVal AllottedStream As String, ByVal AllottedCommunity As String, ByVal Remarks As String, ByVal AdmissionDate As Date, ByVal SpecialQuota As String, ByVal CourseID As String, ByVal State As String)
        Me.AdmissionDate = AdmissionDate
        Me.AllottedCommunity = AllottedCommunity
        Me.AllottedGender = AllottedGender
        Me.AllottedStream = AllottedStream
        Me.Application = Application
        Me.Community = Community
        Me.Course = Course
        Me.CourseID = CourseID
        Me.CutOff = CutOff
        Me.Gender = Gender
        Me.ID = ID
        Me.Medium = Medium
        Me.Name = Name
        Me.Quota = Quota
        Me.Rank = Rank
        Me.Registration = Registration
        Me.Remarks = Remarks
        Me.Shift = Shift
        Me.SpecialQuota = SpecialQuota
        Me.Stream = Stream
        Me.State = State
    End Sub
    Sub Update(ByVal Name As String, ByVal Gender As String, ByVal Rank As Integer, ByVal Application As String, ByVal Community As String, ByVal CutOff As Integer, ByVal Course As String, ByVal Shift As String, ByVal Medium As String, ByVal Stream As String, ByVal Quota As String, ByVal AllottedGender As String, ByVal AllottedStream As String, ByVal AllottedCommunity As String, ByVal Remarks As String, ByVal SpecialQuota As String, ByVal CourseID As String, ByVal State As String)
        Me.AllottedCommunity = AllottedCommunity
        Me.AllottedGender = AllottedGender
        Me.AllottedStream = AllottedStream
        Me.Application = Application
        Me.Community = Community
        Me.Course = Course
        Me.CourseID = CourseID
        Me.CutOff = CutOff
        Me.Gender = Gender
        Me.Medium = Medium
        Me.Name = Name
        Me.Quota = Quota
        Me.Rank = Rank
        Me.Registration = Registration
        Me.Remarks = Remarks
        Me.Shift = Shift
        Me.SpecialQuota = SpecialQuota
        Me.Stream = Stream
        Me.State = State
    End Sub
    Public Shared Function WriteToXML(ByVal AdmissionEntry As AdmissionEntry) As String
        Dim r As String = ""
        Try
            Dim objStreamWriter As New IO.MemoryStream
            Dim xsSerialize As New XmlSerializer(AdmissionEntry.GetType)
            xsSerialize.Serialize(objStreamWriter, AdmissionEntry)
            r = Text.Encoding.ASCII.GetString(objStreamWriter.ToArray)
            objStreamWriter.Close()
        Catch ex As Exception

        End Try
        Return r
    End Function
    Public Shared Function ReadXML(ByVal XML As String) As AdmissionEntry
        Dim r As New AdmissionEntry
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
