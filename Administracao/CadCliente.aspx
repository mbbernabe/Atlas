<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CadCliente.aspx.vb" Inherits="AtlasRadioDiagnostico.cadCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Clientes</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css"/>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1/">
		<script language="JavaScript" type="text/JavaScript">
<!--
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);
//-->
		</script>
	</head>
<body>
<form id="Form1" method="post" runat="server">
<div id="wrap">
<!--Casca Branca-->		
<div class="bl"><div class="br"><div class="tl"><div class="tr"> 
<!--Começo conteúdo-->
<div id="conteudo">
	<div id="minihead">
		<div id="nav_extru">Home &gt; Cadastro &gt; Detalhes do Cliente</div>
	</div>
	<h2 style="margin-bottom:15px;">Detalhes do Cliente </h2>
	<table width="700" cellspacing="1" cellpadding="0">
							<tr>
								<td colspan="6" class="textoazul"><asp:validationsummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"></asp:validationsummary>
									<asp:textbox ID="TxtCodigo" CssClass="textoazul" runat="server" Visible="False" Width="400px"></asp:textbox></td>
							</tr>
							<tr>
								<td width="77" align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label6" runat="server">Nome:&nbsp;</asp:label>
									</strong>
								</td>
								<td colspan="3" class="textoazul"><asp:textbox ID="txtNome" runat="server" CssClass="textoazul" Width="380" MaxLength="100"></asp:textbox></td>
								<td colspan="2" class="textoalerta"><asp:requiredfieldvalidator ID="RequiredFieldValidator1" CssClass="textoalerta" runat="server" Visible="False"
										ControlToValidate="txtNome" ErrorMessage="Digite o nome"></asp:requiredfieldvalidator></td>
							</tr>
							<tr>
								<td colspan="6" align="right" class="textoazul">&nbsp;</td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label3" CssClass="textoazul" runat="server">E-mail:&nbsp;</asp:label>
									</strong>
								</td>
								<td width="144" class="textoazul"><asp:textbox ID="txtEmail" TabIndex="1" runat="server" CssClass="textoazul" MaxLength="100"></asp:textbox>
									<asp:regularexpressionvalidator ID="RegularExpressionValidator1" runat="server" Visible="False" ControlToValidate="txtEmail"
										ErrorMessage="Existem caracteres inválidos no e-mail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator>
									<asp:requiredfieldvalidator ID="RequiredFieldValidator3" runat="server" Visible="False" ControlToValidate="txtEmail"
										ErrorMessage="Digite o e-mail"></asp:requiredfieldvalidator></td>
								<td width="93" align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label7" runat="server" CssClass="textoazul">CNPJ:&nbsp;</asp:label>
									</strong>
								</td>
								<td width="144" class="textoazul"><asp:textbox ID="txtCNPJ" TabIndex="2" runat="server" CssClass="textoazul" MaxLength="14"></asp:textbox>
									<asp:requiredfieldvalidator ID="RequiredFieldValidator2" runat="server" Visible="False" ControlToValidate="txtCNPJ"
										ErrorMessage="Digite o CNPJ"></asp:requiredfieldvalidator></td>
								<td width="75" align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label8" runat="server">I.E.:&nbsp;</asp:label>
									</strong>
								</td>
								<td width="158" class="textoalerta"><asp:textbox ID="TxtIE" Width="160" TabIndex="3" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label2" runat="server">CEP:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtCEP" TabIndex="4" runat="server" CssClass="textoazul" MaxLength="8"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label9" runat="server">Tipo lograd.:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:dropdownlist Width="135" ID="ddlTpLograd" TabIndex="5" 
                                        runat="server" CssClass="textoazul" DataMember="TIPOLOGRADOURO" 
                                        DataTextField="DSCTPLOGRADOURO" DataValueField="CODTPLOGRADOURO">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label1" runat="server">Logradouro:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoalerta"><asp:textbox ID="txtLogradouro" Width="160" TabIndex="6" runat="server" CssClass="textoazul"
										MaxLength="100"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label10" runat="server">Número:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtNumero" TabIndex="7" runat="server" CssClass="textoazul" MaxLength="10"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label11" runat="server">Complem.:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtComplemento" TabIndex="8" runat="server" CssClass="textoazul" MaxLength="50"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label12" runat="server">Bairro:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoalerta"><asp:textbox ID="txtBairro" Width="160" TabIndex="9" runat="server" CssClass="textoazul" MaxLength="100"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label13" runat="server">Cidade:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtCidade" TabIndex="10" runat="server" CssClass="textoazul" MaxLength="100"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label14" runat="server">UF:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:dropdownlist ID=ddlUF TabIndex=11 Width="135" 
                                        runat="server" CssClass="textoazul" DataMember="UF" DataTextField="DSCUF" 
                                        DataValueField="SIGLAUF">
									</asp:dropdownlist></td>
								<td align="right" class="textoazul">&nbsp;</td>
								<td class="textoalerta">&nbsp;</td>
							</tr>
							<tr>
								<td colspan="6" align="right" class="textoazul">&nbsp;</td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label16" runat="server">Tipo Tel.:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:dropdownlist ID="ddltipoTel1" TabIndex="12" runat="server" 
                                        CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="lblddd1" runat="server">DDD:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtDDD1" runat="server" CssClass="textoazul" MaxLength="3"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label18" runat="server">Telefone:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoalerta"><asp:textbox ID="txtTel1" TabIndex="13" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label19" runat="server" Width="81px" Height="17px">Tipo 
                Tel.:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:dropdownlist ID="ddltipoTel2" TabIndex="14" runat="server" 
                                        CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="lblDDD2" runat="server">DDD:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtDDD2" runat="server" CssClass="textoazul" MaxLength="3"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label20" runat="server">Telefone:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoalerta"><asp:textbox ID="txtTel2" TabIndex="15" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label21" runat="server">Tipo Tel.:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:dropdownlist ID="ddltipoTel3" TabIndex="16" runat="server" 
                                        CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="lblddd3" runat="server">DDD:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtDDD3" runat="server" CssClass="textoazul" MaxLength="3"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label17" runat="server">Telefone:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoalerta"><asp:textbox ID="txtTel3" TabIndex="17" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label23" runat="server">Tipo Tel.:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:dropdownlist ID="ddltipoTel4" TabIndex="18" runat="server" 
                                        CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="lblDDD4" runat="server">DDD:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoazul"><asp:textbox ID="txtDDD4" runat="server" CssClass="textoazul" MaxLength="3"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label22" runat="server">Telefone:&nbsp;</asp:label>
									</strong>
								</td>
								<td class="textoalerta"><asp:textbox ID="txtTel4" TabIndex="19" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
						</table>
<table width="700" cellspacing="0" cellpadding="0">
<tr>
	<td width="698">&nbsp;</td>
</tr>
<tr>
	<td align="center">
		<asp:Button id="btnEnviar" tabIndex="21" runat="server" Text="Enviar"></asp:Button></td>
</tr>
<tr>
	<td align="center">&nbsp;</td>
</tr>
</table>

</div>
<div class="clear"></div>
<br/>
</div>
<!--Final conteúdo--> 
</div></div></div></div>
<!--Final Casca Branca-->	
</div>
</form>
<br/><br/>
</body>
</html>
