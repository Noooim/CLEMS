<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        outerPanel = New Panel()
        innerPanel = New Panel()
        Label1 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnLogin = New Button()
        TextBox1 = New TextBox()
        txtBox1 = New TextBox()
        Panel2 = New Panel()
        Button1 = New Button()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        outerPanel.SuspendLayout()
        innerPanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' outerPanel
        ' 
        outerPanel.AutoSize = True
        outerPanel.BackColor = Color.Transparent
        outerPanel.BackgroundImage = My.Resources.Resources.bg_2
        outerPanel.BackgroundImageLayout = ImageLayout.Stretch
        outerPanel.Controls.Add(innerPanel)
        outerPanel.Controls.Add(Panel2)
        outerPanel.Dock = DockStyle.Fill
        outerPanel.Location = New Point(0, 0)
        outerPanel.Name = "outerPanel"
        outerPanel.Size = New Size(1232, 643)
        outerPanel.TabIndex = 0
        ' 
        ' innerPanel
        ' 
        innerPanel.BackColor = Color.White
        innerPanel.BorderStyle = BorderStyle.Fixed3D
        innerPanel.Controls.Add(Label1)
        innerPanel.Controls.Add(Label4)
        innerPanel.Controls.Add(Label3)
        innerPanel.Controls.Add(btnLogin)
        innerPanel.Controls.Add(TextBox1)
        innerPanel.Controls.Add(txtBox1)
        innerPanel.Location = New Point(53, 53)
        innerPanel.Name = "innerPanel"
        innerPanel.Size = New Size(493, 701)
        innerPanel.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(139, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(195, 106)
        Label1.TabIndex = 7
        Label1.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(193, 632)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 6
        Label4.Text = "Register Here"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(172, 600)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 15)
        Label3.TabIndex = 5
        Label3.Text = "Forgot Your Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(190), CByte(140), CByte(129))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(126, 514)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(220, 62)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(66, 378)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PasswordChar = "*"c
        TextBox1.PlaceholderText = "Password"
        TextBox1.Size = New Size(354, 60)
        TextBox1.TabIndex = 3
        ' 
        ' txtBox1
        ' 
        txtBox1.Font = New Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point)
        txtBox1.Location = New Point(66, 234)
        txtBox1.Multiline = True
        txtBox1.Name = "txtBox1"
        txtBox1.PlaceholderText = "Username"
        txtBox1.Size = New Size(354, 60)
        txtBox1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(163), CByte(103), CByte(75))
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(687, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(545, 643)
        Panel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.closeoutline_110831
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(510, -2)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 38)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Lucida Fax", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(72, 445)
        Label5.Name = "Label5"
        Label5.Size = New Size(442, 30)
        Label5.TabIndex = 2
        Label5.Text = "Computer Laboratory Equipment Monitoring System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.CLEMS
        PictureBox1.Location = New Point(159, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(272, 226)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Verdana", 72F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(92, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(404, 116)
        Label2.TabIndex = 0
        Label2.Text = "CLEMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1232, 643)
        Controls.Add(outerPanel)
        Name = "Form1"
        Text = "Form1"
        outerPanel.ResumeLayout(False)
        innerPanel.ResumeLayout(False)
        innerPanel.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents outerPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents innerPanel As Panel
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
