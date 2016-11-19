Public Partial Class IncPadraoDesc1
    Inherits System.Web.UI.Page
#Region "Minhas Declarações"

    Dim oleCn As New OleDb.OleDbConnection()
    Dim TpDesc As New clsTipoDesconto()
    Dim CodDescSel As String
    Dim CodDesc As String
    Dim Config As New clsConfiguracao(Server)
    Dim socio As New clsSocio()
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        oleCn.ConnectionString = Config.StringConexao
        socio.oleConexão = oleCn
        If socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        If Not Page.IsPostBack Then
            CodDescSel = Request.Params("CodDesc")
            'If CodDespSel <> "" Then
            CarregarDados(CodDescSel)
            'End If
        End If
    End Sub
#Region "Preencher Tela"

    Sub CarregarDados(ByVal CodDesc As String)
        TpDesc.AbrirConexão(oleCn)
        TpDesc.oleConexão = Me.oleCn
        PreencherComboDesconto(CodDesc)
        PreencherListas(Me.ddwTipoDesconto.SelectedItem.Value)
        TpDesc.FecharObjetos(oleCn)
    End Sub

    Sub PreencherComboDesconto(ByVal CodDesc As String)
        Dim ls As ListItemCollection
        Dim item As ListItem
        ls = TpDesc.MontarTipoDescontos("", "NOMTPDESCONTO")
        Me.ddwTipoDesconto.Items.Clear()
        For Each item In ls
            Me.ddwTipoDesconto.Items.Add(item)
        Next
        Me.ddwTipoDesconto.SelectedIndex = Me.ddwTipoDesconto.Items.IndexOf(Me.ddwTipoDesconto.Items.FindByValue(CodDesc))
    End Sub

    Sub PreencherListas(ByVal CodDesc As String)
        Dim lsItemIncidente As ListItemCollection
        Dim lsItemNaoIncidente As ListItemCollection
        Dim Item As ListItem
        lsItemIncidente = TpDesc.Incidencia(CodDesc)
        lsItemNaoIncidente = TpDesc.NãoIncidencia(CodDesc)
        lsInc.Items.Clear()
        For Each Item In lsItemIncidente
            lsInc.Items.Add(Item)
        Next
        lsNaoInc.Items.Clear()
        For Each Item In lsItemNaoIncidente
            lsNaoInc.Items.Add(Item)
        Next
    End Sub
#End Region



#Region "Botões de Manipulação de Listas Dupla"

    Private Sub btnVaiUm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaiUm.Click
        Dim item As ListItem
        Dim i As Integer
        For Each item In lsNaoInc.Items
            If item.Selected Then
                Me.lsInc.Items.Add(item)
            End If

        Next
        i = 0
        While i <= lsNaoInc.Items.Count - 1
            If lsNaoInc.Items.Item(i).Selected Then
                lsNaoInc.Items.Remove(lsNaoInc.Items.Item(i))
            Else
                i = i + 1
            End If
        End While
        TpDesc.AbrirConexão(oleCn)
        TpDesc.oleConexão = Me.oleCn
        Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        TpDesc.FecharObjetos(oleCn)


    End Sub

    Private Sub btnVoltaUm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltaUm.Click
        Dim item As ListItem
        Dim i As Integer
        For Each item In lsInc.Items
            If item.Selected Then
                Me.lsNaoInc.Items.Add(item)
            End If
        Next
        i = 0
        While i <= lsInc.Items.Count - 1
            If lsInc.Items.Item(i).Selected Then
                lsInc.Items.Remove(lsInc.Items.Item(i))
            Else
                i = i + 1
            End If
        End While
        TpDesc.AbrirConexão(oleCn)
        TpDesc.oleConexão = Me.oleCn
        Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        TpDesc.FecharObjetos(oleCn)

    End Sub

    Private Sub btnVaiTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaiTodos.Click
        Dim item As ListItem
        Dim i As Integer
        For Each item In lsNaoInc.Items
            Me.lsInc.Items.Add(item)
        Next
        Me.lsNaoInc.Items.Clear()
        TpDesc.AbrirConexão(oleCn)
        TpDesc.oleConexão = Me.oleCn
        Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        TpDesc.FecharObjetos(oleCn)
    End Sub

    Private Sub btnVoltaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltaTodo.Click
        Dim item As ListItem
        For Each item In lsInc.Items
            Me.lsNaoInc.Items.Add(item)
        Next
        Me.lsInc.Items.Clear()

        TpDesc.AbrirConexão(oleCn)
        TpDesc.oleConexão = Me.oleCn
        Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        TpDesc.FecharObjetos(oleCn)
    End Sub

#End Region

    Private Sub ddwTipoDesconto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddwTipoDesconto.SelectedIndexChanged
        CarregarDados(Me.ddwTipoDesconto.SelectedItem.Value)
    End Sub
End Class

