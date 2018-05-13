<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PageSettings
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TopMargin = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_BottomMargin = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_LeftMargin = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_RightMargin = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txt_TopMargin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BottomMargin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LeftMargin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RightMargin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(259, 71)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(52, 23)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(12, 71)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(50, 23)
        Me.btn_Cancel.TabIndex = 1
        Me.btn_Cancel.Text = "Cancel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Top Margin :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Bottom Margin :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(175, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Left Margin :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(169, 43)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Right Margin :"
        '
        'txt_TopMargin
        '
        Me.txt_TopMargin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_TopMargin.Location = New System.Drawing.Point(94, 12)
        Me.txt_TopMargin.Name = "txt_TopMargin"
        Me.txt_TopMargin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_TopMargin.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_TopMargin.Size = New System.Drawing.Size(69, 20)
        Me.txt_TopMargin.TabIndex = 6
        '
        'txt_BottomMargin
        '
        Me.txt_BottomMargin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_BottomMargin.Location = New System.Drawing.Point(94, 40)
        Me.txt_BottomMargin.Name = "txt_BottomMargin"
        Me.txt_BottomMargin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_BottomMargin.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_BottomMargin.Size = New System.Drawing.Size(69, 20)
        Me.txt_BottomMargin.TabIndex = 6
        '
        'txt_LeftMargin
        '
        Me.txt_LeftMargin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_LeftMargin.Location = New System.Drawing.Point(242, 12)
        Me.txt_LeftMargin.Name = "txt_LeftMargin"
        Me.txt_LeftMargin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_LeftMargin.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_LeftMargin.Size = New System.Drawing.Size(69, 20)
        Me.txt_LeftMargin.TabIndex = 6
        '
        'txt_RightMargin
        '
        Me.txt_RightMargin.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_RightMargin.Location = New System.Drawing.Point(242, 40)
        Me.txt_RightMargin.Name = "txt_RightMargin"
        Me.txt_RightMargin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_RightMargin.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_RightMargin.Size = New System.Drawing.Size(69, 20)
        Me.txt_RightMargin.TabIndex = 6
        '
        'frm_PageSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_RightMargin)
        Me.Controls.Add(Me.txt_LeftMargin)
        Me.Controls.Add(Me.txt_BottomMargin)
        Me.Controls.Add(Me.txt_TopMargin)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_PageSettings"
        Me.Text = "Page Settings"
        CType(Me.txt_TopMargin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BottomMargin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LeftMargin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RightMargin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TopMargin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_BottomMargin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_LeftMargin As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_RightMargin As DevExpress.XtraEditors.SpinEdit
End Class
