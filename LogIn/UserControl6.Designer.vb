<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl6
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
        components = New ComponentModel.Container()
        Panel2 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        LabelTime = New Label()
        LabelDate = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Label2 = New Label()
        DateTimePickerStart = New DateTimePicker()
        DateTimePickerEnd = New DateTimePicker()
        btnFilterByDateAndName = New Button()
        Label5 = New Label()
        Label6 = New Label()
        contentPanel = New Panel()
        txtEmployeeNameFilter = New TextBox()
        DataGridView1 = New DataGridView()
        Timer1 = New Timer(components)
        Label4 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        contentPanel.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(LabelTime)
        Panel2.Controls.Add(LabelDate)
        Panel2.Location = New Point(-5, 71)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1147, 53)
        Panel2.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(734, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 18)
        Label3.TabIndex = 26
        Label3.Text = "DATE:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 12F)
        Label1.Location = New Point(298, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 18)
        Label1.TabIndex = 25
        Label1.Text = "TIME:"
        ' 
        ' LabelTime
        ' 
        LabelTime.Anchor = AnchorStyles.None
        LabelTime.AutoSize = True
        LabelTime.BackColor = Color.Transparent
        LabelTime.Font = New Font("Arial", 12F)
        LabelTime.Location = New Point(461, 20)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(44, 18)
        LabelTime.TabIndex = 22
        LabelTime.Text = "TIME"
        ' 
        ' LabelDate
        ' 
        LabelDate.Anchor = AnchorStyles.None
        LabelDate.AutoSize = True
        LabelDate.BackColor = Color.Transparent
        LabelDate.Font = New Font("Arial", 12F)
        LabelDate.Location = New Point(888, 20)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(50, 18)
        LabelDate.TabIndex = 24
        LabelDate.Text = "DATE"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1142, 53)
        Panel1.TabIndex = 27
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(980, 13)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 32)
        Button2.TabIndex = 18
        Button2.Text = "Log out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(501, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(338, 29)
        Label2.TabIndex = 17
        Label2.Text = "ATTENDANCE MONITORING"
        ' 
        ' DateTimePickerStart
        ' 
        DateTimePickerStart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePickerStart.Location = New Point(607, 264)
        DateTimePickerStart.Name = "DateTimePickerStart"
        DateTimePickerStart.Size = New Size(200, 23)
        DateTimePickerStart.TabIndex = 32
        ' 
        ' DateTimePickerEnd
        ' 
        DateTimePickerEnd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DateTimePickerEnd.Location = New Point(832, 264)
        DateTimePickerEnd.Name = "DateTimePickerEnd"
        DateTimePickerEnd.Size = New Size(200, 23)
        DateTimePickerEnd.TabIndex = 33
        ' 
        ' btnFilterByDateAndName
        ' 
        btnFilterByDateAndName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnFilterByDateAndName.Location = New Point(1049, 265)
        btnFilterByDateAndName.Name = "btnFilterByDateAndName"
        btnFilterByDateAndName.Size = New Size(75, 23)
        btnFilterByDateAndName.TabIndex = 35
        btnFilterByDateAndName.Text = "Search"
        btnFilterByDateAndName.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(607, 246)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 36
        Label5.Text = "Starting Date"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(832, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 37
        Label6.Text = "Date End"
        ' 
        ' contentPanel
        ' 
        contentPanel.Controls.Add(Label4)
        contentPanel.Controls.Add(txtEmployeeNameFilter)
        contentPanel.Controls.Add(DataGridView1)
        contentPanel.Controls.Add(Label6)
        contentPanel.Controls.Add(Label5)
        contentPanel.Controls.Add(btnFilterByDateAndName)
        contentPanel.Controls.Add(DateTimePickerEnd)
        contentPanel.Controls.Add(DateTimePickerStart)
        contentPanel.Controls.Add(Panel1)
        contentPanel.Controls.Add(Panel2)
        contentPanel.Dock = DockStyle.Fill
        contentPanel.Location = New Point(0, 0)
        contentPanel.Name = "contentPanel"
        contentPanel.Size = New Size(1142, 547)
        contentPanel.TabIndex = 37
        ' 
        ' txtEmployeeNameFilter
        ' 
        txtEmployeeNameFilter.Location = New Point(352, 264)
        txtEmployeeNameFilter.Name = "txtEmployeeNameFilter"
        txtEmployeeNameFilter.Size = New Size(100, 23)
        txtEmployeeNameFilter.TabIndex = 39
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(242, 295)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(882, 231)
        DataGridView1.TabIndex = 38
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(251, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 40
        Label4.Text = "Employee Name:"
        ' 
        ' UserControl6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(contentPanel)
        Name = "UserControl6"
        Size = New Size(1142, 547)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        contentPanel.ResumeLayout(False)
        contentPanel.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelTime As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerStart As DateTimePicker
    Friend WithEvents DateTimePickerEnd As DateTimePicker
    Friend WithEvents btnFilterByDateAndName As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents contentPanel As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtEmployeeNameFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
