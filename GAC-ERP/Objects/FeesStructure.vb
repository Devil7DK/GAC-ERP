Imports System.ComponentModel
Imports System.Xml.Serialization

Public Class FeesHead
    Property Name As String
    <System.ComponentModel.DisplayName("Name in Tamil")>
    Property TamilName As String
    <System.ComponentModel.DisplayName("Value")>
    Property Value1 As Double
    <System.ComponentModel.DisplayName("Value (Other State)")>
    Property Value2 As Double
    <System.ComponentModel.DisplayName("Is Optional")>
    Property isOptional As Boolean = False

    Sub New()
        Name = "-"
        Value1 = 0
        Value2 = 0
        isOptional = False
    End Sub
    Sub New(Name As String, TamilName As String)
        Me.Name = Name
        Me.TamilName = TamilName
        Me.Value1 = 0
        Me.Value2 = 0
        Me.isOptional = False
    End Sub
    Sub New(Name As String, TamilName As String, Value As Double)
        Me.Name = Name
        Me.Value1 = Value
        Me.Value2 = Value
        Me.isOptional = False
    End Sub
    Sub New(Name As String, TamilName As String, Value1 As Double, Value2 As Double)
        Me.Name = Name
        Me.Value1 = Value1
        Me.Value2 = Value2
        Me.isOptional = False
    End Sub
    Sub New(Name As String, TamilName As String, Value1 As Double, Value2 As Double, isOptional As Boolean)
        Me.Name = Name
        Me.Value1 = Value1
        Me.Value2 = Value2
        Me.isOptional = isOptional
    End Sub
    Public Overrides Function ToString() As String
        Return If(isOptional, Name & " (Optional)", Name)
    End Function


End Class
Public Class FeesGroup
    Property Name As String
    Property FeesHeads As List(Of FeesHead)

    Public Overrides Function ToString() As String
        Return Name
    End Function
    Sub New()
        Name = "-"
        FeesHeads = New List(Of FeesHead)
    End Sub
    Sub New(Name As String, FeesHeads As List(Of FeesHead))
        Me.Name = Name
        Me.FeesHeads = FeesHeads
    End Sub

    <System.ComponentModel.DisplayName("Total")>
    ReadOnly Property Total1 As Double
        Get
            Return Total_1
        End Get
    End Property
    Dim Total_1 As Double = 0
    <System.ComponentModel.DisplayName("Total (Otherstate)")>
    ReadOnly Property Total2 As Double
        Get
            Return Total_2
        End Get
    End Property
    Dim Total_2 As Double = 0
    Sub New(Name As String)
        Me.Name = Name
        Me.FeesHeads = New List(Of FeesHead)
    End Sub

    Sub CalculateTotal()
        Total_1 = 0
        Total_2 = 0
        Try
            For Each i As FeesHead In FeesHeads
                If Not i.isOptional Then
                    Total_1 += i.Value1
                    Total_2 += i.Value2
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Function Clone() As FeesGroup
        Return New FeesGroup(Me.Name, Me.FeesHeads.ToList)
    End Function
End Class
Public Class FeesStructure
    Property PrimaryFeesGroups As List(Of FeesGroup)
    Sub New()
        Me.PrimaryFeesGroups = New List(Of FeesGroup)
    End Sub
    Sub New(ByVal PrimaryFeesGroups As List(Of FeesGroup))
        Me.PrimaryFeesGroups = PrimaryFeesGroups
    End Sub
    Public Shared Function Write2XML(ByVal FeesStructure As FeesStructure) As String
        Dim r As String = ""
        Try
            Dim objStreamWriter As New IO.MemoryStream
            Dim xsSerialize As New XmlSerializer(FeesStructure.GetType)
            xsSerialize.Serialize(objStreamWriter, FeesStructure)
            r = Text.Encoding.ASCII.GetString(objStreamWriter.ToArray)
            objStreamWriter.Close()
        Catch ex As Exception

        End Try
        Return r
    End Function
    Public Shared Function ReadXML(ByVal XML As String) As FeesStructure
        Dim r As New FeesStructure
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