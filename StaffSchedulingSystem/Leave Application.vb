Imports System.Data.SqlClient

Public Class Leave_Application

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand

        ' Open Connection

        SqlConn.Open()

        ' To check if the textbox is empty
        If DateTimePicker1.Text = String.Empty Or
               reasonLeave.Text = String.Empty


            MsgBox("FIELDS CANNOT BE LEFT BLANK")

            Return

        End If

        Try
            SqlCmd = New SqlCommand("sp_leaveapp", SqlConn)

            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.AddWithValue("@leaveDate", DateTimePicker1.Value)
            SqlCmd.Parameters.AddWithValue("@reason", reasonLeave.Text)
            SqlCmd.Parameters.AddWithValue("@empId", EmployeeId)


            SqlCmd.ExecuteScalar()


            MessageBox.Show("Leave Request Submitted Succesfully", "Leave Application")

        Catch ex As Exception

            MessageBox.Show("Error:Record Cannot be added", "Leave Application")

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

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Employee_Home.Show()
        Me.Close()
    End Sub
End Class