Imports System.Web

Public Class clsConfiguracao
    Dim _iTamanhoPaginaGrid As Integer
    Dim _strConexao As String
    Dim _strConexaoSQL As String
    Shared Server As HttpServerUtility()
    ReadOnly Property TamanhoPaginaGrid() As Integer
        Get
            Return _iTamanhoPaginaGrid
        End Get
    End Property
    ReadOnly Property StringConexao() As String
        Get
            Return _strConexao
        End Get
    End Property
    ReadOnly Property StringConexaoSQL() As String
        Get
            Return _strConexaoSQL
        End Get
    End Property
    'Sub New()
    '    _iTamanhoPaginaGrid = 20
    '    _strConexao = System.Configuration.ConfigurationSettings.AppSettings("StringConexão").ToString & System.Web.HttpServerUtility.MapPath("\dados\Imaging.mdb")
    'End Sub
    Sub New(ByVal Server As HttpServerUtility)
        _iTamanhoPaginaGrid = 20
        ' _strConexao = System.Configuration.ConfigurationSettings.AppSettings("StringConexãoLocal").ToString
        _strConexao = System.Configuration.ConfigurationSettings.AppSettings("StringConexãoProd").ToString '& ";user id=logonhost;password=q1w2e3r4"
        ' _strConexaoSQL = System.Configuration.ConfigurationSettings.AppSettings("StringConexãoProdSQL").ToString '& ";user id=logonhost;password=q1w2e3r4"
    End Sub

End Class
