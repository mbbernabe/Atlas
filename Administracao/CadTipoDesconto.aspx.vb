Public Partial Class cadTipoDesconto1
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
#Region "Minhas Declarações"
    Dim tpDesc As New clsTipoDesconto()
    Dim codTpDesc As String
    Dim socio As New clsSocio()
    Dim Config As New clsConfiguracao(Server)
#End Region
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Put user code to initialize the page here
        Try
            'Put user code to initialize the page here
            Me.OleCn = New System.Data.OleDb.OleDbConnection
            OleCn.ConnectionString = Config.StringConexao
            socio.oleConexão = OleCn
            If socio.NivelAcesso(User.Identity.Name) <> 1 Then
                Response.Redirect("AcessoNaoPermitido.aspx")
            End If

            If Not Page.IsPostBack Then
                'Carregando a Combo Natureza de desconto
                Dim daNatDesconto As dsTipoDescontoTableAdapters.NATUREZADESCONTOTableAdapter = New dsTipoDescontoTableAdapters.NATUREZADESCONTOTableAdapter()
                Me.ddlNatDesconto.DataSource = daNatDesconto.GetDataNaoDepreciado()
                Me.ddlNatDesconto.DataBind()

                'Definindo parâmetros para a classe tipoDesconto
                tpDesc.oleConexão = Me.OleCn
                'Pegando o Código do Cliente passado por parâmetro
                codTpDesc = Request.Params("cod")
                If codTpDesc <> "" Then
                    ' Consultar Cliente e preencher com os campos da tela
                    Me.txtTipoDesconto.Enabled = False
                    PreencherTela(codTpDesc)
                Else
                    Me.txtTipoDesconto.Enabled = True
                End If
            End If
        Catch err As Exception
            Throw err

        End Try

    End Sub



    Sub PreencherTela(ByVal CodTpDesc As String)
        Dim dr As OleDb.OleDbDataReader
        Dim olecmd As New OleDb.OleDbCommand()
        Dim sql As String = "select * from TipoDesconto where CodTpDesconto = '" & CodTpDesc & "'"
        Try
            Me.OleCn.Open()

            olecmd.CommandText = sql
            olecmd.Connection = Me.OleCn
            dr = olecmd.ExecuteReader()
            Dim Percentual As Boolean
            Dim IncPercent As Integer
            If dr.Read() Then
                Me.txtCodTpDesc.Text = dr.Item("CODTPDESCONTO").ToString
                Me.txtTipoDesconto.Text = dr.Item("NOMTPDESCONTO").ToString
                Me.txtTipoDesconto.Text = dr.Item("NOMTPDESCONTO").ToString
                If dr.Item("PERCENTUAL").ToString.Trim <> "" Then
                    Me.txtPercentual.Text = Format(dr.Item("PERCENTUAL").ToString, "{0:N2}")
                Else
                    Me.txtPercentual.Text = dr.Item("PERCENTUAL").ToString
                End If
                If dr.Item("VALOR").ToString <> "" Then
                    Me.txtValor.Text = FormatCurrency(CDec(dr.Item("VALOR").ToString))
                Else
                    Me.txtValor.Text = dr.Item("VALOR").ToString
                End If

                Percentual = CBool(dr.Item("PERCENTUALVALOR").ToString)

                Me.rbtValorFixo.Checked = Not Percentual
                Me.rbtPercentual.Checked = Percentual
                If dr.Item("INCPERCENT").ToString <> "" Then
                    IncPercent = CInt(dr.Item("INCPERCENT").ToString)
                End If


                Select Case IncPercent
                    Case 1 ' Desconto sobre o faturamento bruto
                        Me.rbtFatBruto.Checked = True
                    Case 2 ' Desconto sobre o faturamento menos o imposto de renda
                        Me.rbtFatMenosIRPJ.Checked = True
                    Case 3 ' Desconto sobre o faturamento menos o impostos
                        Me.rbtFatMenosImpostos.Checked = False
                End Select
                Me.ddlNatDesconto.SelectedIndex = Me.ddlNatDesconto.Items.IndexOf(Me.ddlNatDesconto.Items.FindByValue(dr.Item("CODNATDESC").ToString))
            End If
            Me.VisualizarPainel()

        Catch ERR As Exception
            Throw ERR
        Finally
            Me.OleCn.Close()
            olecmd.Dispose()
        End Try

    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            'Dim tpDesc As New clsTipoDesconto()
            Dim PercentualValor As Boolean
            Dim IncPercentual As Integer

            If Me.rbtFatBruto.Checked Then IncPercentual = 1
            If Me.rbtFatMenosIRPJ.Checked Then IncPercentual = 2
            If Me.rbtFatMenosImpostos.Checked Then IncPercentual = 3
            PercentualValor = Not Me.rbtValorFixo.Checked

            Me.tpDesc.oleConexão = Me.OleCn

            If Me.txtCodTpDesc.Text <> "" Then

                Select Case PercentualValor
                    Case True ' Atualizar Percentual
                        tpDesc.Update(Me.txtCodTpDesc.Text, _
                                Me.ddlNatDesconto.SelectedItem.Value, _
                                Me.txtTipoDesconto.Text, _
                                IncPercentual, _
                                CDec(Me.txtPercentual.Text))

                    Case False ' Atualizar Valor
                        tpDesc.Update(Me.txtCodTpDesc.Text, _
                                Me.ddlNatDesconto.SelectedItem.Value, _
                                Me.txtTipoDesconto.Text, _
                                CDec(Me.txtValor.Text))
                End Select
                Response.Write(" O Tipo de Desconto " & Me.txtTipoDesconto.Text & " foi atuzalizado co susesso. ")
                Me.txtTipoDesconto.Text = ""
                Me.txtPercentual.Text = ""
            Else
                Select Case PercentualValor
                    Case True ' Atualizar Percentual
                        tpDesc.Insert(Me.ddlNatDesconto.SelectedItem.Value, _
                                Me.txtTipoDesconto.Text, _
                                IncPercentual, _
                                CDec(Me.txtPercentual.Text))
                    Case False ' Atualizar Valor
                        tpDesc.Insert(Me.ddlNatDesconto.SelectedItem.Value, _
                                Me.txtTipoDesconto.Text, _
                                CDec(Me.txtValor.Text))
                End Select
                Response.Write(" O Tipo de Desconto " & Me.txtTipoDesconto.Text & " foi inserido com susesso. ")
                Me.txtTipoDesconto.Text = ""
                Me.txtPercentual.Text = ""
            End If
        Catch err As Exception
            Throw err
        End Try

    End Sub
    Private Sub rbtValorFixo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtValorFixo.CheckedChanged
        VisualizarPainel()
    End Sub
    Private Sub VisualizarPainel()
        If Me.rbtValorFixo.Checked Then
            Me.pnValorFixo.Visible = True
            Me.pnPercent.Visible = False
        Else
            Me.pnValorFixo.Visible = False
            Me.pnPercent.Visible = True
        End If

    End Sub
    Private Sub rbtPercentual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPercentual.CheckedChanged
        VisualizarPainel()
    End Sub

End Class