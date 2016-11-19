Public Partial Class listaSocio1
    Inherits System.Web.UI.Page

    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Protected sqlSelect As String = "Select * from Socio "
    Protected sqlOrderBy As String = " Order by Nome "
    Protected sqlWhere As String
    Dim Socio As New clsSocio()

    Dim Config As New clsConfiguracao(Server)
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        'Put user code to initialize the page here
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCn

        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid
        If Not Page.IsPostBack Then
            PreencherGrid()
        End If
    End Sub
    Private Sub PreencherGrid(ByVal nome As String)
        Dim daSocio As dsSocioTableAdapters.SOCIOTableAdapter = New dsSocioTableAdapters.SOCIOTableAdapter()
        nome = "%" & nome & "%"
        Me.grd.DataSource = daSocio.GetDataLikeNome(nome)
        Me.grd.DataBind()
    End Sub
    Private Sub PreencherGrid()

        Dim daSocio As dsSocioTableAdapters.SOCIOTableAdapter = New dsSocioTableAdapters.SOCIOTableAdapter()
        Me.grd.DataSource = daSocio.GetData
        Me.grd.DataBind()

    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Response.Redirect("CadSocio.aspx?cod=codnovo")
    End Sub

    Private Sub btnAplicarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarFiltro.Click
        PreencherGrid(Me.txtNome.Text.Trim)
    End Sub


    Private Sub grd_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grd.PageIndexChanged
        grd.CurrentPageIndex = e.NewPageIndex
        If Me.txtNome.Text = "" Then
        Else
            PreencherGrid(Me.txtNome.Text.Trim)
        End If
        PreencherGrid()
    End Sub

    'Private Sub grd_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grd.SortCommand
    '    sqlOrderBy = " ORDER BY " & e.SortExpression
    '    PreencherGrid()
    'End Sub

    Private Sub grd_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.DeleteCommand
        Dim Socio As New clsSocio()
        Dim trechoMensagem As String
        Try
            Socio.oleConexão = Me.OleCn
            If Socio.SocioExluido(e.Item.Cells(0).Text) Then
                Socio.Recuperar(e.Item().Cells(0).Text)
                trechoMensagem = "recuperado"
            Else
                Socio.Excluir(e.Item().Cells(0).Text)
                trechoMensagem = "excluido"
            End If
            PreencherGrid()
            Response.Write("O Sócio " & e.Item.Cells(1).Text & " foi " & trechoMensagem & " com sucesso.")

        Catch Err As OleDb.OleDbException
            Throw err
        Catch Err As Exception
            Throw err
        End Try
    End Sub

    Private Sub grd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grd.SelectedIndexChanged

    End Sub

    Private Sub grd_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grd.ItemDataBound
        Dim rec As ButtonColumn
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.EditItem Then
            If Socio.SocioExluido(e.Item.Cells(0).Text) Then
                e.Item.BackColor = Drawing.Color.DeepSkyBlue()
                e.Item.ForeColor = Drawing.Color.White
            End If

            '  e.Item.Cells(13).Visible = False
            '  e.Item.Cells(14).Visible = False
        End If
    End Sub


End Class