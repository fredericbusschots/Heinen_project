Imports System.Net.Mail

Public Module Mailling

    Sub Mail_a_envoyer(de As String, vers As String, objet As String, texte As String, Piece_jointe As Boolean, Optional Path_piece_jointe As String = "")
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("ged@heinen.eu", "heinen")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = "10.0.0.104"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(de)

            Dim adresses() As String
            adresses = vers.Split(";")

            For Each adr As String In adresses
                e_mail.To.Add(adr)
            Next

            e_mail.Subject = objet
            e_mail.IsBodyHtml = False
            e_mail.Body = texte
            If Piece_jointe = True Then
                Dim attachment As Attachment
                attachment = New Attachment(Path_piece_jointe)
                e_mail.Attachments.Add(attachment)
            End If
            Smtp_Server.Send(e_mail)
            Console.WriteLine("Mail Sent")
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
End Module
