<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DosyaZipBtn = New System.Windows.Forms.Button()
        Me.KlasorZipBtn = New System.Windows.Forms.Button()
        Me.AyiklaZipBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DosyaZipBtn
        '
        Me.DosyaZipBtn.Image = CType(resources.GetObject("DosyaZipBtn.Image"), System.Drawing.Image)
        Me.DosyaZipBtn.Location = New System.Drawing.Point(12, 12)
        Me.DosyaZipBtn.Name = "DosyaZipBtn"
        Me.DosyaZipBtn.Size = New System.Drawing.Size(156, 76)
        Me.DosyaZipBtn.TabIndex = 0
        Me.DosyaZipBtn.Text = "Dosya Sıkıştır"
        Me.DosyaZipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DosyaZipBtn.UseVisualStyleBackColor = True
        '
        'KlasorZipBtn
        '
        Me.KlasorZipBtn.Image = CType(resources.GetObject("KlasorZipBtn.Image"), System.Drawing.Image)
        Me.KlasorZipBtn.Location = New System.Drawing.Point(12, 100)
        Me.KlasorZipBtn.Name = "KlasorZipBtn"
        Me.KlasorZipBtn.Size = New System.Drawing.Size(156, 76)
        Me.KlasorZipBtn.TabIndex = 1
        Me.KlasorZipBtn.Text = "Klasör Sıkıştır"
        Me.KlasorZipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KlasorZipBtn.UseVisualStyleBackColor = True
        '
        'AyiklaZipBtn
        '
        Me.AyiklaZipBtn.Image = CType(resources.GetObject("AyiklaZipBtn.Image"), System.Drawing.Image)
        Me.AyiklaZipBtn.Location = New System.Drawing.Point(12, 188)
        Me.AyiklaZipBtn.Name = "AyiklaZipBtn"
        Me.AyiklaZipBtn.Size = New System.Drawing.Size(156, 76)
        Me.AyiklaZipBtn.TabIndex = 2
        Me.AyiklaZipBtn.Text = "Ayıkla"
        Me.AyiklaZipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AyiklaZipBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 286)
        Me.Controls.Add(Me.AyiklaZipBtn)
        Me.Controls.Add(Me.KlasorZipBtn)
        Me.Controls.Add(Me.DosyaZipBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "BipZip"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DosyaZipBtn As Button
    Friend WithEvents KlasorZipBtn As Button
    Friend WithEvents AyiklaZipBtn As Button
End Class
