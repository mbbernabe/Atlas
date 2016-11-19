Public Partial Class TipoOutrasRemu
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection

    Const NomeTabela As String = "TIPO_REMUNERACAO"
    Const NomeCampoCodigo As String = "CODTPREMUNERACAO"
    Const NomeCampoDescrição As String = "DESCTPREMUNERACAO"

    Dim Config As New clsConfiguracao(Server)
    Dim Socio As New clsSocio()
    Dim codDesc As New clsCodDescricao()



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Put user code to initialize the page here
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCn
        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid
        codDesc.NomeTabela = NomeTabela
        codDesc.CampoCodigo = NomeCampoCodigo
        codDesc.CampoDescrição = NomeCampoDescrição
        codDesc.oleConexão = OleCn
        If Not Page.IsPostBack Then
            PreencherGrid()
        End If
    End Sub
    ' Preenche a grid da tela com os dados do bd
    Private Sub PreencherGrid()

        'Novo Código
        Dim daTpOutraRemuneracao As dsFaturamentoTableAdapters.TIPO_REMUNERACAOTableAdapter = New dsFaturamentoTableAdapters.TIPO_REMUNERACAOTableAdapter()


        Me.grd.DataSource = daTpOutraRemuneracao.GetData
        Me.grd.DataBind()
        Me.OleCn.Close()


    End Sub
    ' Exibe mensagens na tela
    Private Sub ExibirMensagem(ByVal msg As String)
        Response.Write(msg)
    End Sub

    'Inclui um item na grid
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        If Me.txtIncluir.Text.Trim <> "" Then
            If Not codDesc.ExistePorDescrição(Me.txtIncluir.Text) Then
                codDesc.Insert(Me.txtIncluir.Text)
                Me.txtIncluir.Text = ""
                PreencherGrid()
            Else
                ExibirMensagem("Item já existe na lista")
            End If
        End If
    End Sub



    Private Sub grd_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.EditCommand
        grd.EditItemIndex = e.Item.ItemIndex
        PreencherGrid()
        ' grd.DataBind()
    End Sub

    Private Sub grd_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.CancelCommand
        grd.EditItemIndex = -1
        PreencherGrid()
    End Sub





    Private Sub grd_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.UpdateCommand
        Dim Codigo As String
        Dim dsc As String
        Dim auxTextBox As TextBox
        Codigo = e.Item.Cells(0).Text()
        auxTextBox = CType(e.Item.Cells(1).Controls(0), TextBox)
        dsc = auxTextBox.Text
        codDesc.Update(dsc, Codigo)
        grd.EditItemIndex = -1
        PreencherGrid()
    End Sub

    Private Sub grd_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.ItemCommand
        Try
            Select Case e.CommandName
                Case "Delete"
                    codDesc.oleConexão = Me.OleCn
                    codDesc.Excluir(e.Item().Cells(0).Text)
                    PreencherGrid()
            End Select
        Catch Err As OleDb.OleDbException
            Select Case Err.ErrorCode
                Case -2147467259
                    ExibirMensagem("Não foi possível excluir o item, pois está relacionada à outros itens.")
            End Select
        Catch Err As Exception
            ExibirMensagem(Err.Message.ToString)
        End Try
    End Sub


End Class