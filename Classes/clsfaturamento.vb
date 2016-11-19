Public Class clsFaturamento
    Inherits clsAcessaBanco

    Private vCodFaturamento As String
    Private vCodCliente As String
    Private vDtFaturamento As Date
    Private vNumnf As String
    Private vAuditado As Boolean
    Private vValorFatBruto As Decimal
    Private vNomeCliente As String

    Private da As OleDb.OleDbDataAdapter


    ReadOnly Property NomeCliente() As String
        Get
            NomeCliente = vNomeCliente
        End Get
    End Property


    ReadOnly Property ValorFatBruto() As Boolean
        Get
            ValorFatBruto = vValorFatBruto
        End Get
    End Property

    ReadOnly Property Auditado() As Boolean
        Get
            Auditado = vAuditado
        End Get
    End Property

    ReadOnly Property Numnf() As String
        Get
            Numnf = vNumnf
        End Get
    End Property

    ReadOnly Property DtFaturamento() As Date
        Get
            DtFaturamento = vDtFaturamento
        End Get
    End Property

    Property CodFaturamento() As String
        Get
            CodFaturamento = vCodFaturamento
        End Get
        Set(ByVal Value As String)
            vCodFaturamento = Value
        End Set
    End Property

    ReadOnly Property CodCliente() As String
        Get
            vCodCliente = CodCliente
        End Get
    End Property

    Public Sub SelFaturamento(ByVal CodFat)
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            'Preenchendo o Detalhe do Faturamento
            sql = "select * from Faturamento WHERE CODFATURAMENTO = '" & CodFat & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.vCodFaturamento = dr.Item("CODFATURAMENTO").ToString
                Me.vCodCliente = dr.Item("CODCLIENTE").ToString
                Me.vNomeCliente = Me.PegarNomeCliente(vCodCliente)
                Me.vDtFaturamento = dr.Item("DTFATURAMENTO").ToString
                Me.vNumnf = dr.Item("NUMNF").ToString
                Me.vAuditado = dr.Item("Auditado").ToString
                Me.vValorFatBruto = dr.Item("VALORFATURAMENTOBRUTO").ToString
            End If

        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Function SomarFaturamentoBruto(ByVal mes As String, ByVal ano As String, ByVal CodSocio As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Try
            sql = "select sum(VALORBRUTOSOCIO) from FATURAMENTO, DETALHEFATURAMENTO " & _
                  " where DETALHEFATURAMENTO.CODSOCIO = '" & CodSocio & "'" & _
                  " AND MONTH(FATURAMENTO.DTFATURAMENTO) = " & mes & _
                  " AND YEAR(FATURAMENTO.DTFATURAMENTO) = " & ano & _
                  " AND FATURAMENTO.CODFATURAMENTO = DETALHEFATURAMENTO.CODFATURAMENTO " & _
                  " AND FATURAMENTO.AUDITADO = 1 "



            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            
            If dr.Read Then
                If dr.Item(0) Is System.DBNull.Value Then
                    ret = 0
                Else
                    ret = dr.Item(0)
                End If

            Else
                ret = 0
            End If

            Return ret
        Catch err As Exception
            Throw
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try

    End Function

    Function SomarIRRF(ByVal mes As String, ByVal ano As String, ByVal CodSocio As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Try
            sql = "select sum(IRRF) from FATURAMENTO, DETALHEFATURAMENTO " & _
                  " where DETALHEFATURAMENTO.CODSOCIO = '" & CodSocio & "'" & _
                  " AND MONTH(FATURAMENTO.DTFATURAMENTO) = " & mes & _
                  " AND YEAR(FATURAMENTO.DTFATURAMENTO) = " & ano & _
                  " AND FATURAMENTO.CODFATURAMENTO = DETALHEFATURAMENTO.CODFATURAMENTO " & _
                  " AND FATURAMENTO.AUDITADO = 1 "




            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader

            If dr.Read Then
                If dr.Item(0) Is System.DBNull.Value Then
                    ret = 0
                Else
                    ret = dr.Item(0)
                End If

            Else
                ret = 0
            End If

            Return ret
        Catch err As Exception
            Throw
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try

    End Function

    Function SomarValorRec(ByVal mes As String, ByVal ano As String, ByVal CodSocio As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Try
            sql = "select sum(VALORREC) from FATURAMENTO, DETALHEFATURAMENTO " & _
                  " where DETALHEFATURAMENTO.CODSOCIO = '" & CodSocio & "'" & _
                  " AND MONTH(FATURAMENTO.DTFATURAMENTO) = " & mes & _
                  " AND YEAR(FATURAMENTO.DTFATURAMENTO) = " & ano & _
                  " AND FATURAMENTO.CODFATURAMENTO = DETALHEFATURAMENTO.CODFATURAMENTO " & _
                  " AND FATURAMENTO.AUDITADO = 1 "



            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader

            If dr.Read Then
                If dr.Item(0) Is System.DBNull.Value Then
                    ret = 0
                Else
                    ret = dr.Item(0)
                End If

            Else
                ret = 0
            End If

            Return ret
        Catch err As Exception
            Throw
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try


    End Function








    Public Sub SelFaturamento()
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            'Preenchendo o Detalhe do Faturamento
            sql = "select * from Faturamento WHERE CODFATURAMENTO = '" & Me.vCodFaturamento & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.vCodFaturamento = dr.Item("CODFATURAMENTO").ToString
                Me.vCodCliente = dr.Item("CODCLIENTE").ToString
                Me.vNomeCliente = Me.PegarNomeCliente(vCodCliente)
                Me.vDtFaturamento = dr.Item("DTFATURAMENTO").ToString
                Me.vNumnf = dr.Item("NUMNF").ToString
                Me.vAuditado = dr.Item("Auditado").ToString
                Me.vValorFatBruto = dr.Item("VALORFATURAMENTOBRUTO").ToString
            End If

        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Sub


    Private Function PegarNomeCliente(ByVal CodCliente) As String
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim ret As String

        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            'Preenchendo o Detalhe do Faturamento
            sql = "select Nome from Cliente WHERE CODCLIENTE = '" & CodCliente & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                ret = dr.Item("NOME").ToString
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try

    End Function


    Private Sub MontarDaFaturamento()
        da = New OleDb.OleDbDataAdapter()
        Dim cmd As New OleDb.OleDbCommand()

        ' da.SelectCommand = "select * from faturamento where "
    End Sub



    Public Function DetalheFaturamento(ByVal CodFaturamento As String) As DataSet
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim da As New OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()

        sql = "SELECT DETALHEFATURAMENTO.CODDETFATURAMENTO, DETALHEFATURAMENTO.CODSOCIO AS CODSOCIODET, SOCIO.CODSOCIO, SOCIO.NOME, DETALHEFATURAMENTO.VALORBRUTOSOCIO, DETALHEFATURAMENTO.CODFATURAMENTO " & _
              "  FROM SOCIO LEFT JOIN DETALHEFATURAMENTO ON SOCIO.CODSOCIO = DETALHEFATURAMENTO.CODSOCIO "

        If CodFaturamento <> "" Then
            sql = sql & " WHERE DETALHEFATURAMENTO.CODDETFATURAMENTO = '" & CodFaturamento & "'"
        End If

        cmd.Connection = Me.oleCn
        cmd.CommandText = sql
        da.SelectCommand = cmd
        da.Fill(ds, "DetFat")
        Return ds
    End Function

    Sub AtualizarInserir(ByVal CodFaturamento As String, ByVal CodSocio As String, ByVal CodCliente As String, ByVal Dia As String, ByVal Mes As String, ByVal ano As String, ByVal ValorBruto As String, ByVal NumNF As String)
        If CodFaturamento <> "" Then
            Me.Atualizar(CodFaturamento, CodSocio, CodCliente, Dia, Mes, ano, ValorBruto, NumNF)
        Else
            Me.Inserir(CodSocio, CodCliente, Dia, Mes, ano, ValorBruto, NumNF)
        End If
    End Sub
    Sub Atualizar(ByVal CodFaturamento As String, ByVal CodSocio As String, ByVal CodCliente As String, ByVal Dia As String, ByVal Mes As String, ByVal ano As String, ByVal ValorBruto As String, ByVal NumNF As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        sql = " update Faturamento  set " & _
              " CODCLIENTE = '" & CodCliente & "'" & _
              " DTFATURAMENTO = '" & Dia & "/" & Mes & "/" & ano & "'" & _
              " VALORFATURAMENTOBRUTO = " & ValorBruto & _
              " NumNF = '" & NumNF & "'" & _
              " WHERE CODFATURAMENTO = '" & CodFaturamento & "'"

        cmd.CommandText = sql
        cmd.Connection = Me.oleCn
        cmd.ExecuteNonQuery()
    End Sub
    Function Inserir(ByVal CodSocio As String, ByVal CodCliente As String, ByVal Dia As String, ByVal Mes As String, ByVal ano As String, ByVal ValorBruto As Decimal, ByVal NumNF As String) As String

        Dim sql As String
        Dim CodFaturamento As String
        CodFaturamento = GerarCodigo()

        Dim cmd As New OleDb.OleDbCommand()
        sql = " insert into Faturamento  (CODFATURAMENTO " & _
              " CODSOCIO = '" & CodSocio & "'" & _
              " CODSOCIO = '" & CodSocio & "'" & _
              " CODCLIENTE = '" & CodCliente & "'" & _
              " DTFATURAMENTO = '" & Dia & "/" & Mes & "/" & ano & "'" & _
              " VALORFATURAMENTOBRUTO = " & ValorBruto & _
              " NumNF = '" & NumNF & "'" & _
              " AUDITADO = FALSE " & _
              " WHERE CODFATURAMENTO = '" & CodFaturamento & "'"

        cmd.CommandText = sql
        cmd.Connection = Me.oleCn
        cmd.ExecuteNonQuery()
        Return CodFaturamento

    End Function
    Sub Excluir(ByVal CodFaturamento As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Try
            sql = "DELETE FROM FATURAMENTO WHERE CODFATURAMENTO = '" & CodFaturamento & "'"
            cmd.Connection = Me.oleCn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        End Try

    End Sub

    Sub Auditar(ByVal CodFat As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        sql = " update Faturamento  set " & _
              " AUDITADO = 1" & _
              " WHERE CODFATURAMENTO = '" & CodFat & "'"

        cmd.CommandText = sql
        cmd.Connection = Me.oleCn
        cmd.Transaction = Me.Transação
        cmd.ExecuteNonQuery()

        sql = " update LANCAMENTO_DESCONTOS  set " & _
                    " AUDIDATO = 1" & _
                    " WHERE CODLANCDESCONTO  IN (SELECT CODLANCDESCONTO FROM " & _
                                                  " FATURAMENTO, DETALHEFATURAMENTO, LANCAMENTO_DESCONTOS " & _
                                                  " WHERE FATURAMENTO.CODFATURAMENTO = DETALHEFATURAMENTO.CODFATURAMENTO " & _
                                                  " AND DETALHEFATURAMENTO.CODDETFATURAMENTO = LANCAMENTO_DESCONTOS.CODDETFATURAMENTO AND FATURAMENTO.CODFATURAMENTO = '" & CodFat & "' ) "


        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

    End Sub

    Sub CancelarAuditoria(ByVal CodFat As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()

        ' COLOCAR O CONTROLE DE TRANSAÇÃO 

        sql = " update Faturamento  set " & _
              " AUDITADO = 0" & _
              " WHERE CODFATURAMENTO = '" & CodFat & "'"

        cmd.CommandText = sql
        cmd.Connection = Me.oleCn
        cmd.Transaction = Me.Transação
        cmd.ExecuteNonQuery()

        sql = " update LANCAMENTO_DESCONTOS  set " & _
             " AUDIDATO = 0" & _
             " WHERE CODLANCDESCONTO  IN (SELECT CODLANCDESCONTO FROM " & _
                                           " FATURAMENTO, DETALHEFATURAMENTO, LANCAMENTO_DESCONTOS " & _
                                           " WHERE FATURAMENTO.CODFATURAMENTO = DETALHEFATURAMENTO.CODFATURAMENTO " & _
                                           " AND DETALHEFATURAMENTO.CODDETFATURAMENTO = LANCAMENTO_DESCONTOS.CODDETFATURAMENTO AND FATURAMENTO.CODFATURAMENTO = '" & CodFat & "' ) "


        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

    End Sub
    Function EstaAuditado(ByVal CodFat As String) As Boolean
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim ret As Boolean
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader

        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()

            sql = " select Auditado From Faturamento " & _
                  " WHERE CODFATURAMENTO = '" & CodFat & "'"

            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ret = dr.Item("AUDITADO")
            Else
                ret = False
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try

    End Function

    Public Sub CalcularImpostosFaturamento(ByVal codFaturamento As String, ByVal DataFaturamento As Date)
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = "select codDetFaturamento, ValorBrutoSocio,ValorRec,CodSocio from detalheFaturamento where codFaturamento = '" & codFaturamento & "'"
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            While dr.Read()
                ApagarImpostos(dr.Item("CodDetFaturamento"))
                CalcularImpostos(dr.Item("CodDetFaturamento"), dr.Item("ValorBrutoSocio"), dr.Item("ValorRec"), dr.Item("CodSocio"), DataFaturamento)
            End While
        Catch err As Exception
            Throw err
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
            cn.Close()
        End Try
    End Sub

    Sub ApagarImpostos(ByVal CodDetFaturamento As String)

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim desc As New clsDescontos()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader

        Try
            sql = "select codLancDesconto from Lancamento_descontos where codDetFaturamento = '" & CodDetFaturamento & "'"
            desc.oleConexão = Me.oleCn
            desc.Transação = Me.trans
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            While dr.Read
                desc.ExcluirDesconto(dr.Item("CODLANCDESCONTO"))
            End While
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Sub CalcularImpostos(ByVal CodDetFaturamento As String, ByVal ValorBrutoSocio As Decimal, ByVal ValorRec As Decimal, ByVal CodSocio As String, ByVal DataFaturamento As Date)

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim desc As New clsDescontos()
        Dim cn As New OleDb.OleDbConnection()
        Dim drTpDesconto As OleDb.OleDbDataReader
        Dim valorDesconto As Decimal
        Dim valor As Decimal


        Try
            desc.oleConexão = Me.oleCn
            desc.Transação = Me.trans
            desc.Usuário = Me.Usuário


            ' Pegar os Tipos de Desconto que são impostos 
            sql = "select * from TipoDesconto where CodNatDesc = '01'"
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            drTpDesconto = cmd.ExecuteReader

            While drTpDesconto.Read
                If IsDBNull(drTpDesconto.Item("Valor")) Then
                    valor = 0.0
                Else
                    valor = drTpDesconto.Item("Valor")
                End If


                valorDesconto = desc.CalcularValorDesconto( _
                                                   drTpDesconto.Item("PercentualValor"), _
                                                   valor, _
                                                   drTpDesconto.Item("IncPercent"), _
                                                   drTpDesconto.Item("Percentual"), _
                                                   ValorBrutoSocio, ValorRec)
                desc.InserirDesconto(DataFaturamento.Month, _
                                     DataFaturamento.Year, _
                                     drTpDesconto.Item("CodTpDesconto"), CodDetFaturamento, CodSocio, "", valorDesconto)
            End While

        Catch err As Exception

            Throw err

        Finally
            cn.Close()
            cmd.Dispose()

        End Try



    End Sub


End Class
