Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Replacements
    Dim adap As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub Replacements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSMDataSet3.sp_leaveApplications' table. You can move, or remove it, as needed.
        'Me.Sp_leaveApplicationsTableAdapter.Fill(Me.SSMDataSet3.sp_leaveApplications)
        'TODO: This line of code loads data into the 'SSMDataSet2.leaveapplications' table. You can move, or remove it, as needed.
        'Me.LeaveapplicationsTableAdapter.Fill(Me.SSMDataSet2.leaveapplications)
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        Dim SqlCmd1 As SqlCommand
        SqlConn.Open()

        If leaveempid = Nothing Then

            MessageBox.Show("Please select an employee to find replacement", "Authentication Error")

        End If
        SqlCmd = New SqlCommand("sp_getempshift", SqlConn)

        SqlCmd.CommandType = CommandType.StoredProcedure

        SqlCmd.Parameters.AddWithValue("@empId", leaveempid)

        SqlCmd.ExecuteNonQuery()

        Dim SqlReader As SqlDataReader = SqlCmd.ExecuteReader
        SqlReader.Read()

        Dim shift As String
        shift = SqlReader.Item(0)
        SqlReader.Close()


        SqlCmd1 = New SqlCommand("sp_replacempavail", SqlConn)
        SqlCmd1.Parameters.AddWithValue("@empShift", shift)
        SqlCmd1.CommandType = CommandType.StoredProcedure


        adap = New SqlDataAdapter()
        adap.SelectCommand = SqlCmd1

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

        avialempid = DataGridView1.Item(0, i).Value


    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnreq_Click(sender As Object, e As EventArgs) Handles btnreq.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        SqlConn.Open()
        Try
            SqlCmd = New SqlCommand("sp_repreq", SqlConn)

            SqlCmd.CommandType = CommandType.StoredProcedure

            Dim lid As String
            lid = avialempid & leavedate

            SqlCmd.Parameters.AddWithValue("@lid", lid)
            SqlCmd.Parameters.AddWithValue("@empId", avialempid)
            SqlCmd.Parameters.AddWithValue("@leavedate", leavedate)
            SqlCmd.Parameters.AddWithValue("@lstatus", "pending")


            SqlCmd.ExecuteScalar()


            MessageBox.Show("Request sent Succesfully", "Relacement Request")

        Catch ex As Exception

            MessageBox.Show("Request cannot be sent", "Replacement Request")

        End Try

        Leave_Applications.Show()
        Me.Close()

    End Sub
End Class