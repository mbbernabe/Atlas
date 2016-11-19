Public Partial Class DesejaSair1
    Inherits System.Web.UI.Page
    Dim Config As New clsConfiguracao(Server)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnNao_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNao.Click
        Dim olecn As New OleDb.OleDbConnection()
        olecn.ConnectionString = Config.StringConexao
        Dim socio As New clsSocio()
        socio.oleConexão = olecn

        Response.Redirect("Administracao/default.aspx")
     
    End Sub

    Protected Sub btnSim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSim.Click
        FormsAuthentication.SignOut()
        Dim Context As HttpContext = HttpContext.Current

        ' Sign Out
        FormsAuthentication.SignOut()
        Response.Redirect("default.aspx")
    End Sub
End Class