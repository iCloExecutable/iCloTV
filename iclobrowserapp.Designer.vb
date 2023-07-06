<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iclobrowserapp
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(iclobrowserapp))
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(14, 21)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(83, 27)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Git"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(1026, 14)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(12, 27)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Hakkında"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(104, 21)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(867, 23)
		Me.TextBox1.TabIndex = 4
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WebBrowser1.Location = New System.Drawing.Point(4, 54)
		Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(23, 23)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(1093, 541)
		Me.WebBrowser1.TabIndex = 5
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(1044, 9)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(40, 35)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 6
		Me.PictureBox1.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(979, 9)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(40, 35)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 7
		Me.PictureBox2.TabStop = False
		'
		'iclobrowserapp
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1098, 594)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Name = "iclobrowserapp"
		Me.Text = "iCloBrowser"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
