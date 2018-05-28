Imports DevExpress.XtraGrid.Views.Base
Public Class frm_FeesStructure

    Sub New(ByVal Title As String, Optional FeesStructure As FeesStructure = Nothing)
        InitializeComponent()
        Me.Text = Title
        Me.FeesStructure = FeesStructure
    End Sub
    Property FeesStructure As FeesStructure
    Private Sub frm_DefaultFeesStructure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FeesStructure IsNot Nothing Then
            gc_FeesGroup.DataSource = FeesStructure.PrimaryFeesGroups
            For Each i As FeesGroup In gc_FeesGroup.DataSource
                i.CalculateTotal()
            Next
        End If
        If gc_FeesGroup.DataSource Is Nothing Then
            gc_FeesGroup.DataSource = New List(Of FeesGroup)
        End If
        Try
            gc_FeesGroup.RefreshDataSource()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_AddGroup_Click(sender As Object, e As EventArgs) Handles btn_AddGroup.Click
        Dim d As New frm_InputBox("New Group", "Enter name for group :")
        If d.ShowDialog = DialogResult.OK Then
            CType(gc_FeesGroup.DataSource, List(Of FeesGroup)).Add(New FeesGroup(d.Value))
            gc_FeesGroup.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_RemoveGroup_Click(sender As Object, e As EventArgs) Handles btn_RemoveGroup.Click
        If gv_FeesGroup.SelectedRowsCount = 1 Then
            Dim g As Object = gv_FeesGroup.GetRow(gv_FeesGroup.GetSelectedRows(0))
            If TypeOf g Is FeesGroup Then
                CType(gc_FeesGroup.DataSource, List(Of FeesGroup)).Remove(g)
                gc_FeesGroup.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_AddHead_Click(sender As Object, e As EventArgs) Handles btn_AddHead.Click
        If gv_FeesGroup.SelectedRowsCount = 1 Then
            Dim g As Object = gv_FeesGroup.GetRow(gv_FeesGroup.GetSelectedRows(0))
            If TypeOf g Is FeesGroup Then
                Dim d As New frm_InputBox("New Head", "Enter name for head :")
                If d.ShowDialog = DialogResult.OK Then
                    CType(g, FeesGroup).FeesHeads.Add(New FeesHead(d.Value, ""))
                    gc_FeesGroup.RefreshDataSource()
                    gc_FeesHeads.RefreshDataSource()
                End If
            End If
        End If
    End Sub

    Private Sub btn_RemoveHead_Click(sender As Object, e As EventArgs) Handles btn_RemoveHead.Click
        If gv_FeesHeads.SelectedRowsCount = 1 Then
            Dim g As Object = gv_FeesHeads.GetRow(gv_FeesHeads.GetSelectedRows(0))
            If TypeOf g Is FeesHead Then
                CType(gc_FeesHeads.DataSource, List(Of FeesHead)).Remove(g)
                gc_FeesHeads.RefreshDataSource()
                gc_FeesGroup.RefreshDataSource()
            End If
        End If
    End Sub


    Private Sub gv_FeesGroup_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gv_FeesGroup.FocusedRowChanged
        If gv_FeesGroup.SelectedRowsCount = 1 Then
            Dim g As Object = gv_FeesGroup.GetRow(gv_FeesGroup.GetSelectedRows(0))
            If TypeOf g Is FeesGroup Then
                gc_FeesHeads.DataSource = CType(g, FeesGroup).FeesHeads
                gc_FeesHeads.Tag = g
                gc_FeesHeads.RefreshDataSource()
                gv_FeesHeads.Columns("TamilName").AppearanceCell.Font = New Font("Bamini", 12)
            End If
        End If
    End Sub


    Private Sub gv_FeesHeads_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gv_FeesHeads.CellValueChanged
        Try
            If e.Column.FieldName.Contains("Value") Then
                If gc_FeesHeads.Tag IsNot Nothing Then
                    If TypeOf gc_FeesHeads.Tag Is FeesGroup Then
                        CType(gc_FeesHeads.Tag, FeesGroup).CalculateTotal()
                        gc_FeesGroup.RefreshDataSource()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            Dim g As List(Of FeesGroup) = gc_FeesGroup.DataSource
            Me.FeesStructure = New FeesStructure(g)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("Error while saving." & vbNewLine & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class