Public Class frm_PropertyEditor
    Sub New(ByVal SelectedObject As Object)
        InitializeComponent()
        Me.SelectedObject = SelectedObject
    End Sub
    Property SelectedObject As Object
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frm_PropertyEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.PropertyGrid.SelectedObject = Me.SelectedObject
    End Sub
End Class