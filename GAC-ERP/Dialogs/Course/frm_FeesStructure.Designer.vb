<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FeesStructure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FeesStructure))
        Me.btn_AddGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_RemoveGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_AddHead = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_RemoveHead = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.gc_FeesGroup = New DevExpress.XtraGrid.GridControl()
        Me.gv_FeesGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gc_FeesHeads = New DevExpress.XtraGrid.GridControl()
        Me.gv_FeesHeads = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grp_FeesGroup = New DevExpress.XtraEditors.GroupControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.panel_GroupControls = New DevExpress.XtraEditors.PanelControl()
        Me.panel_SubHeads = New DevExpress.XtraEditors.PanelControl()
        Me.grp_Heads = New DevExpress.XtraEditors.GroupControl()
        Me.panel_SubHeadsControls = New DevExpress.XtraEditors.PanelControl()
        Me.grp_AdditionalHeads = New DevExpress.XtraEditors.GroupControl()
        Me.gc_AdditionalHeads = New DevExpress.XtraGrid.GridControl()
        Me.gv_AdditionalHeads = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panel_AdditionalHeadsControls = New DevExpress.XtraEditors.PanelControl()
        Me.btn_RemoveAdditionalHead = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_AddAdditionalHead = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_Main = New DevExpress.XtraEditors.PanelControl()
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl()
        CType(Me.gc_FeesGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_FeesGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_FeesHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_FeesHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_FeesGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_FeesGroup.SuspendLayout()
        CType(Me.panel_GroupControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_GroupControls.SuspendLayout()
        CType(Me.panel_SubHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_SubHeads.SuspendLayout()
        CType(Me.grp_Heads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Heads.SuspendLayout()
        CType(Me.panel_SubHeadsControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_SubHeadsControls.SuspendLayout()
        CType(Me.grp_AdditionalHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_AdditionalHeads.SuspendLayout()
        CType(Me.gc_AdditionalHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_AdditionalHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_AdditionalHeadsControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_AdditionalHeadsControls.SuspendLayout()
        CType(Me.panel_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_AddGroup
        '
        Me.btn_AddGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_AddGroup.Location = New System.Drawing.Point(2, 2)
        Me.btn_AddGroup.Name = "btn_AddGroup"
        Me.btn_AddGroup.Size = New System.Drawing.Size(86, 24)
        Me.btn_AddGroup.TabIndex = 1
        Me.btn_AddGroup.Text = "Add Group"
        '
        'btn_RemoveGroup
        '
        Me.btn_RemoveGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_RemoveGroup.Location = New System.Drawing.Point(88, 2)
        Me.btn_RemoveGroup.Name = "btn_RemoveGroup"
        Me.btn_RemoveGroup.Size = New System.Drawing.Size(86, 24)
        Me.btn_RemoveGroup.TabIndex = 2
        Me.btn_RemoveGroup.Text = "Remove Group"
        '
        'btn_AddHead
        '
        Me.btn_AddHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_AddHead.Location = New System.Drawing.Point(2, 2)
        Me.btn_AddHead.Name = "btn_AddHead"
        Me.btn_AddHead.Size = New System.Drawing.Size(93, 23)
        Me.btn_AddHead.TabIndex = 1
        Me.btn_AddHead.Text = "Add Head"
        '
        'btn_RemoveHead
        '
        Me.btn_RemoveHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_RemoveHead.Location = New System.Drawing.Point(2, 25)
        Me.btn_RemoveHead.Name = "btn_RemoveHead"
        Me.btn_RemoveHead.Size = New System.Drawing.Size(93, 23)
        Me.btn_RemoveHead.TabIndex = 2
        Me.btn_RemoveHead.Text = "Remove Head"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(12, 443)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel.TabIndex = 4
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(374, 443)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 4
        Me.btn_Save.Text = "Save"
        '
        'gc_FeesGroup
        '
        Me.gc_FeesGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_FeesGroup.Location = New System.Drawing.Point(2, 48)
        Me.gc_FeesGroup.MainView = Me.gv_FeesGroup
        Me.gc_FeesGroup.MinimumSize = New System.Drawing.Size(0, 160)
        Me.gc_FeesGroup.Name = "gc_FeesGroup"
        Me.gc_FeesGroup.Size = New System.Drawing.Size(429, 161)
        Me.gc_FeesGroup.TabIndex = 5
        Me.gc_FeesGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_FeesGroup})
        '
        'gv_FeesGroup
        '
        Me.gv_FeesGroup.GridControl = Me.gc_FeesGroup
        Me.gv_FeesGroup.Name = "gv_FeesGroup"
        Me.gv_FeesGroup.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesGroup.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesGroup.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesGroup.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesGroup.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesGroup.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesGroup.OptionsDetail.EnableMasterViewMode = False
        Me.gv_FeesGroup.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gv_FeesGroup.OptionsView.ShowGroupPanel = False
        '
        'gc_FeesHeads
        '
        Me.gc_FeesHeads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_FeesHeads.Location = New System.Drawing.Point(2, 20)
        Me.gc_FeesHeads.MainView = Me.gv_FeesHeads
        Me.gc_FeesHeads.Name = "gc_FeesHeads"
        Me.gc_FeesHeads.Size = New System.Drawing.Size(324, 74)
        Me.gc_FeesHeads.TabIndex = 6
        Me.gc_FeesHeads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_FeesHeads})
        '
        'gv_FeesHeads
        '
        Me.gv_FeesHeads.GridControl = Me.gc_FeesHeads
        Me.gv_FeesHeads.Name = "gv_FeesHeads"
        Me.gv_FeesHeads.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesHeads.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesHeads.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_FeesHeads.OptionsView.ShowGroupPanel = False
        '
        'grp_FeesGroup
        '
        Me.grp_FeesGroup.Controls.Add(Me.gc_FeesGroup)
        Me.grp_FeesGroup.Controls.Add(Me.SplitterControl1)
        Me.grp_FeesGroup.Controls.Add(Me.panel_GroupControls)
        Me.grp_FeesGroup.Controls.Add(Me.panel_SubHeads)
        Me.grp_FeesGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_FeesGroup.Location = New System.Drawing.Point(2, 2)
        Me.grp_FeesGroup.MinimumSize = New System.Drawing.Size(0, 315)
        Me.grp_FeesGroup.Name = "grp_FeesGroup"
        Me.grp_FeesGroup.Size = New System.Drawing.Size(433, 316)
        Me.grp_FeesGroup.TabIndex = 7
        Me.grp_FeesGroup.Text = "Groups / Categories"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterControl1.Location = New System.Drawing.Point(2, 209)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(429, 5)
        Me.SplitterControl1.TabIndex = 8
        Me.SplitterControl1.TabStop = False
        '
        'panel_GroupControls
        '
        Me.panel_GroupControls.Controls.Add(Me.btn_RemoveGroup)
        Me.panel_GroupControls.Controls.Add(Me.btn_AddGroup)
        Me.panel_GroupControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_GroupControls.Location = New System.Drawing.Point(2, 20)
        Me.panel_GroupControls.Name = "panel_GroupControls"
        Me.panel_GroupControls.Size = New System.Drawing.Size(429, 28)
        Me.panel_GroupControls.TabIndex = 6
        '
        'panel_SubHeads
        '
        Me.panel_SubHeads.Controls.Add(Me.grp_Heads)
        Me.panel_SubHeads.Controls.Add(Me.panel_SubHeadsControls)
        Me.panel_SubHeads.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_SubHeads.Location = New System.Drawing.Point(2, 214)
        Me.panel_SubHeads.MinimumSize = New System.Drawing.Size(0, 100)
        Me.panel_SubHeads.Name = "panel_SubHeads"
        Me.panel_SubHeads.Size = New System.Drawing.Size(429, 100)
        Me.panel_SubHeads.TabIndex = 7
        '
        'grp_Heads
        '
        Me.grp_Heads.Controls.Add(Me.gc_FeesHeads)
        Me.grp_Heads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_Heads.Location = New System.Drawing.Point(2, 2)
        Me.grp_Heads.Name = "grp_Heads"
        Me.grp_Heads.Size = New System.Drawing.Size(328, 96)
        Me.grp_Heads.TabIndex = 8
        Me.grp_Heads.Text = "Sub Heads"
        '
        'panel_SubHeadsControls
        '
        Me.panel_SubHeadsControls.Controls.Add(Me.btn_RemoveHead)
        Me.panel_SubHeadsControls.Controls.Add(Me.btn_AddHead)
        Me.panel_SubHeadsControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_SubHeadsControls.Location = New System.Drawing.Point(330, 2)
        Me.panel_SubHeadsControls.Name = "panel_SubHeadsControls"
        Me.panel_SubHeadsControls.Size = New System.Drawing.Size(97, 96)
        Me.panel_SubHeadsControls.TabIndex = 9
        '
        'grp_AdditionalHeads
        '
        Me.grp_AdditionalHeads.Controls.Add(Me.gc_AdditionalHeads)
        Me.grp_AdditionalHeads.Controls.Add(Me.panel_AdditionalHeadsControls)
        Me.grp_AdditionalHeads.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grp_AdditionalHeads.Location = New System.Drawing.Point(2, 323)
        Me.grp_AdditionalHeads.MinimumSize = New System.Drawing.Size(0, 100)
        Me.grp_AdditionalHeads.Name = "grp_AdditionalHeads"
        Me.grp_AdditionalHeads.Size = New System.Drawing.Size(433, 100)
        Me.grp_AdditionalHeads.TabIndex = 8
        Me.grp_AdditionalHeads.Text = "Additional Heads"
        '
        'gc_AdditionalHeads
        '
        Me.gc_AdditionalHeads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_AdditionalHeads.Location = New System.Drawing.Point(2, 48)
        Me.gc_AdditionalHeads.MainView = Me.gv_AdditionalHeads
        Me.gc_AdditionalHeads.Name = "gc_AdditionalHeads"
        Me.gc_AdditionalHeads.Size = New System.Drawing.Size(429, 50)
        Me.gc_AdditionalHeads.TabIndex = 8
        Me.gc_AdditionalHeads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_AdditionalHeads})
        '
        'gv_AdditionalHeads
        '
        Me.gv_AdditionalHeads.GridControl = Me.gc_AdditionalHeads
        Me.gv_AdditionalHeads.Name = "gv_AdditionalHeads"
        Me.gv_AdditionalHeads.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_AdditionalHeads.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_AdditionalHeads.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_AdditionalHeads.OptionsView.ShowGroupPanel = False
        '
        'panel_AdditionalHeadsControls
        '
        Me.panel_AdditionalHeadsControls.Controls.Add(Me.btn_RemoveAdditionalHead)
        Me.panel_AdditionalHeadsControls.Controls.Add(Me.btn_AddAdditionalHead)
        Me.panel_AdditionalHeadsControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_AdditionalHeadsControls.Location = New System.Drawing.Point(2, 20)
        Me.panel_AdditionalHeadsControls.Name = "panel_AdditionalHeadsControls"
        Me.panel_AdditionalHeadsControls.Size = New System.Drawing.Size(429, 28)
        Me.panel_AdditionalHeadsControls.TabIndex = 7
        '
        'btn_RemoveAdditionalHead
        '
        Me.btn_RemoveAdditionalHead.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_RemoveAdditionalHead.Location = New System.Drawing.Point(88, 2)
        Me.btn_RemoveAdditionalHead.Name = "btn_RemoveAdditionalHead"
        Me.btn_RemoveAdditionalHead.Size = New System.Drawing.Size(86, 24)
        Me.btn_RemoveAdditionalHead.TabIndex = 2
        Me.btn_RemoveAdditionalHead.Text = "Remove Head"
        '
        'btn_AddAdditionalHead
        '
        Me.btn_AddAdditionalHead.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_AddAdditionalHead.Location = New System.Drawing.Point(2, 2)
        Me.btn_AddAdditionalHead.Name = "btn_AddAdditionalHead"
        Me.btn_AddAdditionalHead.Size = New System.Drawing.Size(86, 24)
        Me.btn_AddAdditionalHead.TabIndex = 1
        Me.btn_AddAdditionalHead.Text = "Add Head"
        '
        'panel_Main
        '
        Me.panel_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_Main.Controls.Add(Me.grp_FeesGroup)
        Me.panel_Main.Controls.Add(Me.SplitterControl2)
        Me.panel_Main.Controls.Add(Me.grp_AdditionalHeads)
        Me.panel_Main.Location = New System.Drawing.Point(12, 12)
        Me.panel_Main.Name = "panel_Main"
        Me.panel_Main.Size = New System.Drawing.Size(437, 425)
        Me.panel_Main.TabIndex = 9
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterControl2.Location = New System.Drawing.Point(2, 318)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(433, 5)
        Me.SplitterControl2.TabIndex = 9
        Me.SplitterControl2.TabStop = False
        '
        'frm_FeesStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 478)
        Me.Controls.Add(Me.panel_Main)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 510)
        Me.Name = "frm_FeesStructure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Default Fees Structure"
        CType(Me.gc_FeesGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_FeesGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_FeesHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_FeesHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_FeesGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_FeesGroup.ResumeLayout(False)
        CType(Me.panel_GroupControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_GroupControls.ResumeLayout(False)
        CType(Me.panel_SubHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_SubHeads.ResumeLayout(False)
        CType(Me.grp_Heads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Heads.ResumeLayout(False)
        CType(Me.panel_SubHeadsControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_SubHeadsControls.ResumeLayout(False)
        CType(Me.grp_AdditionalHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_AdditionalHeads.ResumeLayout(False)
        CType(Me.gc_AdditionalHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_AdditionalHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_AdditionalHeadsControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_AdditionalHeadsControls.ResumeLayout(False)
        CType(Me.panel_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_AddGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_RemoveGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_AddHead As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_RemoveHead As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc_FeesGroup As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_FeesGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_FeesHeads As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_FeesHeads As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grp_FeesGroup As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grp_Heads As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents panel_GroupControls As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_SubHeads As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_SubHeadsControls As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grp_AdditionalHeads As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_AdditionalHeads As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_AdditionalHeads As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panel_AdditionalHeadsControls As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_RemoveAdditionalHead As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_AddAdditionalHead As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_Main As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
End Class
