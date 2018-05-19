Imports System.Data.SqlClient

Public Module Database
    Function GetStaff(ByVal Username As String) As Staff
        Dim staff As Staff = Nothing

        Dim Connection As SqlConnection = GetConnection()
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If
        Using cmd1 As New SqlCommand("SELECT * FROM Staffs WHERE Username = @Username", Connection)
            cmd1.Parameters.Add(New SqlParameter("@Username", Username))
            Using Reader As SqlDataReader = cmd1.ExecuteReader

                While Reader.Read
                    Dim Name As String = Reader.Item("Name")
                    Dim Permissions As New List(Of Permission)
                    If Reader.Item("Permissions") IsNot Nothing Then
                        For Each i As Integer In Reader.Item("Permissions").ToString.Split(",")
                            Permissions.Add(i)
                        Next
                    End If
                    staff = New Staff(Name, Username, Permissions)
                End While
            End Using
        End Using

        Connection.Close()

        Return staff
    End Function
    Function GetStaff(ByVal Username As String, ByVal Connection As SqlConnection) As Staff
        Dim staff As Staff = Nothing

        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If
        Using cmd1 As New SqlCommand("SELECT * FROM Staffs WHERE Username = @Username", Connection)
            cmd1.Parameters.Add(New SqlParameter("@Username", Username))
            Using Reader As SqlDataReader = cmd1.ExecuteReader
                While Reader.Read
                    Dim Name As String = Reader.Item("Name")
                    Dim Permissions As New List(Of Permission)
                    If Reader.Item("Permissions") IsNot Nothing Then
                        For Each i As Integer In Reader.Item("Permissions").ToString.Split(",")
                            Permissions.Add(i)
                        Next
                    End If
                    staff = New Staff(Name, Username, Permissions)
                End While
            End Using
        End Using

            Return staff
    End Function
    Function GetAdmissionEntries(ByVal CloseConnectionOnFinish As Boolean) As List(Of AdmissionEntry)
        Dim r As New List(Of AdmissionEntry)
        Try
            Dim conn As SqlConnection = GetConnection()
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()
            End If
            Using cmd As New SqlCommand("SELECT *  FROM Admission", conn)
                Using dr As SqlDataReader = cmd.ExecuteReader
                    While dr.Read
                        Dim ID As Integer = dr.Item("ID")
                        Dim RegNo As Integer = dr.Item("Registration")
                        Dim ApplicationNo As Integer = dr.Item("Application")
                        Dim NameofCandidate As String = dr.Item("Name").ToString
                        Dim Gender As String = dr.Item("Gender").ToString
                        Dim Stream As String = dr.Item("Stream").ToString
                        Dim Rank As Integer = dr.Item("Rank")
                        Dim Community As String = dr.Item("Community").ToString
                        Dim CutOff As Integer = dr.Item("CutOff")
                        Dim Course As String = dr.Item("Course").ToString
                        Dim Shift As String = dr.Item("Shift").ToString
                        Dim Medium As String = dr.Item("Medium").ToString
                        Dim Quota As String = dr.Item("Quota").ToString
                        Dim SpecialQuota As String = dr.Item("SpecialQuota").ToString
                        Dim DateOfAdmission As Date = If(Date.TryParse(dr.Item("AdmissionDate"), DateOfAdmission), Date.Parse(dr.Item("AdmissionDate")), Now)
                        Dim CourseID As String = dr.Item("CourseID").ToString
                        Dim AllottedGender As String = dr.Item("AllottedGender").ToString
                        Dim AllottedStream As String = dr.Item("AllottedStream").ToString
                        Dim AllottedCommunity As String = dr.Item("AllottedCommunity").ToString
                        Dim Remarks As String = dr.Item("Remarks").ToString
                        Dim FeesPaid As Boolean = dr.Item("FeesPaid")
                        Dim FessPaidAmount As Integer = dr.Item("FeesPaidAmount")
                        Dim State As String = dr.Item("State")
                        r.Add(New AdmissionEntry(ID, NameofCandidate, Gender, RegNo, Rank, ApplicationNo, Community, CutOff, Course, Shift, Medium, Stream, Quota, AllottedGender, AllottedStream, AllottedCommunity, Remarks, DateOfAdmission, FeesPaid, FessPaidAmount, SpecialQuota, CourseID, State))
                    End While
                End Using
            End Using
            If CloseConnectionOnFinish Then conn.Close()
        Catch ex As Exception
            MsgBox("Error while loading courses" & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return r
    End Function
    Function GetCoureses(ByVal CloseConnectionOnFinish As Boolean) As List(Of Course)
        Dim r As New List(Of Course)
        Try
            Dim conn As SqlConnection = GetConnection()
            If (conn.State = ConnectionState.Closed) Then
                conn.Open()
            End If
            Using cmd As New SqlCommand("SELECT *  FROM Courses", conn)
                Using dr As SqlDataReader = cmd.ExecuteReader
                    While dr.Read
                        Dim ID As Integer = dr.Item("ID")
                        Dim Code As String = dr.Item("Code").ToString
                        Dim CourseName As String = dr.Item("Name").ToString
                        Dim Medium As String = dr.Item("Medium").ToString
                        Dim Shift As String = dr.Item("Shift").ToString
                        Dim Department As String = dr.Item("Department").ToString
                        Dim Duration As Integer = dr.Item("Duration")
                        Dim MaxSeats As Integer = dr.Item("MaxSeats")
                        Dim FeesStructure As String = dr.Item("FeesStructure").ToString

                        r.Add(New Course(ID, Code, CourseName, Medium, Shift, Department, Duration, MaxSeats, FeesStructure))
                    End While
                End Using
            End Using
            If CloseConnectionOnFinish Then conn.Close()
        Catch ex As Exception
            MsgBox("Error while loading courses" & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return r
    End Function


    Function NewAdmissionEntry(ByVal RegNo As Integer, ByVal ApplicationNo As Integer, ByVal NameofCandidate As String, ByVal Gender As String, ByVal Stream As String, ByVal Rank As Integer, ByVal Community As String, ByVal CutOff As Integer, ByVal Course As String, ByVal Shift As String, ByVal Medium As String, ByVal Quota As String, ByVal SpecialQuota As String, ByVal DateOfAdmission As Date, ByVal CourseID As String, ByVal AllottedGender As String, ByVal AllottedStream As String, ByVal AllottedCommunity As String, ByVal Remarks As String, ByVal State As String)
        Try
            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
            Dim query As String = "INSERT INTO Admission "
            query &= "(Name, Gender, Registration, Rank, Application, Community, CutOff, Course, Shift, Medium, Stream, Quota, AllottedGender, AllottedStream, AllottedCommunity, Remarks, AdmissionDate, FeesPaid, FeesPaidAmount, SpecialQuota, CourseID,State)  "
            query &= "VALUES (@Name,@Gender,@Registration,@Rank,@Application,@Community,@CutOff,@Course,@Shift,@Medium,@Stream,@Quota,@AllottedGender,@AllottedStream,@AllottedCommunity,@Remarks,@AdmissionDate,@FeesPaid,@FeesPaidAmount,@SpecialQuota,@CourseID,@State);SELECT SCOPE_IDENTITY()"


            Using comm As New SqlCommand()
                With comm
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Name", NameofCandidate)
                    .Parameters.AddWithValue("@Gender", Gender)
                    .Parameters.AddWithValue("@Registration", RegNo)
                    .Parameters.AddWithValue("@Rank", Rank)
                    .Parameters.AddWithValue("@Application", ApplicationNo)
                    .Parameters.AddWithValue("@Community", Community)
                    .Parameters.AddWithValue("@CutOff", CutOff)
                    .Parameters.AddWithValue("@Course", Course)
                    .Parameters.AddWithValue("@Shift", Shift)
                    .Parameters.AddWithValue("@Medium", Medium)
                    .Parameters.AddWithValue("@Stream", Stream)
                    .Parameters.AddWithValue("@Quota", Quota)
                    .Parameters.AddWithValue("@AllottedGender", AllottedGender)
                    .Parameters.AddWithValue("@AllottedStream", AllottedStream)
                    .Parameters.AddWithValue("@AllottedCommunity", AllottedCommunity)
                    .Parameters.AddWithValue("@Remarks", Remarks)
                    .Parameters.AddWithValue("@AdmissionDate", DateOfAdmission)
                    .Parameters.AddWithValue("@FeesPaid", 0)
                    .Parameters.AddWithValue("@FeesPaidAmount", 0)
                    .Parameters.AddWithValue("@SpecialQuota", SpecialQuota)
                    .Parameters.AddWithValue("@CourseID", CourseID)
                    .Parameters.AddWithValue("@State", State)
                End With
                Try
                    Return comm.ExecuteScalar
                Catch ex As SqlException
                    MsgBox("Error when executing sql command " & vbNewLine & vbNewLine & ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End Try
            End Using
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return 0
    End Function

    Function EditAdmissionEntry(ByVal ID As Integer, ByVal RegNo As Integer, ByVal ApplicationNo As Integer, ByVal NameofCandidate As String, ByVal Gender As String, ByVal Stream As String, ByVal Rank As Integer, ByVal Community As String, ByVal CutOff As Integer, ByVal Course As String, ByVal Shift As String, ByVal Medium As String, ByVal Quota As String, ByVal SpecialQuota As String, ByVal CourseID As String, ByVal AllottedGender As String, ByVal AllottedStream As String, ByVal AllottedCommunity As String, ByVal Remarks As String, ByVal State As String)
        Dim r As Integer = 0
        Try
            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
            Dim query As String = "UPDATE Admission SET "
            query &= "Name = @Name, Gender = @Gender, Registration = @Registration, Rank = @Rank, Application = @Application, Community = @Community, CutOff = @CutOff, Course = @Course, Shift = @Shift, Medium = @Medium, Stream = @Stream, Quota = @Quota, AllottedGender = @AllottedGender, AllottedStream = @AllottedStream, AllottedCommunity = @AllottedCommunity, Remarks = @Remarks, SpecialQuota = @SpecialQuota, CourseID = @CourseID, State = @State"
            query &= " WHERE ID = @ID"


            Using comm As New SqlCommand()
                With comm
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Name", NameofCandidate)
                    .Parameters.AddWithValue("@Gender", Gender)
                    .Parameters.AddWithValue("@Registration", RegNo)
                    .Parameters.AddWithValue("@Rank", Rank)
                    .Parameters.AddWithValue("@Application", ApplicationNo)
                    .Parameters.AddWithValue("@Community", Community)
                    .Parameters.AddWithValue("@CutOff", CutOff)
                    .Parameters.AddWithValue("@Course", Course)
                    .Parameters.AddWithValue("@Shift", Shift)
                    .Parameters.AddWithValue("@Medium", Medium)
                    .Parameters.AddWithValue("@Stream", Stream)
                    .Parameters.AddWithValue("@Quota", Quota)
                    .Parameters.AddWithValue("@AllottedGender", AllottedGender)
                    .Parameters.AddWithValue("@AllottedStream", AllottedStream)
                    .Parameters.AddWithValue("@AllottedCommunity", AllottedCommunity)
                    .Parameters.AddWithValue("@Remarks", Remarks)
                    .Parameters.AddWithValue("@SpecialQuota", SpecialQuota)
                    .Parameters.AddWithValue("@CourseID", CourseID)
                    .Parameters.AddWithValue("@ID", ID)
                    .Parameters.AddWithValue("@State", State)
                End With

                Try
                    r = comm.ExecuteNonQuery()
                Catch ex As SqlException
                    MsgBox("Error when executing sql command " & vbNewLine & vbNewLine & ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End Try
            End Using
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return r
    End Function

    Function DeleteAdmissionEntry(ByVal ID As Integer)
        Dim r As Integer = 0
        Dim con As SqlConnection = GetConnection()
        Dim cmd As New SqlCommand
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM Admission WHERE ID = @ID"
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            r = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error while deleting record " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        Finally
            con.Close()
        End Try
        Return r
    End Function

    Function NewCourse(ByVal Code As String, ByVal Name As String, ByVal Medium As String, ByVal Shift As String, ByVal Department As String, ByVal Duration As String, ByVal MaxSeats As String) As Integer
        Try
            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
            Dim query As String = "INSERT INTO Courses "
            query &= "(Code,Name,Medium,Shift,Department,Duration,MaxSeats)  "
            query &= "VALUES (@Code,@Name,@Medium,@Shift,@Department,@Duration,@MaxSeats);SELECT SCOPE_IDENTITY()"


            Using comm As New SqlCommand()
                With comm
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Code", Code)
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Medium", Medium)
                    .Parameters.AddWithValue("@Shift", Shift)
                    .Parameters.AddWithValue("@Department", Department)
                    .Parameters.AddWithValue("@Duration", Duration)
                    .Parameters.AddWithValue("@MaxSeats", MaxSeats)
                End With
                Try
                    Return comm.ExecuteScalar
                Catch ex As SqlException
                    MsgBox("Error when executing sql command " & vbNewLine & vbNewLine & ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End Try
            End Using
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return 0
    End Function

    Function EditCourse(ByVal ID As Integer, ByVal Code As String, ByVal Name As String, ByVal Medium As String, ByVal Shift As String, ByVal Department As String, ByVal Duration As String, ByVal MaxSeats As String) As Integer
        Dim r As Integer = 0
        Try
            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
            Dim query As String = "UPDATE Courses SET "
            query &= "Code = @Code, Name = @Name, Medium = @Medium, Shift = @Shift, Department = @Department, Duration = @Duration, MaxSeats = @MaxSeats"
            query &= " WHERE ID = @ID"


            Using comm As New SqlCommand()
                With comm
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", ID)
                    .Parameters.AddWithValue("@Code", Code)
                    .Parameters.AddWithValue("@Name", Name)
                    .Parameters.AddWithValue("@Medium", Medium)
                    .Parameters.AddWithValue("@Shift", Shift)
                    .Parameters.AddWithValue("@Department", Department)
                    .Parameters.AddWithValue("@Duration", Duration)
                    .Parameters.AddWithValue("@MaxSeats", MaxSeats)
                End With

                Try
                    r = comm.ExecuteNonQuery()
                Catch ex As SqlException
                    MsgBox("Error when executing sql command " & vbNewLine & vbNewLine & ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End Try
            End Using
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return r
    End Function

    Function DeleteCourse(ByVal ID As Integer) As Integer
        Dim r As Integer = 0
        Dim con As SqlConnection = GetConnection()
        Dim cmd As New SqlCommand
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM Courses WHERE ID = @ID"
            cmd.Parameters.Add(New SqlParameter("@ID", ID))
            r = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error while deleting record " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        Finally
            con.Close()
        End Try
        Return r
    End Function

    Function UpdateCourseFeesDetails(ByVal ID As Integer, ByVal FeesStructureXML As String)
        Dim r As Integer = 0
        Try
            Dim Connection As SqlConnection = GetConnection()
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
            Dim query As String = "UPDATE Courses SET "
            query &= "FeesStructure = @FeesStructure"
            query &= " WHERE ID = @ID"


            Using comm As New SqlCommand()
                With comm
                    .Connection = Connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@FeesStructure", FeesStructureXML)
                    .Parameters.AddWithValue("@ID", ID)
                End With

                Try
                    r = comm.ExecuteNonQuery()
                Catch ex As SqlException
                    MsgBox("Error when executing sql command " & vbNewLine & vbNewLine & ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                End Try
            End Using
            Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        Return r
    End Function
End Module
