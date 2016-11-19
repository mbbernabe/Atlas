Public Partial Class NaturezaDesconto
    Inherits System.Web.UI.Page
    'Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    'Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    'Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    'Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    'Protected WithEvents OleDaNaturDesc As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents DsNaturDesc As dsNaturDesc
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection




    '#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    '<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    '    Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
    '    Me.OleCn = New System.Data.OleDb.OleDbConnection()
    '    Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
    '    Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
    '    Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()

    '    '
    '    'OleDbSelectCommand1
    '    '
    '    Me.OleDbSelectCommand1.CommandText = "SELECT CODNATDESP, DSCNATDESP FROM NATUREZADESPESA"
    '    Me.OleDbSelectCommand1.Connection = Me.OleCn
    '    '
    '    'OleCn
    '    '
    '    Me.OleCn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub" & _
    '    "\wwwroot\ImagingRio2\Dados\ImagingNet.mdb;Mode=Share Deny None;Extended Properti" & _
    '    "es="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database" & _
    '    " Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB" & _
    '    ":Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Da" & _
    '    "tabase Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Data" & _
    '    "base=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Withou" & _
    '    "t Replica Repair=False;Jet OLEDB:SFP=False"
    '    '
    '    'OleDbInsertCommand1
    '    '
    '    Me.OleDbInsertCommand1.CommandText = "INSERT INTO NATUREZADESPESA(CODNATDESP, DSCNATDESP) VALUES (?, ?)"
    '    Me.OleDbInsertCommand1.Connection = Me.OleCn
    '    Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESP", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESP"))
    '    Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DSCNATDESP", System.Data.OleDb.OleDbType.VarWChar, 100, "DSCNATDESP"))
    '    '
    '    'OleDbUpdateCommand1
    '    '
    '    Me.OleDbUpdateCommand1.CommandText = "UPDATE NATUREZADESPESA SET CODNATDESP = ?, DSCNATDESP = ? WHERE (CODNATDESP = ?) " & _
    '    "AND (DSCNATDESP = ? OR ? IS NULL AND DSCNATDESP IS NULL)"
    '    Me.OleDbUpdateCommand1.Connection = Me.OleCn
    '    Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESP", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESP"))
    '    Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DSCNATDESP", System.Data.OleDb.OleDbType.VarWChar, 100, "DSCNATDESP"))
    '    Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESP", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESP", System.Data.DataRowVersion.Original, Nothing))
    '    Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESP", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESP", System.Data.DataRowVersion.Original, Nothing))
    '    Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESP1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESP", System.Data.DataRowVersion.Original, Nothing))
    '    '
    '    'OleDbDeleteCommand1
    '    '
    '    Me.OleDbDeleteCommand1.CommandText = "DELETE FROM NATUREZADESPESA WHERE (CODNATDESP = ?) AND (DSCNATDESP = ? OR ? IS NU" & _
    '    "LL AND DSCNATDESP IS NULL)"
    '    Me.OleDbDeleteCommand1.Connection = Me.OleCn
    '    Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESP", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESP", System.Data.DataRowVersion.Original, Nothing))
    '    Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESP", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESP", System.Data.DataRowVersion.Original, Nothing))
    '    Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESP1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESP", System.Data.DataRowVersion.Original, Nothing))

    'End Sub

    'Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
    '    'CODEGEN: This method call is required by the Web Form Designer
    '    'Do not modify it using the code editor.
    '    InitializeComponent()
    'End Sub

    '#End Region



    Const NomeTabela As String = "NATUREZADESCONTO"
    Const NomeCampoCodigo As String = "CODNATDESC"
    Const NomeCampoDescrição As String = "DSCNATDESC"

    Dim Config As New clsConfiguracao(Server)
    Dim Socio As New clsSocio()
    Dim codDesc As New clsCodDescricao()



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Put user code to initialize the page here
        Me.OleCn = New System.Data.OleDb.OleDbConnection
        OleCn.ConnectionString = Config.StringConexao
        Socio.oleConexão = OleCn
        If Socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("AcessoNaoPermitido.aspx")
        End If
        Me.grd.PageSize = Config.TamanhoPaginaGrid
        codDesc.NomeTabela = NomeTabela
        codDesc.CampoCodigo = NomeCampoCodigo
        codDesc.CampoDescrição = NomeCampoDescrição
        codDesc.oleConexão = OleCn
        If Not Page.IsPostBack Then
            PreencherGrid()
        End If
    End Sub
    ' Preenche a grid da tela com os dados do bd
    Private Sub PreencherGrid()

        'Novo Código
        Dim daNaturDesc As dsNaturDescTableAdapters.NATUREZADESCONTOTableAdapter = New dsNaturDescTableAdapters.NATUREZADESCONTOTableAdapter()
        Me.grd.DataSource = daNaturDesc.GetData
        Me.grd.DataBind()
        Me.OleCn.Close()


    End Sub
    ' Exibe mensagens na tela
    Private Sub ExibirMensagem(ByVal msg As String)
        Response.Write(msg)
    End Sub

    'Inclui um item na grid
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        If Me.txtIncluir.Text.Trim <> "" Then
            If Not codDesc.ExistePorDescrição(Me.txtIncluir.Text) Then
                codDesc.Insert(Me.txtIncluir.Text)
                Me.txtIncluir.Text = ""
                PreencherGrid()
            Else
                ExibirMensagem("Item já existe na lista")
            End If
        End If
    End Sub



    Private Sub grd_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.EditCommand
        grd.EditItemIndex = e.Item.ItemIndex
        PreencherGrid()
        ' grd.DataBind()
    End Sub

    Private Sub grd_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.CancelCommand
        grd.EditItemIndex = -1
        PreencherGrid()
    End Sub





    Private Sub grd_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.UpdateCommand
        Dim Codigo As String
        Dim dsc As String
        Dim auxTextBox As TextBox
        Codigo = e.Item.Cells(0).Text()
        auxTextBox = CType(e.Item.Cells(1).Controls(0), TextBox)
        dsc = auxTextBox.Text
        codDesc.Update(dsc, Codigo)
        grd.EditItemIndex = -1
        PreencherGrid()
    End Sub

    Private Sub grd_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grd.ItemCommand
        Try
            Select Case e.CommandName
                Case "Delete"
                    codDesc.oleConexão = Me.OleCn
                    codDesc.Excluir(e.Item().Cells(0).Text)
                    PreencherGrid()
            End Select
        Catch Err As OleDb.OleDbException
            Select Case Err.ErrorCode
                Case -2147467259
                    ExibirMensagem("Não foi possível excluir o item, pois está relacionada à outros itens.")
            End Select
        Catch Err As Exception
            ExibirMensagem(Err.Message.ToString)
        End Try
    End Sub

End Class