<%@ Page Language="vb" AutoEventWireup="false" Codebehind="detfatsocio.aspx.vb" Inherits="ImagingRio2.detfatsocio" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>DetFatSocio</title>
		<META content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<META content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<META content="JavaScript" name="vs_defaultClientScript">
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
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
	</HEAD>
	<body>
	<form id="Form1" method="post" runat="server">
<div id="wrap">
<!--Casca Branca-->		
<div class="bl"><div class="br"><div class="tl"><div class="tr"> 
<!--Começo conteúdo-->
<div id="conteudo">
	<div id="minihead">
		<div id="nav_extru">Home &gt; Lançamentos &gt; Detalhe do Faturamento do Sócio</div>
		<div id="print"><a href="javascript:imprimir();"><img src="img/ico_print.gif" alt="Imprimir"></a></div>
	</div>
	<h2>Detalhe do Faturamento</h2>
	<TABLE width="100%" border="0" cellPadding="0" cellSpacing="0" id="Table4">
							<tr>
								<td colspan="3" height="15"></td>
							</tr>
							<TR>
								<TD width="106" align="right" class="textoazul"><strong>Sócio:&nbsp;</strong></TD>
								<TD width="283" class="textoazul">&nbsp;&nbsp;<asp:label id="lblSocio" runat="server"></asp:label>
								</TD>
								<TD width="311" colspan="2" rowspan="5" valign="top"><TABLE width="100%" border="0" cellPadding="1" cellSpacing="1" id="Table4" style="HEIGHT: 75px">
										<TR>
											<TD width="127" align="right" bgcolor="#FFFAF2" class="textoazul"><b>Faturamento Bruto:</b>&nbsp;</TD>
											<TD width="177" class="textoazul">&nbsp;&nbsp;
												<asp:label id="lblFatBruto" runat="server"></asp:label></TD>
										</TR>
										<TR>
											<TD width="127" align="right" bgcolor="#FFFAF2" class="textoazul"><b>IRRF:&nbsp;</b></TD>
											<TD class="textoazul">&nbsp;&nbsp;
												<asp:label id="lblIRRF" runat="server"></asp:label></TD>
										</TR>
										<TR>
											<TD width="127" align="right" bgcolor="#FFFAF2" class="textoazul"><b>A Receber:&nbsp;</b></TD>
											<TD class="textoazul">&nbsp;&nbsp;
												<asp:label id="lblAReceber" runat="server"></asp:label></TD>
										</TR>
										<TR>
											<TD width="127" align="right" bgcolor="#FFFAF2" class="textoazul"><b>Total dos Impostos:&nbsp;</b></TD>
											<TD class="textoazul">&nbsp;&nbsp;
												<asp:Label id="lblTotImpostos" runat="server"></asp:Label></TD>
										</TR>
										<TR>
											<TD align="right" bgcolor="#FFFAF2" class="textoazul"><b>Líquido:&nbsp;</b></TD>
											<TD class="textoazul">&nbsp;&nbsp; <strong>
													<asp:Label id="lblValorLiquido" runat="server"></asp:Label>
												</strong>
											</TD>
										</TR>
									</TABLE>
									<!-- dados da nota -->
								</TD>
							</TR>
							<TR>
								<TD width="106" align="right" class="textoazul"><strong>Cliente:&nbsp;</strong></TD>
								<TD class="textoazul">&nbsp;&nbsp;<asp:label id="lblCliente" runat="server"></asp:label></TD>
							</TR>
							<TR>
								<TD width="106" align="right" class="textoazul"><strong>Data:&nbsp;</strong></TD>
								<TD class="textoazul">&nbsp;&nbsp;<asp:label id="lblData" runat="server"></asp:label></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD></TD>
							</TR>
							<TR>
								<TD></TD>
								<TD></TD>
							</TR>
			  </TABLE>
	<h2 style="margin-bottom:15px;">Impostos</h2>
	<asp:datagrid id=grdImpostos AlternatingItemStyle-CssClass="textoazul" AlternatingItemStyle-BackColor="#FFFAF2" BorderWidth="0px" runat="server" Width="99%" DataSource="<%# DsDetSocio1 %>" DataKeyField="CODLANCDESCONTO" DataMember="LANCAMENTO_DESCONTOS" AutoGenerateColumns="False">
							<AlternatingItemStyle CssClass="textoazul" BackColor="#FFFAF2"></AlternatingItemStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="CODTPDESCONTO" SortExpression="CODTPDESCONTO" ReadOnly="True" HeaderText="CODTPDESCONTO"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="CODDETFATURAMENTO" SortExpression="CODDETFATURAMENTO" ReadOnly="True" HeaderText="CODDETFATURAMENTO"></asp:BoundColumn>
								<asp:BoundColumn Visible="False" DataField="CODLANCDESCONTO" SortExpression="CODLANCDESCONTO" ReadOnly="True" HeaderText="CODLANCDESCONTO"></asp:BoundColumn>
								<asp:BoundColumn DataField="NOMTPDESCONTO" SortExpression="NOMTPDESCONTO" ReadOnly="True" HeaderText="Tipos de Impostos">
									<HeaderStyle Height="25px" HorizontalAlign="left" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" Font-Size="12px" CssClass="padleft10"></HeaderStyle>
									<ItemStyle CssClass="textoazul padleft10"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="VALORDESCONTO" SortExpression="VALORDESCONTO" HeaderText="Valor" DataFormatString="{0:N2}">
									<HeaderStyle Height="25px" CssClass="header_tbl"></HeaderStyle>
									<ItemStyle Height="25" CssClass="textoazul" HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Atualizar" HeaderText="Editar" CancelText="Cancelar" EditText="Editar">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" CssClass="textocinza_pad10"></ItemStyle>
								</asp:EditCommandColumn>
							</Columns>
						</asp:datagrid><br>
<br>

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
</HTML>
