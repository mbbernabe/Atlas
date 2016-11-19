<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CadTipoDesconto.aspx.vb" Inherits="AtlasRadioDiagnostico.cadTipoDesconto1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Tipo Desconto</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css"/>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
	</head>
<body>
<form id="Form1" method="post" runat="server">
<div id="wrap">
<!--Casca Branca-->		
<div class="bl"><div class="br"><div class="tl"><div class="tr"> 
<!--Começo conteúdo-->
<div id="conteudo">
	<div id="minihead">
		<div id="nav_extru">Home &gt; Descontos &gt; Cadastro do Tipo de Desconto</div>
	</div>
	<h2>Cadastro do Tipo de Desconto</h2>
	<table width="700" border="0"  cellpadding="0" cellspacing="0" dwcopytype="CopyTableCell">
		<tr>
			<td colspan="2" height="15">
				<asp:TextBox id="txtCodTpDesc" runat="server" Visible="False"></asp:TextBox></td>
		</tr>
		<tr>
			<td width="159" align="right" class="textoazul"><strong>Natureza Desconto :&nbsp;</strong></td>
			<td width="541" height="30" class="textoazul" style="WIDTH: 405px">
				<asp:dropdownlist id=ddlNatDesconto runat="server" CssClass="textoazul" 
                    Width="260px" DataMember="NATUREZADESCONTO" DataTextField="DSCNATDESC" 
                    DataValueField="CODNATDESC">				</asp:dropdownlist></td>
			</tr>
			<tr>
			<td colspan="2" bgColor="#FFE6BF"></td>
		</tr>
		<tr>
			<td width="159" align="right" class="textoazul"><strong>Tipo de Desconto:&nbsp;</strong></TD>
			<td height="30" style="WIDTH: 405px">
				<asp:textbox id="txtTipoDesconto" CssClass="textoazul" runat="server" Width="176px"></asp:textbox></TD>
		</tr>
		<tr>
			<td></td>
			<td style="WIDTH: 405px"></td>
		</tr>
	</table>
	<h2>Tipo de Valor</h2>
	<table width="700" border="0" cellpadding="0" cellspacing="0">
		<tr>
			<td width="337" class="textoazul">&nbsp;</td>
			<td width="13">&nbsp;</td>
			<td width="350" align="left" class="textoazul">&nbsp;</td>
		</tr>
		<tr>
			<td class="textoazul"><asp:radiobutton ID="rbtValorFixo" runat="server" Text="Valor Fixo" GroupName="PercentDesconto" AutoPostBack="True" Checked="True"></asp:radiobutton></td>
			<td>&nbsp;</td>
			<td class="textoazul"><asp:radiobutton ID="rbtPercentual" runat="server" Text="Percentual" GroupName="PercentDesconto" AutoPostBack="True"></asp:radiobutton></td>
		</tr>
		<tr>
			<td class="textoazul" valign="top" colspan="1" rowspan="1">
				<asp:panel id="pnValorFixo" runat="server" Width="335px" BorderColor="#D0EBF3">
				<table width="100%" border="0" cellspacing="0" cellpadding="0">
					  <tr>
						<td bgcolor="#FFFAF2" style="padding:10px;">
					<table height="40" cellspacing="0" cellpadding="0" width="323" border="0">
									<tr>
										<td class="textocinza" align="right" width="60" height="30"><STRONG>Valor&nbsp;&nbsp;</STRONG></td>
										<td>
											<asp:textbox id="txtValor" runat="server" Width="119px" CssClass="textoazul"></asp:textbox></td>
									</tr>
									<tr>
										<td class="textocinza" align="right">&nbsp;</td>
										<td>
											<asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" Width="203px" CssClass="textoalerta" ErrorMessage="Entre com o valor como: 122,35" ControlToValidate="txtValor" ValidationExpression="\d+(,\d\d)?"></asp:regularexpressionvalidator></td>
									</tr>
								</table>
									</td>
					  </tr>
					</table>
				</asp:panel></td>
			<td></td>
			<td class="textoazul" align="top">
				<asp:Panel id="pnPercent" runat="server" Width="335px" Visible="False">
					<table width="100%" border="0" cellspacing="0" cellpadding="0">
					  <tr>
						<td bgcolor="#FFFAF2" style="padding:10px;">
						<table width="323" border="0" align="center" cellpadding="0" cellspacing="0">
									<tr>
										<td colspan="2"></td>
									</tr>
									<tr align="bottom">
										<td class="textocinza" align="right" width="63"><strong>Valor %&nbsp;</strong> &nbsp;</td>
										<td width="260" height="20">
											<asp:textbox id="txtPercentual" runat="server" Width="250" CssClass="textoazul"></asp:textbox></td>
									</tr>
									<tr  align="center">
										<td class="textoalerta" colspan="2" height="25">
											<div align="center">
												<asp:RegularExpressionValidator id="RegularExpressionValidator2" runat="server" Width="294px" ErrorMessage="Entre com o valor da porcentagem como: 12,35" ControlToValidate="txtPercentual" ValidationExpression="\d+(,\d\d)?"></asp:RegularExpressionValidator></div>
										</td>
									</tr>
									<tr>
										<td bgcolor="#ffffff" colspan="2" height="1"></td>
									</tr>
									<tr>
										<td class="textoazul" colspan="2" height="25"><strong>Incidência do Percentual</strong></td>
									</tr>
									<tr>
										<td class="textoazul" colspan="2">
											<asp:RadioButton id="rbtFatBruto" runat="server" CssClass="textoazul" GroupName="IncFaturamento" Text="Faturamento Bruto"></asp:RadioButton></td>
									</tr>
									<tr>
										<td class="textoazul" colspan="2">
											<asp:RadioButton id="rbtFatMenosIRPJ" runat="server" CssClass="textoazul" GroupName="IncFaturamento" Text="Faturamento Desc. IRRF"></asp:RadioButton></td>
									</tr>
									<tr>
										<td class="textoazul" colspan="2">
											<asp:RadioButton id="rbtFatMenosImpostos" runat="server" CssClass="textoazul" GroupName="IncFaturamento" Text="Faturamento Desc. Impostos"></asp:RadioButton></td>
									</tr>
							</table>
						
						</td>
					  </tr>
					</table>
	
				</asp:Panel>
				</TD>
		</TR>
		<tr>
			<td valign="top" class="textoazul">
			</td>
		</tr>
	</table>
	<br/>
	<div align="center">
	<hr style="border-top: 1px solid #FF9900; border-bottom:1px solid #FFFFFF">
	<asp:Button id="btnEnviar" runat="server" Text="Enviar"></asp:Button>
	<br/>
	<asp:ValidationSummary id="ValidationSummary1" runat="server" HeaderText="Por favor, acerte os erros abaixos listados e envie novamente." Width="346px" Height="87px"></asp:ValidationSummary>
<br/>
<span style="WIDTH: 405px">
<asp:RequiredFieldValidator ID="rfvTipoDesconto" runat="server" ControlToValidate="txtTipoDesconto" CssClass="textoalerta" ErrorMessage="O Tipo de Desconto é obrigatório."></asp:RequiredFieldValidator>
</span>

<br/><br/>
</div>
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
