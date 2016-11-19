Public Partial Class cboSocio1
    Inherits System.Web.UI.UserControl

    Dim daSocio As dsSocioTableAdapters.SOCIOTableAdapter = New dsSocioTableAdapters.SOCIOTableAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Put user code to initialize the page here
        If Not Page.IsPostBack Then
            Me.DropDownList1.DataSource = daSocio.GetData()
            Me.DropDownList1.DataBind()
           
        End If
    End Sub
    ReadOnly Property SelectedItem() As ListItem
        Get
            Return Me.DropDownList1.SelectedItem
        End Get
    End Property
    Property CssClass() As String
        Get
            Return Me.DropDownList1.CssClass
        End Get
        Set(ByVal Value As String)
            Me.DropDownList1.CssClass = Value
        End Set
    End Property

   

    Property Enabled() As Boolean
        Get
            Return Me.DropDownList1.Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me.DropDownList1.Enabled = Value
        End Set
    End Property
End Class