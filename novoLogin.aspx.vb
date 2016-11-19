Public Partial Class novoLogin
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Protected WithEvents SqlCn As System.Data.SqlClient.SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        Me.SqlCn = New System.Data.SqlClient.SqlConnection
    End Sub

    Protected Sub btnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviar.Click
        Dim login As New clslogin()
        Dim Config As New clsConfiguracao(Server)
        Try
            ' OleCn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings("StringConexão").ToString & Server.MapPath("\dados\Imaging.mdb")
            OleCn.ConnectionString = Config.StringConexao
            login.oleConexão = Me.OleCn
            ' login.SqlConexão = SqlCn
            If login.ValidaSenha(Me.txtNome.Text, Me.txtSenha.Text) Then
                '    Dim Ticket As New FormsAuthenticationTicket(Me.txtNome.Text, False, 5000)
                lblLoginInvalido.Visible = False
                FormsAuthentication.SetAuthCookie(Me.txtNome.Text, False)
                'Falta ExibirMenuSocio()
                If Me.txtNome.Text = "Contador" Then
                    Me.Response.Redirect("Contador/default.aspx")
                Else
                    If login.NivelAcesso(Me.txtNome.Text) = 1 Or login.NivelAcesso(Me.txtNome.Text) = 2 Then
                        Me.Response.Redirect("Administracao/default.aspx")
                   
                    End If
                End If
            Else
                lblLoginInvalido.Visible = True
            End If
        Catch Err As Exception
            Throw Err
        End Try

    End Sub
End Class