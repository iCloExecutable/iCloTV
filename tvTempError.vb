Public Class tvTempError
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim tvnormal As Form1
		tvnormal = New Form1()
		tvnormal.Show()
		Me.Hide()
	End Sub
End Class