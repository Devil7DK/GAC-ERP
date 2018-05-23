<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdmissionEntries_SearchResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdmissionEntries_SearchResult))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.gc_AdmissionEntries = New DevExpress.XtraGrid.GridControl()
        Me.gv_AdmissionEntries = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gc_AdmissionEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_AdmissionEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Padding = New System.Windows.Forms.Padding(10)
        Me.LabelControl1.Size = New System.Drawing.Size(532, 34)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Multiple entries found with given registration number. Choose exact one from foll" &
    "owing list."
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_OK)
        Me.PanelControl1.Controls.Add(Me.btn_Cancel)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 241)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(532, 35)
        Me.PanelControl1.TabIndex = 1
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.Location = New System.Drawing.Point(452, 5)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 25)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "Select"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(5, 5)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 25)
        Me.btn_Cancel.TabIndex = 0
        Me.btn_Cancel.Text = "Cancel"
        '
        'gc_AdmissionEntries
        '
        Me.gc_AdmissionEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_AdmissionEntries.Location = New System.Drawing.Point(0, 34)
        Me.gc_AdmissionEntries.MainView = Me.gv_AdmissionEntries
        Me.gc_AdmissionEntries.Name = "gc_AdmissionEntries"
        Me.gc_AdmissionEntries.Size = New System.Drawing.Size(532, 207)
        Me.gc_AdmissionEntries.TabIndex = 3
        Me.gc_AdmissionEntries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_AdmissionEntries})
        '
        'gv_AdmissionEntries
        '
        Me.gv_AdmissionEntries.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gv_AdmissionEntries.GridControl = Me.gc_AdmissionEntries
        Me.gv_AdmissionEntries.Name = "gv_AdmissionEntries"
        Me.gv_AdmissionEntries.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_AdmissionEntries.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_AdmissionEntries.OptionsBehavior.Editable = False
        Me.gv_AdmissionEntries.OptionsBehavior.ReadOnly = True
        Me.gv_AdmissionEntries.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
        Me.gv_AdmissionEntries.OptionsCustomization.AllowColumnMoving = False
        Me.gv_AdmissionEntries.OptionsLayout.Columns.AddNewColumns = False
        Me.gv_AdmissionEntries.OptionsSelection.MultiSelect = True
        '
        'frm_AdmissionEntries_SearchResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.gc_AdmissionEntries)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AdmissionEntries_SearchResult"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Admission Entry"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gc_AdmissionEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_AdmissionEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc_AdmissionEntries As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_AdmissionEntries As DevExpress.XtraGrid.Views.Grid.GridView
End Class
