Imports System.IO
Imports System.IO.Compression

Public Class AyiklaZipForm

    Private Sub VazgecBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VazgecBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DosyaSecBtn_Click(sender As Object, e As EventArgs) Handles DosyaSecBtn.Click
        DosyaTBox.Clear()
        KlasorTBox.Clear()
        If DosyaAcDiyalog.ShowDialog = DialogResult.OK Then
            Dim Dosya As New FileInfo(DosyaAcDiyalog.FileName)
            If Dosya.Exists Then
                DosyaTBox.Text = Dosya.FullName
                KlasorTBox.Text = KaydedilecekKlasor(Dosya.FullName)
            End If
        End If
    End Sub
    Private Function KaydedilecekKlasor(DosyaTamAdi As String) As String
        Dim Klasor As String = Nothing
        Dim Dosya As New FileInfo(DosyaTamAdi)
        Dim UstKlasor As String = Dosya.Directory.FullName
        If Not Path.EndsInDirectorySeparator(UstKlasor) Then
            UstKlasor &= Path.DirectorySeparatorChar
        End If
        Dim KlasorAdi As String = Path.GetFileNameWithoutExtension(Dosya.FullName)
        Dim Sayac As Integer = 0
        Do
            If Sayac = 0 Then
                Klasor = String.Format("{0}{1}", UstKlasor, KlasorAdi)
            Else
                Klasor = String.Format("{0}{1}_{2}", UstKlasor, KlasorAdi, Sayac)
            End If
            Sayac += 1
        Loop While My.Computer.FileSystem.DirectoryExists(Klasor)
        Return Klasor
    End Function
    Private Sub AyiklaZipForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DosyaAcDiyalog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
    End Sub

    Private Sub KlasorSecBtn_Click(sender As Object, e As EventArgs) Handles KlasorSecBtn.Click
        If DosyaTBox.TextLength = 0 Then
            MessageBox.Show("Öncelikle ayıklamak istediğiniz sıkıştırılmış dosyayı seçiniz.", "Hata")
            DosyaSecBtn.Select()
            Exit Sub
        End If
        KlasorSecDiyalog.ShowNewFolderButton = True
        KlasorSecDiyalog.SelectedPath = Path.GetDirectoryName(KlasorTBox.Text)
        If KlasorSecDiyalog.ShowDialog = DialogResult.OK Then
            KlasorTBox.Text = KlasorSecDiyalog.SelectedPath
        End If
    End Sub

    Private Sub ZipBtn_Click(sender As Object, e As EventArgs) Handles ZipBtn.Click
        If DosyaTBox.TextLength = 0 Then
            MessageBox.Show("Öncelikle ayıklamak istediğiniz sıkıştırılmış dosyayı seçiniz.", "Hata")
            DosyaSecBtn.Select()
            Exit Sub
        End If
        Dim Dosya As New FileInfo(DosyaTBox.Text)
        Dim Klasor As New DirectoryInfo(KlasorTBox.Text)
        If Dosya.Exists Then
            Try
                ZipFile.ExtractToDirectory(Dosya.FullName, Klasor.FullName, True)
                MessageBox.Show("Ayıklama işlemi başarı ile gerçekleşmiştir.", "İşlem Başarılı")
                Process.Start("explorer.exe", Klasor.FullName)
            Catch ex As Exception
                MessageBox.Show("Dosya Ayıklanamadı Hata: " & ex.Message, "Hata")
                DosyaSecBtn.Select()
            End Try
            DosyaTBox.Clear()
            KlasorTBox.Clear()
        End If
    End Sub
End Class
