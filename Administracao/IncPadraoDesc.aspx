<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IncPadraoDesc.aspx.vb" Inherits="AtlasRadioDiagnostico.IncPadraoDesc1" %>

<!DOCTYPE html PUBLIC "-//W3C//Dtd XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/Dtd/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>IncPadraoDesc</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0"/>
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0"/>
		<meta name="vs_defaultClientScript" content="JavaScript"/>
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css"/>
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5"/>
		<!-- <body MS_POSITIONING="GridLayout"> -->
	</head>
<body>
<form id="Form1" method="post" runat="server">
<div id="wrap">
<!--Casca Branca-->		
<div class="bl"><div class="br"><div class="tl"><div class="tr"> 
<!--Começo conteúdo-->
<div id="conteudo">
	<div id="minihead">
		<div id="nav_extru">Home &gt; Descontos &gt; Padrão de Descontos</div>
	</div>
	<h2>Padrão de Descontos</h2>
	<table width="700" border="0" cellpadding="0" cellppacing="0" id="Table4">
		<tr>
			<td colspan="3" height="15"></td>
		</tr>
		<tr>
			<td width="134" align="right" class="textoazul"><strong>Tipo de Desconto:&nbsp;</strong></td>
			<td width="566" class="textoazul"><asp:dropdownlist id="ddwTipoDesconto" runat="server" Width="270px" CssClass="textoazul" DataTextField="O" DataValueField="O" AutoPostBack="True"></asp:dropdownlist></td>
			</tr>
	</table>
	<h2>Sócios</h2>
	<table width="700" border="0" cellPadding="0" cellSpacing="0" id="Table4">
							<tr>
								<td colspan="3" height="15"></td>
							</tr>
							<tr>
								<td width="220" class="textoazul"><strong>Disponíveis&nbsp;</strong></td>
								<td width="60" class="textoazul">&nbsp;</td>
								<td width="354" colspan="2" class="textoazul"><strong>Selecionados&nbsp;</strong></td>
							</tr>
							<tr>
								<td valign="top" class="textoazul">
									<asp:listbox id="lsNaoInc" runat="server" CssClass="textoazul" Width="321px" Height="221" SelectionMode="Multiple"></asp:listbox>
								</td>
								<td width="60" align="middle" class="textoazul">
									<asp:button id="btnVaiTodos" runat="server" Width="47px" Height="32px" CssClass="botao_2r"></asp:button>
									<br>
									<br>
									<asp:button id="btnVoltaTodo" runat="server" Width="47px" Height="32px" CssClass="botao_2l"></asp:button>
									<br>
									<br>
									<asp:button id="btnVaiUm" runat="server" Width="47" Height="32" CssClass="botao_1r"></asp:button>
									<br>
									<br>
									<asp:button id="btnVoltaUm" runat="server" Width="47px" Height="32px" CssClass="botao_1l"></asp:button></td>
								<td colspan="2" valign="top" class="textoazul">
									<asp:listbox id="lsInc" CssClass="textoazul" runat="server" Width="321px" Height="221px" SelectionMode="Multiple"></asp:listbox>
								</td>
							</tr>
						</table>
						<br/><br/><br/>
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
