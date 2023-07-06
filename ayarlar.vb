Public Class ayarlar

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim pchakkında As pcabout
        pchakkında = New pcabout()
        pchakkında.Show()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub İCloBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AyarlarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim pchakkında As pcabout
        pchakkında = New pcabout()
        pchakkında.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PCHakkındaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCHakkındaToolStripMenuItem.Click

        Dim pchakkında As pcabout
        pchakkında = New pcabout()
        pchakkında.Show()
    End Sub

    Private Sub GüncelleVeyaSıfırlaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GüncelleVeyaSıfırlaToolStripMenuItem.Click

    End Sub

    Private Sub ReturnToTVModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToTVModeToolStripMenuItem.Click
        Dim tvmodehome As Form1
        tvmodehome = New Form1
        tvmodehome.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim tvmodehome As Form1
        tvmodehome = New Form1
        tvmodehome.Show()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Dim tvmodehome As Form1
        tvmodehome = New Form1
        tvmodehome.Show()
    End Sub
End Class