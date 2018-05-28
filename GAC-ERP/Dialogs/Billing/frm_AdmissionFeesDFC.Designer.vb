<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdmissionFeesDFC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdmissionFeesDFC))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_FromDate = New DevExpress.XtraEditors.DateEdit()
        Me.txt_ToDate = New DevExpress.XtraEditors.DateEdit()
        Me.txt_FilePath = New DevExpress.XtraEditors.ButtonEdit()
        Me.btn_Generate = New DevExpress.XtraEditors.SimpleButton()
        Me.dlg_Save = New System.Windows.Forms.SaveFileDialog()
        Me.txt_Progress_Determidiate = New DevExpress.XtraEditors.ProgressBarControl()
        Me.txt_Status = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Progress_Indermidiate = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.txt_FromDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ToDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FilePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Progress_Determidiate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Progress_Indermidiate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "From Date :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "To Date :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(26, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Save to :"
        '
        'txt_FromDate
        '
        Me.txt_FromDate.EditValue = Nothing
        Me.txt_FromDate.Location = New System.Drawing.Point(75, 9)
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_FromDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_FromDate.Size = New System.Drawing.Size(338, 20)
        Me.txt_FromDate.TabIndex = 3
        '
        'txt_ToDate
        '
        Me.txt_ToDate.EditValue = Nothing
        Me.txt_ToDate.Location = New System.Drawing.Point(75, 35)
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ToDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ToDate.Size = New System.Drawing.Size(338, 20)
        Me.txt_ToDate.TabIndex = 3
        '
        'txt_FilePath
        '
        Me.txt_FilePath.Location = New System.Drawing.Point(75, 61)
        Me.txt_FilePath.Name = "txt_FilePath"
        Me.txt_FilePath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_FilePath.Properties.ReadOnly = True
        Me.txt_FilePath.Size = New System.Drawing.Size(338, 20)
        Me.txt_FilePath.TabIndex = 4
        '
        'btn_Generate
        '
        Me.btn_Generate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Generate.Location = New System.Drawing.Point(338, 87)
        Me.btn_Generate.Name = "btn_Generate"
        Me.btn_Generate.Size = New System.Drawing.Size(75, 37)
        Me.btn_Generate.TabIndex = 5
        Me.btn_Generate.Text = "Generate"
        '
        'dlg_Save
        '
        Me.dlg_Save.DefaultExt = "xlsx"
        Me.dlg_Save.FileName = "Admission Fees DFC.xlsx"
        Me.dlg_Save.Filter = "Excel Spreadsheet Files (*.xlsx)|*.xlsx"
        '
        'txt_Progress_Determidiate
        '
        Me.txt_Progress_Determidiate.Location = New System.Drawing.Point(12, 106)
        Me.txt_Progress_Determidiate.Name = "txt_Progress_Determidiate"
        Me.txt_Progress_Determidiate.Size = New System.Drawing.Size(320, 18)
        Me.txt_Progress_Determidiate.TabIndex = 6
        Me.txt_Progress_Determidiate.Visible = False
        '
        'txt_Status
        '
        Me.txt_Status.Location = New System.Drawing.Point(14, 87)
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.Size = New System.Drawing.Size(4, 13)
        Me.txt_Status.TabIndex = 7
        Me.txt_Status.Text = "-"
        Me.txt_Status.Visible = False
        '
        'txt_Progress_Indermidiate
        '
        Me.txt_Progress_Indermidiate.EditValue = 0
        Me.txt_Progress_Indermidiate.Location = New System.Drawing.Point(12, 106)
        Me.txt_Progress_Indermidiate.Name = "txt_Progress_Indermidiate"
        Me.txt_Progress_Indermidiate.Size = New System.Drawing.Size(320, 18)
        Me.txt_Progress_Indermidiate.TabIndex = 8
        Me.txt_Progress_Indermidiate.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'frm_AdmissionFeesDFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 131)
        Me.Controls.Add(Me.txt_Progress_Indermidiate)
        Me.Controls.Add(Me.txt_Status)
        Me.Controls.Add(Me.txt_Progress_Determidiate)
        Me.Controls.Add(Me.btn_Generate)
        Me.Controls.Add(Me.txt_FilePath)
        Me.Controls.Add(Me.txt_ToDate)
        Me.Controls.Add(Me.txt_FromDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AdmissionFeesDFC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admission Fees - DFC"
        CType(Me.txt_FromDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ToDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FilePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Progress_Determidiate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Progress_Indermidiate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_FromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_ToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_FilePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btn_Generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dlg_Save As SaveFileDialog
    Friend WithEvents txt_Progress_Determidiate As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents txt_Status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Progress_Indermidiate As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
