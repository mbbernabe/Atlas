Imports System.Web.Mail

Public Class Email

    Sub enviar(ByVal email As String, ByVal assunto As String, ByVal comment As String)

        '##--------------------------------------------------------------------
        '##  Envio de Emails pelo SMTP Autênticado usando CDO usando o ASP.NET
        '##--------------------------------------------------------------------
        '# Mais informações sobre as possiveis bibliotecas são encontradas no link:
        '#   http://msdn.microsoft.com/library/en-us/dncdsys/html/cdo_roadmap.asp
        '#
        '# Documentação do CDO pode ser encontrada no link:
        '#   http://msdn.microsoft.com/library/en-us/dnanchor/html/collabdataobjects.asp
        '#
        '# Para ler sobre as possiveis configurações do objeto de configuração, acesse:
        '#   http://msdn.microsoft.com/library/en-us/cdosys/html/_cdosys_schema_configuration.asp
        '#   http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cdosys/html/_cdosys_imessage_interface.asp
        '#
        '# IMPORTANTE
        '# O codigos de erros estão documentados em:
        '#   http://msdn.microsoft.com/library/en-us/cdosys/html/_cdosys_error_codes.asp
        '#
        '# Para ler sobre a comparação do CDO com CDONTS acesse:
        '#   http://support.microsoft.com/default.aspx?scid=kb;en-us;177850
        '##--------------------------------------------------------------------

        Dim objMail As New MailMessage

        Dim uEmail As String
        Dim uAssunto As String
        Dim uComment As String
        Dim sch As String

        uEmail = email
        uAssunto = assunto
        uComment = comment

        ' Definindo uma variavel auxiliar
        sch = "http://schemas.microsoft.com/cdo/configuration/"

        objMail.From = "contato@atlasradiodiagnostico.com.br"

        ' Utilize esta opção caso deseje definir o e-mail de resposta
        '  objMail.ReplyTo = "EMailDeResposta@DominioDeResposta.com"

        objMail.To = uEmail
        objMail.Subject = uAssunto
        objMail.BodyFormat = MailFormat.HTML
        objMail.Body = uComment

        objMail.Fields(sch & "sendusing") = 2
        objMail.Fields(sch & "smtpauthenticate") = 1
        System.Web.Mail.SmtpMail.SmtpServer = "smtp.atlasradiodiagnostico.com.br"
        objMail.Fields(sch & "sendusername") = "contato@atlasradiodiagnostico.com.br"
        objMail.Fields(sch & "sendpassword") = "admin#2010"

        System.Web.Mail.SmtpMail.Send(objMail)

    End Sub

End Class
