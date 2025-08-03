<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl5
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
        dataGridViewDailyHours = New DataGridView()
        Label1 = New Label()
        btnClear = New Button()
        btnGeneratePayroll = New Button()
        txtEmployeeSearch = New TextBox()
        M = New Panel()
        Label2 = New Label()
        txtAddressFilter = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        Panel2 = New Panel()
        PAYROLL = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        lblTotalWorkDays = New TextBox()
        Label4 = New Label()
        txtJobTitle = New TextBox()
        Label3 = New Label()
        txtOvertimeHours = New TextBox()
        lblEmployeeName = New Label()
        txtTotalWorkHours = New TextBox()
        txtPayrollAmount = New TextBox()
        lblTotalHoursWorked = New Label()
        txtEmployeeName = New TextBox()
        txtEmployeeId = New TextBox()
        lblPayrollAmount = New Label()
        lblEmployeeId = New Label()
        CType(dataGridViewDailyHours, ComponentModel.ISupportInitialize).BeginInit()
        M.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dataGridViewDailyHours
        ' 
        dataGridViewDailyHours.AllowUserToAddRows = False
        dataGridViewDailyHours.AllowUserToDeleteRows = False
        dataGridViewDailyHours.AllowUserToResizeColumns = False
        dataGridViewDailyHours.AllowUserToResizeRows = False
        dataGridViewDailyHours.Anchor = AnchorStyles.Bottom
        dataGridViewDailyHours.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridViewDailyHours.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewDailyHours.Enabled = False
        dataGridViewDailyHours.Location = New Point(276, 321)
        dataGridViewDailyHours.MultiSelect = False
        dataGridViewDailyHours.Name = "dataGridViewDailyHours"
        dataGridViewDailyHours.RowHeadersWidth = 51
        dataGridViewDailyHours.Size = New Size(815, 209)
        dataGridViewDailyHours.TabIndex = 57
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Location = New Point(291, 276)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 55
        Label1.Text = "EmployeeName"
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Top
        btnClear.Location = New Point(1016, 290)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 25)
        btnClear.TabIndex = 53
        btnClear.Text = "Reset"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnGeneratePayroll
        ' 
        btnGeneratePayroll.Anchor = AnchorStyles.Top
        btnGeneratePayroll.Location = New Point(899, 290)
        btnGeneratePayroll.Name = "btnGeneratePayroll"
        btnGeneratePayroll.Size = New Size(75, 25)
        btnGeneratePayroll.TabIndex = 52
        btnGeneratePayroll.Text = "Calculate"
        btnGeneratePayroll.UseVisualStyleBackColor = True
        ' 
        ' txtEmployeeSearch
        ' 
        txtEmployeeSearch.Anchor = AnchorStyles.Top
        txtEmployeeSearch.Location = New Point(388, 270)
        txtEmployeeSearch.Name = "txtEmployeeSearch"
        txtEmployeeSearch.Size = New Size(167, 23)
        txtEmployeeSearch.TabIndex = 51
        ' 
        ' M
        ' 
        M.Controls.Add(Label2)
        M.Controls.Add(txtAddressFilter)
        M.Controls.Add(Label6)
        M.Controls.Add(Label5)
        M.Controls.Add(dtpEndDate)
        M.Controls.Add(dtpStartDate)
        M.Controls.Add(Panel2)
        M.Controls.Add(dataGridViewDailyHours)
        M.Controls.Add(Label1)
        M.Controls.Add(txtEmployeeSearch)
        M.Controls.Add(btnClear)
        M.Controls.Add(btnGeneratePayroll)
        M.Controls.Add(Panel3)
        M.Dock = DockStyle.Fill
        M.Location = New Point(0, 0)
        M.Name = "M"
        M.Size = New Size(1142, 547)
        M.TabIndex = 58
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(617, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 74
        Label2.Text = "City"
        ' 
        ' txtAddressFilter
        ' 
        txtAddressFilter.Anchor = AnchorStyles.Top
        txtAddressFilter.Location = New Point(651, 270)
        txtAddressFilter.Name = "txtAddressFilter"
        txtAddressFilter.Size = New Size(167, 23)
        txtAddressFilter.TabIndex = 73
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top
        Label6.AutoSize = True
        Label6.Location = New Point(651, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 72
        Label6.Text = "Date End"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Location = New Point(300, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 71
        Label5.Text = "Starting Date"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Anchor = AnchorStyles.Top
        dtpEndDate.Location = New Point(651, 231)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(200, 23)
        dtpEndDate.TabIndex = 70
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Anchor = AnchorStyles.Top
        dtpStartDate.Location = New Point(300, 231)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(200, 23)
        dtpStartDate.TabIndex = 69
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(PAYROLL)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1142, 57)
        Panel2.TabIndex = 67
        ' 
        ' PAYROLL
        ' 
        PAYROLL.Anchor = AnchorStyles.None
        PAYROLL.AutoSize = True
        PAYROLL.Font = New Font("Segoe UI", 20.0F)
        PAYROLL.Location = New Point(638, 9)
        PAYROLL.Name = "PAYROLL"
        PAYROLL.Size = New Size(122, 37)
        PAYROLL.TabIndex = 1
        PAYROLL.Text = "PAYROLL"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(lblTotalWorkDays)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtJobTitle)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(txtOvertimeHours)
        Panel3.Controls.Add(lblEmployeeName)
        Panel3.Controls.Add(txtTotalWorkHours)
        Panel3.Controls.Add(txtPayrollAmount)
        Panel3.Controls.Add(lblTotalHoursWorked)
        Panel3.Controls.Add(txtEmployeeName)
        Panel3.Controls.Add(txtEmployeeId)
        Panel3.Controls.Add(lblPayrollAmount)
        Panel3.Controls.Add(lblEmployeeId)
        Panel3.Location = New Point(0, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1155, 124)
        Panel3.TabIndex = 68
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.BackColor = Color.Silver
        Label7.Location = New Point(521, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 15)
        Label7.TabIndex = 82
        Label7.Text = "Total Days Work"
        ' 
        ' lblTotalWorkDays
        ' 
        lblTotalWorkDays.Anchor = AnchorStyles.None
        lblTotalWorkDays.Location = New Point(617, 83)
        lblTotalWorkDays.Name = "lblTotalWorkDays"
        lblTotalWorkDays.ReadOnly = True
        lblTotalWorkDays.Size = New Size(173, 23)
        lblTotalWorkDays.TabIndex = 81
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Location = New Point(561, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 80
        Label4.Text = "Job Title"
        ' 
        ' txtJobTitle
        ' 
        txtJobTitle.Anchor = AnchorStyles.None
        txtJobTitle.Location = New Point(617, 54)
        txtJobTitle.Name = "txtJobTitle"
        txtJobTitle.ReadOnly = True
        txtJobTitle.Size = New Size(173, 23)
        txtJobTitle.TabIndex = 79
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Location = New Point(521, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 78
        Label3.Text = "Overtime Hours"
        ' 
        ' txtOvertimeHours
        ' 
        txtOvertimeHours.Anchor = AnchorStyles.None
        txtOvertimeHours.Location = New Point(617, 25)
        txtOvertimeHours.Name = "txtOvertimeHours"
        txtOvertimeHours.ReadOnly = True
        txtOvertimeHours.Size = New Size(173, 23)
        txtOvertimeHours.TabIndex = 77
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.Anchor = AnchorStyles.None
        lblEmployeeName.AutoSize = True
        lblEmployeeName.BackColor = Color.Silver
        lblEmployeeName.Location = New Point(230, 28)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(94, 15)
        lblEmployeeName.TabIndex = 69
        lblEmployeeName.Text = "Employee Name"
        ' 
        ' txtTotalWorkHours
        ' 
        txtTotalWorkHours.Anchor = AnchorStyles.None
        txtTotalWorkHours.Location = New Point(330, 83)
        txtTotalWorkHours.Name = "txtTotalWorkHours"
        txtTotalWorkHours.ReadOnly = True
        txtTotalWorkHours.Size = New Size(161, 23)
        txtTotalWorkHours.TabIndex = 75
        ' 
        ' txtPayrollAmount
        ' 
        txtPayrollAmount.Anchor = AnchorStyles.None
        txtPayrollAmount.Location = New Point(918, 25)
        txtPayrollAmount.Name = "txtPayrollAmount"
        txtPayrollAmount.ReadOnly = True
        txtPayrollAmount.Size = New Size(173, 23)
        txtPayrollAmount.TabIndex = 76
        ' 
        ' lblTotalHoursWorked
        ' 
        lblTotalHoursWorked.Anchor = AnchorStyles.None
        lblTotalHoursWorked.AutoSize = True
        lblTotalHoursWorked.BackColor = Color.Silver
        lblTotalHoursWorked.Location = New Point(227, 86)
        lblTotalHoursWorked.Name = "lblTotalHoursWorked"
        lblTotalHoursWorked.Size = New Size(97, 15)
        lblTotalHoursWorked.TabIndex = 71
        lblTotalHoursWorked.Text = "TotalWorksHours"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Anchor = AnchorStyles.None
        txtEmployeeName.Location = New Point(330, 25)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.ReadOnly = True
        txtEmployeeName.Size = New Size(161, 23)
        txtEmployeeName.TabIndex = 73
        ' 
        ' txtEmployeeId
        ' 
        txtEmployeeId.Anchor = AnchorStyles.None
        txtEmployeeId.Location = New Point(330, 54)
        txtEmployeeId.Name = "txtEmployeeId"
        txtEmployeeId.ReadOnly = True
        txtEmployeeId.Size = New Size(161, 23)
        txtEmployeeId.TabIndex = 74
        ' 
        ' lblPayrollAmount
        ' 
        lblPayrollAmount.Anchor = AnchorStyles.None
        lblPayrollAmount.AutoSize = True
        lblPayrollAmount.BackColor = Color.Silver
        lblPayrollAmount.Location = New Point(821, 28)
        lblPayrollAmount.Name = "lblPayrollAmount"
        lblPayrollAmount.Size = New Size(90, 15)
        lblPayrollAmount.TabIndex = 72
        lblPayrollAmount.Text = "Payroll Amount"
        ' 
        ' lblEmployeeId
        ' 
        lblEmployeeId.Anchor = AnchorStyles.None
        lblEmployeeId.AutoSize = True
        lblEmployeeId.BackColor = Color.Silver
        lblEmployeeId.Location = New Point(244, 57)
        lblEmployeeId.Name = "lblEmployeeId"
        lblEmployeeId.Size = New Size(69, 15)
        lblEmployeeId.TabIndex = 70
        lblEmployeeId.Text = "EmployeeId"
        ' 
        ' UserControl5
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(M)
        Name = "UserControl5"
        Size = New Size(1142, 547)
        CType(dataGridViewDailyHours, ComponentModel.ISupportInitialize).EndInit()
        M.ResumeLayout(False)
        M.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dataGridViewDailyHours As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnGeneratePayroll As Button
    Friend WithEvents txtEmployeeSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PAYROLL As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents txtTotalWorkHours As TextBox
    Friend WithEvents txtPayrollAmount As TextBox
    Friend WithEvents lblTotalHoursWorked As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtEmployeeId As TextBox
    Friend WithEvents lblPayrollAmount As Label
    Friend WithEvents lblEmployeeId As Label
    Friend WithEvents txtOvertimeHours As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents M As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddressFilter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalWorkDays As TextBox

End Class
