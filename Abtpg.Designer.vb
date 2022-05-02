<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abtpg
	Inherits System.Windows.Forms.Form

	'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

	'Windows Form Tasarımcısı tarafından gerektirilir
	Private components As System.ComponentModel.IContainer

	'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
	'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
	'Kod düzenleyicisini kullanarak değiştirmeyin.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Abtpg))
		Me.PictureBox8 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox8
		'
		Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
		Me.PictureBox8.Location = New System.Drawing.Point(157, 176)
		Me.PictureBox8.Name = "PictureBox8"
		Me.PictureBox8.Size = New System.Drawing.Size(317, 233)
		Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox8.TabIndex = 10
		Me.PictureBox8.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label1.Location = New System.Drawing.Point(496, 189)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(120, 47)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "iCloTV"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label2.Location = New System.Drawing.Point(496, 236)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(171, 40)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Version 1.0a"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Label3.Location = New System.Drawing.Point(496, 276)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(700, 160)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "©2021 iCloCorp. All rights reserved. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Netflix logo and brand is owned by Net" &
	"flix." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Youtube logo and brand is owned by Google Inc. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Google Assistant" &
	" logo is owned by Google Inc. "
		'
		'Abtpg
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlText
		Me.ClientSize = New System.Drawing.Size(1210, 619)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox8)
		Me.Name = "Abtpg"
		Me.Text = "Abtpg"
		CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox8 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
End Class
