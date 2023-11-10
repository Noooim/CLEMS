Imports System.Drawing.Drawing2D

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized


        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)


        AddHandler btnSubmit.Paint, AddressOf btnSubmit_Paint
    End Sub


    Private Sub innPanel_Paint(sender As Object, e As PaintEventArgs) Handles innPanel.Paint


        Dim xPosition As Integer = (outPanel.Width - innPanel.Width) \ 2
        Dim yPosition As Integer = (outPanel.Height - innPanel.Height) \ 2

        ' Set the location of the inner panel
        innPanel.Location = New Point(xPosition, yPosition)

    End Sub


    Private Sub btnSubmit_Paint(sender As Object, e As PaintEventArgs)
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Me.Hide()
        Form1.Show()

    End Sub
End Class