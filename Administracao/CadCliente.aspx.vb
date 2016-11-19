Public Partial Class cadCliente
    Inherits System.Web.UI.Page

    Protected WithEvents oleCnCliente As System.Data.OleDb.OleDbConnection
    Private CodCliente As String
    Dim Socio As New clsSocio()
    Dim Config As New clsConfiguracao(Server)
    Dim Cliente As New clsCliente()


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            'Put user code to initialize the page here

            Me.oleCnCliente = New System.Data.OleDb.OleDbConnection
            oleCnCliente.ConnectionString = Config.StringConexao
            Socio.oleConexão = oleCnCliente
            If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
                Response.Redirect("AcessoNaoPermitido.aspx")
            End If

            If Not Page.IsPostBack Then
                PreencherDropdow()
                Cliente.oleConexão = Me.oleCnCliente
                'Pegando o Código do Cliente passado por parâmetro
                CodCliente = Request.Params("cod")

                If CodCliente <> "" Then
                    ' Consultar Cliente e preencher com os campos da tela
                    PreencherTela(CodCliente)
                End If
            End If
        Catch err As Exception
            Throw err
        End Try
    End Sub
    Private Sub PreencherDropdow()
        Try
            Dim daTipoLogradouro As dsClienteTableAdapters.TIPOLOGRADOUROTableAdapter = New dsClienteTableAdapters.TIPOLOGRADOUROTableAdapter()
            Dim daUF As dsClienteTableAdapters.UFTableAdapter = New dsClienteTableAdapters.UFTableAdapter()
            Dim daTipoTelefone As dsClienteTableAdapters.TIPOTELEFONETableAdapter = New dsClienteTableAdapters.TIPOTELEFONETableAdapter


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

    Private Sub PreencherTela(ByVal CodCliente As String)
        Dim drCliente As OleDb.OleDbDataReader
        Dim olecmd As New OleDb.OleDbCommand()

        Dim sql As String = "select * from cliente where CodCliente = '" & CodCliente & "'"
        Me.oleCnCliente.Open()
        olecmd.CommandText = sql
        olecmd.Connection = Me.oleCnCliente
        drCliente = olecmd.ExecuteReader()

        'drCliente = Cliente.PesquisarUnicoCliente(CodCliente)
        If drCliente.Read() Then
            Me.TxtCodigo.Text = drCliente.Item("CODCLIENTE").ToString
            Me.txtBairro.Text = drCliente.Item("Bairro").ToString
            Me.txtCEP.Text = drCliente.Item("CEP").ToString
            Me.txtCidade.Text = drCliente.Item("Cidade").ToString
            Me.txtCNPJ.Text = drCliente.Item("CNPJ").ToString
            Me.txtComplemento.Text = drCliente.Item("Complemento").ToString
            Me.txtEmail.Text = drCliente.Item("Email").ToString
            Me.TxtIE.Text = drCliente.Item("IE").ToString
            Me.txtLogradouro.Text = drCliente.Item("Logradouro").ToString
            Me.txtNome.Text = drCliente.Item("Nome").ToString
            Me.txtNumero.Text = drCliente.Item("Numero").ToString
            Me.txtTel1.Text = drCliente.Item("Telefone1").ToString
            Me.txtTel2.Text = drCliente.Item("Telefone2").ToString
            Me.txtTel3.Text = drCliente.Item("Telefone3").ToString
            Me.txtTel4.Text = drCliente.Item("Telefone4").ToString

            Me.txtDDD1.Text = Format(drCliente.Item("DDDTEL1").ToString, )
            Me.txtDDD2.Text = drCliente.Item("DDDTEL2").ToString
            Me.txtDDD3.Text = drCliente.Item("DDDTEL3").ToString
            Me.txtDDD4.Text = drCliente.Item("DDDTEL4").ToString

            ddlTpLograd.SelectedIndex = ddlTpLograd.Items.IndexOf(ddlTpLograd.Items.FindByValue(drCliente.Item("TpLogradouro").ToString))
            ddltipoTel1.SelectedIndex = ddltipoTel1.Items.IndexOf(ddltipoTel1.Items.FindByValue(drCliente.Item("TPTELEFONE1").ToString))
            ddltipoTel2.SelectedIndex = ddltipoTel2.Items.IndexOf(ddltipoTel2.Items.FindByValue(drCliente.Item("TPTELEFONE2").ToString))
            ddltipoTel3.SelectedIndex = ddltipoTel3.Items.IndexOf(ddltipoTel3.Items.FindByValue(drCliente.Item("TPTELEFONE3").ToString))
            ddltipoTel4.SelectedIndex = ddltipoTel4.Items.IndexOf(ddltipoTel4.Items.FindByValue(drCliente.Item("TPTELEFONE4").ToString))
        End If
        Me.oleCnCliente.Close()
        olecmd.Dispose()
    End Sub


    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            Cliente.oleConexão = Me.oleCnCliente
            If Me.TxtCodigo.Text <> "" Then
                Cliente.Update(Me.TxtCodigo.Text, _
                                Me.txtNome.Text, _
                                Me.txtCNPJ.Text, _
                                Me.txtBairro.Text, _
                                Me.txtEmail.Text, _
                                Me.ddlTpLograd.SelectedItem.Value, _
                                Me.txtLogradouro.Text, _
                                Me.txtNumero.Text, _
                                Me.txtComplemento.Text, _
                                Me.txtBairro.Text, _
                                Me.txtCidade.Text, _
                                Me.ddlUF.SelectedItem.Value, _
                                Me.txtCEP.Text, _
                                Me.ddltipoTel1.SelectedItem.Value, _
                                Me.ddltipoTel2.SelectedItem.Value, _
                                Me.ddltipoTel3.SelectedItem.Value, _
                                Me.ddltipoTel4.SelectedItem.Value, _
                                Me.txtTel1.Text, _
                                Me.txtTel2.Text, _
                                Me.txtTel3.Text, _
                                Me.txtTel4.Text, _
                                Me.txtDDD1.Text, _
                                Me.txtDDD2.Text, _
                                Me.txtDDD3.Text, _
                                Me.txtDDD4.Text)
            Else
                Cliente.Insert(Me.txtNome.Text, _
                               Me.txtCNPJ.Text, _
                               Me.txtBairro.Text, _
                               Me.txtEmail.Text, _
                               Me.ddlTpLograd.SelectedItem.Value, _
                               Me.txtLogradouro.Text, _
                               Me.txtNumero.Text, _
                               Me.txtComplemento.Text, _
                               Me.txtBairro.Text, _
                               Me.txtCidade.Text, _
                               Me.ddlUF.SelectedItem.Value, _
                               Me.txtCEP.Text, _
                               Me.ddltipoTel1.SelectedItem.Value, _
                               Me.ddltipoTel2.SelectedItem.Value, _
                               Me.ddltipoTel3.SelectedItem.Value, _
                               Me.ddltipoTel4.SelectedItem.Value, _
                               Me.txtTel1.Text, _
                               Me.txtTel2.Text, _
                               Me.txtTel3.Text, _
                               Me.txtTel4.Text, _
                               Me.txtDDD1.Text, _
                               Me.txtDDD2.Text, _
                               Me.txtDDD3.Text, _
                               Me.txtDDD4.Text)
            End If
        Catch err As Exception
            Throw err
        End Try
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Response.Redirect("ListaClientes.aspx")
    End Sub

End Class