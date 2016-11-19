<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CadSocio.aspx.vb" Inherits="AtlasRadioDiagnostico.CadSocio" %>

<!DOCTYPE html PUBLIC "-//W3C//Dtd XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Sócios</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css"/>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
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
		<div id="nav_extru">Home &gt; Cadastro &gt; S&oacute;cio </div>
	</div>
	<h2 style="margin-bottom:15px;">Detalhes do S&oacute;cio </h2>
	<table cellspacing="1" cellpadding="0" width="700">
							<tr>
								<td class="textoazul" colspan="6">
									<p align="left"><asp:validationsummary id="ValidationSummary1" runat="server" ShowMessageBox="True"></asp:validationsummary>
                                    <asp:Label ID="lblMessagePersonalizada" Visible="false"  ForeColor="Red" runat="server" Text=""></asp:Label></br>
                                    <asp:textbox id="TxtCodigo" runat="server" Visible="False" CssClass="textoazul"></asp:textbox>
                                    </p>								</td>
							</tr>
							<tr>
								<td class="textoazul" align="right" width="77" bgcolor="#fffaf2"><strong>
							  <asp:label id="Label6" runat="server">Nome:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 351px" colspan="3">
									<p align="right"><asp:textbox id="txtNome" runat="server" CssClass="textoazul" Width="380" MaxLength="100"></asp:textbox></P>								</td>
								<td class="textoalerta" colspan="2"><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Visible="False" CssClass="textoalerta"
										ErrorMessage="Digite o nome" ControlToValidate="txtNome"></asp:requiredfieldvalidator></td>
							</tr>
							<tr>
								<td class="textoazul" style="HEIGHT: 37px" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label3" runat="server" CssClass="textoazul">E-mail:&nbsp;</asp:label></strong></td>
								<td class="" style="WIDTH: 351px; HEIGHT: 37px" width="351" colSpan="3">
									<P align="right"><asp:textbox id="txtEmail" tabIndex="1" runat="server" CssClass="textoazul" Width="377px" MaxLength="100"></asp:textbox></P>								</td>
								<td class="textoalerta" style="HEIGHT: 37px" colSpan="2"><asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" Visible="False" Width="216px" ErrorMessage="Existem caracteres inválidos no e-mail"
										ControlToValidate="txtEmail" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator><asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" Visible="False" ErrorMessage="Digite o e-mail"
										ControlToValidate="txtEmail"></asp:requiredfieldvalidator></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" colSpan="6">
									<P align="right">&nbsp;</P>								</td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label4" runat="server">CRTR:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px"><asp:textbox id="txtCRM" runat="server" Width="140px" tabIndex="2" MaxLength="50"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 69px" align="right" bgColor="#fffaf2">
									<P align="right"><strong><asp:label id="Label7" runat="server" CssClass="textoazul" Width="64px">CPF:&nbsp;</asp:label></strong></P>							  </td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox id="txtCPF" tabIndex="3" runat="server" CssClass="textoazul" Width="125px" MaxLength="10"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" Visible="False" ErrorMessage="Digite o CPF."
										ControlToValidate="txtCNPJ"></asp:requiredfieldvalidator></td>
								<td class="textoazul" style="WIDTH: 37px" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label8" runat="server">Identidade:&nbsp;</asp:label></strong></td>
								<td class="textoalerta"><asp:textbox id="TxtIdentidade" tabIndex="4" runat="server" CssClass="textoazul" Width="160"
										MaxLength="15"></asp:textbox></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" colSpan="6">
									<P align="right">&nbsp;</P>								</td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label5" runat="server">Banco:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px">
									<P><asp:textbox id="txtBanco" runat="server" tabIndex="5" MaxLength="3"></asp:textbox>&nbsp;</P>								</td>
								<td class="textoazul" style="WIDTH: 69px" align="left" bgColor="#fffaf2">
									<P align="right"><strong>Agência:</strong></P>							  </td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox id="txtAgencia" runat="server" Width="125px" tabIndex="6" MaxLength="15"></asp:textbox></td>
								<td class="textoazul"  align="right" bgColor="#fffaf2"><strong>Conta:</strong></td>
								<td class="textoalerta"><asp:textbox id="txtConta" runat="server" tabIndex="7" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr bgcolor="#fffaf2">
								<td colSpan="6" align="right" class="textoazul"></td>
				</tr>
							<tr>
								<td class="textoazul" align="right" bgColor="#fffaf2"><P align="right"><strong>Nome Acesso:</strong></P>							  </td>
								<td class="textoazul" style="WIDTH: 153px"><asp:textbox id="txtNomeAcesso" runat="server" tabIndex="8" MaxLength="50"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 69px" align="left" bgColor="#fffaf2">
									<P align="right"><strong>Senha: </strong>									</P>							  </td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox id="txtSenha" runat="server" Width="118px" TextMode="Password" tabIndex="9" MaxLength="6"></asp:textbox></td>
								<td class="textoazul"  align="right" bgColor="#fffaf2">
							  <P><strong>Confirmar Senha:</strong></P>							  </td>
								<td class="textoalerta"><asp:textbox id="txtConfSenha" runat="server" TextMode="Password" tabIndex="10" MaxLength="6"></asp:textbox>
									<asp:CompareValidator id="cvConfirmaSenha" runat="server" ControlToValidate="txtConfSenha" ErrorMessage="Senha não confere."
										ControlToCompare="txtSenha"></asp:CompareValidator></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" colspan="6">
									<P align="right">&nbsp;</P>								</td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgcolor="#fffaf2"><strong>
							    <asp:label id="Label2" runat="server">CEP:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px"><asp:textbox id="txtCEP" tabIndex="11" runat="server" CssClass="textoazul" MaxLength="8"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 69px" align="right" bgColor="#fffaf2"><strong>
										<P align="right"><asp:label id="Label9" runat="server">Tipo lograd.:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px"><asp:dropdownlist id=ddlTpLograd 
                                        tabIndex=12 runat="server" CssClass="textoazul" Width="120px" 
                                        DataValueField="CODTPLOGRADOURO" DataTextField="DSCTPLOGRADOURO" 
                                        DataMember="TIPOLOGRADOURO">
									</asp:dropdownlist></td>
								<td class="textoazul" style="WIDTH: 37px" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label1" runat="server">Logradouro:&nbsp;</asp:label></strong></td>
								<td class="textoalerta"><asp:textbox id="txtLogradouro" tabIndex="13" runat="server" CssClass="textoazul" Width="160"
										MaxLength="100"></asp:textbox></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgcolor="#fffaf2"><strong>
							    <asp:label id="Label10" runat="server">Número:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px"><asp:textbox id="txtNumero" tabIndex="14" runat="server" CssClass="textoazul" MaxLength="10"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 69px" align="right" bgcolor="#fffaf2"><strong>
										<P align="right"><asp:label id="Label11" runat="server">Complem.:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox id="txtComplemento" tabIndex="15" runat="server" CssClass="textoazul" Width="120px"
										MaxLength="50"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 37px" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label12" runat="server">Bairro:&nbsp;</asp:label></strong></td>
								<td class="textoalerta"><asp:textbox id="txtBairro" tabIndex="16" runat="server" CssClass="textoazul" Width="160" MaxLength="100"></asp:textbox></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgcolor="#fffaf2"><strong>
							    <asp:label id="Label13" runat="server">Cidade:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px"><asp:textbox id="txtCidade" tabIndex="17" runat="server" CssClass="textoazul" MaxLength="100"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 69px" align="right" bgcolor="#fffaf2"><strong>
										<P align="right"><asp:label id="Label14" runat="server">UF:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px"><asp:dropdownlist id=ddlUF tabIndex=18 
                                        runat="server" CssClass="textoazul" Width="120px" DataValueField="SIGLAUF" 
                                        DataTextField="DSCUF" DataMember="UF">
									</asp:dropdownlist></td>
								<td class="textoazul" style="WIDTH: 37px" align="right">&nbsp;</td>
								<td class="textoalerta">&nbsp;</td>
							</tr>
							<tr>
								<td class="textoazul" align="right" colspan="6">
									<P align="right">&nbsp;</P>								</td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgcolor="#fffaf2"><strong>
							  <asp:label id="Label16" runat="server">Tipo Tel.:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px"><asp:dropdownlist id=ddltipoTel1 
                                        tabIndex=19 runat="server" CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td class="textoazul" style="WIDTH: 69px" align="right" bgcolor="#fffaf2"><strong>
										<P align="right"><asp:label id="lblddd1" runat="server">DDD:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox id="txtDDD1" runat="server" CssClass="textoazul" Width="117px" tabIndex="20" MaxLength="3"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 37px" align="right" bgColor="#fffaf2"><strong>
							  <asp:label id="Label18" runat="server">Telefone:&nbsp;</asp:label></strong></td>
								<td class="textoalerta"><asp:textbox id="txtTel1" tabIndex="21" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgcolor="#fffaf2"><strong>
								  <asp:label id="Label19" runat="server" Width="81px" Height="17px">Tipo 
                Tel.:&nbsp;</asp:label></strong></td>
								<td class="textoazul" style="WIDTH: 153px"><asp:dropdownlist id=ddltipoTel2 
                                        tabIndex=22 runat="server" CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td class="textoazul" style="WIDTH: 69px" align="right" bgcolor="#fffaf2"><strong>
										<P align="right"><asp:label id="lblDDD2" runat="server">DDD:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox id="txtDDD2" runat="server" CssClass="textoazul" Width="113px" tabIndex="23" MaxLength="3"></asp:textbox></td>
								<td class="textoazul" style="WIDTH: 37px" align="right" bgcolor="#fffaf2"><strong>
							  <asp:label id="Label20" runat="server">Telefone:&nbsp;</asp:label></strong></td>
								<td class="textoalerta"><asp:textbox id="txtTel2" tabIndex="24" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" bgColor="#fffaf2"><strong>
										<asp:label ID="Label21" runat="server">Tipo Tel.:&nbsp;</asp:label>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 153px"><asp:dropdownlist ID=ddltipoTel3 
                                        TabIndex=25 runat="server" CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul" style="WIDTH: 69px"><strong>
										<p align="right">
											<asp:label ID="lblddd3" runat="server">DDD:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px">
									<asp:textbox id="txtDDD3" tabIndex="26" runat="server" CssClass="textoazul" Width="113px" MaxLength="3"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul" style="WIDTH: 37px"><strong>
										<asp:label ID="Label17" runat="server">Telefone:&nbsp;</asp:label>
							  </strong>								</td>
								<td class="textoalerta"><asp:textbox ID="txtTel3" TabIndex="27" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
							<tr>
								<td align="right" bgcolor="#fffaf2" class="textoazul"><strong>
										<asp:label ID="Label23" runat="server">Tipo Tel.:&nbsp;</asp:label>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 153px"><asp:dropdownlist ID=ddltipoTel4 
                                        TabIndex=28 runat="server" CssClass="textoazul" DataValueField="CODTPTELEFONE" 
                                        DataTextField="DSCTPTELEFONE" DataMember="TIPOTELEFONE">
									</asp:dropdownlist></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul" style="WIDTH: 69px"><strong>
										<p align="right">
											<asp:label ID="lblDDD4" runat="server">DDD:&nbsp;</asp:label></P>
							  </strong>								</td>
								<td class="textoazul" style="WIDTH: 112px"><asp:textbox ID="txtDDD4" runat="server" CssClass="textoazul" Width="114px" tabIndex="29" MaxLength="3"></asp:textbox></td>
								<td align="right" bgcolor="#fffaf2" class="textoazul" style="WIDTH: 37px"><strong>
										<asp:label ID="Label22" runat="server">Telefone:&nbsp;</asp:label>
							  </strong>								</td>
								<td class="textoalerta"><asp:textbox ID="txtTel4" TabIndex="30" runat="server" CssClass="textoazul" MaxLength="20"></asp:textbox></td>
							</tr>
			  </table>
	
	
	<table width="700" cellspacing="0" cellpadding="0">
      <tr>
        <td width="698">&nbsp;</td>
      </tr>
      <tr>
        <td align="center"><asp:Button id="btnEnviar" tabIndex="31" runat="server" Text="Enviar"></asp:Button></td>
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
