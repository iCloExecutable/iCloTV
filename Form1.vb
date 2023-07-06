

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Timer1.Start()

	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Label1.Text = Date.Now.ToString("HH:mm")

	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Dim Youtube As YuoTuba
		Youtube = New YuoTuba()
		Youtube.Show()
	End Sub

	Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
		Dim Netflix As Netflix
		Netflix = New Netflix()
		Netflix.Show()
	End Sub

	Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
		Dim Assistant As iCloAssistant
		Assistant = New iCloAssistant()
		Assistant.Show()
	End Sub

	Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
		Dim Sidebar As Frm1Sbar
		Sidebar = New Frm1Sbar()
		Sidebar.Show()
	End Sub

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
		Dim DisneyApp As disneyUI
		DisneyApp = New disneyUI
		DisneyApp.Show()
	End Sub
End Class
