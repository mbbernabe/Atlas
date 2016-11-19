
Public Class clsAcessaBanco
#Region "Declara��es de vari�veis privadas"
    Protected oleCn As OleDb.OleDbConnection
    Protected SqlCn As SqlClient.SqlConnection
    Protected vuser As String
    Protected trans As OleDb.OleDbTransaction
#End Region

#Region "Propriedades"
    Property Transa��o() As OleDb.OleDbTransaction
        Get
            Transa��o = trans
        End Get
        Set(ByVal Value As OleDb.OleDbTransaction)
            trans = Value
        End Set
    End Property
    Property Usu�rio() As String
        Get
            Usu�rio = vuser
        End Get
        Set(ByVal Value As String)
            vuser = Value
        End Set
    End Property
    Property oleConex�o() As OleDb.OleDbConnection
        Get
            oleConex�o = oleCn
        End Get
        Set(ByVal Value As OleDb.OleDbConnection)
            oleCn = Value
        End Set
    End Property
    Property SqlConex�o() As SqlClient.SqlConnection
        Get
            SqlConex�o = SqlCn
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
    Public Sub AbrirConex�o(ByVal cn As OleDb.OleDbConnection)

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
    End Sub
    Public Shared Sub AbrirConex�o(ByVal cn As SqlClient.SqlConnection)

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


    Public Function StringConex�o() As String
        Dim ret As String
        ret = System.Configuration.ConfigurationSettings.AppSettings("StringConex�o").ToString '& Server.MapPath("\dados\Imaging.mdb")
        Return ret
    End Function
End Class
