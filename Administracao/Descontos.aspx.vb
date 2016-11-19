Public Partial Class Descontos1
    Inherits System.Web.UI.Page

    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    'Dim sqlwhereTpDesc As String
    'Dim sqlorderbyTpDesc As String
    ' Dim sqlTpDesc As String
    Dim Config As New clsConfiguracao(Server)
    Dim socio As New clsSocio()

    Dim daNatDesc As dsListaDescontosTableAdapters.NATUREZADESCONTOTableAdapter = New dsListaDescontosTableAdapters.NATUREZADESCONTOTableAdapter()
    Dim daTipoDesc As dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter = New dsListaDescontosTableAdapters.TIPODESCONTOTableAdapter()



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao

        socio.oleConexão = OleCn
        If socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If

        'Put user code to initialize the page here
        ' Me.sqlTpDesc = Me.OleDaTipoDesconto.SelectCommand.CommandText
        If Not Page.IsPostBack Then
            PreencherComboMes()
            MontarComboNatDesconto()
            PreencherListas()
            Me.txtAno.Text = Year(Now())
        End If
    End Sub

    Sub MontarComboNatDesconto()
        OleCn.Open()
        Me.ddlNatDesconto.DataSource = daNatDesc.GetData
        Me.ddlNatDesconto.DataBind()
        MontarComboTipoDesconto(Me.ddlNatDesconto.SelectedItem.Value)


        'Me.OleDaNatDesconto.SelectCommand.CommandText = Me.OleDaNatDesconto.SelectCommand.CommandText & " WHERE DTDEPRECIADO IS NULL  ORDER BY DSCNATDESC "
        ' Me.OleDaNatDesconto.Fill(Me.DsLancDesconto1, "NaturezaDesconto")

        OleCn.Close()
    End Sub

    Sub MontarComboTipoDesconto(ByVal CodNatDesconto As String)

        ddlTipoDesconto.DataSource = daTipoDesc.GetDataByNaturzaDesconto(CodNatDesconto)
        Me.ddlTipoDesconto.DataBind()
     
    End Sub

    Private Sub ddlNatDesconto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlNatDesconto.SelectedIndexChanged
        MontarComboTipoDesconto(Me.ddlNatDesconto.SelectedItem.Value)
    End Sub
    Private Sub btnPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadrao.Click
        PegarPadrao(Me.ddlTipoDesconto.SelectedItem.Value)
    End Sub


    Sub PegarPadrao(ByVal CodTpDesconto As String)
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()

        sql = "select * from tipodesconto where codtpdesconto = '" & CodTpDesconto & "'"
        If Not Me.OleCn.State = ConnectionState.Open Then
            Me.OleCn.Open()
        End If
        cmd.Connection = Me.OleCn()
        cmd.CommandText = sql
        dr = cmd.ExecuteReader
        If dr.Read() Then
            If Not CType(dr.Item("PercentualValor"), Boolean) Then
                Me.HabilitarValor()
                Me.rbPercentual.Checked = False
                Me.rbValor.Checked = True
                Me.txtValor.Text = FormatCurrency(dr.Item("Valor").ToString)
            Else
                Me.HabilitarPercentual()
                Select Case CType(dr.Item("INCPERCENT"), Integer)
                    Case 1
                        Me.rbFatBruto.Checked = True
                    Case 2
                        Me.rbFatIRRF.Checked = True
                    Case 3
                        Me.rbFatImpostos.Checked = True
                End Select
                Me.rbPercentual.Checked = True
                Me.txtPercentual.Text = IIf((dr.Item("Percentual") Is System.DBNull.Value), "", dr.Item("Percentual").ToString)

            End If
            PreencherListas(Me.ddlTipoDesconto.SelectedItem.Value)
        End If
    End Sub

    Sub PreencherListas()
        Dim lsItemIncidente As New ListItemCollection()
        Dim lsItemNaoIncidente As New ListItemCollection()
        Dim Item As ListItem
        lsItemIncidente = Incidencia()
        'lsItemNaoIncidente = NãoIncidencia(CodDesc)
        lsInc.Items.Clear()
        For Each Item In lsItemIncidente
            lsInc.Items.Add(Item)
        Next
        lsNaoInc.Items.Clear()
        For Each Item In lsItemNaoIncidente
            lsNaoInc.Items.Add(Item)
        Next
    End Sub
    Sub PreencherListas(ByVal CodDesc As String)
        Dim lsItemIncidente As ListItemCollection
        Dim lsItemNaoIncidente As ListItemCollection
        Dim Item As ListItem
        Dim TpDesc As New clsTipoDesconto()
        TpDesc.oleConexão = Me.OleCn
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
    Public Function Incidencia() As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()
        cn.ConnectionString = Me.OleCn.ConnectionString
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
        sql = "select CODSOCIO, NOME from SOCIO WHERE EXCLUIDO <> -1"
        cmd.CommandText = sql
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        While dr.Read()
            Dim lsItem As New ListItem()
            lsItem.Text = dr.Item("NOME").ToString
            lsItem.Value = dr.Item("CODSOCIO").ToString
            lsItens.Add(lsItem)
        End While
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cmd.Dispose()
        Return lsItens
    End Function
    Sub PreencherComboMes()
        'Dim lsMes As ListItemCollection
        Dim Mes As ListItem

        Mes = New ListItem()
        Mes.Text = "Janeiro"
        Mes.Value = "01"
        Me.ddlmes.Items.Add(Mes)
        'lsMes.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Fevereiro"
        Mes.Value = "02"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Março"
        Mes.Value = "03"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Abril"
        Mes.Value = "04"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Maio"
        Mes.Value = "05"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Junho"
        Mes.Value = "06"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Julho"
        Mes.Value = "07"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Agosto"
        Mes.Value = "08"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Setembro"
        Mes.Value = "09"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Outubro"
        Mes.Value = "10"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Novembro"
        Mes.Value = "11"
        Me.ddlmes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Dezembro"
        Mes.Value = "12"
        Me.ddlmes.Items.Add(Mes)


        ' Me.ddlmes.Items = lsMes

    End Sub
    Function ValidarDados() As Boolean
        ValidarDados = True
    End Function
    Private Sub cvValor_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvValor.ServerValidate
        If Me.rbValor.Checked Then
            If Not IsNumeric(Me.txtValor.Text) Then
                args.IsValid = False
            Else
                args.IsValid = True
            End If
        End If
    End Sub
    Private Sub cvPercentual_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvPercentual.ServerValidate
        If Me.rbPercentual.Checked Then
            If Not IsNumeric(Me.txtPercentual.Text) Then
                args.IsValid = False
            Else
                args.IsValid = True
            End If
        End If
    End Sub
    Private Sub btnGerarDescontos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarDescontos.Click
        Dim item As ListItem
        Dim Valor As Decimal
        Dim desc As New clsDescontos()
        Dim IncPercent As String

        Me.OleCn.Open()
        desc.oleConexão = Me.OleCn
        desc.Usuário = User.Identity.Name
        If Page.IsValid Then
            If rbValor.Checked AndAlso Me.txtValor.Text <> "" Then
                If Me.rbRatear.Checked Then
                    Valor = CDec(Me.txtValor.Text) / Me.lsInc.Items.Count
                Else
                    Valor = CDec(Me.txtValor.Text)
                End If
                For Each item In Me.lsInc.Items
                    'inserir descontos
                    desc.InserirDesconto(Me.ddlmes.SelectedItem.Value, Me.txtAno.Text, Me.ddlTipoDesconto.SelectedItem.Value, item.Value, Valor)
                Next
            ElseIf Me.rbPercentual.Checked AndAlso Me.txtPercentual.Text <> "" Then
                If Me.rbFatBruto.Checked Then
                    IncPercent = "1"
                End If
                If Me.rbFatIRRF.Checked Then
                    IncPercent = "2"
                End If
                If Me.rbFatImpostos.Checked Then
                    IncPercent = "3"
                End If
                For Each item In Me.lsInc.Items
                    'inserir descontos
                    desc.InserirDesconto(Me.ddlmes.SelectedItem.Value, Me.txtAno.Text, Me.ddlTipoDesconto.SelectedItem.Value, item.Value, CDec(Me.txtPercentual.Text), IncPercent)
                Next
            End If
        End If
        Me.OleCn.Close()
    End Sub
    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Response.Redirect("listadescontos.aspx")
    End Sub


    Private Sub HabilitarValor()
        Me.txtPercentual.Enabled = False
        Me.rbFatBruto.Enabled = False
        Me.rbFatImpostos.Enabled = False
        Me.rbFatIRRF.Enabled = False
        Me.txtValor.Enabled = True
        Me.rbPropagar.Enabled = True
        Me.rbRatear.Enabled = True
    End Sub
    Private Sub HabilitarPercentual()
        Me.txtPercentual.Enabled = True
        Me.rbFatBruto.Enabled = True
        Me.rbFatImpostos.Enabled = True
        Me.rbFatIRRF.Enabled = True
        Me.txtValor.Enabled = False
        Me.rbPropagar.Enabled = False
        Me.rbRatear.Enabled = False
    End Sub
    Private Sub rbValor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbValor.CheckedChanged

        If rbValor.Checked Then
            HabilitarValor()
        Else
            HabilitarPercentual()
        End If

    End Sub

    Private Sub rbPercentual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPercentual.CheckedChanged
        If Me.rbPercentual.Checked Then
            HabilitarPercentual()
        Else
            HabilitarValor()
        End If
    End Sub
    Private Sub btnValDiferentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValDiferentes.Click
        Response.Redirect("DescontosValDif.aspx")
    End Sub

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
        'TpDesc.AbrirConexão(oleCn)
        'TpDesc.oleConexão = Me.oleCn
        'Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        'TpDesc.FecharObjetos(oleCn)


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
        'TpDesc.AbrirConexão(oleCn)
        'TpDesc.oleConexão = Me.oleCn
        'Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        'TpDesc.FecharObjetos(oleCn)

    End Sub

    Private Sub btnVaiTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVaiTodos.Click
        Dim item As ListItem
        Dim i As Integer
        For Each item In lsNaoInc.Items
            Me.lsInc.Items.Add(item)
        Next
        Me.lsNaoInc.Items.Clear()
        'TpDesc.AbrirConexão(oleCn)
        'TpDesc.oleConexão = Me.oleCn
        'Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        'TpDesc.FecharObjetos(oleCn)
    End Sub

    Private Sub btnVoltaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltaTodo.Click
        Dim item As ListItem
        For Each item In lsInc.Items
            Me.lsNaoInc.Items.Add(item)
        Next
        Me.lsInc.Items.Clear()

        'TpDesc.AbrirConexão(oleCn)
        'TpDesc.oleConexão = Me.oleCn
        'Me.TpDesc.RegistrarIncidencia(Me.ddwTipoDesconto.SelectedItem.Value, lsInc.Items)
        'TpDesc.FecharObjetos(oleCn)
    End Sub

#End Region
End Class