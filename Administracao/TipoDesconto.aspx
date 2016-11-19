<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TipoDesconto.aspx.vb" Inherits="AtlasRadioDiagnostico.TipoDesconto1" %>

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
		<div id="nav_extru">Home &gt; Descontos &gt; Tipo de Desconto</div>
	</div>
	<h2>Tipo de Desconto</h2>
	<table id="Table1" width="700" cellspacing="0" cellpadding="0" border="0">
							<tr valign="bottom">
								<td width="320" height="30" align="left" class="textoazul"><asp:label ID="Label1" runat="server" Height="20px" Width="214px" Font-Bold="true">Selecione a Natureza do Desconto</asp:label></td>
								<td width="97" height="30"></td>
								<td height="30" colSpan="2" align="left">&nbsp;</td>
								<td width="78" height="30">&nbsp;</td>
							</tr>
							<tr>
								<td width="320" height="30" align="left">
									<asp:dropdownlist id="ddwNaturezaDesconto" runat="server" CssClass="textoazul" 
                                        Height="16px" Width="301px" DataMember="NATUREZADESCONTO" 
                                        DataTextField="DSCNATDESC" DataValueField="CODNATDESC">									</asp:dropdownlist></TD>
							  <td height="30" colspan="4"><asp:button id="btnSelNatDesconto" runat="server" Text="Selecionar"></asp:button>&nbsp;&nbsp;<asp:button id="bntNovo" runat="server" Text="Novo"></asp:button></td>
							</tr>
	</table>

	<h2 style=" margin-bottom:15px;">Lista de Descontos</h2>
	<asp:datagrid ID="grd"
		runat="server"
		Width="99%" 
		AlternatingItemStyle-CssClass="textoazul" 
		AlternatingItemStyle-BackColor="#FFFAF2"
		DataMember="TIPODESCONTO"
		GridLines="Horizontal" 
		CellPadding="1" 
		ForeColor="#336699" 
		BorderWidth="0px" 
		BorderColor="White" 
		AutoGenerateColumns="False" 
		DataKeyField="CODTPDESCONTO" 
		AllowPaging="True" 
		PageSize="6" 
		BackColor="#ffffff">
			<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#FFFAF2"></SelectedItemStyle>
			<AlternatingItemStyle CssClass="textoazul" BackColor="#FFFAF2"></AlternatingItemStyle>
			<ItemStyle ForeColor="#336699" BackColor="White"></ItemStyle>
			<FooterStyle Height="30px" ForeColor="#336699" BackColor="#DDDDDD"></FooterStyle>
			<Columns>
				<asp:BoundColumn Visible="False" DataField="CODNATDESC" SortExpression="CODNATDESC" ReadOnly="True"
					HeaderText="CODNATDESC"></asp:BoundColumn>
				<asp:BoundColumn Visible="False" DataField="CODTPDESCONTO" SortExpression="CODTPDESCONTO" ReadOnly="True"
					HeaderText="CODTPDESCONTO"></asp:BoundColumn>
				<asp:HyperLinkColumn DataNavigateUrlField="CODTPDESCONTO" DataNavigateUrlFormatString="cadTipoDesconto.aspx?cod={0}"
					DataTextField="NOMTPDESCONTO" SortExpression="NOMTPDESCONTO" HeaderText="Tipo de Desconto">
					<HeaderStyle Height="25px" HorizontalAlign="Left" Font-Bold="true" ForeColor="#FFFFFF" BackColor="#FEA723" CssClass="padleft10" Font-Size="12px"></HeaderStyle>
					<ItemStyle CssClass="textoazul padleft10"></ItemStyle>
				</asp:HyperLinkColumn>
				<asp:ButtonColumn Text="Excluir" HeaderText="&#160;&#160;Excluir&#160;&#160;" CommandName="Delete">
					<HeaderStyle CssClass="header_tbl"></HeaderStyle>
					<ItemStyle HorizontalAlign="Center" Height="25px" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></ItemStyle>
				</asp:ButtonColumn>
				<asp:HyperLinkColumn Text="Incid&#234;ncia" DataNavigateUrlField="CODTPDESCONTO" DataNavigateUrlFormatString="IncPadraoDesc.aspx?CodDesc={0}"
					HeaderText="Incid&#234;ncia">
					<HeaderStyle Height="25px" CssClass="header_tbl"></HeaderStyle>
					<ItemStyle HorizontalAlign="Center" Height="25px" Font-Bold="true" ForeColor="#3399FF" Font-Size="11px"></ItemStyle>
				</asp:HyperLinkColumn>
			</Columns>
			<PagerStyle Position="Bottom" Height="30px" Mode="NumericPages" ForeColor="#618CB4" BackColor="#FFFFFF"></PagerStyle>
	</asp:DataGrid>
	<asp:Label Font-Bold="true" BackColor="#618CB4" ForeColor="#FFFFFF" HorizontalAlign="Center" BorderWidth="3px" BorderColor="#618CB4" id="lblPaginaCorrente" runat="server" />
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
