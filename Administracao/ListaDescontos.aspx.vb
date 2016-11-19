Public Partial Class ListaDescontos
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection


    Dim sqlwhere As String
    Dim sqlorderby As String
    Dim Config As New clsConfiguracao(Server)
    Dim Socio As New clsSocio

    'Criação dos dataAdapters 
    Dim daTpDesconto As dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter = New dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter()
    Dim daSocio As dsListaDescontosTableAdapters.SOCIOTableAdapter = New dsListaDescontosTableAdapters.SOCIOTableAdapter()
    Dim daTipoDesconto As dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter = New dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter()
    Dim daLancDescontos As dsListaDescontosTableAdapters.LANCAMENTO_DESCONTOSTableAdapter = New dsListaDescontosTableAdapters.LANCAMENTO_DESCONTOSTableAdapter()

    Dim dtLancDesconto As dsListaDescontos.LANCAMENTO_DESCONTOSDataTable = New dsListaDescontos.LANCAMENTO_DESCONTOSDataTable



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCn
        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid
        Me.grd.Columns(15).Visible = Socio.PermiteAuditar(User.Identity.Name)
        Me.btnConfCanc.Visible = Socio.PermiteAuditar(User.Identity.Name)


        If Not Page.IsPostBack Then
            '  Me.OleCn.Open()
            ' Me.DsListaDescontos1.SOCIO.Clear()
            'Me.OleDaSocio.Fill(Me.DsListaDescontos1, "SOCIO")
            'Me.DsListaDescontos1.TIPODESCONTO.Clear()
            'Me.OleDaTipoDesconto.Fill(Me.DsListaDescontos1, "TIPODESCONTO")
            daLancDescontos.Fill(dtLancDesconto)
            PreencherCombos()
            ' PreencherGrid()
        End If

    End Sub
    Sub PreencherCombos()
        'Dim sqlold
        PreencherComboAno()
        PreencherComboMes()

       

        'Preenchendo Combo Socio e Tipo de Desconto
        Me.ddlSocio.DataSource = daSocio.GetData()
        Me.ddlTpDesconto.DataSource = daTipoDesconto.GetData()

        Me.ddlSocio.DataBind()
        Me.ddlTpDesconto.DataBind()



        'sqlold = Me.OleDaSocio.SelectCommand.CommandText
        'Me.OleDaSocio.SelectCommand.CommandText = Me.OleDaSocio.SelectCommand.CommandText & " order by Nome "
        'Me.DsListaDescontos1.SOCIO.Clear()
        'Me.OleDaSocio.Fill(Me.DsListaDescontos1, "SOCIO")
        'Me.OleDaSocio.SelectCommand.CommandText = sqlold
        'sqlold = Me.OleDaTipoDesconto.SelectCommand.CommandText

        'Me.DsListaDescontos1.TIPODESCONTO.Clear()
        'Me.OleDaTipoDesconto.SelectCommand.CommandText = Me.OleDaTipoDesconto.SelectCommand.CommandText & " order by NomTpDesconto "
        'Me.OleDaTipoDesconto.Fill(Me.DsListaDescontos1, "TIPODESCONTO")
        'Me.OleDaTipoDesconto.SelectCommand.CommandText = sqlold
        'Me.ddlSocio.DataBind()
        Me.ddlTpDesconto.DataBind()
    End Sub
    Sub PreencherComboAno()
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim acb As clsAcessaBanco = New clsAcessaBanco()
        Try

            sql = "select ano from lancamento_descontos group by ano"
            acb.AbrirConexão(Me.OleCn)
            cmd.Connection = Me.OleCn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            While dr.Read
                Me.ddlAno.Items.Add(dr.Item("ano").ToString)
            End While
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            acb.FecharObjetos(OleCn)
        End Try


    End Sub
    Sub PreencherComboMes()
        'Dim lsMes As ListItemCollection
        Dim Mes As ListItem

        Mes = New ListItem
        Mes.Text = "Janeiro"
        Mes.Value = "01"
        Me.ddlmes.Items.Add(Mes)
        'lsMes.Add(Mes)

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


        ' Me.ddlmes.Items = lsMes

    End Sub

    Sub CarregarDados()

        Try
          
            'Preenchendo Combo Socio e Tipo de Desconto
          
            daLancDescontos.FillByMesAnoSocioTpDesc(dtLancDesconto, Me.ddlmes.SelectedItem.Value, CType(IIf(Me.chkFiltrarMes.Checked, 1, 0), Decimal), _
                                                        Me.ddlAno.SelectedItem.Value, CType(IIf(Me.chkFiltrarAno.Checked, 1, 0), Decimal), _
                                                        Me.ddlSocio.SelectedItem.Value, CType(IIf(Me.chkfiltrarSocio.Checked, 1, 0), Decimal), _
                                                        Me.ddlTpDesconto.SelectedItem.Value, CType(IIf(Me.chkFiltrarTpDesconto.Checked, 1, 0), Decimal))

            '  acessaBanco.AbrirConexão(OleCn)

            Me.grd.DataSource = dtLancDesconto
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
            str = str & " and ano = '" & Me.ddlAno.SelectedItem.Value & "'"
        End If
        If Me.chkFiltrarMes.Checked Then
            str = str & " and mes = '" & Me.ddlmes.SelectedItem.Value & "'"
        End If
        If Me.chkfiltrarSocio.Checked Then
            str = str & " and CODSOCIO = '" & Me.ddlSocio.SelectedItem.Value & "'"
        End If
        If Me.chkFiltrarTpDesconto.Checked Then
            str = str & " and CODTPDESCONTO = '" & Me.ddlTpDesconto.SelectedItem.Value & "'"
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

    Function IncDesconto(ByVal CodInc As String) As String
        Dim ret As String
        Select Case CodInc
            Case "1"
                ret = "Fat. Bruto"
            Case "2"
                ret = "Fat. Bruto - IRRF"
            Case "3"
                ret = "Fat. Bruto - Impostos"
        End Select
        Return ret
    End Function

    Function TipoDesconto(ByVal CodTpDesconto As String) As String
        Dim row As DataRow
        Dim ret As String

        Dim dtTableTpDesconto As dsListaDescontos.TIPODESCONTODataTable = New dsListaDescontos.TIPODESCONTODataTable()

        daTpDesconto.Fill(dtTableTpDesconto)
        row = dtTableTpDesconto.FindByCODTPDESCONTO(CodTpDesconto)


        If Not row Is Nothing Then
            ret = row("NOMTPDESCONTO")
        Else
            ret = ""
        End If
        Return ret
    End Function


    Private Sub grd_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grd.ItemDataBound
        ' Dim nvc As NameValueCollection = System.Configuration.ConfigurationManager.GetSection("AtlasRadioDiagnostico/Figuras") 'CType(ConfigurationSettings.GetConfig("Imaging/Figuras"), NameValueCollection)



        If User.Identity.Name = "Contador" Then
            e.Item.Cells(14).Visible = False
            e.Item.Cells(15).Visible = False
        End If

        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Or e.Item.ItemType = ListItemType.EditItem Then
            CType(e.Item.Cells(3).Controls(1), Label).Text = NomeSocio(e.Item.Cells(2).Text)
            CType(e.Item.Cells(5).Controls(1), Label).Text = TipoDesconto(e.Item.Cells(4).Text)
            e.Item.Cells(10).Text = IncDesconto(e.Item.Cells(9).Text)

            Dim img As System.Web.UI.WebControls.Image
            If Auditado(e.Item.Cells(0).Text) And Not Vinculado(e.Item.Cells(0).Text) Then
                CType(e.Item.Cells(14).Controls(1), System.Web.UI.WebControls.Image).ImageUrl = "imagens/checkmrk.gif" ' "imagens/CHECK.gif" ' nvc("check")
            Else
                If Not Vinculado(e.Item.Cells(0).Text) Then
                    CType(e.Item.Cells(14).Controls(1), System.Web.UI.WebControls.Image).ImageUrl = "imagens/icondoc.gif" 'nvc("icondoc")
                Else
                    CType(e.Item.Cells(14).Controls(1), System.Web.UI.WebControls.Image).ImageUrl = "imagens/lock.gif" 'nvc("lock")
                End If
            End If
            If Socio.PermiteAuditar(User.Identity.Name) Then
                e.Item.Cells(15).Enabled = True
            Else
                e.Item.Cells(15).Enabled = False
            End If
        End If
    End Sub

    Function Vinculado(ByVal CodDesc) As Boolean
        Dim ret As Boolean
        Dim vincDesp As Boolean
        Dim vincFat As Boolean

        ' Dim dtLancDesconto As dsListaDescontos.LANCAMENTO_DESCONTOSDataTable = New dsListaDescontos.LANCAMENTO_DESCONTOSDataTable
       ' daLancDescontos.Fill(dtLancDesconto)

        ' Verifica se está vinculado a uma despesa.
        If dtLancDesconto.FindByCODLANCDESCONTO(CodDesc).IsCODLANCDESPESANull Then
            vincDesp = False
        Else
            If dtLancDesconto.FindByCODLANCDESCONTO(CodDesc).CODLANCDESPESA.ToString.Trim = "" Then
                vincDesp = False
            Else
                vincDesp = True
            End If
        End If

        ' Verifica se está vinculado ao Faturamento

        If dtLancDesconto.FindByCODLANCDESCONTO(CodDesc).IsCODDETFATURAMENTONull Then
            vincFat = False
        Else
            If dtLancDesconto.FindByCODLANCDESCONTO(CodDesc).CODDETFATURAMENTO.ToString.Trim = "" Then
                vincFat = False
            Else
                vincFat = True
            End If
        End If


        ret = vincFat Or vincDesp
        Return ret
    End Function
    Function Auditado(ByVal CodDesc As String) As Boolean



        Dim dr As DataRow
        Dim ret As Boolean
        If Not dtLancDesconto.FindByCODLANCDESCONTO(CodDesc).AUDIDATO Then
            ret = False
        Else
            dr = dtLancDesconto.FindByCODLANCDESCONTO(CodDesc)
            ret = dr("AUDIDATO")
        End If

        Return ret
    End Function
    Private Sub grd_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grd.PageIndexChanged
        grd.CurrentPageIndex = e.NewPageIndex
        CarregarDados()
        Me.grd.DataBind()
        ExibirStatus()

    End Sub


    Private Sub grd_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.EditCommand
        Me.grd.EditItemIndex = e.Item.ItemIndex
        CarregarDados()
        PreencherGrid()
    End Sub

    Private Sub grd_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.CancelCommand
        Me.grd.EditItemIndex = -1
        CarregarDados()
        PreencherGrid()
    End Sub

    Private Sub grd_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.UpdateCommand
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim acb As clsAcessaBanco
        Dim cn As New OleDb.OleDbConnection
        Try

            ' Validando  o Valor com relação ao percentual
            If (CType(e.Item.Cells(11).Controls(0), TextBox).Text = "" Or CType(e.Item.Cells(11).Controls(0), TextBox).Text.Trim = "0,00") _
               And (CType(e.Item.Cells(8).Controls(0), TextBox).Text = "" Or CType(e.Item.Cells(8).Controls(0), TextBox).Text.Trim = "0,00") Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")

                Exit Sub
            End If
            If (CType(e.Item.Cells(11).Controls(0), TextBox).Text <> "" And CType(e.Item.Cells(11).Controls(0), TextBox).Text.Trim <> "0,00") _
                 And (CType(e.Item.Cells(8).Controls(0), TextBox).Text <> "" And CType(e.Item.Cells(8).Controls(0), TextBox).Text.Trim <> "0,00") Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")
                Exit Sub
            End If
            If CType(e.Item.Cells(11).Controls(0), TextBox).Text <> "" And e.Item.Cells(10).Text <> "" Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")
                Exit Sub
            End If
            If (CType(e.Item.Cells(11).Controls(0), TextBox).Text <> "" And CType(e.Item.Cells(11).Controls(0), TextBox).Text.Trim <> "0,00") _
                And e.Item.Cells(10).Text <> "" Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")
                Exit Sub
            End If
            If (CType(e.Item.Cells(11).Controls(0), TextBox).Text = "" Or CType(e.Item.Cells(11).Controls(0), TextBox).Text.Trim = "0,00") _
                And e.Item.Cells(10).Text = "" Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")
                Exit Sub
            End If

            If CType(e.Item.Cells(7).Controls(0), TextBox).Text.Trim.Length <> 4 Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")
                Exit Sub
            End If
            If CType(e.Item.Cells(4).Controls(0), TextBox).Text.Trim.Length <> 2 Then
                Response.Write("Você deve escolher entre o Valor ou Percentual")
                Exit Sub
            End If

            ' Não deixar alterar se for originário de uma despesa
            If e.Item.Cells(14).Text = "" Then
                Response.Write("Este desconto não pode ser alterado, pois está relacionado a uma despesa")
                Exit Sub
            End If
            If Auditado(e.Item.Cells(0).Text) Then
                Response.Write("Este desconto já foi confirmado pelo Administrador")
                Exit Sub
            End If

            cn.ConnectionString = Me.OleCn.ConnectionString
            acb.AbrirConexão(cn)
            sql = "update lancamento_descontos set " & _
                  " VALORDESCONTO =  " & Str(CDec(CType(e.Item.Cells(11).Controls(0), TextBox).Text)).Trim & _
                  " , Mes =  '" & CType(e.Item.Cells(4).Controls(0), TextBox).Text & "'" & _
                  " , Ano =  '" & CType(e.Item.Cells(7).Controls(0), TextBox).Text & "'" & _
                  " , Percentual =  " & Str(CDec(CType(e.Item.Cells(8).Controls(0), TextBox).Text)).Trim & _
                  " , USUARIO = '" & User.Identity.Name & "'" & _
                  " , DTALTERACAO = '" & Now() & "'" & _
                  " where codlancdesconto = '" & e.Item.Cells(0).Text & "'"

            cmd.CommandText = sql
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

            Me.grd.EditItemIndex = -1

            CarregarDados()
            PreencherGrid()


        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub grd_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.DeleteCommand
        Dim desc As New clsDescontos
        desc.oleConexão = Me.OleCn
        CarregarDados()
        If Not (Me.Auditado(e.Item.Cells(0).Text) Or Vinculado(e.Item.Cells(0).Text)) Then
            desc.ExcluirDesconto(e.Item.Cells(0).Text)
            CarregarDados()
            PreencherGrid()
        Else
            Response.Write("Este item não pode ser excluido.")
        End If
    End Sub


    Private Sub btnLancarDescontos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLancarDescontos.Click
        Response.Redirect("Descontos.aspx")
    End Sub

    Private Sub btnExcluirSeleção_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
        Dim cmd As New OleDb.OleDbCommand()
        sqlwhere = MontarFiltro()
        cmd.CommandText = "delete from lancamento_descontos " & sqlwhere
        cmd.ExecuteNonQuery()
        CarregarDados()
        PreencherGrid()
    End Sub



    Private Sub grd_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.ItemCommand
        If Socio.PermiteAuditar(User.Identity.Name) Then
            Select Case e.CommandName
                Case "Confirmar"
                    Dim Desc As New clsDescontos
                    Desc.AbrirConexão(Me.OleCn)
                    Desc.oleConexão = Me.OleCn
                    If CType(e.Item.Cells(16).Text, Boolean) Then
                        Desc.CancelarAuditoria(e.Item.Cells(0).Text)
                    Else
                        Desc.Auditar(e.Item.Cells(0).Text)
                    End If
                    Desc.FecharObjetos(Me.OleCn)
                    CarregarDados()
                    PreencherGrid()
            End Select
        End If
    End Sub

    Protected Sub btnExcluirMarcados_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcluirMarcados.Click
        Dim desc As New clsDescontos
        Dim i As Integer
        Dim chk As CheckBox
        Try

            desc.oleConexão = Me.OleCn


            For i = 0 To Me.grd.Items.Count - 1
                chk = CType(Me.grd.Items(i).Cells(1).Controls(1), CheckBox)
                ' Verifica se o item está marcado ou foi confirmado 
                If chk.Checked AndAlso Not desc.EstaAuditado(Me.grd.Items.Item(i).Cells(0).Text) Then
                    desc.ExcluirDesconto(Me.grd.Items.Item(i).Cells(0).Text)
                End If
            Next
            Me.OleCn.Close()
            CarregarDados()
            PreencherGrid()
        Catch Err As Exception
            Throw Err
        Finally
            If Me.OleCn.State = ConnectionState.Open Then
                desc.FecharObjetos(Me.OleCn)
            End If
        End Try
    End Sub

    Protected Sub btnConfCanc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfCanc.Click
        Dim desc As New clsDescontos
        Dim i As Integer
        Dim chk As CheckBox
        Dim trans As OleDb.OleDbTransaction

        If Socio.PermiteAuditar(User.Identity.Name) Then
            Try
                'Me.grdFaturamento.Items.Item(1).Cells()
                desc.oleConexão = Me.OleCn
                desc.AbrirConexão(desc.oleConexão)
                trans = desc.oleConexão.BeginTransaction
                desc.Transação = trans

                For i = 0 To grd.Items.Count - 1
                    chk = CType(Me.grd.Items(i).Cells(1).Controls(1), CheckBox)
                    ' Verifica se o item está marcado 
                    If chk.Checked Then
                        If desc.EstaAuditado(Me.grd.Items.Item(i).Cells(0).Text) Then
                            desc.CancelarAuditoria(Me.grd.Items(i).Cells(0).Text)
                        Else
                            desc.Auditar(Me.grd.Items(i).Cells(0).Text)
                        End If
                    End If
                Next
                trans.Commit()
                Me.OleCn.Close()
                CarregarDados()
                PreencherGrid()
            Catch Err As Exception
                trans.Rollback()
                Throw Err
            Finally
                If Me.OleCn.State = ConnectionState.Open Then
                    desc.FecharObjetos(Me.OleCn)
                End If
            End Try
        End If
    End Sub
End Class