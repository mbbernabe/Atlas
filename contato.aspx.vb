Public Partial Class contato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviar.Click
        Dim objemail As New Email

        Dim emailDest As String
        Dim assunto As String
        Dim corpoMensagem As String

        emailDest = "contato@atlasradiodiagnopstico.com.br"
        assunto = "Contato pelo site"
        '' Montando a mensagem

        corpoMensagem = "<html><body>"

        corpoMensagem = corpoMensagem & "Nome: " & Me.txtNome.Text & "<br/>"
        corpoMensagem = corpoMensagem & "Empresa: " & Me.txtEmpresa.Text & "<br/>"
        corpoMensagem = corpoMensagem & "Cidade: " & Me.txtCidade.Text & "<br/>"
        corpoMensagem = corpoMensagem & "Estado: " & Me.TxtEstado.Text & "<br/>"
        corpoMensagem = corpoMensagem & "Telefone: " & Me.txtTelefone.Text & "<br/>"
        corpoMensagem = corpoMensagem & "Mensagem: " & Me.txtMensagem.Text & "<br/>"

        corpoMensagem = "</body></html>"


        ' Chamando a função
        objemail.enviar(emailDest, assunto, corpoMensagem)

        ' Me.Label1.Text = " Dentro de instantes você estará recebendo em sua caixa postal um email com as credenciasi para entrar no site."


    End Sub
End Class