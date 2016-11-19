Public Partial Class CadSocio
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Dim Config As New clsConfiguracao(Server)
    Dim socio As New clsSocio()
    Dim CadSocio As New clsSocio()
    Private CodSocio As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.OleCn = New System.Data.OleDb.OleDbConnection
            OleCn.ConnectionString = Config.StringConexao

            'Put user code to initialize the page here
            OleCn.ConnectionString = Config.StringConexao
            Socio.oleConexão = OleCn

            CadSocio.oleConexão = OleCn
            If socio.NivelAcesso(User.Identity.Name) <> 1 Then
                Response.Redirect("AcessoNaoPermitido.aspx")
            End If
            'Put user code to initialize the page here
            If Not Page.IsPostBack Then

                PreencherDropdow()
                CodSocio = Request.Params("cod")
                If CodSocio = "" Then
                    CodSocio = CadSocio.CodPorNomeUsuario(User.Identity.Name)
                End If
                If CodSocio <> "" And CodSocio <> "codnovo" Then
                    ' Consultar Cliente e preencher com os campos da tela
                    PreencherTela(CodSocio)
                End If

            End If
        Catch err As Exception
            Throw err
        End Try
    End Sub

    Private Sub PreencherTela(ByVal CodSocio As String)
        Dim drSocio As OleDb.OleDbDataReader
        Dim olecmd As New OleDb.OleDbCommand()

        Dim sql As String = "select * from Socio where CodSocio = '" & CodSocio & "'"
        Me.OleCn.Open()
        olecmd.CommandText = sql
        olecmd.Connection = Me.OleCn
        drSocio = olecmd.ExecuteReader()


        If drSocio.Read() Then
            Me.TxtCodigo.Text = drSocio.Item("CODSOCIO").ToString
            Me.txtNome.Text = drSocio.Item("Nome").ToString
            Me.txtEmail.Text = drSocio.Item("EMAIL").ToString
            Me.txtCPF.Text = drSocio.Item("CPF").ToString
            Me.TxtIdentidade.Text = drSocio.Item("IDENTIDADE").ToString
            Me.txtCRM.Text = drSocio.Item("CRM").ToString
            Me.txtBanco.Text = drSocio.Item("NUMBANCO").ToString
            Me.txtAgencia.Text = drSocio.Item("AGENCIA").ToString
            Me.txtNomeAcesso.Text = drSocio.Item("NOMEUSUARIO").ToString
            ' Me.txtSenha.Text = drSocio.Item("Senha").ToString

            'Me.txtConfSenha.Text = drSocio.Item("Senha").ToString
            Me.txtConta.Text = drSocio.Item("CONTA").ToString
            Me.txtLogradouro.Text = drSocio.Item("Logradouro").ToString
            Me.txtNumero.Text = drSocio.Item("Numero").ToString
            Me.txtComplemento.Text = drSocio.Item("Complemento").ToString
            Me.txtBairro.Text = drSocio.Item("Bairro").ToString
            Me.txtCidade.Text = drSocio.Item("Cidade").ToString
            Me.txtCEP.Text = drSocio.Item("CEP").ToString
            Me.txtTel1.Text = drSocio.Item("Telefone1").ToString
            Me.txtTel2.Text = drSocio.Item("Telefone2").ToString
            Me.txtTel3.Text = drSocio.Item("Telefone3").ToString
            Me.txtTel4.Text = drSocio.Item("Telefone4").ToString
            Me.txtDDD1.Text = Format(drSocio.Item("DDDTEL1").ToString, )
            Me.txtDDD2.Text = drSocio.Item("DDDTEL2").ToString
            Me.txtDDD3.Text = drSocio.Item("DDDTEL3").ToString
            Me.txtDDD4.Text = drSocio.Item("DDDTEL4").ToString
            ddlTpLograd.SelectedIndex = ddlTpLograd.Items.IndexOf(ddlTpLograd.Items.FindByValue(drSocio.Item("TpLogradouro").ToString))
            ddltipoTel1.SelectedIndex = ddltipoTel1.Items.IndexOf(ddltipoTel1.Items.FindByValue(drSocio.Item("TPTELEFONE1").ToString))
            ddltipoTel2.SelectedIndex = ddltipoTel2.Items.IndexOf(ddltipoTel2.Items.FindByValue(drSocio.Item("TPTELEFONE2").ToString))
            ddltipoTel3.SelectedIndex = ddltipoTel3.Items.IndexOf(ddltipoTel3.Items.FindByValue(drSocio.Item("TPTELEFONE3").ToString))
            ddltipoTel4.SelectedIndex = ddltipoTel4.Items.IndexOf(ddltipoTel4.Items.FindByValue(drSocio.Item("TPTELEFONE4").ToString))
            Me.ddlUF.SelectedIndex = ddlUF.Items.IndexOf(ddlUF.Items.FindByValue(drSocio.Item("UF").ToString))

            'Preencher a foto
            '  Me.fotoSocio.ImageUrl = System.Configuration.ConfigurationSettings.AppSettings("CaminhoFoto").ToString & CodSocio

            '     Me.fotoSocio.ImageUrl = "/ImagingRio2/" & System.Configuration.ConfigurationSettings.AppSettings("CaminhoFoto").ToString & "hernandes.jpg"  'CadSocio.nomeUsuario & ".jpg"  '& CadSocio.codSocio & CadSocio.nomeUsuario 



        End If
        Me.OleCn.Close()
        olecmd.Dispose()
    End Sub

    Private Sub PreencherDropdow()
        Try
            Dim daTipoTelefone As dsSocioTableAdapters.TIPOTELEFONETableAdapter = New dsSocioTableAdapters.TIPOTELEFONETableAdapter()
            Dim daTipoLogradouro As dsSocioTableAdapters.TIPOLOGRADOUROTableAdapter = New dsSocioTableAdapters.TIPOLOGRADOUROTableAdapter()
            Dim daUF As dsSocioTableAdapters.UFTableAdapter = New dsSocioTableAdapters.UFTableAdapter()


            Me.ddlTpLograd.DataSource = daTipoLogradouro.GetData()
            Me.ddlUF.DataSource = daUF.GetData()


            Me.ddltipoTel1.DataSource() = daTipoTelefone.GetData()
            Me.ddltipoTel2.DataSource() = daTipoTelefone.GetData()
            Me.ddltipoTel3.DataSource() = daTipoTelefone.GetData()
            Me.ddltipoTel4.DataSource() = daTipoTelefone.GetData()

            Me.ddlTpLograd.DataBind()
            Me.ddlUF.DataBind()
            Me.ddltipoTel1.DataBind()
            Me.ddltipoTel2.DataBind()
            Me.ddltipoTel3.DataBind()
            Me.ddltipoTel4.DataBind()
        Catch err As Exception
            Throw err
        End Try
    End Sub




    Protected Sub btnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviar.Click
        Dim cadSocio As New clsSocio()
        cadSocio.oleConexão = OleCn

        Try

            If Me.txtSenha.Text <> "" And Me.txtConfSenha.Text = "" Then
                lblMessagePersonalizada.Text = "É necessário confirmar a senha."
                lblMessagePersonalizada.Visible = True
                Exit Sub
            End If
            lblMessagePersonalizada.Visible = False
            cadSocio.codSocio = Me.TxtCodigo.Text
            cadSocio.nome = Me.txtNome.Text
            cadSocio.email = Me.txtEmail.Text

            cadSocio.nomeUsuario = Me.txtNomeAcesso.Text
            cadSocio.identidade = Me.TxtIdentidade.Text
            cadSocio.cpf = Me.txtCPF.Text
            cadSocio.crm = Me.txtCRM.Text
            cadSocio.tplogradouro = Me.ddlTpLograd.SelectedItem.Value
            cadSocio.logradouro = Me.txtLogradouro.Text
            cadSocio.numero = Me.txtNumero.Text
            cadSocio.complemento = Me.txtComplemento.Text
            cadSocio.cidade = Me.txtCidade.Text
            cadSocio.bairro = Me.txtBairro.Text
            cadSocio.uf = Me.ddlUF.SelectedItem.Value
            cadSocio.cep = Me.txtCEP.Text
            cadSocio.telefone1 = Me.txtTel1.Text
            cadSocio.telefone2 = Me.txtTel2.Text
            cadSocio.telefone3 = Me.txtTel3.Text
            cadSocio.telefone4 = Me.txtTel4.Text

            cadSocio.tpTelefone1 = Me.ddltipoTel1.SelectedItem.Value
            cadSocio.tpTelefone2 = Me.ddltipoTel2.SelectedItem.Value
            cadSocio.tpTelefone3 = Me.ddltipoTel3.SelectedItem.Value
            cadSocio.tpTelefone4 = Me.ddltipoTel4.SelectedItem.Value

            cadSocio.dddtel1 = Me.txtDDD1.Text
            cadSocio.dddtel2 = Me.txtDDD2.Text
            cadSocio.dddtel3 = Me.txtDDD3.Text
            cadSocio.dddtel4 = Me.txtDDD4.Text

            cadSocio.numBanco = Me.txtBanco.Text
            cadSocio.agencia = Me.txtAgencia.Text
            cadSocio.usuario = Me.User.Identity.Name
            cadSocio.conta = Me.txtConta.Text

            cadSocio.senha = Me.txtSenha.Text

            cadSocio.dtAlteracao = Now()

            If Me.TxtCodigo.Text <> "" Then
                cadSocio.Update()
            Else
                cadSocio.Insert()
            End If

            'If Not (File1.PostedFile Is Nothing) Then
            '    Dim nomeArq As String = System.AppDomain.CurrentDomain.BaseDirectory & _
            '    System.Configuration.ConfigurationSettings.AppSettings("CaminhoFoto").ToString & cadSocio.nomeUsuario & ".jpg"
            '    '& cadSocio.codSocio & cadSocio.nomeUsuario
            '    File1.PostedFile.SaveAs(nomeArq)
            'End If
            'Me.fotoSocio.ImageUrl = "/ImagingRio2/" & System.Configuration.ConfigurationSettings.AppSettings("CaminhoFoto").ToString & cadSocio.nomeUsuario & ".jpg"   ' & cadSocio.codSocio & cadSocio.nomeUsuario
            'Response.Write("Atualização de dados realizada com sucesso.")

        Catch err As Exception
            Throw err
        End Try



    End Sub
End Class