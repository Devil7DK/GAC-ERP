<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Courses_View
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Courses_View))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FeesStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_DefaultFeesStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_PrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MarginSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Edit = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Data = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Edit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Fees = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_Courses = New DevExpress.XtraGrid.GridControl()
        Me.gv_Courses = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Worker_LoadCourses = New System.ComponentModel.BackgroundWorker()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_Courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Reload, Me.btn_Edit, Me.btn_Remove, Me.btn_FeesStructure, Me.btn_PrintPreview, Me.btn_MarginSettings, Me.btn_New, Me.btn_DefaultFeesStructure})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 9
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Edit})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(442, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.Description = "Reload Admission List"
        Me.btn_Reload.Id = 1
        Me.btn_Reload.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.courses_reload
        Me.btn_Reload.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.courses_reload
        Me.btn_Reload.Name = "btn_Reload"
        '
        'btn_Edit
        '
        Me.btn_Edit.Caption = "Edit"
        Me.btn_Edit.Id = 2
        Me.btn_Edit.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.courses_edit
        Me.btn_Edit.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.courses_edit
        Me.btn_Edit.Name = "btn_Edit"
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 3
        Me.btn_Remove.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.courses_remove
        Me.btn_Remove.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.courses_remove
        Me.btn_Remove.Name = "btn_Remove"
        '
        'btn_FeesStructure
        '
        Me.btn_FeesStructure.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_FeesStructure.Caption = "Set / Change Fees Structure"
        Me.btn_FeesStructure.DropDownControl = Me.PopupMenu1
        Me.btn_FeesStructure.Id = 4
        Me.btn_FeesStructure.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.feesstructure_edit
        Me.btn_FeesStructure.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.feesstructure_edit
        Me.btn_FeesStructure.Name = "btn_FeesStructure"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.btn_DefaultFeesStructure)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl
        '
        'btn_DefaultFeesStructure
        '
        Me.btn_DefaultFeesStructure.Caption = "Reset Fees Structure to Default"
        Me.btn_DefaultFeesStructure.Id = 8
        Me.btn_DefaultFeesStructure.Name = "btn_DefaultFeesStructure"
        '
        'btn_PrintPreview
        '
        Me.btn_PrintPreview.Caption = "PrintPreview"
        Me.btn_PrintPreview.Id = 5
        Me.btn_PrintPreview.Name = "btn_PrintPreview"
        '
        'btn_MarginSettings
        '
        Me.btn_MarginSettings.Caption = "Margin Settings"
        Me.btn_MarginSettings.Id = 6
        Me.btn_MarginSettings.Name = "btn_MarginSettings"
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Id = 7
        Me.btn_New.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.courses_add
        Me.btn_New.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.courses_add
        Me.btn_New.Name = "btn_New"
        '
        'rp_Edit
        '
        Me.rp_Edit.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Data, Me.rpg_Edit, Me.rpg_Fees})
        Me.rp_Edit.Name = "rp_Edit"
        Me.rp_Edit.Text = "Edit"
        '
        'rpg_Data
        '
        Me.rpg_Data.AllowMinimize = False
        Me.rpg_Data.ItemLinks.Add(Me.btn_Reload)
        Me.rpg_Data.Name = "rpg_Data"
        Me.rpg_Data.ShowCaptionButton = False
        '
        'rpg_Edit
        '
        Me.rpg_Edit.AllowMinimize = False
        Me.rpg_Edit.ItemLinks.Add(Me.btn_New)
        Me.rpg_Edit.ItemLinks.Add(Me.btn_Edit)
        Me.rpg_Edit.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_Edit.Name = "rpg_Edit"
        Me.rpg_Edit.ShowCaptionButton = False
        '
        'rpg_Fees
        '
        Me.rpg_Fees.ItemLinks.Add(Me.btn_FeesStructure)
        Me.rpg_Fees.Name = "rpg_Fees"
        Me.rpg_Fees.ShowCaptionButton = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'gc_Courses
        '
        Me.gc_Courses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Courses.Location = New System.Drawing.Point(0, 143)
        Me.gc_Courses.MainView = Me.gv_Courses
        Me.gc_Courses.Name = "gc_Courses"
        Me.gc_Courses.Size = New System.Drawing.Size(442, 275)
        Me.gc_Courses.TabIndex = 5
        Me.gc_Courses.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Courses})
        '
        'gv_Courses
        '
        Me.gv_Courses.GridControl = Me.gc_Courses
        Me.gv_Courses.Name = "gv_Courses"
        Me.gv_Courses.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_Courses.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_Courses.OptionsBehavior.Editable = False
        Me.gv_Courses.OptionsView.ShowGroupPanel = False
        '
        'Worker_LoadCourses
        '
        '
        'frm_Courses_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.Controls.Add(Me.gc_Courses)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_Courses_View"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Courses"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_Courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Edit As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Data As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Edit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FeesStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Fees As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_PrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_MarginSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gc_Courses As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Courses As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_DefaultFeesStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Worker_LoadCourses As System.ComponentModel.BackgroundWorker
End Class
