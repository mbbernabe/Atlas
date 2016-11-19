Partial Public Class Lista_OutraRemuneracao
    Inherits System.Web.UI.Page

    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection

    Dim sqlwhere As String
    Dim sqlorderby As String
    Dim Config As New clsConfiguracao(Server)
    Dim Socio As New clsSocio

    'Criação dos dataAdapters 


    Dim daSocio As dsListaDescontosTableAdapters.SOCIOTableAdapter = New dsListaDescontosTableAdapters.SOCIOTableAdapter()
    Dim daTpOutraRemuneracao As dsFaturamentoTableAdapters.TIPO_REMUNERACAOTableAdapter = New dsFaturamentoTableAdapters.TIPO_REMUNERACAOTableAdapter()

    Dim daOutraRemuneracao As dsFaturamentoTableAdapters.OUTRAS_REMUNERACOESTableAdapter = New dsFaturamentoTableAdapters.OUTRAS_REMUNERACOESTableAdapter()

    Dim dtOutraRemuneracao As dsFaturamento.OUTRAS_REMUNERACOESDataTable = New dsFaturamento.OUTRAS_REMUNERACOESDataTable



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCn
        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid
        ' Me.grd.Columns(15).Visible = Socio.PermiteAuditar(User.Identity.Name)
        'Me.btnConfCanc.Visible = Socio.PermiteAuditar(User.Identity.Name)


        If Not Page.IsPostBack Then
            daOutraRemuneracao.Fill(dtOutraRemuneracao)
            PreencherCombos()
            Me.txtAno.Text = Year(Today())

        End If
    End Sub
    Sub PreencherCombos()
        'Dim sqlold
        ' PreencherComboAno()
        PreencherComboMes()



        'Preenchendo Combo Socio e Tipo de Desconto
        Me.ddlSocio.DataSource = daSocio.GetData()
        Me.ddlTpOutraRemuneracao.DataSource = daTpOutraRemuneracao.GetData()

        Me.ddlSocio.DataBind()
        Me.ddlTpOutraRemuneracao.DataBind()

    End Sub

    
    Sub PreencherComboMes()

        Dim Mes As ListItem

        Mes = New ListItem
        Mes.Text = "Janeiro"
        Mes.Value = "01"
        Me.ddlmes.Items.Add(Mes)


        Mes = New ListItem
        Mes.Text = "Fevereiro"
        Mes.Value = "02"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Março"
        Mes.Value = "03"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Abril"
        Mes.Value = "04"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Maio"
        Mes.Value = "05"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Junho"
        Mes.Value = "06"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Julho"
        Mes.Value = "07"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Agosto"
        Mes.Value = "08"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Setembro"
        Mes.Value = "09"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Outubro"
        Mes.Value = "10"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Novembro"
        Mes.Value = "11"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Dezembro"
        Mes.Value = "12"
        Me.ddlmes.Items.Add(Mes)




    End Sub

    Sub CarregarDados()

        Try

            'Preenchendo Combo Socio e Tipo de Desconto

            Me.daOutraRemuneracao.FillByMesAnoSocioTpOutraRemuneracao(dtOutraRemuneracao, Me.ddlmes.SelectedItem.Value, CType(IIf(Me.chkFiltrarMes.Checked, 1, 0), Decimal), _
                                                        Me.txtAno.Text, CType(IIf(Me.chkFiltrarAno.Checked, 1, 0), Decimal), _
                                                        Me.ddlSocio.SelectedItem.Value, CType(IIf(Me.chkfiltrarSocio.Checked, 1, 0), Decimal), _
                                                        Me.ddlTpOutraRemuneracao.SelectedItem.Value, CType(IIf(Me.chkFiltrarTpOutraRemuneracao.Checked, 1, 0), Decimal))



            '  acessaBanco.AbrirConexão(OleCn)

            Me.grd.DataSource = dtOutraRemuneracao
            Me.grd.DataBind()


        Catch err As Exception
            Throw err
        Finally
            Me.OleCn.Close()
        End Try
    End Sub


    Function MontarFiltro() As String
        Dim str As String
        str = ""
        If Me.chkFiltrarAno.Checked Then
            str = str & " and ano = '" & Me.txtAno.Text & "'"
        End If
        If Me.chkFiltrarMes.Checked Then
            str = str & " and mes = '" & Me.ddlmes.SelectedItem.Value & "'"
        End If
        If Me.chkfiltrarSocio.Checked Then
            str = str & " and CODSOCIO = '" & Me.ddlSocio.SelectedItem.Value & "'"
        End If
        If Me.chkFiltrarTpOutraRemuneracao.Checked Then
            str = str & " and CODTPDESCONTO = '" & Me.ddlTpOutraRemuneracao.SelectedItem.Value & "'"
        End If
        If str <> "" Then
            str = Mid(str.Trim, 4, str.Length)
            str = " where " & str
        End If
        Return str
    End Function

    Sub PreencherGrid()
        ' If Me.grd.CurrentPageIndex <= 0 Or Me.grd.CurrentPageIndex > Me.grd.PageCount Then
        Me.grd.CurrentPageIndex = 0
        ' End If
        Me.grd.DataBind()
        ExibirStatus()
    End Sub

    Sub ExibirStatus()
        lblPaginaCorrente.Text = "Página:" & Me.grd.CurrentPageIndex + 1 & " de " & Me.grd.PageCount
    End Sub
    Private Sub bntAplicarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntAplicarFiltro.Click
        CarregarDados()
        PreencherGrid()
    End Sub

    Function NomeSocio(ByVal CodSocio As String) As String
        Dim row As DataRow
        Dim ret As String
        Dim daSocio As dsSocioTableAdapters.SOCIOTableAdapter = New dsSocioTableAdapters.SOCIOTableAdapter()
        Dim dtTableSocio As dsSocio.SOCIODataTable = New dsSocio.SOCIODataTable()
        daSocio.Fill(dtTableSocio)
        row = dtTableSocio.FindByCODSOCIO(CodSocio)
        'row = Me.DsListaDescontos1.Tables("SOCIO").Rows.Find(CodSocio)
        If Not row Is Nothing Then
            ret = row("Nome")
        Else
            ret = ""
        End If
        Return ret
    End Function

    Function TipoOutraRemuneracao(ByVal CodTpOutraRemuneracao As String) As String
        Dim row As DataRow
        Dim ret As String

        Dim dtTableTpOutraRemuneracao As dsFaturamento.TIPO_REMUNERACAODataTable = New dsFaturamento.TIPO_REMUNERACAODataTable()

        daTpOutraRemuneracao.Fill(dtTableTpOutraRemuneracao)
        row = dtTableTpOutraRemuneracao.FindByCODTPREMUNERACAO(CodTpOutraRemuneracao)


        If Not row Is Nothing Then
            ret = row("DESCTPREMUNERACAO")
        Else
            ret = ""
        End If
        Return ret
    End Function

    Private Sub grd_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.DeleteCommand

        daOutraRemuneracao.Delete(e.Item.Cells(0).Text)
        CarregarDados()
        PreencherGrid()
       
    End Sub



    Private Sub grd_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grd.ItemDataBound
        ' Dim nvc As NameValueCollection = System.Configuration.ConfigurationManager.GetSection("AtlasRadioDiagnostico/Figuras") 'CType(ConfigurationSettings.GetConfig("Imaging/Figuras"), NameValueCollection)



        If User.Identity.Name = "Contador" Then
            e.Item.Cells(14).Visible = False
            e.Item.Cells(15).Visible = False
        End If

        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.EditItem Then
            CType(e.Item.Cells(3).Controls(1), Label).Text = NomeSocio(e.Item.Cells(2).Text)
            CType(e.Item.Cells(5).Controls(1), Label).Text = TipoOutraRemuneracao(e.Item.Cells(4).Text)
          
        End If
    End Sub

    Private Sub btnExcluirMarcados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExcluirMarcados.Click
        '  Dim desc As New clsDescontos
        Dim i As Integer
        Dim chk As CheckBox
        Try

            For i = 0 To Me.grd.Items.Count - 1
                chk = CType(Me.grd.Items(i).Cells(1).Controls(1), CheckBox)
                ' Verifica se o item está marcado ou foi confirmado 
                daOutraRemuneracao.Delete(Me.grd.Items.Item(i).Cells(0).Text)
            Next
            Me.OleCn.Close()
            CarregarDados()
            PreencherGrid()
        Catch Err As Exception
            Throw Err
       
        End Try
    End Sub

    Protected Sub btnAdicionarOutraRemuneracao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdicionarOutraRemuneracao.Click

        Dim ab As clsAcessaBanco = New clsAcessaBanco()
        daOutraRemuneracao.Insert(ab.GerarCodigo, Me.ddlTpOutraRemuneracao.SelectedValue, ddlSocio.SelectedValue, ddlmes.SelectedValue, Me.txtAno.Text, Me.txtValor.Text, "")
        CarregarDados()
        PreencherGrid()
    End Sub
End Class