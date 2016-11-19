Public Class clsDescontos
    Inherits clsAcessaBanco
    'Dim vusuario As String
    'Property Usuario() As String
    '    Get
    '        Usuario = vusuario
    '    End Get
    '    Set(ByVal Value As String)
    '        vusuario = Value
    '    End Set
    'End Property

    Public Sub AtulizarValorDesconto(ByVal ValorDesconto As Decimal, ByVal CodLancDesconto As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = " update lancamento_descontos set valordesconto = " & ValorDesconto.ToString & _
                  " , USUARIO = ' " & Me.Usuário & "'" & _
                  " , DTALTERACAO = ' " & Month(Now().Date) & "/" & Day(Now().Date) & "/" & Year(Now().Date) & "'" & _
                  " where  codlancdesconto = '" & CodLancDesconto & "'"
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try
    End Sub


    Public Sub InserirDesconto(ByVal Mes As String, ByVal Ano As String, ByVal codTpDesconto As String, _
           ByVal codDetFaturamento As String, ByVal codSocio As String, _
           ByVal codLancDespesa As String, ByVal valorDesconto As Decimal)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim Código As String

        Try

            Código = GerarCodigo()
            While ExisteLancDesconto(Código)
                Código = GerarCodigo()
            End While

            If codDetFaturamento <> "" Then
                sql = "insert into lancamento_descontos (" & _
                      "CODLANCDESCONTO,Mes , Ano, codTpDesconto,codDetFaturamento, codSocio,codLancDespesa,valorDesconto, USUARIO, DTALTERACAO, AUDIDATO" & _
                      ") values (" & _
                      "'" & Código & "', '" & Mes & "', '" & Ano & "', '" & codTpDesconto & "', '" & codDetFaturamento & "', '" & codSocio & "', '" & codLancDespesa & "', " & Str(valorDesconto) & ", '" & Me.Usuário & "','" & Month(Now().Date) & "/" & Day(Now().Date) & "/" & Year(Now().Date) & "',0)"
            Else
                sql = "insert into lancamento_descontos (" & _
                      "CODLANCDESCONTO,Mes , Ano, codTpDesconto,codDetFaturamento, codSocio,codLancDespesa,valorDesconto, USUARIO, DTALTERACAO, AUDIDATO " & _
                      ") values (" & _
                      "'" & Código & "', '" & Mes & "', '" & Ano & "', '" & codTpDesconto & "', Null , '" & codSocio & "', '" & codLancDespesa & "', " & Str(valorDesconto) & ", '" & Me.Usuário & "','" & Month(Now().Date) & "/" & Day(Now().Date) & "/" & Year(Now().Date) & "', 0)"
            End If

            cmd.Connection = Me.oleCn
            cmd.Transaction = Me.Transação
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
        End Try
    End Sub


    Public Sub InserirDesconto(ByVal Mes As String, ByVal Ano As String, ByVal codTpDesconto As String, ByVal codSocio As String, ByVal valorDesconto As Decimal)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim Código As String
        Try
            Código = Me.GerarCodigo()
            sql = "insert into lancamento_descontos (" & _
                  "CODLANCDESCONTO,Mes , Ano, codTpDesconto, codSocio,valorDesconto, USUARIO, DTALTERACAO, AUDIDATO" & _
                  ") values (" & _
                  "'" & Código & "', '" & Mes & "', '" & Ano & "', '" & codTpDesconto & "', '" & codSocio & "', " & Str(valorDesconto) & ", '" & Me.Usuário & "','" & Month(Now().Date) & "/" & Day(Now().Date) & "/" & Year(Now().Date) & "', 0)"

            cmd.Connection = Me.oleCn
            cmd.Transaction = Me.Transação
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
        End Try
    End Sub

    Public Sub InserirDesconto(ByVal Mes As String, ByVal Ano As String, ByVal codTpDesconto As String, ByVal codSocio As String, ByVal Percentual As Decimal, ByVal IncidenciaPercentual As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim Código As String
        Try
            Código = Me.GerarCodigo()

            sql = "insert into lancamento_descontos (" & _
                  "CODLANCDESCONTO,Mes , Ano, codTpDesconto, codSocio,Percentual,IncidenciaPercentual, USUARIO, DTALTERACAO, AUDIDATO" & _
                  ") values (" & _
                  "'" & Código & "', '" & Mes & "', '" & Ano & "', '" & codTpDesconto & "', '" & codSocio & "', " & Str(Percentual) & ", '" & IncidenciaPercentual & "', '" & Me.Usuário & "','" & Month(Now().Date) & "/" & Day(Now().Date) & "/" & Year(Now().Date) & "', 0)"

            cmd.Connection = Me.oleCn
            cmd.Transaction = Me.Transação
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()

        End Try
    End Sub

    Public Sub ExcluirDesconto(ByVal CodLancDesconto As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()

            sql = " Delete from  lancamento_descontos  where  codlancdesconto = '" & CodLancDesconto & "'"
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.Transaction = Me.Transação
            cmd.ExecuteNonQuery()

        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try
    End Sub


    Public Sub ExcluirDescontosDeDespesa(ByVal CodLancDespesa As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        'Dim cn As New OleDb.OleDbConnection()
        Try
            'cn.ConnectionString = Me.oleCn.ConnectionString
            'cn.Open()
            sql = " Delete from  lancamento_descontos  where  codlancdespesa = '" & CodLancDespesa & "'"
            cmd.Connection = Me.oleConexão
            cmd.CommandText = sql
            cmd.Transaction = Me.Transação
            cmd.ExecuteNonQuery()

            '   cn.Close()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            '  cn.Close()
        End Try
    End Sub

    Sub Auditar(ByVal CodDesc As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        sql = " update LANCAMENTO_DESCONTOS  set " & _
              " AUDIDATO = 1" & _
              " WHERE CODLANCDESCONTO = '" & CodDesc & "'"

        If Not Me.trans Is Nothing Then
            cmd.Transaction = Me.Transação
        End If
        cmd.CommandText = sql
        cmd.Connection = Me.oleCn
        cmd.ExecuteNonQuery()



    End Sub

    Sub CancelarAuditoria(ByVal CodDesc As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        sql = " update LANCAMENTO_DESCONTOS  set " & _
              " AUDIDATO = 0" & _
              " WHERE CODLANCDESCONTO = '" & CodDesc & "'"

        If Not Me.trans Is Nothing Then
            cmd.Transaction = Me.Transação
        End If
        cmd.CommandText = sql
        cmd.Connection = Me.oleCn
        cmd.ExecuteNonQuery()
    End Sub

    Function EstaAuditado(ByVal CodDesc As String) As Boolean
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim ret As Boolean
        Dim cn As OleDb.OleDbConnection


        Try
            cn = New OleDb.OleDbConnection

            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)


            Dim dr As OleDb.OleDbDataReader
            sql = " select AUDIDATO From LANCAMENTO_DESCONTOS " & _
                  " WHERE CODLANCDESCONTO = '" & CodDesc & "'"
          
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ret = dr.Item("AUDIDATO")
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

    Public Function ExisteLancDesconto(ByVal CodLancDesconto) As Boolean
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            sql = "select * from LANCAMENTO_DESCONTOS where CODLANCDESCONTO = '" & CodLancDesconto & "'"
            cmd.CommandText = sql
            cn.Open()
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                ExisteLancDesconto = True
            Else
                ExisteLancDesconto = False
            End If
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try

    End Function

#Region "Totalizar Natureza de Desconto"
    Function TotalizarValorNatDesconto(ByVal CodNatDesc As String, ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Try
            sql = "select sum(VALORDESCONTO) from LANCAMENTO_DESCONTOS, TIPODESCONTO " & _
                  " where LANCAMENTO_DESCONTOS.CODSOCIO = '" & CodSocio & "'" & _
                  " AND LANCAMENTO_DESCONTOS.MES = '" & Mes & "'" & _
                  " AND LANCAMENTO_DESCONTOS.ANO = '" & Ano & "'" & _
                  " AND TIPODESCONTO.CODNATDESC = '" & CodNatDesc & "'" & _
                  " AND LANCAMENTO_DESCONTOS.CODTPDESCONTO = TIPODESCONTO.CODTPDESCONTO" & _
                  " AND AUDIDATO = 1 "

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







    Function TotalizarNatDesconto(ByVal CodNatDesc As String, ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal TotFatBruto As Decimal, ByVal TotFatRec As Decimal, ByVal TotMenosImpostos As String) As Decimal
        Dim ValorDesconto As Decimal
        Dim ValorSobFatBruto As Decimal
        Dim ValorSobFatLiquido As Decimal
        Dim ValorSobFaMenosImpostos As Decimal

        ValorDesconto = TotalizarValorNatDesconto(CodNatDesc, Mes, Ano, CodSocio)
        ValorSobFatBruto = TotalizarNatDescontoPercent(CodNatDesc, Mes, Ano, CodSocio, TotFatBruto, 1)
        ValorSobFatLiquido = TotalizarNatDescontoPercent(CodNatDesc, Mes, Ano, CodSocio, TotFatRec, 2)
        ValorSobFaMenosImpostos = TotalizarNatDescontoPercent(CodNatDesc, Mes, Ano, CodSocio, TotMenosImpostos, 3)

        Return (ValorDesconto + ValorSobFatBruto + ValorSobFatLiquido + ValorSobFaMenosImpostos)

    End Function




    Function TotalizarNatDescontoPercent(ByVal CodNatDesc As String, ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal ValorIncPercent As Decimal, ByVal IncPercent As Integer) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Dim TotalValor As Decimal
        Try
            sql = "select sum(LANCAMENTO_DESCONTOS.Percentual * " & Str(ValorIncPercent / 100) & " ) from LANCAMENTO_DESCONTOS, TIPODESCONTO " & _
                             " where LANCAMENTO_DESCONTOS.CODSOCIO = '" & CodSocio & "'" & _
                             " AND LANCAMENTO_DESCONTOS.MES = '" & Mes & "'" & _
                             " AND LANCAMENTO_DESCONTOS.ANO = '" & Ano & "'" & _
                             " AND TIPODESCONTO.CODNATDESC = '" & CodNatDesc & "'" & _
                             " AND INCIDENCIAPERCENTUAL = '" & IncPercent & "'" & _
                             " AND LANCAMENTO_DESCONTOS.CODTPDESCONTO = TIPODESCONTO.CODTPDESCONTO" & _
                             " AND AUDIDATO = 1 "


            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.Item(0) Is System.DBNull.Value Then
                    TotalValor = 0
                Else
                    TotalValor = dr.Item(0)
                End If
            Else
                TotalValor = 0
            End If


            Return TotalValor
        Catch err As Exception
            Throw
        Finally
            dr.Close()
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try


    End Function

#End Region

#Region "Totalizar por Tipo de Desconto"
    Function TotalizarTipoDesconto(ByVal CodTpDesc As String, ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal TotFatBruto As Decimal, ByVal TotFatRec As Decimal, ByVal TotMenosImpostos As String) As Decimal
        Dim ValorDesconto As Decimal
        Dim ValorSobFatBruto As Decimal
        Dim ValorSobFatLiquido As Decimal
        Dim ValorSobFaMenosImpostos As Decimal

        ValorDesconto = TotalizarValorTipoDesconto(CodTpDesc, Mes, Ano, CodSocio)
        ValorSobFatBruto = TotalizarTipoDescontoPercent(CodTpDesc, Mes, Ano, CodSocio, TotFatBruto, 1)
        ValorSobFatLiquido = TotalizarTipoDescontoPercent(CodTpDesc, Mes, Ano, CodSocio, TotFatRec, 2)
        ValorSobFaMenosImpostos = TotalizarTipoDescontoPercent(CodTpDesc, Mes, Ano, CodSocio, TotMenosImpostos, 3)

        Return (ValorDesconto + ValorSobFatBruto + ValorSobFatLiquido + ValorSobFaMenosImpostos)

    End Function


    Function TotalizarTipoDescontoPercent(ByVal CodTpDesc As String, ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal ValorIncPercent As Decimal, ByVal IncPercent As Integer) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Dim TotalValor As Decimal
        Try
            sql = "select sum(LANCAMENTO_DESCONTOS.Percentual * " & Str(ValorIncPercent / 100) & " ) from LANCAMENTO_DESCONTOS, TIPODESCONTO " & _
                             " where LANCAMENTO_DESCONTOS.CODSOCIO = '" & CodSocio & "'" & _
                             " AND LANCAMENTO_DESCONTOS.MES = '" & Mes & "'" & _
                             " AND LANCAMENTO_DESCONTOS.ANO = '" & Ano & "'" & _
                             " AND TIPODESCONTO.CODTPDESCONTO = '" & CodTpDesc & "'" & _
                             " AND INCIDENCIAPERCENTUAL = '" & IncPercent & "'" & _
                             " AND LANCAMENTO_DESCONTOS.CODTPDESCONTO = TIPODESCONTO.CODTPDESCONTO" & _
                             " AND AUDIDATO = 1 "


            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.Item(0) Is System.DBNull.Value Then
                    TotalValor = 0
                Else
                    TotalValor = dr.Item(0)
                End If
            Else
                TotalValor = 0
            End If
            Return TotalValor
        Catch err As Exception
            Throw
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try
    End Function

    Function TotalizarValorTipoDesconto(ByVal CodTpDesc As String, ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As Decimal
        Try
            sql = "select sum(VALORDESCONTO) from LANCAMENTO_DESCONTOS, TIPODESCONTO " & _
                  " where LANCAMENTO_DESCONTOS.CODSOCIO = '" & CodSocio & "'" & _
                  " AND LANCAMENTO_DESCONTOS.MES = '" & Mes & "'" & _
                  " AND LANCAMENTO_DESCONTOS.ANO = '" & Ano & "'" & _
                  " AND TIPODESCONTO.CODTPDESCONTO = '" & CodTpDesc & "'" & _
                  " AND LANCAMENTO_DESCONTOS.CODTPDESCONTO = TIPODESCONTO.CODTPDESCONTO" & _
                  " AND AUDIDATO = 1 "
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
#End Region


    Public Function CalcularValorDesconto(ByVal PercentualValor As Boolean, _
                            ByVal Valor As Decimal, _
                            ByVal IncPercent As Integer, _
                            ByVal Percentual As Single, _
                            ByVal FatBruto As Decimal, _
                            ByVal FatRec As Decimal) As Decimal

        Dim ret As Decimal
        If PercentualValor = False Then
            ret = Valor
        Else
            If IncPercent = 1 Then
                ret = FatBruto * (Percentual / 100)
            End If
            If IncPercent = 2 Then
                ret = FatRec * (Percentual / 100)
            End If
        End If
        Return ret
    End Function

End Class

