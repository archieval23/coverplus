Imports Telerik.WinControls.UI

Public Class FrmDashboard
    Public loggedUserID
    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        FrmNewCustomer.ShowDialog()
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshDashboard()
    End Sub
    Public Sub loadCustomer()
        Try
            Dim dt As DataTable = loadCustomerMod()
            If dt.Rows.Count > 0 Then
                gridCustomer.DataSource = dt
                Dim commandColumn As New GridViewCommandColumn()
                Dim commandColumn1 As New GridViewCommandColumn()

                With commandColumn
                    .Name = "CommandColumn"
                    .UseDefaultText = True
                    .DefaultText = "Delete"
                    .HeaderText = "Delete"
                    .PinPosition = PinnedColumnPosition.Right
                End With

                With commandColumn1
                    .Name = "CommandColumn1"
                    .UseDefaultText = True
                    .DefaultText = "Add Result"
                    .HeaderText = "Action"
                    .PinPosition = PinnedColumnPosition.Right
                End With

                gridCustomer.MasterTemplate.Columns.Add(commandColumn1)
                gridCustomer.MasterTemplate.Columns.Add(commandColumn)

                AddHandler gridCustomer.CommandCellClick, AddressOf ActionItem_CommandCellClick

                For i As Integer = 0 To gridCustomer.Columns.Count - 1
                    gridCustomer.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                    gridCustomer.Columns(i).Width = 100
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadCustomerforSwabIssuance()
        Try
            Dim dt As DataTable = loadCustomerDropMod()
            If dt.Rows.Count > 0 Then
                dropcustomer.DataSource = dt
                dropcustomer.DisplayMember = "FullName"
                dropcustomer.ValueMember = "ID"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadswabissuanceResult()
        Try
            Try
                Dim dt As DataTable = loadSwabIssuanceResultMod(Val(dropcustomer.SelectedValue))
                If dt.Rows.Count > 0 Then
                    gridSwabIssuanceResult.DataSource = dt
                    For i As Integer = 0 To gridSwabIssuanceResult.Columns.Count - 1
                        gridSwabIssuanceResult.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                        gridSwabIssuanceResult.Columns(i).Width = 100
                    Next
                Else
                    MsgBox("Customer Doesn't have Result yet", vbInformation)
                    gridSwabIssuanceResult.DataSource = Nothing

                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadCustomerResultDistribution()
        Try
            Dim dt As DataTable = loadCustomerResultDistributionMod()
            If dt.Rows.Count > 0 Then
                gridResultDistribution.DataSource = dt

                Dim commandColumn As New GridViewCommandColumn()

                With commandColumn
                    .Name = "CommandColumn"
                    .UseDefaultText = True
                    .DefaultText = "Send Email"
                    .HeaderText = "Send Email"
                    .PinPosition = PinnedColumnPosition.Right
                End With

                gridResultDistribution.MasterTemplate.Columns.Add(commandColumn)

                AddHandler gridResultDistribution.CommandCellClick, AddressOf ActionItemResultDistribution_CommandCellClick
                gridResultDistribution.Columns(4).IsVisible = True
                For i As Integer = 0 To gridResultDistribution.Columns.Count - 1
                    gridResultDistribution.Columns(i).TextAlignment = ContentAlignment.MiddleCenter
                    gridResultDistribution.Columns(i).Width = 100
                Next
            Else
                'MsgBox("Customer Doesn't have Result yet", vbInformation)
                gridSwabIssuanceResult.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub refreshDashboard()
        loadCustomer()
        loadCustomerforSwabIssuance()
        loadCustomerResultDistribution()
    End Sub
    Private Sub ActionItem_CommandCellClick(sender As Object, e As GridViewCellEventArgs)
        Try
            If gridCustomer.SelectedRows.Count > 0 Then
                If e.ColumnIndex = gridCustomer.Columns(10).Index Then
                    Dim id As Integer = gridCustomer.CurrentRow.Cells(0).Value.ToString
                    Dim remove As DialogResult
                    remove = MessageBox.Show("Are you sure you want To Delete Record " & id & "? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If remove = DialogResult.Yes Then
                        Dim deleteCustomer As Boolean = deleteCustomerMod(id)
                        If deleteCustomer = True Then
                            refreshDashboard()
                            MsgBox("Successfully Removed", vbInformation)
                        End If
                    End If
                ElseIf e.ColumnIndex = gridCustomer.Columns(9).Index Then
                    Dim result As String = gridCustomer.CurrentRow.Cells(8).Value.ToString
                    If result = "" Then
                        Dim id As Integer = gridCustomer.CurrentRow.Cells(0).Value.ToString
                        With FrmAddResult
                            .CustomerID = gridCustomer.CurrentRow.Cells(0).Value.ToString
                            .Fullname = gridCustomer.CurrentRow.Cells(1).Value.ToString
                            .userloggedID = loggedUserID
                            .ShowDialog()
                        End With
                    Else
                        MsgBox("User Already have Result", vbCritical)
                    End If

                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActionItemResultDistribution_CommandCellClick(sender As Object, e As GridViewCellEventArgs)
        Try
            If gridResultDistribution.SelectedRows.Count > 0 Then
                If e.ColumnIndex = gridResultDistribution.Columns(9).Index Then
                    Dim id As Integer = gridResultDistribution.CurrentRow.Cells(0).Value.ToString
                    With FrmSendEmail
                        .fullname = gridResultDistribution.CurrentRow.Cells(1).Value.ToString
                        .email = gridResultDistribution.CurrentRow.Cells(2).Value.ToString
                        .gender = gridResultDistribution.CurrentRow.Cells(3).Value.ToString
                        .encrptedData = gridResultDistribution.CurrentRow.Cells(4).Value.ToString
                        .ShowDialog()
                    End With
                    'MsgBox(id)
                    'Dim remove As DialogResult
                    'remove = MessageBox.Show("Are you sure you want To Delete Record " & id & "? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'If remove = DialogResult.Yes Then
                    '    Dim deleteCustomer As Boolean = deleteCustomerMod(id)
                    '    If deleteCustomer = True Then
                    '        refreshDashboard()
                    '        MsgBox("Successfully Removed", vbInformation)
                    '    End If
                    'End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        loadswabissuanceResult()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            If gridSwabIssuanceResult.Rows.Count > 0 Then
                Dim fullname, address, cnumber, gender As String
                Dim testname, testresult, interpretation As String
                Dim clinicname, clinicianname, datetested As String
                Dim id As Integer

                Dim dt As DataTable = loadSwabIssuanceResultforReportMod(Val(dropcustomer.SelectedValue))
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        id = row("ID")
                        fullname = row("FullName")
                        address = row("address")
                        cnumber = row("contactnumber")
                        gender = row("gender")
                        testname = row("TestName")
                        testresult = row("TestResult")
                        interpretation = row("TestInterpretation")
                        clinicname = row("hospitalname")
                        clinicianname = row("clinicianname")
                        datetested = row("datetested")
                    Next
                    With FrmSwabResultReport
                        .ID = id
                        .fullname = fullname
                        .address = address
                        .cnumber = cnumber
                        .gender = gender
                        .testname = testname
                        .testresult = testresult
                        .interpretation = interpretation
                        .clinicname = clinicname
                        .clinicianname = clinicianname
                        .datetested = datetested
                        .ShowDialog()
                    End With
                End If
            Else
                MsgBox("Please Generate Result first", vbInformation)
                gridSwabIssuanceResult.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        refreshDashboard()
    End Sub
End Class
