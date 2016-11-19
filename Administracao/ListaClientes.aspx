<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ListaClientes.aspx.vb" Inherits="AtlasRadioDiagnostico.listaClientes" %>

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
		<div id="nav_extru">Home &gt; Cadastro &gt; Clientes</div>
	</div>
	<h2 style="margin-bottom:15px;">Cadastro de Clientes </h2>
	<table width="700" cellspacing="0" cellpadding="0">
		<tr>
			<td width="115" align="right" class="textoazul"><b>Nome:&nbsp;</b></td>
			<td width="389"><asp:textbox ID="txtNome" runat="server" Width="380" CssClass="textoazul"></asp:textbox></td>
			<td width="194"><asp:Button id="btnAplicarFiltro"  runat="server" Text="Filtrar"></asp:Button>&nbsp;&nbsp;<asp:button id="btnNovo" runat="server" Text="Novo Cliente"></asp:button></td>
		</tr>
	</table>
	<h2 style="margin-bottom:15px;">Lista de Clientes </h2>
	<asp:datagrid
		id="grdCliente"
		AlternatingItemStyle-BackColor="#fffaf2"
		AlternatingItemStyle-CssClass="textoazul"
		CssClass="textoazul"
		runat="server"
		OnDeleteCommand="grdCliente_DeleteCommand"
		OnPageIndexChanged="grdCliente_PageIndexChanged"
		AllowPaging="True" 
		Width="99%"	
		DataMember="CLIENTE" 
		AutoGenerateColumns="False"
		PageSize="6"
		DataKeyField="CODCLIENTE"
		BorderWidth="0px"	>

<AlternatingItemStyle BackColor="#FFFAF2" CssClass="textoazul"></AlternatingItemStyle>
		<Columns>
			<asp:BoundColumn Visible="False" DataField="CODCLIENTE" SortExpression="CODCLIENTE" HeaderText="CODCLIENTE"></asp:BoundColumn>
			<asp:HyperLinkColumn DataNavigateUrlField="CODCLIENTE" DataNavigateUrlFormatString="wfrmCadCliente.aspx?cod={0}" DataTextField="NOME" SortExpression="NOME" HeaderText="Nome">
				<HeaderStyle Height="25px" HorizontalAlign="Left" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" CssClass="padleft10" Font-Size="12px"></HeaderStyle>
				<itemstyle CssClass="textoazul padleft10" Height="25px"></itemstyle>
			</asp:HyperLinkColumn>
			<asp:BoundColumn DataField="TELEFONE1" SortExpression="TELEFONE1" HeaderText="Telefone 1">
				<HeaderStyle CssClass="header_tbl" Height="25px" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" Font-Size="12px"></HeaderStyle>
				<itemstyle CssClass="textoazul" HorizontalAlign="Center"></itemstyle>
			</asp:BoundColumn>
			<asp:BoundColumn DataField="TELEFONE2" SortExpression="TELEFONE2" HeaderText="Telefone 2">
				<HeaderStyle CssClass="header_tbl" Height="25px" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" Font-Size="12px"></HeaderStyle>
				<itemstyle CssClass="textoazul" HorizontalAlign="Center"></itemstyle>
			</asp:BoundColumn>
			<asp:BoundColumn DataField="CNPJ" SortExpression="CNPJ" HeaderText="CNPJ">
				<HeaderStyle CssClass="header_tbl" Height="25px" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" Font-Size="12px"></HeaderStyle>
				<itemstyle CssClass="textoazul" HorizontalAlign="Center"></itemstyle>
			</asp:BoundColumn>
			<asp:ButtonColumn Text="Excluir" HeaderText="&#160;&#160;&#160;Excluir&#160;&#160;&#160;" CommandName="Delete">
        		<headerstyle CssClass="header_tbl"></headerstyle>
        		<itemstyle  HorizontalAlign="Center" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></itemstyle>
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
