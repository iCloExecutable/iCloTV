<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YuoTuba
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
		Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
		CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'webView
		'
		Me.webView.CreationProperties = Nothing
		Me.webView.DefaultBackgroundColor = System.Drawing.Color.White
		Me.webView.Location = New System.Drawing.Point(0, 3)
		Me.webView.Name = "webView"
		Me.webView.Size = New System.Drawing.Size(1210, 618)
		Me.webView.Source = New System.Uri("https://www.youtube.com/tv", System.UriKind.Absolute)
		Me.webView.TabIndex = 0
		Me.webView.ZoomFactor = 1.0R
		'
		'YuoTuba
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1210, 619)
		Me.Controls.Add(Me.webView)
		Me.Name = "YuoTuba"
		Me.Text = "YouTube"
		CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
