<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KlasorZipForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KlasorZipForm))
        Me.KlasorSecBtn = New System.Windows.Forms.Button()
        Me.KlasorTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DosyaTBox = New System.Windows.Forms.TextBox()
        Me.DosyaSecBtn = New System.Windows.Forms.Button()
        Me.DahilRBtn = New System.Windows.Forms.RadioButton()
        Me.HaricRBtn = New System.Windows.Forms.RadioButton()
        Me.ZipBtn = New System.Windows.Forms.Button()
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.KlasorSecDiyalog = New System.Windows.Forms.FolderBrowserDialog()
        Me.DosyaKaydetDiyalog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'KlasorSecBtn
        '
        Me.KlasorSecBtn.Image = CType(resources.GetObject("KlasorSecBtn.Image"), System.Drawing.Image)
        Me.KlasorSecBtn.Location = New System.Drawing.Point(13, 12)
        Me.KlasorSecBtn.Name = "KlasorSecBtn"
        Me.KlasorSecBtn.Size = New System.Drawing.Size(389, 55)
        Me.KlasorSecBtn.TabIndex = 0
        Me.KlasorSecBtn.Text = "Sıkıştırılacak Klasörü Seçiniz"
        Me.KlasorSecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KlasorSecBtn.UseVisualStyleBackColor = True
        '
        'KlasorTBox
        '
        Me.KlasorTBox.Location = New System.Drawing.Point(16, 98)
        Me.KlasorTBox.Name = "KlasorTBox"
        Me.KlasorTBox.ReadOnly = True
        Me.KlasorTBox.Size = New System.Drawing.Size(384, 23)
        Me.KlasorTBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sıkıştırılacak Klasör"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kaydedilecek Dosya"
        '
        'DosyaTBox
        '
        Me.DosyaTBox.Location = New System.Drawing.Point(13, 145)
        Me.DosyaTBox.Multiline = True
        Me.DosyaTBox.Name = "DosyaTBox"
        Me.DosyaTBox.ReadOnly = True
        Me.DosyaTBox.Size = New System.Drawing.Size(348, 67)
        Me.DosyaTBox.TabIndex = 4
        '
        'DosyaSecBtn
        '
        Me.DosyaSecBtn.Location = New System.Drawing.Point(367, 144)
        Me.DosyaSecBtn.Name = "DosyaSecBtn"
        Me.DosyaSecBtn.Size = New System.Drawing.Size(35, 68)
        Me.DosyaSecBtn.TabIndex = 5
        Me.DosyaSecBtn.Text = "..."
        Me.DosyaSecBtn.UseVisualStyleBackColor = True
        '
        'DahilRBtn
        '
        Me.DahilRBtn.AutoSize = True
        Me.DahilRBtn.Checked = True
        Me.DahilRBtn.Location = New System.Drawing.Point(165, 73)
        Me.DahilRBtn.Name = "DahilRBtn"
        Me.DahilRBtn.Size = New System.Drawing.Size(107, 19)
        Me.DahilRBtn.TabIndex = 6
        Me.DahilRBtn.TabStop = True
        Me.DahilRBtn.Text = "Klasörü Dahil Et"
        Me.DahilRBtn.UseVisualStyleBackColor = True
        '
        'HaricRBtn
        '
        Me.HaricRBtn.AutoSize = True
        Me.HaricRBtn.Location = New System.Drawing.Point(278, 73)
        Me.HaricRBtn.Name = "HaricRBtn"
        Me.HaricRBtn.Size = New System.Drawing.Size(124, 19)
        Me.HaricRBtn.TabIndex = 7
        Me.HaricRBtn.Text = "Klasörü Dahil Etme"
        Me.HaricRBtn.UseVisualStyleBackColor = True
        '
        'ZipBtn
        '
        Me.ZipBtn.Image = CType(resources.GetObject("ZipBtn.Image"), System.Drawing.Image)
        Me.ZipBtn.Location = New System.Drawing.Point(13, 230)
        Me.ZipBtn.Name = "ZipBtn"
        Me.ZipBtn.Size = New System.Drawing.Size(139, 69)
        Me.ZipBtn.TabIndex = 8
        Me.ZipBtn.Text = "Sıkıştır"
        Me.ZipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ZipBtn.UseVisualStyleBackColor = True
        '
        'VazgecBtn
        '
        Me.VazgecBtn.Image = CType(resources.GetObject("VazgecBtn.Image"), System.Drawing.Image)
        Me.VazgecBtn.Location = New System.Drawing.Point(261, 230)
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(139, 69)
        Me.VazgecBtn.TabIndex = 9
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.VazgecBtn.UseVisualStyleBackColor = True
        '
        'KlasorSecDiyalog
        '
        Me.KlasorSecDiyalog.ShowNewFolderButton = False
        '
        'DosyaKaydetDiyalog
        '
        Me.DosyaKaydetDiyalog.Filter = "Zip Arşiv Dosyası|*.zip"
        '
        'KlasorZipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 319)
        Me.Controls.Add(Me.VazgecBtn)
        Me.Controls.Add(Me.ZipBtn)
        Me.Controls.Add(Me.HaricRBtn)
        Me.Controls.Add(Me.DahilRBtn)
        Me.Controls.Add(Me.DosyaSecBtn)
        Me.Controls.Add(Me.DosyaTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KlasorTBox)
        Me.Controls.Add(Me.KlasorSecBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KlasorZipForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Klasör Sıkıştır"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KlasorSecBtn As Button
    Friend WithEvents KlasorTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DosyaTBox As TextBox
    Friend WithEvents DosyaSecBtn As Button
    Friend WithEvents DahilRBtn As RadioButton
    Friend WithEvents HaricRBtn As RadioButton
    Friend WithEvents ZipBtn As Button
    Friend WithEvents VazgecBtn As Button
    Friend WithEvents KlasorSecDiyalog As FolderBrowserDialog
    Friend WithEvents DosyaKaydetDiyalog As SaveFileDialog
End Class
