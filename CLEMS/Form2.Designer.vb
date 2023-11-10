<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        outPanel = New Panel()
        innPanel = New Panel()
        Label2 = New Label()
        btnSubmit = New Button()
        rbFemale = New RadioButton()
        rbMale = New RadioButton()
        TextBox3 = New TextBox()
        txtPassword = New TextBox()
        TxtUsername = New TextBox()
        txtName = New TextBox()
        Label1 = New Label()
        outPanel.SuspendLayout()
        innPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' outPanel
        ' 
        outPanel.BackgroundImage = My.Resources.Resources.bg_2
        outPanel.BackgroundImageLayout = ImageLayout.Stretch
        outPanel.Controls.Add(innPanel)
        outPanel.Dock = DockStyle.Fill
        outPanel.Location = New Point(0, 0)
        outPanel.Name = "outPanel"
        outPanel.Size = New Size(800, 772)
        outPanel.TabIndex = 0
        ' 
        ' innPanel
        ' 
        innPanel.Controls.Add(Label2)
        innPanel.Controls.Add(btnSubmit)
        innPanel.Controls.Add(rbFemale)
        innPanel.Controls.Add(rbMale)
        innPanel.Controls.Add(TextBox3)
        innPanel.Controls.Add(txtPassword)
        innPanel.Controls.Add(TxtUsername)
        innPanel.Controls.Add(txtName)
        innPanel.Controls.Add(Label1)
        innPanel.Font = New Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        innPanel.Location = New Point(187, 27)
        innPanel.Name = "innPanel"
        innPanel.Size = New Size(493, 701)
        innPanel.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(128, 626)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 25)
        Label2.TabIndex = 9
        Label2.Text = "Already Have Account?"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.Location = New Point(122, 549)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(230, 55)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.Font = New Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbFemale.Location = New Point(262, 484)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(116, 50)
        rbFemale.TabIndex = 7
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.Location = New Point(113, 484)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(106, 43)
        rbMale.TabIndex = 6
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(75, 405)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Phone Number"
        TextBox3.Size = New Size(354, 50)
        TextBox3.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(75, 321)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(354, 50)
        txtPassword.TabIndex = 3
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(75, 237)
        TxtUsername.Multiline = True
        TxtUsername.Name = "TxtUsername"
        TxtUsername.PlaceholderText = "Username"
        TxtUsername.Size = New Size(354, 50)
        TxtUsername.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Palatino Linotype", 24F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(75, 149)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(354, 50)
        txtName.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(104, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 47)
        Label1.TabIndex = 0
        Label1.Text = "Create Account"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 772)
        Controls.Add(outPanel)
        Name = "Form2"
        Text = "Form2"
        outPanel.ResumeLayout(False)
        innPanel.ResumeLayout(False)
        innPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents outPanel As Panel
    Friend WithEvents innPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
End Class
