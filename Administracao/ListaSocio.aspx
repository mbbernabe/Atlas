<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ListaSocio.aspx.vb" Inherits="AtlasRadioDiagnostico.listaSocio1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Clientes</title>
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
		<div id="nav_extru">Home &gt; Cadastro &gt; Sócios</div>
	</div>
	<h2>Cadastro de Sócios</h2>
	<table cellspacing="0" cellpadding="0" width="700">
		<tr>
			<td colspan="3">&nbsp;</td>
		</tr>
		<tr>
			<td class="textoazul" align="right" width="58"><strong>Nome:</strong>&nbsp;</td>
			<td width="402"><asp:textbox id="txtNome" runat="server" CssClass="textoazul" Width="380"></asp:textbox></td>
			<td width="238"><asp:button id="btnAplicarFiltro" runat="server"  Text="Filtrar"></asp:button>&nbsp;&nbsp;<asp:button id="btnNovo" runat="server" Text="Novo Sócio"></asp:button></td>
		</tr>
	</table>
	<h2 style="margin-bottom:15px;">Lista de Sócios</h2>
	<asp:datagrid id=grd runat="server" CssClass="textoazul" Width="99%" 
        DataKeyField="CODSOCIO" PageSize="6" AutoGenerateColumns="False" 
        DataMember="SOCIO" AllowPaging="True" 
        AlternatingItemStyle-CssClass="texto_azul" 
        AlternatingItemStyle-BackColor="#ffffaf2" BackColor="White" BorderWidth="0">
		<AlternatingItemStyle CssClass="texto_azul" BackColor="#ffffaf2"></AlternatingItemStyle>
		<Columns>
			<asp:BoundColumn Visible="False" DataField="CODSOCIO" SortExpression="CODSOCIO" HeaderText="CODSOCIO"></asp:BoundColumn>
			<asp:HyperLinkColumn DataNavigateUrlField="CODSOCIO" DataNavigateUrlFormatString="CadSocio.aspx?cod={0}"
				DataTextField="NOME" SortExpression="NOME" HeaderText="Nome">
				<HeaderStyle Height="25px" HorizontalAlign="Left" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" CssClass="padleft10"></HeaderStyle>
				<itemstyle Height="25px" CssClass="padleft10"></itemstyle>
			</asp:HyperLinkColumn>
			<asp:BoundColumn DataField="TELEFONE1" SortExpression="TELEFONE1" HeaderText="Telefone 1 ">
				<HeaderStyle CssClass="header_tbl" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723"></HeaderStyle>
				<itemstyle Height="25px" CssClass="textoazul" HorizontalAlign="Center"></itemstyle>
			</asp:BoundColumn>
			<asp:BoundColumn DataField="TELEFONE2" SortExpression="TELEFONE2" HeaderText="Telefone 2">
				<HeaderStyle CssClass="header_tbl" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723"></HeaderStyle>
				<itemstyle Height="25px" CssClass="textoazul" HorizontalAlign="Center"></itemstyle>
			</asp:BoundColumn>
			<asp:ButtonColumn Text="Excluir/Recuperar" HeaderText="&#160;&#160;Excluir&#160;&#160;" CommandName="Delete">
				<HeaderStyle CssClass="header_tbl" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723"></HeaderStyle>
				<ItemStyle HorizontalAlign="Center" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></ItemStyle>
			</asp:ButtonColumn>
		</Columns>
		<PagerStyle Position="Bottom" Height="30px" Mode="NumericPages" ForeColor="#618CB4" BackColor="#FFFFFF"></PagerStyle>
	</asp:datagrid>
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
