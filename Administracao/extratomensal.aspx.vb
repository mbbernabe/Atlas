Public Partial Class extratomensal
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection

    Dim daSocio As dsExtratoMensalTableAdapters.SOCIOTableAdapter = New dsExtratoMensalTableAdapters.SOCIOTableAdapter
    Dim daNatDesc As dsExtratoMensalTableAdapters.NATUREZADESCONTOTableAdapter = New dsExtratoMensalTableAdapters.NATUREZADESCONTOTableAdapter
    Dim daDetFat As dsExtratoMensalTableAdapters.DETALHEFATURAMENTOTableAdapter = New dsExtratoMensalTableAdapters.DETALHEFATURAMENTOTableAdapter
    Dim daCliente As dsExtratoMensalTableAdapters.CLIENTETableAdapter = New dsExtratoMensalTableAdapters.CLIENTETableAdapter
    Dim daFaturamento As dsExtratoMensalTableAdapters.FATURAMENTOTableAdapter = New dsExtratoMensalTableAdapters.FATURAMENTOTableAdapter
    Dim daTipoDesconto As dsExtratoMensalTableAdapters.TIPODESCONTOTableAdapter = New dsExtratoMensalTableAdapters.TIPODESCONTOTableAdapter
    Dim daLancDesconto As dsExtratoMensalTableAdapters.LANCAMENTO_DESCONTOSTableAdapter = New dsExtratoMensalTableAdapters.LANCAMENTO_DESCONTOSTableAdapter
    Dim daOutraRemu As dsFaturamentoTableAdapters.OUTRAS_REMUNERACOESTableAdapter = New dsFaturamentoTableAdapters.OUTRAS_REMUNERACOESTableAdapter()

    Dim dtNatDesc As dsExtratoMensal.NATUREZADESCONTODataTable = New dsExtratoMensal.NATUREZADESCONTODataTable

    Dim Config As New clsConfiguracao(Server)
    Dim socio As New clsSocio()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        socio.oleConexão = OleCn
        If User.Identity.Name = "Contador" Then 'And socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("../Contador/default.aspx")
        End If

        If Not Page.IsPostBack Then


            Me.ddlSocio.DataSource = daSocio.GetData
            Me.ddlSocio.DataBind()
            Me.ddlSocio.SelectedIndex = Me.ddlSocio.Items.IndexOf(ddlSocio.Items.FindByValue(socio.CodPorNomeUsuario(Me.User.Identity.Name)))
            If socio.NivelAcesso(User.Identity.Name) <> 1 Then
                Me.ddlSocio.Enabled = False
            End If
            PreencherComboMes()
            Me.txtAno.Text = Year(Now())

        End If
    End Sub
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        MontarTotais()
        CarregarFaturamento()
        CarregarDescontos()
        Me.lblMesAno.Text = Me.ddlMes.SelectedItem.Value & "/" & Me.txtAno.Text
    End Sub


    Sub MontarTotais()
        Dim vDescTot As New ArrayList
        Dim Desc As New clsDescontos
        Dim fat As New clsFaturamento
        Dim dtrow As DataRow
        Dim Valor As Decimal
        Dim NatDesc As String
        Dim AcumalaOutrosDescontos As Decimal
        Dim FaturamentoBruto As Decimal
        Dim dtOutrasRemuneracoes As dsFaturamento.OUTRAS_REMUNERACOESDataTable = New dsFaturamento.OUTRAS_REMUNERACOESDataTable()

        Dim SaldoParcial As Decimal
        Dim totIRRF As Decimal
        Dim TotalOutrasRemuneraçoes As Decimal = 0
        AcumalaOutrosDescontos = 0

        'Defininco Conexões 
        fat.oleConexão = Me.OleCn
        Desc.oleConexão = Me.OleCn


        daOutraRemu.FillByMesAnoSocio(dtOutrasRemuneracoes, Me.ddlSocio.SelectedItem.Value, Me.ddlMes.SelectedItem.Value, Me.txtAno.Text)

        Dim myRow As dsFaturamento.OUTRAS_REMUNERACOESRow
        For Each myRow In dtOutrasRemuneracoes.Rows
            TotalOutrasRemuneraçoes = TotalOutrasRemuneraçoes + myRow.VALOR
        Next myRow


        FaturamentoBruto = FormatCurrency(fat.SomarFaturamentoBruto(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        SaldoParcial = FormatCurrency(fat.SomarValorRec(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        SaldoParcial = SaldoParcial
        totIRRF = FormatCurrency(fat.SomarIRRF(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))

        'Carrega Lista de Natureza de Desconto
        daNatDesc.FillByNaoDepreciado(dtNatDesc, Me.txtAno.Text, Me.ddlMes.SelectedItem.Value)

        For Each dtrow In dtNatDesc.Rows
            If (IsDBNull(dtrow("IMPOSTO"))) Then
                Valor = Desc.TotalizarNatDesconto(dtrow("CodNatDesc"), _
                                                  Me.ddlMes.SelectedItem.Value, _
                                                  Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, _
                                                  CDec(IIf(Me.lblFatBruto.Text = "", "0", Me.lblFatBruto.Text)), _
                                                  CDec(IIf(Me.lblSubSaldoParcial.Text = "", "0", Me.lblSubSaldoParcial.Text)), _
                                                  CDec(IIf(Me.lblTotMenosImpostos.Text = "", "0", Me.lblTotMenosImpostos.Text)))
                NatDesc = dtrow("DscNatDesc")
                If Valor > 0 Then
                    vDescTot.Add(New ValorNatDesconto(NatDesc, Valor))
                    AcumalaOutrosDescontos = AcumalaOutrosDescontos + Valor
                End If
            Else
                If dtrow("IMPOSTO") <> True Then   '  diferente de imposto     'CDec(IIf(Me.lblFatBruto.Text = "", "0", Me.lblFatBruto.Text))
                    Valor = Desc.TotalizarNatDesconto(dtrow("CodNatDesc"), _
                                                      Me.ddlMes.SelectedItem.Value, _
                                                      Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, _
                                                      FaturamentoBruto, _
                                                      CDec(IIf(Me.lblSubSaldoParcial.Text = "", "0", Me.lblSubSaldoParcial.Text)), _
                                                      CDec(IIf(Me.lblTotMenosImpostos.Text = "", "0", Me.lblTotMenosImpostos.Text)))
                    NatDesc = dtrow("DscNatDesc")
                    If Valor > 0 Then
                        vDescTot.Add(New ValorNatDesconto(NatDesc, Valor))
                        AcumalaOutrosDescontos = AcumalaOutrosDescontos + Valor
                    End If


                End If
            End If


        Next

        Me.lblImpostos.Text = FormatCurrency(Desc.TotalizarValorNatDesconto("27412010114132533425", Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblTotOutrosDescontos.Text = FormatCurrency(AcumalaOutrosDescontos)

        Me.lblSubSaldoParcial.Text = FormatCurrency(SaldoParcial, 2)  'FormatCurrency(fat.SomarValorRec(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblFatBruto.Text = FormatCurrency(FaturamentoBruto, 2) 'FormatCurrency(fat.SomarFaturamentoBruto(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblIRRF.Text = FormatCurrency(totIRRF, 2) 'FormatCurrency(fat.SomarIRRF(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))

        Me.lblTotMenosImpostos.Text = FormatCurrency(CDec(Me.lblSubSaldoParcial.Text) - CDec(IIf(Me.lblImpostos.Text = "", "0", Me.lblImpostos.Text)))


        Me.lblOutrasRemuneracoes.Text = FormatCurrency(TotalOutrasRemuneraçoes, 2)

        Me.lblTotal.Text = FormatCurrency(CDec(IIf(Me.lblTotMenosImpostos.Text = "", "0", Me.lblTotMenosImpostos.Text)) + TotalOutrasRemuneraçoes, 2)

        Me.lblTotFinal.Text = FormatCurrency(CDec(IIf(Me.lblTotal.Text = "", "0", Me.lblTotal.Text)) - AcumalaOutrosDescontos, 2)   'Me.lblTotFinal.Text = FormatCurrency(CDec(IIf(Me.lblTotMenosImpostos.Text = "", "0", Me.lblTotMenosImpostos.Text)) - AcumalaOutrosDescontos)




        Repeater1.DataSource = vDescTot
        Repeater1.DataBind()







        'Me.lblImpostos.Text = FormatCurrency(Desc.TotalizarImpostos(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
     


    End Sub

    Sub CarregarDescontos()

        'Me.carregarNaturezaDesconto("CODNATDESC <> '01'")
        '  Me.grdOutrosDescontos.DataSource = daNatDesc.GetDataByNaoDepreciadoImposto(Me.txtAno.Text, Me.ddlMes.SelectedItem.Value, False)
        Me.grdOutrosDescontos.DataSource = daNatDesc.GetDataByNaoDepreciado(Me.txtAno.Text, Me.ddlMes.SelectedItem.Value)

        Me.grdOutrosDescontos.DataBind()

    End Sub


    Sub CarregarFaturamento()
        grd.DataSource = Me.daDetFat.GetDataBySocioMesAno(Me.ddlSocio.SelectedItem.Value, Me.ddlMes.SelectedItem.Value, Me.txtAno.Text)
        grd.DataBind()
    End Sub
    Sub PreencherComboMes()
        'Dim lsMes As ListItemCollection
        Dim Mes As ListItem

        Mes = New ListItem
        Mes.Text = "Janeiro"
        Mes.Value = "01"
        Me.ddlMes.Items.Add(Mes)
        'lsMes.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Fevereiro"
        Mes.Value = "02"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Março"
        Mes.Value = "03"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Abril"
        Mes.Value = "04"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Maio"
        Mes.Value = "05"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Junho"
        Mes.Value = "06"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Julho"
        Mes.Value = "07"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Agosto"
        Mes.Value = "08"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Setembro"
        Mes.Value = "09"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Outubro"
        Mes.Value = "10"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Novembro"
        Mes.Value = "11"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem
        Mes.Text = "Dezembro"
        Mes.Value = "12"
        Me.ddlMes.Items.Add(Mes)

        Me.ddlMes.SelectedIndex = Month(Now()) - 1


    End Sub
    Function NomeCliente(ByVal CodCliente As String) As String
        Return daCliente.GetData.FindByCODCLIENTE(CodCliente).NOME
    End Function

    Function FaturamentoBruto(ByVal CodDetFat As String) As Decimal
        Dim ret As Decimal
        ret = daDetFat.GetData().FindByCODDETFATURAMENTO(CodDetFat).VALORBRUTOSOCIO
        Return ret
    End Function

    Function IRRF(ByVal CodDetFat As String) As Decimal
        Dim ret As Decimal
        ret = daDetFat.GetData().FindByCODDETFATURAMENTO(CodDetFat).IRRF
        Return ret
    End Function

    Function FaturamentoLiquido(ByVal CodDetFat As String) As Decimal
        Dim ret As Decimal
        ret = daDetFat.GetData().FindByCODDETFATURAMENTO(CodDetFat).VALORREC
        Return ret
    End Function


    Private Sub grdOutrosDescontos_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdOutrosDescontos.ItemDataBound
        Dim vDescTot As ArrayList
        Dim r As Repeater
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            ' Informações de Faturamento
            CType(e.Item.Cells(2).Controls(1), Label).Text = e.Item.Cells(1).Text

            vDescTot = CarregarOutrosDescontosDTR(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, e.Item.Cells(0).Text)

            If vDescTot.Count > 0 Then
                CType(e.Item.Cells(2).FindControl("Repeater2"), Repeater).DataSource = vDescTot
                CType(e.Item.Cells(2).FindControl("Repeater2"), Repeater).DataBind()
            Else
                e.Item.Visible = False
            End If

        End If
    End Sub



    Function CarregarOutrosDescontosDTR(ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal CodNatDesc As String) As ArrayList
        Dim vDescTot As New ArrayList
        Dim Desc As New clsDescontos
        Dim fat As New clsFaturamento
        Dim dtTipoDesconto As dsExtratoMensal.TIPODESCONTODataTable = New dsExtratoMensal.TIPODESCONTODataTable
        fat.oleConexão = Me.OleCn
        Desc.oleConexão = Me.OleCn

        daTipoDesconto.FillByCodNatDesc(dtTipoDesconto, CodNatDesc)

        Dim dtrow As DataRow
        Dim Valor As Decimal
        Dim TipoDesc As String
        Dim AcumalaOutrosDescontos As Decimal

        AcumalaOutrosDescontos = 0
        For Each dtrow In dtTipoDesconto.Rows  'Me.DsExtratoMensal1.TIPODESCONTO.Rows
            Valor = Desc.TotalizarTipoDesconto(dtrow("CODTPDESCONTO"), Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, CDec(Me.lblFatBruto.Text), CDec(Me.lblSubSaldoParcial.Text), CDec(Me.lblTotMenosImpostos.Text))
            If Valor > 0 Then
                TipoDesc = dtrow("NOMTPDESCONTO")
                vDescTot.Add(New ValorTipoDesconto(TipoDesc, Valor))
                AcumalaOutrosDescontos = AcumalaOutrosDescontos + Valor
            End If

        Next
        Return vDescTot
    End Function


    'Sub CarregarOutrosDescontos(ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal CodNatDesc As String)
    '    Dim sql As String
    '    Dim sqlold As String
    '    Dim sqlwhere As String


    '    sqlold = Me.OleDaOutrosDescView.SelectCommand.CommandText
    '    sql = Me.OleDaOutrosDescView.SelectCommand.CommandText
    '    sqlwhere = " where Mes = '" & Mes & "' and Ano = '" & Ano & "' and CODSOCIO = '" & CodSocio & "' and CODNATDESC = '" & CodNatDesc & "'"
    '    sql = sql & sqlwhere
    '    Me.OleDaOutrosDescView.SelectCommand.CommandText = sql
    '    Me.DsExtratoMensal1.Descontos_Nao_Vinculados_ao_Faturamento.Clear()
    '    Me.DsExtratoMensal1.Descontos_Nao_Vinculados_ao_Faturamento.Clear()
    '    Me.OleDaOutrosDescView.Fill(Me.DsExtratoMensal1, "Descontos Nao Vinculados ao Faturamento")
    '    Me.OleDaOutrosDescView.SelectCommand.CommandText = sqlold
    'End Sub

    Private Sub grd_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grd.ItemDataBound

        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            ' Informações de Faturamento
            CType(e.Item.Cells(3).Controls(1), Label).Text = NomeCliente(e.Item.Cells(2).Text)
            CType(e.Item.Cells(3).Controls(3), Label).Text = FormatCurrency(FaturamentoBruto(e.Item.Cells(0).Text))
            CType(e.Item.Cells(3).Controls(5), Label).Text = FormatCurrency(IRRF(e.Item.Cells(0).Text))
            CType(e.Item.Cells(3).Controls(7), Label).Text = FormatCurrency(FaturamentoLiquido(e.Item.Cells(0).Text))


            ' Informações dos Impostos

            CType(e.Item.Cells(3).Controls(9), DataGrid).DataSource = Me.daLancDesconto.GetDataByCodDetFat(e.Item.Cells(0).Text)
            CType(e.Item.Cells(3).Controls(9), DataGrid).DataBind()

        End If
    End Sub

    Public Class ValorTipoDesconto

        Private TipoDesc As String
        Private vValor As Decimal

        Public Sub New(ByVal TipoDesc As String, ByVal Valor As Decimal)
            Me.TipoDesc = TipoDesc
            Me.vValor = Valor
        End Sub

        Public ReadOnly Property TipoDesconto() As String
            Get
                Return TipoDesc
            End Get
        End Property

        Public ReadOnly Property Valor() As String
            Get
                Return FormatCurrency(vValor)
            End Get
        End Property
    End Class
    Public Class ValorNatDesconto

        Private NatDesc As String
        Private vValor As Decimal

        Public Sub New(ByVal NatDesc As String, ByVal Valor As Decimal)
            Me.NatDesc = NatDesc
            Me.vValor = Valor
        End Sub

        Public ReadOnly Property NaturezaDesconto() As String
            Get
                Return NatDesc
            End Get
        End Property

        Public ReadOnly Property Valor() As String
            Get
                Return FormatCurrency(vValor)
            End Get
        End Property
    End Class

End Class