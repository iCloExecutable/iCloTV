Public Class connectphpccar
	Private Sub connectphpccar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If My.Resources.phoneConnection = 1 Then
			Label1.Text = "Connected"
		Else
			Label1.Text = "Not connected"
		End If
	End Sub
End Class