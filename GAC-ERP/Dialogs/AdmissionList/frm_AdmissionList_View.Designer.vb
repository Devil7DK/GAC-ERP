<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdmissionList_View
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdmissionList_View))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Remove = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_PrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_MarginSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Edit = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Data = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Edit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gc_AdmissionEntries = New DevExpress.XtraGrid.GridControl()
        Me.gv_AdmissionEntries = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Worker_LoadData = New System.ComponentModel.BackgroundWorker()
        Me.ProvisionalSlip_Printer = New GAC_ERP.ProvisionalAdmissionSlipPrinter()
        Me.ProvisionalSlip_PrintDialog = New System.Windows.Forms.PrintDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc_AdmissionEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_AdmissionEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Reload, Me.btn_Edit, Me.btn_Remove, Me.btn_Print, Me.btn_PrintPreview, Me.btn_MarginSettings})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 7
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
        Me.btn_Reload.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.refresh_entries
        Me.btn_Reload.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.refresh_entries
        Me.btn_Reload.Name = "btn_Reload"
        '
        'btn_Edit
        '
        Me.btn_Edit.Caption = "Edit"
        Me.btn_Edit.Id = 2
        Me.btn_Edit.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.edit_entry
        Me.btn_Edit.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.edit_entry
        Me.btn_Edit.Name = "btn_Edit"
        '
        'btn_Remove
        '
        Me.btn_Remove.Caption = "Remove"
        Me.btn_Remove.Id = 3
        Me.btn_Remove.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.remove_entry
        Me.btn_Remove.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.remove_entry
        Me.btn_Remove.Name = "btn_Remove"
        '
        'btn_Print
        '
        Me.btn_Print.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_Print.Caption = "Print"
        Me.btn_Print.DropDownControl = Me.PopupMenu1
        Me.btn_Print.Id = 4
        Me.btn_Print.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.print
        Me.btn_Print.Name = "btn_Print"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.btn_PrintPreview)
        Me.PopupMenu1.ItemLinks.Add(Me.btn_MarginSettings)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl
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
        'rp_Edit
        '
        Me.rp_Edit.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Data, Me.rpg_Edit, Me.RibbonPageGroup1})
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
        Me.rpg_Edit.ItemLinks.Add(Me.btn_Edit)
        Me.rpg_Edit.ItemLinks.Add(Me.btn_Remove)
        Me.rpg_Edit.Name = "rpg_Edit"
        Me.rpg_Edit.ShowCaptionButton = False
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_Print)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'gc_AdmissionEntries
        '
        Me.gc_AdmissionEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_AdmissionEntries.Location = New System.Drawing.Point(0, 143)
        Me.gc_AdmissionEntries.MainView = Me.gv_AdmissionEntries
        Me.gc_AdmissionEntries.Name = "gc_AdmissionEntries"
        Me.gc_AdmissionEntries.Size = New System.Drawing.Size(442, 275)
        Me.gc_AdmissionEntries.TabIndex = 2
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
        'Worker_LoadData
        '
        '
        'ProvisionalSlip_Printer
        '
        Me.ProvisionalSlip_Printer.AdmissionEntries = Nothing
        Me.ProvisionalSlip_Printer.Courses = Nothing
        Me.ProvisionalSlip_Printer.DocumentName = "Provisional Admission Slip"
        Me.ProvisionalSlip_Printer.Settings = Nothing
        '
        'ProvisionalSlip_PrintDialog
        '
        Me.ProvisionalSlip_PrintDialog.Document = Me.ProvisionalSlip_Printer
        Me.ProvisionalSlip_PrintDialog.UseEXDialog = True
        '
        'frm_AdmissionList_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.Controls.Add(Me.gc_AdmissionEntries)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_AdmissionList_View"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Admission List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc_AdmissionEntries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_AdmissionEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Edit As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Data As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Edit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gc_AdmissionEntries As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_AdmissionEntries As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Remove As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Worker_LoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_PrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_MarginSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProvisionalSlip_Printer As ProvisionalAdmissionSlipPrinter
    Friend WithEvents ProvisionalSlip_PrintDialog As PrintDialog
End Class
