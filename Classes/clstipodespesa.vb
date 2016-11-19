Public Class clsTipoDespesa
    Inherits clsAcessaBanco
#Region "Métodos Públicos de Acesso aos Dados"
    Public Function Insert(ByVal CodNatDesp As String, _
                      ByVal codTpDesconto As String, _
                      ByVal NomTipoDespesa As String, _
                      ByVal ValorPadrao As Decimal) As String

        Dim Codigo As String
        Dim oleCmd As New OleDb.OleDbCommand()
        Dim sqlbuider As New System.Text.StringBuilder()
        Try
            Codigo = GerarCodigo()
            With sqlbuider
                .Append("insert into TipoDespesa ")
                .Append("(CODTIPODESPESA")
                .Append(", CODNATDESP")
                '.Append(", CODTPDESCONTO")
                .Append(", NOMTIPODESPESA")
                .Append(", VALORPADRAO")
                .Append(") VALUES (")
                .Append("'" & Codigo.Trim & "'")
                .Append(", '" & CodNatDesp.Trim & "'")
                '.Append(",'" & codTpDesconto.Trim & "'")
                .Append(",'" & NomTipoDespesa.Trim & "'")
                .Append("," & Str(ValorPadrao))
                .Append(" )")
            End With
            oleCmd.CommandText = sqlbuider.ToString.Trim
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
            Return Codigo
        Catch Err As Exception
            Throw Err
        End Try

    End Function
    Public Sub Update(ByVal Codigo As String, ByVal CodNatDesp As String, ByVal codTpDesconto As String, ByVal NomTipoDespesa As String, ByVal ValorPadrao As Double)
        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim sqlbuider As New System.Text.StringBuilder()
            With sqlbuider
                .Append("update TipoDespesa set ")
                .Append(" CodNatDesp = '" & CodNatDesp.Trim & "'")
                '  .Append(", CodTpDescoto = '" & codTpDesconto.Trim & "'")
                .Append(", NomTipoDespesa = '" & NomTipoDespesa.Trim & "'")
                .Append(", ValorPadrao=  " & Str(ValorPadrao))
                .Append(" WHERE CODTIPODESPESA ='" & Codigo.Trim & "'")
            End With


            oleCmd.CommandText = sqlbuider.ToString
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        End Try
    End Sub

    Public Sub Excluir(ByVal Codigo As String)
        Dim oleCmd As New OleDb.OleDbCommand()
        Try

            Dim sql As String
            sql = "delete from TipoDespesa where CODTIPODESPESA = '" & Codigo.Trim & "'"

            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As OleDb.OleDbException
            Throw err
        Catch Err As Exception
            Throw Err
        Finally
            oleCmd.Dispose()
        End Try
    End Sub

    Public Function Incidencia(ByVal CodTpDespesa As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()
        cn.ConnectionString = Me.oleCn.ConnectionString
        Me.AbrirConexão(cn)
        sql = "select ID.CODSOCIO, S.NOME from INCIDENCIAPADRAODESPESA ID, SOCIO S WHERE  S.EXCLUIDO <> -1 AND ID.CODSOCIO = S.CODSOCIO AND ID.CODTIPODESPESA = '" & CodTpDespesa & "'"

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

    Public Function NãoIncidencia(ByVal CodTpDespesa As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()

        cn.ConnectionString = Me.oleCn.ConnectionString
        Me.AbrirConexão(cn)
        sql = "select CODSOCIO, NOME FROM SOCIO WHERE  SOCIO.EXCLUIDO <> -1 AND CODSOCIO NOT IN (select CODSOCIO from INCIDENCIAPADRAODESPESA WHERE CODTIPODESPESA = '" & CodTpDespesa & "')"
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

    Public Sub RegistrarIncidencia(ByVal CodTpDesp As String, ByVal lsIncidencia As ListItemCollection)
        Try
            Dim item As ListItem
            ExcluirIncidenciaPadrao(CodTpDesp)
            For Each item In lsIncidencia
                IncluirUmaIncidencia(CodTpDesp, item.Value.Trim)
            Next
        Catch Err As Exception
            Throw Err
        End Try

    End Sub

    Public Sub IncluirUmaIncidencia(ByVal CodTipoDespesa As String, ByVal CodSocio As String)
        Dim sql As String
        Dim olecmd As New OleDb.OleDbCommand()
        Try
            sql = "insert into INCIDENCIAPADRAODESPESA (" & _
                          "CODSOCIO, CODTIPODESPESA)values ('" & CodSocio & "', '" & CodTipoDespesa.Trim & "')"
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
            sql = "delete from INCIDENCIAPADRAODESPESA where CODTIPODESPESA = '" & Codigo.Trim & "'"
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As OleDb.OleDbException
            Throw err
        Catch Err As Exception
            Throw Err
        End Try
    End Sub

    Public Sub IncidenciaParaTodos(ByVal CodTpDespesa As String)

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
                IncluirUmaIncidencia(CodTpDespesa, dr.Item(0).ToString)
            End While

        Catch err As Exception
        Finally
            cn.Close()
            cmd.Dispose()

        End Try



    End Sub


    Public Function PegarCodDescontoPadrao(ByVal CodDesp As String) As String
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim ret As String
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = "select CODTPDESCONTO from TIPODESPESA where CODTIPODESPESA = '" & CodDesp & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                ret = dr.Item("CODTPDESCONTO").ToString
            Else
                ret = ""
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try
    End Function


    Public Sub AtualizarTipoDescontoPadrao(ByVal CodDesp As String, ByVal CodTpDesc As String)
        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim sqlbuider As New System.Text.StringBuilder()
            With sqlbuider
                .Append("update TipoDespesa set ")
                .Append("CodTpDesconto = '" & CodTpDesc.Trim & "'")
                .Append(" WHERE CODTIPODESPESA ='" & CodDesp.Trim & "'")
            End With
            oleCmd.CommandText = sqlbuider.ToString
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        End Try
    End Sub

    Public Function MontarTipoDespesas() As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim item As ListItem
        Dim lsItems As New ListItemCollection()
        Try
            sql = "select * from TipoDespesa"
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            While dr.Read()
                item = New ListItem()
                item.Text = dr.Item("NOMTIPODESPESA").ToString
                item.Value = dr.Item("CODTIPODESPESA").ToString
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
    Public Function MontarTipoDespesas(ByVal Condição As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim item As ListItem
        Dim lsItems As New ListItemCollection()
        Try
            sql = "select * from TipoDespesa "
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
                item.Text = dr.Item("NOMTIPODESPESA").ToString
                item.Value = dr.Item("CODTIPODESPESA").ToString
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
    Public Function MontarTipoDespesas(ByVal Condição As String, ByVal Ordem As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Dim item As ListItem
        Dim lsItems As New ListItemCollection()
        Try
            sql = "select * from TipoDespesa "
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
                item.Text = dr.Item("NOMTIPODESPESA").ToString
                item.Value = dr.Item("CODTIPODESPESA").ToString
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


#End Region



End Class
