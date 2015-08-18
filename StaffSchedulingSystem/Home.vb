Public Class ManagerHome

    Private Sub SSMHOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnJobsPage_Click(sender As Object, e As EventArgs) Handles btnJobsPage.Click
        JobsPage.Show()
        Me.Close()
    End Sub

    Private Sub btnCrtEmp_Click(sender As Object, e As EventArgs) Handles btnCrtEmp.Click
        Create_Employee.Show()
        Me.Close()
    End Sub

    Private Sub btnLeaveReq_Click(sender As Object, e As EventArgs) Handles btnLeaveReq.Click
        Leave_Applications.Show()
        Me.Close()
    End Sub

    Private Sub btnViewApp_Click(sender As Object, e As EventArgs) Handles btnViewApp.Click
        Applicants_List.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnrepstatus_Click(sender As Object, e As EventArgs) Handles btnrepstatus.Click
        ReplacementStatus.Show()
        Me.Close()
    End Sub
End Class