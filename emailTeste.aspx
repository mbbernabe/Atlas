<%@ Page Language="C#" %> 
<%@ Import Namespace="System" %> 
<!--Inclui o namespace para envio de emails --> 
<%@ Import Namespace="System.Web.Mail" %> 
<html> 
<script runat="server"> 
public void Page_Load(Object Sender, EventArgs e) 
{ 
 
//Instancia o Objeto Email como MailMessage 
MailMessage Email = new MailMessage(); 
 
//Atribui ao método From o valor do Remetente 
Email.From = "contato@atlasradiodiagnostico.com.br"; 
 
//Atribui ao método To o valor do Destinatário 
Email.To = "contato@atlasradiodiagnostico.com.br"; 
 
//Atribui ao método Cc o valor do com Cópia 
//Email.Cc = "email2@dominio"; 
 
//Atribui ao método Bcc o valor do com Cópia oculta 
//Email.Bcc = "email3@dominio"; 
 
//Atribui ao método Subject o assunto da mensagem 
Email.Subject = "Teste de Envio de mensagens"; 
 
//Define o formato da mensagem que pode ser Texto ou Html 
Email.BodyFormat = MailFormat.Text; 
 
//Atribui ao método Body a texto da mensagem 
Email.Body = "Texto da mensagem"; 
 
//Define qual o host a ser usado para envio de mensagens. Nos planos de Hospedagem da locaweb é smtp2.locaweb.com.br e na Revenda localhost 
SmtpMail.SmtpServer = "smtp.atlasradiodiagnostico.com.br"; 
 
//Envia a mensagem baseado nos dados do objeto Email 
SmtpMail.Send(Email); 
 

 
//Escreve no label que a mensagem foi enviada 
Response.Write("Email enviado com sucesso!"); 
} 
</script> 
</html>
