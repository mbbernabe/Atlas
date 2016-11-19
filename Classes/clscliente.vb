Public Class clsCliente
    Inherits clsAcessaBanco
#Region "Métodos Públicos de Acesso aos Dados"
    Public Sub Insert(ByVal Nome As String, ByVal CNPJ As String, ByVal IE As String, ByVal Email As String, _
                      ByVal TpLogradouro As String, ByVal Logradouro As String, ByVal Numero As String, ByVal complemento As String, _
                      ByVal Bairro As String, ByVal Cidade As String, ByVal Uf As String, ByVal Cep As String, _
                      ByVal TpTelefone1 As String, ByVal TpTelefone2 As String, ByVal TpTelefone3 As String, ByVal TpTelefone4 As String, _
                      ByVal Telefone1 As String, ByVal Telefone2 As String, ByVal Telefone3 As String, ByVal Telefone4 As String, _
                      ByVal DDDTel1 As String, ByVal DDDTel2 As String, ByVal DDDTel3 As String, ByVal DDDTel4 As String)
        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim Codigo As String
            Dim sqlbuider As New System.Text.StringBuilder()
            Codigo = GerarCodigo()
            With sqlbuider
                .Append("insert into Cliente ")
                .Append("(CODCLIENTE")
                .Append(", NOME")
                .Append(", CNPJ")
                .Append(", IE")
                .Append(", EMAIL")
                .Append(", TPLOGRADOURO")
                .Append(", LOGRADOURO")
                .Append(", NUMERO")
                .Append(", COMPLEMENTO")
                .Append(", BAIRRO")
                .Append(", CIDADE")
                .Append(", SIGLAUF")
                .Append(", CEP")
                .Append(", TPTELEFONE1")
                .Append(", TPTELEFONE2")
                .Append(", TPTELEFONE3")
                .Append(", TPTELEFONE4")
                .Append(", TELEFONE1")
                .Append(", TELEFONE2")
                .Append(", TELEFONE3")
                .Append(", TELEFONE4")
                .Append(", DDDTEL1")
                .Append(", DDDTEL2")
                .Append(", DDDTEL3")
                .Append(", DDDTEL4")
                .Append(") VALUES (")
                .Append("'" & Codigo.Trim & "'")
                .Append(", '" & Nome.Trim & "'")
                .Append(",'" & CNPJ.Trim & "'")
                .Append(",'" & IE.Trim & "'")
                .Append(",'" & Email.Trim & "'")
                .Append(",'" & TpLogradouro.Trim & "'")
                .Append(",'" & Logradouro.Trim & "'")
                .Append(",'" & Numero.Trim & "'")
                .Append(",'" & complemento.Trim & "'")
                .Append(",'" & Bairro.Trim & "'")
                .Append(",'" & Cidade.Trim & "'")
                .Append(",'" & Uf.Trim & "'")
                .Append(",'" & Cep.Trim & "'")
                .Append(",'" & TpTelefone1.Trim & "'")
                .Append(",'" & TpTelefone2.Trim & "'")
                .Append(",'" & TpTelefone3.Trim & "'")
                .Append(",'" & TpTelefone4.Trim & "'")
                .Append(",'" & Telefone1.Trim & "'")
                .Append(",'" & Telefone2.Trim & "'")
                .Append(",'" & Telefone3.Trim & "'")
                .Append(",'" & Telefone4.Trim & "'")
                .Append(",'" & DDDTel1.Trim & "'")
                .Append(",'" & DDDTel2.Trim & "'")
                .Append(",'" & DDDTel3.Trim & "'")
                .Append(",'" & DDDTel4.Trim & "'")
                .Append(" )")
            End With
            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString.Trim
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub
    Public Sub Update(ByVal Codigo As String, ByVal Nome As String, ByVal CNPJ As String, ByVal IE As String, ByVal Email As String, _
                      ByVal TpLogradouro As String, ByVal Logradouro As String, ByVal Numero As String, ByVal complemento As String, _
                      ByVal Bairro As String, ByVal Cidade As String, ByVal Uf As String, ByVal Cep As String, _
                      ByVal TpTelefone1 As String, ByVal TpTelefone2 As String, ByVal TpTelefone3 As String, ByVal TpTelefone4 As String, _
                      ByVal Telefone1 As String, ByVal Telefone2 As String, ByVal Telefone3 As String, ByVal Telefone4 As String, _
                      ByVal DDDTel1 As String, ByVal DDDTel2 As String, ByVal DDDTel3 As String, ByVal DDDTel4 As String)

        Try
            Dim oleCmd As New OleDb.OleDbCommand()
            Dim sqlbuider As New System.Text.StringBuilder()
            With sqlbuider
                .Append("update Cliente set ")
                .Append(" NOME = '" & Nome.Trim & "'")
                .Append(", CNPJ = '" & CNPJ.Trim & "'")
                .Append(", IE = '" & IE.Trim & "'")
                .Append(", EMAIL=  '" & Email.Trim & "'")
                .Append(", TPLOGRADOURO = '" & TpLogradouro.Trim & "'")
                .Append(", LOGRADOURO = '" & Logradouro.Trim & "'")
                .Append(", NUMERO = '" & Numero.Trim & "'")
                .Append(", COMPLEMENTO = '" & complemento.Trim & "'")
                .Append(", BAIRRO = '" & Bairro.Trim & "'")
                .Append(", CIDADE = '" & Cidade.Trim & "'")
                .Append(", SIGLAUF = '" & Uf.Trim & "'")
                .Append(", CEP = '" & Cep.Trim & "'")
                .Append(", TPTELEFONE1 = '" & TpTelefone1.Trim & "'")
                .Append(", TPTELEFONE2 = '" & TpTelefone2.Trim & "'")
                .Append(", TPTELEFONE3 = '" & TpTelefone3.Trim & "'")
                .Append(", TPTELEFONE4= '" & TpTelefone4.Trim & "'")
                .Append(", TELEFONE1 = '" & Telefone1.Trim & "'")
                .Append(", TELEFONE2 = '" & Telefone2.Trim & "'")
                .Append(", TELEFONE3 = '" & Telefone3.Trim & "'")
                .Append(", TELEFONE4 = '" & Telefone4.Trim & "'")
                .Append(", DDDTEL1 = '" & DDDTel1.Trim & "'")
                .Append(", DDDTEL2 = '" & DDDTel2.Trim & "'")
                .Append(", DDDTEL3 = '" & DDDTel3.Trim & "'")
                .Append(", DDDTEL4= '" & DDDTel4.Trim & "'")
                .Append(" WHERE CODCLIENTE ='" & Codigo.Trim & "'")
            End With

            oleCn.Open()
            oleCmd.CommandText = sqlbuider.ToString
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As Exception
            Throw Err
        Finally
            oleCn.Close()
        End Try
    End Sub
    Public Sub Excluir(ByVal Codigo As String)
        Dim oleCmd As New OleDb.OleDbCommand()
        Try

            Dim sql As String
            sql = "delete from Cliente where CODCLIENTE = '" & Codigo & "'"
            oleCn.Open()
            oleCmd.CommandText = sql
            oleCmd.Connection = oleCn
            oleCmd.ExecuteNonQuery()

        Catch Err As OleDb.OleDbException
            Throw err
        Catch Err As Exception
            Throw Err
        Finally
            oleCmd.Dispose()
            oleCn.Close()
        End Try
    End Sub
#End Region
End Class
