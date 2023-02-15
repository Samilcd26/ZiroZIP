Public Class Form1
    Private Sub KlasorZipBtn_Click(sender As Object, e As EventArgs) Handles KlasorZipBtn.Click
        KlasorZipForm.ShowDialog(Me)
    End Sub

    Private Sub AyiklaZipBtn_Click(sender As Object, e As EventArgs) Handles AyiklaZipBtn.Click
        AyiklaZipForm.ShowDialog(Me)
    End Sub

    Private Sub DosyaZipBtn_Click(sender As Object, e As EventArgs) Handles DosyaZipBtn.Click
        DosyaZipForm.ShowDialog(Me)
    End Sub
End Class
