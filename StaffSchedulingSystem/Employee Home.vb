Public Class Employee_Home

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Leave_Application.Show()
        Me.Hide()
    End Sub

    Private Sub Employee_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show(EmployeeId)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        View_Requests.Show()
        Me.Close()
    End Sub
End Class