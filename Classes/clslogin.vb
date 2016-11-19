Imports System.Web.Security
Public Class clslogin
    Inherits clsAcessaBanco
    Public Function ValidaSenha(ByVal NomeUsuario As String, ByVal Senha As String) As Boolean
        Dim sql As String
        Dim drSenha As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim ValSenha As Boolean

        ' Verificando se é sócio
        sql = "select senha from socio where NOMEUSUARIO = '" & NomeUsuario & "'"
        Me.AbrirConexão(Me.oleConexão)
        cmd.CommandText = sql
        cmd.Connection = Me.oleConexão
        drSenha = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If drSenha.Read() Then
            If drSenha.Item("Senha").ToString.Trim = Senha.Trim Then
                ValSenha = True
            Else
                ValSenha = False
            End If
        Else
            ValSenha = False
        End If
        If Not ValSenha Then
            ' Verificando se é outros usuários
            sql = "SELECT CODUSUARIO, NOME, NIVELACESSO , LOGIN ,SENHA " & _
                  "FROM  USUARIO WHERE LOGIN =  '" & NomeUsuario & "'"
            Me.AbrirConexão(Me.oleConexão)
            cmd.CommandText = sql
            cmd.Connection = Me.oleConexão
            drSenha = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If drSenha.Read() Then
                If drSenha.Item("Senha").ToString.Trim = Senha.Trim Then
                    ValSenha = True
                Else
                    ValSenha = False
                End If
            Else
                ValSenha = False
            End If
        End If
        Return ValSenha
    End Function
   
    Function NivelAcesso(ByVal NomeUsuario As String) As String
        Dim sql As String
        Dim drSenha As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand()
        Dim Nivel As String = ""
        ' Se for Sócio
        Try
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
End Class
