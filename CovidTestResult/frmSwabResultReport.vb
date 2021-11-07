Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmSwabResultReport
    Public fullname, address, cnumber, gender As String
    Public testname, testresult, interpretation As String
    Public clinicname, clinicianname, datetested As String
    Public ID As Integer

    Private Sub FrmSwabResultReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim crpt As New crSwabResult
            'crpt.SetParameterValue("test", interpretation.ToUpper())

            Dim tofullname, toaddress, tocnumber, togender As TextObject
            Dim totestname, totestresult, tointerpretation As TextObject
            Dim toclinicname, toclinicianname, todatetested As TextObject

            '#1
            tofullname = crpt.ReportDefinition.ReportObjects("crptName")
            tofullname.Text = fullname

            toaddress = crpt.ReportDefinition.ReportObjects("crptAddress")
            toaddress.Text = address

            tocnumber = crpt.ReportDefinition.ReportObjects("crptCnumber")
            tocnumber.Text = cnumber

            togender = crpt.ReportDefinition.ReportObjects("crptGender")
            togender.Text = gender
            'End #1

            '#2
            totestname = crpt.ReportDefinition.ReportObjects("crptTestName")
            totestname.Text = testname

            totestresult = crpt.ReportDefinition.ReportObjects("crptTestResult")
            totestresult.Text = testresult

            tointerpretation = crpt.ReportDefinition.ReportObjects("crptInterpretation")
            tointerpretation.Text = interpretation
            'End #2

            '#3
            toclinicname = crpt.ReportDefinition.ReportObjects("crptClinicName")
            toclinicname.Text = clinicname

            toclinicianname = crpt.ReportDefinition.ReportObjects("crptClinicianName")
            toclinicianname.Text = clinicianname

            todatetested = crpt.ReportDefinition.ReportObjects("crptDateTested")
            todatetested.Text = datetested
            'End #3

            Dim dtSwabIssuance As DataTable = loadSwabIssuanceResultMod(ID)
            crpt.Database.Tables("SwabIssuance").SetDataSource(dtSwabIssuance)

            crvSwabResult.ReportSource = Nothing
            crvSwabResult.ReportSource = crpt
            crpt.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
