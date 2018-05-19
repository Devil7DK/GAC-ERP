<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InputBox
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
        Me.txt_Title = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Text = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Ok = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_Text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Title
        '
        Me.txt_Title.Location = New System.Drawing.Point(12, 12)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(27, 13)
        Me.txt_Title.TabIndex = 0
        Me.txt_Title.Text = "Title :"
        '
        'txt_Text
        '
        Me.txt_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Text.Location = New System.Drawing.Point(12, 31)
        Me.txt_Text.Name = "txt_Text"
        Me.txt_Text.Size = New System.Drawing.Size(242, 20)
        Me.txt_Text.TabIndex = 1
        '
        'btn_Ok
        '
        Me.btn_Ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ok.Location = New System.Drawing.Point(179, 58)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ok.TabIndex = 2
        Me.btn_Ok.Text = "Ok"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(12, 58)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 2
        Me.btn_Cancel.Text = "Cancel"
        '
        'frm_InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 93)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.txt_Text)
        Me.Controls.Add(Me.txt_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_InputBox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Box"
        CType(Me.txt_Text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Text As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
End Class
