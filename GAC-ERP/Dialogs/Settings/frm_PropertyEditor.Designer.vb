<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PropertyEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PropertyEditor))
        Me.PropertyGrid = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PropertyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PropertyGrid
        '
        Me.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid.Name = "PropertyGrid"
        Me.PropertyGrid.Size = New System.Drawing.Size(290, 430)
        Me.PropertyGrid.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_Save)
        Me.PanelControl1.Controls.Add(Me.btn_Cancel)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 430)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(290, 38)
        Me.PanelControl1.TabIndex = 1
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(5, 6)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 27)
        Me.btn_Cancel.TabIndex = 0
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(210, 6)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 27)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        '
        'frm_PropertyEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 468)
        Me.Controls.Add(Me.PropertyGrid)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 500)
        Me.Name = "frm_PropertyEditor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Property Editor"
        CType(Me.PropertyGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PropertyGrid As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
End Class
