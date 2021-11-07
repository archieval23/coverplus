Public Class RadForm1
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            Dim username, password As String
            Dim lastname As String = ""
            Dim ID As Integer

            username = RadTextBox1.Text
            password = RadTextBox2.Text
            Dim dt As DataTable = login(username, password)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    ID = row("ID")
                    With FrmDashboard
                        .loggedUserID = ID
                        .Show()
                    End With
                Next
                Me.Close()
            Else
                MsgBox("Invalid Username or Password", vbCritical, title)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Are you sure you want to Cancel?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub RadTextBox1_Enter(sender As Object, e As EventArgs) Handles RadTextBox1.Enter
        If RadTextBox1.Text = "Username" Then
            RadTextBox1.Text = ""
            RadTextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadTextBox1_Leave(sender As Object, e As EventArgs) Handles RadTextBox1.Leave
        If RadTextBox1.Text = "" Then
            RadTextBox1.Text = "Username"
            RadTextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub RadTextBox2_Enter(sender As Object, e As EventArgs) Handles RadTextBox2.Enter
        If RadTextBox2.Text = "Password" Then
            RadTextBox2.Text = ""
            RadTextBox2.ForeColor = Color.Black
            RadTextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub RadTextBox2_Leave(sender As Object, e As EventArgs) Handles RadTextBox2.Leave
        If RadTextBox2.Text = "" Then
            RadTextBox2.Text = "Password"
            RadTextBox2.ForeColor = Color.Gray
            RadTextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub RadTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            RadButton1.PerformClick()
        End If
    End Sub

    Private Sub RadTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles RadTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            RadButton1.PerformClick()
        End If
    End Sub
End Class
