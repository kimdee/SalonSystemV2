<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendanceTimein
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPasscode = New System.Windows.Forms.TextBox()
        Me.lblTodayTime = New System.Windows.Forms.Label()
        Me.lblTodayDate = New System.Windows.Forms.Label()
        Me.TimerAttendance = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.Label6)
        Me.panelMain.Controls.Add(Me.txtPasscode)
        Me.panelMain.Controls.Add(Me.lblTodayTime)
        Me.panelMain.Controls.Add(Me.lblTodayDate)
        Me.panelMain.Location = New System.Drawing.Point(15, 95)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(987, 452)
        Me.panelMain.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(396, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 32)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "ENTER PASSCODE"
        '
        'txtPasscode
        '
        Me.txtPasscode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasscode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPasscode.ForeColor = System.Drawing.Color.DimGray
        Me.txtPasscode.Location = New System.Drawing.Point(312, 324)
        Me.txtPasscode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPasscode.Name = "txtPasscode"
        Me.txtPasscode.Size = New System.Drawing.Size(391, 34)
        Me.txtPasscode.TabIndex = 67
        Me.txtPasscode.Text = "ENTER PASSCODE"
        Me.txtPasscode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPasscode.UseSystemPasswordChar = True
        '
        'lblTodayTime
        '
        Me.lblTodayTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayTime.Font = New System.Drawing.Font("Segoe UI", 55.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayTime.ForeColor = System.Drawing.Color.Black
        Me.lblTodayTime.Location = New System.Drawing.Point(189, 137)
        Me.lblTodayTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTodayTime.Name = "lblTodayTime"
        Me.lblTodayTime.Size = New System.Drawing.Size(637, 142)
        Me.lblTodayTime.TabIndex = 69
        Me.lblTodayTime.Text = "02:21:10 AM"
        Me.lblTodayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTodayDate
        '
        Me.lblTodayDate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayDate.ForeColor = System.Drawing.Color.Black
        Me.lblTodayDate.Location = New System.Drawing.Point(348, 62)
        Me.lblTodayDate.Name = "lblTodayDate"
        Me.lblTodayDate.Size = New System.Drawing.Size(320, 76)
        Me.lblTodayDate.TabIndex = 68
        Me.lblTodayDate.Text = "January 28, 2019"
        Me.lblTodayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerAttendance
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(253, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(466, 48)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "SALON DE ELEGANTE"
        '
        'frmAttendanceTimein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 560)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelMain)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAttendanceTimein"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents TimerAttendance As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPasscode As TextBox
    Friend WithEvents lblTodayTime As Label
    Friend WithEvents lblTodayDate As Label
    Friend WithEvents Label2 As Label
End Class
