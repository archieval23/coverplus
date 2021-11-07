Imports MySql.Data.MySqlClient

Module modConnection
    'Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\db_covidtest.accdb")

    'Public con As New MySqlConnection("Server = 184.168.113.203; Database = db_coverplus; Uid = root; Pwd =''; SSL Mode=None;")
    Public con As New MySqlConnection("Server = 184.168.113.203; Database = db_coverplus; Uid = coverplus_user; Pwd ='P@ssw0rd_coverplus'; SSL Mode=None;")

    Public title As String = "Covid Test Result"
    Public Sub Connect()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                con.Open()
            Else
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
