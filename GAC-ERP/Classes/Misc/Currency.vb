Module Currency
    Private Function ReadSingle(ByVal m As Byte) As String
        Dim st As String = ""
        Select Case m
            Case 1 : st = "One" : Case 2 : st = "Two"
            Case 3 : st = "Three" : Case 4 : st = "Four"
            Case 5 : st = "Five" : Case 6 : st = "Six"
            Case 7 : st = "Seven" : Case 8 : st = "Eight"
            Case 9 : st = "Nine" : Case 10 : st = "Ten"
            Case 11 : st = "Eleven" : Case 12 : st = "Twelve"
            Case 13 : st = "Thirteen" : Case 14 : st = "Fourteen"
            Case 15 : st = "Fifteen" : Case 16 : st = "Sixteen"
            Case 17 : st = "Seventeen" : Case 18 : st = "Eighteen"
            Case 19 : st = "Nineteen" : Case 20 : st = "Twenty"
        End Select
        ReadSingle = st
    End Function
    Private Function ReadTenths(ByVal m As Byte) As String
        Dim n As Double
        n = m \ 10
        Dim st As String = ""
        Select Case n
            Case 2 : st = "Twenty " : Case 3 : st = "Thirty "
            Case 4 : st = "Forty " : Case 5 : st = "Fifty "
            Case 6 : st = "Sixty " : Case 7 : st = "Seventy "
            Case 8 : st = "Eighty " : Case 9 : st = "Ninety "
        End Select
        ReadTenths = st
    End Function
    Private Function ReadCombined(ByVal m As Byte) As String
        Dim st As String = ""
        Dim n As Double
        If m < 21 Then
            st = ReadSingle(m)
        ElseIf m < 100 Then
            st = ReadTenths(m)
            n = m Mod (10)
            st = st & ReadSingle((n))
        End If
        ReadCombined = st
    End Function
    Function AmountInWords(ByVal m As Integer) As String
        'If m > 99999999999.0# Then Exit Function
        Dim n As Double
        n = Fix(m / 1000000000)
        Dim st As String = ""
        If m = 0 Or m < 0 Then
            st = "Rupees Zero Only"
            Return st
        End If
        If n > 0 Then
            st = st & ReadCombined((n)) & " Arab "
        End If
        m = m - n * 1000000000
        n = m \ 10000000
        If n > 0 Then
            st = st & ReadCombined((n)) & " Crore "
        End If
        n = m Mod (10000000)
        n = n \ 100000
        If n > 0 Then
            st = st & ReadCombined((n)) & " Lakh "
        End If
        n = m Mod (100000)
        n = n \ 1000
        If n > 0 Then
            st = st & ReadCombined((n)) & " Thousand "
        End If
        n = m Mod (1000)
        n = n \ 100
        If n > 0 Then
            st = st & ReadSingle((n)) & " Hundred and"
        End If
        n = m Mod (100)
        st = st & " " & ReadCombined((n))
        Return ("Rupees " & st & " Only").Trim().Replace("  ", " ")
    End Function
    Function AmountToComma(ByVal Value As Integer) As String
        Return Value.ToString("00,00,00,000").TrimStart("0,".ToArray)
    End Function
End Module
