<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="detfat.aspx.vb" Inherits="AtlasRadioDiagnostico.detfat1" %>
<%@ Register TagPrefix="uc1" TagName="cboCliente" Src="../Controles/cbocliente.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cboSocio" Src="../Controles/cboSocio.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>DetFat</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript">
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
		<div id="nav_extru">Home &gt; Lançamentos &gt; Despesas</div>
		<div id="print"><a href="javascript:imprimir();"><img src="img/ico_print.gif" alt="Imprimir"></a></div>
	</div>
	<h2>Notas Fiscais</h2>
	<table width="100%" border="0" cellpadding="0" cellspacing="0" id="Table10">
							<tr>
								<td colspan="3" height="15"></td>
							</tr>
							<tr>
								<td width="145" align="right" class="textoazul"><strong>Cliente:&nbsp;</strong></td>
								<td width="341" class="textoazul">
									<uc1:cboCliente CssClass="textoazul" id="CboCliente1" runat="server"></uc1:cboCliente>
							  </td>
								<td width="478" colspan="2" rowspan="4">
									<!-- dados da nota -->
									<table width="100%" border="0" cellpadding="1" cellspacing="1" id="Table4" style="HEIGHT: 75px">
										<tr>
											<td width="124" align="right" bgcolor="#FFFAF2" class="textoazul"><b>Valor Bruto:</b>&nbsp;</td>
											<td width="245" class="textoazul">&nbsp;&nbsp;
												<asp:label id="lblValorBruto" runat="server"></asp:label></td>
										</tr>
										<tr>
											<td width="124" align="right" bgcolor="#FFFAF2" class="textoazul"><b>IRRF:&nbsp;</b></td>
											<td class="textoazul">&nbsp;&nbsp;
												<asp:label id="lblIRRF" runat="server"></asp:label></td>
										</tr>
										<tr>
											<td width="124" align="right" bgcolor="#FFFAF2" class="textoazul"><b>Valor Rec:&nbsp;</b></td>
											<td class="textoazul">&nbsp;&nbsp;
												<asp:label id="lblValorRec" runat="server"></asp:label></td>
										</tr>
										<tr>
											<td width="124" align="right" bgcolor="#FFFAF2" class="textoazul"><b>Total 
                                                Impostos:&nbsp;</b></TD>
											<td class="textoazul">
												&nbsp;&nbsp;
												<asp:label ID="lblTotalImpostos" runat="server"></asp:label></td>
										</tr>
								  </table>
								</td>
							</tr>
							<tr>
								<td width="145" align="right" class="textoazul"><strong>Data:&nbsp;</strong></td>
								<td><asp:textbox id="txtData" CssClass="textoazul" runat="server" Width="118px"></asp:textbox></td>
							</tr>
							<tr>
								<td width="145" align="right" class="textoazul"><strong>Nota Fiscal:&nbsp;</strong></td>
								<td><asp:textbox id="txtNota" CssClass="textoazul" runat="server" Width="117px"></asp:textbox></td>
							</tr>
							<tr>
								<td></td>
								<td></td>
							</tr>
			  </table>
	
	<h2>Sócios</h2>
	<table id="Table3" cellspacing="0" cellpadding="0" width="700" border="0">
							<tr>
								<td height="15" colspan="5"></td>
							</tr>
							<tr>
								<td width="106" align="right" class="textoazul"><strong>Socio:</strong>&nbsp;</td>
								<td width="284">
									<uc1:cboSocio id="CboSocio1" CssClass="textoazul" runat="server"></uc1:cboSocio>
								</td>
								<td width="41" class="textoazul"><strong>Valor:</strong>&nbsp;</td>
								<td width="110"><asp:textbox ID="txtValorBrutoSocio" CssClass="textoazul" runat="server" Width="100"></asp:textbox></td>
								<td width="149">
									<asp:button ID="btnAdicionar" runat="server" Text="Adicionar" ></asp:button>
								</td>
							</tr>
			  </table>
						
						<h2 style="margin-bottom:15px;">Lista de Lançamentos</h2>
    <asp:datagrid id="grdDetFat"  
        AlternatingItemStyle-CssClass="textoazul" 
        AlternatingItemStyle-BackColor="#FFFAF2" BorderWidth="0px" runat="server" 
        Width="99%" DataMember="DETALHEFATURAMENTO" DataKeyField="CODDETFATURAMENTO" 
        AutoGenerateColumns="False">
							<AlternatingItemStyle CssClass="textoazul" BackColor="#FFFAF2"></AlternatingItemStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="CODDETFATURAMENTO" SortExpression="CODDETFATURAMENTO" ReadOnly="True" HeaderText="CODDETFATURAMENTO"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="CODFATURAMENTO" SortExpression="CODFATURAMENTO" HeaderText="CODFATURAMENTO"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="CODSOCIO" SortExpression="CODSOCIO" HeaderText="CODSOCIO"></asp:BoundColumn>
								<asp:BoundColumn DataField="NOME" SortExpression="NOME" HeaderText="Nome Socio">
									<HeaderStyle Height="25px" HorizontalAlign="left" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" Font-Size="12px" CssClass="padleft10"></HeaderStyle>
									<ItemStyle CssClass="textoazul padleft10" HorizontalAlign="left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="VALORBRUTOSOCIO" SortExpression="VALORBRUTOSOCIO" HeaderText="Valor Bruto" DataFormatString="{0:N2}">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle Height="30px" CssClass="textoazul padright10" HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="IRRF" SortExpression="IRRF" HeaderText=" IRRF " DataFormatString="{0:N2}">
									<HeaderStyle Height="25px" CssClass="header_tbl"></HeaderStyle>
									<ItemStyle CssClass="textoazul padright10" HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="VALORREC" SortExpression="VALORREC" HeaderText=" Valor a receber " DataFormatString="{0:N2}">
									<HeaderStyle  CssClass="header_tbl"></HeaderStyle>
									<ItemStyle CssClass="textoazul padright10" HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
							<%-- Comentado até migração da tela detfatsocio
								<asp:HyperLinkColumn Text="Impostos" DataNavigateUrlField="CODDETFATURAMENTO" DataNavigateUrlFormatString="detFatSocio.aspx?CodDetFat={0}" HeaderText="Impostos">
										<HeaderStyle  CssClass="header_tbl"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" Font-Bold="true" ForeColor="#9900FF" Font-Size="11px"></ItemStyle>
								</asp:HyperLinkColumn>--%>
							
								<asp:ButtonColumn Text="Excluir" HeaderText=" Excluir " CommandName="Delete">
									<HeaderStyle  CssClass="header_tbl"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></ItemStyle>
								</asp:ButtonColumn>
							</Columns>
						</asp:datagrid>
						<asp:textbox id="txtCodFaturamento" CssClass="textoazul" runat="server" Visible="False"></asp:textbox></td>
					<!-- fim aspx -->
					<table width="700" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="11">&nbsp;</td>
					<td width="678"><table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td width="47%" class="textoalert"><asp:requiredfieldvalidator ID="rfvTxtData" runat="server" ControlToValidate="txtData" ErrorMessage="A Data é obrigatória" designtimedragdrop="201"></asp:requiredfieldvalidator></td>
								<td width="53%" class="textoalert"><asp:customvalidator ID="cvTxtData" runat="server" ControlToValidate="txtData" ErrorMessage="Data inválida. Exemplo de data válida : 22/10/2003" designtimedragdrop="202"></asp:customvalidator></td>
							</tr>
							<tr>
								<td class="textoalert"><asp:validationsummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"></asp:validationsummary></td>
								<td class="textoalert">&nbsp;</td>
							</tr>
						</table>
					</td>
					<td width="11">&nbsp;</td>
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
