Public Class FrmAddResult
    Public CustomerID, userloggedID As Integer
    Public Fullname As String
    Private Sub RadLabel6_Click(sender As Object, e As EventArgs) Handles RadLabel6.Click

    End Sub

    Private Sub RadPanel3_Paint(sender As Object, e As PaintEventArgs) Handles RadPanel3.Paint

    End Sub

    Private Sub FrmAddResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pickerSpecimen.Text = DateTime.Now
        pickerSpecimen.Format = DateTimePickerFormat.Custom
        pickerSpecimen.CustomFormat = "MM-dd-yyyy"
        dropResult.Text = "Negative"
        lblFullname.Text = Fullname.ToUpper
        'RadLabel1.Text = CustomerID.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim Result As DialogResult = OpenFileDialog1.ShowDialog()
        'If Result = DialogResult.OK Then
        '    txtfilename.Text = OpenFileDialog1.FileName
        'End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If saveCustomerResult(dropResult.Text, pickerSpecimen.Text, CustomerID, userloggedID) = True Then
                'File.Delete(destination)
                'File.Copy(OpenFileDialog1.FileName, "FileUpload\" + filename(filename.Length - 1))
                MsgBox("Result Successfully Added", vbInformation)
                Me.Dispose()
                FrmDashboard.refreshDashboard()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to Cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class
