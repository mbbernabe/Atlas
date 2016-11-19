Public Partial Class cboConfirmação1
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public ReadOnly Property Confirmado() As Boolean
        Get
            Dim ret As Boolean
            If Me.ddlConfirmação.SelectedItem.Value = "Confirmados" Then
                ret = True
            Else
                ret = False
            End If
            Return ret
        End Get
    End Property

    Property CssClass() As String
        Get
            CssClass = Me.ddlConfirmação.CssClass
        End Get
        Set(ByVal Value As String)
            Me.ddlConfirmação.CssClass = Value
        End Set
    End Property

End Class