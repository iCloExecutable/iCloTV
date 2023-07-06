Public Class Frm1Sbar
    Private Sub Frm1Sbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim abtpg1 As Abtpg
        abtpg1 = New Abtpg()
        abtpg1.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim abtpg2 As Abtpg
        abtpg2 = New Abtpg()
        abtpg2.Show()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Dim upd2 As maxupdate
        upd2 = New maxupdate
        upd2.Show()

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim upd As maxupdate
        upd = New maxupdate
        upd.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim storage2 As storplus
        storage2 = New storplus
        storage2.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim storage As storplus
        storage = New storplus
        storage.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim coems As connectphpccar
        coems = New connectphpccar
        coems.Show()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Dim minamintip As connectphpccar
        minamintip = New connectphpccar
        minamintip.Show()
    End Sub
End Class