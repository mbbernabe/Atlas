Public Partial Class txtAno1
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Property Text() As String
        Get
            Text = Me.Text1.Text
        End Get
        Set(ByVal Value As String)
            Me.Text1.Text = Value
        End Set
    End Property

    Property CssClass() As String
        Get
            CssClass = Me.Text1.CssClass
        End Get

        Set(ByVal Value As String)
            Me.Text1.CssClass = Value

        End Set
    End Property
    Public Property AutoPostBack() As Boolean
        Get
            AutoPostBack = Me.Text1.AutoPostBack
        End Get
        Set(ByVal Value As Boolean)
            Me.Text1.AutoPostBack = Value
        End Set
    End Property
End Class