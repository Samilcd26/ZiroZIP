Imports System.IO
Imports System.IO.Compression

Public Class DosyaZipForm
    Private Sub VazgecBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VazgecBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CokluDosyaSecBtn_Click(sender As Object, e As EventArgs) Handles CokluDosyaSecBtn.Click
        DosyalarLView.Items.Clear()
        DosyaTBox.Clear()
        If DosyaAcDiyalog.ShowDialog = DialogResult.OK Then
            Dim Dosyalar() As String = DosyaAcDiyalog.FileNames
            For Each DosyaAdi As String In Dosyalar
                Dim Dosya As New FileInfo(DosyaAdi)
                If Dosya.Exists Then
                    Dim Eleman As New ListViewItem
                    Eleman.Text = Dosya.Name
                    Eleman.ToolTipText = Dosya.FullName
                    Eleman.Tag = Dosya
                    Eleman.ImageIndex = 0
                    DosyalarLView.Items.Add(Eleman)
                End If
            Next
            If DosyalarLView.Items.Count > 0 Then
                Dim Dosya As FileInfo = DosyalarLView.Items(0).Tag
                DosyaTBox.Text = KaydedilecekDosya(Dosya.Directory.FullName)
            End If
        End If
    End Sub
    Private Function KaydedilecekDosya(KlasorYolu As String) As String
        Dim Dosya As String = Nothing
        Dim Klasor As New DirectoryInfo(KlasorYolu)
        If Klasor.Exists Then
            Dim UstKlasor As String
            If Klasor.FullName = Klasor.Root.FullName Then
                UstKlasor = Klasor.Name
            Else
                UstKlasor = Klasor.Parent.FullName
            End If

            If Not Path.EndsInDirectorySeparator(UstKlasor) Then
                UstKlasor &= Path.DirectorySeparatorChar
            End If
            Dim DosyaAdi As String = Klasor.Name.Replace(":\", "")
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
        If DosyalarLView.Items.Count = 0 Then
            MessageBox.Show("Öncelikle sıkıştırma yapılacak dosyaları seçmelisiniz.", "Hata")
            CokluDosyaSecBtn.Select()
            Exit Sub
        End If
        DosyaKaydetDiyalog.InitialDirectory = Path.GetDirectoryName(DosyaTBox.Text)
        If DosyaKaydetDiyalog.ShowDialog = DialogResult.OK Then
            Dim Dosya As String = DosyaKaydetDiyalog.FileName
            DosyaTBox.Text = Dosya
        End If
    End Sub

    Private Sub ZipBtn_Click(sender As Object, e As EventArgs) Handles ZipBtn.Click
        If DosyalarLView.Items.Count = 0 Then
            MessageBox.Show("Öncelikle sıkıştırma yapılacak dosyaları seçmelisiniz.", "Hata")
            CokluDosyaSecBtn.Select()
            Exit Sub
        End If
        Dim ZipDosya As New FileInfo(DosyaTBox.Text)
        Dim ZipArsiv As ZipArchive

        Try
            If ZipDosya.Exists Then
                ZipDosya.Delete()
            End If
            ZipArsiv = ZipFile.Open(ZipDosya.FullName, ZipArchiveMode.Create)
            For Each Eleman As ListViewItem In DosyalarLView.Items
                Dim Dosya As FileInfo = Eleman.Tag
                If Dosya.Exists Then
                    ZipArsiv.CreateEntryFromFile(Dosya.FullName, Dosya.Name, CompressionLevel.Optimal)
                End If
            Next
            MessageBox.Show("Sıkıştırma işlemi başarıyla gerçekleşti.", "İşlem Başarılı")
            Process.Start("explorer.exe", ZipDosya.Directory.FullName)
        Catch ex As Exception
            MessageBox.Show("Dosya Sıkıştırılamadı Hata: " & ex.Message, "Hata")
        Finally
            ZipArsiv.Dispose()
        End Try
        DosyalarLView.Items.Clear()
        DosyaTBox.Clear()

    End Sub
End Class
