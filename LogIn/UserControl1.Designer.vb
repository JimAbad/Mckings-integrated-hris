<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
        Label9 = New Label()
        TextBox1 = New TextBox()
        Label8 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        ComboBox2 = New ComboBox()
        Label1 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LimeGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(808, 488)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 22)
        Button2.TabIndex = 66
        Button2.Text = "Submit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(36, 380)
        RichTextBox1.Margin = New Padding(3, 2, 3, 2)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(854, 79)
        RichTextBox1.TabIndex = 65
        RichTextBox1.Text = ""
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Gainsboro
        Label9.Font = New Font("Arial", 9.0F)
        Label9.Location = New Point(36, 363)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 15)
        Label9.TabIndex = 64
        Label9.Text = "Reason"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(36, 327)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(854, 23)
        TextBox1.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Gainsboro
        Label8.Font = New Font("Arial", 9.0F)
        Label8.Location = New Point(36, 310)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 15)
        Label8.TabIndex = 62
        Label8.Text = "Short Description"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(582, 240)
        DateTimePicker2.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(280, 23)
        DateTimePicker2.TabIndex = 61
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Gainsboro
        Label7.Font = New Font("Arial", 9.0F)
        Label7.Location = New Point(582, 224)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 60
        Label7.Text = "Until"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(92, 240)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(280, 23)
        DateTimePicker1.TabIndex = 59
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Gainsboro
        Label6.Font = New Font("Arial", 9.0F)
        Label6.Location = New Point(92, 224)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 58
        Label6.Text = "From"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(386, 177)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(196, 23)
        ComboBox2.TabIndex = 57
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gainsboro
        Label1.Font = New Font("Arial", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(302, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 15)
        Label1.TabIndex = 56
        Label1.Text = "Leave Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Gainsboro
        Label4.Font = New Font("Arial", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(127, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 55
        Label4.Text = "Job Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Gainsboro
        Label3.Font = New Font("Arial", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SteelBlue
        Label3.Location = New Point(127, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 54
        Label3.Text = "Employee Name"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Gainsboro
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(36, 104)
        PictureBox5.Margin = New Padding(2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(71, 64)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 53
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gainsboro
        Label2.Font = New Font("Arial", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 52
        Label2.Text = "Leave Requests"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Gainsboro
        PictureBox4.Location = New Point(16, 81)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(892, 446)
        PictureBox4.TabIndex = 51
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Gainsboro
        PictureBox3.Location = New Point(16, 13)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(892, 52)
        PictureBox3.TabIndex = 50
        PictureBox3.TabStop = False
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label9)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(ComboBox2)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox5)
        Controls.Add(Label2)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Name = "UserControl1"
        Size = New Size(924, 548)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
