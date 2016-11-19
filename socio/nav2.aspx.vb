Public Partial Class nav1
    Inherits System.Web.UI.Page

    Dim Config As New clsConfiguracao(Server)
    'Dim MenuSocio1 As menuSocio
    Dim mNomeFilme As String
    Dim cb As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim socio As New clsSocio
        Dim login As New clslogin

        Dim Olecn As New OleDb.OleDbConnection()
        Olecn.ConnectionString = Config.StringConexao
        socio.oleConexão = Olecn
        login.oleConexão = Olecn
        If User.Identity.Name = "Contador" Then
            Response.Write("MenuContador")
        Else
            'If socio.NivelAcesso(User.Identity.Name) = 1 Then
            ' If login.NivelAcesso(User.Identity.Name) = 1 Then
            'Me.NomeFilme = DefinirNomeFilme("Administrador")  '"../flash/menu_adimin.swf "
            ' ElseIf login.NivelAcesso(User.Identity.Name) = 2 Then
            ' Me.NomeFilme = DefinirNomeFilme("Socio")
            'End If
        End If
    End Sub
    Property NomeFilme() As String
        Get
            NomeFilme = mNomeFilme
        End Get
        Set(ByVal Value As String)
            mNomeFilme = Value
        End Set
    End Property
    Property ClasseBody() As String
        Get
            ClasseBody = cb
        End Get
        Set(ByVal Value As String)
            cb = Value
        End Set
    End Property

    Private Function DefinirNomeFilme(ByVal tipoMenu As String) As String
        Dim nvc As NameValueCollection = CType(ConfigurationSettings.GetConfig("Imaging/MenuFlash"), NameValueCollection)
        Dim retorno As String = ""

        Select Case tipoMenu
            Case "Administrador"
                retorno = "../" & nvc("NomeFilmeAdministrador")
                cb = "bgadmin padleft40"
            Case "Socio"
                retorno = "../" & nvc("NomeFilmeSocio")
                cb = ""
            Case "Contador"
                retorno = "../" & nvc("NomeFilmeContador")
                cb = ""
        End Select

        Return retorno
    End Function
End Class