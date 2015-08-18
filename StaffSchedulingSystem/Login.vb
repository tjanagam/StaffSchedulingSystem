Imports System.Data.Sql
Imports System.Data.SqlClient

Public Module Globals
    Public EmployeeId As String = ""
    Public leavedate As String = ""
    Public leaveempid As String = ""
    Public reason As String = ""
    Public avialempid As String = ""
End Module

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim SqlConn As New SqlConnection With {.ConnectionString = "Data Source= MOUNA; Database= SSM ; Integrated Security=  True "}

        Dim SqlCmd As SqlCommand
        Dim SqlCmd1 As SqlCommand

        ' Open Connection

        SqlConn.Open()

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then

            MessageBox.Show("Please enter valid credential", "Authentication Error")

        End If

        SqlCmd = New SqlCommand("sp_AccountDetails", SqlConn)

        SqlCmd.CommandType = CommandType.StoredProcedure

        SqlCmd.Parameters.AddWithValue("@cUsername", txtUsername.Text)
        SqlCmd.Parameters.AddWithValue("@cPassword", txtPassword.Text)

        SqlCmd.ExecuteNonQuery()

        Dim SqlReader As SqlDataReader = SqlCmd.ExecuteReader
        SqlReader.Read()
        ' Check if Username and Password is valid
        'MsgBox(SqlReader.Item(2))
        'SqlReader.Item
        If SqlReader.HasRows Then

            Dim test As String
            test = SqlReader.Item(2)

            SqlReader.Close()
            If (test = "Admin     ") Then
                ManagerHome.Show()
                Me.Hide()

            Else
                SqlCmd1 = New SqlCommand("sp_getEid", SqlConn)

                SqlCmd1.CommandType = CommandType.StoredProcedure

                SqlCmd1.Parameters.AddWithValue("@Username", txtUsername.Text)


                SqlCmd1.ExecuteNonQuery()

                Dim SqlReader1 As SqlDataReader = SqlCmd1.ExecuteReader
                SqlReader1.Read()
                EmployeeId = SqlReader1.Item(0)

                Employee_Home.Show()
                '' Me.Close()
                Me.Hide()
            End If

        Else
            MessageBox.Show("Not Authenticated", "Login Attempt")

        End If

            ' Check if Username or Password is empty

            ' to Clear all Text fields
            Dim T As Control

            For Each T In Me.Controls

                If TypeOf T Is TextBox Then

                    T.Text = Nothing

                End If

            Next


            Try

            Catch ex As Exception

                MsgBox(ex.Message)

        End Try


    End Sub

   
    Private Sub btnViewJobs_Click(sender As Object, e As EventArgs) Handles btnViewJobs.Click
        Application_Page.Show()
        Me.Hide()
    End Sub
End Class
