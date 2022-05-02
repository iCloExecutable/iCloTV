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
			If My.Resources.customStLoadpage = "1" Then
				Dim tvloader As Form1
				tvloader = New Form1()
				tvloader.Show()



			End If
		End If
	End Sub
End Class