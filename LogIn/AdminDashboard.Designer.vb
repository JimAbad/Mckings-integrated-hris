<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Payroll = New Button()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label3 = New Label()
        LabelTime = New Label()
        Label4 = New Label()
        LabelDate = New Label()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Button2 = New Button()
        Label2 = New Label()
        contentPanel = New Panel()
        txtEmployeeNameFilter = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        btnFilterByDateAndName = New Button()
        DateTimePickerEnd = New DateTimePicker()
        DateTimePickerStart = New DateTimePicker()
        Timer1 = New Timer(components)
        Label7 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        contentPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Payroll
        ' 
        Payroll.BackColor = Color.Firebrick
        Payroll.FlatStyle = FlatStyle.Flat
        Payroll.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Payroll.ForeColor = Color.Gainsboro
        Payroll.Location = New Point(37, 299)
        Payroll.Margin = New Padding(2)
        Payroll.Name = "Payroll"
        Payroll.Size = New Size(163, 25)
        Payroll.TabIndex = 35
        Payroll.Text = "PAYROLL"
        Payroll.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(37, 247)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 25)
        Button1.TabIndex = 31
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(63, 152)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 16)
        Label1.TabIndex = 30
        Label1.Text = "Employee Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Firebrick
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(58, 46)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(119, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 29
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Firebrick
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 573)
        PictureBox1.TabIndex = 28
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(LabelTime)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(LabelDate)
        Panel2.Location = New Point(5, 71)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1150, 53)
        Panel2.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(784, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 18)
        Label3.TabIndex = 48
        Label3.Text = "DATE:"
        ' 
        ' LabelTime
        ' 
        LabelTime.Anchor = AnchorStyles.None
        LabelTime.AutoSize = True
        LabelTime.BackColor = Color.Transparent
        LabelTime.Font = New Font("Arial", 12F)
        LabelTime.Location = New Point(484, 17)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(44, 18)
        LabelTime.TabIndex = 22
        LabelTime.Text = "TIME"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F)
        Label4.Location = New Point(348, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 18)
        Label4.TabIndex = 47
        Label4.Text = "TIME:"
        ' 
        ' LabelDate
        ' 
        LabelDate.Anchor = AnchorStyles.None
        LabelDate.AutoSize = True
        LabelDate.BackColor = Color.Transparent
        LabelDate.Font = New Font("Arial", 12F)
        LabelDate.Location = New Point(910, 17)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(50, 18)
        LabelDate.TabIndex = 24
        LabelDate.Text = "DATE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(250, 316)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(882, 231)
        DataGridView1.TabIndex = 26
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1158, 53)
        Panel1.TabIndex = 27
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(989, 13)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 32)
        Button2.TabIndex = 18
        Button2.Text = "Log out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(531, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(338, 29)
        Label2.TabIndex = 17
        Label2.Text = "ATTENDANCE MONITORING"
        ' 
        ' contentPanel
        ' 
        contentPanel.Controls.Add(Label7)
        contentPanel.Controls.Add(txtEmployeeNameFilter)
        contentPanel.Controls.Add(Label6)
        contentPanel.Controls.Add(Label5)
        contentPanel.Controls.Add(btnFilterByDateAndName)
        contentPanel.Controls.Add(DateTimePickerEnd)
        contentPanel.Controls.Add(DateTimePickerStart)
        contentPanel.Controls.Add(Panel1)
        contentPanel.Controls.Add(DataGridView1)
        contentPanel.Controls.Add(Panel2)
        contentPanel.Dock = DockStyle.Fill
        contentPanel.Location = New Point(0, 0)
        contentPanel.Name = "contentPanel"
        contentPanel.Size = New Size(1158, 573)
        contentPanel.TabIndex = 36
        ' 
        ' txtEmployeeNameFilter
        ' 
        txtEmployeeNameFilter.Location = New Point(301, 277)
        txtEmployeeNameFilter.Name = "txtEmployeeNameFilter"
        txtEmployeeNameFilter.Size = New Size(100, 23)
        txtEmployeeNameFilter.TabIndex = 46
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(828, 258)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 45
        Label6.Text = "Date End"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(603, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 44
        Label5.Text = "Starting Date"
        ' 
        ' btnFilterByDateAndName
        ' 
        btnFilterByDateAndName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnFilterByDateAndName.Location = New Point(1045, 277)
        btnFilterByDateAndName.Name = "btnFilterByDateAndName"
        btnFilterByDateAndName.Size = New Size(75, 23)
        btnFilterByDateAndName.TabIndex = 43
        btnFilterByDateAndName.Text = "Search"
        btnFilterByDateAndName.UseVisualStyleBackColor = True
        ' 
        ' DateTimePickerEnd
        ' 
        DateTimePickerEnd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePickerEnd.Location = New Point(828, 276)
        DateTimePickerEnd.Name = "DateTimePickerEnd"
        DateTimePickerEnd.Size = New Size(200, 23)
        DateTimePickerEnd.TabIndex = 41
        ' 
        ' DateTimePickerStart
        ' 
        DateTimePickerStart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePickerStart.Location = New Point(603, 276)
        DateTimePickerStart.Name = "DateTimePickerStart"
        DateTimePickerStart.Size = New Size(200, 23)
        DateTimePickerStart.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(253, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 47
        Label7.Text = "Name:"
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 573)
        Controls.Add(Payroll)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(contentPanel)
        Name = "AdminDashboard"
        Text = "AdminDashboard"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        contentPanel.ResumeLayout(False)
        contentPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Payroll As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents contentPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFilterByDateAndName As Button
    Friend WithEvents DateTimePickerEnd As DateTimePicker
    Friend WithEvents DateTimePickerStart As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtEmployeeNameFilter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class
