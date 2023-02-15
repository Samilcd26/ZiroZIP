Imports System.IO
Imports System.IO.Compression
Public Class KlasorZipForm

    Private Sub VazgecBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VazgecBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub KlasorSecBtn_Click(sender As Object, e As EventArgs) Handles KlasorSecBtn.Click
        KlasorTBox.Clear()
        DosyaTBox.Clear()
        If KlasorSecDiyalog.ShowDialog = DialogResult.OK Then
            Dim Klasor As New DirectoryInfo(KlasorSecDiyalog.SelectedPath)
            If Klasor.FullName = Klasor.Root.FullName Then
                MessageBox.Show(Klasor.Name & " bir sürücü bu uygulama ile sürücü sıkıştırması yapılamaz.", "Hata")
                Exit Sub
            End If
            If Klasor.Exists Then
                KlasorTBox.Text = Klasor.FullName
                DosyaTBox.Text = KaydedilecekDosya(Klasor.FullName)
            End If
        End If
    End Sub
    Private Function KaydedilecekDosya(KlasorYolu As String) As String
        Dim Dosya As String = Nothing
        Dim Klasor As New DirectoryInfo(KlasorYolu)
        If Klasor.Exists Then
            Dim UstKlasor As String = Klasor.Parent.FullName
            If Not Path.EndsInDirectorySeparator(UstKlasor) Then
                UstKlasor &= Path.DirectorySeparatorChar
            End If
            Dim DosyaAdi As String = Klasor.Name
            Dim Sayac As Integer = 0
            Do
                If Sayac = 0 Then
                    Dosya = String.Format("{0}{1}.{2}", UstKlasor, DosyaAdi, "zip")
                Else
                    Dosya = String.Format("{0}{1}({3}).{2}", UstKlasor, DosyaAdi, "zip", Sayac)
                End If
                Sayac += 1
            Loop While My.Computer.FileSystem.FileExists(Dosya)
        End If
        Return Dosya
    End Function

    Private Sub DosyaSecBtn_Click(sender As Object, e As EventArgs) Handles DosyaSecBtn.Click
        If KlasorTBox.TextLength = 0 Then
            MessageBox.Show("Öncelikle sıkıştırma yapılacak klasörü seçmelisiniz.", "Hata")
            KlasorSecBtn.Select()
            Exit Sub
        End If
        DosyaKaydetDiyalog.InitialDirectory = Path.GetDirectoryName(DosyaTBox.Text)
        If DosyaKaydetDiyalog.ShowDialog = DialogResult.OK Then
            Dim Dosya As String = DosyaKaydetDiyalog.FileName
            If Dosya.StartsWith(KlasorTBox.Text) Then
                MessageBox.Show("Dosyanız sıkıştırma yapılacak klasörün içine kaydedilemez.", "Hata")
                Exit Sub
            End If
            DosyaTBox.Text = Dosya
        End If
    End Sub

    Private Sub ZipBtn_Click(sender As Object, e As EventArgs) Handles ZipBtn.Click
        If KlasorTBox.TextLength = 0 Then
            MessageBox.Show("Öncelikle sıkıştırma yapılacak klasörü seçmelisiniz.", "Hata")
            KlasorSecBtn.Select()
            Exit Sub
        End If
        Dim Klasor As New DirectoryInfo(KlasorTBox.Text)
        If Klasor.Exists Then
            Dim Dosya As New FileInfo(DosyaTBox.Text)
            Try
                ZipFile.CreateFromDirectory(Klasor.FullName, Dosya.FullName, CompressionLevel.Optimal, DahilRBtn.Checked)

                MessageBox.Show("Sıkıştırma işlemi başarıyla gerçekleşti.", "İşlem Başarılı")
                Process.Start("explorer.exe", Dosya.Directory.FullName)
            Catch ex As Exception
                MessageBox.Show("Dosya Sıkıştırılamadı Hata: " & ex.Message, "Hata")
            End Try
            KlasorTBox.Clear()
            DosyaTBox.Clear()
        End If
    End Sub
End Class
