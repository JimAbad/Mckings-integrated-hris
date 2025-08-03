<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl7))
        Button7 = New Button()
        TextBoxJobTitle = New TextBox()
        Label13 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button8 = New Button()
        GroupBox1 = New GroupBox()
        TextBoxAddress = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxLastName = New TextBox()
        TextBoxFirstName = New TextBox()
        Address = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Firebrick
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Gainsboro
        Button7.Location = New Point(34, 284)
        Button7.Margin = New Padding(2)
        Button7.Name = "Button7"
        Button7.Size = New Size(163, 25)
        Button7.TabIndex = 27
        Button7.Text = "LEAVE REQUESTS"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' TextBoxJobTitle
        ' 
        TextBoxJobTitle.Location = New Point(80, 200)
        TextBoxJobTitle.Margin = New Padding(2)
        TextBoxJobTitle.Name = "TextBoxJobTitle"
        TextBoxJobTitle.ReadOnly = True
        TextBoxJobTitle.Size = New Size(205, 20)
        TextBoxJobTitle.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 7.0F)
        Label13.Location = New Point(10, 205)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(52, 13)
        Label13.TabIndex = 0
        Label13.Text = "Job Title:"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Firebrick
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.Gainsboro
        Button6.Location = New Point(34, 242)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(163, 25)
        Button6.TabIndex = 26
        Button6.Text = "ATTENDANCE"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Firebrick
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Gainsboro
        Button5.Location = New Point(34, 199)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(163, 25)
        Button5.TabIndex = 25
        Button5.Text = "PROFILE"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Firebrick
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.Gainsboro
        Button8.Location = New Point(34, 328)
        Button8.Margin = New Padding(2)
        Button8.Name = "Button8"
        Button8.Size = New Size(163, 25)
        Button8.TabIndex = 28
        Button8.Text = "PAYROLL"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkGray
        GroupBox1.Controls.Add(TextBoxAddress)
        GroupBox1.Controls.Add(TextBoxEmail)
        GroupBox1.Controls.Add(TextBoxLastName)
        GroupBox1.Controls.Add(TextBoxJobTitle)
        GroupBox1.Controls.Add(TextBoxFirstName)
        GroupBox1.Controls.Add(Address)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Arial", 8.0F, FontStyle.Underline)
        GroupBox1.Location = New Point(293, 76)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(561, 264)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' TextBoxAddress
        ' 
        TextBoxAddress.Location = New Point(80, 171)
        TextBoxAddress.Margin = New Padding(2)
        TextBoxAddress.Name = "TextBoxAddress"
        TextBoxAddress.ReadOnly = True
        TextBoxAddress.Size = New Size(389, 20)
        TextBoxAddress.TabIndex = 7
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(80, 142)
        TextBoxEmail.Margin = New Padding(2)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.ReadOnly = True
        TextBoxEmail.Size = New Size(205, 20)
        TextBoxEmail.TabIndex = 6
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.Location = New Point(80, 109)
        TextBoxLastName.Margin = New Padding(2)
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.ReadOnly = True
        TextBoxLastName.Size = New Size(205, 20)
        TextBoxLastName.TabIndex = 5
        ' 
        ' TextBoxFirstName
        ' 
        TextBoxFirstName.Location = New Point(80, 80)
        TextBoxFirstName.Margin = New Padding(2)
        TextBoxFirstName.Name = "TextBoxFirstName"
        TextBoxFirstName.ReadOnly = True
        TextBoxFirstName.Size = New Size(205, 20)
        TextBoxFirstName.TabIndex = 4
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.Font = New Font("Arial", 7F)
        Address.Location = New Point(10, 176)
        Address.Margin = New Padding(2, 0, 2, 0)
        Address.Name = "Address"
        Address.Size = New Size(49, 13)
        Address.TabIndex = 3
        Address.Text = "Address :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 7F)
        Label4.Location = New Point(10, 147)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 13)
        Label4.TabIndex = 2
        Label4.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 7F)
        Label3.Location = New Point(10, 114)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 13)
        Label3.TabIndex = 1
        Label3.Text = "Last Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 7F)
        Label2.Location = New Point(10, 85)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 13)
        Label2.TabIndex = 0
        Label2.Text = "First Name:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(34, 156)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 25)
        Button1.TabIndex = 18
        Button1.Text = "DASHBOARD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(59, 106)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 16)
        Label1.TabIndex = 17
        Label1.Text = "Employee Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Firebrick
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(54, 0)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(119, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Firebrick
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 392)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' UserControl7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button8)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "UserControl7"
        Size = New Size(930, 393)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBoxJobTitle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
