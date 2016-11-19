Public Partial Class DescontosValoresDiferentes
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Dim Socio As New clsSocio
    Dim Config As New clsConfiguracao(Server)
    Dim daSocio As dsSocioTableAdapters.SOCIOTableAdapter = New dsSocioTableAdapters.SOCIOTableAdapter()
    Dim daNaturDesc As dsListaDescontosTableAdapters.NATUREZADESCONTOTableAdapter = New dsListaDescontosTableAdapters.NATUREZADESCONTOTableAdapter()
    Dim daTipoDesc As dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter = New dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCn

        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid
        'Me.sqlTpDesc = Me.OleDaTipoDesconto.SelectCommand.CommandText
        If Not Page.IsPostBack Then
            PreencherGrid()
            Me.txtAno.Text = Year(Now())
        End If

    End Sub

    Private Sub PreencherGrid()
        Me.grd.DataSource = daSocio.GetDataNaoExcluido()
        Me.grd.DataBind()

        ' Me.OleCn.Open()
        ' Me.OleDbSelectCommand1.CommandText = sqlSelect & sqlWhere & sqlOrderBy
        ' Me.OleDaSocio.Fill(Me.DsSocio1, "Socio")
        ' Me.OleCn.Close()
        'Me.grd.DataBind()
        MontarComboNatDesconto()

    End Sub

    Sub MontarComboNatDesconto()
        '  OleCn.Open()
        Me.ddlNatDesconto.DataSource = daNaturDesc.GetData
        Me.ddlNatDesconto.DataBind()
        MontarComboTipoDesconto(Me.ddlNatDesconto.SelectedItem.Value)
        '  OleCn.Close()
    End Sub


    Sub MontarComboTipoDesconto(ByVal CodNatDesconto As String)

        Me.ddlTipoDesconto.DataSource = Me.daTipoDesc.GetDataByNaturzaDesconto(CodNatDesconto)
        Me.ddlTipoDesconto.DataBind()

    End Sub

    Private Sub ddlNatDesconto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlNatDesconto.SelectedIndexChanged
        MontarComboTipoDesconto(Me.ddlNatDesconto.SelectedItem.Value)
    End Sub

    Private Sub btnGerarDescontos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarDescontos.Click
        Dim i As Integer
        Dim Valor As Decimal
        Dim desc As New clsDescontos
        Dim IncPercent As String
        Dim trans As OleDb.OleDbTransaction
        Dim gravou As Boolean = False


        Try
            Me.OleCn.Open()
            desc.oleConexão = Me.OleCn
            trans = Me.OleCn.BeginTransaction()
            desc.Usuário = User.Identity.Name
            desc.Transação = trans
            If Page.IsValid Then
                For i = 0 To grd.Items.Count - 1
                    'inserir descontos
                    If IsNumeric(CType(Me.grd.Items(i).Cells(2).Controls(1), TextBox).Text) Then
                        Valor = CDec(CType(Me.grd.Items(i).Cells(2).Controls(1), TextBox).Text)
                        desc.InserirDesconto(cboMes1.MesSelecionado, Me.txtAno.Text, Me.ddlTipoDesconto.SelectedItem.Value, grd.Items(i).Cells(0).Text, Valor)
                        gravou = True

                    End If
                    grd.Items(i).Cells(2).Text = ""
                Next
            End If
            trans.Commit()
            Me.OleCn.Close()
            If gravou Then
                Response.Write("Descontos gerados com sucesso")
            End If
        Catch ex As Exception
            trans.Rollback()
            Response.Write("Houve problemas ao tentar gerar os descontos.<br>Os descontos não foram gerados.")
            Throw ex

        End Try
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Response.Redirect("Descontos.aspx")
    End Sub

End Class