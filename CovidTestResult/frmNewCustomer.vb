Imports System.IO

Public Class FrmNewCustomer
    Private Sub FrmNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pickerbday.Text = DateTime.Now
        pickerdatetested.Text = DateTime.Now
        pickerbday.Format = DateTimePickerFormat.Custom
        pickerbday.CustomFormat = "MM-dd-yyyy"
        pickerdatetested.Format = DateTimePickerFormat.Custom
        pickerdatetested.CustomFormat = "MM-dd-yyyy"
        dropgender.Text = "Male"
        loadTestType()
        'dropresult.Text = "Negative"
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If txtfname.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtaddress.Text = "" Or txtemail.Text = "" Or txtcnumber.Text = "" Or txtage.Text = "" Or txtclinicname.Text = "" Or txtclinicianname.Text = "" Then
                MsgBox("All Fileds are Required", vbInformation)

                'ElseIf txtfilename.Text = "" Then
                '    MsgBox("File Upload is Required")

            Else
                'Dim destination As String
                'Dim filename As String()

                'filename = OpenFileDialog1.FileName.Split("\"c)
                'destination = String.Format(Application.StartupPath & "\FileUpload\" & filename(filename.Length - 1))

                If saveNewCustomer(txtfname.Text, txtlname.Text, txtmname.Text, txtaddress.Text, txtemail.Text, txtcnumber.Text, pickerbday.Text, txtage.Text, dropgender.Text, txtclinicname.Text, droptypes.SelectedValue, txtclinicianname.Text, pickerdatetested.Text) = True Then
                    'File.Delete(destination)
                    'File.Copy(OpenFileDialog1.FileName, "FileUpload\" + filename(filename.Length - 1))
                    MsgBox("Successfully Inserted", vbInformation)
                    Me.Dispose()
                    FrmDashboard.refreshDashboard()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Dim decstring As String = DecrptData(txtaddress.Text)
        MsgBox(decstring)
        Console.WriteLine(decstring)
        'Dim iexit As DialogResult
        'iexit = MessageBox.Show("Are you sure you want to Cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If iexit = DialogResult.Yes Then
        '    Me.Dispose()
        'End If
    End Sub
    Public Sub loadTestType()
        Try
            Dim dt As DataTable = loadTestTypeDropMod()
            If dt.Rows.Count > 0 Then
                droptypes.DataSource = dt
                droptypes.DisplayMember = "TestName"
                droptypes.ValueMember = "ID"
                droptypes.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dpgender_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles dropgender.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim Result As DialogResult = OpenFileDialog1.ShowDialog()
        'If Result = DialogResult.OK Then
        '    txtfilename.Text = OpenFileDialog1.FileName
        'End If
    End Sub

End Class
