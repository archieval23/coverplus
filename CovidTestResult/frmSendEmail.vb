Imports System.ComponentModel
Imports System.Net.Mail
Imports System.Text

Public Class FrmSendEmail
    Public fullname, email, gender, encrptedData, link As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub FrmSendEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFullname.Text = fullname
        txtTo.Text = email
        txtSubject.Text = "Cover Plus Result Distribution for " & fullname
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            Using mail As New MailMessage
                Dim lastname As String() = fullname.Split(New Char() {","c})
                Dim content As New StringBuilder
                If gender = "Male" Then
                    content.AppendLine("<b>Dear Mr. " & lastname(0) & ",</b><br>")
                Else
                    content.AppendLine("<b>Dear Ms. " & lastname(0) & ",</b><br>")
                End If
                content.AppendLine("<br>")
                content.AppendLine("Your COVID-19 Test Result and Certification has come out. To view your result, please see the attachment below.<br>")
                content.AppendLine("<br>")
                content.AppendLine("If you want to verify your certification, scan the QR code and verify using your registered Birthday.<br>")
                content.AppendLine("<br>")
                'content.AppendLine("Key : <b>" & EncrptData(encrptedData) & "</b><br>")
                'content.AppendLine("<br>")
                content.AppendLine("In case you have any questions, do not hesitate to contact or email us. We are open from Monday to Friday: 9:00-12:00NN and 1:00-5:00PM only.<br>")
                content.AppendLine("<br>")
                content.AppendLine("<b>Thank you,</b><br>")
                content.AppendLine("<br>")
                content.AppendLine("<b>CoVer Life</b><br>")
                content.AppendLine("<br>")
                content.AppendLine("<br>")
                content.AppendLine("*The contents of this email message and any attachments are intended only for the person(s) named in the addressee(s). It contains information that is confidential, privileged and/or exempt from disclosure. <br>")
                content.AppendLine("<br>")
                content.AppendLine("If you have received this message in error, please notify the sender and delete the message.<br>")

                Dim from As String = "coverpluslife@gmail.com"
                If String.IsNullOrEmpty(txtAttachfile.Text) Then
                    MsgBox("File Attachment is Required", vbInformation)
                Else
                    With mail
                        .From = New MailAddress(from)
                        .To.Add(txtTo.Text)
                        .Body = content.ToString()
                        .IsBodyHtml = True
                        If Not OpenFileDialog1.FileName = vbNullString Then
                            Dim attach As New Attachment(OpenFileDialog1.FileName)
                            mail.Attachments.Add(attach)
                        End If
                        .Subject = txtSubject.Text
                        .Priority = mail.Priority.Normal
                        Using smtp As New SmtpClient
                            With smtp
                                .EnableSsl = True
                                .Port = "587"
                                .Host = "smtp.gmail.com"
                                .Credentials = New Net.NetworkCredential(from, "SdYyJAh4UTVyhiX")
                                .Send(mail)
                            End With
                        End Using
                        MsgBox("Successfully Sent", vbInformation)
                        Me.Dispose()
                    End With
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to Cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtAttachfile.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class
