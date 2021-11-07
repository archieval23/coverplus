Imports MySql.Data.MySqlClient

Module modQueries
    Public Function login(username As String, password As String)
        Try
            Connect()
            Dim cmd As New MySqlCommand("Select * from tbl_user where UserName = @1 and Password = @2", con)
            cmd.Parameters.AddWithValue("@1", username)
            cmd.Parameters.AddWithValue("@2", password)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox("Check your Server or Contact your System Adminisrator", vbInformation)
            Return Nothing
        End Try
    End Function

    Public Function saveNewCustomer(cfname As String, clname As String, cmname As String, address As String, email As String, cnumber As String, bday As DateTime, age As Integer, gender As String, hname As String, typeoftest As Integer, clinicianname As String, datetested As DateTime)
        Try
            Connect()
            Dim com As New MySqlCommand("Insert into tbl_customer(FirstName,LastName,MiddleName,Address,Email,ContactNumber,Birthday,Age,Gender,DateAdded)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10);SELECT LAST_INSERT_ID()", con)
            With com
                .Parameters.AddWithValue("@1", cfname)
                .Parameters.AddWithValue("@2", clname)
                .Parameters.AddWithValue("@3", cmname)
                .Parameters.AddWithValue("@4", address)
                .Parameters.AddWithValue("@5", email)
                .Parameters.AddWithValue("@6", cnumber)
                .Parameters.Add("@7", OleDb.OleDbType.Date).Value = bday
                .Parameters.AddWithValue("@8", age)
                .Parameters.AddWithValue("@9", gender)
                .Parameters.Add("@10", OleDb.OleDbType.Date).Value = Now
                '.Parameters.AddWithValue("@11", EncrptData(guid))
            End With
            Dim lastID As Integer = CInt(com.ExecuteScalar)
            'Dim fullname As String = clname & "-" & cfname
            'Dim codeToEncrpt = String.Format("CV-{0}-{1}", fullname, lastID)

            'Dim comUpdate As New MySqlCommand("update tbl_customer set EncrptedKey = @1 where ID = @2", con)
            'With comUpdate
            '    .Parameters.AddWithValue("@1", EncrptData(codeToEncrpt))
            '    .Parameters.AddWithValue("@2", lastID)
            '    .ExecuteNonQuery()
            'End With

            Dim comM As New MySqlCommand("Insert into tbl_medicalDetails(CustomerID,HospitalName,TestType,ClinicianName,DateTested)VALUES(@1,@2,@3,@4,@5)", con)
            With comM
                .Parameters.AddWithValue("@1", lastID)
                .Parameters.AddWithValue("@2", hname)
                .Parameters.AddWithValue("@3", typeoftest)
                .Parameters.AddWithValue("@4", clinicianname)
                .Parameters.Add("@5", OleDb.OleDbType.Date).Value = datetested
                .ExecuteNonQuery()
            End With

            'Dim cmdLastID As New MySqlCommand("select MAX(ID) from tbl_customer", con)
            'Dim lastID As Integer
            'lastID = cmdLastID.ExecuteScalar
            'Dim testresult As String
            'If result = "Negative" Then
            '    testresult = "SARS-CoV-2 (causative agent of Covid-19) viral RNA not detected"
            'Else
            '    testresult = "SARS-CoV-2 (causative agent of Covid-19) viral RNA detected"
            'End If

            'Dim cmdInsert As New MySqlCommand("Insert into tbl_swabissuance(CustomerID,TestName,TestResult,TestInterpretation)VALUES(@1,@2,@3,@4)", con)
            'With cmdInsert
            '    .Parameters.AddWithValue("@1", lastID)
            '    .Parameters.AddWithValue("@2", typeoftest)
            '    .Parameters.AddWithValue("@3", testresult)
            '    .Parameters.AddWithValue("@4", result)
            '    .ExecuteNonQuery()
            'End With

            Return True
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function loadCustomerMod()
        Try
            Connect()
            Dim cmd As New MySqlCommand("select a.ID, Concat(a.LastName, ' ,', a.FirstName) as FullName, a.Address, a.Email, a.ContactNumber, a.Birthday, a.Age, d.TestName, b.Result 
            from tbl_customer a 
            inner join tbl_medicalDetails b on a.ID = b.CustomerID 
            inner join tbl_testType d on b.TestType = d.ID
            left join tbl_swabissuance c on a.ID = c.CustomerID order by a.ID desc", con)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function loadCustomerDropMod()
        Try
            Connect()
            Dim cmd As New MySqlCommand("select ID, CONCAT(LastName, ', ', FirstName) AS FullName from tbl_customer order by Lastname", con)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function loadTestTypeDropMod()
        Try
            Connect()
            Dim cmd As New MySqlCommand("select ID, TestName from tbl_testType where Status = 1 order by TestName", con)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function loadSwabIssuanceResultMod(id As Integer)
        Try
            Connect()
            Dim cmd As New MySqlCommand("select CONCAT(a.LastName, ', ', a.FirstName) AS FullName, d.TestName, b.TestResult, b.TestInterpretation, b.DateSpecimenCollected 
            from tbl_customer a 
            INNER JOIN tbl_medicalDetails c on a.ID = c.CustomerID
            INNER JOIN tbl_testType d on c.TestType = d.ID
            INNER JOIN tbl_swabissuance b on a.ID = b.CustomerID where a.ID = @1 order by a.ID desc", con)
            With cmd
                .Parameters.AddWithValue("@1", id)
            End With
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function loadCustomerResultDistributionMod()
        Try
            Connect()
            Dim cmd As New MySqlCommand("select a.ID, CONCAT(a.LastName, ', ', a.FirstName) AS FullName, a.Email, a.gender, b.SwabIssuanceCode, c.TestName, b.TestResult, b.TestInterpretation, b.DateSpecimenCollected 
            from tbl_customer a 
            INNER JOIN tbl_swabissuance b on a.ID = b.CustomerID 
            INNER JOIN tbl_medicalDetails d on a.ID = d.CustomerID
            INNER JOIN tbl_testType c on d.TestType = c.ID 
            where d.Result IN ('Positive','Negative') order by a.ID desc", con)
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function loadSwabIssuanceResultforReportMod(id As Integer)
        Try
            Connect()
            Dim cmd As New MySqlCommand("select a.ID, CONCAT(a.FirstName, ' ', a.MiddleName, ' ', a.LastName) AS FullName, a.address, a.contactnumber, a.gender, c.TestName, d.TestResult, d.TestInterpretation, d.DateSpecimenCollected, b.hospitalname, b.clinicianname, b.datetested 
            from tbl_customer a 
            INNER JOIN tbl_medicalDetails b on a.ID = b.CustomerID
            INNER JOIN tbl_testType c on b.TestType = c.ID
            INNER JOIN tbl_swabissuance d on a.ID = d.CustomerID 
            where a.ID = @1 order by a.ID desc", con)
            With cmd
                .Parameters.AddWithValue("@1", id)
            End With
            Dim dt As New DataTable
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function deleteCustomerMod(id As Integer)
        Try
            Connect()
            Dim com1 As New MySqlCommand("delete from tbl_customer where ID = @1", con)
            With com1
                .Parameters.AddWithValue("@1", id)
                .ExecuteNonQuery()
            End With

            Dim com2 As New MySqlCommand("delete from tbl_swabissuance where CustomerID = @1", con)
            With com2
                .Parameters.AddWithValue("@1", id)
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function saveCustomerResult(result As String, datespecimen As DateTime, CustomerID As Integer, userLogged As Integer)
        Try
            Connect()
            Dim com As New MySqlCommand("Update tbl_medicalDetails set Result = @1 where CustomerID = @2;
            SELECT TestType from tbl_medicalDetails where CustomerID = @2", con)
            With com
                .Parameters.AddWithValue("@1", result)
                .Parameters.AddWithValue("@2", CustomerID)
            End With
            Dim testTypeID As Integer = CInt(com.ExecuteScalar)

            Dim testresult As String
            If result = "Negative" Then
                testresult = "SARS-CoV-2 (causative agent of Covid-19) viral RNA NOT DETECTED"
            Else
                testresult = "SARS-CoV-2 (causative agent of Covid-19) viral RNA DETECTED"
            End If

            Dim guid As String = System.Guid.NewGuid.ToString()
            Dim swabIssuanceID As String = String.Format("CV-{0}-{1}-{2}-{3}", CustomerID, testTypeID, datespecimen.ToString("MMddyyyy"), result)

            Dim cmdInsert As New MySqlCommand("Insert into tbl_swabissuance(CustomerID,TestResult,TestInterpretation,DateSpecimenCollected,SwabIssuanceCode,UserID)VALUES(@1,@2,@3,@4,@5,@6)", con)
            With cmdInsert
                .Parameters.AddWithValue("@1", CustomerID)
                .Parameters.AddWithValue("@2", testresult)
                .Parameters.AddWithValue("@3", result)
                .Parameters.Add("@4", OleDb.OleDbType.Date).Value = datespecimen
                .Parameters.AddWithValue("@5", swabIssuanceID)
                .Parameters.AddWithValue("@6", userLogged)
                .ExecuteNonQuery()
            End With

            Return True
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Module
