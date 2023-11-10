Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Call this method to enable the Paint event for the panel
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)

        ' Set the region for the panel to create curved edges
        SetCurvedPanelEdges(innerPanel, 20)
        SetCurvedButtonEdges(btnLogin, 20)

        AddHandler Panel2.Paint, AddressOf GradientPanel_Paint
        AddHandler Label2.Paint, AddressOf Label2_Paint
        AddHandler btnLogin.Paint, AddressOf btnLogin_Paint

    End Sub
    Private Sub SetCurvedPanelEdges(panel As Panel, cornerRadius As Integer)
        ' Create a GraphicsPath object with rounded corners

        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90)
        path.AddLine(cornerRadius, 0, panel.Width - cornerRadius, 0)
        path.AddArc(New Rectangle(panel.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90)
        path.AddLine(panel.Width, cornerRadius, panel.Width, panel.Height - cornerRadius)
        path.AddArc(New Rectangle(panel.Width - cornerRadius * 2, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90)
        path.AddLine(panel.Width - cornerRadius, panel.Height, cornerRadius, panel.Height)
        path.AddArc(New Rectangle(0, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90)
        path.AddLine(0, panel.Height - cornerRadius, 0, cornerRadius)
        path.CloseFigure()

        ' Set the panel's region to the created GraphicsPath
        panel.Region = New Region(path)
    End Sub

    Private Sub txtBox1_TextChanged(sender As Object, e As PaintEventArgs)
        ControlPaint.DrawBorder(e.Graphics, txtBox1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid)
        txtBox1.BorderStyle = BorderStyle.Fixed3D ' or BorderStyle.Fixed3D, BorderStyle.None

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles innerPanel.Paint


        Dim xPosition As Integer = (outerPanel.Width - innerPanel.Width) \ 3
        Dim yPosition As Integer = (outerPanel.Height - innerPanel.Height) \ 2.5

        ' Set the location of the inner panel
        innerPanel.Location = New Point(xPosition, yPosition)
    End Sub

    Private Sub SetCurvedButtonEdges(button As Button, cornerRadius As Integer)
        ' Create a GraphicsPath object with rounded corners
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90)
        path.AddLine(cornerRadius, 0, button.Width - cornerRadius, 0)
        path.AddArc(New Rectangle(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90)
        path.AddLine(button.Width, cornerRadius, button.Width, button.Height - cornerRadius)
        path.AddArc(New Rectangle(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90)
        path.AddLine(button.Width - cornerRadius, button.Height, cornerRadius, button.Height)
        path.AddArc(New Rectangle(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90)
        path.AddLine(0, button.Height - cornerRadius, 0, cornerRadius)
        path.CloseFigure()

        ' Set the button's region to the created GraphicsPath
        button.Region = New Region(path)

    End Sub

    Private Sub GradientPanel_Paint(sender As Object, e As PaintEventArgs)
        ' Draw a gradient background in the Paint event
        Dim panel = DirectCast(sender, Panel)
        Dim gradientBrush As New LinearGradientBrush(panel.ClientRectangle, Color.Beige, Color.Brown, LinearGradientMode.Vertical)

        ' You can customize the LinearGradientMode and colors according to your preference

        e.Graphics.FillRectangle(gradientBrush, panel.ClientRectangle)
    End Sub

    Private Sub Label2_Paint(sender As Object, e As PaintEventArgs)

        Dim gradientBrush As New LinearGradientBrush(Label2.ClientRectangle, Color.Teal, Color.Gray, LinearGradientMode.Vertical)

        ' Draw the gradient text
        Dim textFormat As New StringFormat()
        textFormat.Alignment = StringAlignment.Center
        textFormat.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Label2.Text, Label2.Font, gradientBrush, Label2.ClientRectangle, textFormat)

    End Sub
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs)
        Dim button = DirectCast(sender, Button)

        ' Create a LinearGradientBrush for the button's background
        Dim gradientBrush As New LinearGradientBrush(button.ClientRectangle, Color.Beige, Color.Brown, LinearGradientMode.Vertical)

        ' Draw the gradient background
        e.Graphics.FillRectangle(gradientBrush, button.ClientRectangle)

        ' Draw the button's text
        Dim textBrush As New SolidBrush(button.ForeColor)
        Dim textFormat As New StringFormat()
        textFormat.Alignment = StringAlignment.Center
        textFormat.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(button.Text, button.Font, textBrush, button.ClientRectangle, textFormat)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
    End Sub
End Class
