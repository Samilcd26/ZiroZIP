<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AyiklaZipForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AyiklaZipForm))
        Me.VazgecBtn = New System.Windows.Forms.Button()
        Me.ZipBtn = New System.Windows.Forms.Button()
        Me.DosyaTBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KlasorTBox = New System.Windows.Forms.TextBox()
        Me.KlasorSecBtn = New System.Windows.Forms.Button()
        Me.DosyaSecBtn = New System.Windows.Forms.Button()
        Me.KlasorSecDiyalog = New System.Windows.Forms.FolderBrowserDialog()
        Me.DosyaAcDiyalog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'VazgecBtn
        '
        Me.VazgecBtn.Image = CType(resources.GetObject("VazgecBtn.Image"), System.Drawing.Image)
        Me.VazgecBtn.Location = New System.Drawing.Point(264, 166)
        Me.VazgecBtn.Name = "VazgecBtn"
        Me.VazgecBtn.Size = New System.Drawing.Size(139, 69)
        Me.VazgecBtn.TabIndex = 18
        Me.VazgecBtn.Text = "Vazgeç"
        Me.VazgecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.VazgecBtn.UseVisualStyleBackColor = True
        '
        'ZipBtn
        '
        Me.ZipBtn.Image = CType(resources.GetObject("ZipBtn.Image"), System.Drawing.Image)
        Me.ZipBtn.Location = New System.Drawing.Point(9, 166)
        Me.ZipBtn.Name = "ZipBtn"
        Me.ZipBtn.Size = New System.Drawing.Size(139, 69)
        Me.ZipBtn.TabIndex = 17
        Me.ZipBtn.Text = "Ayıkla"
        Me.ZipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ZipBtn.UseVisualStyleBackColor = True
        '
        'DosyaTBox
        '
        Me.DosyaTBox.Location = New System.Drawing.Point(9, 33)
        Me.DosyaTBox.Multiline = True
        Me.DosyaTBox.Name = "DosyaTBox"
        Me.DosyaTBox.ReadOnly = True
        Me.DosyaTBox.Size = New System.Drawing.Size(353, 67)
        Me.DosyaTBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ayıklanacak Dosya"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ayıklanacak Klasör"
        '
        'KlasorTBox
        '
        Me.KlasorTBox.Location = New System.Drawing.Point(9, 118)
        Me.KlasorTBox.Name = "KlasorTBox"
        Me.KlasorTBox.ReadOnly = True
        Me.KlasorTBox.Size = New System.Drawing.Size(353, 23)
        Me.KlasorTBox.TabIndex = 11
        '
        'KlasorSecBtn
        '
        Me.KlasorSecBtn.Location = New System.Drawing.Point(368, 118)
        Me.KlasorSecBtn.Name = "KlasorSecBtn"
        Me.KlasorSecBtn.Size = New System.Drawing.Size(35, 26)
        Me.KlasorSecBtn.TabIndex = 10
        Me.KlasorSecBtn.Text = "..."
        Me.KlasorSecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.KlasorSecBtn.UseVisualStyleBackColor = True
        '
        'DosyaSecBtn
        '
        Me.DosyaSecBtn.Location = New System.Drawing.Point(368, 32)
        Me.DosyaSecBtn.Name = "DosyaSecBtn"
        Me.DosyaSecBtn.Size = New System.Drawing.Size(35, 68)
        Me.DosyaSecBtn.TabIndex = 19
        Me.DosyaSecBtn.Text = "..."
        Me.DosyaSecBtn.UseVisualStyleBackColor = True
        '
        'KlasorSecDiyalog
        '
        Me.KlasorSecDiyalog.ShowNewFolderButton = False
        '
        'DosyaAcDiyalog
        '
        Me.DosyaAcDiyalog.Filter = "Zip Arşiv Dosyası|*.zip"
        '
        'AyiklaZipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 264)
        Me.Controls.Add(Me.DosyaSecBtn)
        Me.Controls.Add(Me.VazgecBtn)
        Me.Controls.Add(Me.ZipBtn)
        Me.Controls.Add(Me.DosyaTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KlasorTBox)
        Me.Controls.Add(Me.KlasorSecBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AyiklaZipForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sıkıştırılmış Dosya Ayıkla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VazgecBtn As Button
    Friend WithEvents ZipBtn As Button
    Friend WithEvents DosyaTBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KlasorTBox As TextBox
    Friend WithEvents KlasorSecBtn As Button
    Friend WithEvents DosyaSecBtn As Button
    Friend WithEvents KlasorSecDiyalog As FolderBrowserDialog
    Friend WithEvents DosyaAcDiyalog As OpenFileDialog
End Class
