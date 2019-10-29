<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditManualTimein
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdbPmTimeOut = New System.Windows.Forms.RadioButton()
        Me.rdbPmTimeIn = New System.Windows.Forms.RadioButton()
        Me.rdbAmTimeOut = New System.Windows.Forms.RadioButton()
        Me.rdbAmTimeIn = New System.Windows.Forms.RadioButton()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(289, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(359, 57)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "MANUAL TIME-IN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.panel)
        Me.Panel1.Location = New System.Drawing.Point(15, 95)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 450)
        Me.Panel1.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnUpdate)
        Me.Panel4.Location = New System.Drawing.Point(628, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(276, 441)
        Me.Panel4.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(7, 375)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(259, 58)
        Me.btnCancel.TabIndex = 135
        Me.btnCancel.Text = "Close"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(7, 313)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(259, 58)
        Me.btnUpdate.TabIndex = 134
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel.Controls.Add(Me.TabControl3)
        Me.panel.Controls.Add(Me.TabControl2)
        Me.panel.Controls.Add(Me.TabControl1)
        Me.panel.Location = New System.Drawing.Point(3, 4)
        Me.panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(619, 441)
        Me.panel.TabIndex = 3
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl3.Location = New System.Drawing.Point(345, 5)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(267, 217)
        Me.TabControl3.TabIndex = 127
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(259, 173)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Remarks"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.rdbPmTimeOut)
        Me.Panel2.Controls.Add(Me.rdbPmTimeIn)
        Me.Panel2.Controls.Add(Me.rdbAmTimeOut)
        Me.Panel2.Controls.Add(Me.rdbAmTimeIn)
        Me.Panel2.Location = New System.Drawing.Point(5, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 161)
        Me.Panel2.TabIndex = 0
        '
        'rdbPmTimeOut
        '
        Me.rdbPmTimeOut.AutoSize = True
        Me.rdbPmTimeOut.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbPmTimeOut.ForeColor = System.Drawing.Color.Black
        Me.rdbPmTimeOut.Location = New System.Drawing.Point(15, 123)
        Me.rdbPmTimeOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbPmTimeOut.Name = "rdbPmTimeOut"
        Me.rdbPmTimeOut.Size = New System.Drawing.Size(181, 36)
        Me.rdbPmTimeOut.TabIndex = 122
        Me.rdbPmTimeOut.Text = "PM Time-Out"
        Me.rdbPmTimeOut.UseVisualStyleBackColor = True
        '
        'rdbPmTimeIn
        '
        Me.rdbPmTimeIn.AutoSize = True
        Me.rdbPmTimeIn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbPmTimeIn.ForeColor = System.Drawing.Color.Black
        Me.rdbPmTimeIn.Location = New System.Drawing.Point(15, 85)
        Me.rdbPmTimeIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbPmTimeIn.Name = "rdbPmTimeIn"
        Me.rdbPmTimeIn.Size = New System.Drawing.Size(161, 36)
        Me.rdbPmTimeIn.TabIndex = 121
        Me.rdbPmTimeIn.Text = "PM Time-In"
        Me.rdbPmTimeIn.UseVisualStyleBackColor = True
        '
        'rdbAmTimeOut
        '
        Me.rdbAmTimeOut.AutoSize = True
        Me.rdbAmTimeOut.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbAmTimeOut.ForeColor = System.Drawing.Color.Black
        Me.rdbAmTimeOut.Location = New System.Drawing.Point(15, 44)
        Me.rdbAmTimeOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbAmTimeOut.Name = "rdbAmTimeOut"
        Me.rdbAmTimeOut.Size = New System.Drawing.Size(183, 36)
        Me.rdbAmTimeOut.TabIndex = 120
        Me.rdbAmTimeOut.Text = "AM Time-Out"
        Me.rdbAmTimeOut.UseVisualStyleBackColor = True
        '
        'rdbAmTimeIn
        '
        Me.rdbAmTimeIn.AutoSize = True
        Me.rdbAmTimeIn.Checked = True
        Me.rdbAmTimeIn.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbAmTimeIn.ForeColor = System.Drawing.Color.Black
        Me.rdbAmTimeIn.Location = New System.Drawing.Point(15, 4)
        Me.rdbAmTimeIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbAmTimeIn.Name = "rdbAmTimeIn"
        Me.rdbAmTimeIn.Size = New System.Drawing.Size(163, 36)
        Me.rdbAmTimeIn.TabIndex = 119
        Me.rdbAmTimeIn.TabStop = True
        Me.rdbAmTimeIn.Text = "AM Time-In"
        Me.rdbAmTimeIn.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl2.Location = New System.Drawing.Point(345, 226)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(267, 212)
        Me.TabControl2.TabIndex = 126
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(259, 168)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Date & Time"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.dtpDate)
        Me.Panel3.Controls.Add(Me.dtpTime)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(5, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(245, 159)
        Me.Panel3.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(20, 108)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(184, 39)
        Me.dtpDate.TabIndex = 30
        Me.dtpDate.Value = New Date(2019, 10, 14, 0, 0, 0, 0)
        '
        'dtpTime
        '
        Me.dtpTime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(19, 34)
        Me.dtpTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(187, 39)
        Me.dtpTime.TabIndex = 29
        Me.dtpTime.Value = New Date(2019, 10, 14, 1, 17, 30, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 35)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 35)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Time"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl1.Location = New System.Drawing.Point(3, 5)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(337, 433)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(329, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtPosition)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.rdbFemale)
        Me.Panel5.Controls.Add(Me.rdbMale)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtMName)
        Me.Panel5.Controls.Add(Me.txtFName)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtLName)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(5, 6)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(315, 377)
        Me.Panel5.TabIndex = 0
        '
        'txtPosition
        '
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtPosition.Location = New System.Drawing.Point(9, 329)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(259, 39)
        Me.txtPosition.TabIndex = 120
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 35)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Position"
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Enabled = False
        Me.rdbFemale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbFemale.ForeColor = System.Drawing.Color.Black
        Me.rdbFemale.Location = New System.Drawing.Point(115, 261)
        Me.rdbFemale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(113, 36)
        Me.rdbFemale.TabIndex = 118
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Checked = True
        Me.rdbMale.Enabled = False
        Me.rdbMale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbMale.ForeColor = System.Drawing.Color.Black
        Me.rdbMale.Location = New System.Drawing.Point(13, 261)
        Me.rdbMale.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(89, 36)
        Me.rdbMale.TabIndex = 117
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 35)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Gender"
        '
        'txtMName
        '
        Me.txtMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMName.Enabled = False
        Me.txtMName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtMName.Location = New System.Drawing.Point(13, 187)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(259, 39)
        Me.txtMName.TabIndex = 115
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Enabled = False
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtFName.Location = New System.Drawing.Point(9, 114)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(259, 39)
        Me.txtFName.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 35)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 35)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "First Name"
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Enabled = False
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtLName.Location = New System.Drawing.Point(9, 42)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(259, 39)
        Me.txtLName.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 35)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Last Name"
        '
        'frmEditManualTimein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(945, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmEditManualTimein"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.panel.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents panel As Panel
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdbPmTimeOut As RadioButton
    Friend WithEvents rdbPmTimeIn As RadioButton
    Friend WithEvents rdbAmTimeOut As RadioButton
    Friend WithEvents rdbAmTimeIn As RadioButton
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label2 As Label
End Class
