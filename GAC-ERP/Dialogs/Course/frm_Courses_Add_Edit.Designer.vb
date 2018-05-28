<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Courses_Add_Edit
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Courses_Add_Edit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CourseID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CourseName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Medium = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Shift = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Department = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_Duration = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_MaxSeats = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_CourseID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CourseName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Medium.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Shift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Department.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Duration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaxSeats.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_Cancel)
        Me.PanelControl1.Controls.Add(Me.btn_OK)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 203)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(338, 37)
        Me.PanelControl1.TabIndex = 0
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.Location = New System.Drawing.Point(5, 5)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.btn_Cancel.TabIndex = 0
        Me.btn_Cancel.Text = "Cancel"
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.Location = New System.Drawing.Point(258, 6)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 26)
        Me.btn_OK.TabIndex = 0
        Me.btn_OK.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 203)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl10, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl11, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl12, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl13, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl14, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CourseID, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CourseName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Medium, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Shift, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Department, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Duration, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_MaxSeats, 2, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 200)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Course ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl2.Location = New System.Drawing.Point(3, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Course Name"
        '
        'LabelControl3
        '
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl3.Location = New System.Drawing.Point(3, 53)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Medium of Course"
        '
        'LabelControl4
        '
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl4.Location = New System.Drawing.Point(3, 78)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Shift"
        '
        'LabelControl5
        '
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl5.Location = New System.Drawing.Point(3, 103)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Department"
        '
        'LabelControl6
        '
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl6.Location = New System.Drawing.Point(3, 128)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Duration"
        '
        'LabelControl7
        '
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl7.Location = New System.Drawing.Point(3, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Max Seats"
        '
        'LabelControl8
        '
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl8.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl8.Location = New System.Drawing.Point(111, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = ":"
        '
        'LabelControl9
        '
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl9.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl9.Location = New System.Drawing.Point(111, 28)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl9.TabIndex = 7
        Me.LabelControl9.Text = ":"
        '
        'LabelControl10
        '
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl10.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl10.Location = New System.Drawing.Point(111, 53)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl10.TabIndex = 7
        Me.LabelControl10.Text = ":"
        '
        'LabelControl11
        '
        Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl11.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl11.Location = New System.Drawing.Point(111, 78)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl11.TabIndex = 7
        Me.LabelControl11.Text = ":"
        '
        'LabelControl12
        '
        Me.LabelControl12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl12.Location = New System.Drawing.Point(111, 103)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl12.TabIndex = 7
        Me.LabelControl12.Text = ":"
        '
        'LabelControl13
        '
        Me.LabelControl13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl13.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl13.Location = New System.Drawing.Point(111, 128)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl13.TabIndex = 7
        Me.LabelControl13.Text = ":"
        '
        'LabelControl14
        '
        Me.LabelControl14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl14.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl14.Location = New System.Drawing.Point(111, 153)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(2, 19)
        Me.LabelControl14.TabIndex = 7
        Me.LabelControl14.Text = ":"
        '
        'txt_CourseID
        '
        Me.txt_CourseID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CourseID.EnterMoveNextControl = True
        Me.txt_CourseID.Location = New System.Drawing.Point(119, 3)
        Me.txt_CourseID.Name = "txt_CourseID"
        Me.txt_CourseID.Size = New System.Drawing.Size(216, 20)
        Me.txt_CourseID.TabIndex = 8
        '
        'txt_CourseName
        '
        Me.txt_CourseName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CourseName.EnterMoveNextControl = True
        Me.txt_CourseName.Location = New System.Drawing.Point(119, 28)
        Me.txt_CourseName.Name = "txt_CourseName"
        Me.txt_CourseName.Size = New System.Drawing.Size(216, 20)
        Me.txt_CourseName.TabIndex = 8
        '
        'txt_Medium
        '
        Me.txt_Medium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Medium.EnterMoveNextControl = True
        Me.txt_Medium.Location = New System.Drawing.Point(119, 53)
        Me.txt_Medium.Name = "txt_Medium"
        Me.txt_Medium.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Medium.Properties.Items.AddRange(New Object() {"Tamil", "English"})
        Me.txt_Medium.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Medium.Size = New System.Drawing.Size(216, 20)
        Me.txt_Medium.TabIndex = 9
        '
        'txt_Shift
        '
        Me.txt_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Shift.EnterMoveNextControl = True
        Me.txt_Shift.Location = New System.Drawing.Point(119, 78)
        Me.txt_Shift.Name = "txt_Shift"
        Me.txt_Shift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Shift.Properties.Items.AddRange(New Object() {"I", "II"})
        Me.txt_Shift.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Shift.Size = New System.Drawing.Size(216, 20)
        Me.txt_Shift.TabIndex = 10
        '
        'txt_Department
        '
        Me.txt_Department.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Department.EnterMoveNextControl = True
        Me.txt_Department.Location = New System.Drawing.Point(119, 103)
        Me.txt_Department.Name = "txt_Department"
        Me.txt_Department.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Department.Properties.Items.AddRange(New Object() {"Botany", "Business Administration", "Chemistry", "Commerce", "Commerce with Computer Applications", "Computer Science", "Economics", "English Literature", "Geography", "History", "Information Technology", "Mathematics", "Physics", "Political Science", "Psychology", "Public Administration", "Statistics", "Tamil Literature", "Tourism & Travel Management", "Zoology"})
        Me.txt_Department.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_Department.Size = New System.Drawing.Size(216, 20)
        Me.txt_Department.TabIndex = 11
        '
        'txt_Duration
        '
        Me.txt_Duration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Duration.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Duration.EnterMoveNextControl = True
        Me.txt_Duration.Location = New System.Drawing.Point(119, 128)
        Me.txt_Duration.Name = "txt_Duration"
        Me.txt_Duration.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Duration.Properties.MaxValue = New Decimal(New Integer() {6, 0, 0, 0})
        Me.txt_Duration.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Duration.Size = New System.Drawing.Size(216, 20)
        Me.txt_Duration.TabIndex = 12
        '
        'txt_MaxSeats
        '
        Me.txt_MaxSeats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MaxSeats.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MaxSeats.EnterMoveNextControl = True
        Me.txt_MaxSeats.Location = New System.Drawing.Point(119, 153)
        Me.txt_MaxSeats.Name = "txt_MaxSeats"
        Me.txt_MaxSeats.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_MaxSeats.Properties.MaxValue = New Decimal(New Integer() {500, 0, 0, 0})
        Me.txt_MaxSeats.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_MaxSeats.Size = New System.Drawing.Size(216, 20)
        Me.txt_MaxSeats.TabIndex = 13
        '
        'frm_Courses_Add_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 240)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(328, 268)
        Me.Name = "frm_Courses_Add_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Course"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_CourseID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CourseName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Medium.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Shift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Department.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Duration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaxSeats.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CourseID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CourseName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Medium As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Shift As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Department As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Duration As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_MaxSeats As DevExpress.XtraEditors.SpinEdit
End Class
