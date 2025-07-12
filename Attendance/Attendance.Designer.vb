<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox5 = New PictureBox()
        Label8 = New Label()
        Button3 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Firebrick
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(261, 522)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(509, 35)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(354, 39)
        Label1.TabIndex = 1
        Label1.Text = "My Attendance Record"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.WhiteSmoke
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column4, Column5, Column6, Column7, Column2, Column3})
        DataGridView1.Location = New Point(282, 265)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(793, 216)
        DataGridView1.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "In Time"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Out Time"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Leave"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Morning Late"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Early Out"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Overtime"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(299, 139)
        DateTimePicker1.Margin = New Padding(2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(269, 27)
        DateTimePicker1.TabIndex = 3
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(572, 138)
        DateTimePicker2.Margin = New Padding(2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(261, 27)
        DateTimePicker2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gainsboro
        Label2.Font = New Font("Arial", 10F)
        Label2.Location = New Point(299, 117)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 19)
        Label2.TabIndex = 5
        Label2.Text = "From"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Gainsboro
        Label3.Font = New Font("Arial", 10F)
        Label3.Location = New Point(572, 117)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 19)
        Label3.TabIndex = 6
        Label3.Text = "Until"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(839, 136)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 27)
        Button1.TabIndex = 7
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Indigo
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(931, 136)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 27)
        Button2.TabIndex = 8
        Button2.Text = "Download PDF"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Gainsboro
        PictureBox2.Location = New Point(282, 103)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(793, 73)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Gainsboro
        PictureBox3.Location = New Point(282, 180)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(793, 73)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Silver
        PictureBox4.Location = New Point(282, 180)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(793, 38)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(293, 190)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 19)
        Label4.TabIndex = 12
        Label4.Text = "Employee Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Silver
        Label5.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(756, 190)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 19)
        Label5.TabIndex = 13
        Label5.Text = "Employee ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Gainsboro
        Label6.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(293, 225)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 19)
        Label6.TabIndex = 14
        Label6.Text = "LUCKYBU, RAT KO."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Gainsboro
        Label7.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(756, 225)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 19)
        Label7.TabIndex = 15
        Label7.Text = "12345"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Firebrick
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(62, 0)
        PictureBox5.Margin = New Padding(2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(136, 123)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Firebrick
        Label8.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Gainsboro
        Label8.Location = New Point(67, 141)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 19)
        Label8.TabIndex = 17
        Label8.Text = "Employee Name"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Firebrick
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Gainsboro
        Button3.Location = New Point(39, 208)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(186, 33)
        Button3.TabIndex = 18
        Button3.Text = "DASHBOARD"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Firebrick
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Gainsboro
        Button5.Location = New Point(39, 265)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(186, 33)
        Button5.TabIndex = 19
        Button5.Text = "PROFILE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Firebrick
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.Gainsboro
        Button6.Location = New Point(39, 322)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(186, 33)
        Button6.TabIndex = 20
        Button6.Text = "ATTENDANCE"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Firebrick
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Gainsboro
        Button7.Location = New Point(39, 379)
        Button7.Margin = New Padding(2)
        Button7.Name = "Button7"
        Button7.Size = New Size(186, 33)
        Button7.TabIndex = 21
        Button7.Text = "LEAVE REQUESTS"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Firebrick
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.Gainsboro
        Button8.Location = New Point(39, 438)
        Button8.Margin = New Padding(2)
        Button8.Name = "Button8"
        Button8.Size = New Size(186, 33)
        Button8.TabIndex = 22
        Button8.Text = "PAYROLL"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1096, 519)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Label8)
        Controls.Add(PictureBox5)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Margin = New Padding(2)
        Name = "Attendance"
        Text = "Attendance"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button

End Class
