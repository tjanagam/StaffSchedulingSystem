Imports System.Data.SqlClient

Public Class Create_Employee





    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        Dim SqlCmd1 As SqlCommand

        ' Open Connection

        SqlConn.Open()

        ' To check if the textbox is empty
        If eID.Text = String.Empty Or
               eName.Text = String.Empty Or
               eUserName.Text = String.Empty Or
               ePassword.Text = String.Empty Or
               ComboBox1.SelectedItem.ToString = String.Empty Then

            MsgBox("FIELDS CANNOT BE LEFT BLANK")

            Return

        End If

        Try
            SqlCmd = New SqlCommand("sp_addemp", SqlConn)

            SqlCmd.CommandType = CommandType.StoredProcedure

            SqlCmd.Parameters.AddWithValue("@eId", eID.Text)
            SqlCmd.Parameters.AddWithValue("@eName", eName.Text)
            SqlCmd.Parameters.AddWithValue("@eUsername", eUserName.Text)
            SqlCmd.Parameters.AddWithValue("@ePassword", ePassword.Text)
            SqlCmd.Parameters.AddWithValue("@eShift", ComboBox1.SelectedItem.ToString)


            SqlCmd.ExecuteScalar()

            SqlCmd1 = New SqlCommand("sp_addemplogin3", SqlConn)

            SqlCmd1.CommandType = CommandType.StoredProcedure

            
            SqlCmd1.Parameters.AddWithValue("@eUsername", eUserName.Text)
            SqlCmd1.Parameters.AddWithValue("@ePassword", ePassword.Text)
            SqlCmd1.Parameters.AddWithValue("@eRole", "emp")


            SqlCmd1.ExecuteScalar()

            MessageBox.Show("Account Created Succesfully", "Add Employee")

        Catch ex As Exception

            MessageBox.Show("Error:Record Cannot be added", "Add Employee")

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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ManagerHome.Show()
        Me.Close()
    End Sub
End Class