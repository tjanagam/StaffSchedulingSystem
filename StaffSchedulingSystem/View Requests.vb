Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class View_Requests


    Dim adap As New SqlDataAdapter
    Dim dt As New DataTable
    Dim eid As String
    Dim ldate As String
    Private Sub View_Requests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        SqlConn.Open()
        SqlCmd = New SqlCommand("sp_reqavail", SqlConn)
        SqlCmd.Parameters.AddWithValue("@empId", EmployeeId)
        SqlCmd.CommandType = CommandType.StoredProcedure


        adap = New SqlDataAdapter()
        adap.SelectCommand = SqlCmd

        Dim builder As New SqlCommandBuilder(adap)
        'adap.InsertCommand = builder.GetInsertCommand()
        'adap.UpdateCommand = builder.GetUpdateCommand()
        'adap.DeleteCommand = builder.GetDeleteCommand()

        dt = New DataTable()
        adap.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub dtgContactList_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        DataGridView1.Rows(e.RowIndex).Selected = True

        eid = DataGridView1.Item(1, i).Value
        ldate = DataGridView1.Item(2, i).Value


    End Sub

    Private Sub btnaccept_Click(sender As Object, e As EventArgs) Handles btnaccept.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        SqlConn.Open()
        Try
            SqlCmd = New SqlCommand("sp_updatereq", SqlConn)

            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.AddWithValue("@empId", eid)
            SqlCmd.Parameters.AddWithValue("@ldate", ldate)
            SqlCmd.Parameters.AddWithValue("@lstatus", "accepted")


            SqlCmd.ExecuteScalar()


            MessageBox.Show("Request Accepted Succesfully", "Relacement Request")

        Catch ex As Exception

            MessageBox.Show("Acceptance cannot be sent", "Replacement Request")

        End Try


    End Sub

    Private Sub btnreject_Click(sender As Object, e As EventArgs) Handles btnreject.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        SqlConn.Open()
        Try
            SqlCmd = New SqlCommand("sp_updatereq", SqlConn)

            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.AddWithValue("@empId", eid)
            SqlCmd.Parameters.AddWithValue("@ldate", ldate)
            SqlCmd.Parameters.AddWithValue("@lstatus", "rejected")


            SqlCmd.ExecuteScalar()


            MessageBox.Show("Request Rejected Succesfully", "Relacement Request")

        Catch ex As Exception

            MessageBox.Show("Acceptance cannot be sent", "Replacement Request")

        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Employee_Home.Show()
        Me.Close()
    End Sub
End Class