<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl4
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
        Panel1 = New Panel()
        Button2 = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        contentPanel = New Panel()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        contentPanel.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1305, 71)
        Panel1.TabIndex = 27
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.WhiteSmoke
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1105, 15)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 43)
        Button2.TabIndex = 19
        Button2.Text = "LOG OUT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(590, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(420, 35)
        Label2.TabIndex = 17
        Label2.Text = "ATTENDANCE MONITORING"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(0, 95)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1305, 71)
        Panel2.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(553, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 23)
        Label3.TabIndex = 22
        Label3.Text = "TIME"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 12F)
        Label4.Location = New Point(931, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 23)
        Label4.TabIndex = 24
        Label4.Text = "DATE"
        ' 
        ' contentPanel
        ' 
        contentPanel.Controls.Add(Panel1)
        contentPanel.Controls.Add(Button4)
        contentPanel.Controls.Add(DataGridView1)
        contentPanel.Controls.Add(Button3)
        contentPanel.Controls.Add(Panel2)
        contentPanel.Dock = DockStyle.Fill
        contentPanel.Location = New Point(0, 0)
        contentPanel.Margin = New Padding(3, 4, 3, 4)
        contentPanel.Name = "contentPanel"
        contentPanel.Size = New Size(1305, 729)
        contentPanel.TabIndex = 36
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.Silver
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.OrangeRed
        Button4.Location = New Point(859, 197)
        Button4.Name = "Button4"
        Button4.Size = New Size(410, 53)
        Button4.TabIndex = 25
        Button4.Text = "TIME OUT"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(265, 404)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1025, 308)
        DataGridView1.TabIndex = 26
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Lime
        Button3.Location = New Point(325, 197)
        Button3.Name = "Button3"
        Button3.Size = New Size(362, 53)
        Button3.TabIndex = 23
        Button3.Text = "TIME IN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' UserControl4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(contentPanel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UserControl4"
        Size = New Size(1305, 729)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        contentPanel.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents contentPanel As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button

End Class
