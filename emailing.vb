' Importing the necessary libraries, properties and methods needed for enabling mail send through a server
'If port 465 brings up an error then use 587 and viceversa
Imports System.Net.Mail
Public Class Form1

    Private Sub Label3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles msg.Click

    End Sub

    Private Sub Send_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Send.Click

        'Testing the code for errors...
        Try
            'To establish connection between server & application
            Dim server As New SmtpClient
            'To create a way to parse our contents into mail-friendly for,
            Dim mail As New MailMessage

            'To set parameters for the server configuration
            server.Credentials = New Net.NetworkCredential("", "") 'Real email credentials
            server.Port = 587 'Port number which may vary depending on the security used for the connection
            server.EnableSsl = True 'Type of security used
            server.Host = "smtp.gmail.com" 'Name of server host

            'To set the mail contents based on the inputs from the form
            mail = New MailMessage With {
                .From = New MailAddress(txtFrom.Text) 'Sender's email address
            }
            mail.To.Add(txtTo.Text) 'Receipent(s) email address 
            mail.Subject = txtSub.Text 'Subject of the email
            mail.Body = txtmsg.Text 'Body of the email

            server.Send(mail) ' Sending the mail through the server to the e-mail client, in this case: Gmail
            MsgBox("Mail sent") ' Alerting the user that the mail is sent successfully

            'Clearing the form after submitting it
            txtmsg.Clear()
            txtSub.Clear()
            txtFrom.Clear()
            txtTo.Clear()
            ' ...catching the error when it happens
        Catch x As Exception
            ' Alerting what went wrong in-case the program throws an error
            MsgBox(x.ToString)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class