<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl3
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        PictureBox5 = New PictureBox()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Panel6 = New Panel()
        Label5 = New Label()
        lblTotalWorkDays = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lblTotalOvertimeHours = New Label()
        lblTotalWorkHours = New Label()
        Panel7 = New Panel()
        ButtonGenerateReport = New Button()
        Label2 = New Label()
        txtTotalPayroll = New TextBox()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Gainsboro
        PictureBox5.Location = New Point(131, 218)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(1008, 280)
        PictureBox5.TabIndex = 66
        PictureBox5.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1142, 547)
        Panel2.TabIndex = 92
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label1)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1142, 44)
        Panel5.TabIndex = 94
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gainsboro
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(549, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 19)
        Label1.TabIndex = 93
        Label1.Text = "PAYROLL SLIP"
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.Silver
        Panel4.Location = New Point(0, 50)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1142, 100)
        Panel4.TabIndex = 92
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel7)
        Panel3.Location = New Point(232, 191)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(885, 335)
        Panel3.TabIndex = 91
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 79)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(843, 162)
        DataGridView1.TabIndex = 97
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.None
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(lblTotalWorkDays)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(lblTotalOvertimeHours)
        Panel6.Controls.Add(lblTotalWorkHours)
        Panel6.Location = New Point(27, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(921, 70)
        Panel6.TabIndex = 100
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(445, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 5
        Label5.Text = "Total Work Days:"
        ' 
        ' lblTotalWorkDays
        ' 
        lblTotalWorkDays.AutoSize = True
        lblTotalWorkDays.Location = New Point(555, 23)
        lblTotalWorkDays.Name = "lblTotalWorkDays"
        lblTotalWorkDays.Size = New Size(16, 15)
        lblTotalWorkDays.TabIndex = 4
        lblTotalWorkDays.Text = "   "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(171, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 15)
        Label4.TabIndex = 3
        Label4.Text = "Total Overtime Hours:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(192, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 15)
        Label3.TabIndex = 2
        Label3.Text = "Total Work Hours:"
        ' 
        ' lblTotalOvertimeHours
        ' 
        lblTotalOvertimeHours.AutoSize = True
        lblTotalOvertimeHours.Location = New Point(302, 43)
        lblTotalOvertimeHours.Name = "lblTotalOvertimeHours"
        lblTotalOvertimeHours.Size = New Size(19, 15)
        lblTotalOvertimeHours.TabIndex = 1
        lblTotalOvertimeHours.Text = "    "
        ' 
        ' lblTotalWorkHours
        ' 
        lblTotalWorkHours.AutoSize = True
        lblTotalWorkHours.Location = New Point(302, 23)
        lblTotalWorkHours.Name = "lblTotalWorkHours"
        lblTotalWorkHours.Size = New Size(16, 15)
        lblTotalWorkHours.TabIndex = 0
        lblTotalWorkHours.Text = "   "
        ' 
        ' Panel7
        ' 
        Panel7.Anchor = AnchorStyles.None
        Panel7.Controls.Add(ButtonGenerateReport)
        Panel7.Controls.Add(Label2)
        Panel7.Controls.Add(txtTotalPayroll)
        Panel7.Location = New Point(14, 247)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(868, 68)
        Panel7.TabIndex = 102
        ' 
        ' ButtonGenerateReport
        ' 
        ButtonGenerateReport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonGenerateReport.Location = New Point(31, 22)
        ButtonGenerateReport.Name = "ButtonGenerateReport"
        ButtonGenerateReport.Size = New Size(212, 23)
        ButtonGenerateReport.TabIndex = 101
        ButtonGenerateReport.Text = "Calculate"
        ButtonGenerateReport.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gainsboro
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(584, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 16)
        Label2.TabIndex = 98
        Label2.Text = "TOTAL PAYROLL:"
        ' 
        ' txtTotalPayroll
        ' 
        txtTotalPayroll.Location = New Point(723, 23)
        txtTotalPayroll.Margin = New Padding(3, 2, 3, 2)
        txtTotalPayroll.Name = "txtTotalPayroll"
        txtTotalPayroll.Size = New Size(110, 23)
        txtTotalPayroll.TabIndex = 99
        ' 
        ' UserControl3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(PictureBox5)
        Name = "UserControl3"
        Size = New Size(1142, 547)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label33 As Label
    Friend WithEvents txtTotalPayroll As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ButtonGenerateReport As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalOvertimeHours As Label
    Friend WithEvents lblTotalWorkHours As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalWorkDays As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label

End Class
