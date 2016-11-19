Public Class clsTipoDesconto
    Inherits clsAcessaBanco
#Region "Métodos Públicos de Acesso aos Dados"


    Public Sub Insert(ByVal CodNatDesc As String, _
                      ByVal NomTipoDesconto As String, _
                      ByVal PercentualValor As Boolean, _
                      ByVal IncPercentual As Integer, _
                      ByVal Percentual As Double, _
                      ByVal ValorPadrao As Double)


        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim Codigo As String
            Dim sqlbuider As New System.Text.StringBuilder()
            Codigo = GerarCodigo()
            With sqlbuider
                .Append("insert into TipoDesconto")
                .Append("(CODTPDESCONTO")
                .Append(", CODNATDESC")
                .Append(", NOMTPDESCONTO")
                .Append(", VALOR")
                .Append(", PERCENTUAL")
                .Append(", PERCENTUALVALOR")
                .Append(", INCPERCENT")
                .Append(") VALUES (")
                .Append("'" & Codigo.Trim & "'")
                .Append(", '" & CodNatDesc.Trim & "'")
                .Append(",'" & NomTipoDesconto.Trim & "'")
                .Append("," & Str(ValorPadrao))
                .Append("," & Str(Percentual))
                .Append("," & PercentualValor)
                .Append("," & IncPercentual)
                .Append(" )")
            End With
            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString.Trim
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub

    Public Sub Insert(ByVal CodNatDesc As String, _
                    ByVal NomTipoDesconto As String, _
                    ByVal ValorPadrao As Double)


        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim Codigo As String
            Dim sqlbuider As New System.Text.StringBuilder()
            Codigo = GerarCodigo()
            With sqlbuider
                .Append("insert into TipoDesconto")
                .Append("(CODTPDESCONTO")
                .Append(", CODNATDESC")
                .Append(", NOMTPDESCONTO")
                .Append(", VALOR")
                .Append(", PERCENTUALVALOR")
                .Append(") VALUES (")
                .Append("'" & Codigo.Trim & "'")
                .Append(", '" & CodNatDesc.Trim & "'")
                .Append(",'" & NomTipoDesconto.Trim & "'")
                .Append("," & Str(ValorPadrao))
                .Append("," & "1")
                .Append(" )")
            End With
            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString.Trim
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub

    Public Sub Insert(ByVal CodNatDesc As String, _
                      ByVal NomTipoDesconto As String, _
                      ByVal IncPercentual As Integer, _
                      ByVal Percentual As Double)


        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim Codigo As String
            Dim sqlbuider As New System.Text.StringBuilder()
            Codigo = GerarCodigo()
            With sqlbuider
                .Append("insert into TipoDesconto")
                .Append("(CODTPDESCONTO")
                .Append(", CODNATDESC")
                .Append(", NOMTPDESCONTO")
                .Append(", PERCENTUAL")
                .Append(", PERCENTUALVALOR")
                .Append(", INCPERCENT")
                .Append(") VALUES (")
                .Append("'" & Codigo.Trim & "'")
                .Append(", '" & CodNatDesc.Trim & "'")
                .Append(",'" & NomTipoDesconto.Trim & "'")
                .Append("," & Str(Percentual))
                .Append("," & "1")
                .Append("," & IncPercentual)
                .Append(" )")
            End With
            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString.Trim
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub




    Public Sub Update(ByVal Codigo As String, _
                      ByVal CodNatDesc As String, _
                      ByVal NomTipoDesconto As String, _
                      ByVal PercentualValor As Boolean, _
                      ByVal IncPercentual As Integer, _
                      ByVal Percentual As Double, _
                      ByVal ValorPadrao As Double)

        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim sqlbuider As New System.Text.StringBuilder()
            With sqlbuider
                .Append("update TipoDesconto set ")
                .Append(" CodNatDesc = '" & CodNatDesc.Trim & "'")
                .Append(", NomTpDesconto = '" & NomTipoDesconto.Trim & "'")
                .Append(", ValorPadrao=  " & Str(ValorPadrao))
                .Append(", Percentual=  " & Str(Percentual))
                .Append(", PercentualValor = " & PercentualValor)
                .Append(", IncPercent = " & IncPercentual)
                .Append(" WHERE CODTPDESCONTO ='" & Codigo.Trim & "'")
            End With

            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub
    Public Sub Update(ByVal Codigo As String, _
                      ByVal CodNatDesc As String, _
                      ByVal NomTipoDesconto As String, _
                      ByVal ValorPadrao As Double)

        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim sqlbuider As New System.Text.StringBuilder()
            With sqlbuider
                .Append("update TipoDesconto set ")
                .Append(" CodNatDesc = '" & CodNatDesc.Trim & "'")
                .Append(", NomTpDesconto = '" & NomTipoDesconto.Trim & "'")
                .Append(", ValorPadrao=  " & Str(ValorPadrao))
                .Append(", PercentualValor = " & "0")
                .Append(" WHERE CODTPDESCONTO ='" & Codigo.Trim & "'")
            End With

            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub
    Public Sub Update(ByVal Codigo As String, _
                      ByVal CodNatDesc As String, _
                      ByVal NomTipoDesconto As String, _
                      ByVal IncPercentual As Integer, _
                      ByVal Percentual As Double)

        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim sqlbuider As New System.Text.StringBuilder()
            With sqlbuider
                .Append("update TipoDesconto set ")
                .Append(" CodNatDesc = '" & CodNatDesc.Trim & "'")
                .Append(", NomTpDesconto = '" & NomTipoDesconto.Trim & "'")
                .Append(", Percentual=  " & Str(Percentual))
                .Append(", PercentualValor = " & "1")
                .Append(", IncPercent = " & IncPercentual)
                .Append(" WHERE CODTPDESCONTO ='" & Codigo.Trim & "'")
            End With

            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub

    Public Sub Excluir(ByVal Codigo As String)
        Dim oleCmd As New OleDb.OleDbCommand()
        Try
            Dim sql As String

            'sql = "delete from TipoDesconto where CODTPDESCONTO = '" & Codigo.Trim & "'"
            'oleCn.Open()
            'oleCmd.CommandText = sql
            'oleCmd.Connection = oleCn
            'oleCmd.ExecuteNonQuery()


            ' Ao contrário de deletar, vou setar a data de depreciação com a data do sistema

            sql = "UPDATE TipoDesconto SET DtDepreciado= '" & Format(Now(), "dd/MM/yyyy") & "' where CODTPDESCONTO = '" & Codigo.Trim & "'"
            oleCn.Open()
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()


        Catch Err As OleDb.OleDbException
            Throw err
        Catch Err As Exception
            Throw Err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try
    End Sub

    Public Function MontarTipoDescontos() As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim item As ListItem
        Dim lsItems As New ListItemCollection()
        Try
            sql = "select * from TipoDesconto"
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            While dr.Read()
                item = New ListItem()
                item.Text = dr.Item("NOMTPDESCONTO").ToString
                item.Value = dr.Item("CODTPDESCONTO").ToString
                lsItems.Add(item)
            End While
            Return lsItems
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Function
    Public Function MontarTipoDescontos(ByVal Condição As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim item As ListItem
        Dim lsItems As New ListItemCollection()
        Try
            sql = "select * from TipoDesconto "
            If Condição <> "" Then
                sql = sql & " where " & Condição
            End If
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            While dr.Read()
                item = New ListItem()
                item.Text = dr.Item("NOMTPDESCONTO").ToString
                item.Value = dr.Item("CODTPDESCONTO").ToString
                lsItems.Add(item)
            End While
            Return lsItems
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Function
    Public Function MontarTipoDescontos(ByVal Condição As String, ByVal Ordem As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim item As ListItem
        Dim lsItems As New ListItemCollection()
        Try
            sql = "select * from TipoDesconto "
            If Condição <> "" Then
                sql = sql & " where " & Condição
            End If
            If Ordem <> "" Then
                sql = sql & "order by " & Ordem
            End If
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            While dr.Read()
                item = New ListItem()
                item.Text = dr.Item("NOMTPDESCONTO").ToString
                item.Value = dr.Item("CODTPDESCONTO").ToString
                lsItems.Add(item)
            End While
            Return lsItems
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Function



    Public Function Incidencia(ByVal CodTpDesconto As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()
        cn.ConnectionString = Me.oleCn.ConnectionString
        Me.AbrirConexão(cn)
        sql = "select ID.CODSOCIO, S.NOME from INCIDENCIAPADRAODESCONTO ID, SOCIO S WHERE ID.CODSOCIO = S.CODSOCIO AND ID.CODTPDESCONTO = '" & CodTpDesconto & "'"

        cmd.CommandText = sql
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        While dr.Read()
            Dim lsItem As New ListItem()
            lsItem.Text = dr.Item("NOME").ToString
            lsItem.Value = dr.Item("CODSOCIO").ToString
            lsItens.Add(lsItem)
        End While
        Me.FecharObjetos(cn)
        cmd.Dispose()
        Return lsItens
    End Function

    Public Function NãoIncidencia(ByVal CodTpDesconto As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()

        cn.ConnectionString = Me.oleCn.ConnectionString
        Me.AbrirConexão(cn)
        sql = "select CODSOCIO, NOME FROM SOCIO WHERE CODSOCIO NOT IN (select CODSOCIO from INCIDENCIAPADRAODESCONTO WHERE CODTPDESCONTO = '" & CodTpDesconto & "')"
        cmd.CommandText = sql
        cmd.Connection = cn
        dr = cmd.ExecuteReader
        While dr.Read()
            Dim lsItem As New ListItem()
            lsItem.Text = dr.Item("NOME").ToString
            lsItem.Value = dr.Item("CODSOCIO").ToString
            lsItens.Add(lsItem)
        End While
        Me.FecharObjetos(cn)
        cmd.Dispose()
        Return lsItens
    End Function

    Public Sub RegistrarIncidencia(ByVal CodTpDesconto As String, ByVal lsIncidencia As ListItemCollection)
        Try
            Dim item As ListItem
            ExcluirIncidenciaPadrao(CodTpDesconto)
            For Each item In lsIncidencia
                IncluirUmaIncidencia(CodTpDesconto, item.Value.Trim)
            Next
        Catch Err As Exception
            Throw Err
        End Try

    End Sub

    Public Sub IncluirUmaIncidencia(ByVal CodTpDesconto As String, ByVal CodSocio As String)
        Dim sql As String
        Dim olecmd As New OleDb.OleDbCommand()
        Try
            sql = "insert into INCIDENCIAPADRAODESCONTO (" & _
                          "CODSOCIO, CODTPDESCONTO)values ('" & CodSocio & "', '" & CodTpDesconto.Trim & "')"
            olecmd.CommandText = sql
            olecmd.Connection = oleCn
            olecmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        End Try

    End Sub

    Public Sub ExcluirIncidenciaPadrao(ByVal Codigo As String)
        Dim oleCmd As New OleDb.OleDbCommand()
        Try
            Dim sql As String
            sql = "delete from INCIDENCIAPADRAODESCONTO where CODTPDESCONTO = '" & Codigo.Trim & "'"
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As OleDb.OleDbException
            Throw err
        Catch Err As Exception
            Throw Err
        End Try
    End Sub

    Public Sub IncidenciaParaTodos(ByVal CodTpDesconto As String)

        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = "select codsocio from socio"
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            While dr.Read()
                IncluirUmaIncidencia(CodTpDesconto, dr.Item(0).ToString)
            End While
        Catch err As Exception
        Finally
            cn.Close()
            cmd.Dispose()
        End Try


    End Sub
    Function RetCodNatDesc(ByVal CodTpDesc As String) As String
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim ret As String
        Try
            ret = ""
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = "select codnatdesc from tipodesconto where codtpdesconto = '" & CodTpDesc & "'"
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            While dr.Read()
                ret = dr.Item("codnatdesc").ToString
            End While
            Return ret
        Catch err As Exception
        Finally
            cn.Close()
            cmd.Dispose()
        End Try

    End Function


















#End Region
End Class
