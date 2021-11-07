<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddResult
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.pickerSpecimen = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dropResult = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btncancel = New Telerik.WinControls.UI.RadButton()
        Me.btnsave = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.lblFullname = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.pickerSpecimen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.lblFullname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel3
        '
        Me.RadPanel3.Controls.Add(Me.pickerSpecimen)
        Me.RadPanel3.Controls.Add(Me.dropResult)
        Me.RadPanel3.Controls.Add(Me.RadLabel4)
        Me.RadPanel3.Controls.Add(Me.RadLabel6)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel3.Location = New System.Drawing.Point(0, 62)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(418, 259)
        Me.RadPanel3.TabIndex = 0
        '
        'pickerSpecimen
        '
        Me.pickerSpecimen.CalendarSize = New System.Drawing.Size(290, 320)
        Me.pickerSpecimen.Location = New System.Drawing.Point(16, 138)
        Me.pickerSpecimen.Name = "pickerSpecimen"
        Me.pickerSpecimen.Size = New System.Drawing.Size(363, 41)
        Me.pickerSpecimen.TabIndex = 2
        Me.pickerSpecimen.TabStop = False
        Me.pickerSpecimen.Text = "Tuesday, September 28, 2021"
        Me.pickerSpecimen.ThemeName = "Material"
        Me.pickerSpecimen.Value = New Date(2021, 9, 28, 19, 18, 49, 720)
        '
        'dropResult
        '
        Me.dropResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        RadListDataItem1.Text = "Negative"
        RadListDataItem2.Text = "Positive"
        Me.dropResult.Items.Add(RadListDataItem1)
        Me.dropResult.Items.Add(RadListDataItem2)
        Me.dropResult.Location = New System.Drawing.Point(16, 43)
        Me.dropResult.Name = "dropResult"
        Me.dropResult.Size = New System.Drawing.Size(363, 41)
        Me.dropResult.TabIndex = 1
        Me.dropResult.ThemeName = "Material"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(16, 97)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(200, 25)
        Me.RadLabel4.TabIndex = 183
        Me.RadLabel4.Text = "Date Specimen Collected"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.Location = New System.Drawing.Point(16, 13)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(56, 25)
        Me.RadLabel6.TabIndex = 0
        Me.RadLabel6.Text = "Result"
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.btncancel)
        Me.RadPanel2.Controls.Add(Me.btnsave)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadPanel2.Location = New System.Drawing.Point(418, 62)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(220, 259)
        Me.RadPanel2.TabIndex = 181
        '
        'btncancel
        '
        Me.btncancel.Image = Global.CovidTestResult.My.Resources.Resources.Cancel_26px
        Me.btncancel.Location = New System.Drawing.Point(6, 90)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(207, 78)
        Me.btncancel.TabIndex = 1
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.ThemeName = "Material"
        '
        'btnsave
        '
        Me.btnsave.Image = Global.CovidTestResult.My.Resources.Resources.Save_26px
        Me.btnsave.Location = New System.Drawing.Point(6, 6)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(207, 78)
        Me.btnsave.TabIndex = 0
        Me.btnsave.Text = "Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.ThemeName = "Material"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.lblFullname)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(638, 62)
        Me.RadPanel1.TabIndex = 180
        '
        'lblFullname
        '
        Me.lblFullname.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.Location = New System.Drawing.Point(106, 12)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(16, 33)
        Me.lblFullname.TabIndex = 177
        Me.lblFullname.Text = "."
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadLabel1.Location = New System.Drawing.Point(16, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(84, 33)
        Me.RadLabel1.TabIndex = 176
        Me.RadLabel1.Text = "Name :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmAddResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 321)
        Me.Controls.Add(Me.RadPanel3)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddResult"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Result"
        Me.ThemeName = "Material"
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        Me.RadPanel3.PerformLayout()
        CType(Me.pickerSpecimen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.btncancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.lblFullname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btncancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnsave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dropResult As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents pickerSpecimen As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents lblFullname As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

