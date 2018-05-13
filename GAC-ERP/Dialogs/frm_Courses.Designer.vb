<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Courses
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
        Me.components = New System.ComponentModel.Container()
        Me.grp_Controls = New DevExpress.XtraEditors.GroupControl()
        Me.btn_FeesStructure = New DevExpress.XtraEditors.DropDownButton()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btn_Reload = New DevExpress.XtraEditors.SimpleButton()
        Me.grp_Courses = New DevExpress.XtraEditors.GroupControl()
        Me.gc_Courses = New DevExpress.XtraGrid.GridControl()
        Me.gv_Courses = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Worker_LoadCourses = New System.ComponentModel.BackgroundWorker()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btn_DefaultFeesStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.grp_Controls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Controls.SuspendLayout()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Courses.SuspendLayout()
        CType(Me.gc_Courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Controls
        '
        Me.grp_Controls.Controls.Add(Me.btn_FeesStructure)
        Me.grp_Controls.Controls.Add(Me.SeparatorControl2)
        Me.grp_Controls.Controls.Add(Me.SimpleButton4)
        Me.grp_Controls.Controls.Add(Me.SimpleButton3)
        Me.grp_Controls.Controls.Add(Me.SimpleButton2)
        Me.grp_Controls.Controls.Add(Me.SeparatorControl1)
        Me.grp_Controls.Controls.Add(Me.btn_Reload)
        Me.grp_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Controls.Location = New System.Drawing.Point(0, 0)
        Me.grp_Controls.Name = "grp_Controls"
        Me.grp_Controls.Size = New System.Drawing.Size(589, 66)
        Me.grp_Controls.TabIndex = 0
        Me.grp_Controls.Text = "Controls"
        '
        'btn_FeesStructure
        '
        Me.btn_FeesStructure.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_FeesStructure.DropDownControl = Me.PopupMenu1
        Me.btn_FeesStructure.Location = New System.Drawing.Point(411, 20)
        Me.btn_FeesStructure.Name = "btn_FeesStructure"
        Me.btn_FeesStructure.Size = New System.Drawing.Size(166, 44)
        Me.btn_FeesStructure.TabIndex = 6
        Me.btn_FeesStructure.Text = "Set / Change Fees Structure"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SeparatorControl2.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl2.Location = New System.Drawing.Point(388, 20)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(23, 44)
        Me.SeparatorControl2.TabIndex = 5
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton4.Location = New System.Drawing.Point(293, 20)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(95, 44)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "Remove Course"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton3.Location = New System.Drawing.Point(211, 20)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(82, 44)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "Edit Course"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton2.Location = New System.Drawing.Point(129, 20)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 44)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "New Course"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(106, 20)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(23, 44)
        Me.SeparatorControl1.TabIndex = 1
        '
        'btn_Reload
        '
        Me.btn_Reload.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Reload.Location = New System.Drawing.Point(2, 20)
        Me.btn_Reload.Name = "btn_Reload"
        Me.btn_Reload.Size = New System.Drawing.Size(104, 44)
        Me.btn_Reload.TabIndex = 0
        Me.btn_Reload.Text = "Reload / Refresh"
        '
        'grp_Courses
        '
        Me.grp_Courses.Controls.Add(Me.gc_Courses)
        Me.grp_Courses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_Courses.Location = New System.Drawing.Point(0, 66)
        Me.grp_Courses.Name = "grp_Courses"
        Me.grp_Courses.Size = New System.Drawing.Size(589, 172)
        Me.grp_Courses.TabIndex = 1
        Me.grp_Courses.Text = "Courses"
        '
        'gc_Courses
        '
        Me.gc_Courses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Courses.Location = New System.Drawing.Point(2, 20)
        Me.gc_Courses.MainView = Me.gv_Courses
        Me.gc_Courses.Name = "gc_Courses"
        Me.gc_Courses.Size = New System.Drawing.Size(585, 150)
        Me.gc_Courses.TabIndex = 0
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_DefaultFeesStructure})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(589, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 238)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(589, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 238)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(589, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 238)
        '
        'btn_DefaultFeesStructure
        '
        Me.btn_DefaultFeesStructure.Caption = "Reset Fees Structure to Default"
        Me.btn_DefaultFeesStructure.Id = 0
        Me.btn_DefaultFeesStructure.Name = "btn_DefaultFeesStructure"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DefaultFeesStructure)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'frm_Courses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 261)
        Me.Controls.Add(Me.grp_Courses)
        Me.Controls.Add(Me.grp_Controls)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MinimizeBox = False
        Me.Name = "frm_Courses"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Courses"
        CType(Me.grp_Controls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Controls.ResumeLayout(False)
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Courses.ResumeLayout(False)
        CType(Me.gc_Courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_Controls As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grp_Courses As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_Courses As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Courses As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btn_Reload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Worker_LoadCourses As System.ComponentModel.BackgroundWorker
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btn_FeesStructure As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_DefaultFeesStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
End Class
