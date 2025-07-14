<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gainsboro
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1099, 58)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(0, 0)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(81, 58)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gainsboro
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(96, 12)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 36)
        Button2.TabIndex = 16
        Button2.Text = "ABOUT US"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gainsboro
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(237, 12)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 36)
        Button3.TabIndex = 17
        Button3.Text = "CONTACT US"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.ForestGreen
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonFace
        Button4.Location = New Point(846, 18)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 27)
        Button4.TabIndex = 18
        Button4.Text = "LOG IN"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.OrangeRed
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonFace
        Button5.Location = New Point(949, 18)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(107, 27)
        Button5.TabIndex = 19
        Button5.Text = "REGISTER"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Gold
        LinkLabel1.Location = New Point(392, 465)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(114, 19)
        LinkLabel1.TabIndex = 20
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Privacy Policy"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.Gold
        LinkLabel2.Location = New Point(559, 465)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(139, 19)
        LinkLabel2.TabIndex = 21
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Terms of Services"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(401, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(268, 55)
        Label1.TabIndex = 22
        Label1.Text = "WELCOME"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 12F)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(248, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(589, 141)
        Label2.TabIndex = 23
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' HomePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(183), CByte(28), CByte(28))
        ClientSize = New Size(1096, 519)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Name = "HomePage"
        Text = "Home Page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
