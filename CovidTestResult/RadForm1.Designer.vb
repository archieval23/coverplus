<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.PictureBox1)
        Me.RadGroupBox1.Controls.Add(Me.RadButton2)
        Me.RadGroupBox1.Controls.Add(Me.RadButton1)
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox2)
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox1.HeaderText = "LogIn"
        Me.RadGroupBox1.Location = New System.Drawing.Point(68, 37)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(339, 406)
        Me.RadGroupBox1.TabIndex = 4
        Me.RadGroupBox1.Text = "LogIn"
        Me.RadGroupBox1.ThemeName = "Material"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.CovidTestResult.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RadButton2
        '
        Me.RadButton2.BackColor = System.Drawing.Color.Red
        Me.RadButton2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton2.ForeColor = System.Drawing.Color.White
        Me.RadButton2.Location = New System.Drawing.Point(180, 332)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(125, 36)
        Me.RadButton2.TabIndex = 3
        Me.RadButton2.Text = "Exit"
        Me.RadButton2.ThemeName = "Material"
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.Location = New System.Drawing.Point(35, 332)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(139, 36)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Login"
        Me.RadButton1.ThemeName = "Material"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox2.ForeColor = System.Drawing.Color.Gray
        Me.RadTextBox2.Location = New System.Drawing.Point(35, 288)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(270, 42)
        Me.RadTextBox2.TabIndex = 1
        Me.RadTextBox2.Text = "Password"
        Me.RadTextBox2.ThemeName = "Material"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox1.ForeColor = System.Drawing.Color.Gray
        Me.RadTextBox1.Location = New System.Drawing.Point(35, 246)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(270, 42)
        Me.RadTextBox1.TabIndex = 0
        Me.RadTextBox1.Text = "Username"
        Me.RadTextBox1.ThemeName = "Material"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CovidTestResult.My.Resources.Resources.trianglify_background
        Me.ClientSize = New System.Drawing.Size(480, 482)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ThemeName = "Material"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
End Class
