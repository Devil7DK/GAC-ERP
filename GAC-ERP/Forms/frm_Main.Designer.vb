<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.btn_DefaultFeesStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Exit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AdmissionList = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Courses = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AdmissionList_View = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AdmissionFees = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BillPrinter = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Home = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Admission = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Billing = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Settings = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rp_Settings = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Printing = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_Exit, Me.btn_AdmissionList, Me.btn_DefaultFeesStructure, Me.btn_Courses, Me.btn_AdmissionList_View, Me.btn_AdmissionFees, Me.btn_BillPrinter})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 9
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Home, Me.rp_Settings})
        Me.RibbonControl.Size = New System.Drawing.Size(617, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.ItemLinks.Add(Me.btn_DefaultFeesStructure)
        Me.ApplicationMenu1.ItemLinks.Add(Me.btn_Exit)
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.RibbonControl
        '
        'btn_DefaultFeesStructure
        '
        Me.btn_DefaultFeesStructure.Caption = "Default Fees Structure"
        Me.btn_DefaultFeesStructure.Description = "Set / Change Default Fees Structure"
        Me.btn_DefaultFeesStructure.Id = 4
        Me.btn_DefaultFeesStructure.ImageOptions.Image = CType(resources.GetObject("btn_DefaultFeesStructure.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_DefaultFeesStructure.Name = "btn_DefaultFeesStructure"
        Me.btn_DefaultFeesStructure.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_Exit
        '
        Me.btn_Exit.Caption = "Exit"
        Me.btn_Exit.Description = "Close the Application & Logout"
        Me.btn_Exit.Id = 1
        Me.btn_Exit.ImageOptions.Image = CType(resources.GetObject("btn_Exit.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btn_AdmissionList
        '
        Me.btn_AdmissionList.Caption = "Admission List"
        Me.btn_AdmissionList.Id = 3
        Me.btn_AdmissionList.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.admission_add
        Me.btn_AdmissionList.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.admission_add
        Me.btn_AdmissionList.Name = "btn_AdmissionList"
        '
        'btn_Courses
        '
        Me.btn_Courses.Caption = "Courses"
        Me.btn_Courses.Id = 5
        Me.btn_Courses.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.courses
        Me.btn_Courses.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.courses
        Me.btn_Courses.Name = "btn_Courses"
        '
        'btn_AdmissionList_View
        '
        Me.btn_AdmissionList_View.Caption = "View List"
        Me.btn_AdmissionList_View.Id = 6
        Me.btn_AdmissionList_View.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.admission_view
        Me.btn_AdmissionList_View.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.admission_view
        Me.btn_AdmissionList_View.Name = "btn_AdmissionList_View"
        '
        'btn_AdmissionFees
        '
        Me.btn_AdmissionFees.Caption = "Admission Fees"
        Me.btn_AdmissionFees.Id = 7
        Me.btn_AdmissionFees.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.admission_fees
        Me.btn_AdmissionFees.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.admission_fees
        Me.btn_AdmissionFees.Name = "btn_AdmissionFees"
        '
        'btn_BillPrinter
        '
        Me.btn_BillPrinter.Caption = "Admission Fees Receipt"
        Me.btn_BillPrinter.Id = 8
        Me.btn_BillPrinter.ImageOptions.Image = Global.GAC_ERP.My.Resources.Resources.print_invoice
        Me.btn_BillPrinter.ImageOptions.LargeImage = Global.GAC_ERP.My.Resources.Resources.print_invoice
        Me.btn_BillPrinter.Name = "btn_BillPrinter"
        '
        'rp_Home
        '
        Me.rp_Home.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Admission, Me.rpg_Billing, Me.rpg_Settings})
        Me.rp_Home.Name = "rp_Home"
        Me.rp_Home.Text = "Home"
        '
        'rpg_Admission
        '
        Me.rpg_Admission.ItemLinks.Add(Me.btn_AdmissionList)
        Me.rpg_Admission.ItemLinks.Add(Me.btn_AdmissionList_View)
        Me.rpg_Admission.Name = "rpg_Admission"
        Me.rpg_Admission.ShowCaptionButton = False
        Me.rpg_Admission.Text = "Admission"
        '
        'rpg_Billing
        '
        Me.rpg_Billing.ItemLinks.Add(Me.btn_AdmissionFees)
        Me.rpg_Billing.Name = "rpg_Billing"
        Me.rpg_Billing.ShowCaptionButton = False
        Me.rpg_Billing.Text = "Billing"
        '
        'rpg_Settings
        '
        Me.rpg_Settings.ItemLinks.Add(Me.btn_Courses)
        Me.rpg_Settings.Name = "rpg_Settings"
        Me.rpg_Settings.ShowCaptionButton = False
        Me.rpg_Settings.Text = "Others"
        '
        'rp_Settings
        '
        Me.rp_Settings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Printing})
        Me.rp_Settings.Name = "rp_Settings"
        Me.rp_Settings.Text = "Settings"
        '
        'rpg_Printing
        '
        Me.rpg_Printing.ItemLinks.Add(Me.btn_BillPrinter)
        Me.rpg_Printing.Name = "rpg_Printing"
        Me.rpg_Printing.ShowCaptionButton = False
        Me.rpg_Printing.Text = "Printing"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(617, 31)
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Government Arts College (Autonomous)"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Home As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Admission As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents btn_Exit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AdmissionList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_DefaultFeesStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Settings As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_Courses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AdmissionList_View As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Billing As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_AdmissionFees As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_BillPrinter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rp_Settings As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpg_Printing As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
