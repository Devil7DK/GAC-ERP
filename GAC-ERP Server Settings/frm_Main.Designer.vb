<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.txt_ServerAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txt_DatabaseName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Username = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Update = New DevExpress.XtraEditors.SimpleButton()
        Me.cb_ShowPassword = New DevExpress.XtraEditors.CheckEdit()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        CType(Me.txt_ServerAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DatabaseName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_ShowPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_ServerAddress
        '
        Me.txt_ServerAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ServerAddress.EnterMoveNextControl = True
        Me.txt_ServerAddress.Location = New System.Drawing.Point(101, 12)
        Me.txt_ServerAddress.Name = "txt_ServerAddress"
        Me.txt_ServerAddress.Size = New System.Drawing.Size(177, 20)
        Me.txt_ServerAddress.TabIndex = 0
        '
        'txt_DatabaseName
        '
        Me.txt_DatabaseName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DatabaseName.EnterMoveNextControl = True
        Me.txt_DatabaseName.Location = New System.Drawing.Point(101, 38)
        Me.txt_DatabaseName.Name = "txt_DatabaseName"
        Me.txt_DatabaseName.Size = New System.Drawing.Size(177, 20)
        Me.txt_DatabaseName.TabIndex = 1
        '
        'txt_Username
        '
        Me.txt_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Username.EnterMoveNextControl = True
        Me.txt_Username.Location = New System.Drawing.Point(101, 64)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(177, 20)
        Me.txt_Username.TabIndex = 2
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Password.EnterMoveNextControl = True
        Me.txt_Password.Location = New System.Drawing.Point(101, 90)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(177, 20)
        Me.txt_Password.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Server Address :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Database Name :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Username :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(42, 93)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Password :"
        '
        'btn_Update
        '
        Me.btn_Update.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Update.Enabled = False
        Me.btn_Update.Location = New System.Drawing.Point(203, 116)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(75, 24)
        Me.btn_Update.TabIndex = 4
        Me.btn_Update.Text = "Update"
        '
        'cb_ShowPassword
        '
        Me.cb_ShowPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_ShowPassword.Location = New System.Drawing.Point(12, 121)
        Me.cb_ShowPassword.Name = "cb_ShowPassword"
        Me.cb_ShowPassword.Properties.Caption = "Show Password"
        Me.cb_ShowPassword.Size = New System.Drawing.Size(99, 19)
        Me.cb_ShowPassword.TabIndex = 6
        Me.cb_ShowPassword.TabStop = False
        '
        'Worker
        '
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 152)
        Me.Controls.Add(Me.cb_ShowPassword)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_DatabaseName)
        Me.Controls.Add(Me.txt_ServerAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GAC-ERP Server Settings Editor"
        CType(Me.txt_ServerAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DatabaseName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_ShowPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ServerAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_DatabaseName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cb_ShowPassword As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
End Class
