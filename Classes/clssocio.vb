

Public Class clsSocio
    Inherits clsAcessaBanco
#Region "Atributos"
    Private _nome As String
    Private _codSocio As String
    Private _email As String
    Private _identidade As String
    Private _cpf As String
    Private _tplogradouro As String
    Private _logradouro As String
    Private _numero As String
    Private _complemento As String
    Private _cidade As String
    Private _bairro As String
    Private _uf As String
    Private _cep As String
    Private _telefone1 As String
    Private _telefone2 As String
    Private _telefone3 As String
    Private _telefone4 As String
    Private _tpTelefone1 As String
    Private _tpTelefone2 As String
    Private _tpTelefone3 As String
    Private _tpTelefone4 As String

    Private _dddtel1 As String
    Private _dddtel2 As String
    Private _dddtel3 As String
    Private _dddtel4 As String

    Private _nomeUsuario As String
    Private _senha As String = ""
    Private _crm As String
    Private _numBanco As String
    Private _agencia As String
    Private _conta As String
    Private _codNivelAcesso As String = ""
    Private _usuario As String
    Private _excluido As String
    Private _dtAlteracao As Date
#End Region

#Region "Propriedades"
    Property nome() As String
        Get
            nome = _nome
        End Get
        Set(ByVal Value As String)
            _nome = Value
        End Set
    End Property


    Property codSocio() As String
        Get
            codSocio = _codSocio
        End Get
        Set(ByVal Value As String)
            _codSocio = Value

        End Set
    End Property

    Property email() As String
        Get
            email = _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property

    Property identidade() As String
        Get
            identidade = _identidade
        End Get
        Set(ByVal Value As String)
            _identidade = Value
        End Set
    End Property

    Property cpf() As String
        Get
            cpf = _cpf
        End Get
        Set(ByVal Value As String)
            _cpf = Value
        End Set
    End Property

    Property tplogradouro() As String
        Get
            tplogradouro = _tplogradouro
        End Get
        Set(ByVal Value As String)
            _tplogradouro = Value
        End Set
    End Property

    Property logradouro() As String
        Get
            logradouro = _logradouro
        End Get
        Set(ByVal Value As String)
            _logradouro = Value
        End Set
    End Property

    Property numero() As String
        Get
            numero = _numero
        End Get
        Set(ByVal Value As String)
            _numero = Value
        End Set
    End Property
    Property complemento() As String
        Get
            complemento = _complemento
        End Get
        Set(ByVal Value As String)
            _complemento = Value
        End Set
    End Property

    Property cidade() As String
        Get
            cidade = _cidade
        End Get
        Set(ByVal Value As String)
            _cidade = Value
        End Set
    End Property

    Property bairro() As String
        Get
            bairro = _bairro
        End Get
        Set(ByVal Value As String)
            _bairro = Value
        End Set
    End Property

    Property uf() As String
        Get
            uf = _uf
        End Get
        Set(ByVal Value As String)
            _uf = Value
        End Set
    End Property


    Property cep() As String
        Get
            cep = _cep
        End Get
        Set(ByVal Value As String)
            _cep = Value
        End Set
    End Property

    Property telefone1() As String
        Get
            telefone1 = _telefone1
        End Get
        Set(ByVal Value As String)
            _telefone1 = Value
        End Set
    End Property


    Property telefone2() As String
        Get
            telefone2 = _telefone2
        End Get
        Set(ByVal Value As String)
            _telefone2 = Value
        End Set
    End Property

    Property telefone3() As String
        Get
            telefone3 = _telefone3
        End Get
        Set(ByVal Value As String)
            _telefone3 = Value
        End Set
    End Property

    Property telefone4() As String
        Get
            telefone4 = _telefone4
        End Get
        Set(ByVal Value As String)
            _telefone4 = Value
        End Set
    End Property

    Property tpTelefone1() As String
        Get
            tpTelefone1 = _tpTelefone1
        End Get
        Set(ByVal Value As String)
            _tpTelefone1 = Value
        End Set
    End Property

    Property tpTelefone2() As String
        Get
            tpTelefone2 = _tpTelefone2
        End Get
        Set(ByVal Value As String)
            _tpTelefone2 = Value
        End Set
    End Property
    Property tpTelefone3() As String
        Get
            tpTelefone3 = _tpTelefone3
        End Get
        Set(ByVal Value As String)
            _tpTelefone3 = Value
        End Set
    End Property
    Property tpTelefone4() As String
        Get
            tpTelefone4 = _tpTelefone4
        End Get
        Set(ByVal Value As String)
            _tpTelefone4 = Value
        End Set
    End Property
    Property senha() As String
        Get
            senha = _senha
        End Get
        Set(ByVal Value As String)
            _senha = Value
        End Set
    End Property

    Property nomeUsuario() As String
        Get
            nomeUsuario = _nomeUsuario
        End Get
        Set(ByVal Value As String)
            _nomeUsuario = Value
        End Set
    End Property


    Property dddtel1() As String
        Get
            dddtel1 = _dddtel1
        End Get
        Set(ByVal Value As String)
            _dddtel1 = Value
        End Set
    End Property


    Property dddtel2() As String
        Get
            dddtel2 = _dddtel2
        End Get
        Set(ByVal Value As String)
            _dddtel2 = Value
        End Set
    End Property

    Property dddtel3() As String
        Get
            dddtel3 = _dddtel3
        End Get
        Set(ByVal Value As String)
            _dddtel3 = Value
        End Set
    End Property

    Property dddtel4() As String
        Get
            dddtel4 = _dddtel4
        End Get
        Set(ByVal Value As String)
            _dddtel4 = Value
        End Set
    End Property



    Property crm() As String
        Get
            crm = _crm
        End Get
        Set(ByVal Value As String)
            _crm = Value
        End Set
    End Property

    Property numBanco() As String
        Get
            numBanco = _numBanco
        End Get
        Set(ByVal Value As String)
            _numBanco = Value
        End Set
    End Property

    Property agencia() As String
        Get
            agencia = _agencia
        End Get
        Set(ByVal Value As String)
            _agencia = Value
        End Set
    End Property


    Property conta() As String
        Get
            conta = _conta
        End Get
        Set(ByVal Value As String)
            _conta = Value
        End Set
    End Property
    Property codNivelAcesso() As String
        Get
            codNivelAcesso = _codNivelAcesso
        End Get
        Set(ByVal Value As String)
            _codNivelAcesso = Value
        End Set
    End Property

    Property usuario() As String
        Get
            usuario = _usuario
        End Get
        Set(ByVal Value As String)
            _usuario = Value
        End Set
    End Property

    Property dtAlteracao() As String
        Get
            dtAlteracao = _dtAlteracao
        End Get
        Set(ByVal Value As String)
            _dtAlteracao = Value
        End Set
    End Property
    Property excluido() As String
        Get
            excluido = _excluido
        End Get
        Set(ByVal Value As String)
            _excluido = Value
        End Set
    End Property
#End Region



#Region "Métodos Públicos de Acesso aos Dados"
    Public Sub Insert()
        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim Codigo As String
            Dim sqlbuider As New System.Text.StringBuilder()
            Codigo = GerarCodigo()
            With sqlbuider
                .Append("insert into Socio ")
                .Append("(CODSOCIO")
                .Append(", NOME")
                .Append(", EMAIL")
                .Append(", IDENTIDADE")
                .Append(", CPF")
                .Append(", TPLOGRADOURO")
                .Append(", LOGRADOURO")
                .Append(", NUMERO")
                .Append(", COMPLEMENTO")
                .Append(", BAIRRO")
                .Append(", CIDADE")
                .Append(", UF")
                .Append(", CEP")
                .Append(", TPTELEFONE1")
                .Append(", TPTELEFONE2")
                .Append(", TPTELEFONE3")
                .Append(", TPTELEFONE4")
                .Append(", TELEFONE1")
                .Append(", TELEFONE2")
                .Append(", TELEFONE3")
                .Append(", TELEFONE4")
                .Append(", DDDTEL1")
                .Append(", DDDTEL2")
                .Append(", DDDTEL3")
                .Append(", DDDTEL4")
                .Append(", CRM")
                .Append(", SENHA")
                .Append(", NUMBANCO")
                .Append(", AGENCIA")
                .Append(", CONTA")
                .Append(", CODNIVELACESSO")
                .Append(", USUARIO")
                .Append(", DTALTERACAO")
                .Append(", EXCLUIDO")
                .Append(") VALUES (")
                .Append("'" & Codigo & "'")
                .Append(", '" & Me.nome & "'")
                .Append(",'" & Me.email.Trim & "'")
                .Append(",'" & Me.identidade.Trim & "'")
                .Append(",'" & Me.cpf.Trim & "'")
                .Append(",'" & Me.tplogradouro.Trim & "'")
                .Append(",'" & Me.logradouro.Trim & "'")
                .Append(",'" & Me.numero.Trim & "'")
                .Append(",'" & Me.complemento.Trim & "'")
                .Append(",'" & Me.bairro.Trim & "'")
                .Append(",'" & Me.cidade.Trim & "'")
                .Append(",'" & Me.uf.Trim & "'")
                .Append(",'" & Me.cep.Trim & "'")
                .Append(",'" & Me.tpTelefone1.Trim & "'")
                .Append(",'" & Me.tpTelefone2.Trim & "'")
                .Append(",'" & Me.tpTelefone3.Trim & "'")
                .Append(",'" & Me.tpTelefone4.Trim & "'")
                .Append(",'" & Me.telefone1.Trim & "'")
                .Append(",'" & Me.telefone2.Trim & "'")
                .Append(",'" & Me.telefone3.Trim & "'")
                .Append(",'" & Me.telefone4.Trim & "'")
                .Append(",'" & Me.dddtel1.Trim & "'")
                .Append(",'" & Me.dddtel2.Trim & "'")
                .Append(",'" & Me.dddtel3.Trim & "'")
                .Append(",'" & Me.dddtel4.Trim & "'")
                .Append(",'" & Me.crm.Trim & "'")
                .Append(",'" & Me.senha.Trim & "'")
                .Append(",'" & Me.numBanco.Trim & "'")
                .Append(",'" & Me.agencia.Trim & "'")
                .Append(",'" & Me.conta.Trim & "'")
                .Append(",'" & Me.codNivelAcesso.Trim & "'")
                .Append(",'" & Me.usuario.Trim & "'")
                Dim dtAt As Date
                dtAt = Me.dtAlteracao
                '  Me.dtAlteracao = Month(dtAt.Date) & "/" & Day(dtAt.Date) & "/" & Year(dtAt.Date)
                .Append(",'" & Month(dtAt.Date) & "/" & Day(dtAt.Date) & "/" & Year(dtAt.Date) & "'")
                .Append(",0")
                .Append(" )")
            End With
            Me.AbrirConexão(Me.oleConexão)
            oleCmd.CommandText = sqlbuider.ToString.Trim
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub
    Public Sub TrocaSenha()
        Try
            Dim oleCmd As New OleDb.OleDbCommand
            Dim sqlbuider As New System.Text.StringBuilder
            With sqlbuider
                .Append("update Socio set ")
                If Me.senha.ToString.Trim <> "" Then
                    .Append(" SENHA= '" & Me.senha.Trim & "'")
                End If
                .Append(", USUARIO= '" & Me.usuario.Trim & "'")
                Dim dtAt As Date
                dtAt = Me.dtAlteracao
                .Append(", DTALTERACAO= '" & Month(dtAt.Date) & "/" & Day(dtAt.Date) & "/" & Year(dtAt.Date) & "'")
                .Append(" WHERE CODSOCIO ='" & Me.codSocio.Trim & "'")
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

    Public Sub Update()

        Try




            Dim oleCmd As New OleDb.OleDbCommand
            Dim sqlbuider As New System.Text.StringBuilder
            With sqlbuider
                .Append("update Socio set ")
                .Append(" NOME = '" & Me.nome.Trim & "'")
                .Append(", EMAIL = '" & Me.email.Trim & "'")
                .Append(", IDENTIDADE = '" & Me.identidade.Trim & "'")
                .Append(", CPF=  '" & Me.cpf.Trim & "'")
                .Append(", TPLOGRADOURO = '" & Me.tplogradouro.Trim & "'")
                .Append(", LOGRADOURO = '" & Me.logradouro.Trim & "'")
                .Append(", NUMERO = '" & Me.numero.Trim & "'")
                .Append(", COMPLEMENTO = '" & Me.complemento.Trim & "'")
                .Append(", BAIRRO = '" & Me.bairro.Trim & "'")
                .Append(", CIDADE = '" & Me.cidade.Trim & "'")
                .Append(", UF = '" & Me.uf.Trim & "'")
                .Append(", CEP = '" & Me.cep.Trim & "'")
                .Append(", TPTELEFONE1 = '" & Me.tpTelefone1.Trim & "'")
                .Append(", TPTELEFONE2 = '" & Me.tpTelefone2.Trim & "'")
                .Append(", TPTELEFONE3 = '" & Me.tpTelefone3.Trim & "'")
                .Append(", TPTELEFONE4= '" & Me.tpTelefone4.Trim & "'")
                .Append(", TELEFONE1 = '" & Me.telefone1.Trim & "'")
                .Append(", TELEFONE2 = '" & Me.telefone2.Trim & "'")
                .Append(", TELEFONE3 = '" & Me.telefone3.Trim & "'")
                .Append(", TELEFONE4= '" & Me.telefone4.Trim & "'")
                .Append(", DDDTEL1 = '" & Me.dddtel1.Trim & "'")
                .Append(", DDDTEL2 = '" & Me.dddtel2.Trim & "'")
                .Append(", DDDTEL3 = '" & Me.dddtel3.Trim & "'")
                .Append(", DDDTEL4= '" & Me.dddtel4.Trim & "'")
                .Append(", CRM= '" & Me.crm.Trim & "'")
                .Append(", NUMBANCO= '" & Me.numBanco.Trim & "'")
                .Append(", AGENCIA= '" & Me.agencia.Trim & "'")
                .Append(", CONTA= '" & Me.conta.Trim & "'")
                .Append(", NOMEUSUARIO= '" & Me.nomeUsuario.Trim & "'")
                If Me.senha <> "" Then
                    .Append(", SENHA= '" & Me.senha.Trim & "'")
                End If
                Dim dtAt As Date
                dtAt = Me.dtAlteracao
                .Append(", DTALTERACAO= '" & Month(dtAt.Date) & "/" & Day(dtAt.Date) & "/" & Year(dtAt.Date) & "'")
                .Append(" WHERE CODSOCIO ='" & Me.codSocio.Trim & "'")
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
        Dim oleCmd As New OleDb.OleDbCommand
        Try

            Dim sql As String
            sql = "update Socio set Excluido = 1 where CODSocio = '" & Codigo & "'"
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

    'Recupera um sócio excluido logicamente
    Public Sub Recuperar(ByVal Codigo As String)
        Dim oleCmd As New OleDb.OleDbCommand
        Try

            Dim sql As String
            sql = "update Socio set Excluido = 0 where CODSocio = '" & Codigo & "'"
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

    'Function NivelAcesso(ByVal Id As String) As String
    '    Dim sql As String
    '    Dim cmd As New OleDb.OleDbCommand()
    '    Dim dr As OleDb.OleDbDataReader
    '    Dim ret As String
    '    Dim cn As New OleDb.OleDbConnection()
    '    Try
    '        cn.ConnectionString = Me.oleCn.ConnectionString
    '        cmd.Connection = cn
    '        Me.AbrirConexão(cn)
    '        sql = "select CODNIVELACESSO FROM SOCIO WHERE NOMEUSUARIO ='" & Id & "'"
    '        cmd.CommandText = sql
    '        dr = cmd.ExecuteReader
    '        If dr.Read Then
    '            ret = dr.Item("CODNIVELACESSO").ToString
    '        Else
    '            ret = 0
    '        End If
    '        Return ret
    '    Catch err As Exception
    '        Throw err
    '    Finally
    '        Me.FecharObjetos(cn)
    '        cmd.Dispose()
    '    End Try


    'End Function
    Function NivelAcesso(ByVal NomeUsuario As String)
        Try


            Dim sql As String
            Dim drSenha As OleDb.OleDbDataReader
            Dim cmd As New OleDb.OleDbCommand
            Dim Nivel As String = ""
            ' Se for Sócio
            sql = "select senha, CODNIVELACESSO from socio where NOMEUSUARIO = '" & NomeUsuario & "'"
            Me.AbrirConexão(Me.oleConexão)
            ' Me.oleConexão.Open()
            cmd.CommandText = sql
            cmd.Connection = Me.oleConexão
            drSenha = cmd.ExecuteReader(CommandBehavior.CloseConnection)


            If drSenha.Read() Then
                Nivel = drSenha.Item("CODNIVELACESSO").ToString.Trim
            End If
            ' Se for Usuário
            If Nivel = "" Then
                sql = "select senha, NIVELACESSO from USUARIO where LOGIN = '" & NomeUsuario & "'"
                Me.AbrirConexão(Me.oleConexão)
                ' Me.oleConexão.Open()
                cmd.CommandText = sql
                cmd.Connection = Me.oleConexão
                drSenha = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                If drSenha.Read() Then
                    Nivel = drSenha.Item("NIVELACESSO").ToString.Trim
                End If
            End If
            Return Nivel
        Catch ex As Exception
            Throw ex
        Finally
            Me.oleConexão.Close()
        End Try
    End Function
    Function CodPorNomeUsuario(ByVal Id As String) As String
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim ret As String
        Dim cn As New OleDb.OleDbConnection
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cmd.Connection = cn
            Me.AbrirConexão(cn)
            sql = "select CODSOCIO FROM SOCIO WHERE NOMEUSUARIO ='" & Id & "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                ret = dr.Item("CODSOCIO").ToString
            Else
                ret = ""
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try

    End Function

    Function SenhaPorEmail(ByVal Email As String) As String
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim ret As String
        Dim cn As New OleDb.OleDbConnection
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cmd.Connection = cn
            Me.AbrirConexão(cn)
            sql = "select SENHA FROM SOCIO WHERE EMAIL ='" & Email & "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                ret = dr.Item("SENHA").ToString
            Else
                ret = ""
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try

    End Function

    Function LoginPorEmail(ByVal Email As String) As String
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim ret As String
        Dim cn As New OleDb.OleDbConnection
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cmd.Connection = cn
            Me.AbrirConexão(cn)
            sql = "select NOMEUSUARIO FROM SOCIO WHERE EMAIL ='" & Email & "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                ret = dr.Item("NOMEUSUARIO").ToString
            Else
                ret = ""
            End If
            Return ret
        Catch err As Exception
            Throw err
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try

    End Function
    Public Function PermiteAuditar(ByVal NomeUsuario) As Boolean
        'Dim codUsuario As String
        'codUsuario = Me.CodPorNomeUsuario(NomeUsuario)

        ' If codUsuario <> "" And NivelAcesso(NomeUsuario) = "1" Then
        If NivelAcesso(NomeUsuario) = "1" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function eSocio(ByVal codSocio As String) As Boolean

    End Function

    Function SocioExluido(ByVal CodSocio As String) As Boolean
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim Ret As Boolean
        Dim cn As New OleDb.OleDbConnection
        Try
            cn.ConnectionString = Me.oleCn.ConnectionString
            cmd.Connection = cn
            Me.AbrirConexão(cn)
            sql = "select EXCLUIDO FROM SOCIO WHERE CODSOCIO ='" & CodSocio & "'"
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                Ret = dr.Item("EXCLUIDO")
            Else
                Ret = False
            End If
            Return Ret
        Catch err As Exception
            Throw err
        Finally
            Me.FecharObjetos(cn)
            cmd.Dispose()
        End Try
    End Function


#End Region
End Class
