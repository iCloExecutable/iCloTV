<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customStLoad
	Inherits System.Windows.Forms.Form

	'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(475, 80)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "This is the custom settings loader." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't close this or the app will close"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(29, 415)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(708, 26)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "The settings loader was built by micraia in 2021 in the beginning of development" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(564, 9)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(224, 103)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "button if you close mainui without the setting thing lol"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'customStLoad
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "customStLoad"
		Me.Text = "CustomSettingsUX"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
End Class
