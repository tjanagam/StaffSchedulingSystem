Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Application_Page

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ApplicatNAme.Click

    End Sub

    Private Sub Application_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSMDataSet.Jobs' table. You can move, or remove it, as needed.
        Me.JobsTableAdapter.Fill(Me.SSMDataSet.Jobs)

    End Sub

    Private Sub jobId_TextChanged(sender As Object, e As EventArgs) Handles jobId.TextChanged

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand

        ' Open Connection

        SqlConn.Open()

        ' To check if the textbox is empty sale price
        If jobId.Text = String.Empty Or
               appName.Text = String.Empty Or
               appPhone.Text = String.Empty Then

            MsgBox("FIELDS CANNOT BE LEFT BLANK")

            Return

        End If

        Try
            SqlCmd = New SqlCommand("sp_applyjob", SqlConn)

            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.AddWithValue("@jobId", jobId.Text)
            SqlCmd.Parameters.AddWithValue("@appName", appName.Text)
            SqlCmd.Parameters.AddWithValue("@appPhone", appPhone.Text)


            SqlCmd.ExecuteScalar()

            MessageBox.Show("Applied Succesfully", "Apply Message")

        Catch ex As Exception

            MessageBox.Show("Error:Record Cannot be added", "Apply Message")

        End Try

        ' To Clear fields


        Dim T As Control

        For Each T In Me.Controls

            If TypeOf T Is TextBox Then

                T.Text = Nothing

            End If

        Next

        SqlConn.Close()
    End Sub

    Private Sub dtgContactList_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        DataGridView1.Rows(e.RowIndex).Selected = True

        jobId.Text = DataGridView1.Item(0, i).Value


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Form1.Show()
        Me.Close()

    End Sub
End Class