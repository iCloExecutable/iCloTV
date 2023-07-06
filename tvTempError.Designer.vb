<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tvTempError
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.label1.Location = New System.Drawing.Point(303, 101)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(181, 47)
		Me.label1.TabIndex = 0
		Me.label1.Text = "WARNING"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(160, 167)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(504, 96)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Warning! The TV is too hot." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can ignore this message or unplug the tv." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'Button1
		'
		Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Button1.Location = New System.Drawing.Point(365, 283)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "Ok!"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'tvTempError
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlText
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.label1)
		Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
		Me.Name = "tvTempError"
		Me.Text = "tvTempError"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
End Class
