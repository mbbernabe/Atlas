Public Class clsDespesa
    Inherits clsAcessaBanco

    Public Function Incidencia(ByVal CodLancDespesa As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()
        cn.ConnectionString = Me.oleCn.ConnectionString
        Me.AbrirConexão(cn)
        sql = "select LD.CODSOCIO, S.NOME from LANCAMENTO_DESCONTOS LD, SOCIO S WHERE LD.CODSOCIO = S.CODSOCIO AND LD.CODLANCDESPESA = '" & CodLancDespesa & "'"

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

    Public Function NãoIncidencia(ByVal CodLancDespesa As String) As ListItemCollection
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim dr As OleDb.OleDbDataReader
        Dim htInc As New Hashtable()
        Dim cn As New OleDb.OleDbConnection()
        Dim lsItens As New ListItemCollection()

        cn.ConnectionString = Me.oleCn.ConnectionString
        Me.AbrirConexão(cn)
        sql = "select CODSOCIO, NOME FROM SOCIO WHERE CODSOCIO NOT IN (select CODSOCIO from LANCAMENTO_DESCONTOS WHERE CODLANCDESPESA = '" & CodLancDespesa & "')"
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

    Public Sub deletarDescontos(ByVal CodLancDespesa As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Try
            sql = "delete from lancamento_descontos where codlancdespesa = '" & CodLancDespesa & "'"
            cmd.CommandText = sql
            cmd.Transaction = Me.Transação
            cmd.Connection = Me.oleCn
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            '  Me.FecharObjetos(cn)
        End Try
    End Sub
    Public Sub deletarDespesas(ByVal CodLancDespesa As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Try

            sql = "delete from lancamento_despesas where codlancdespesa = '" & CodLancDespesa & "'"
            cmd.CommandText = sql
            cmd.Transaction = Me.Transação
            cmd.Connection = Me.oleCn
            cmd.ExecuteNonQuery()
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            ' Me.FecharObjetos(cn)
        End Try
    End Sub
    Sub Auditar(ByVal CodDesp As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        cmd.Connection = Me.oleCn
        If Not Me.trans Is Nothing Then
            cmd.Transaction = Me.Transação
        End If

        sql = " update LANCAMENTO_DESPESAS  set " & _
              " AUDITADO = 1" & _
              " WHERE CODLANCDESPESA = '" & CodDesp & "'"

        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        sql = " update LANCAMENTO_DESCONTOS  set " & _
                      " AUDIDATO = 1" & _
                      " WHERE CODLANCDESPESA = '" & CodDesp & "'"

        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

    End Sub
    Sub CancelarAuditoria(ByVal CodDesp As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        cmd.Connection = Me.oleCn
        If Not Me.trans Is Nothing Then
            cmd.Transaction = Me.Transação
        End If

        sql = " update LANCAMENTO_DESPESAS  set " & _
              " AUDITADO = 0" & _
              " WHERE CODLANCDESPESA = '" & CodDesp & "'"

        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        sql = " update LANCAMENTO_DESCONTOS  set " & _
                      " AUDIDATO = 0" & _
                      " WHERE CODLANCDESPESA = '" & CodDesp & "'"

        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

    End Sub



    Function Existe(ByVal CodDesp As String) As Boolean
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim ret As Boolean
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)

            sql = " select CODLANCDESPESA From LANCAMENTO_DESPESAS " & _
                  " WHERE CODLANCDESPESA = '" & CodDesp & "'"

            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read() Then
                ret = True
            Else
                ret = False
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()

        End Try

    End Function


    Function EstaAuditado(ByVal CodDesp As String) As Boolean
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim ret As Boolean
        Dim dr As OleDb.OleDbDataReader
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            Me.AbrirConexão(cn)

            sql = " select Auditado From LANCAMENTO_DESPESAS " & _
                  " WHERE CODLANCDESPESA = '" & CodDesp & "'"

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
            Me.FecharObjetos(cn)
            cmd.Dispose()

        End Try


    End Function
End Class
