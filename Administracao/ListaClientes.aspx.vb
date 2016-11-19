Public Partial Class listaClientes
    Inherits System.Web.UI.Page
    Dim Socio As New clsSocio()
    Dim Config As New clsConfiguracao(Server)
    Protected WithEvents OleCnCliente As System.Data.OleDb.OleDbConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Put user code to initialize the page here
        Me.OleCnCliente = New System.Data.OleDb.OleDbConnection
        OleCnCliente.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCnCliente

        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grdCliente.PageSize = Config.TamanhoPaginaGrid
        If Not Page.IsPostBack Then
            PreencherGrid()
        End If
    End Sub
    Protected Sub grdCliente_PageIndexChanged(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs)
        grdCliente.CurrentPageIndex = e.NewPageIndex
        If Me.txtNome.Text = "" Then
            PreencherGrid()
        Else
            PreencherGrid(Me.txtNome.Text)
        End If

    End Sub

    Private Sub PreencherGrid()
        Me.OleCnCliente.Open()
        Dim daCliente As dsClienteTableAdapters.CLIENTETableAdapter = New dsClienteTableAdapters.CLIENTETableAdapter()
        Me.grdCliente.DataSource = daCliente.GetData()
        Me.grdCliente.DataBind()
    End Sub

    Private Sub PreencherGrid(ByVal nome As String)
        Me.OleCnCliente.Open()
        Dim daCliente As dsClienteTableAdapters.CLIENTETableAdapter = New dsClienteTableAdapters.CLIENTETableAdapter()
        Me.grdCliente.DataSource = daCliente.GetDataPorNome("%" & nome & "%")
        Me.grdCliente.DataBind()
    End Sub

    Protected Sub grdCliente_DeleteCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs)
        Dim cliente As New clsCliente()
        Try
            cliente.oleConexão = Me.OleCnCliente
            cliente.Excluir(e.Item().Cells(0).Text)
            PreencherGrid()
            Response.Write("O Cliente " & e.Item.Cells(1).Text & " foi excluido com sucesso.")
        Catch Err As OleDb.OleDbException
            Response.Write(Err.Message.ToString)
        Catch Err As Exception
            Response.Write(Err.Message.ToString)
        End Try
    End Sub

    Private Sub btnAplicarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarFiltro.Click

        PreencherGrid(Me.txtNome.Text.Trim)
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Response.Redirect("CadCliente.aspx")
    End Sub

End Class