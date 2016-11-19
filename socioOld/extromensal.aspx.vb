Public Class extromensalSocio
    Inherits System.Web.UI.Page
    Protected WithEvents ddlSocio As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlMes As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnEnviar As System.Web.UI.WebControls.Button
    Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Protected WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaCliente As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDaFaturamento As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaSocio As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents txtAno As System.Web.UI.WebControls.TextBox
    Protected WithEvents OleDaDetFatView As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    'Protected WithEvents DsExtratoMensal1 As ImagingRio2.DsExtratoMensal
    Protected WithEvents OleDbSelectCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OledaDetFat As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDaLancDescontos As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaNatDesconto As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents grdOutrosDescontos As System.Web.UI.WebControls.DataGrid
    Protected WithEvents OleDaOutrosDescView As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand7 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbSelectCommand8 As System.Data.OleDb.OleDbCommand
    Protected WithEvents Repeater1 As System.Web.UI.WebControls.Repeater
    Protected WithEvents lblFatBruto As System.Web.UI.WebControls.Label
    Protected WithEvents lblIRRF As System.Web.UI.WebControls.Label
    Protected WithEvents lblImpostos As System.Web.UI.WebControls.Label
    Protected WithEvents lblSubSaldoParcial As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotMenosImpostos As System.Web.UI.WebControls.Label
    Protected WithEvents lblTotOutrosDescontos As System.Web.UI.WebControls.Label
    Protected WithEvents grd As System.Web.UI.WebControls.DataGrid
    Protected WithEvents OleDbSelectCommand9 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaTpDesconto As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents DsExtratoMensal1 As ImagingRio2.DsExtratoMensal
    Protected WithEvents lblTotFinal As System.Web.UI.WebControls.Label

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleCn = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaCliente = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaFaturamento = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaSocio = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDaDetFatView = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OledaDetFat = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDaLancDescontos = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaNatDesconto = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand7 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaOutrosDescView = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand8 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand9 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaTpDesconto = New System.Data.OleDb.OleDbDataAdapter()
        Me.DsExtratoMensal1 = New ImagingRio2.DsExtratoMensal()
        CType(Me.DsExtratoMensal1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT BAIRRO, CEP, CIDADE, CNPJ, CODCLIENTE, COMPLEMENTO, DDDTEL1, DDDTEL2, DDDT" & _
        "EL3, DDDTEL4, DTALTERACAO, EMAIL, IE, LOGRADOURO, NOME, NUMERO, SIGLAUF, TELEFON" & _
        "E1, TELEFONE2, TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELEFONE2, TPT" & _
        "ELEFONE3, TPTELEFONE4, USUARIO FROM CLIENTE ORDER BY NOME"
        Me.OleDbSelectCommand1.Connection = Me.OleCn
        '
        'OleCn
        '
        Me.OleCn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub" & _
        "\wwwroot\Dados\Imaging.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB" & _
        ":System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Je" & _
        "t OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial" & _
        " Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password" & _
        "="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet " & _
        "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" & _
        "r=False;Jet OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO CLIENTE(BAIRRO, CEP, CIDADE, CNPJ, CODCLIENTE, COMPLEMENTO, DDDTEL1, " & _
        "DDDTEL2, DDDTEL3, DDDTEL4, DTALTERACAO, EMAIL, IE, LOGRADOURO, NOME, NUMERO, SIG" & _
        "LAUF, TELEFONE1, TELEFONE2, TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPT" & _
        "ELEFONE2, TPTELEFONE3, TPTELEFONE4, USUARIO) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, " & _
        "?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleCn
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, "CNPJ"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IE", System.Data.OleDb.OleDbType.VarWChar, 20, "IE"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, "SIGLAUF"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE CLIENTE SET BAIRRO = ?, CEP = ?, CIDADE = ?, CNPJ = ?, CODCLIENTE = ?, COM" & _
        "PLEMENTO = ?, DDDTEL1 = ?, DDDTEL2 = ?, DDDTEL3 = ?, DDDTEL4 = ?, DTALTERACAO = " & _
        "?, EMAIL = ?, IE = ?, LOGRADOURO = ?, NOME = ?, NUMERO = ?, SIGLAUF = ?, TELEFON" & _
        "E1 = ?, TELEFONE2 = ?, TELEFONE3 = ?, TELEFONE4 = ?, TPLOGRADOURO = ?, TPTELEFON" & _
        "E1 = ?, TPTELEFONE2 = ?, TPTELEFONE3 = ?, TPTELEFONE4 = ?, USUARIO = ? WHERE (CO" & _
        "DCLIENTE = ?) AND (BAIRRO = ? OR ? IS NULL AND BAIRRO IS NULL) AND (CEP = ? OR ?" & _
        " IS NULL AND CEP IS NULL) AND (CIDADE = ? OR ? IS NULL AND CIDADE IS NULL) AND (" & _
        "CNPJ = ? OR ? IS NULL AND CNPJ IS NULL) AND (COMPLEMENTO = ? OR ? IS NULL AND CO" & _
        "MPLEMENTO IS NULL) AND (DDDTEL1 = ? OR ? IS NULL AND DDDTEL1 IS NULL) AND (DDDTE" & _
        "L2 = ? OR ? IS NULL AND DDDTEL2 IS NULL) AND (DDDTEL3 = ? OR ? IS NULL AND DDDTE" & _
        "L3 IS NULL) AND (DDDTEL4 = ? OR ? IS NULL AND DDDTEL4 IS NULL) AND (DTALTERACAO " & _
        "= ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (EMAIL = ? OR ? IS NULL AND EMAIL " & _
        "IS NULL) AND (IE = ? OR ? IS NULL AND IE IS NULL) AND (LOGRADOURO = ? OR ? IS NU" & _
        "LL AND LOGRADOURO IS NULL) AND (NOME = ? OR ? IS NULL AND NOME IS NULL) AND (NUM" & _
        "ERO = ? OR ? IS NULL AND NUMERO IS NULL) AND (SIGLAUF = ? OR ? IS NULL AND SIGLA" & _
        "UF IS NULL) AND (TELEFONE1 = ? OR ? IS NULL AND TELEFONE1 IS NULL) AND (TELEFONE" & _
        "2 = ? OR ? IS NULL AND TELEFONE2 IS NULL) AND (TELEFONE3 = ? OR ? IS NULL AND TE" & _
        "LEFONE3 IS NULL) AND (TELEFONE4 = ? OR ? IS NULL AND TELEFONE4 IS NULL) AND (TPL" & _
        "OGRADOURO = ? OR ? IS NULL AND TPLOGRADOURO IS NULL) AND (TPTELEFONE1 = ? OR ? I" & _
        "S NULL AND TPTELEFONE1 IS NULL) AND (TPTELEFONE2 = ? OR ? IS NULL AND TPTELEFONE" & _
        "2 IS NULL) AND (TPTELEFONE3 = ? OR ? IS NULL AND TPTELEFONE3 IS NULL) AND (TPTEL" & _
        "EFONE4 = ? OR ? IS NULL AND TPTELEFONE4 IS NULL) AND (USUARIO = ? OR ? IS NULL A" & _
        "ND USUARIO IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleCn
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, "CNPJ"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IE", System.Data.OleDb.OleDbType.VarWChar, 20, "IE"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, "SIGLAUF"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ1", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM CLIENTE WHERE (CODCLIENTE = ?) AND (BAIRRO = ? OR ? IS NULL AND BAIRR" & _
        "O IS NULL) AND (CEP = ? OR ? IS NULL AND CEP IS NULL) AND (CIDADE = ? OR ? IS NU" & _
        "LL AND CIDADE IS NULL) AND (CNPJ = ? OR ? IS NULL AND CNPJ IS NULL) AND (COMPLEM" & _
        "ENTO = ? OR ? IS NULL AND COMPLEMENTO IS NULL) AND (DDDTEL1 = ? OR ? IS NULL AND" & _
        " DDDTEL1 IS NULL) AND (DDDTEL2 = ? OR ? IS NULL AND DDDTEL2 IS NULL) AND (DDDTEL" & _
        "3 = ? OR ? IS NULL AND DDDTEL3 IS NULL) AND (DDDTEL4 = ? OR ? IS NULL AND DDDTEL" & _
        "4 IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (EMAIL" & _
        " = ? OR ? IS NULL AND EMAIL IS NULL) AND (IE = ? OR ? IS NULL AND IE IS NULL) AN" & _
        "D (LOGRADOURO = ? OR ? IS NULL AND LOGRADOURO IS NULL) AND (NOME = ? OR ? IS NUL" & _
        "L AND NOME IS NULL) AND (NUMERO = ? OR ? IS NULL AND NUMERO IS NULL) AND (SIGLAU" & _
        "F = ? OR ? IS NULL AND SIGLAUF IS NULL) AND (TELEFONE1 = ? OR ? IS NULL AND TELE" & _
        "FONE1 IS NULL) AND (TELEFONE2 = ? OR ? IS NULL AND TELEFONE2 IS NULL) AND (TELEF" & _
        "ONE3 = ? OR ? IS NULL AND TELEFONE3 IS NULL) AND (TELEFONE4 = ? OR ? IS NULL AND" & _
        " TELEFONE4 IS NULL) AND (TPLOGRADOURO = ? OR ? IS NULL AND TPLOGRADOURO IS NULL)" & _
        " AND (TPTELEFONE1 = ? OR ? IS NULL AND TPTELEFONE1 IS NULL) AND (TPTELEFONE2 = ?" & _
        " OR ? IS NULL AND TPTELEFONE2 IS NULL) AND (TPTELEFONE3 = ? OR ? IS NULL AND TPT" & _
        "ELEFONE3 IS NULL) AND (TPTELEFONE4 = ? OR ? IS NULL AND TPTELEFONE4 IS NULL) AND" & _
        " (USUARIO = ? OR ? IS NULL AND USUARIO IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleCn
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ1", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaCliente
        '
        Me.OleDaCliente.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDaCliente.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDaCliente.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDaCliente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CLIENTE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODCLIENTE", "CODCLIENTE"), New System.Data.Common.DataColumnMapping("SIGLAUF", "SIGLAUF"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("EMAIL", "EMAIL"), New System.Data.Common.DataColumnMapping("CNPJ", "CNPJ"), New System.Data.Common.DataColumnMapping("IE", "IE"), New System.Data.Common.DataColumnMapping("TPLOGRADOURO", "TPLOGRADOURO"), New System.Data.Common.DataColumnMapping("LOGRADOURO", "LOGRADOURO"), New System.Data.Common.DataColumnMapping("NUMERO", "NUMERO"), New System.Data.Common.DataColumnMapping("COMPLEMENTO", "COMPLEMENTO"), New System.Data.Common.DataColumnMapping("CIDADE", "CIDADE"), New System.Data.Common.DataColumnMapping("BAIRRO", "BAIRRO"), New System.Data.Common.DataColumnMapping("CEP", "CEP"), New System.Data.Common.DataColumnMapping("TELEFONE1", "TELEFONE1"), New System.Data.Common.DataColumnMapping("TELEFONE2", "TELEFONE2"), New System.Data.Common.DataColumnMapping("TELEFONE3", "TELEFONE3"), New System.Data.Common.DataColumnMapping("TELEFONE4", "TELEFONE4"), New System.Data.Common.DataColumnMapping("TPTELEFONE1", "TPTELEFONE1"), New System.Data.Common.DataColumnMapping("TPTELEFONE2", "TPTELEFONE2"), New System.Data.Common.DataColumnMapping("TPTELEFONE3", "TPTELEFONE3"), New System.Data.Common.DataColumnMapping("TPTELEFONE4", "TPTELEFONE4"), New System.Data.Common.DataColumnMapping("DDDTEL1", "DDDTEL1"), New System.Data.Common.DataColumnMapping("DDDTEL2", "DDDTEL2"), New System.Data.Common.DataColumnMapping("DDDTEL3", "DDDTEL3"), New System.Data.Common.DataColumnMapping("DDDTEL4", "DDDTEL4"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO")})})
        Me.OleDaCliente.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT AUDITADO, CODCLIENTE, CODFATURAMENTO, DTALTERACAO, DTFATURAMENTO, NUMNF, U" & _
        "SUARIO, VALORFATURAMENTOBRUTO FROM FATURAMENTO"
        Me.OleDbSelectCommand2.Connection = Me.OleCn
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO FATURAMENTO(AUDITADO, CODCLIENTE, CODFATURAMENTO, DTALTERACAO, DTFATU" & _
        "RAMENTO, NUMNF, USUARIO, VALORFATURAMENTOBRUTO) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleCn
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, "AUDITADO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODFATURAMENTO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, "DTFATURAMENTO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, "NUMNF"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE FATURAMENTO SET AUDITADO = ?, CODCLIENTE = ?, CODFATURAMENTO = ?, DTALTERA" & _
        "CAO = ?, DTFATURAMENTO = ?, NUMNF = ?, USUARIO = ?, VALORFATURAMENTOBRUTO = ? WH" & _
        "ERE (CODFATURAMENTO = ?) AND (AUDITADO = ?) AND (CODCLIENTE = ? OR ? IS NULL AND" & _
        " CODCLIENTE IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) " & _
        "AND (DTFATURAMENTO = ? OR ? IS NULL AND DTFATURAMENTO IS NULL) AND (NUMNF = ? OR" & _
        " ? IS NULL AND NUMNF IS NULL) AND (USUARIO = ? OR ? IS NULL AND USUARIO IS NULL)" & _
        " AND (VALORFATURAMENTOBRUTO = ? OR ? IS NULL AND VALORFATURAMENTOBRUTO IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleCn
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, "AUDITADO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODFATURAMENTO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, "DTFATURAMENTO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, "NUMNF"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AUDITADO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM FATURAMENTO WHERE (CODFATURAMENTO = ?) AND (AUDITADO = ?) AND (CODCLI" & _
        "ENTE = ? OR ? IS NULL AND CODCLIENTE IS NULL) AND (DTALTERACAO = ? OR ? IS NULL " & _
        "AND DTALTERACAO IS NULL) AND (DTFATURAMENTO = ? OR ? IS NULL AND DTFATURAMENTO I" & _
        "S NULL) AND (NUMNF = ? OR ? IS NULL AND NUMNF IS NULL) AND (USUARIO = ? OR ? IS " & _
        "NULL AND USUARIO IS NULL) AND (VALORFATURAMENTOBRUTO = ? OR ? IS NULL AND VALORF" & _
        "ATURAMENTOBRUTO IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleCn
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AUDITADO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaFaturamento
        '
        Me.OleDaFaturamento.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDaFaturamento.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDaFaturamento.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDaFaturamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FATURAMENTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODFATURAMENTO", "CODFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODCLIENTE", "CODCLIENTE"), New System.Data.Common.DataColumnMapping("DTFATURAMENTO", "DTFATURAMENTO"), New System.Data.Common.DataColumnMapping("VALORFATURAMENTOBRUTO", "VALORFATURAMENTOBRUTO"), New System.Data.Common.DataColumnMapping("NUMNF", "NUMNF"), New System.Data.Common.DataColumnMapping("AUDITADO", "AUDITADO"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO")})})
        Me.OleDaFaturamento.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT AGENCIA, BAIRRO, CEP, CIDADE, CODNIVELACESSO, CODSOCIO, COMPLEMENTO, CPF, " & _
        "CRM, DATAENTRADA, DDDTEL1, DDDTEL2, DDDTEL3, DDDTEL4, DTALTERACAO, EMAIL, EXCLUI" & _
        "DO, IDENTIDADE, LOGRADOURO, NOME, NOMEUSUARIO, NUMBANCO, NUMERO, SENHA, TELEFONE" & _
        "1, TELEFONE2, TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELEFONE2, TPTE" & _
        "LEFONE3, TPTELEFONE4, UF, USUARIO FROM SOCIO"
        Me.OleDbSelectCommand3.Connection = Me.OleCn
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO SOCIO(AGENCIA, BAIRRO, CEP, CIDADE, CODNIVELACESSO, CODSOCIO, COMPLEM" & _
        "ENTO, CPF, CRM, DATAENTRADA, DDDTEL1, DDDTEL2, DDDTEL3, DDDTEL4, DTALTERACAO, EM" & _
        "AIL, EXCLUIDO, IDENTIDADE, LOGRADOURO, NOME, NOMEUSUARIO, NUMBANCO, NUMERO, SENH" & _
        "A, TELEFONE1, TELEFONE2, TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELE" & _
        "FONE2, TPTELEFONE3, TPTELEFONE4, UF, USUARIO) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?," & _
        " ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleCn
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, "AGENCIA"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNIVELACESSO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CPF", System.Data.OleDb.OleDbType.VarWChar, 30, "CPF"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CRM", System.Data.OleDb.OleDbType.VarWChar, 50, "CRM"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, "DATAENTRADA"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EXCLUIDO", System.Data.OleDb.OleDbType.Boolean, 2, "EXCLUIDO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, "IDENTIDADE"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "NOMEUSUARIO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, "NUMBANCO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, "SENHA"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("UF", System.Data.OleDb.OleDbType.VarWChar, 2, "UF"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE SOCIO SET AGENCIA = ?, BAIRRO = ?, CEP = ?, CIDADE = ?, CODNIVELACESSO = ?" & _
        ", CODSOCIO = ?, COMPLEMENTO = ?, CPF = ?, CRM = ?, DATAENTRADA = ?, DDDTEL1 = ?," & _
        " DDDTEL2 = ?, DDDTEL3 = ?, DDDTEL4 = ?, DTALTERACAO = ?, EMAIL = ?, EXCLUIDO = ?" & _
        ", IDENTIDADE = ?, LOGRADOURO = ?, NOME = ?, NOMEUSUARIO = ?, NUMBANCO = ?, NUMER" & _
        "O = ?, SENHA = ?, TELEFONE1 = ?, TELEFONE2 = ?, TELEFONE3 = ?, TELEFONE4 = ?, TP" & _
        "LOGRADOURO = ?, TPTELEFONE1 = ?, TPTELEFONE2 = ?, TPTELEFONE3 = ?, TPTELEFONE4 =" & _
        " ?, UF = ?, USUARIO = ? WHERE (CODSOCIO = ?) AND (AGENCIA = ? OR ? IS NULL AND A" & _
        "GENCIA IS NULL) AND (BAIRRO = ? OR ? IS NULL AND BAIRRO IS NULL) AND (CEP = ? OR" & _
        " ? IS NULL AND CEP IS NULL) AND (CIDADE = ? OR ? IS NULL AND CIDADE IS NULL) AND" & _
        " (CODNIVELACESSO = ? OR ? IS NULL AND CODNIVELACESSO IS NULL) AND (COMPLEMENTO =" & _
        " ? OR ? IS NULL AND COMPLEMENTO IS NULL) AND (CPF = ? OR ? IS NULL AND CPF IS NU" & _
        "LL) AND (CRM = ? OR ? IS NULL AND CRM IS NULL) AND (DATAENTRADA = ? OR ? IS NULL" & _
        " AND DATAENTRADA IS NULL) AND (DDDTEL1 = ? OR ? IS NULL AND DDDTEL1 IS NULL) AND" & _
        " (DDDTEL2 = ? OR ? IS NULL AND DDDTEL2 IS NULL) AND (DDDTEL3 = ? OR ? IS NULL AN" & _
        "D DDDTEL3 IS NULL) AND (DDDTEL4 = ? OR ? IS NULL AND DDDTEL4 IS NULL) AND (DTALT" & _
        "ERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (EMAIL = ? OR ? IS NULL AND" & _
        " EMAIL IS NULL) AND (EXCLUIDO = ?) AND (IDENTIDADE = ? OR ? IS NULL AND IDENTIDA" & _
        "DE IS NULL) AND (LOGRADOURO = ? OR ? IS NULL AND LOGRADOURO IS NULL) AND (NOME =" & _
        " ? OR ? IS NULL AND NOME IS NULL) AND (NOMEUSUARIO = ? OR ? IS NULL AND NOMEUSUA" & _
        "RIO IS NULL) AND (NUMBANCO = ? OR ? IS NULL AND NUMBANCO IS NULL) AND (NUMERO = " & _
        "? OR ? IS NULL AND NUMERO IS NULL) AND (SENHA = ? OR ? IS NULL AND SENHA IS NULL" & _
        ") AND (TELEFONE1 = ? OR ? IS NULL AND TELEFONE1 IS NULL) AND (TELEFONE2 = ? OR ?" & _
        " IS NULL AND TELEFONE2 IS NULL) AND (TELEFONE3 = ? OR ? IS NULL AND TELEFONE3 IS" & _
        " NULL) AND (TELEFONE4 = ? OR ? IS NULL AND TELEFONE4 IS NULL) AND (TPLOGRADOURO " & _
        "= ? OR ? IS NULL AND TPLOGRADOURO IS NULL) AND (TPTELEFONE1 = ? OR ? IS NULL AND" & _
        " TPTELEFONE1 IS NULL) AND (TPTELEFONE2 = ? OR ? IS NULL AND TPTELEFONE2 IS NULL)" & _
        " AND (TPTELEFONE3 = ? OR ? IS NULL AND TPTELEFONE3 IS NULL) AND (TPTELEFONE4 = ?" & _
        " OR ? IS NULL AND TPTELEFONE4 IS NULL) AND (UF = ? OR ? IS NULL AND UF IS NULL) " & _
        "AND (USUARIO = ? OR ? IS NULL AND USUARIO IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleCn
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, "AGENCIA"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNIVELACESSO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CPF", System.Data.OleDb.OleDbType.VarWChar, 30, "CPF"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CRM", System.Data.OleDb.OleDbType.VarWChar, 50, "CRM"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, "DATAENTRADA"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("EXCLUIDO", System.Data.OleDb.OleDbType.Boolean, 2, "EXCLUIDO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, "IDENTIDADE"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "NOMEUSUARIO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, "NUMBANCO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, "SENHA"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("UF", System.Data.OleDb.OleDbType.VarWChar, 2, "UF"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EXCLUIDO", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EXCLUIDO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM SOCIO WHERE (CODSOCIO = ?) AND (AGENCIA = ? OR ? IS NULL AND AGENCIA " & _
        "IS NULL) AND (BAIRRO = ? OR ? IS NULL AND BAIRRO IS NULL) AND (CEP = ? OR ? IS N" & _
        "ULL AND CEP IS NULL) AND (CIDADE = ? OR ? IS NULL AND CIDADE IS NULL) AND (CODNI" & _
        "VELACESSO = ? OR ? IS NULL AND CODNIVELACESSO IS NULL) AND (COMPLEMENTO = ? OR ?" & _
        " IS NULL AND COMPLEMENTO IS NULL) AND (CPF = ? OR ? IS NULL AND CPF IS NULL) AND" & _
        " (CRM = ? OR ? IS NULL AND CRM IS NULL) AND (DATAENTRADA = ? OR ? IS NULL AND DA" & _
        "TAENTRADA IS NULL) AND (DDDTEL1 = ? OR ? IS NULL AND DDDTEL1 IS NULL) AND (DDDTE" & _
        "L2 = ? OR ? IS NULL AND DDDTEL2 IS NULL) AND (DDDTEL3 = ? OR ? IS NULL AND DDDTE" & _
        "L3 IS NULL) AND (DDDTEL4 = ? OR ? IS NULL AND DDDTEL4 IS NULL) AND (DTALTERACAO " & _
        "= ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (EMAIL = ? OR ? IS NULL AND EMAIL " & _
        "IS NULL) AND (EXCLUIDO = ?) AND (IDENTIDADE = ? OR ? IS NULL AND IDENTIDADE IS N" & _
        "ULL) AND (LOGRADOURO = ? OR ? IS NULL AND LOGRADOURO IS NULL) AND (NOME = ? OR ?" & _
        " IS NULL AND NOME IS NULL) AND (NOMEUSUARIO = ? OR ? IS NULL AND NOMEUSUARIO IS " & _
        "NULL) AND (NUMBANCO = ? OR ? IS NULL AND NUMBANCO IS NULL) AND (NUMERO = ? OR ? " & _
        "IS NULL AND NUMERO IS NULL) AND (SENHA = ? OR ? IS NULL AND SENHA IS NULL) AND (" & _
        "TELEFONE1 = ? OR ? IS NULL AND TELEFONE1 IS NULL) AND (TELEFONE2 = ? OR ? IS NUL" & _
        "L AND TELEFONE2 IS NULL) AND (TELEFONE3 = ? OR ? IS NULL AND TELEFONE3 IS NULL) " & _
        "AND (TELEFONE4 = ? OR ? IS NULL AND TELEFONE4 IS NULL) AND (TPLOGRADOURO = ? OR " & _
        "? IS NULL AND TPLOGRADOURO IS NULL) AND (TPTELEFONE1 = ? OR ? IS NULL AND TPTELE" & _
        "FONE1 IS NULL) AND (TPTELEFONE2 = ? OR ? IS NULL AND TPTELEFONE2 IS NULL) AND (T" & _
        "PTELEFONE3 = ? OR ? IS NULL AND TPTELEFONE3 IS NULL) AND (TPTELEFONE4 = ? OR ? I" & _
        "S NULL AND TPTELEFONE4 IS NULL) AND (UF = ? OR ? IS NULL AND UF IS NULL) AND (US" & _
        "UARIO = ? OR ? IS NULL AND USUARIO IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleCn
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EXCLUIDO", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EXCLUIDO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaSocio
        '
        Me.OleDaSocio.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDaSocio.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDaSocio.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDaSocio.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SOCIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("EMAIL", "EMAIL"), New System.Data.Common.DataColumnMapping("IDENTIDADE", "IDENTIDADE"), New System.Data.Common.DataColumnMapping("CPF", "CPF"), New System.Data.Common.DataColumnMapping("DATAENTRADA", "DATAENTRADA"), New System.Data.Common.DataColumnMapping("TPLOGRADOURO", "TPLOGRADOURO"), New System.Data.Common.DataColumnMapping("LOGRADOURO", "LOGRADOURO"), New System.Data.Common.DataColumnMapping("NUMERO", "NUMERO"), New System.Data.Common.DataColumnMapping("COMPLEMENTO", "COMPLEMENTO"), New System.Data.Common.DataColumnMapping("CIDADE", "CIDADE"), New System.Data.Common.DataColumnMapping("BAIRRO", "BAIRRO"), New System.Data.Common.DataColumnMapping("UF", "UF"), New System.Data.Common.DataColumnMapping("CEP", "CEP"), New System.Data.Common.DataColumnMapping("TELEFONE1", "TELEFONE1"), New System.Data.Common.DataColumnMapping("TELEFONE2", "TELEFONE2"), New System.Data.Common.DataColumnMapping("TELEFONE3", "TELEFONE3"), New System.Data.Common.DataColumnMapping("TELEFONE4", "TELEFONE4"), New System.Data.Common.DataColumnMapping("TPTELEFONE1", "TPTELEFONE1"), New System.Data.Common.DataColumnMapping("TPTELEFONE2", "TPTELEFONE2"), New System.Data.Common.DataColumnMapping("TPTELEFONE3", "TPTELEFONE3"), New System.Data.Common.DataColumnMapping("TPTELEFONE4", "TPTELEFONE4"), New System.Data.Common.DataColumnMapping("SENHA", "SENHA"), New System.Data.Common.DataColumnMapping("NOMEUSUARIO", "NOMEUSUARIO"), New System.Data.Common.DataColumnMapping("DDDTEL1", "DDDTEL1"), New System.Data.Common.DataColumnMapping("DDDTEL2", "DDDTEL2"), New System.Data.Common.DataColumnMapping("DDDTEL3", "DDDTEL3"), New System.Data.Common.DataColumnMapping("DDDTEL4", "DDDTEL4"), New System.Data.Common.DataColumnMapping("CRM", "CRM"), New System.Data.Common.DataColumnMapping("NUMBANCO", "NUMBANCO"), New System.Data.Common.DataColumnMapping("AGENCIA", "AGENCIA"), New System.Data.Common.DataColumnMapping("CODNIVELACESSO", "CODNIVELACESSO"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO"), New System.Data.Common.DataColumnMapping("EXCLUIDO", "EXCLUIDO")})})
        Me.OleDaSocio.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDaDetFatView
        '
        Me.OleDaDetFatView.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDaDetFatView.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DETALHEFATURAMENTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODDETFATURAMENTO", "CODDETFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODFATURAMENTO", "CODFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO"), New System.Data.Common.DataColumnMapping("IRRF", "IRRF"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("VALORBRUTOSOCIO", "VALORBRUTOSOCIO"), New System.Data.Common.DataColumnMapping("VALORREC", "VALORREC"), New System.Data.Common.DataColumnMapping("AUDITADO", "AUDITADO"), New System.Data.Common.DataColumnMapping("CODCLIENTE", "CODCLIENTE"), New System.Data.Common.DataColumnMapping("DTALTERACAOFAT", "DTALTERACAOFAT"), New System.Data.Common.DataColumnMapping("DTFATURAMENTO", "DTFATURAMENTO"), New System.Data.Common.DataColumnMapping("NUMNF", "NUMNF"), New System.Data.Common.DataColumnMapping("USUARIOFAT", "USUARIOFAT"), New System.Data.Common.DataColumnMapping("VALORFATURAMENTOBRUTO", "VALORFATURAMENTOBRUTO"), New System.Data.Common.DataColumnMapping("CODFATURAMENTOFAT", "CODFATURAMENTOFAT")})})
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT DETALHEFATURAMENTO.CODDETFATURAMENTO, DETALHEFATURAMENTO.CODFATURAMENTO, D" & _
        "ETALHEFATURAMENTO.CODSOCIO, DETALHEFATURAMENTO.DTALTERACAO, DETALHEFATURAMENTO.I" & _
        "RRF, DETALHEFATURAMENTO.USUARIO, DETALHEFATURAMENTO.VALORBRUTOSOCIO, DETALHEFATU" & _
        "RAMENTO.VALORREC, FATURAMENTO.AUDITADO, FATURAMENTO.CODCLIENTE, FATURAMENTO.DTAL" & _
        "TERACAO AS DTALTERACAOFAT, FATURAMENTO.DTFATURAMENTO, FATURAMENTO.NUMNF, FATURAM" & _
        "ENTO.USUARIO AS USUARIOFAT, FATURAMENTO.VALORFATURAMENTOBRUTO, FATURAMENTO.CODFA" & _
        "TURAMENTO AS CODFATURAMENTOFAT FROM DETALHEFATURAMENTO INNER JOIN FATURAMENTO ON" & _
        " DETALHEFATURAMENTO.CODFATURAMENTO = FATURAMENTO.CODFATURAMENTO"
        Me.OleDbSelectCommand4.Connection = Me.OleCn
        '
        'OleDbSelectCommand5
        '
        Me.OleDbSelectCommand5.CommandText = "SELECT CODDETFATURAMENTO, CODFATURAMENTO, CODSOCIO, DTALTERACAO, IRRF, USUARIO, V" & _
        "ALORBRUTOSOCIO, VALORREC FROM DETALHEFATURAMENTO"
        Me.OleDbSelectCommand5.Connection = Me.OleCn
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO DETALHEFATURAMENTO(CODDETFATURAMENTO, CODFATURAMENTO, CODSOCIO, DTALT" & _
        "ERACAO, IRRF, USUARIO, VALORBRUTOSOCIO, VALORREC) VALUES (?, ?, ?, ?, ?, ?, ?, ?" & _
        ")"
        Me.OleDbInsertCommand4.Connection = Me.OleCn
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODDETFATURAMENTO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "CODFATURAMENTO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE DETALHEFATURAMENTO SET CODDETFATURAMENTO = ?, CODFATURAMENTO = ?, CODSOCIO" & _
        " = ?, DTALTERACAO = ?, IRRF = ?, USUARIO = ?, VALORBRUTOSOCIO = ?, VALORREC = ? " & _
        "WHERE (CODDETFATURAMENTO = ?) AND (CODFATURAMENTO = ? OR ? IS NULL AND CODFATURA" & _
        "MENTO IS NULL) AND (CODSOCIO = ? OR ? IS NULL AND CODSOCIO IS NULL) AND (DTALTER" & _
        "ACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (IRRF = ? OR ? IS NULL AND IR" & _
        "RF IS NULL) AND (USUARIO = ? OR ? IS NULL AND USUARIO IS NULL) AND (VALORBRUTOSO" & _
        "CIO = ? OR ? IS NULL AND VALORBRUTOSOCIO IS NULL) AND (VALORREC = ? OR ? IS NULL" & _
        " AND VALORREC IS NULL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleCn
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODDETFATURAMENTO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "CODFATURAMENTO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM DETALHEFATURAMENTO WHERE (CODDETFATURAMENTO = ?) AND (CODFATURAMENTO " & _
        "= ? OR ? IS NULL AND CODFATURAMENTO IS NULL) AND (CODSOCIO = ? OR ? IS NULL AND " & _
        "CODSOCIO IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND" & _
        " (IRRF = ? OR ? IS NULL AND IRRF IS NULL) AND (USUARIO = ? OR ? IS NULL AND USUA" & _
        "RIO IS NULL) AND (VALORBRUTOSOCIO = ? OR ? IS NULL AND VALORBRUTOSOCIO IS NULL) " & _
        "AND (VALORREC = ? OR ? IS NULL AND VALORREC IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleCn
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        '
        'OledaDetFat
        '
        Me.OledaDetFat.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OledaDetFat.InsertCommand = Me.OleDbInsertCommand4
        Me.OledaDetFat.SelectCommand = Me.OleDbSelectCommand5
        Me.OledaDetFat.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DETALHEFATURAMENTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODDETFATURAMENTO", "CODDETFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("VALORBRUTOSOCIO", "VALORBRUTOSOCIO"), New System.Data.Common.DataColumnMapping("CODFATURAMENTO", "CODFATURAMENTO"), New System.Data.Common.DataColumnMapping("IRRF", "IRRF"), New System.Data.Common.DataColumnMapping("VALORREC", "VALORREC"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO")})})
        Me.OledaDetFat.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'OleDaLancDescontos
        '
        Me.OleDaLancDescontos.SelectCommand = Me.OleDbSelectCommand6
        Me.OleDaLancDescontos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LANCAMENTO_DESCONTOS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Ano", "Ano"), New System.Data.Common.DataColumnMapping("CODDETFATURAMENTO", "CODDETFATURAMENTO"), New System.Data.Common.DataColumnMapping("NOMTPDESCONTO", "NOMTPDESCONTO"), New System.Data.Common.DataColumnMapping("CODLANCDESCONTO", "CODLANCDESCONTO"), New System.Data.Common.DataColumnMapping("CODLANCDESPESA", "CODLANCDESPESA"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("CODTPDESCONTO", "CODTPDESCONTO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO"), New System.Data.Common.DataColumnMapping("IncidenciaPercentual", "IncidenciaPercentual"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("Percentual", "Percentual"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("VALORDESCONTO", "VALORDESCONTO")})})
        '
        'OleDbSelectCommand6
        '
        Me.OleDbSelectCommand6.CommandText = "SELECT LANCAMENTO_DESCONTOS.Ano, LANCAMENTO_DESCONTOS.CODDETFATURAMENTO, TIPODESC" & _
        "ONTO.NOMTPDESCONTO, LANCAMENTO_DESCONTOS.CODLANCDESCONTO, LANCAMENTO_DESCONTOS.C" & _
        "ODLANCDESPESA, LANCAMENTO_DESCONTOS.CODSOCIO, LANCAMENTO_DESCONTOS.CODTPDESCONTO" & _
        ", LANCAMENTO_DESCONTOS.DTALTERACAO, LANCAMENTO_DESCONTOS.IncidenciaPercentual, L" & _
        "ANCAMENTO_DESCONTOS.Mes, LANCAMENTO_DESCONTOS.Percentual, LANCAMENTO_DESCONTOS.U" & _
        "SUARIO, LANCAMENTO_DESCONTOS.VALORDESCONTO, TIPODESCONTO.CODTPDESCONTO AS Expr1 " & _
        "FROM LANCAMENTO_DESCONTOS INNER JOIN TIPODESCONTO ON LANCAMENTO_DESCONTOS.CODTPD" & _
        "ESCONTO = TIPODESCONTO.CODTPDESCONTO"
        Me.OleDbSelectCommand6.Connection = Me.OleCn
        '
        'OleDaNatDesconto
        '
        Me.OleDaNatDesconto.DeleteCommand = Me.OleDbDeleteCommand5
        Me.OleDaNatDesconto.InsertCommand = Me.OleDbInsertCommand5
        Me.OleDaNatDesconto.SelectCommand = Me.OleDbSelectCommand7
        Me.OleDaNatDesconto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NATUREZADESCONTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODNATDESC", "CODNATDESC"), New System.Data.Common.DataColumnMapping("DSCNATDESC", "DSCNATDESC"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO")})})
        Me.OleDaNatDesconto.UpdateCommand = Me.OleDbUpdateCommand5
        '
        'OleDbDeleteCommand5
        '
        Me.OleDbDeleteCommand5.CommandText = "DELETE FROM NATUREZADESCONTO WHERE (CODNATDESC = ?) AND (DSCNATDESC = ? OR ? IS N" & _
        "ULL AND DSCNATDESC IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS" & _
        " NULL) AND (USUARIO = ? OR ? IS NULL AND USUARIO IS NULL)"
        Me.OleDbDeleteCommand5.Connection = Me.OleCn
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand5
        '
        Me.OleDbInsertCommand5.CommandText = "INSERT INTO NATUREZADESCONTO(CODNATDESC, DSCNATDESC, DTALTERACAO, USUARIO) VALUES" & _
        " (?, ?, ?, ?)"
        Me.OleDbInsertCommand5.Connection = Me.OleCn
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESC"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, "DSCNATDESC"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        '
        'OleDbSelectCommand7
        '
        Me.OleDbSelectCommand7.CommandText = "SELECT CODNATDESC, DSCNATDESC, DTALTERACAO, USUARIO FROM NATUREZADESCONTO"
        Me.OleDbSelectCommand7.Connection = Me.OleCn
        '
        'OleDbUpdateCommand5
        '
        Me.OleDbUpdateCommand5.CommandText = "UPDATE NATUREZADESCONTO SET CODNATDESC = ?, DSCNATDESC = ?, DTALTERACAO = ?, USUA" & _
        "RIO = ? WHERE (CODNATDESC = ?) AND (DSCNATDESC = ? OR ? IS NULL AND DSCNATDESC I" & _
        "S NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (USUARIO " & _
        "= ? OR ? IS NULL AND USUARIO IS NULL)"
        Me.OleDbUpdateCommand5.Connection = Me.OleCn
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESC"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, "DSCNATDESC"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaOutrosDescView
        '
        Me.OleDaOutrosDescView.SelectCommand = Me.OleDbSelectCommand8
        Me.OleDaOutrosDescView.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Descontos Nao Vinculados ao Faturamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Ano", "Ano"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("DSCNATDESC", "DSCNATDESC"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("NOMTPDESCONTO", "NOMTPDESCONTO"), New System.Data.Common.DataColumnMapping("SomaDeVALORDESCONTO", "SomaDeVALORDESCONTO"), New System.Data.Common.DataColumnMapping("CODNATDESC", "CODNATDESC")})})
        '
        'OleDbSelectCommand8
        '
        Me.OleDbSelectCommand8.CommandText = "SELECT Ano, CODSOCIO, DSCNATDESC, Mes, NOME, NOMTPDESCONTO, SomaDeVALORDESCONTO, " & _
        "CODNATDESC FROM [Descontos Nao Vinculados ao Faturamento]"
        Me.OleDbSelectCommand8.Connection = Me.OleCn
        '
        'OleDbSelectCommand9
        '
        Me.OleDbSelectCommand9.CommandText = "SELECT CODNATDESC, CODTPDESCONTO, DTALTERACAO, INCPERCENT, NOMTPDESCONTO, PERCENT" & _
        "UAL, PERCENTUALVALOR, USUARIO, VALOR FROM TIPODESCONTO"
        Me.OleDbSelectCommand9.Connection = Me.OleCn
        '
        'OleDbInsertCommand6
        '
        Me.OleDbInsertCommand6.CommandText = "INSERT INTO TIPODESCONTO(CODNATDESC, CODTPDESCONTO, DTALTERACAO, INCPERCENT, NOMT" & _
        "PDESCONTO, PERCENTUAL, PERCENTUALVALOR, USUARIO, VALOR) VALUES (?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?)"
        Me.OleDbInsertCommand6.Connection = Me.OleCn
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESC"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODTPDESCONTO"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("INCPERCENT", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "INCPERCENT", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOMTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 100, "NOMTPDESCONTO"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PERCENTUAL", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "PERCENTUAL", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PERCENTUALVALOR", System.Data.OleDb.OleDbType.Boolean, 2, "PERCENTUALVALOR"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALOR", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALOR", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand6
        '
        Me.OleDbUpdateCommand6.CommandText = "UPDATE TIPODESCONTO SET CODNATDESC = ?, CODTPDESCONTO = ?, DTALTERACAO = ?, INCPE" & _
        "RCENT = ?, NOMTPDESCONTO = ?, PERCENTUAL = ?, PERCENTUALVALOR = ?, USUARIO = ?, " & _
        "VALOR = ? WHERE (CODTPDESCONTO = ?) AND (CODNATDESC = ? OR ? IS NULL AND CODNATD" & _
        "ESC IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (NOM" & _
        "TPDESCONTO = ? OR ? IS NULL AND NOMTPDESCONTO IS NULL) AND (PERCENTUAL = ? OR ? " & _
        "IS NULL AND PERCENTUAL IS NULL) AND (PERCENTUALVALOR = ?) AND (USUARIO = ? OR ? " & _
        "IS NULL AND USUARIO IS NULL) AND (VALOR = ? OR ? IS NULL AND VALOR IS NULL)"
        Me.OleDbUpdateCommand6.Connection = Me.OleCn
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESC"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODTPDESCONTO"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("INCPERCENT", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "INCPERCENT", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOMTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 100, "NOMTPDESCONTO"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PERCENTUAL", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "PERCENTUAL", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("PERCENTUALVALOR", System.Data.OleDb.OleDbType.Boolean, 2, "PERCENTUALVALOR"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALOR", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALOR", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMTPDESCONTO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PERCENTUAL", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "PERCENTUAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PERCENTUAL1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "PERCENTUAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PERCENTUALVALOR", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PERCENTUALVALOR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALOR", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALOR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALOR1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALOR", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand6
        '
        Me.OleDbDeleteCommand6.CommandText = "DELETE FROM TIPODESCONTO WHERE (CODTPDESCONTO = ?) AND (CODNATDESC = ? OR ? IS NU" & _
        "LL AND CODNATDESC IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS " & _
        "NULL) AND (NOMTPDESCONTO = ? OR ? IS NULL AND NOMTPDESCONTO IS NULL) AND (PERCEN" & _
        "TUAL = ? OR ? IS NULL AND PERCENTUAL IS NULL) AND (PERCENTUALVALOR = ?) AND (USU" & _
        "ARIO = ? OR ? IS NULL AND USUARIO IS NULL) AND (VALOR = ? OR ? IS NULL AND VALOR" & _
        " IS NULL)"
        Me.OleDbDeleteCommand6.Connection = Me.OleCn
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMTPDESCONTO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PERCENTUAL", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "PERCENTUAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PERCENTUAL1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, False, CType(7, Byte), CType(0, Byte), "PERCENTUAL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_PERCENTUALVALOR", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PERCENTUALVALOR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALOR", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALOR", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALOR1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALOR", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaTpDesconto
        '
        Me.OleDaTpDesconto.DeleteCommand = Me.OleDbDeleteCommand6
        Me.OleDaTpDesconto.InsertCommand = Me.OleDbInsertCommand6
        Me.OleDaTpDesconto.SelectCommand = Me.OleDbSelectCommand9
        Me.OleDaTpDesconto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TIPODESCONTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODTPDESCONTO", "CODTPDESCONTO"), New System.Data.Common.DataColumnMapping("CODNATDESC", "CODNATDESC"), New System.Data.Common.DataColumnMapping("NOMTPDESCONTO", "NOMTPDESCONTO"), New System.Data.Common.DataColumnMapping("PERCENTUALVALOR", "PERCENTUALVALOR"), New System.Data.Common.DataColumnMapping("VALOR", "VALOR"), New System.Data.Common.DataColumnMapping("PERCENTUAL", "PERCENTUAL"), New System.Data.Common.DataColumnMapping("INCPERCENT", "INCPERCENT"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO")})})
        Me.OleDaTpDesconto.UpdateCommand = Me.OleDbUpdateCommand6
        '
        'DsExtratoMensal1
        '
        Me.DsExtratoMensal1.DataSetName = "DsExtratoMensal"
        Me.DsExtratoMensal1.Locale = New System.Globalization.CultureInfo("pt-BR")
        Me.DsExtratoMensal1.Namespace = "http://www.tempuri.org/DsExtratoMensal.xsd"
        CType(Me.DsExtratoMensal1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Dim sqlwhere As String
    Dim sqlorderby As String

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
        OleCn.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings("StringConexão").ToString & Server.MapPath("\dados\Imaging.mdb")
        Dim socio As New clsSocio()
        socio.oleConexão = OleCn
        If User.Identity.Name = "Contador" Then
            Response.Redirect("../Contador/default.aspx")
        Else
            If socio.NivelAcesso(User.Identity.Name) <> 1 Then
                Response.Redirect("../Socio/default.aspx")
            End If
        End If

        If Not Page.IsPostBack Then
            Dim sqlold As String
            sqlold = Me.OleDaSocio.SelectCommand.CommandText
            Me.OleDaSocio.SelectCommand.CommandText = Me.OleDaSocio.SelectCommand.CommandText & " ORDER BY NOME "

            Me.OleDaSocio.Fill(Me.DsExtratoMensal1, "SOCIO")
            Me.ddlSocio.DataBind()
            PreencherComboMes()
            Me.txtAno.Text = Year(Now())
            Me.OleDaSocio.SelectCommand.CommandText = sqlold
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        MontarTotais()
        CarregarFaturamento()
        CarregarDescontos()
    End Sub

    Sub MontarTotais()
        Dim vDescTot As New ArrayList()
        Dim Desc As New clsDescontos()
        Dim fat As New clsFaturamento()

        fat.oleConexão = Me.OleCn
        Desc.oleConexão = Me.OleCn
        Me.lblFatBruto.Text = FormatCurrency(fat.SomarFaturamentoBruto(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblIRRF.Text = FormatCurrency(fat.SomarIRRF(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblSubSaldoParcial.Text = FormatCurrency(fat.SomarValorRec(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblImpostos.Text = FormatCurrency(Desc.TotalizarValorNatDesconto("01", Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value))
        Me.lblTotMenosImpostos.Text = FormatCurrency(CDec(Me.lblSubSaldoParcial.Text) - CDec(Me.lblImpostos.Text))

        ' Preenchendo outros descontos
        Me.DsExtratoMensal1.NATUREZADESCONTO.Clear()
        Me.OleDaNatDesconto.Fill(Me.DsExtratoMensal1, "NaturezaDesconto")

        Dim dtrow As DataRow
        Dim Valor As Decimal
        Dim NatDesc As String
        Dim AcumalaOutrosDescontos As Decimal
        AcumalaOutrosDescontos = 0
        For Each dtrow In Me.DsExtratoMensal1.NATUREZADESCONTO.Rows
            If dtrow("CodNatDesc") <> "01" Then   '  diferente de imposto
                Valor = Desc.TotalizarNatDesconto(dtrow("CodNatDesc"), Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, CDec(Me.lblFatBruto.Text), CDec(Me.lblSubSaldoParcial.Text), CDec(Me.lblTotMenosImpostos.Text))
                NatDesc = dtrow("DscNatDesc")
                vDescTot.Add(New ValorNatDescontoSocio(NatDesc, Valor))
                AcumalaOutrosDescontos = AcumalaOutrosDescontos + Valor
            End If
        Next
        Me.lblTotOutrosDescontos.Text = FormatCurrency(AcumalaOutrosDescontos)
        Me.lblTotFinal.Text = FormatCurrency(CDec(Me.lblTotMenosImpostos.Text) - AcumalaOutrosDescontos)




        ' vDescTot.Add(new ValorNatDesconto(Impostos,Desc.
        '        vDescTot.Add(New ValorNatDesconto("Microsoft", 100))
        '       vDescTot.Add(New ValorNatDesconto("Intel", 200))
        '      vDescTot.Add(New ValorNatDesconto("Dell", 300))

        Repeater1.DataSource = vDescTot
        Repeater1.DataBind()


    End Sub

    Sub CarregarDescontos()
        Dim sql As String
        Dim sqlold As String
        sqlold = Me.OleDaNatDesconto.SelectCommand.CommandText
        sql = Me.OleDaNatDesconto.SelectCommand.CommandText
        sqlwhere = " where CODNATDESC <> '01' "
        sql = sql & sqlwhere
        Me.OleDaNatDesconto.SelectCommand.CommandText = sql
        Me.DsExtratoMensal1.NATUREZADESCONTO.Clear()
        Me.OleDaNatDesconto.Fill(Me.DsExtratoMensal1, "NATUREZADESCONTO")
        Me.grdOutrosDescontos.DataBind()
        Me.OleDaNatDesconto.SelectCommand.CommandText = sqlold
    End Sub

    Sub CarregarFaturamento()
        Dim sql As String
        sql = Me.OleDaDetFatView.SelectCommand.CommandText
        sqlwhere = " where DETALHEFATURAMENTO.CODSOCIO = '" & Me.ddlSocio.SelectedItem.Value & "'" & _
              " and  Month(FATURAMENTO.DTFATURAMENTO) = " & Me.ddlMes.SelectedItem.Value & " And Year(FATURAMENTO.DTFATURAMENTO) = '" & Me.txtAno.Text & "'" & _
              " and FATURAMENTO.AUDITADO = TRUE "

        sql = sql & sqlwhere & " order by FATURAMENTO.DTFATURAMENTO"

        'sql = "select Fat.*, Det.* from Faturamento Fat, DETALHEFATURAMENTO Det where  Fat.CodFaturamento = Det.CodFaturamento And Det.CodSocio = '" & Me.ddlSocio.SelectedItem.Value & "'" & _
        '      " and  Month(Fat.DTFATURAMENTO) = " & Me.ddlMes.SelectedItem.Value & " And Year(Fat.DTFATURAMENTO) = '" & Me.txtAno.Text & "'"
        'sql = sql & "order by DTFATURAMENTO"
        Me.OleDaDetFatView.SelectCommand.CommandText = sql
        Me.OleDaDetFatView.Fill(Me.DsExtratoMensal1, "DETALHEFATURAMENTO")
        grd.DataBind()
    End Sub

    Sub PreencherComboMes()
        'Dim lsMes As ListItemCollection
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

        Me.ddlMes.SelectedIndex = Month(Now()) - 1


    End Sub



    Function NomeCliente(ByVal CodCliente As String) As String

        Dim ret As String
        Me.OleDaCliente.Fill(Me.DsExtratoMensal1, "CLIENTE")
        ret = Me.DsExtratoMensal1.CLIENTE.FindByCODCLIENTE(CodCliente).NOME
        Return ret
    End Function

    Function FaturamentoBruto(ByVal CodDetFat As String) As Decimal
        Dim ret As Decimal

        Me.OleDaFaturamento.Fill(Me.DsExtratoMensal1, "FATURAMENTO")
        ret = Me.DsExtratoMensal1.DETALHEFATURAMENTO.FindByCODDETFATURAMENTO(CodDetFat).VALORBRUTOSOCIO
        Return ret
    End Function

    Function IRRF(ByVal CodDetFat As String) As Decimal
        Dim ret As Decimal
        Me.OleDaFaturamento.Fill(Me.DsExtratoMensal1, "FATURAMENTO")
        ret = Me.DsExtratoMensal1.DETALHEFATURAMENTO.FindByCODDETFATURAMENTO(CodDetFat).IRRF
        Return ret
    End Function

    Function FaturamentoLiquido(ByVal CodDetFat As String) As Decimal
        Dim ret As Decimal

        Me.OleDaFaturamento.Fill(Me.DsExtratoMensal1, "FATURAMENTO")
        ret = Me.DsExtratoMensal1.DETALHEFATURAMENTO.FindByCODDETFATURAMENTO(CodDetFat).VALORREC
        Return ret
    End Function

    Private Sub grdOutrosDescontos_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grdOutrosDescontos.ItemDataBound
        Dim vDescTot As ArrayList
        Dim r As Repeater
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            ' Informações de Faturamento
            CType(e.Item.Cells(2).Controls(1), Label).Text = e.Item.Cells(1).Text

            vDescTot = CarregarOutrosDescontosDTR(Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, e.Item.Cells(0).Text)

            CType(e.Item.Cells(2).FindControl("Repeater2"), Repeater).DataSource = vDescTot
            CType(e.Item.Cells(2).FindControl("Repeater2"), Repeater).DataBind()

        End If
    End Sub

    Function CarregarOutrosDescontosDTR(ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal CodNatDesc As String) As ArrayList
        Dim vDescTot As New ArrayList()
        Dim Desc As New clsDescontos()
        Dim fat As New clsFaturamento()
        Dim sqlold As String

        fat.oleConexão = Me.OleCn
        Desc.oleConexão = Me.OleCn

        ' Preenchendo outros descontos

        'Natureza de Desconto
        Me.DsExtratoMensal1.NATUREZADESCONTO.Clear()
        Me.OleDaNatDesconto.Fill(Me.DsExtratoMensal1, "NaturezaDesconto")
        Me.DsExtratoMensal1.TIPODESCONTO.Clear()
        sqlold = Me.OleDaTpDesconto.SelectCommand.CommandText

        'Pegando os Tipos de descontos na NatDesc Passada no Parametro
        Me.OleDaTpDesconto.SelectCommand.CommandText = Me.OleDaTpDesconto.SelectCommand.CommandText & " where codnatdesc = '" & CodNatDesc & "'"
        Me.OleDaTpDesconto.Fill(Me.DsExtratoMensal1, "TIPODESCONTO")
        Me.OleDaTpDesconto.SelectCommand.CommandText = sqlold

        Dim dtrow As DataRow
        Dim Valor As Decimal
        Dim TipoDesc As String
        Dim AcumalaOutrosDescontos As Decimal

        AcumalaOutrosDescontos = 0
        For Each dtrow In Me.DsExtratoMensal1.TIPODESCONTO.Rows
            Valor = Desc.TotalizarTipoDesconto(dtrow("CODTPDESCONTO"), Me.ddlMes.SelectedItem.Value, Me.txtAno.Text, Me.ddlSocio.SelectedItem.Value, CDec(Me.lblFatBruto.Text), CDec(Me.lblSubSaldoParcial.Text), CDec(Me.lblTotMenosImpostos.Text))
            TipoDesc = dtrow("NOMTPDESCONTO")
            vDescTot.Add(New ValorTipoDescontoSocio(TipoDesc, Valor))
            AcumalaOutrosDescontos = AcumalaOutrosDescontos + Valor
        Next

        Me.lblTotOutrosDescontos.Text = FormatCurrency(AcumalaOutrosDescontos)
        Me.lblTotFinal.Text = FormatCurrency(CDec(Me.lblTotMenosImpostos.Text) - AcumalaOutrosDescontos)

        Return vDescTot

    End Function


    Sub CarregarOutrosDescontos(ByVal Mes As String, ByVal Ano As String, ByVal CodSocio As String, ByVal CodNatDesc As String)
        Dim sql As String
        Dim sqlold As String
        Dim sqlwhere As String
        sqlold = Me.OleDaOutrosDescView.SelectCommand.CommandText
        sql = Me.OleDaOutrosDescView.SelectCommand.CommandText
        sqlwhere = " where Mes = '" & Mes & "' and Ano = '" & Ano & "' and CODSOCIO = '" & CodSocio & "' and CODNATDESC = '" & CodNatDesc & "'"
        sql = sql & sqlwhere
        Me.OleDaOutrosDescView.SelectCommand.CommandText = sql
        Me.DsExtratoMensal1.Descontos_Nao_Vinculados_ao_Faturamento.Clear()
        Me.DsExtratoMensal1.Descontos_Nao_Vinculados_ao_Faturamento.Clear()
        Me.OleDaOutrosDescView.Fill(Me.DsExtratoMensal1, "Descontos Nao Vinculados ao Faturamento")
        Me.OleDaOutrosDescView.SelectCommand.CommandText = sqlold
    End Sub

    Private Sub Repeater1_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.RepeaterCommandEventArgs) Handles Repeater1.ItemCommand

    End Sub

    Private Sub grd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub grd_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataGridItemEventArgs) Handles grd.ItemDataBound
        Dim Cliente As clsCliente
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            ' Informações de Faturamento
            CType(e.Item.Cells(3).Controls(1), Label).Text = NomeCliente(e.Item.Cells(2).Text)
            CType(e.Item.Cells(3).Controls(3), Label).Text = FormatCurrency(FaturamentoBruto(e.Item.Cells(0).Text))
            CType(e.Item.Cells(3).Controls(5), Label).Text = FormatCurrency(IRRF(e.Item.Cells(0).Text))
            CType(e.Item.Cells(3).Controls(7), Label).Text = FormatCurrency(FaturamentoLiquido(e.Item.Cells(0).Text))
            ' Informações dos Impostos
            Dim sqlwhere As String
            Dim sql As String
            Dim sqlold As String
            sqlwhere = " where CODDETFATURAMENTO = '" & e.Item.Cells(0).Text & "'"
            sql = Me.OleDaLancDescontos.SelectCommand.CommandText
            sqlold = sql
            sql = sql & sqlwhere
            Me.OleDaLancDescontos.SelectCommand.CommandText = sql
            Me.DsExtratoMensal1.LANCAMENTO_DESCONTOS.Clear()
            Me.OleDaLancDescontos.Fill(Me.DsExtratoMensal1, "LANCAMENTO_DESCONTOS")
            Me.OleDaLancDescontos.SelectCommand.CommandText = sqlold
            CType(e.Item.Cells(3).Controls(9), DataGrid).DataBind()

        End If
    End Sub
End Class
Public Class ValorTipoDescontoSocio

    Private TipoDesc As String
    Private vValor As Decimal

    Public Sub New(ByVal TipoDesc As String, ByVal Valor As Decimal)
        Me.TipoDesc = TipoDesc
        Me.vValor = Valor
    End Sub

    Public ReadOnly Property TipoDesconto() As String
        Get
            Return TipoDesc
        End Get
    End Property

    Public ReadOnly Property Valor() As String
        Get
            Return FormatCurrency(vValor)
        End Get
    End Property
End Class
Public Class ValorNatDescontoSocio

    Private NatDesc As String
    Private vValor As Decimal

    Public Sub New(ByVal NatDesc As String, ByVal Valor As Decimal)
        Me.NatDesc = NatDesc
        Me.vValor = Valor
    End Sub

    Public ReadOnly Property NaturezaDesconto() As String
        Get
            Return NatDesc
        End Get
    End Property

    Public ReadOnly Property Valor() As String
        Get
            Return FormatCurrency(vValor)
        End Get
    End Property
End Class
