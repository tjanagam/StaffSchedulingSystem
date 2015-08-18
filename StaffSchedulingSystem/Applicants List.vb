Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Applicants_List
    Dim adap As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub Applicants_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSMDataSet1.jobapplicants' table. You can move, or remove it, as needed.
        'Me.JobapplicantsTableAdapter.Fill(Me.SSMDataSet1.jobapplicants)
        DataGridView1.AllowUserToAddRows = True
        DataGridView1.AllowUserToDeleteRows = True


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        adap = New SqlDataAdapter(" select * from [dbo].[jobapplicants]", SqlConn)

        Dim builder As New SqlCommandBuilder(adap)
        adap.InsertCommand = builder.GetInsertCommand()
        adap.UpdateCommand = builder.GetUpdateCommand()
        adap.DeleteCommand = builder.GetDeleteCommand()


        dt = New DataTable()
        adap.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub btndelapp_Click(sender As Object, e As EventArgs) Handles btndelapp.Click
        Try
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
            adap.Update(dt)
        Catch ex As Exception
            MessageBox.Show("Error removing row")
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ManagerHome.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class