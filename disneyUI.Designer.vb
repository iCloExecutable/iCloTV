<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class disneyUI
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
		Me.MainFrame = New Microsoft.Web.WebView2.WinForms.WebView2()
		CType(Me.MainFrame, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MainFrame
		'
		Me.MainFrame.AllowExternalDrop = True
		Me.MainFrame.CreationProperties = Nothing
		Me.MainFrame.DefaultBackgroundColor = System.Drawing.Color.White
		Me.MainFrame.Location = New System.Drawing.Point(-2, -1)
		Me.MainFrame.Name = "MainFrame"
		Me.MainFrame.Size = New System.Drawing.Size(1211, 620)
		Me.MainFrame.Source = New System.Uri("https://disneyplus.com/tr-tr/home", System.UriKind.Absolute)
		Me.MainFrame.TabIndex = 0
		Me.MainFrame.ZoomFactor = 1.0R
		'
		'disneyUI
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1210, 619)
		Me.Controls.Add(Me.MainFrame)
		Me.Name = "disneyUI"
		Me.Text = "disneyUI"
		CType(Me.MainFrame, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents MainFrame As Microsoft.Web.WebView2.WinForms.WebView2
End Class
