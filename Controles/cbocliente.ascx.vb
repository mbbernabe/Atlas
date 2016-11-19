Public Partial Class cbocliente1
    Inherits System.Web.UI.UserControl

    Dim daCliente As dsClienteTableAdapters.CLIENTETableAdapter = New dsClienteTableAdapters.CLIENTETableAdapter()
    Dim _codCliente As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            'abrirConexão(OleCn)
            'Me.OleDaCliente.SelectCommand.Connection = OleCn
            Me.ddlCliente.DataSource = daCliente.GetData()
            Me.ddlCliente.DataBind()
            ddlCliente.SelectedIndex = Me.ddlCliente.Items.IndexOf(ddlCliente.Items.FindByValue(_codCliente))
        End If
    End Sub

    Property CssClass() As String
        Get
            Return Me.ddlCliente.CssClass
        End Get
        Set(ByVal Value As String)
            Me.ddlCliente.CssClass = Value
        End Set
    End Property

    ReadOnly Property SelectedItem() As ListItem
        Get
            Return Me.ddlCliente.SelectedItem
        End Get
    End Property

    Property SelectedIndex() As Integer
        Get
            Return Me.ddlCliente.SelectedIndex
        End Get
        Set(ByVal Value As Integer)
            Me.ddlCliente.SelectedIndex = Value
        End Set
    End Property

    ReadOnly Property Items() As ListItemCollection
        Get
            Return Me.ddlCliente.Items
        End Get
    End Property

    Property Enabled() As Boolean
        Get
            Return Me.ddlCliente.Enabled
        End Get
        Set(ByVal Value As Boolean)
            ddlCliente.Enabled = Value
        End Set
    End Property
    WriteOnly Property SetarCliente() As String
        Set(ByVal Value As String)
            _codCliente = Value

        End Set

    End Property


End Class