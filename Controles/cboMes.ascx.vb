Public Partial Class cboMes1
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MontarCombo()
    End Sub
    Sub MontarCombo()
        Dim Mes As ListItem

        Mes = New ListItem()
        Mes.Text = "Janeiro"
        Mes.Value = "01"
        Me.ddlMes.Items.Add(Mes)
        'lsMes.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Fevereiro"
        Mes.Value = "02"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Março"
        Mes.Value = "03"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Abril"
        Mes.Value = "04"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Maio"
        Mes.Value = "05"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Junho"
        Mes.Value = "06"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Julho"
        Mes.Value = "07"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Agosto"
        Mes.Value = "08"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Setembro"
        Mes.Value = "09"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Outubro"
        Mes.Value = "10"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Novembro"
        Mes.Value = "11"
        Me.ddlMes.Items.Add(Mes)

        Mes = New ListItem()
        Mes.Text = "Dezembro"
        Mes.Value = "12"
        Me.ddlMes.Items.Add(Mes)

    End Sub

    Public ReadOnly Property MesSelecionado() As String
        Get
            Return (Me.ddlMes.SelectedItem.Value)
        End Get
    End Property


    Public Property CssClass() As String
        Get
            CssClass = Me.ddlMes.CssClass
        End Get
        Set(ByVal Value As String)
            Me.ddlMes.CssClass = Value
        End Set
    End Property

    Public Property AutoPostBack() As Boolean
        Get
            AutoPostBack = Me.ddlMes.AutoPostBack
        End Get
        Set(ByVal Value As Boolean)
            Me.ddlMes.AutoPostBack = Value
        End Set
    End Property
End Class