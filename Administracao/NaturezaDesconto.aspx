<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NaturezaDesconto.aspx.vb" Inherits="AtlasRadioDiagnostico.NaturezaDesconto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>NaturezaDesconto</title>
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
		<div id="nav_extru">Home &gt; Descontos &gt; Natureza dos Descontos </div>
	</div>
	<h2 style="margin-bottom:15px;">Natureza dos Descontos</h2>
	<table width="700" height="30" border="0" cellpadding="0" cellspacing="0">
		<tr>
			<td width="318"><asp:textbox ID="txtIncluir" runat="server" CssClass="textoazul" Width="370px"></asp:textbox></td>
			<td width="20">&nbsp;</td>
			<td width="345"><asp:button id="btnNovo" runat="server" Text="Adicionar"></asp:button></td>
		</tr>
	</table>
	<h2 style="margin-bottom:15px;">Lista de Natureza Descontos</h2>
	<asp:datagrid id=grd AlternatingItemStyle-CssClass="textoazul" 
        AlternatingItemStyle-BackColor="#FFFAF2" BorderWidth="0px" runat="server" 
        Width="99%" AutoGenerateColumns="False" DataMember="NATUREZADESCONTO" 
        DataKeyField="CODNATDESC">
	<AlternatingItemStyle CssClass="textoazul"></AlternatingItemStyle>
	<Columns>
		<asp:BoundColumn Visible="False" DataField="CODNATDESC" SortExpression="CODNATDESC" ReadOnly="True" HeaderText="C&#243;digo"></asp:BoundColumn>
		<asp:BoundColumn DataField="DSCNATDESC" SortExpression="DSCNATDESC" HeaderText="Descri&#231;&#227;o">
			<HeaderStyle Height="25px" HorizontalAlign="Left" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" CssClass="padleft10" Font-Size="12px"></HeaderStyle>
			<ItemStyle CssClass="textoazul padleft10"></ItemStyle>
		</asp:BoundColumn>
		<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Atualizar" HeaderText="&#160;&#160;&#160;Editar&#160;&#160;&#160;" CancelText="Cancelar" EditText="Editar">
			<HeaderStyle CssClass="header_tbl"></HeaderStyle>
			<ItemStyle HorizontalAlign="Center" Height="25px" Font-Bold="true" ForeColor="#3399FF" Font-Size="11px"></ItemStyle>
		</asp:EditCommandColumn>
		<asp:ButtonColumn Text="Excluir" HeaderText="&#160;&#160;&#160;Excluir&#160;&#160;&#160;" CommandName="Delete">
			<HeaderStyle CssClass="header_tbl"></HeaderStyle>
			<ItemStyle HorizontalAlign="Center" Height="25px" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></ItemStyle>
		</asp:ButtonColumn>
	</Columns>
	<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
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
