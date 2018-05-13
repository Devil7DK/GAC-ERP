Module PublicSubs
    Sub ShowError(Ex As Exception)
        MsgBox(Ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    End Sub
End Module
