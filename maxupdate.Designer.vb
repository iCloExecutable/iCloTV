<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maxupdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(24, 74)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(1141, 434)
        Me.WebView21.Source = New System.Uri("https://api.iclostudios.ml/updsrv/tvx", System.UriKind.Absolute)
        Me.WebView21.TabIndex = 0
        Me.WebView21.ZoomFactor = 1.0R
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Update may have been found, we don't know. Just check the release date " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'WebView22
        '
        Me.WebView22.AllowExternalDrop = True
        Me.WebView22.CreationProperties = Nothing
        Me.WebView22.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView22.Location = New System.Drawing.Point(977, 560)
        Me.WebView22.Name = "WebView22"
        Me.WebView22.Size = New System.Drawing.Size(188, 37)
        Me.WebView22.Source = New System.Uri("https://api.iclostudios.ml/updsrv/tvx/buttondown.html", System.UriKind.Absolute)
        Me.WebView22.TabIndex = 2
        Me.WebView22.ZoomFactor = 1.0R
        '
        'maxupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1210, 619)
        Me.Controls.Add(Me.WebView22)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebView21)
        Me.Name = "maxupdate"
        Me.Text = "maxupdate"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Label1 As Label
    Friend WithEvents WebView22 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
