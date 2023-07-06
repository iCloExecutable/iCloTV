<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pcabout
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(28, 35)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(360, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "iClosOS 2.0 with systemUX 1.0"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(28, 77)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(515, 31)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Copyright 2022 iCloCorp. All rights reserved" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'pcabout
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(568, 143)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "pcabout"
		Me.Text = "pcabout"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
