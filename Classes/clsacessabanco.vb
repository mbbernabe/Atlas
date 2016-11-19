
Public Class clsAcessaBanco
#Region "Declarações de variáveis privadas"
    Protected oleCn As OleDb.OleDbConnection
    Protected SqlCn As SqlClient.SqlConnection
    Protected vuser As String
    Protected trans As OleDb.OleDbTransaction
#End Region

#Region "Propriedades"
    Property Transação() As OleDb.OleDbTransaction
        Get
            Transação = trans
        End Get
        Set(ByVal Value As OleDb.OleDbTransaction)
            trans = Value
        End Set
    End Property
    Property Usuário() As String
        Get
            Usuário = vuser
        End Get
        Set(ByVal Value As String)
            vuser = Value
        End Set
    End Property
    Property oleConexão() As OleDb.OleDbConnection
        Get
            oleConexão = oleCn
        End Get
        Set(ByVal Value As OleDb.OleDbConnection)
            oleCn = Value
        End Set
    End Property
    Property SqlConexão() As SqlClient.SqlConnection
        Get
            SqlConexão = SqlCn
        End Get
        Set(ByVal Value As SqlClient.SqlConnection)
            SqlCn = Value
        End Set
    End Property

#End Region

    Public Function GerarCodigo() As String
        Dim NovoCodigo As String
        NovoCodigo = Format(Now(), "ddmmyyyyhhmmss") & Format((999999 * Rnd()) + 1, "000000")
        Return NovoCodigo
    End Function
    Public Sub AbrirConexão(ByVal cn As OleDb.OleDbConnection)

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
    End Sub
    Public Shared Sub AbrirConexão(ByVal cn As SqlClient.SqlConnection)

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
    End Sub
    Public Sub FecharObjetos(ByVal obj As Object)
        Try
            obj.close()
        Catch err As Exception

        End Try
    End Sub


    Public Function StringConexão() As String
        Dim ret As String
        ret = System.Configuration.ConfigurationSettings.AppSettings("StringConexão").ToString '& Server.MapPath("\dados\Imaging.mdb")
        Return ret
    End Function
End Class
