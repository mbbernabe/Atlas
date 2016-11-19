Imports System.Web.Security
Public Class DesejaSair
    Inherits System.Web.UI.Page
    Protected WithEvents btnSim As System.Web.UI.WebControls.Button
    Protected WithEvents btnNao As System.Web.UI.WebControls.Button

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Dim Config As New clsConfiguracao(Server)
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub

    Private Sub btnNao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNao.Click
        Dim olecn As New OleDb.OleDbConnection()
        olecn.ConnectionString = Config.StringConexao
        Dim socio As New clsSocio()
        socio.oleConexão = olecn
        If User.Identity.Name = "Contador" Then
            Response.Redirect("Contador/default.aspx")
        Else
            Select Case socio.NivelAcesso(User.Identity.Name)
                Case 1
                    Response.Redirect("Administracao/default.aspx")
                Case 2
                    Response.Redirect("Socio/default.aspx")

            End Select

            'If socio.NivelAcesso(User.Identity.Name) = 1 Then
            '    Response.Redirect("Socio/default.aspx")
            'End If
        End If
    End Sub

    Private Sub btnSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSim.Click
        FormsAuthentication.SignOut()
        Dim Context As HttpContext = HttpContext.Current

        ' Sign Out
        FormsAuthentication.SignOut()
        Response.Redirect("default.aspx")

    End Sub
End Class
