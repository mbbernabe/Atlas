Public Partial Class Faturamento1
    Inherits System.Web.UI.Page
    Dim Config As New clsConfiguracao(Server)
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Protected WithEvents OleCn2 As System.Data.OleDb.OleDbConnection
    Dim socio As New clsSocio()

    Dim daCliente As dsClienteTableAdapters.CLIENTETableAdapter = New dsClienteTableAdapters.CLIENTETableAdapter()
    Dim daFaturamento As dsFaturamentoTableAdapters.FATURAMENTOTableAdapter = New dsFaturamentoTableAdapters.FATURAMENTOTableAdapter()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        Me.OleCn2 = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        OleCn2.ConnectionString = Config.StringConexao
        socio.oleConexão = OleCn
       
        'Exibindo os botões de operações na grid

     

        If socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")

        Else
            If User.Identity.Name = "Contador" Then
                Me.btnExcluirMarcados.Enabled = False
                Me.btnConfCanc.Enabled = False
            Else
                Me.btnExcluirMarcados.Enabled = True
                Me.btnConfCanc.Enabled = True
            End If
        End If
        'Definindo o tamanho da grid  
        Me.grdFaturamento.PageSize = Config.TamanhoPaginaGrid
        Me.grdFaturamento.Columns(7).Visible = socio.PermiteAuditar(User.Identity.Name)
        Me.btnConfCanc.Visible = socio.PermiteAuditar(User.Identity.Name)

        If Not Page.IsPostBack Then
            Me.ddlCliente.DataSource = daCliente.GetData()
            Me.ddlCliente.DataBind()
            Me.TxtAno1.Text = Year(Now)
        End If

    End Sub
    Sub ExibirStatus()
        Me.lblPaginaCorrente.Text = "Página:" & Me.grdFaturamento.CurrentPageIndex + 1 & " de " & Me.grdFaturamento.PageCount
    End Sub

    Sub PreencherGrid()

        If Me.TxtAno1.Text = "" Then
            Me.TxtAno1.Text = Year(Now())
        End If



        Me.grdFaturamento.DataSource = daFaturamento.GetDataBySelecaoTela(Me.txtNota.Text, _
                                          IIf(Me.chkFiltrarNumNota.Checked, "1", "0"), _
                                          Me.ddlCliente.SelectedItem.Value, _
                                          IIf(Me.chkFiltrarCliente.Checked, "1", "0"), _
                                          CboMes1.MesSelecionado, _
                                          IIf(Me.chkFiltrarMes.Checked, "1", "0"), _
                                          TxtAno1.Text, _
                                          IIf(Me.chkFiltrarAno.Checked, "1", "0"), _
                                          IIf(Me.CboConfirmação1.Confirmado, "1", "0"), _
                                          IIf(Me.chkFiltrarCofirmacao.Checked, "1", "0"))
        Me.grdFaturamento.DataBind()
        ExibirStatus()

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Me.grdFaturamento.CurrentPageIndex = 0
        PreencherGrid()
    End Sub
    'Sub GerarFiltro()

    '    sqlwhere = ""
    '    If Me.chkFiltrarCliente.Checked Then
    '        sqlwhere = " AND CODCLIENTE = '" & Me.ddlCliente.SelectedItem.Value & "'"
    '    End If
    '    If Me.chkFiltrarNumNota.Checked Then
    '        sqlwhere = sqlwhere & " AND NUMNF='" & Me.txtNota.Text & "'"
    '    End If

    '    If Me.chkFiltrarMes.Checked Then
    '        sqlwhere = sqlwhere & " AND MONTH(DTFATURAMENTO)='" & CboMes1.MesSelecionado & "'"
    '    End If

    '    If Me.chkFiltrarAno.Checked Then
    '        sqlwhere = sqlwhere & " AND YEAR(DTFATURAMENTO)='" & TxtAno1.Text & "'"
    '    End If

    '    If Me.chkFiltrarCofirmacao.Checked Then
    '        sqlwhere = sqlwhere & " AND AUDITADO =" & IIf(CboConfirmação1.Confirmado, "1", "0")
    '    End If

    '    If sqlwhere <> "" Then
    '        sqlwhere = Mid(sqlwhere, 5, sqlwhere.Length)
    '        sqlwhere = " where " & sqlwhere
    '    End If
    'End Sub

    '  Private Sub grdFaturamento_SortCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridSortCommandEventArgs) Handles grdFaturamento.SortCommand
    '     sqlorderby = " order by " & e.SortExpression
    '     PreencherGrid()
    'End Sub

    Private Sub grdFaturamento_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles grdFaturamento.PageIndexChanged
        grdFaturamento.CurrentPageIndex = e.NewPageIndex
        PreencherGrid()
    End Sub

    Private Sub grdFaturamento_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdFaturamento.DeleteCommand
        Dim fat As New clsFaturamento
        Try
            fat.oleConexão = Me.OleCn
            fat.AbrirConexão(fat.oleConexão)
            If fat.EstaAuditado(e.Item.Cells(0).Text) Then
                Response.Write("Operação não permitida - Este faturamento já foi confirmado pelo Administrador.")
                Exit Sub
            End If
            fat.FecharObjetos(fat.oleConexão)
            If Me.OleCn.State = ConnectionState.Open Then
                Me.OleCn.Close()
            End If
            Me.OleCn.Open()
            fat.oleConexão = Me.OleCn
            fat.Excluir(e.Item.Cells(0).Text)
            Me.OleCn.Close()
            PreencherGrid()
        Catch Err As Exception
        Finally
            If Me.OleCn.State = ConnectionState.Open Then
                Me.OleCn.Close()
            End If
        End Try

    End Sub

    Private Sub bntNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntNovo.Click
        Response.Redirect("detfat.aspx")
    End Sub

    Private Sub grdFaturamento_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdFaturamento.ItemDataBound
        Dim img As System.Web.UI.WebControls.Image
        ' Dim nvc As NameValueCollection = CType(ConfigurationSettings.GetConfig("Imaging/Figuras"), NameValueCollection)
        If User.Identity.Name = "Contador" Then
            'e.Item.Cells(6).Visible = False
            e.Item.Cells(7).Visible = False
        End If

        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            If Auditado(e.Item.Cells(0).Text) Then
                CType(e.Item.Cells(6).Controls(1), System.Web.UI.WebControls.Image).ImageUrl = "imagens/checkmrk.gif"
            Else
                CType(e.Item.Cells(6).Controls(1), System.Web.UI.WebControls.Image).ImageUrl = "imagens/icondoc.gif"
            End If
            If socio.PermiteAuditar(User.Identity.Name) Then
                e.Item.Cells(7).Enabled = True
            Else
                e.Item.Cells(7).Enabled = False
            End If
        End If
    End Sub

    Function Auditado(ByVal CodFat As String) As Boolean
        Dim dr As DataRow
        Dim ret As Boolean

        dr = Me.daFaturamento.GetDataByCodFaturamento(CodFat).FindByCODFATURAMENTO(CodFat)   'DsFaturamento1.FATURAMENTO.FindByCODFATURAMENTO(CodFat)
        ret = dr("AUDITADO")
        Return ret
    End Function

    Private Sub grdFaturamento_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdFaturamento.ItemCommand
        Dim trans As OleDb.OleDbTransaction = Nothing
        Try
            Select Case e.CommandName
                Case "Confirmar"
                    If socio.PermiteAuditar(User.Identity.Name) Then
                        Dim fat As New clsFaturamento
                        fat.AbrirConexão(Me.OleCn)
                        trans = Me.OleCn.BeginTransaction
                        fat.oleConexão = Me.OleCn
                        fat.Transação = trans

                        If CType(e.Item.Cells(8).Text, Boolean) Then
                            fat.CancelarAuditoria(e.Item.Cells(0).Text)
                        Else
                            fat.Auditar(e.Item.Cells(0).Text)
                        End If
                        trans.Commit()
                        fat.FecharObjetos(Me.OleCn)
                        PreencherGrid()
                    End If
            End Select
        Catch err As Exception
            If Not (trans Is Nothing) Then
                trans.Rollback()
            End If

            Throw err
        End Try
    End Sub
    Private Sub btnExcluirMarcados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirMarcados.Click
        Dim fat As New clsFaturamento
        Dim i As Integer
        Dim chk As CheckBox

        Try

            fat.oleConexão = Me.OleCn
            fat.AbrirConexão(fat.oleConexão)

            For i = 0 To grdFaturamento.Items.Count - 1
                chk = CType(Me.grdFaturamento.Items(i).Cells(1).Controls(1), CheckBox)
                ' Verifica se o item está marcado ou foi confirmado 
                If chk.Checked AndAlso Not fat.EstaAuditado(Me.grdFaturamento.Items.Item(i).Cells(0).Text) Then
                    fat.Excluir(Me.grdFaturamento.Items.Item(i).Cells(0).Text)
                End If
            Next
            Me.OleCn.Close()
            PreencherGrid()
        Catch Err As Exception
            Throw Err
        Finally
            If Me.OleCn.State = ConnectionState.Open Then
                fat.FecharObjetos(Me.OleCn)
            End If
        End Try
    End Sub

    Private Sub btnConfCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfCanc.Click
        Dim fat As New clsFaturamento
        Dim i As Integer
        Dim chk As CheckBox
        Dim trans As OleDb.OleDbTransaction = Nothing

        ' If Me.grdFaturamento.Columns(15).Visible = socio.PermiteAuditar(User.Identity.Name) Then

        If socio.PermiteAuditar(User.Identity.Name) Then
            Try
                'Me.grdFaturamento.Items.Item(1).Cells()

                fat.oleConexão = Me.OleCn
                fat.AbrirConexão(fat.oleConexão)
                trans = fat.oleConexão.BeginTransaction
                fat.Transação = trans

                For i = 0 To grdFaturamento.Items.Count - 1
                    chk = CType(Me.grdFaturamento.Items(i).Cells(1).Controls(1), CheckBox)
                    ' Verifica se o item está marcado 
                    If chk.Checked Then
                        If CType(Me.grdFaturamento.Items(i).Cells(8).Text, Boolean) Then
                            fat.CancelarAuditoria(Me.grdFaturamento.Items(i).Cells(0).Text)
                        Else
                            fat.Auditar(Me.grdFaturamento.Items(i).Cells(0).Text)
                        End If
                    End If
                Next
                trans.Commit()
                Me.OleCn.Close()
                PreencherGrid()
            Catch Err As Exception

                If Not (trans Is Nothing) Then
                    trans.Rollback()
                End If
                Throw Err
            Finally
                If Me.OleCn.State = ConnectionState.Open Then
                    fat.FecharObjetos(Me.OleCn)
                End If
            End Try

        End If
    End Sub
    ' ***********************************************************
    '   btnRecalcularNota_Click
    ' 
    '  Recalcula os descontos de impostos lançados para cada
    '  sócio da nota.
    '
    '************************************************************
    Private Sub btnRecalcularNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecalcularNota.Click
        Dim fat As New clsFaturamento
        Dim i As Integer
        Dim chk As CheckBox
        Dim trans As OleDb.OleDbTransaction = Nothing
        Dim Notas As New ArrayList
        Try

            ' Definindo as configurações para a classe de faturamento
            fat.oleConexão = Me.OleCn
            fat.AbrirConexão(fat.oleConexão)
            trans = fat.oleConexão.BeginTransaction
            fat.Transação = trans
            fat.Usuário = User.Identity.Name

            'para cada faturamento na grid
            For i = 0 To grdFaturamento.Items.Count - 1
                chk = CType(Me.grdFaturamento.Items(i).Cells(1).Controls(1), CheckBox)
                ' Verifica se o item está marcado e também não esta autidato
                ' o faturamento não pode ser recalculado se ja estiver auditado
                If chk.Checked AndAlso Not fat.EstaAuditado(Me.grdFaturamento.Items.Item(i).Cells(0).Text) Then
                    fat.CalcularImpostosFaturamento(Me.grdFaturamento.Items(i).Cells(0).Text, CDate(Me.grdFaturamento.Items(i).Cells(3).Text))
                End If
            Next
            trans.Commit()
            Response.Write("As Notas marcadas que não estão confirmadas foram recalculas com sucesso!")
            PreencherGrid()
        Catch Err As Exception
            If Not (trans Is Nothing) Then
                trans.Rollback()
            End If

            Throw Err
        Finally
            If Me.OleCn.State = ConnectionState.Open Then
                fat.FecharObjetos(Me.OleCn)
            End If
        End Try
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LinkButton1.Click

    End Sub
End Class