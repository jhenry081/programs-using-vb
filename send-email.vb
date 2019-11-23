Imports System.Net.Mail

'If port 465 brings up an error then use 857 and viceversa
Public Class Form1

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg.Click

    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send.Click

        Try
            Dim server As New SmtpClient
            Dim mail As New MailMessage()

            server.UseDefaultCredentials = False
            'Insert your email credentials here
            server.Credentials = New System.Net.NetworkCredential("", "")
            server.Port = 465
            server.EnableSsl = True
            server.Host = "smtp.gmail.com"


            mail = New MailMessage()
            mail.From = New MailAddress(txtFrom.Text)
            mail.To.Add(txtTo.Text)
            mail.Subject = txtSub.Text
            mail.IsBodyHtml = False
            mail.Body = txtmsg.Text

            server.Send(mail)
            MsgBox("Mail sent")
            txtmsg.Clear()
            txtSub.Clear()
            txtFrom.Clear()
            txtTo.Clear()


        Catch x As Exception
            MsgBox(x.ToString)

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged

    End Sub
End Class
