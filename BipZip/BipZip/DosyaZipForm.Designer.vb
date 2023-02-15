<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DosyaZipForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DosyaZipForm))
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.ZipBtn = New System.Windows.Forms.Button()
        Me.DosyaSecBtn = New System.Windows.Forms.Button()
        Me.DosyaTBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CokluDosyaSecBtn = New System.Windows.Forms.Button()
        Me.DosyaKaydetDiyalog = New System.Windows.Forms.SaveFileDialog()
        Me.DosyaAcDiyalog = New System.Windows.Forms.OpenFileDialog()
        Me.DosyalarLView = New System.Windows.Forms.ListView()
        Me.LResimlerList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'VazgecBtn
        '
        Me.VazgecBtn.Image = CType(resources.GetObject("VazgecBtn.Image"), System.Drawing.Image)
        Me.VazgecBtn.Location = New System.Drawing.Point(262, 282)
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(139, 69)
        Me.VazgecBtn.TabIndex = 19
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.VazgecBtn.UseVisualStyleBackColor = True
        '
        'ZipBtn
        '
        Me.ZipBtn.Image = CType(resources.GetObject("ZipBtn.Image"), System.Drawing.Image)
        Me.ZipBtn.Location = New System.Drawing.Point(14, 282)
        Me.ZipBtn.Name = "ZipBtn"
        Me.ZipBtn.Size = New System.Drawing.Size(139, 69)
        Me.ZipBtn.TabIndex = 18
        Me.ZipBtn.Text = "Sıkıştır"
        Me.ZipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ZipBtn.UseVisualStyleBackColor = True
        '
        'DosyaSecBtn
        '
        Me.DosyaSecBtn.Location = New System.Drawing.Point(366, 207)
        Me.DosyaSecBtn.Name = "DosyaSecBtn"
        Me.DosyaSecBtn.Size = New System.Drawing.Size(35, 68)
        Me.DosyaSecBtn.TabIndex = 15
        Me.DosyaSecBtn.Text = "..."
        Me.DosyaSecBtn.UseVisualStyleBackColor = True
        '
        'DosyaTBox
        '
        Me.DosyaTBox.Location = New System.Drawing.Point(14, 208)
        Me.DosyaTBox.Multiline = True
        Me.DosyaTBox.Name = "DosyaTBox"
        Me.DosyaTBox.ReadOnly = True
        Me.DosyaTBox.Size = New System.Drawing.Size(348, 67)
        Me.DosyaTBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Kaydedilecek Dosya"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sıkıştırılacak Dosyalar"
        '
        'CokluDosyaSecBtn
        '
        Me.CokluDosyaSecBtn.Image = CType(resources.GetObject("CokluDosyaSecBtn.Image"), System.Drawing.Image)
        Me.CokluDosyaSecBtn.Location = New System.Drawing.Point(12, 12)
        Me.CokluDosyaSecBtn.Name = "CokluDosyaSecBtn"
        Me.CokluDosyaSecBtn.Size = New System.Drawing.Size(389, 55)
        Me.CokluDosyaSecBtn.TabIndex = 10
        Me.CokluDosyaSecBtn.Text = "Sıkıştırılacak Dosyaları Seçiniz"
        Me.CokluDosyaSecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CokluDosyaSecBtn.UseVisualStyleBackColor = True
        '
        'DosyaKaydetDiyalog
        '
        Me.DosyaKaydetDiyalog.Filter = "Zip Arşiv Dosyası|*.zip"
        '
        'DosyaAcDiyalog
        '
        Me.DosyaAcDiyalog.Filter = "Tüm Dosyalar|*.*"
        Me.DosyaAcDiyalog.Multiselect = True
        '
        'DosyalarLView
        '
        Me.DosyalarLView.HideSelection = False
        Me.DosyalarLView.LargeImageList = Me.LResimlerList
        Me.DosyalarLView.Location = New System.Drawing.Point(17, 88)
        Me.DosyalarLView.Name = "DosyalarLView"
        Me.DosyalarLView.ShowItemToolTips = True
        Me.DosyalarLView.Size = New System.Drawing.Size(384, 97)
        Me.DosyalarLView.TabIndex = 20
        Me.DosyalarLView.UseCompatibleStateImageBehavior = False
        '
        'LResimlerList
        '
        Me.LResimlerList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.LResimlerList.ImageStream = CType(resources.GetObject("LResimlerList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LResimlerList.TransparentColor = System.Drawing.Color.Transparent
        Me.LResimlerList.Images.SetKeyName(0, "bosdosya.png")
        '
        'DosyaZipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 363)
        Me.Controls.Add(Me.DosyalarLView)
        Me.Controls.Add(Me.VazgecBtn)
        Me.Controls.Add(Me.ZipBtn)
        Me.Controls.Add(Me.DosyaSecBtn)
        Me.Controls.Add(Me.DosyaTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CokluDosyaSecBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DosyaZipForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DosyaZipForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VazgecBtn As Button
    Friend WithEvents ZipBtn As Button
    Friend WithEvents DosyaSecBtn As Button
    Friend WithEvents DosyaTBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CokluDosyaSecBtn As Button
    Friend WithEvents DosyaKaydetDiyalog As SaveFileDialog
    Friend WithEvents DosyaAcDiyalog As OpenFileDialog
    Friend WithEvents DosyalarLView As ListView
    Friend WithEvents LResimlerList As ImageList
End Class
