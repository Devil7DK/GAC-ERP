<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdmissionList_Add_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdmissionList_Add_Edit))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Cancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btn_PrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.lbl_Status = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_Status = New DevExpress.XtraBars.BarStaticItem()
        Me.rp_Add = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_New = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Status = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Print = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Worker_LoadData = New System.ComponentModel.BackgroundWorker()
        Me.panel_Data = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_RegistrationNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ApplicationNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Rank = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Gender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Community = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_CutOff = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CourseID = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_Course = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Shift = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Medium = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Stream = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Quota = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_AllottedGender = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_AllottedCommunity = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_AllottedStream = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cb_SpecialQuota = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.txt_Remarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Department = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_State = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ProvisionalSlip_Printer = New GAC_ERP.ProvisionalAdmissionSlipPrinter()
        Me.ProvisionalSlip_PrintDialog = New System.Windows.Forms.PrintDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Data.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RegistrationNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ApplicationNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Rank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Gender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Community.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CutOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CourseID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Course.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Shift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Medium.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Stream.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Quota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AllottedGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AllottedCommunity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AllottedStream.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_SpecialQuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Department.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_State.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Save, Me.btn_Cancel, Me.btn_Print, Me.btn_PrintPreview, Me.btn_New, Me.lbl_Status, Me.txt_Status})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 11
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Add})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(672, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 2
        Me.btn_Save.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.save_entry
        Me.btn_Save.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.save_entry
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Caption = "Cancel"
        Me.btn_Cancel.Id = 3
        Me.btn_Cancel.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.cancel_entry
        Me.btn_Cancel.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.cancel_entry
        Me.btn_Cancel.Name = "btn_Cancel"
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
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl
        '
        'btn_PrintPreview
        '
        Me.btn_PrintPreview.Caption = "PrintPreview"
        Me.btn_PrintPreview.Id = 5
        Me.btn_PrintPreview.Name = "btn_PrintPreview"
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Id = 7
        Me.btn_New.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.new_entry
        Me.btn_New.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.new_entry
        Me.btn_New.Name = "btn_New"
        '
        'lbl_Status
        '
        Me.lbl_Status.Caption = "Status :"
        Me.lbl_Status.Id = 9
        Me.lbl_Status.Name = "lbl_Status"
        '
        'txt_Status
        '
        Me.txt_Status.Caption = "-"
        Me.txt_Status.Id = 10
        Me.txt_Status.Name = "txt_Status"
        '
        'rp_Add
        '
        Me.rp_Add.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_New, Me.rpg_Status, Me.rpg_Print})
        Me.rp_Add.Name = "rp_Add"
        Me.rp_Add.Text = "Add"
        '
        'rpg_New
        '
        Me.rpg_New.AllowMinimize = False
        Me.rpg_New.ItemLinks.Add(Me.btn_New)
        Me.rpg_New.Name = "rpg_New"
        Me.rpg_New.ShowCaptionButton = False
        '
        'rpg_Status
        '
        Me.rpg_Status.AllowMinimize = False
        Me.rpg_Status.ItemLinks.Add(Me.btn_Save)
        Me.rpg_Status.ItemLinks.Add(Me.btn_Cancel)
        Me.rpg_Status.Name = "rpg_Status"
        Me.rpg_Status.ShowCaptionButton = False
        '
        'rpg_Print
        '
        Me.rpg_Print.ItemLinks.Add(Me.btn_Print)
        Me.rpg_Print.Name = "rpg_Print"
        Me.rpg_Print.ShowCaptionButton = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.lbl_Status)
        Me.RibbonStatusBar.ItemLinks.Add(Me.txt_Status)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(672, 31)
        '
        'Worker_LoadData
        '
        '
        'panel_Data
        '
        Me.panel_Data.AutoScroll = True
        Me.panel_Data.Controls.Add(Me.TableLayoutPanel1)
        Me.panel_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Data.Location = New System.Drawing.Point(0, 143)
        Me.panel_Data.Name = "panel_Data"
        Me.panel_Data.Size = New System.Drawing.Size(672, 275)
        Me.panel_Data.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl8, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl10, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl11, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl12, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl13, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl14, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl15, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl16, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl17, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl18, 0, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl19, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl20, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl21, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl22, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl23, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl24, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl25, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl26, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl27, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl28, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl29, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl30, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl31, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl32, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl33, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl34, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl35, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl36, 1, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Name, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RegistrationNumber, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_ApplicationNumber, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Rank, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Gender, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Community, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CutOff, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CourseID, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Course, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Shift, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Medium, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Stream, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Quota, 2, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_AllottedGender, 2, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_AllottedCommunity, 2, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_AllottedStream, 2, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_SpecialQuota, 2, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Remarks, 2, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl37, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl38, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Department, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl39, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl40, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_State, 2, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 21
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(655, 586)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Name of Candidate"
        '
        'LabelControl3
        '
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(3, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Registration Number"
        '
        'LabelControl2
        '
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(3, 103)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Gender"
        '
        'LabelControl4
        '
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(3, 78)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Rank"
        '
        'LabelControl5
        '
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl5.Location = New System.Drawing.Point(3, 53)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Application Number"
        '
        'LabelControl6
        '
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(3, 128)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Community"
        '
        'LabelControl7
        '
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl7.Location = New System.Drawing.Point(3, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Cut Off Marks"
        '
        'LabelControl9
        '
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl9.Location = New System.Drawing.Point(3, 203)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Course ID"
        '
        'LabelControl8
        '
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl8.Location = New System.Drawing.Point(3, 228)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Course"
        '
        'LabelControl10
        '
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl10.Location = New System.Drawing.Point(3, 278)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Shift"
        '
        'LabelControl11
        '
        Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl11.Location = New System.Drawing.Point(3, 303)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Medium"
        '
        'LabelControl12
        '
        Me.LabelControl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl12.Location = New System.Drawing.Point(3, 328)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl12.TabIndex = 11
        Me.LabelControl12.Text = "Stream"
        '
        'LabelControl13
        '
        Me.LabelControl13.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl13.Location = New System.Drawing.Point(3, 353)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = "Quota"
        '
        'LabelControl14
        '
        Me.LabelControl14.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl14.Location = New System.Drawing.Point(3, 378)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl14.TabIndex = 13
        Me.LabelControl14.Text = "Allotted Gender"
        '
        'LabelControl15
        '
        Me.LabelControl15.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl15.Location = New System.Drawing.Point(3, 403)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl15.TabIndex = 14
        Me.LabelControl15.Text = "Allotted Community"
        '
        'LabelControl16
        '
        Me.LabelControl16.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl16.Location = New System.Drawing.Point(3, 428)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl16.TabIndex = 15
        Me.LabelControl16.Text = "Allotted Stream"
        '
        'LabelControl17
        '
        Me.LabelControl17.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl17.Location = New System.Drawing.Point(3, 453)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl17.TabIndex = 16
        Me.LabelControl17.Text = "Special Quota"
        '
        'LabelControl18
        '
        Me.LabelControl18.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl18.Location = New System.Drawing.Point(3, 553)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl18.TabIndex = 17
        Me.LabelControl18.Text = "Remarks"
        '
        'LabelControl19
        '
        Me.LabelControl19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl19.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl19.Location = New System.Drawing.Point(118, 3)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl19.TabIndex = 18
        Me.LabelControl19.Text = ":"
        '
        'LabelControl20
        '
        Me.LabelControl20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl20.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl20.Location = New System.Drawing.Point(118, 28)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl20.TabIndex = 18
        Me.LabelControl20.Text = ":"
        '
        'LabelControl21
        '
        Me.LabelControl21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl21.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl21.Location = New System.Drawing.Point(118, 53)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl21.TabIndex = 18
        Me.LabelControl21.Text = ":"
        '
        'LabelControl22
        '
        Me.LabelControl22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl22.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl22.Location = New System.Drawing.Point(118, 78)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl22.TabIndex = 18
        Me.LabelControl22.Text = ":"
        '
        'LabelControl23
        '
        Me.LabelControl23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl23.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl23.Location = New System.Drawing.Point(118, 103)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl23.TabIndex = 18
        Me.LabelControl23.Text = ":"
        '
        'LabelControl24
        '
        Me.LabelControl24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl24.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl24.Location = New System.Drawing.Point(118, 128)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl24.TabIndex = 18
        Me.LabelControl24.Text = ":"
        '
        'LabelControl25
        '
        Me.LabelControl25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl25.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl25.Location = New System.Drawing.Point(118, 153)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl25.TabIndex = 18
        Me.LabelControl25.Text = ":"
        '
        'LabelControl26
        '
        Me.LabelControl26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl26.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl26.Location = New System.Drawing.Point(118, 203)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl26.TabIndex = 18
        Me.LabelControl26.Text = ":"
        '
        'LabelControl27
        '
        Me.LabelControl27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl27.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl27.Location = New System.Drawing.Point(118, 228)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl27.TabIndex = 18
        Me.LabelControl27.Text = ":"
        '
        'LabelControl28
        '
        Me.LabelControl28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl28.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl28.Location = New System.Drawing.Point(118, 278)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl28.TabIndex = 18
        Me.LabelControl28.Text = ":"
        '
        'LabelControl29
        '
        Me.LabelControl29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl29.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl29.Location = New System.Drawing.Point(118, 303)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl29.TabIndex = 18
        Me.LabelControl29.Text = ":"
        '
        'LabelControl30
        '
        Me.LabelControl30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl30.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl30.Location = New System.Drawing.Point(118, 328)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl30.TabIndex = 18
        Me.LabelControl30.Text = ":"
        '
        'LabelControl31
        '
        Me.LabelControl31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl31.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl31.Location = New System.Drawing.Point(118, 353)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl31.TabIndex = 18
        Me.LabelControl31.Text = ":"
        '
        'LabelControl32
        '
        Me.LabelControl32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl32.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl32.Location = New System.Drawing.Point(118, 378)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl32.TabIndex = 18
        Me.LabelControl32.Text = ":"
        '
        'LabelControl33
        '
        Me.LabelControl33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl33.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl33.Location = New System.Drawing.Point(118, 403)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl33.TabIndex = 18
        Me.LabelControl33.Text = ":"
        '
        'LabelControl34
        '
        Me.LabelControl34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl34.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl34.Location = New System.Drawing.Point(118, 428)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl34.TabIndex = 18
        Me.LabelControl34.Text = ":"
        '
        'LabelControl35
        '
        Me.LabelControl35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl35.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl35.Location = New System.Drawing.Point(118, 453)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(2, 94)
        Me.LabelControl35.TabIndex = 18
        Me.LabelControl35.Text = ":"
        '
        'LabelControl36
        '
        Me.LabelControl36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl36.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl36.Location = New System.Drawing.Point(118, 553)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl36.TabIndex = 18
        Me.LabelControl36.Text = ":"
        '
        'txt_Name
        '
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.EnterMoveNextControl = True
        Me.txt_Name.Location = New System.Drawing.Point(126, 3)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(526, 20)
        Me.txt_Name.TabIndex = 0
        '
        'txt_RegistrationNumber
        '
        Me.txt_RegistrationNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_RegistrationNumber.EnterMoveNextControl = True
        Me.txt_RegistrationNumber.Location = New System.Drawing.Point(126, 28)
        Me.txt_RegistrationNumber.Name = "txt_RegistrationNumber"
        Me.txt_RegistrationNumber.Properties.ReadOnly = True
        Me.txt_RegistrationNumber.Size = New System.Drawing.Size(526, 20)
        Me.txt_RegistrationNumber.TabIndex = 1
        Me.txt_RegistrationNumber.TabStop = False
        '
        'txt_ApplicationNumber
        '
        Me.txt_ApplicationNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ApplicationNumber.EnterMoveNextControl = True
        Me.txt_ApplicationNumber.Location = New System.Drawing.Point(126, 53)
        Me.txt_ApplicationNumber.Name = "txt_ApplicationNumber"
        Me.txt_ApplicationNumber.Size = New System.Drawing.Size(526, 20)
        Me.txt_ApplicationNumber.TabIndex = 2
        '
        'txt_Rank
        '
        Me.txt_Rank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Rank.EnterMoveNextControl = True
        Me.txt_Rank.Location = New System.Drawing.Point(126, 78)
        Me.txt_Rank.Name = "txt_Rank"
        Me.txt_Rank.Size = New System.Drawing.Size(526, 20)
        Me.txt_Rank.TabIndex = 3
        '
        'txt_Gender
        '
        Me.txt_Gender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Gender.EnterMoveNextControl = True
        Me.txt_Gender.Location = New System.Drawing.Point(126, 103)
        Me.txt_Gender.Name = "txt_Gender"
        Me.txt_Gender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Gender.Properties.Items.AddRange(New Object() {"Male", "Female", "Transgender"})
        Me.txt_Gender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Gender.Size = New System.Drawing.Size(526, 20)
        Me.txt_Gender.TabIndex = 4
        '
        'txt_Community
        '
        Me.txt_Community.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Community.EnterMoveNextControl = True
        Me.txt_Community.Location = New System.Drawing.Point(126, 128)
        Me.txt_Community.Name = "txt_Community"
        Me.txt_Community.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Community.Properties.Items.AddRange(New Object() {"-", "BC", "BCM", "MBC", "OC", "SC", "SCA", "ST", "ZD"})
        Me.txt_Community.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Community.Size = New System.Drawing.Size(526, 20)
        Me.txt_Community.TabIndex = 5
        '
        'txt_CutOff
        '
        Me.txt_CutOff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CutOff.EnterMoveNextControl = True
        Me.txt_CutOff.Location = New System.Drawing.Point(126, 153)
        Me.txt_CutOff.Name = "txt_CutOff"
        Me.txt_CutOff.Size = New System.Drawing.Size(526, 20)
        Me.txt_CutOff.TabIndex = 6
        '
        'txt_CourseID
        '
        Me.txt_CourseID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CourseID.EnterMoveNextControl = True
        Me.txt_CourseID.Location = New System.Drawing.Point(126, 203)
        Me.txt_CourseID.Name = "txt_CourseID"
        Me.txt_CourseID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_CourseID.Size = New System.Drawing.Size(526, 20)
        Me.txt_CourseID.TabIndex = 8
        '
        'txt_Course
        '
        Me.txt_Course.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Course.EnterMoveNextControl = True
        Me.txt_Course.Location = New System.Drawing.Point(126, 228)
        Me.txt_Course.Name = "txt_Course"
        Me.txt_Course.Properties.ReadOnly = True
        Me.txt_Course.Size = New System.Drawing.Size(526, 20)
        Me.txt_Course.TabIndex = 9
        Me.txt_Course.TabStop = False
        '
        'txt_Shift
        '
        Me.txt_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Shift.EnterMoveNextControl = True
        Me.txt_Shift.Location = New System.Drawing.Point(126, 278)
        Me.txt_Shift.Name = "txt_Shift"
        Me.txt_Shift.Properties.ReadOnly = True
        Me.txt_Shift.Size = New System.Drawing.Size(526, 20)
        Me.txt_Shift.TabIndex = 11
        Me.txt_Shift.TabStop = False
        '
        'txt_Medium
        '
        Me.txt_Medium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Medium.EnterMoveNextControl = True
        Me.txt_Medium.Location = New System.Drawing.Point(126, 303)
        Me.txt_Medium.Name = "txt_Medium"
        Me.txt_Medium.Properties.ReadOnly = True
        Me.txt_Medium.Size = New System.Drawing.Size(526, 20)
        Me.txt_Medium.TabIndex = 12
        Me.txt_Medium.TabStop = False
        '
        'txt_Stream
        '
        Me.txt_Stream.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Stream.EnterMoveNextControl = True
        Me.txt_Stream.Location = New System.Drawing.Point(126, 328)
        Me.txt_Stream.Name = "txt_Stream"
        Me.txt_Stream.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Stream.Properties.Items.AddRange(New Object() {"Academic", "Vocational"})
        Me.txt_Stream.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Stream.Size = New System.Drawing.Size(526, 20)
        Me.txt_Stream.TabIndex = 13
        '
        'txt_Quota
        '
        Me.txt_Quota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Quota.EnterMoveNextControl = True
        Me.txt_Quota.Location = New System.Drawing.Point(126, 353)
        Me.txt_Quota.Name = "txt_Quota"
        Me.txt_Quota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Quota.Properties.Items.AddRange(New Object() {"BC", "BCM", "MBC", "OC", "SC", "SCA", "ST"})
        Me.txt_Quota.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Quota.Size = New System.Drawing.Size(526, 20)
        Me.txt_Quota.TabIndex = 14
        '
        'txt_AllottedGender
        '
        Me.txt_AllottedGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AllottedGender.EnterMoveNextControl = True
        Me.txt_AllottedGender.Location = New System.Drawing.Point(126, 378)
        Me.txt_AllottedGender.Name = "txt_AllottedGender"
        Me.txt_AllottedGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_AllottedGender.Properties.Items.AddRange(New Object() {"Male", "Female"})
        Me.txt_AllottedGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_AllottedGender.Size = New System.Drawing.Size(526, 20)
        Me.txt_AllottedGender.TabIndex = 15
        '
        'txt_AllottedCommunity
        '
        Me.txt_AllottedCommunity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AllottedCommunity.EnterMoveNextControl = True
        Me.txt_AllottedCommunity.Location = New System.Drawing.Point(126, 403)
        Me.txt_AllottedCommunity.Name = "txt_AllottedCommunity"
        Me.txt_AllottedCommunity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_AllottedCommunity.Properties.Items.AddRange(New Object() {"BC", "BCM", "MBC", "OC", "SC", "SCA", "ST"})
        Me.txt_AllottedCommunity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_AllottedCommunity.Size = New System.Drawing.Size(526, 20)
        Me.txt_AllottedCommunity.TabIndex = 16
        '
        'txt_AllottedStream
        '
        Me.txt_AllottedStream.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_AllottedStream.EnterMoveNextControl = True
        Me.txt_AllottedStream.Location = New System.Drawing.Point(126, 428)
        Me.txt_AllottedStream.Name = "txt_AllottedStream"
        Me.txt_AllottedStream.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_AllottedStream.Properties.Items.AddRange(New Object() {"Academic", "Vocational"})
        Me.txt_AllottedStream.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_AllottedStream.Size = New System.Drawing.Size(526, 20)
        Me.txt_AllottedStream.TabIndex = 17
        '
        'cb_SpecialQuota
        '
        Me.cb_SpecialQuota.Cursor = System.Windows.Forms.Cursors.Default
        Me.cb_SpecialQuota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_SpecialQuota.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("EX-MAN"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("NCC"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("PH"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("SPORTS")})
        Me.cb_SpecialQuota.Location = New System.Drawing.Point(126, 453)
        Me.cb_SpecialQuota.Name = "cb_SpecialQuota"
        Me.cb_SpecialQuota.Size = New System.Drawing.Size(526, 94)
        Me.cb_SpecialQuota.TabIndex = 18
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Remarks.EnterMoveNextControl = True
        Me.txt_Remarks.Location = New System.Drawing.Point(126, 553)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(526, 20)
        Me.txt_Remarks.TabIndex = 19
        '
        'LabelControl37
        '
        Me.LabelControl37.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl37.Location = New System.Drawing.Point(3, 253)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl37.TabIndex = 37
        Me.LabelControl37.Text = "Department / Branch"
        '
        'LabelControl38
        '
        Me.LabelControl38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl38.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl38.Location = New System.Drawing.Point(118, 253)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl38.TabIndex = 38
        Me.LabelControl38.Text = ":"
        '
        'txt_Department
        '
        Me.txt_Department.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Department.EnterMoveNextControl = True
        Me.txt_Department.Location = New System.Drawing.Point(126, 253)
        Me.txt_Department.Name = "txt_Department"
        Me.txt_Department.Properties.ReadOnly = True
        Me.txt_Department.Size = New System.Drawing.Size(526, 20)
        Me.txt_Department.TabIndex = 10
        Me.txt_Department.TabStop = False
        '
        'LabelControl39
        '
        Me.LabelControl39.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl39.Location = New System.Drawing.Point(3, 178)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl39.TabIndex = 39
        Me.LabelControl39.Text = "State"
        '
        'LabelControl40
        '
        Me.LabelControl40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl40.Location = New System.Drawing.Point(118, 178)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl40.TabIndex = 40
        Me.LabelControl40.Text = ":"
        '
        'txt_State
        '
        Me.txt_State.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_State.EditValue = "Tamil Nadu"
        Me.txt_State.EnterMoveNextControl = True
        Me.txt_State.Location = New System.Drawing.Point(126, 178)
        Me.txt_State.Name = "txt_State"
        Me.txt_State.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_State.Properties.Items.AddRange(New Object() {"Andaman and Nicobar Islands", "Andra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chandigarh", "Chhattisgarh", "Dadar and Nagar Haveli", "Daman and Diu", "Delhi", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Lakshadeep", "Madya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Orissa", "Pondicherry", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Tripura", "Uttar Pradesh", "Uttaranchal", "West Bengal"})
        Me.txt_State.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_State.Size = New System.Drawing.Size(526, 20)
        Me.txt_State.TabIndex = 7
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
        'frm_AdmissionList_Add_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 449)
        Me.Controls.Add(Me.panel_Data)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_AdmissionList_Add_Edit"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Admission List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Data.ResumeLayout(False)
        Me.panel_Data.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RegistrationNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ApplicationNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Rank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Gender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Community.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CutOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CourseID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Course.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Shift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Medium.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Stream.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Quota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AllottedGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AllottedCommunity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AllottedStream.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_SpecialQuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Department.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_State.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Add As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_New As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents rpg_Status As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Cancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Worker_LoadData As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Print As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btn_PrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents panel_Data As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_RegistrationNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ApplicationNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Rank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Gender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Community As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_CutOff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CourseID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_Course As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Shift As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Medium As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Stream As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Quota As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_AllottedGender As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_AllottedCommunity As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_AllottedStream As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_SpecialQuota As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents txt_Remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Department As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_State As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_Status As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_Status As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ProvisionalSlip_Printer As ProvisionalAdmissionSlipPrinter
    Friend WithEvents ProvisionalSlip_PrintDialog As PrintDialog
End Class
