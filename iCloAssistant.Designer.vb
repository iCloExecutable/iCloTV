﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class iCloAssistant
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
		Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
		CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'WebView21
		'
		Me.WebView21.AllowExternalDrop = True
		Me.WebView21.CreationProperties = Nothing
		Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
		Me.WebView21.Location = New System.Drawing.Point(1, 1)
		Me.WebView21.Name = "WebView21"
		Me.WebView21.Size = New System.Drawing.Size(1209, 616)
		Me.WebView21.Source = New System.Uri("http://api.iclostudios.ml/icloassistant", System.UriKind.Absolute)
		Me.WebView21.TabIndex = 0
		Me.WebView21.ZoomFactor = 1.0R
		'
		'iCloAssistant
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1210, 619)
		Me.Controls.Add(Me.WebView21)
		Me.Name = "iCloAssistant"
		Me.Text = "iCloAssistant"
		CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
