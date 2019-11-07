<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPayments
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
        Me.components = New System.ComponentModel.Container()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtxRecieve = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelGv = New System.Windows.Forms.Panel()
        Me.gvView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelButtom = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsstTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsstDate = New System.Windows.Forms.ToolStripLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TimerPayment = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelGv.SuspendLayout()
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelButtom.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMain.Controls.Add(Me.TabControl3)
        Me.panelMain.Controls.Add(Me.TabControl2)
        Me.panelMain.Controls.Add(Me.TabControl1)
        Me.panelMain.Controls.Add(Me.btnDone)
        Me.panelMain.Controls.Add(Me.Button1)
        Me.panelMain.Controls.Add(Me.panelButtom)
        Me.panelMain.Location = New System.Drawing.Point(11, 77)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(667, 382)
        Me.panelMain.TabIndex = 0
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl3.Location = New System.Drawing.Point(9, 140)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(284, 178)
        Me.TabControl3.TabIndex = 78
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(276, 140)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Billing Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtChange)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtxRecieve)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtTotal)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(6, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(264, 128)
        Me.Panel4.TabIndex = 0
        '
        'txtChange
        '
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(96, 83)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(150, 34)
        Me.txtChange.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total :"
        '
        'txtxRecieve
        '
        Me.txtxRecieve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtxRecieve.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxRecieve.Location = New System.Drawing.Point(96, 43)
        Me.txtxRecieve.Name = "txtxRecieve"
        Me.txtxRecieve.Size = New System.Drawing.Size(150, 34)
        Me.txtxRecieve.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Recieve :"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(96, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(150, 34)
        Me.txtTotal.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 88)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 25)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Change :"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl2.Location = New System.Drawing.Point(9, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(284, 135)
        Me.TabControl2.TabIndex = 77
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(276, 97)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Customer Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rdbFemale)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.rdbMale)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 85)
        Me.Panel1.TabIndex = 0
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.BackColor = System.Drawing.Color.Transparent
        Me.rdbFemale.Enabled = False
        Me.rdbFemale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbFemale.ForeColor = System.Drawing.Color.Black
        Me.rdbFemale.Location = New System.Drawing.Point(157, 46)
        Me.rdbFemale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(90, 29)
        Me.rdbFemale.TabIndex = 42
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Name"
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Enabled = False
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.txtFName.ForeColor = System.Drawing.Color.Black
        Me.txtFName.Location = New System.Drawing.Point(81, 8)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(165, 34)
        Me.txtFName.TabIndex = 39
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.BackColor = System.Drawing.Color.Transparent
        Me.rdbMale.Checked = True
        Me.rdbMale.Enabled = False
        Me.rdbMale.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.rdbMale.ForeColor = System.Drawing.Color.Black
        Me.rdbMale.Location = New System.Drawing.Point(81, 46)
        Me.rdbMale.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(72, 29)
        Me.rdbMale.TabIndex = 41
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(36, 46)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Sex"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TabControl1.Location = New System.Drawing.Point(299, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(355, 315)
        Me.TabControl1.TabIndex = 76
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(347, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Serve"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.panelGv)
        Me.Panel3.Controls.Add(Me.btnAddEmployee)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 265)
        Me.Panel3.TabIndex = 64
        '
        'panelGv
        '
        Me.panelGv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelGv.Controls.Add(Me.gvView)
        Me.panelGv.Location = New System.Drawing.Point(3, 49)
        Me.panelGv.Name = "panelGv"
        Me.panelGv.Size = New System.Drawing.Size(329, 213)
        Me.panelGv.TabIndex = 65
        '
        'gvView
        '
        Me.gvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvView.BackgroundColor = System.Drawing.Color.White
        Me.gvView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.gvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvView.Location = New System.Drawing.Point(0, 0)
        Me.gvView.Name = "gvView"
        Me.gvView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvView.RowHeadersVisible = False
        Me.gvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvView.Size = New System.Drawing.Size(327, 211)
        Me.gvView.TabIndex = 64
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "No."
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(4, 5)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(144, 39)
        Me.btnAddEmployee.TabIndex = 64
        Me.btnAddEmployee.Text = "+ Employee"
        Me.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.Location = New System.Drawing.Point(406, 323)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(122, 32)
        Me.btnDone.TabIndex = 75
        Me.btnDone.Text = "PAY"
        Me.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(532, 323)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 32)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panelButtom
        '
        Me.panelButtom.BackColor = System.Drawing.Color.Transparent
        Me.panelButtom.Controls.Add(Me.ToolStrip1)
        Me.panelButtom.Controls.Add(Me.btnCancel)
        Me.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelButtom.Location = New System.Drawing.Point(0, 357)
        Me.panelButtom.Name = "panelButtom"
        Me.panelButtom.Size = New System.Drawing.Size(665, 23)
        Me.panelButtom.TabIndex = 69
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsstTime, Me.ToolStripSeparator2, Me.tsstDate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(665, 23)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'tsstTime
        '
        Me.tsstTime.Name = "tsstTime"
        Me.tsstTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tsstTime.Size = New System.Drawing.Size(53, 20)
        Me.tsstTime.Text = "Time"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'tsstDate
        '
        Me.tsstDate.Name = "tsstDate"
        Me.tsstDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tsstDate.Size = New System.Drawing.Size(51, 20)
        Me.tsstDate.Text = "Date"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCancel.Location = New System.Drawing.Point(391, -15)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnCancel.TabIndex = 70
        Me.btnCancel.Text = "Close"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TimerPayment
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(250, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 46)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "PAYMENTS"
        '
        'frmAddPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(689, 470)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panelMain)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAddPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panelGv.ResumeLayout(False)
        CType(Me.gvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelButtom.ResumeLayout(False)
        Me.panelButtom.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents TimerPayment As Timer
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtxRecieve As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents panelButtom As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsstTime As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsstDate As ToolStripLabel
    Friend WithEvents btnDone As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelGv As Panel
    Friend WithEvents gvView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
End Class
