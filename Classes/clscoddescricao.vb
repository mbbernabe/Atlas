Public Class clsCodDescricao
    Inherits clsAcessaBanco
#Region "Declarações"
    Private sCampoCodigo As String
    Private sCampoDescrição As String
    Private sNomeTabela As String
#End Region
#Region "Propriedades"
    Property CampoCodigo() As String
        Get
            CampoCodigo = sCampoCodigo
        End Get
        Set(ByVal Value As String)
            sCampoCodigo = Value
        End Set
    End Property
    Property CampoDescrição() As String
        Get
            CampoDescrição = sCampoDescrição
        End Get
        Set(ByVal Value As String)
            sCampoDescrição = Value
        End Set
    End Property
    Property NomeTabela() As String
        Get
            NomeTabela = sNomeTabela
        End Get
        Set(ByVal Value As String)
            sNomeTabela = Value
        End Set
    End Property
#End Region
#Region "Métodos Públicos"
    ' Public Function MontarClientes(ByVal condição As String) As DataSet
        'Try
        '    Dim oleCmd As New OleDb.OleDbCommand()
        '    Dim daCliente As OleDb.OleDbDataAdapter


        '    Dim Codigo As String
        '    Dim sql As String
        '    sql = "select * from clientes " & IIf(condição = "", "", "where " & condição)


        'Catch Err As Exception
        '    Throw Err
        'Finally
        'End Try



    'End Function

    Public Function ExistePorDescrição(ByVal Descrição As String) As Boolean
        Dim oleCmd As New OleDb.OleDbCommand()
        Dim oledrCodDesc As OleDb.OleDbDataReader
        Try
            Dim sql As String
            sql = "select * from " & Me.sNomeTabela & " where " & Me.sCampoDescrição & " = '" & Descrição & "'"
            Me.oleCn.Open()
            oleCmd.Connection = oleCn
            oleCmd.CommandText = sql
            oledrCodDesc = oleCmd.ExecuteReader
            If oledrCodDesc.Read Then
                ExistePorDescrição = True
            Else
                ExistePorDescrição = False
            End If
        Catch err As Exception
            Throw err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try
    End Function

    Public Function ExistePorCodigo(ByVal Código As String) As Boolean
        Dim oleCmd As New OleDb.OleDbCommand()
        Dim oledrCodDesc As OleDb.OleDbDataReader
        Try
            Dim sql As String
            sql = "select * from" & Me.sNomeTabela & " where " & Me.sCampoCodigo & " = '" & Código & "'"
            Me.oleCn.Open()
            oleCmd.Connection = oleCn
            oleCmd.CommandText = sql
            oledrCodDesc = oleCmd.ExecuteReader
            If oledrCodDesc.Read Then
                ExistePorCodigo = True
            Else
                ExistePorCodigo = False
            End If
        Catch err As Exception
            Throw err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try

    End Function

    Public Sub Insert(ByVal dsc As String)
        Dim oleCmd As New OleDb.OleDbCommand()
        Try
            Dim Codigo As String
            Dim sql As String

            Codigo = GerarCodigo()
            sql = "insert into " & sNomeTabela & " (" & sCampoCodigo & ", " & sCampoDescrição & ") values ('" & Codigo & "','" & dsc & "')"
            oleCn.Open()
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try

    End Sub
    Public Sub Update(ByVal dsc As String, ByVal Codigo As String)

        Dim oleCmd As New OleDb.OleDbCommand()
        Try
            Dim sql As String
            sql = "update  " & sNomeTabela & " SET " & sCampoDescrição & " = '" & dsc & "' where " & sCampoCodigo & "= '" & Codigo & "'"
            oleCn.Open()
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try
    End Sub
    Public Sub Excluir(ByVal Codigo As String)

        Dim oleCmd As New OleDb.OleDbCommand()
        Try
            Dim sql As String
            sql = "delete from  " & sNomeTabela & " where " & sCampoCodigo & "= '" & Codigo & "'"
            oleCn.Open()
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()
        Catch Err As Exception
            Throw Err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try
    End Sub
#End Region

End Class
