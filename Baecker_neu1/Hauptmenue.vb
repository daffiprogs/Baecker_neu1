Public Class Hauptmenue
    'Public Teilnehmer As String = UserName.Name

    Private Sub Hauptmenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Bestellung_neu1.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ArtikelAuswahl.ShowDialog()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub UserName_TextChanged(sender As Object, e As EventArgs) Handles UserName.TextChanged

    End Sub
End Class
