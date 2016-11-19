Public Partial Class welcome
    Inherits System.Web.UI.Page
    Dim Config As New clsConfiguracao(Server)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim socio As New clsSocio
        Dim Olecn As New OleDb.OleDbConnection
        Olecn.ConnectionString = Config.StringConexao
        socio.oleConexão = Olecn
        ' Pegar o novo do Sócio
        socio.Recuperar(User.Identity.Name)

        Me.lblData.Text = "Hoje é " & System.DateTime.Now.ToLongDateString


        ' If User.Identity.Name = "Contador" Then
        '    Response.Redirect("../Contador/default.aspx")
        ' Else
        If socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("extratomensal.aspx")
        End If


        'Put user code to initialize the page here

    End Sub

End Class