Public Class iclobrowserapp

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pchakkında As pcabout
        pchakkında = New pcabout()
        pchakkında.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoBack()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoForward()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub iclobrowserapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class