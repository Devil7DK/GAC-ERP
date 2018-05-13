Public Class frm_InputBox
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Sub New(ByVal Title As String, ByVal Prompt As String, Optional DefaultText As String = "")
        InitializeComponent()
        Me.Text = Title
        Me.txt_Title.Text = Prompt
        Me.Value = DefaultText
        Me.txt_Text.Text = DefaultText
    End Sub
    Property Value As String = ""

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        Me.Value = txt_Text.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub txt_Text_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Text.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_Ok.PerformClick()
        End If
    End Sub
End Class