<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.gridCustomer = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView2 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.gridSwabIssuanceResult = New Telerik.WinControls.UI.RadGridView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dropcustomer = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.RadPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView3 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.gridResultDistribution = New Telerik.WinControls.UI.RadGridView()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage2.SuspendLayout()
        CType(Me.gridCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel8.SuspendLayout()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.RadPageView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView2.SuspendLayout()
        Me.RadPageViewPage4.SuspendLayout()
        CType(Me.gridSwabIssuanceResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSwabIssuanceResult.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage3.SuspendLayout()
        CType(Me.RadPageView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView3.SuspendLayout()
        Me.RadPageViewPage5.SuspendLayout()
        CType(Me.gridResultDistribution, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridResultDistribution.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage2)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage3)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage2
        Me.RadPageView1.Size = New System.Drawing.Size(1545, 1040)
        Me.RadPageView1.TabIndex = 6
        Me.RadPageView1.ThemeName = "Material"
        Me.RadPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage
        '
        'RadPageViewPage2
        '
        Me.RadPageViewPage2.Controls.Add(Me.gridCustomer)
        Me.RadPageViewPage2.Controls.Add(Me.RadPanel8)
        Me.RadPageViewPage2.ItemSize = New System.Drawing.SizeF(153.0!, 49.0!)
        Me.RadPageViewPage2.Location = New System.Drawing.Point(206, 5)
        Me.RadPageViewPage2.Name = "RadPageViewPage2"
        Me.RadPageViewPage2.Size = New System.Drawing.Size(1334, 1030)
        Me.RadPageViewPage2.Text = "Dashboard"
        '
        'gridCustomer
        '
        Me.gridCustomer.BackColor = System.Drawing.Color.White
        Me.gridCustomer.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnF2
        Me.gridCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCustomer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridCustomer.ForeColor = System.Drawing.Color.Black
        Me.gridCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gridCustomer.Location = New System.Drawing.Point(0, 54)
        '
        '
        '
        Me.gridCustomer.MasterTemplate.AllowAddNewRow = False
        Me.gridCustomer.MasterTemplate.AllowCellContextMenu = False
        Me.gridCustomer.MasterTemplate.AllowColumnChooser = False
        Me.gridCustomer.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.gridCustomer.MasterTemplate.AllowColumnReorder = False
        Me.gridCustomer.MasterTemplate.AllowColumnResize = False
        Me.gridCustomer.MasterTemplate.AllowDeleteRow = False
        Me.gridCustomer.MasterTemplate.AllowDragToGroup = False
        Me.gridCustomer.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.gridCustomer.MasterTemplate.AllowRowResize = False
        Me.gridCustomer.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gridCustomer.MasterTemplate.EnableFiltering = True
        Me.gridCustomer.MasterTemplate.EnablePaging = True
        Me.gridCustomer.MasterTemplate.ShowFilteringRow = False
        Me.gridCustomer.MasterTemplate.ShowHeaderCellButtons = True
        Me.gridCustomer.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.gridCustomer.Name = "gridCustomer"
        Me.gridCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridCustomer.ShowHeaderCellButtons = True
        Me.gridCustomer.Size = New System.Drawing.Size(1334, 976)
        Me.gridCustomer.TabIndex = 10
        Me.gridCustomer.ThemeName = "ControlDefault"
        '
        'RadPanel8
        '
        Me.RadPanel8.Controls.Add(Me.RadButton6)
        Me.RadPanel8.Controls.Add(Me.Button2)
        Me.RadPanel8.Controls.Add(Me.RadLabel13)
        Me.RadPanel8.Controls.Add(Me.RadButton2)
        Me.RadPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel8.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(1334, 54)
        Me.RadPanel8.TabIndex = 4
        '
        'RadButton6
        '
        Me.RadButton6.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadButton6.Image = Global.CovidTestResult.My.Resources.Resources.generatereport
        Me.RadButton6.Location = New System.Drawing.Point(1186, 0)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(148, 54)
        Me.RadButton6.TabIndex = 108
        Me.RadButton6.Text = "Refresh"
        Me.RadButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.CovidTestResult.My.Resources.Resources.User_Groups_48px
        Me.Button2.Location = New System.Drawing.Point(560, -20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 94)
        Me.Button2.TabIndex = 107
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RadLabel13
        '
        Me.RadLabel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel13.Location = New System.Drawing.Point(8, 7)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(194, 33)
        Me.RadLabel13.TabIndex = 106
        Me.RadLabel13.Text = "Customer Records"
        '
        'RadButton2
        '
        Me.RadButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton2.Image = Global.CovidTestResult.My.Resources.Resources.Add_New_26px
        Me.RadButton2.Location = New System.Drawing.Point(210, 7)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(148, 41)
        Me.RadButton2.TabIndex = 22
        Me.RadButton2.Text = "Add New Record"
        Me.RadButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.RadPageView2)
        Me.RadPageViewPage1.ItemSize = New System.Drawing.SizeF(153.0!, 49.0!)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(206, 5)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(1334, 1030)
        Me.RadPageViewPage1.Text = "Swab Issuance"
        '
        'RadPageView2
        '
        Me.RadPageView2.Controls.Add(Me.RadPageViewPage4)
        Me.RadPageView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.RadPageView2.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView2.Name = "RadPageView2"
        Me.RadPageView2.SelectedPage = Me.RadPageViewPage4
        Me.RadPageView2.Size = New System.Drawing.Size(1334, 1030)
        Me.RadPageView2.TabIndex = 1
        Me.RadPageView2.ThemeName = "Material"
        '
        'RadPageViewPage4
        '
        Me.RadPageViewPage4.Controls.Add(Me.gridSwabIssuanceResult)
        Me.RadPageViewPage4.Controls.Add(Me.RadPanel1)
        Me.RadPageViewPage4.ItemSize = New System.Drawing.SizeF(140.0!, 50.0!)
        Me.RadPageViewPage4.Location = New System.Drawing.Point(6, 56)
        Me.RadPageViewPage4.Name = "RadPageViewPage4"
        Me.RadPageViewPage4.Size = New System.Drawing.Size(1322, 968)
        Me.RadPageViewPage4.Text = "Swab Issuance"
        '
        'gridSwabIssuanceResult
        '
        Me.gridSwabIssuanceResult.BackColor = System.Drawing.Color.White
        Me.gridSwabIssuanceResult.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnF2
        Me.gridSwabIssuanceResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridSwabIssuanceResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridSwabIssuanceResult.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridSwabIssuanceResult.ForeColor = System.Drawing.Color.Black
        Me.gridSwabIssuanceResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gridSwabIssuanceResult.Location = New System.Drawing.Point(0, 56)
        '
        '
        '
        Me.gridSwabIssuanceResult.MasterTemplate.AllowAddNewRow = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowCellContextMenu = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowColumnChooser = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowColumnReorder = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowColumnResize = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowDeleteRow = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowDragToGroup = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.gridSwabIssuanceResult.MasterTemplate.AllowRowResize = False
        Me.gridSwabIssuanceResult.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gridSwabIssuanceResult.MasterTemplate.EnableFiltering = True
        Me.gridSwabIssuanceResult.MasterTemplate.EnablePaging = True
        Me.gridSwabIssuanceResult.MasterTemplate.ShowFilteringRow = False
        Me.gridSwabIssuanceResult.MasterTemplate.ShowHeaderCellButtons = True
        Me.gridSwabIssuanceResult.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.gridSwabIssuanceResult.Name = "gridSwabIssuanceResult"
        Me.gridSwabIssuanceResult.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridSwabIssuanceResult.ShowHeaderCellButtons = True
        Me.gridSwabIssuanceResult.Size = New System.Drawing.Size(1322, 912)
        Me.gridSwabIssuanceResult.TabIndex = 9
        Me.gridSwabIssuanceResult.ThemeName = "ControlDefault"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.PictureBox1)
        Me.RadPanel1.Controls.Add(Me.dropcustomer)
        Me.RadPanel1.Controls.Add(Me.RadButton1)
        Me.RadPanel1.Controls.Add(Me.RadButton5)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1322, 56)
        Me.RadPanel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(821, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 260)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'dropcustomer
        '
        Me.dropcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.dropcustomer.Location = New System.Drawing.Point(9, 7)
        Me.dropcustomer.Name = "dropcustomer"
        Me.dropcustomer.Size = New System.Drawing.Size(335, 41)
        Me.dropcustomer.TabIndex = 2
        Me.dropcustomer.Text = "Select Customer"
        Me.dropcustomer.ThemeName = "Material"
        '
        'RadButton1
        '
        Me.RadButton1.Enabled = False
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.Image = Global.CovidTestResult.My.Resources.Resources.Save_26px
        Me.RadButton1.Location = New System.Drawing.Point(582, 7)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(195, 41)
        Me.RadButton1.TabIndex = 4
        Me.RadButton1.Text = "Report Preview"
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadButton5
        '
        Me.RadButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton5.Image = Global.CovidTestResult.My.Resources.Resources.generatereport
        Me.RadButton5.Location = New System.Drawing.Point(356, 7)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(220, 41)
        Me.RadButton5.TabIndex = 3
        Me.RadButton5.Text = "Generate Result"
        Me.RadButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadPageViewPage3
        '
        Me.RadPageViewPage3.Controls.Add(Me.RadPageView3)
        Me.RadPageViewPage3.ItemSize = New System.Drawing.SizeF(153.0!, 49.0!)
        Me.RadPageViewPage3.Location = New System.Drawing.Point(206, 5)
        Me.RadPageViewPage3.Name = "RadPageViewPage3"
        Me.RadPageViewPage3.Size = New System.Drawing.Size(1334, 1030)
        Me.RadPageViewPage3.Text = "Result Distribution"
        '
        'RadPageView3
        '
        Me.RadPageView3.Controls.Add(Me.RadPageViewPage5)
        Me.RadPageView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.RadPageView3.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView3.Name = "RadPageView3"
        Me.RadPageView3.SelectedPage = Me.RadPageViewPage5
        Me.RadPageView3.Size = New System.Drawing.Size(1334, 1030)
        Me.RadPageView3.TabIndex = 2
        Me.RadPageView3.ThemeName = "Material"
        '
        'RadPageViewPage5
        '
        Me.RadPageViewPage5.Controls.Add(Me.gridResultDistribution)
        Me.RadPageViewPage5.ItemSize = New System.Drawing.SizeF(158.0!, 50.0!)
        Me.RadPageViewPage5.Location = New System.Drawing.Point(6, 56)
        Me.RadPageViewPage5.Name = "RadPageViewPage5"
        Me.RadPageViewPage5.Size = New System.Drawing.Size(1322, 968)
        Me.RadPageViewPage5.Text = "Result Distribution"
        '
        'gridResultDistribution
        '
        Me.gridResultDistribution.BackColor = System.Drawing.Color.White
        Me.gridResultDistribution.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnF2
        Me.gridResultDistribution.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridResultDistribution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridResultDistribution.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gridResultDistribution.ForeColor = System.Drawing.Color.Black
        Me.gridResultDistribution.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gridResultDistribution.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.gridResultDistribution.MasterTemplate.AllowAddNewRow = False
        Me.gridResultDistribution.MasterTemplate.AllowCellContextMenu = False
        Me.gridResultDistribution.MasterTemplate.AllowColumnChooser = False
        Me.gridResultDistribution.MasterTemplate.AllowColumnHeaderContextMenu = False
        Me.gridResultDistribution.MasterTemplate.AllowColumnReorder = False
        Me.gridResultDistribution.MasterTemplate.AllowColumnResize = False
        Me.gridResultDistribution.MasterTemplate.AllowDeleteRow = False
        Me.gridResultDistribution.MasterTemplate.AllowDragToGroup = False
        Me.gridResultDistribution.MasterTemplate.AllowRowHeaderContextMenu = False
        Me.gridResultDistribution.MasterTemplate.AllowRowResize = False
        Me.gridResultDistribution.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.gridResultDistribution.MasterTemplate.EnableFiltering = True
        Me.gridResultDistribution.MasterTemplate.EnablePaging = True
        Me.gridResultDistribution.MasterTemplate.ShowFilteringRow = False
        Me.gridResultDistribution.MasterTemplate.ShowHeaderCellButtons = True
        Me.gridResultDistribution.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.gridResultDistribution.Name = "gridResultDistribution"
        Me.gridResultDistribution.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridResultDistribution.ShowHeaderCellButtons = True
        Me.gridResultDistribution.Size = New System.Drawing.Size(1322, 968)
        Me.gridResultDistribution.TabIndex = 10
        Me.gridResultDistribution.ThemeName = "ControlDefault"
        '
        'RadButton3
        '
        Me.RadButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadButton3.Location = New System.Drawing.Point(116, 7)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(148, 41)
        Me.RadButton3.TabIndex = 22
        Me.RadButton3.Text = "Add New Accounts"
        Me.RadButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(397, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(601, 41)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(3, 7)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(105, 33)
        Me.RadLabel2.TabIndex = 106
        '
        'RadButton4
        '
        Me.RadButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton4.Location = New System.Drawing.Point(1179, 7)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(148, 41)
        Me.RadButton4.TabIndex = 107
        Me.RadButton4.Text = "Compute"
        Me.RadButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 1040)
        Me.Controls.Add(Me.RadPageView1)
        Me.Name = "FrmDashboard"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ThemeName = "Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage2.ResumeLayout(False)
        CType(Me.gridCustomer.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel8.ResumeLayout(False)
        Me.RadPanel8.PerformLayout()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage1.ResumeLayout(False)
        CType(Me.RadPageView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView2.ResumeLayout(False)
        Me.RadPageViewPage4.ResumeLayout(False)
        CType(Me.gridSwabIssuanceResult.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSwabIssuanceResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage3.ResumeLayout(False)
        CType(Me.RadPageView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView3.ResumeLayout(False)
        Me.RadPageViewPage5.ResumeLayout(False)
        CType(Me.gridResultDistribution.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridResultDistribution, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button1 As Button
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button2 As Button
    Friend WithEvents RadPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageView2 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents gridCustomer As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dropcustomer As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents gridSwabIssuanceResult As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPageView3 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents gridResultDistribution As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox1 As PictureBox
End Class

