Public Class Frm1Sbar
	Private Sub Frm1Sbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
		Dim abtpg1 As Abtpg
		abtpg1 = New Abtpg()
		abtpg1.Show()
	End Sub
End Class