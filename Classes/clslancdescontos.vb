Public Class clsLancDescontos
    Inherits clsAcessaBanco
    Public Sub AtulizarValorDesconto(ByVal ValorDesconto As Decimal, ByVal CodLancDesconto As String)
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = "update lancamento_descontos set valordesconto = " & Str(ValorDesconto) _
            & ", USUARIO = '" & Me.Usuário & "'" _
            & ", DTALTERACAO = '" & Now() & "'" _
            & " where  codlancdesconto = '" & CodLancDesconto & "'"
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
    Function RetornaTipoDesconto(ByVal CodLancDespesa) As String
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim ret As String

        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            sql = "select CodTpDesconto from lancamento_descontos  where CodLancDespesa ='" & CodLancDespesa & "'"
            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                ret = dr.Item("CodTpDesconto")
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
End Class

