Imports System.Data.SqlClient
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Username.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Password.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RegistrationTableAdapter As New database_app_1.Database1DataSet.RegistrationTableAdapter

        ' Create a new row.
        Dim newRegistration As Database1DataSet.RegistrationRow
        newRegistration = Me.Database1DataSet._Registration.NewRegistrationRow()
        newRegistration.fullName = fullname.Text
        newRegistration.userName = Username.Text
        newRegistration.password = Password.Text

        ' Add the row to the Region table
        Me.Database1DataSet._Registration.Rows.Add(newRegistration)

        ' Save the new row to the database
        Me.RegistrationTableAdapter.Update(Me.Database1DataSet._Registration)
    End Sub
End Class
