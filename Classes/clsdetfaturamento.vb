Public Class clsdetFaturamento
    Inherits clsAcessaBanco

    Dim vCodDetFaturamento As String
    Dim vCodFaturamento As String
    Dim vCodSocio As String
    Dim vValorBruto As Decimal
    Dim vIRRF As Decimal
    Dim vValorrec As Decimal
    Dim vNomeSocio As String



    Public ReadOnly Property Valorrec() As Decimal
        Get
            Valorrec = vValorrec
        End Get
       
    End Property
    Public ReadOnly Property IRRF() As Decimal
        Get
            IRRF = vIRRF
        End Get
    End Property
    Public ReadOnly Property ValorBruto() As Decimal
        Get
            ValorBruto = vValorBruto
        End Get
    End Property
    Public Property CodDetFaturamento() As String
        Get
            CodDetFaturamento = vCodDetFaturamento
        End Get
        Set(ByVal Value As String)
            vCodDetFaturamento = Value
        End Set
    End Property
    Public ReadOnly Property CodFaturamento() As String
        Get
            CodFaturamento = vCodFaturamento
        End Get
    End Property
    Public ReadOnly Property CodSocio() As String
        Get
            CodSocio = vCodSocio
        End Get
    End Property
    Public ReadOnly Property NomeSocio() As String
        Get
            NomeSocio = vNomeSocio
        End Get

    End Property


    Public Sub SelDetFaturamento(ByVal CodDetFat)
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            'Preenchendo o Detalhe do Faturamento
            sql = "select * from detalhefaturamento WHERE CODDETFATURAMENTO = '" & CodDetFat & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.vValorBruto = dr.Item("VALORBRUTOSOCIO").ToString
                Me.vCodDetFaturamento = dr.Item("CODDETFATURAMENTO").ToString
                Me.vCodSocio = CDec(dr.Item("CODSOCIO").ToString)
                Me.vNomeSocio = PegarNomeSocio(vCodSocio)
                Me.vIRRF = CDec(dr.Item("IRRF").ToString)
                Me.vValorrec = CDec(dr.Item("VALORREC").ToString)
                Me.vCodFaturamento = dr.Item("CODFATURAMENTO").ToString
            End If

        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try

    End Sub
    Public Sub SelDetFaturamento()
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            'Preenchendo o Detalhe do Faturamento
            sql = "select * from detalhefaturamento WHERE CODDETFATURAMENTO = '" & Me.vCodDetFaturamento & "'"
            cmd.CommandText = sql
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.vValorBruto = dr.Item("VALORBRUTOSOCIO").ToString
                Me.vCodDetFaturamento = dr.Item("CODDETFATURAMENTO").ToString
                Me.vCodSocio = CDec(dr.Item("CODSOCIO").ToString)
                Me.vNomeSocio = PegarNomeSocio(vCodSocio)
                Me.vIRRF = CDec(dr.Item("IRRF").ToString)
                Me.vValorrec = CDec(dr.Item("VALORREC").ToString)
                Me.vCodFaturamento = dr.Item("CODFATURAMENTO").ToString
            End If

        Catch err As Exception
            Throw err
        Finally
            cn.Close()
            cmd.Dispose()
        End Try

    End Sub

    Private Function PegarNomeSocio(ByVal CodSocio) As String
        Dim sql As String
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim ret As String

        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cn.Open()
            'Preenchendo o Detalhe do Faturamento
            sql = "select Nome from socio WHERE CODSOCIO = '" & vCodSocio & "'"
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

End Class
