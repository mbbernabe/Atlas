Partial Class detfatsocio
    Inherits System.Web.UI.Page
    Protected WithEvents OleCn As System.Data.OleDb.OleDbConnection
    Protected WithEvents OleDaLancDescontos As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDaLancDescView As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaDetFat As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand3 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaFaturamento As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand4 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaSocio As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand5 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaCliente As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand7 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand6 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDaNatDesc As System.Data.OleDb.OleDbDataAdapter
    Protected WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Protected WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Protected WithEvents DsDetSocio1 As dsDetFat







#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OleCn = New System.Data.OleDb.OleDbConnection()
        Me.OleDaLancDescontos = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.DsDetSocio1 = New dsDetFat()
        Me.OleDaLancDescView = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaDetFat = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaFaturamento = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaSocio = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaCliente = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand7 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand6 = New System.Data.OleDb.OleDbCommand()
        Me.OleDaNatDesc = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.DsDetSocio1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'OleCn
        '
        Me.OleCn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\Inetpub" & _
        "\wwwroot\Dados\ImagingNet.mdb;Mode=ReadWrite|Share Deny None;Extended Properties" & _
        "="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database P" & _
        "assword="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:G" & _
        "lobal Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Data" & _
        "base Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Databa" & _
        "se=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without " & _
        "Replica Repair=False;Jet OLEDB:SFP=False"
        '
        'OleDaLancDescontos
        '
        Me.OleDaLancDescontos.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDaLancDescontos.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDaLancDescontos.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDaLancDescontos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LANCAMENTO_DESCONTOS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODDETFATURAMENTO", "CODDETFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODLANCDESCONTO", "CODLANCDESCONTO"), New System.Data.Common.DataColumnMapping("CODLANCDESPESA", "CODLANCDESPESA"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("CODTPDESCONTO", "CODTPDESCONTO"), New System.Data.Common.DataColumnMapping("VALORDESCONTO", "VALORDESCONTO"), New System.Data.Common.DataColumnMapping("Ano", "Ano"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO"), New System.Data.Common.DataColumnMapping("IncidenciaPercentual", "IncidenciaPercentual"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("Percentual", "Percentual"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO")})})
        Me.OleDaLancDescontos.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM LANCAMENTO_DESCONTOS WHERE (CODLANCDESCONTO = ?) AND (Ano = ? OR ? IS" & _
        " NULL AND Ano IS NULL) AND (CODDETFATURAMENTO = ? OR ? IS NULL AND CODDETFATURAM" & _
        "ENTO IS NULL) AND (CODLANCDESPESA = ? OR ? IS NULL AND CODLANCDESPESA IS NULL) A" & _
        "ND (CODSOCIO = ? OR ? IS NULL AND CODSOCIO IS NULL) AND (CODTPDESCONTO = ? OR ? " & _
        "IS NULL AND CODTPDESCONTO IS NULL) AND (DTALTERACAO = ? OR ? IS NULL AND DTALTER" & _
        "ACAO IS NULL) AND (IncidenciaPercentual = ? OR ? IS NULL AND IncidenciaPercentua" & _
        "l IS NULL) AND (Mes = ? OR ? IS NULL AND Mes IS NULL) AND (Percentual = ? OR ? I" & _
        "S NULL AND Percentual IS NULL) AND (USUARIO = ? OR ? IS NULL AND USUARIO IS NULL" & _
        ") AND (VALORDESCONTO = ? OR ? IS NULL AND VALORDESCONTO IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleCn
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODLANCDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODLANCDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ano", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ano", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ano1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ano", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODLANCDESPESA", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODLANCDESPESA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODLANCDESPESA1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODLANCDESPESA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODTPDESCONTO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncidenciaPercentual", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncidenciaPercentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncidenciaPercentual1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncidenciaPercentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mes", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mes1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Percentual", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Percentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Percentual1", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Percentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORDESCONTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORDESCONTO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO LANCAMENTO_DESCONTOS(CODDETFATURAMENTO, CODLANCDESCONTO, CODLANCDESPE" & _
        "SA, CODSOCIO, CODTPDESCONTO, VALORDESCONTO, Ano, DTALTERACAO, IncidenciaPercentu" & _
        "al, Mes, Percentual, USUARIO) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleCn
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODDETFATURAMENTO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODLANCDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODLANCDESCONTO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODLANCDESPESA", System.Data.OleDb.OleDbType.VarWChar, 20, "CODLANCDESPESA"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODTPDESCONTO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORDESCONTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORDESCONTO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ano", System.Data.OleDb.OleDbType.VarWChar, 4, "Ano"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IncidenciaPercentual", System.Data.OleDb.OleDbType.VarWChar, 1, "IncidenciaPercentual"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Mes", System.Data.OleDb.OleDbType.VarWChar, 2, "Mes"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Percentual", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Percentual", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CODDETFATURAMENTO, CODLANCDESCONTO, CODLANCDESPESA, CODSOCIO, CODTPDESCONT" & _
        "O, VALORDESCONTO, Ano, DTALTERACAO, IncidenciaPercentual, Mes, Percentual, USUAR" & _
        "IO FROM LANCAMENTO_DESCONTOS"
        Me.OleDbSelectCommand1.Connection = Me.OleCn
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE LANCAMENTO_DESCONTOS SET CODDETFATURAMENTO = ?, CODLANCDESCONTO = ?, CODLA" & _
        "NCDESPESA = ?, CODSOCIO = ?, CODTPDESCONTO = ?, VALORDESCONTO = ?, Ano = ?, DTAL" & _
        "TERACAO = ?, IncidenciaPercentual = ?, Mes = ?, Percentual = ?, USUARIO = ? WHER" & _
        "E (CODLANCDESCONTO = ?) AND (Ano = ? OR ? IS NULL AND Ano IS NULL) AND (CODDETFA" & _
        "TURAMENTO = ? OR ? IS NULL AND CODDETFATURAMENTO IS NULL) AND (CODLANCDESPESA = " & _
        "? OR ? IS NULL AND CODLANCDESPESA IS NULL) AND (CODSOCIO = ? OR ? IS NULL AND CO" & _
        "DSOCIO IS NULL) AND (CODTPDESCONTO = ? OR ? IS NULL AND CODTPDESCONTO IS NULL) A" & _
        "ND (DTALTERACAO = ? OR ? IS NULL AND DTALTERACAO IS NULL) AND (IncidenciaPercent" & _
        "ual = ? OR ? IS NULL AND IncidenciaPercentual IS NULL) AND (Mes = ? OR ? IS NULL" & _
        " AND Mes IS NULL) AND (Percentual = ? OR ? IS NULL AND Percentual IS NULL) AND (" & _
        "USUARIO = ? OR ? IS NULL AND USUARIO IS NULL) AND (VALORDESCONTO = ? OR ? IS NUL" & _
        "L AND VALORDESCONTO IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleCn
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODDETFATURAMENTO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODLANCDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODLANCDESCONTO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODLANCDESPESA", System.Data.OleDb.OleDbType.VarWChar, 20, "CODLANCDESPESA"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODTPDESCONTO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORDESCONTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORDESCONTO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Ano", System.Data.OleDb.OleDbType.VarWChar, 4, "Ano"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, "DTALTERACAO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("IncidenciaPercentual", System.Data.OleDb.OleDbType.VarWChar, 1, "IncidenciaPercentual"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Mes", System.Data.OleDb.OleDbType.VarWChar, 2, "Mes"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Percentual", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Percentual", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, "USUARIO"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODLANCDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODLANCDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ano", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ano", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Ano1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ano", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODLANCDESPESA", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODLANCDESPESA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODLANCDESPESA1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODLANCDESPESA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODTPDESCONTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODTPDESCONTO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODTPDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTALTERACAO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTALTERACAO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncidenciaPercentual", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncidenciaPercentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IncidenciaPercentual1", System.Data.OleDb.OleDbType.VarWChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IncidenciaPercentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mes", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Mes1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Percentual", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Percentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Percentual1", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Percentual", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_USUARIO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "USUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORDESCONTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORDESCONTO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORDESCONTO", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsDetSocio1
        '
        Me.DsDetSocio1.DataSetName = "dsDetSocio"
        Me.DsDetSocio1.Locale = New System.Globalization.CultureInfo("pt-BR")
        Me.DsDetSocio1.Namespace = "http://www.tempuri.org/dsDetSocio.xsd"
        '
        'OleDaLancDescView
        '
        Me.OleDaLancDescView.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDaLancDescView.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "LANCAMENTO_DESCONTOS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODDETFATURAMENTO", "CODDETFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODLANCDESCONTO", "CODLANCDESCONTO"), New System.Data.Common.DataColumnMapping("CODLANCDESPESA", "CODLANCDESPESA"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("CODTPDESCONTO", "CODTPDESCONTO"), New System.Data.Common.DataColumnMapping("VALORDESCONTO", "VALORDESCONTO"), New System.Data.Common.DataColumnMapping("NOMTPDESCONTO", "NOMTPDESCONTO"), New System.Data.Common.DataColumnMapping("CODNATDESC", "CODNATDESC"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Ano", "Ano"), New System.Data.Common.DataColumnMapping("USUARIO", "USUARIO"), New System.Data.Common.DataColumnMapping("Percentual", "Percentual"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("IncidenciaPercentual", "IncidenciaPercentual"), New System.Data.Common.DataColumnMapping("DTALTERACAO", "DTALTERACAO")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT LANCAMENTO_DESCONTOS.CODDETFATURAMENTO, LANCAMENTO_DESCONTOS.CODLANCDESCON" & _
        "TO, LANCAMENTO_DESCONTOS.CODLANCDESPESA, LANCAMENTO_DESCONTOS.CODSOCIO, LANCAMEN" & _
        "TO_DESCONTOS.CODTPDESCONTO, LANCAMENTO_DESCONTOS.VALORDESCONTO, TIPODESCONTO.NOM" & _
        "TPDESCONTO, TIPODESCONTO.CODNATDESC, TIPODESCONTO.CODTPDESCONTO AS Expr1, LANCAM" & _
        "ENTO_DESCONTOS.Ano, LANCAMENTO_DESCONTOS.USUARIO, LANCAMENTO_DESCONTOS.Percentua" & _
        "l, LANCAMENTO_DESCONTOS.Mes, LANCAMENTO_DESCONTOS.IncidenciaPercentual, LANCAMEN" & _
        "TO_DESCONTOS.DTALTERACAO FROM LANCAMENTO_DESCONTOS INNER JOIN TIPODESCONTO ON LA" & _
        "NCAMENTO_DESCONTOS.CODTPDESCONTO = TIPODESCONTO.CODTPDESCONTO"
        Me.OleDbSelectCommand2.Connection = Me.OleCn
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT CODDETFATURAMENTO, CODFATURAMENTO, CODSOCIO, IRRF, VALORBRUTOSOCIO, VALORR" & _
        "EC FROM DETALHEFATURAMENTO"
        Me.OleDbSelectCommand3.Connection = Me.OleCn
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO DETALHEFATURAMENTO(CODDETFATURAMENTO, CODFATURAMENTO, CODSOCIO, IRRF," & _
        " VALORBRUTOSOCIO, VALORREC) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleCn
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODDETFATURAMENTO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "CODFATURAMENTO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE DETALHEFATURAMENTO SET CODDETFATURAMENTO = ?, CODFATURAMENTO = ?, CODSOCIO" & _
        " = ?, IRRF = ?, VALORBRUTOSOCIO = ?, VALORREC = ? WHERE (CODDETFATURAMENTO = ?) " & _
        "AND (CODFATURAMENTO = ? OR ? IS NULL AND CODFATURAMENTO IS NULL) AND (CODSOCIO =" & _
        " ? OR ? IS NULL AND CODSOCIO IS NULL) AND (IRRF = ? OR ? IS NULL AND IRRF IS NUL" & _
        "L) AND (VALORBRUTOSOCIO = ? OR ? IS NULL AND VALORBRUTOSOCIO IS NULL) AND (VALOR" & _
        "REC = ? OR ? IS NULL AND VALORREC IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleCn
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODDETFATURAMENTO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "CODFATURAMENTO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM DETALHEFATURAMENTO WHERE (CODDETFATURAMENTO = ?) AND (CODFATURAMENTO " & _
        "= ? OR ? IS NULL AND CODFATURAMENTO IS NULL) AND (CODSOCIO = ? OR ? IS NULL AND " & _
        "CODSOCIO IS NULL) AND (IRRF = ? OR ? IS NULL AND IRRF IS NULL) AND (VALORBRUTOSO" & _
        "CIO = ? OR ? IS NULL AND VALORBRUTOSOCIO IS NULL) AND (VALORREC = ? OR ? IS NULL" & _
        " AND VALORREC IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleCn
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODDETFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODDETFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IRRF1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "IRRF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORBRUTOSOCIO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORBRUTOSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORREC1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORREC", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaDetFat
        '
        Me.OleDaDetFat.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDaDetFat.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDaDetFat.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDaDetFat.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DETALHEFATURAMENTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODDETFATURAMENTO", "CODDETFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("VALORBRUTOSOCIO", "VALORBRUTOSOCIO"), New System.Data.Common.DataColumnMapping("CODFATURAMENTO", "CODFATURAMENTO"), New System.Data.Common.DataColumnMapping("IRRF", "IRRF"), New System.Data.Common.DataColumnMapping("VALORREC", "VALORREC")})})
        Me.OleDaDetFat.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT AUDITADO, CODCLIENTE, CODFATURAMENTO, DTFATURAMENTO, NUMNF, VALORFATURAMEN" & _
        "TOBRUTO FROM FATURAMENTO"
        Me.OleDbSelectCommand4.Connection = Me.OleCn
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO FATURAMENTO(AUDITADO, CODCLIENTE, CODFATURAMENTO, DTFATURAMENTO, NUMN" & _
        "F, VALORFATURAMENTOBRUTO) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleCn
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, "AUDITADO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODFATURAMENTO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, "DTFATURAMENTO"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, "NUMNF"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE FATURAMENTO SET AUDITADO = ?, CODCLIENTE = ?, CODFATURAMENTO = ?, DTFATURA" & _
        "MENTO = ?, NUMNF = ?, VALORFATURAMENTOBRUTO = ? WHERE (CODFATURAMENTO = ?) AND (" & _
        "AUDITADO = ?) AND (CODCLIENTE = ? OR ? IS NULL AND CODCLIENTE IS NULL) AND (DTFA" & _
        "TURAMENTO = ? OR ? IS NULL AND DTFATURAMENTO IS NULL) AND (NUMNF = ? OR ? IS NUL" & _
        "L AND NUMNF IS NULL) AND (VALORFATURAMENTOBRUTO = ? OR ? IS NULL AND VALORFATURA" & _
        "MENTOBRUTO IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.OleCn
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, "AUDITADO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODFATURAMENTO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, "DTFATURAMENTO"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, "NUMNF"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AUDITADO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM FATURAMENTO WHERE (CODFATURAMENTO = ?) AND (AUDITADO = ?) AND (CODCLI" & _
        "ENTE = ? OR ? IS NULL AND CODCLIENTE IS NULL) AND (DTFATURAMENTO = ? OR ? IS NUL" & _
        "L AND DTFATURAMENTO IS NULL) AND (NUMNF = ? OR ? IS NULL AND NUMNF IS NULL) AND " & _
        "(VALORFATURAMENTOBRUTO = ? OR ? IS NULL AND VALORFATURAMENTOBRUTO IS NULL)"
        Me.OleDbDeleteCommand3.Connection = Me.OleCn
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODFATURAMENTO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AUDITADO", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AUDITADO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DTFATURAMENTO1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DTFATURAMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMNF1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMNF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VALORFATURAMENTOBRUTO1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "VALORFATURAMENTOBRUTO", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaFaturamento
        '
        Me.OleDaFaturamento.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDaFaturamento.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDaFaturamento.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDaFaturamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FATURAMENTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODFATURAMENTO", "CODFATURAMENTO"), New System.Data.Common.DataColumnMapping("CODCLIENTE", "CODCLIENTE"), New System.Data.Common.DataColumnMapping("DTFATURAMENTO", "DTFATURAMENTO"), New System.Data.Common.DataColumnMapping("VALORFATURAMENTOBRUTO", "VALORFATURAMENTOBRUTO"), New System.Data.Common.DataColumnMapping("NUMNF", "NUMNF"), New System.Data.Common.DataColumnMapping("AUDITADO", "AUDITADO")})})
        Me.OleDaFaturamento.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbSelectCommand5
        '
        Me.OleDbSelectCommand5.CommandText = "SELECT AGENCIA, BAIRRO, CEP, CIDADE, CODNIVELACESSO, CODSOCIO, COMPLEMENTO, CPF, " & _
        "CRM, DATAENTRADA, DDDTEL1, DDDTEL2, DDDTEL3, DDDTEL4, EMAIL, IDENTIDADE, LOGRADO" & _
        "URO, NOME, NOMEUSUARIO, NUMBANCO, NUMERO, SENHA, TELEFONE1, TELEFONE2, TELEFONE3" & _
        ", TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELEFONE2, TPTELEFONE3, TPTELEFONE4, U" & _
        "F FROM SOCIO"
        Me.OleDbSelectCommand5.Connection = Me.OleCn
        '
        'OleDbInsertCommand4
        '
        Me.OleDbInsertCommand4.CommandText = "INSERT INTO SOCIO(AGENCIA, BAIRRO, CEP, CIDADE, CODNIVELACESSO, CODSOCIO, COMPLEM" & _
        "ENTO, CPF, CRM, DATAENTRADA, DDDTEL1, DDDTEL2, DDDTEL3, DDDTEL4, EMAIL, IDENTIDA" & _
        "DE, LOGRADOURO, NOME, NOMEUSUARIO, NUMBANCO, NUMERO, SENHA, TELEFONE1, TELEFONE2" & _
        ", TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELEFONE2, TPTELEFONE3, TPT" & _
        "ELEFONE4, UF) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand4.Connection = Me.OleCn
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, "AGENCIA"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNIVELACESSO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CPF", System.Data.OleDb.OleDbType.VarWChar, 30, "CPF"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CRM", System.Data.OleDb.OleDbType.VarWChar, 50, "CRM"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, "DATAENTRADA"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, "IDENTIDADE"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 100, "NOMEUSUARIO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, "NUMBANCO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, "SENHA"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbInsertCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("UF", System.Data.OleDb.OleDbType.VarWChar, 2, "UF"))
        '
        'OleDbUpdateCommand4
        '
        Me.OleDbUpdateCommand4.CommandText = "UPDATE SOCIO SET AGENCIA = ?, BAIRRO = ?, CEP = ?, CIDADE = ?, CODNIVELACESSO = ?" & _
        ", CODSOCIO = ?, COMPLEMENTO = ?, CPF = ?, CRM = ?, DATAENTRADA = ?, DDDTEL1 = ?," & _
        " DDDTEL2 = ?, DDDTEL3 = ?, DDDTEL4 = ?, EMAIL = ?, IDENTIDADE = ?, LOGRADOURO = " & _
        "?, NOME = ?, NOMEUSUARIO = ?, NUMBANCO = ?, NUMERO = ?, SENHA = ?, TELEFONE1 = ?" & _
        ", TELEFONE2 = ?, TELEFONE3 = ?, TELEFONE4 = ?, TPLOGRADOURO = ?, TPTELEFONE1 = ?" & _
        ", TPTELEFONE2 = ?, TPTELEFONE3 = ?, TPTELEFONE4 = ?, UF = ? WHERE (CODSOCIO = ?)" & _
        " AND (AGENCIA = ? OR ? IS NULL AND AGENCIA IS NULL) AND (BAIRRO = ? OR ? IS NULL" & _
        " AND BAIRRO IS NULL) AND (CEP = ? OR ? IS NULL AND CEP IS NULL) AND (CIDADE = ? " & _
        "OR ? IS NULL AND CIDADE IS NULL) AND (CODNIVELACESSO = ? OR ? IS NULL AND CODNIV" & _
        "ELACESSO IS NULL) AND (COMPLEMENTO = ? OR ? IS NULL AND COMPLEMENTO IS NULL) AND" & _
        " (CPF = ? OR ? IS NULL AND CPF IS NULL) AND (CRM = ? OR ? IS NULL AND CRM IS NUL" & _
        "L) AND (DATAENTRADA = ? OR ? IS NULL AND DATAENTRADA IS NULL) AND (DDDTEL1 = ? O" & _
        "R ? IS NULL AND DDDTEL1 IS NULL) AND (DDDTEL2 = ? OR ? IS NULL AND DDDTEL2 IS NU" & _
        "LL) AND (DDDTEL3 = ? OR ? IS NULL AND DDDTEL3 IS NULL) AND (DDDTEL4 = ? OR ? IS " & _
        "NULL AND DDDTEL4 IS NULL) AND (EMAIL = ? OR ? IS NULL AND EMAIL IS NULL) AND (ID" & _
        "ENTIDADE = ? OR ? IS NULL AND IDENTIDADE IS NULL) AND (LOGRADOURO = ? OR ? IS NU" & _
        "LL AND LOGRADOURO IS NULL) AND (NOME = ? OR ? IS NULL AND NOME IS NULL) AND (NOM" & _
        "EUSUARIO = ? OR ? IS NULL AND NOMEUSUARIO IS NULL) AND (NUMBANCO = ? OR ? IS NUL" & _
        "L AND NUMBANCO IS NULL) AND (NUMERO = ? OR ? IS NULL AND NUMERO IS NULL) AND (SE" & _
        "NHA = ? OR ? IS NULL AND SENHA IS NULL) AND (TELEFONE1 = ? OR ? IS NULL AND TELE" & _
        "FONE1 IS NULL) AND (TELEFONE2 = ? OR ? IS NULL AND TELEFONE2 IS NULL) AND (TELEF" & _
        "ONE3 = ? OR ? IS NULL AND TELEFONE3 IS NULL) AND (TELEFONE4 = ? OR ? IS NULL AND" & _
        " TELEFONE4 IS NULL) AND (TPLOGRADOURO = ? OR ? IS NULL AND TPLOGRADOURO IS NULL)" & _
        " AND (TPTELEFONE1 = ? OR ? IS NULL AND TPTELEFONE1 IS NULL) AND (TPTELEFONE2 = ?" & _
        " OR ? IS NULL AND TPTELEFONE2 IS NULL) AND (TPTELEFONE3 = ? OR ? IS NULL AND TPT" & _
        "ELEFONE3 IS NULL) AND (TPTELEFONE4 = ? OR ? IS NULL AND TPTELEFONE4 IS NULL) AND" & _
        " (UF = ? OR ? IS NULL AND UF IS NULL)"
        Me.OleDbUpdateCommand4.Connection = Me.OleCn
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, "AGENCIA"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNIVELACESSO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, "CODSOCIO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CPF", System.Data.OleDb.OleDbType.VarWChar, 30, "CPF"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("CRM", System.Data.OleDb.OleDbType.VarWChar, 50, "CRM"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, "DATAENTRADA"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, "IDENTIDADE"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 100, "NOMEUSUARIO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, "NUMBANCO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, "SENHA"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("UF", System.Data.OleDb.OleDbType.VarWChar, 2, "UF"))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand4
        '
        Me.OleDbDeleteCommand4.CommandText = "DELETE FROM SOCIO WHERE (CODSOCIO = ?) AND (AGENCIA = ? OR ? IS NULL AND AGENCIA " & _
        "IS NULL) AND (BAIRRO = ? OR ? IS NULL AND BAIRRO IS NULL) AND (CEP = ? OR ? IS N" & _
        "ULL AND CEP IS NULL) AND (CIDADE = ? OR ? IS NULL AND CIDADE IS NULL) AND (CODNI" & _
        "VELACESSO = ? OR ? IS NULL AND CODNIVELACESSO IS NULL) AND (COMPLEMENTO = ? OR ?" & _
        " IS NULL AND COMPLEMENTO IS NULL) AND (CPF = ? OR ? IS NULL AND CPF IS NULL) AND" & _
        " (CRM = ? OR ? IS NULL AND CRM IS NULL) AND (DATAENTRADA = ? OR ? IS NULL AND DA" & _
        "TAENTRADA IS NULL) AND (DDDTEL1 = ? OR ? IS NULL AND DDDTEL1 IS NULL) AND (DDDTE" & _
        "L2 = ? OR ? IS NULL AND DDDTEL2 IS NULL) AND (DDDTEL3 = ? OR ? IS NULL AND DDDTE" & _
        "L3 IS NULL) AND (DDDTEL4 = ? OR ? IS NULL AND DDDTEL4 IS NULL) AND (EMAIL = ? OR" & _
        " ? IS NULL AND EMAIL IS NULL) AND (IDENTIDADE = ? OR ? IS NULL AND IDENTIDADE IS" & _
        " NULL) AND (LOGRADOURO = ? OR ? IS NULL AND LOGRADOURO IS NULL) AND (NOME = ? OR" & _
        " ? IS NULL AND NOME IS NULL) AND (NOMEUSUARIO = ? OR ? IS NULL AND NOMEUSUARIO I" & _
        "S NULL) AND (NUMBANCO = ? OR ? IS NULL AND NUMBANCO IS NULL) AND (NUMERO = ? OR " & _
        "? IS NULL AND NUMERO IS NULL) AND (SENHA = ? OR ? IS NULL AND SENHA IS NULL) AND" & _
        " (TELEFONE1 = ? OR ? IS NULL AND TELEFONE1 IS NULL) AND (TELEFONE2 = ? OR ? IS N" & _
        "ULL AND TELEFONE2 IS NULL) AND (TELEFONE3 = ? OR ? IS NULL AND TELEFONE3 IS NULL" & _
        ") AND (TELEFONE4 = ? OR ? IS NULL AND TELEFONE4 IS NULL) AND (TPLOGRADOURO = ? O" & _
        "R ? IS NULL AND TPLOGRADOURO IS NULL) AND (TPTELEFONE1 = ? OR ? IS NULL AND TPTE" & _
        "LEFONE1 IS NULL) AND (TPTELEFONE2 = ? OR ? IS NULL AND TPTELEFONE2 IS NULL) AND " & _
        "(TPTELEFONE3 = ? OR ? IS NULL AND TPTELEFONE3 IS NULL) AND (TPTELEFONE4 = ? OR ?" & _
        " IS NULL AND TPTELEFONE4 IS NULL) AND (UF = ? OR ? IS NULL AND UF IS NULL)"
        Me.OleDbDeleteCommand4.Connection = Me.OleCn
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODSOCIO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODSOCIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_AGENCIA1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AGENCIA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNIVELACESSO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNIVELACESSO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CPF1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CPF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CRM1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CRM", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DATAENTRADA1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DATAENTRADA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IDENTIDADE1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IDENTIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOMEUSUARIO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOMEUSUARIO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMBANCO1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMBANCO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SENHA1", System.Data.OleDb.OleDbType.VarWChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SENHA", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand4.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UF", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaSocio
        '
        Me.OleDaSocio.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDaSocio.InsertCommand = Me.OleDbInsertCommand4
        Me.OleDaSocio.SelectCommand = Me.OleDbSelectCommand5
        Me.OleDaSocio.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SOCIO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODSOCIO", "CODSOCIO"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("EMAIL", "EMAIL"), New System.Data.Common.DataColumnMapping("IDENTIDADE", "IDENTIDADE"), New System.Data.Common.DataColumnMapping("CPF", "CPF"), New System.Data.Common.DataColumnMapping("DATAENTRADA", "DATAENTRADA"), New System.Data.Common.DataColumnMapping("TPLOGRADOURO", "TPLOGRADOURO"), New System.Data.Common.DataColumnMapping("LOGRADOURO", "LOGRADOURO"), New System.Data.Common.DataColumnMapping("NUMERO", "NUMERO"), New System.Data.Common.DataColumnMapping("COMPLEMENTO", "COMPLEMENTO"), New System.Data.Common.DataColumnMapping("CIDADE", "CIDADE"), New System.Data.Common.DataColumnMapping("BAIRRO", "BAIRRO"), New System.Data.Common.DataColumnMapping("UF", "UF"), New System.Data.Common.DataColumnMapping("CEP", "CEP"), New System.Data.Common.DataColumnMapping("TELEFONE1", "TELEFONE1"), New System.Data.Common.DataColumnMapping("TELEFONE2", "TELEFONE2"), New System.Data.Common.DataColumnMapping("TELEFONE3", "TELEFONE3"), New System.Data.Common.DataColumnMapping("TELEFONE4", "TELEFONE4"), New System.Data.Common.DataColumnMapping("TPTELEFONE1", "TPTELEFONE1"), New System.Data.Common.DataColumnMapping("TPTELEFONE2", "TPTELEFONE2"), New System.Data.Common.DataColumnMapping("TPTELEFONE3", "TPTELEFONE3"), New System.Data.Common.DataColumnMapping("TPTELEFONE4", "TPTELEFONE4"), New System.Data.Common.DataColumnMapping("SENHA", "SENHA"), New System.Data.Common.DataColumnMapping("NOMEUSUARIO", "NOMEUSUARIO"), New System.Data.Common.DataColumnMapping("DDDTEL1", "DDDTEL1"), New System.Data.Common.DataColumnMapping("DDDTEL2", "DDDTEL2"), New System.Data.Common.DataColumnMapping("DDDTEL3", "DDDTEL3"), New System.Data.Common.DataColumnMapping("DDDTEL4", "DDDTEL4"), New System.Data.Common.DataColumnMapping("CRM", "CRM"), New System.Data.Common.DataColumnMapping("NUMBANCO", "NUMBANCO"), New System.Data.Common.DataColumnMapping("AGENCIA", "AGENCIA"), New System.Data.Common.DataColumnMapping("CODNIVELACESSO", "CODNIVELACESSO")})})
        Me.OleDaSocio.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'OleDbSelectCommand6
        '
        Me.OleDbSelectCommand6.CommandText = "SELECT BAIRRO, CEP, CIDADE, CNPJ, CODCLIENTE, COMPLEMENTO, DDDTEL1, DDDTEL2, DDDT" & _
        "EL3, DDDTEL4, EMAIL, IE, LOGRADOURO, NOME, NUMERO, SIGLAUF, TELEFONE1, TELEFONE2" & _
        ", TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELEFONE2, TPTELEFONE3, TPT" & _
        "ELEFONE4 FROM CLIENTE"
        Me.OleDbSelectCommand6.Connection = Me.OleCn
        '
        'OleDbInsertCommand5
        '
        Me.OleDbInsertCommand5.CommandText = "INSERT INTO CLIENTE(BAIRRO, CEP, CIDADE, CNPJ, CODCLIENTE, COMPLEMENTO, DDDTEL1, " & _
        "DDDTEL2, DDDTEL3, DDDTEL4, EMAIL, IE, LOGRADOURO, NOME, NUMERO, SIGLAUF, TELEFON" & _
        "E1, TELEFONE2, TELEFONE3, TELEFONE4, TPLOGRADOURO, TPTELEFONE1, TPTELEFONE2, TPT" & _
        "ELEFONE3, TPTELEFONE4) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?" & _
        ", ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand5.Connection = Me.OleCn
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, "CNPJ"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("IE", System.Data.OleDb.OleDbType.VarWChar, 20, "IE"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, "SIGLAUF"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbInsertCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        '
        'OleDbUpdateCommand5
        '
        Me.OleDbUpdateCommand5.CommandText = "UPDATE CLIENTE SET BAIRRO = ?, CEP = ?, CIDADE = ?, CNPJ = ?, CODCLIENTE = ?, COM" & _
        "PLEMENTO = ?, DDDTEL1 = ?, DDDTEL2 = ?, DDDTEL3 = ?, DDDTEL4 = ?, EMAIL = ?, IE " & _
        "= ?, LOGRADOURO = ?, NOME = ?, NUMERO = ?, SIGLAUF = ?, TELEFONE1 = ?, TELEFONE2" & _
        " = ?, TELEFONE3 = ?, TELEFONE4 = ?, TPLOGRADOURO = ?, TPTELEFONE1 = ?, TPTELEFON" & _
        "E2 = ?, TPTELEFONE3 = ?, TPTELEFONE4 = ? WHERE (CODCLIENTE = ?) AND (BAIRRO = ? " & _
        "OR ? IS NULL AND BAIRRO IS NULL) AND (CEP = ? OR ? IS NULL AND CEP IS NULL) AND " & _
        "(CIDADE = ? OR ? IS NULL AND CIDADE IS NULL) AND (CNPJ = ? OR ? IS NULL AND CNPJ" & _
        " IS NULL) AND (COMPLEMENTO = ? OR ? IS NULL AND COMPLEMENTO IS NULL) AND (DDDTEL" & _
        "1 = ? OR ? IS NULL AND DDDTEL1 IS NULL) AND (DDDTEL2 = ? OR ? IS NULL AND DDDTEL" & _
        "2 IS NULL) AND (DDDTEL3 = ? OR ? IS NULL AND DDDTEL3 IS NULL) AND (DDDTEL4 = ? O" & _
        "R ? IS NULL AND DDDTEL4 IS NULL) AND (EMAIL = ? OR ? IS NULL AND EMAIL IS NULL) " & _
        "AND (IE = ? OR ? IS NULL AND IE IS NULL) AND (LOGRADOURO = ? OR ? IS NULL AND LO" & _
        "GRADOURO IS NULL) AND (NOME = ? OR ? IS NULL AND NOME IS NULL) AND (NUMERO = ? O" & _
        "R ? IS NULL AND NUMERO IS NULL) AND (SIGLAUF = ? OR ? IS NULL AND SIGLAUF IS NUL" & _
        "L) AND (TELEFONE1 = ? OR ? IS NULL AND TELEFONE1 IS NULL) AND (TELEFONE2 = ? OR " & _
        "? IS NULL AND TELEFONE2 IS NULL) AND (TELEFONE3 = ? OR ? IS NULL AND TELEFONE3 I" & _
        "S NULL) AND (TELEFONE4 = ? OR ? IS NULL AND TELEFONE4 IS NULL) AND (TPLOGRADOURO" & _
        " = ? OR ? IS NULL AND TPLOGRADOURO IS NULL) AND (TPTELEFONE1 = ? OR ? IS NULL AN" & _
        "D TPTELEFONE1 IS NULL) AND (TPTELEFONE2 = ? OR ? IS NULL AND TPTELEFONE2 IS NULL" & _
        ") AND (TPTELEFONE3 = ? OR ? IS NULL AND TPTELEFONE3 IS NULL) AND (TPTELEFONE4 = " & _
        "? OR ? IS NULL AND TPTELEFONE4 IS NULL)"
        Me.OleDbUpdateCommand5.Connection = Me.OleCn
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, "BAIRRO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CEP", System.Data.OleDb.OleDbType.VarWChar, 8, "CEP"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, "CIDADE"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, "CNPJ"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, "CODCLIENTE"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, "COMPLEMENTO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL1"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL2"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL3"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, "DDDTEL4"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, "EMAIL"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("IE", System.Data.OleDb.OleDbType.VarWChar, 20, "IE"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, "LOGRADOURO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("NOME", System.Data.OleDb.OleDbType.VarWChar, 100, "NOME"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, "NUMERO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, "SIGLAUF"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE1"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE2"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE3"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TELEFONE4"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, "TPLOGRADOURO"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE1"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE2"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE3"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, "TPTELEFONE4"))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ1", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand5
        '
        Me.OleDbDeleteCommand5.CommandText = "DELETE FROM CLIENTE WHERE (CODCLIENTE = ?) AND (BAIRRO = ? OR ? IS NULL AND BAIRR" & _
        "O IS NULL) AND (CEP = ? OR ? IS NULL AND CEP IS NULL) AND (CIDADE = ? OR ? IS NU" & _
        "LL AND CIDADE IS NULL) AND (CNPJ = ? OR ? IS NULL AND CNPJ IS NULL) AND (COMPLEM" & _
        "ENTO = ? OR ? IS NULL AND COMPLEMENTO IS NULL) AND (DDDTEL1 = ? OR ? IS NULL AND" & _
        " DDDTEL1 IS NULL) AND (DDDTEL2 = ? OR ? IS NULL AND DDDTEL2 IS NULL) AND (DDDTEL" & _
        "3 = ? OR ? IS NULL AND DDDTEL3 IS NULL) AND (DDDTEL4 = ? OR ? IS NULL AND DDDTEL" & _
        "4 IS NULL) AND (EMAIL = ? OR ? IS NULL AND EMAIL IS NULL) AND (IE = ? OR ? IS NU" & _
        "LL AND IE IS NULL) AND (LOGRADOURO = ? OR ? IS NULL AND LOGRADOURO IS NULL) AND " & _
        "(NOME = ? OR ? IS NULL AND NOME IS NULL) AND (NUMERO = ? OR ? IS NULL AND NUMERO" & _
        " IS NULL) AND (SIGLAUF = ? OR ? IS NULL AND SIGLAUF IS NULL) AND (TELEFONE1 = ? " & _
        "OR ? IS NULL AND TELEFONE1 IS NULL) AND (TELEFONE2 = ? OR ? IS NULL AND TELEFONE" & _
        "2 IS NULL) AND (TELEFONE3 = ? OR ? IS NULL AND TELEFONE3 IS NULL) AND (TELEFONE4" & _
        " = ? OR ? IS NULL AND TELEFONE4 IS NULL) AND (TPLOGRADOURO = ? OR ? IS NULL AND " & _
        "TPLOGRADOURO IS NULL) AND (TPTELEFONE1 = ? OR ? IS NULL AND TPTELEFONE1 IS NULL)" & _
        " AND (TPTELEFONE2 = ? OR ? IS NULL AND TPTELEFONE2 IS NULL) AND (TPTELEFONE3 = ?" & _
        " OR ? IS NULL AND TPTELEFONE3 IS NULL) AND (TPTELEFONE4 = ? OR ? IS NULL AND TPT" & _
        "ELEFONE4 IS NULL)"
        Me.OleDbDeleteCommand5.Connection = Me.OleCn
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODCLIENTE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODCLIENTE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_BAIRRO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BAIRRO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CEP1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CEP", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CIDADE1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CIDADE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CNPJ1", System.Data.OleDb.OleDbType.VarWChar, 14, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CNPJ", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_COMPLEMENTO1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMPLEMENTO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL1", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL11", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL2", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL21", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL3", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL31", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL4", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DDDTEL41", System.Data.OleDb.OleDbType.VarWChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DDDTEL4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EMAIL1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EMAIL", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_IE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IE", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NOME1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOME", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_NUMERO1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NUMERO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_SIGLAUF1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SIGLAUF", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPLOGRADOURO1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPLOGRADOURO", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE11", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE1", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE2", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE21", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE2", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE3", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE31", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE3", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE4", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand5.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TPTELEFONE41", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TPTELEFONE4", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaCliente
        '
        Me.OleDaCliente.DeleteCommand = Me.OleDbDeleteCommand5
        Me.OleDaCliente.InsertCommand = Me.OleDbInsertCommand5
        Me.OleDaCliente.SelectCommand = Me.OleDbSelectCommand6
        Me.OleDaCliente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CLIENTE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODCLIENTE", "CODCLIENTE"), New System.Data.Common.DataColumnMapping("SIGLAUF", "SIGLAUF"), New System.Data.Common.DataColumnMapping("NOME", "NOME"), New System.Data.Common.DataColumnMapping("EMAIL", "EMAIL"), New System.Data.Common.DataColumnMapping("CNPJ", "CNPJ"), New System.Data.Common.DataColumnMapping("IE", "IE"), New System.Data.Common.DataColumnMapping("TPLOGRADOURO", "TPLOGRADOURO"), New System.Data.Common.DataColumnMapping("LOGRADOURO", "LOGRADOURO"), New System.Data.Common.DataColumnMapping("NUMERO", "NUMERO"), New System.Data.Common.DataColumnMapping("COMPLEMENTO", "COMPLEMENTO"), New System.Data.Common.DataColumnMapping("CIDADE", "CIDADE"), New System.Data.Common.DataColumnMapping("BAIRRO", "BAIRRO"), New System.Data.Common.DataColumnMapping("CEP", "CEP"), New System.Data.Common.DataColumnMapping("TELEFONE1", "TELEFONE1"), New System.Data.Common.DataColumnMapping("TELEFONE2", "TELEFONE2"), New System.Data.Common.DataColumnMapping("TELEFONE3", "TELEFONE3"), New System.Data.Common.DataColumnMapping("TELEFONE4", "TELEFONE4"), New System.Data.Common.DataColumnMapping("TPTELEFONE1", "TPTELEFONE1"), New System.Data.Common.DataColumnMapping("TPTELEFONE2", "TPTELEFONE2"), New System.Data.Common.DataColumnMapping("TPTELEFONE3", "TPTELEFONE3"), New System.Data.Common.DataColumnMapping("TPTELEFONE4", "TPTELEFONE4"), New System.Data.Common.DataColumnMapping("DDDTEL1", "DDDTEL1"), New System.Data.Common.DataColumnMapping("DDDTEL2", "DDDTEL2"), New System.Data.Common.DataColumnMapping("DDDTEL3", "DDDTEL3"), New System.Data.Common.DataColumnMapping("DDDTEL4", "DDDTEL4")})})
        Me.OleDaCliente.UpdateCommand = Me.OleDbUpdateCommand5
        '
        'OleDbSelectCommand7
        '
        Me.OleDbSelectCommand7.CommandText = "SELECT CODNATDESC, DSCNATDESC FROM NATUREZADESCONTO"
        Me.OleDbSelectCommand7.Connection = Me.OleCn
        '
        'OleDbInsertCommand6
        '
        Me.OleDbInsertCommand6.CommandText = "INSERT INTO NATUREZADESCONTO(CODNATDESC, DSCNATDESC) VALUES (?, ?)"
        Me.OleDbInsertCommand6.Connection = Me.OleCn
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESC"))
        Me.OleDbInsertCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, "DSCNATDESC"))
        '
        'OleDbUpdateCommand6
        '
        Me.OleDbUpdateCommand6.CommandText = "UPDATE NATUREZADESCONTO SET CODNATDESC = ?, DSCNATDESC = ? WHERE (CODNATDESC = ?)" & _
        " AND (DSCNATDESC = ? OR ? IS NULL AND DSCNATDESC IS NULL)"
        Me.OleDbUpdateCommand6.Connection = Me.OleCn
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, "CODNATDESC"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, "DSCNATDESC"))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand6
        '
        Me.OleDbDeleteCommand6.CommandText = "DELETE FROM NATUREZADESCONTO WHERE (CODNATDESC = ?) AND (DSCNATDESC = ? OR ? IS N" & _
        "ULL AND DSCNATDESC IS NULL)"
        Me.OleDbDeleteCommand6.Connection = Me.OleCn
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CODNATDESC", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CODNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand6.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DSCNATDESC1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DSCNATDESC", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDaNatDesc
        '
        Me.OleDaNatDesc.DeleteCommand = Me.OleDbDeleteCommand6
        Me.OleDaNatDesc.InsertCommand = Me.OleDbInsertCommand6
        Me.OleDaNatDesc.SelectCommand = Me.OleDbSelectCommand7
        Me.OleDaNatDesc.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NATUREZADESCONTO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CODNATDESC", "CODNATDESC"), New System.Data.Common.DataColumnMapping("DSCNATDESC", "DSCNATDESC")})})
        Me.OleDaNatDesc.UpdateCommand = Me.OleDbUpdateCommand6
        CType(Me.DsDetSocio1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Dim sqlwhere As String
    Dim codDetFat As String
    Dim detFat As New clsdetFaturamento()
    Dim Fat As New clsFaturamento()
    Dim Config As New clsConfiguracao(Server)
    Dim socio As New clsSocio()
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        OleCn.ConnectionString = Config.StringConexao
        socio.oleConexão = OleCn
        If User.Identity.Name <> "Contador" And socio.NivelAcesso(User.Identity.Name) <> 1 Then
            Response.Redirect("../Socio/default.aspx")
        End If

        Me.grdImpostos.PageSize = Config.TamanhoPaginaGrid
        If Not Page.IsPostBack Then
            ' CarregarDados(codDetFat)
            PreencherTela()
        End If


    End Sub
    Sub CarregarDados(ByVal codDetFat As String)
        Dim sql As String
        Dim sqlaux As String

        'Pegando Informações dos Tipos de Descontos
        sql = Me.OleDaLancDescView.SelectCommand.CommandText
        sqlaux = sql
        sqlwhere = " where  CODNATDESC ='27412010114132533425' AND CODDETFATURAMENTO = '" & codDetFat & "'"
        sql = sql & sqlwhere
        Me.OleDaLancDescView.SelectCommand.CommandText = sql
        Me.OleDaLancDescView.Fill(Me.DsDetSocio1, "LANCAMENTO_DESCONTOS")
        Me.OleDaLancDescView.SelectCommand.CommandText = sqlaux

    End Sub

    Sub PreencherTela()
        'informações do Cabeçalho.

        codDetFat = Request.Params("CodDetFat").ToString
        If Me.OleCn.State = ConnectionState.Open Then
            Me.OleCn.Close()
        End If
        Me.OleCn.Open()

        detFat.oleConexão = Me.OleCn
        detFat.CodDetFaturamento = codDetFat
        detFat.SelDetFaturamento()

        Fat.oleConexão = Me.OleCn
        Fat.CodFaturamento = detFat.CodFaturamento
        Fat.SelFaturamento()


        Me.lblSocio.Text = detFat.NomeSocio
        Me.lblFatBruto.Text = FormatCurrency(detFat.ValorBruto)
        Me.lblIRRF.Text = FormatCurrency(detFat.IRRF)
        Me.lblAReceber.Text = FormatCurrency(detFat.Valorrec)
        Me.lblCliente.Text = Fat.NomeCliente
        Me.lblData.Text = Fat.DtFaturamento.ToShortDateString
        Me.lblTotImpostos.Text = FormatCurrency(TotalizarImpostos(detFat.CodSocio, detFat.CodDetFaturamento))
        Me.lblValorLiquido.Text = FormatCurrency(CDec(lblAReceber.Text) - CDec(Me.lblTotImpostos.Text))
        CarregarDados(detFat.CodDetFaturamento)
        Me.grdImpostos.DataBind()
        Me.OleCn.Close()

    End Sub


    Function TotalizarImpostos(ByVal CodSocio As String, ByVal CodDetFaturamento As String) As Decimal
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand()
        Dim cn As New OleDb.OleDbConnection()
        Dim dr As OleDb.OleDbDataReader
        Dim total As Decimal
        Try
            'Estou assumindo que os impostos são lançamentos de desconto filhos de um detalhe de faturamento.    
            sql = "select sum(valordesconto) as TotImpostos from lancamento_descontos where codsocio ='" & CodSocio & "' and codDetFaturamento = '" & CodDetFaturamento & "'"
            cn.ConnectionString = Me.OleCn.ConnectionString
            cn.Open()

            cmd.Connection = cn
            cmd.CommandText = sql
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.Item("TotImpostos").ToString <> "" Then
                    total = CDec(dr.Item("TotImpostos").ToString)
                Else
                    total = 0

                End If
            End If
            Return total
        Catch err As Exception
            Throw err
        Finally
            cmd.Dispose()
            cn.Close()
        End Try




    End Function

    Private Sub grdImpostos_EditCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdImpostos.EditCommand
        Dim fat As New clsFaturamento()
        Dim CodFat As String
        Me.DsDetSocio1.DETALHEFATURAMENTO.Clear()
        Me.OleDaDetFat.Fill(Me.DsDetSocio1, "DETALHEFATURAMENTO")
        CodFat = Me.DsDetSocio1.DETALHEFATURAMENTO.FindByCODDETFATURAMENTO(e.Item.Cells(1).Text).CODFATURAMENTO
        fat.oleConexão = Me.OleCn
        fat.AbrirConexão(fat.oleConexão)
        If fat.EstaAuditado(CodFat) Then
            Response.Write("Operação não permitida - Este faturamento já foi confirmado pelo Administrador.")
            Exit Sub
        End If
        fat.FecharObjetos(fat.oleConexão)

        grdImpostos.EditItemIndex = e.Item.ItemIndex
        'Me.grdImpostos.DataBind()
        PreencherTela()
    End Sub

    Private Sub grdImpostos_UpdateCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdImpostos.UpdateCommand
        Dim LancDescontos As New clsLancDescontos()
        Dim NovoValor As Decimal
        Dim CodLancDesconto As String
        Try
            If Not IsNumeric(CType(e.Item.Cells(4).Controls(0), TextBox).Text) Then
                Response.Write("O Valor deve ser um número.")
                PreencherTela()
                Exit Sub
            End If


            NovoValor = CDec(CType(e.Item.Cells(4).Controls(0), TextBox).Text)
            CodLancDesconto = e.Item.Cells(2).Text
            LancDescontos.oleConexão = Me.OleCn
            LancDescontos.Usuário = User.Identity.Name
            LancDescontos.AtulizarValorDesconto(NovoValor, CodLancDesconto)
            grdImpostos.EditItemIndex = -1
            'Me.grdImpostos.DataBind()
            PreencherTela()
            'Me.lblTotImpostos.Text = FormatCurrency(TotalizarImpostos(detFat.CodSocio, detFat.CodDetFaturamento))
        Catch err As Exception
            Throw err
        End Try
    End Sub

    Private Sub grdImpostos_CancelCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles grdImpostos.CancelCommand
        grdImpostos.EditItemIndex = -1
        'Me.grdImpostos.DataBind()
        PreencherTela()
    End Sub
End Class
