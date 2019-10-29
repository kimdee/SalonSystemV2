<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEmployeePayroll
    Inherits MaterialSkin.Controls.MaterialForm
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.tbcntrlSalary = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panelSalary = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtStandardPay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelGvDeduction = New System.Windows.Forms.Panel()
        Me.gvViewDeduction = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddDeduction = New System.Windows.Forms.Button()
        Me.txtBasicPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOvertime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNepay = New System.Windows.Forms.TextBox()
        Me.tbcntrlEmployee = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panelEmployee = New System.Windows.Forms.Panel()
        Me.gvViewEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.tbcntrlSalary.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.panelSalary.SuspendLayout()
        Me.panelGvDeduction.SuspendLayout()
        CType(Me.gvViewDeduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcntrlEmployee.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.panelEmployee.SuspendLayout()
        CType(Me.gvViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Controls.Add(Me.tbcntrlSalary)
        Me.panelMain.Controls.Add(Me.tbcntrlEmployee)
        Me.panelMain.Location = New System.Drawing.Point(15, 95)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1026, 621)
        Me.panelMain.TabIndex = 4
        '
        'tbcntrlSalary
        '
        Me.tbcntrlSalary.Controls.Add(Me.TabPage2)
        Me.tbcntrlSalary.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcntrlSalary.Location = New System.Drawing.Point(481, 4)
        Me.tbcntrlSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcntrlSalary.Name = "tbcntrlSalary"
        Me.tbcntrlSalary.SelectedIndex = 0
        Me.tbcntrlSalary.Size = New System.Drawing.Size(541, 614)
        Me.tbcntrlSalary.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.panelSalary)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(533, 570)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Salary Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'panelSalary
        '
        Me.panelSalary.Controls.Add(Me.Label8)
        Me.panelSalary.Controls.Add(Me.txtPosition)
        Me.panelSalary.Controls.Add(Me.txtStandardPay)
        Me.panelSalary.Controls.Add(Me.Label5)
        Me.panelSalary.Controls.Add(Me.txtTotalDeduction)
        Me.panelSalary.Controls.Add(Me.Label6)
        Me.panelSalary.Controls.Add(Me.panelGvDeduction)
        Me.panelSalary.Controls.Add(Me.Button1)
        Me.panelSalary.Controls.Add(Me.btnAddDeduction)
        Me.panelSalary.Controls.Add(Me.txtBasicPay)
        Me.panelSalary.Controls.Add(Me.Label4)
        Me.panelSalary.Controls.Add(Me.Label3)
        Me.panelSalary.Controls.Add(Me.txtGrossPay)
        Me.panelSalary.Controls.Add(Me.Label1)
        Me.panelSalary.Controls.Add(Me.txtOvertime)
        Me.panelSalary.Controls.Add(Me.Label2)
        Me.panelSalary.Controls.Add(Me.txtNepay)
        Me.panelSalary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSalary.Location = New System.Drawing.Point(4, 4)
        Me.panelSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSalary.Name = "panelSalary"
        Me.panelSalary.Size = New System.Drawing.Size(525, 562)
        Me.panelSalary.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 35)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Position Type"
        '
        'txtPosition
        '
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.Enabled = False
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(14, 304)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(217, 39)
        Me.txtPosition.TabIndex = 72
        '
        'txtStandardPay
        '
        Me.txtStandardPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStandardPay.Enabled = False
        Me.txtStandardPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtStandardPay.ForeColor = System.Drawing.Color.Black
        Me.txtStandardPay.Location = New System.Drawing.Point(14, 375)
        Me.txtStandardPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStandardPay.Name = "txtStandardPay"
        Me.txtStandardPay.Size = New System.Drawing.Size(217, 39)
        Me.txtStandardPay.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 35)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Basic Pay"
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDeduction.Enabled = False
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtTotalDeduction.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDeduction.Location = New System.Drawing.Point(295, 304)
        Me.txtTotalDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.Size = New System.Drawing.Size(217, 39)
        Me.txtTotalDeduction.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(288, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 35)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Total Deduction"
        '
        'panelGvDeduction
        '
        Me.panelGvDeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGvDeduction.Controls.Add(Me.gvViewDeduction)
        Me.panelGvDeduction.Location = New System.Drawing.Point(4, 4)
        Me.panelGvDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.panelGvDeduction.Name = "panelGvDeduction"
        Me.panelGvDeduction.Size = New System.Drawing.Size(514, 200)
        Me.panelGvDeduction.TabIndex = 67
        '
        'gvViewDeduction
        '
        Me.gvViewDeduction.AllowUserToAddRows = False
        Me.gvViewDeduction.AllowUserToDeleteRows = False
        Me.gvViewDeduction.AllowUserToResizeColumns = False
        Me.gvViewDeduction.AllowUserToResizeRows = False
        Me.gvViewDeduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvViewDeduction.BackgroundColor = System.Drawing.Color.White
        Me.gvViewDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvViewDeduction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvViewDeduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvViewDeduction.ColumnHeadersHeight = 27
        Me.gvViewDeduction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.gvViewDeduction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvViewDeduction.EnableHeadersVisualStyles = False
        Me.gvViewDeduction.Location = New System.Drawing.Point(0, 0)
        Me.gvViewDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gvViewDeduction.Name = "gvViewDeduction"
        Me.gvViewDeduction.ReadOnly = True
        Me.gvViewDeduction.RowHeadersVisible = False
        Me.gvViewDeduction.RowTemplate.Height = 24
        Me.gvViewDeduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvViewDeduction.Size = New System.Drawing.Size(512, 198)
        Me.gvViewDeduction.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "No."
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Type"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amount"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(259, 497)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 58)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Generate Payroll"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAddDeduction
        '
        Me.btnAddDeduction.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAddDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDeduction.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnAddDeduction.ForeColor = System.Drawing.Color.White
        Me.btnAddDeduction.Location = New System.Drawing.Point(3, 208)
        Me.btnAddDeduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddDeduction.Name = "btnAddDeduction"
        Me.btnAddDeduction.Size = New System.Drawing.Size(228, 58)
        Me.btnAddDeduction.TabIndex = 64
        Me.btnAddDeduction.Text = "+ Deduction"
        Me.btnAddDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDeduction.UseVisualStyleBackColor = False
        '
        'txtBasicPay
        '
        Me.txtBasicPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBasicPay.Enabled = False
        Me.txtBasicPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtBasicPay.ForeColor = System.Drawing.Color.Black
        Me.txtBasicPay.Location = New System.Drawing.Point(14, 442)
        Me.txtBasicPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBasicPay.Name = "txtBasicPay"
        Me.txtBasicPay.Size = New System.Drawing.Size(217, 39)
        Me.txtBasicPay.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 35)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Standard Pay(Per Day)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(288, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 35)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Gross Pay"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPay.Enabled = False
        Me.txtGrossPay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtGrossPay.ForeColor = System.Drawing.Color.Black
        Me.txtGrossPay.Location = New System.Drawing.Point(295, 378)
        Me.txtGrossPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(217, 39)
        Me.txtGrossPay.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 35)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Overtime"
        '
        'txtOvertime
        '
        Me.txtOvertime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOvertime.Enabled = False
        Me.txtOvertime.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtOvertime.ForeColor = System.Drawing.Color.Black
        Me.txtOvertime.Location = New System.Drawing.Point(14, 510)
        Me.txtOvertime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Size = New System.Drawing.Size(217, 39)
        Me.txtOvertime.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(288, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 35)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Net Pay"
        '
        'txtNepay
        '
        Me.txtNepay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNepay.Enabled = False
        Me.txtNepay.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtNepay.ForeColor = System.Drawing.Color.Black
        Me.txtNepay.Location = New System.Drawing.Point(295, 453)
        Me.txtNepay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNepay.Name = "txtNepay"
        Me.txtNepay.Size = New System.Drawing.Size(217, 39)
        Me.txtNepay.TabIndex = 48
        '
        'tbcntrlEmployee
        '
        Me.tbcntrlEmployee.Controls.Add(Me.TabPage1)
        Me.tbcntrlEmployee.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.tbcntrlEmployee.Location = New System.Drawing.Point(4, 4)
        Me.tbcntrlEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcntrlEmployee.Name = "tbcntrlEmployee"
        Me.tbcntrlEmployee.SelectedIndex = 0
        Me.tbcntrlEmployee.Size = New System.Drawing.Size(475, 614)
        Me.tbcntrlEmployee.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelEmployee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(467, 570)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panelEmployee
        '
        Me.panelEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmployee.Controls.Add(Me.gvViewEmployee)
        Me.panelEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEmployee.Location = New System.Drawing.Point(4, 4)
        Me.panelEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.panelEmployee.Name = "panelEmployee"
        Me.panelEmployee.Size = New System.Drawing.Size(459, 562)
        Me.panelEmployee.TabIndex = 0
        '
        'gvViewEmployee
        '
        Me.gvViewEmployee.AllowUserToAddRows = False
        Me.gvViewEmployee.AllowUserToDeleteRows = False
        Me.gvViewEmployee.AllowUserToResizeColumns = False
        Me.gvViewEmployee.AllowUserToResizeRows = False
        Me.gvViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvViewEmployee.BackgroundColor = System.Drawing.Color.White
        Me.gvViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvViewEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvViewEmployee.ColumnHeadersHeight = 35
        Me.gvViewEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.gvViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvViewEmployee.EnableHeadersVisualStyles = False
        Me.gvViewEmployee.Location = New System.Drawing.Point(0, 0)
        Me.gvViewEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gvViewEmployee.Name = "gvViewEmployee"
        Me.gvViewEmployee.ReadOnly = True
        Me.gvViewEmployee.RowHeadersVisible = False
        Me.gvViewEmployee.RowTemplate.Height = 24
        Me.gvViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvViewEmployee.Size = New System.Drawing.Size(457, 560)
        Me.gvViewEmployee.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 20
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "No."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.Width = 35
        '
        'Column4
        '
        Me.Column4.HeaderText = "Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Position"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(311, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(396, 57)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "GENERATE PAYROLL"
        '
        'frmAddEmployeePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1056, 730)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.panelMain)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAddEmployeePayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.tbcntrlSalary.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.panelSalary.ResumeLayout(False)
        Me.panelSalary.PerformLayout()
        Me.panelGvDeduction.ResumeLayout(False)
        CType(Me.gvViewDeduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcntrlEmployee.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.panelEmployee.ResumeLayout(False)
        CType(Me.gvViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents tbcntrlSalary As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents panelSalary As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAddDeduction As Button
    Friend WithEvents txtBasicPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNepay As TextBox
    Friend WithEvents tbcntrlEmployee As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents panelEmployee As Panel
    Friend WithEvents panelGvDeduction As Panel
    Friend WithEvents gvViewEmployee As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents gvViewDeduction As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewLinkColumn
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStandardPay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
