Public Partial Class detfat1
    Inherits System.Web.UI.Page
    Dim CodFat As String
    Dim sqlwhereFat As String
    Dim sqlwhereDetFat As String
    Dim ValorBrutoNota As Decimal
    Dim irrfNota As Decimal
    Dim ValorRec As Decimal
    Dim LinhaFaturamento As DataRow
    Dim Config As New clsConfiguracao(Server)
    Dim socio As New clsSocio()
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection

    'Data Adapter
    Dim daFaturamento As dsDetFatTableAdapters.FATURAMENTOTableAdapter = New dsDetFatTableAdapters.FATURAMENTOTableAdapter
    Dim daTipoDesc As dsDetFatTableAdapters.TIPODESCONTOTableAdapter = New dsDetFatTableAdapters.TIPODESCONTOTableAdapter
    Dim daDetFat As dsDetFatTableAdapters.DETALHEFATURAMENTOTableAdapter = New dsDetFatTableAdapters.DETALHEFATURAMENTOTableAdapter
    Dim daLancDesc As dsDetFatTableAdapters.LANCAMENTO_DESCONTOSTableAdapter = New dsDetFatTableAdapters.LANCAMENTO_DESCONTOSTableAdapter()
    'Data Table
    Dim dtableFaturamento As dsDetFat.FATURAMENTODataTable = New dsDetFat.FATURAMENTODataTable()
    Dim dtDetFat As dsDetFat.DETALHEFATURAMENTODataTable = New dsDetFat.DETALHEFATURAMENTODataTable()
    Dim dtTipoDesc As dsDetFat.TIPODESCONTODataTable = New dsDetFat.TIPODESCONTODataTable()
    Dim vdsDetFat As dsDetFat = New dsDetFat()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        'Me.CboSocio1.Conexão = OleCn
        'Me.CboCliente1.Conexão = OleCn
        socio.oleConexão = OleCn
        If socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If

        Me.grdDetFat.PageSize = Config.TamanhoPaginaGrid
        If Not Page.IsPostBack Then
            ' Me.OleDaCliente.Fill(Me.DsDetFat1, "CLIENTE")
            '  Me.ddlCliente.DataBind()
            ' Me.OleDaSocio.Fill(Me.DsDetFat1, "SOCIO")
            ' Me.ddlSocio.DataBind()
            CodFat = Request.Params("cod")
            If CodFat <> "" Then
                daFaturamento.FillByCodFaturamento(dtableFaturamento, CodFat)
                daTipoDesc.Fill(dtTipoDesc)

                Me.txtData.Text = dtableFaturamento.Item(0).DTFATURAMENTO.ToShortDateString
                Me.txtNota.Text = dtableFaturamento.Item(0).NUMNF.ToString

                Me.txtCodFaturamento.Text = CodFat
                CalcularResumoFaturamento(Me.txtCodFaturamento.Text)
                Me.lblTotalImpostos.Text = FormatCurrency(CalcularTotalImpostos(Me.txtCodFaturamento.Text))
                Me.txtValorBrutoSocio.Text = ""
                desbilitarcampos()
                SetarComboCliente(CodFat)
                PreencherGrid()
            End If
        End If
    End Sub
    Sub SetarComboCliente(ByVal CodFat As String)
        Dim CodCliente As String

        CodCliente = dtableFaturamento.FindByCODFATURAMENTO(CodFat).CODCLIENTE   '.Me.DsDetFat1.FATURAMENTO.FindByCODFATURAMENTO(CodFat).CODCLIENTE
        Me.CboCliente1.SetarCliente = CodCliente
       

    End Sub
    Sub PreencherGrid()
        daDetFat.FillByCodFaturamento(dtDetFat, CodFat)
        Me.grdDetFat.DataSource = dtDetFat
        Me.grdDetFat.DataBind()
    End Sub

    Sub desbilitarcampos()
        Me.txtData.Enabled = False
        Me.CboCliente1.Enabled = False
        Me.txtNota.Enabled = False
    End Sub

    Sub habilitarcampos()
        Me.txtData.Enabled = True
        Me.CboCliente1.Enabled = True
        Me.txtNota.Enabled = True
    End Sub


    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Dim AcessaBanco As New clsAcessaBanco
        Dim cod As String
        Dim TotalImpostos As Decimal
        Dim trans As OleDb.OleDbTransaction
        Try
            If Not Page.IsValid Then
                Return
            End If

            Dim fat As New clsFaturamento

            fat.oleConexão = Me.OleCn
            fat.AbrirConexão(fat.oleConexão)
            If fat.EstaAuditado(Me.txtCodFaturamento.Text) Then
                Response.Write("Operação não permitida - Este faturamento já foi confirmado pelo Administrador.")
                Exit Sub
            End If
            fat.FecharObjetos(fat.oleConexão)
            desbilitarcampos()
            AcessaBanco.AbrirConexão(Me.OleCn)
            trans = OleCn.BeginTransaction()

            If Me.txtCodFaturamento.Text = "" Then
                Me.txtCodFaturamento.Text = AcessaBanco.GerarCodigo
                ' InserirLinhaFaturamento(Me.txtCodFaturamento.Text, Me.ddlCliente.SelectedItem.Value, CDate(Me.txtData.Text), CDec(Me.txtValorBrutoSocio.Text), Me.txtNota.Text, False, trans)
                InserirLinhaFaturamento(Me.txtCodFaturamento.Text, Me.CboCliente1.SelectedItem.Value, CDate(Me.txtData.Text), CDec(Me.txtValorBrutoSocio.Text), Me.txtNota.Text, False, trans)

            End If
            CodFat = Me.txtCodFaturamento.Text
            'cod = ExisteSocioFat(Me.txtCodFaturamento.Text, Me.ddlSocio.SelectedItem.Value)

            ' Sejá existir alguma linha para o sócio, devemos pegar o código e atualizar a linha, caso contrário, inserir uma nova
            cod = ExisteSocioFat(Me.txtCodFaturamento.Text, Me.CboSocio1.SelectedItem.Value)
            If cod <> "" Then
                AtualiazarDetalheFaturamento(cod, CDec(Me.txtValorBrutoSocio.Text), trans)
                trans.Commit()
                PreencherGrid()
                ' Dim sqlwhereFat As String = " where CODFATURAMENTO = '" & Me.txtCodFaturamento.Text & "'"
                ' Me.OleDaDetFatView.SelectCommand.CommandText = Me.OleDaDetFatView.SelectCommand.CommandText & sqlwhereFat
                'Me.OleDaDetFatView.SelectCommand.Transaction = trans
                'Me.OleDaDetFatView.Fill(Me.DsDetFat1, "DETALHEFATURAMENTO")
                'Me.grdDetFat.DataBind()
            Else
                ' InserirDetalheFaturamento(Me.ddlSocio.SelectedItem.Value, CDec(Me.txtValorBrutoSocio.Text), Me.txtCodFaturamento.Text, trans)
                InserirDetalheFaturamento(Me.CboSocio1.SelectedItem.Value, CDec(Me.txtValorBrutoSocio.Text), Me.txtCodFaturamento.Text, trans)

            End If
            trans.Commit()
            AtualizarImpostos("27412010114132533425", _
                              Me.CboSocio1.SelectedItem.Value, _
                              CDate(Me.txtData.Text), _
                              Me.txtCodFaturamento.Text, _
                              CDec(txtValorBrutoSocio.Text), _
                              CDec(txtValorBrutoSocio.Text) - (CDec(txtValorBrutoSocio.Text) * 1.5) / 100)


            CalcularResumoFaturamento(Me.txtCodFaturamento.Text)
            AtualizarFatBruto(ValorBrutoNota, Me.txtCodFaturamento.Text)
            Me.lblTotalImpostos.Text = FormatCurrency(CalcularTotalImpostos(Me.txtCodFaturamento.Text))
            Me.txtValorBrutoSocio.Text = ""
            ' trans.Commit()
        Catch err As Exception
            trans.Rollback()
            Throw err
        Finally
            AcessaBanco.FecharObjetos(Me.OleCn)
        End Try

    End Sub

    Sub AtualizarFatBruto(ByVal FatNota As Decimal, ByVal codFat As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim cn As New OleDb.OleDbConnection

        Try

            sql = "update Faturamento set VALORFATURAMENTOBRUTO = " & Str(FatNota) & " where CODFATURAMENTO = '" & codFat & "'"
            cn.ConnectionString = Me.OleCn.ConnectionString
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            'cmd.Transaction = trans
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try
    End Sub
    Sub InserirLinhaFaturamento(ByVal CODFATURAMENTO As String, ByVal CODCLIENTE As String, _
                                ByVal DTFATURAMENTO As Date, ByVal VALORFATURAMENTOBRUTO As Decimal, _
                                ByVal NUMNF As String, ByVal AUDITADO As Boolean, ByVal trans As System.Data.OleDb.OleDbTransaction)




        Dim linha As dsDetFat.FATURAMENTORow = dtableFaturamento.NewFATURAMENTORow

        linha.CODFATURAMENTO = CODFATURAMENTO
        linha.CODCLIENTE = CODCLIENTE
        linha.DTFATURAMENTO = DTFATURAMENTO
        linha.VALORFATURAMENTOBRUTO = Format(VALORFATURAMENTOBRUTO, "#########0.00")
        linha.NUMNF = NUMNF
        linha.AUDITADO = AUDITADO
        dtableFaturamento.AddFATURAMENTORow(linha)

        'daFaturamento.Transaction = CType(trans, System.Data.SqlClient.SqlTransaction)
        daFaturamento.Update(dtableFaturamento)

    End Sub

    Sub InserirDetalheFaturamento(ByVal CODSOCIO As String, _
                                ByVal VALORBRUTOSOCIO As Decimal, ByVal CODFATURAMENTO As String, ByVal trans As System.Data.OleDb.OleDbTransaction)
        Dim linha As dsDetFat.DETALHEFATURAMENTORow
        Dim Cod As String
        Dim AcessaBanco As New clsAcessaBanco


        'sqlwhereFat = " where CODFATURAMENTO = '" & CODFATURAMENTO & "'"
        ' Me.OleDaDetFatView.SelectCommand.CommandText = Me.OleDaDetFatView.SelectCommand.CommandText & sqlwhereFat
        'Me.OleDaDetFatView.SelectCommand.Transaction = trans
        'Me.OleDaDetFatView.Fill(Me.DsDetFat1, "DETALHEFATURAMENTO")

        Cod = AcessaBanco.GerarCodigo
        linha = dtDetFat.NewDETALHEFATURAMENTORow


        linha.CODFATURAMENTO = CODFATURAMENTO
        linha.CODDETFATURAMENTO = Cod
        linha.CODSOCIO = CODSOCIO
        ' linha("NOME") = Me.ddlSocio.SelectedItem.Text
        'linha("NOME") = Me.CboSocio1.SelectedItem.Text
        linha.VALORBRUTOSOCIO = Format(VALORBRUTOSOCIO, "#########0.00")
        linha.IRRF = Format((VALORBRUTOSOCIO * 1.5) / 100, "##########0.00")
        linha.VALORREC = Format(linha.VALORBRUTOSOCIO - linha.IRRF, "#########0.00")

        dtDetFat.AddDETALHEFATURAMENTORow(linha)

        'Me.DsDetFat1.DETALHEFATURAMENTO.Rows.Add(linha)
        'daDetFat.Transaction = trans
        daDetFat.Update(dtDetFat)
        PreencherGrid()

    End Sub
    Sub AtualizarLinhaFaturamento(ByVal CODFATURAMENTO As String, ByVal CODCLIENTE As String, _
                               ByVal DTFATURAMENTO As Date, ByVal VALORFATURAMENTOBRUTO As Decimal, _
                               ByVal NUMNF As String, ByVal AUDITADO As Boolean)


        Dim linha As dsDetFat.FATURAMENTORow

        linha = dtableFaturamento.FindByCODFATURAMENTO(CODFATURAMENTO)

        linha.CODFATURAMENTO = CODFATURAMENTO
        linha.CODCLIENTE = CODCLIENTE
        linha.DTFATURAMENTO = DTFATURAMENTO
        linha.VALORFATURAMENTOBRUTO = VALORFATURAMENTOBRUTO
        linha.NUMNF = NUMNF
        linha.AUDITADO = AUDITADO
        daFaturamento.Update(dtableFaturamento)
    
    End Sub

    Sub AtualiazarDetalheFaturamento(ByVal CODDETFATURAMENTO As String, ByVal VALORBRUTOSOCIO As Decimal, ByVal trans As OleDb.OleDbTransaction)

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Try
            sql = "update detalhefaturamento set " & _
                                  " VALORBRUTOSOCIO = " & VALORBRUTOSOCIO & _
                                  ", IRRF = " & TrocaVirgulaPonto(Format((VALORBRUTOSOCIO * 1.5) / 100, "##########0.00")) & _
                                  ", VALORREC = " & TrocaVirgulaPonto(VALORBRUTOSOCIO - (VALORBRUTOSOCIO * 1.5) / 100) & _
                                  " where CODDETFATURAMENTO = '" & CODDETFATURAMENTO & "'"
            ' Me.OleCn.Open()
            cmd.CommandText = sql
            cmd.Connection = Me.OleCn
            cmd.Transaction = trans
            cmd.ExecuteNonQuery()

        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()

        End Try
    End Sub

    Function TrocaVirgulaPonto(ByVal sql As String) As String

        Dim i As Integer
        Dim sqlaux As String = ""
        Dim c As String
        For i = 0 To sql.Length - 1
            c = sql.Substring(i, 1)
            If c = "," Then
                c = "."
            End If
            sqlaux = sqlaux & c
        Next
        Return sqlaux
    End Function

    Function ExisteSocioFat(ByVal CodFat As String, ByVal CodSocio As String) As String
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand
        Dim cn As New OleDb.OleDbConnection
        Dim ret As String
        Try
            cn.ConnectionString = Me.OleCn.ConnectionString
            cn.Open()
            sql = "select * from detalhefaturamento where codfaturamento = '" & CodFat & "' and codsocio = '" & CodSocio & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ret = dr.Item("CODDETFATURAMENTO").ToString
            Else
                ret = ""
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()

        End Try
    End Function



    Sub deletarImpostos(ByVal CodNatDesc As String, ByVal CODDETFATURAMENTO As String, ByVal CodSocio As String, ByVal CodFat As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim cn As New OleDb.OleDbConnection
        Try
            daLancDesc.DeleteLancSocioByCodNatDesc(CodNatDesc, CODDETFATURAMENTO, CodSocio)

            'sql = "delete from LANCAMENTO_DESCONTOS LD, TIPODESCONTO TD where  LD.CODDETFATURAMENTO = '" & CODDETFATURAMENTO & "' AND LD.CODSOCIO = '" & CodSocio & "' AND LD.CODTPDESCONTO = TP.CODTPDESCONTO AND TP.CODNATDESC = '" & CodNatDesc & "'"
            ' cmd.CommandText = sql
            ' cn.ConnectionString = Me.OleCn.ConnectionString
            'cn.Open()
            'cmd.Connection = cn
            'cmd.Transaction = trans
            'cmd.ExecuteNonQuery()
            AtualizarFatBruto(ValorBrutoNota, CodFat)
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try


    End Sub
    Function PegarCodDetFat(ByVal CODSOCIO As String, ByVal CODFATURAMENTO As String) As String
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection
        Dim Resultado As String = ""
        Try
            cn.ConnectionString = Me.OleCn.ConnectionString
            cn.Open()
            ' Pegar o Código do Detalhe do Faturamento
            sql = "select CODDETFATURAMENTO FROM DETALHEFATURAMENTO WHERE CODSOCIO = '" & CODSOCIO & "' AND CODFATURAMENTO = '" & CODFATURAMENTO & "'"
            cmd.CommandText = sql
            cmd.Connection = cn

            dr = cmd.ExecuteReader
            If dr.Read Then
                Resultado = dr.Item("CODDETFATURAMENTO").ToString
            End If
            Return Resultado
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try


    End Function


    Sub AtualizarImpostos(ByVal CODNATDESC As String, _
                          ByVal CODSOCIO As String, _
                          ByVal DATA As String, _
                          ByVal CODFATURAMENTO As String, _
                          ByVal FATBRUTO As Decimal, _
                          ByVal FATREC As Decimal)

        Dim AcessaBanco As New clsAcessaBanco
        Dim linhaTpDesc As DataRow
        Dim LinhaLancDesc As dsDetFat.LANCAMENTO_DESCONTOSRow
        Dim codLancDesconto As String
        Dim CODDETFATURAMENTO As String
        Dim desc As New clsDescontos
        Dim dtLancDescontos As dsDetFat.LANCAMENTO_DESCONTOSDataTable = New dsDetFat.LANCAMENTO_DESCONTOSDataTable()

        Try


            CODDETFATURAMENTO = PegarCodDetFat(CODSOCIO, CODFATURAMENTO)
            deletarImpostos(CODNATDESC, CODDETFATURAMENTO, CODSOCIO, CODFATURAMENTO)
            ' Me.OledaTipoDesconto.SelectCommand.Transaction = trans
            daTipoDesc.FillByCodNatDesc(dtTipoDesc, CODNATDESC)


            'Me.OledaTipoDesconto.Fill(Me.DsDetFat1, "TIPODESCONTO")
            For Each linhaTpDesc In dtTipoDesc.Rows
                codLancDesconto = AcessaBanco.GerarCodigo
                desc.oleConexão = Me.OleCn
                While desc.ExisteLancDesconto(codLancDesconto)
                    codLancDesconto = AcessaBanco.GerarCodigo
                End While
                LinhaLancDesc = dtLancDescontos.NewRow
                LinhaLancDesc.CODSOCIO = CODSOCIO
                LinhaLancDesc.CODLANCDESCONTO = codLancDesconto
                LinhaLancDesc.CODDETFATURAMENTO = CODDETFATURAMENTO
                LinhaLancDesc.CODTPDESCONTO = linhaTpDesc("CODTPDESCONTO")
                LinhaLancDesc.CODLANCDESPESA = ""
                LinhaLancDesc.Mes = Format(Month(DATA), "00")
                LinhaLancDesc.Ano = Year(DATA)
                LinhaLancDesc.USUARIO = User.Identity.Name
                LinhaLancDesc.DTALTERACAO = DATA
                LinhaLancDesc.AUDIDATO = False



                If linhaTpDesc("PERCENTUALVALOR") = False Then
                    LinhaLancDesc("VALORDESCONTO") = linhaTpDesc("VALOR")
                Else
                    If Not IsDBNull(linhaTpDesc("INCPERCENT")) Then
                        If (linhaTpDesc("INCPERCENT") = 1) Then
                            LinhaLancDesc("VALORDESCONTO") = FATBRUTO * (linhaTpDesc("PERCENTUAL") / 100)
                        End If
                        If (linhaTpDesc("INCPERCENT") = 2) Then
                            LinhaLancDesc("VALORDESCONTO") = FATREC * (linhaTpDesc("PERCENTUAL") / 100)
                        End If
                    End If
                End If
                dtLancDescontos.AddLANCAMENTO_DESCONTOSRow(LinhaLancDesc)
                daLancDesc.Update(dtLancDescontos)
            Next


        Catch err As Exception
            Throw err
        End Try
    End Sub


    Function CalcularTotalImpostos(ByVal CODFATURAMENTO As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Resultado As Decimal
        Dim cn As New OleDb.OleDbConnection


        Try
            cn.ConnectionString = Me.OleCn.ConnectionString
            cn.Open()

            sql = " SELECT Sum(LANCAMENTO_DESCONTOS.VALORDESCONTO) AS SomaDeVALORDESCONTO, DETALHEFATURAMENTO.CODFATURAMENTO, TIPODESCONTO.CODNATDESC " & _
                  " FROM DETALHEFATURAMENTO INNER JOIN (TIPODESCONTO INNER JOIN LANCAMENTO_DESCONTOS ON TIPODESCONTO.CODTPDESCONTO = LANCAMENTO_DESCONTOS.CODTPDESCONTO) ON DETALHEFATURAMENTO.CODDETFATURAMENTO = LANCAMENTO_DESCONTOS.CODDETFATURAMENTO " & _
                  " GROUP BY DETALHEFATURAMENTO.CODFATURAMENTO, TIPODESCONTO.CODNATDESC " & _
                  " HAVING (((DETALHEFATURAMENTO.CODFATURAMENTO)= '" & CODFATURAMENTO & "') AND ((TIPODESCONTO.CODNATDESC)='27412010114132533425')) "


            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Resultado = CDec(dr.Item("SomaDeVALORDESCONTO").ToString)
            Else
                Resultado = 0
            End If
            Return Resultado
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Function

    Sub CalcularResumoFaturamento(ByVal CODFATURAMENTO As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection
        Try
            sql = "select sum(VALORBRUTOSOCIO) AS SUMBRUTO, SUM(IRRF) AS SUMIRRF,SUM (VALORREC) AS SUMREC" & _
                  " from DETALHEFATURAMENTO " & _
                  " where CODFATURAMENTO = '" & CODFATURAMENTO & "'"

            cn.ConnectionString = Me.OleCn.ConnectionString
            cn.Open()
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                If dr.Item("SUMBRUTO").ToString <> "" Then
                    ValorBrutoNota = CDec(dr.Item("SUMBRUTO").ToString)
                End If
                If dr.Item("SUMIRRF").ToString <> "" Then
                    irrfNota = CDec(dr.Item("SUMIRRF").ToString)
                End If
                If dr.Item("SUMREC").ToString <> "" Then
                    ValorRec = CDec(dr.Item("SUMREC").ToString)
                End If
            End If

            Me.lblValorBruto.Text = FormatCurrency(ValorBrutoNota)
            Me.lblIRRF.Text = FormatCurrency(irrfNota)
            Me.lblValorRec.Text = FormatCurrency(ValorRec)

        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Sub


    Private Sub grdDetFat_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdDetFat.DeleteCommand
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim fat As New clsFaturamento
        Try

            fat.oleConexão = Me.OleCn
            fat.AbrirConexão(fat.oleConexão)
            If fat.EstaAuditado(Me.txtCodFaturamento.Text) Then
                Response.Write("Operação não permitida - Este faturamento já foi confirmado pelo Administrador.")
                Exit Sub
            End If
            fat.FecharObjetos(fat.oleConexão)
            sql = "delete from detalhefaturamento where codDetFaturamento = '" & e.Item().Cells(0).Text & "'"
            Me.OleCn.Open()
            cmd.CommandText = sql
            cmd.Connection = Me.OleCn
            cmd.ExecuteNonQuery()

            'sqlwhereFat = " where CODFATURAMENTO = '" & Me.txtCodFaturamento.Text & "'"
            'Me.OleDaDetFatView.SelectCommand.CommandText = Me.OleDaDetFatView.SelectCommand.CommandText & sqlwhereFat
            'Me.OleDaDetFatView.Fill(Me.DsDetFat1, "DETALHEFATURAMENTO")
            'Me.grdDetFat.DataBind()
            PreencherGrid()

            Me.OleCn.Close()
            CalcularResumoFaturamento(Me.txtCodFaturamento.Text)

            Me.lblTotalImpostos.Text = CalcularTotalImpostos(Me.txtCodFaturamento.Text).ToString
            Me.txtValorBrutoSocio.Text = ""

        Catch err As Exception
            Throw err
        Finally
            Me.OleCn.Close()
            cmd.Dispose()
        End Try

    End Sub


End Class