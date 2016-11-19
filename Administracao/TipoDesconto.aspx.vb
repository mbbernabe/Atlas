Public Partial Class TipoDesconto1
    Inherits System.Web.UI.Page

    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
#Region "Minhas Declarações"
    Dim strMensagem As String
    Dim TpDesc As New clsTipoDesconto()
    Protected sqlSelect As String = "Select * from TipoDesconto"
    Protected sqlOrderBy As String = " Order by NOMTPDESCONTO "
    Protected sqlWhere As String
    Dim socio As New clsSocio()
    Dim Config As New clsConfiguracao(Server)

#End Region


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Put user code to initialize the page here
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        socio.oleConexão = OleCn
        If socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid

        If Not Page.IsPostBack Then
            CarregarDados()
            'Me.ddwNaturezaDesconto.DataBind()
        End If
    End Sub

    Sub CarregarDados()

        Dim daNatDesconto As dsTipoDescontoTableAdapters.NATUREZADESCONTOTableAdapter = New dsTipoDescontoTableAdapters.NATUREZADESCONTOTableAdapter()
        Dim daTipoDesconto As dsTipoDescontoTableAdapters.TIPODESCONTOTableAdapter = New dsTipoDescontoTableAdapters.TIPODESCONTOTableAdapter()

        'Carregando dados da Combo
        Me.ddwNaturezaDesconto.DataSource = daNatDesconto.GetDataNaoDepreciado
        ddwNaturezaDesconto.DataBind()

    End Sub

    Private Sub PreencherGrid(ByVal codNatDesconto As String)

      
        Dim daTipoDesconto As dsTipoDescontoTableAdapters.TIPODESCONTOTableAdapter = New dsTipoDescontoTableAdapters.TIPODESCONTOTableAdapter()
        grd.DataSource = daTipoDesconto.GetDataNaoDepreciadoByCodNatDesc(codNatDesconto)
        grd.DataBind()

        ExibirStatus()
    End Sub
    Private Sub btnSelNatDesconto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelNatDesconto.Click
        PreencherGrid(Me.ddwNaturezaDesconto.Items(Me.ddwNaturezaDesconto.SelectedIndex).Value)
    End Sub
    Private Sub bntNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntNovo.Click
        Response.Redirect("cadTipoDesconto.aspx")
    End Sub
    Private Sub grd_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grd.PageIndexChanged
        grd.CurrentPageIndex = e.NewPageIndex
        PreencherGrid(Me.ddwNaturezaDesconto.Items(Me.ddwNaturezaDesconto.SelectedIndex).Value)
    End Sub

    Private Sub grd_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.DeleteCommand
        Dim tpDesc As New clsTipoDesconto
        tpDesc.oleConexão = Me.OleCn
        tpDesc.Excluir(e.Item().Cells(1).Text)
        PreencherGrid(Me.ddwNaturezaDesconto.Items(Me.ddwNaturezaDesconto.SelectedIndex).Value)
    End Sub

    Private Sub grd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd.SelectedIndexChanged

    End Sub
    Sub ExibirStatus()
        Me.lblPaginaCorrente.Text = "Página:" & Me.grd.CurrentPageIndex + 1 & " de " & Me.grd.PageCount
    End Sub

End Class