<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSendEmail
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
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.txtAttachfile = New Telerik.WinControls.UI.RadTextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtSubject = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.lblFullname = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.txtAttachfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.lblFullname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel3
        '
        Me.RadPanel3.Controls.Add(Me.txtAttachfile)
        Me.RadPanel3.Controls.Add(Me.btnOpenFile)
        Me.RadPanel3.Controls.Add(Me.txtSubject)
        Me.RadPanel3.Controls.Add(Me.txtTo)
        Me.RadPanel3.Controls.Add(Me.RadLabel5)
        Me.RadPanel3.Controls.Add(Me.RadLabel3)
        Me.RadPanel3.Controls.Add(Me.RadLabel1)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel3.Location = New System.Drawing.Point(0, 58)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(695, 194)
        Me.RadPanel3.TabIndex = 0
        '
        'txtAttachfile
        '
        Me.txtAttachfile.AutoSize = False
        Me.txtAttachfile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttachfile.Location = New System.Drawing.Point(158, 119)
        Me.txtAttachfile.Name = "txtAttachfile"
        Me.txtAttachfile.Size = New System.Drawing.Size(459, 41)
        Me.txtAttachfile.TabIndex = 3
        Me.txtAttachfile.ThemeName = "ControlDefault"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(623, 119)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(53, 41)
        Me.btnOpenFile.TabIndex = 120
        Me.btnOpenFile.Text = "..."
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.AutoSize = False
        Me.txtSubject.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(158, 7)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(518, 41)
        Me.txtSubject.TabIndex = 0
        Me.txtSubject.ThemeName = "ControlDefault"
        '
        'txtTo
        '
        Me.txtTo.AutoSize = False
        Me.txtTo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(158, 64)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(518, 41)
        Me.txtTo.TabIndex = 1
        Me.txtTo.ThemeName = "ControlDefault"
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(12, 119)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(141, 33)
        Me.RadLabel5.TabIndex = 3
        Me.RadLabel5.Text = "Attachment :"
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(12, 64)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(47, 33)
        Me.RadLabel3.TabIndex = 1
        Me.RadLabel3.Text = "To :"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(12, 15)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(97, 33)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Subject :"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.RadButton2)
        Me.RadPanel2.Controls.Add(Me.RadButton1)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadPanel2.Location = New System.Drawing.Point(695, 58)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(220, 194)
        Me.RadPanel2.TabIndex = 181
        '
        'RadButton2
        '
        Me.RadButton2.Image = Global.CovidTestResult.My.Resources.Resources.Cancel_26px
        Me.RadButton2.Location = New System.Drawing.Point(7, 89)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(207, 78)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "Cancel"
        Me.RadButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadButton2.ThemeName = "Material"
        '
        'RadButton1
        '
        Me.RadButton1.Image = Global.CovidTestResult.My.Resources.Resources.Save_26px
        Me.RadButton1.Location = New System.Drawing.Point(7, 5)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(207, 78)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "Send"
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadButton1.ThemeName = "Material"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.lblFullname)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(915, 58)
        Me.RadPanel1.TabIndex = 180
        '
        'lblFullname
        '
        Me.lblFullname.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(102, 12)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(16, 33)
        Me.lblFullname.TabIndex = 1
        Me.lblFullname.Text = "."
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadLabel2.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(84, 33)
        Me.RadLabel2.TabIndex = 0
        Me.RadLabel2.Text = "Name :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BackgroundWorker1
        '
        '
        'FrmSendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 252)
        Me.Controls.Add(Me.RadPanel3)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSendEmail"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Email"
        Me.ThemeName = "Material"
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        Me.RadPanel3.PerformLayout()
        CType(Me.txtAttachfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.lblFullname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtAttachfile As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtSubject As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFullname As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class

