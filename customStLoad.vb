Public Class customStLoad
	Private Sub customStLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If My.Resources.tvTemp = "85" Then
			Dim tvtempload As tvTempError
			tvtempload = New tvTempError()
			tvtempload.Show()
		Else
			Dim tvload As Form1
			tvload = New Form1()
			tvload.Show()




		End If


	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If My.Resources.tvTemp = "85" Then
			Dim tvtempload As tvTempError
			tvtempload = New tvTempError()
			tvtempload.Show()
		Else
			Dim tvload As Form1
			tvload = New Form1()
			tvload.Show()




		End If


	End Sub
End Class