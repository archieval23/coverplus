<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSwabResultReport
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
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.crvSwabResult = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvSwabResult
        '
        Me.crvSwabResult.ActiveViewIndex = -1
        Me.crvSwabResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvSwabResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvSwabResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvSwabResult.Location = New System.Drawing.Point(0, 0)
        Me.crvSwabResult.Name = "crvSwabResult"
        Me.crvSwabResult.Size = New System.Drawing.Size(1018, 544)
        Me.crvSwabResult.TabIndex = 0
        '
        'FrmSwabResultReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 544)
        Me.Controls.Add(Me.crvSwabResult)
        Me.Name = "FrmSwabResultReport"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSwabResultReport"
        Me.ThemeName = "Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents crvSwabResult As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class

