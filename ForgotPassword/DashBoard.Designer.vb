<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Button2 = New Button()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        Button3 = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Firebrick
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(261, 522)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Firebrick
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(62, 0)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(136, 123)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(67, 141)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 19)
        Label1.TabIndex = 3
        Label1.Text = "Employee Name"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(39, 208)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(186, 33)
        Button1.TabIndex = 4
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
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
        Button5.TabIndex = 12
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
        Button6.TabIndex = 13
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
        Button7.TabIndex = 14
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
        Button8.TabIndex = 15
        Button8.Text = "PAYROLL"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Silver
        PictureBox3.Location = New Point(260, -1)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(838, 62)
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(457, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(420, 35)
        Label2.TabIndex = 17
        Label2.Text = "ATTENDANCE MONITORING"
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(953, 15)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 18
        Button2.Text = "Log out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Silver
        PictureBox4.Location = New Point(309, 86)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(738, 48)
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Silver
        PictureBox5.Location = New Point(309, 139)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(738, 79)
        PictureBox5.TabIndex = 20
        PictureBox5.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.Silver
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(309, 246)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(738, 243)
        DataGridView1.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(327, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 23)
        Label3.TabIndex = 22
        Label3.Text = "TIME"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Lime
        Button3.Location = New Point(479, 153)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 54)
        Button3.TabIndex = 23
        Button3.Text = "TIME IN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 54.74452F
        Column1.HeaderText = "TIME"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.FillWeight = 102.931061F
        Column2.HeaderText = "STATUS"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 142.324417F
        Column3.HeaderText = "DATE"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Arial", 12F)
        Label4.Location = New Point(675, 100)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 23)
        Label4.TabIndex = 24
        Label4.Text = "DATE"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Silver
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.OrangeRed
        Button4.Location = New Point(675, 153)
        Button4.Name = "Button4"
        Button4.Size = New Size(202, 54)
        Button4.TabIndex = 25
        Button4.Text = "TIME OUT"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DashBoard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1096, 519)
        Controls.Add(Button4)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(PictureBox3)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "DashBoard"
        Text = "Dash Board"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button

End Class
