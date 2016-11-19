<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="welcome.aspx.vb" Inherits="AtlasRadioDiagnostico.welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>welcome</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<META HTTP-EQUIV="Expires" CONTENT="-1">
		<META HTTP-EQUIV="Cache-control" CONTENT="no-store">
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css">
	</head>

<body>
<form id="Form1" method="post" runat="server">
			<!-- <table align="center" width="701">
				<tr>
					<td>
						<asp:Label id="lblData" runat="server" CssClass="textoazul_peq11">Label</asp:Label>
					</td>
					<td align="center">
					</td>
					<td align="right">
						<asp:HyperLink class="textoazul_peq11" id="HyperLink2" runat="server" Height="10px" NavigateUrl="http://www.imagingrio.com.br/DesejaSair.aspx"
							Target="_top">Sair</asp:HyperLink>
					</td>
				</tr>
			</table> -->

<div id="wrap">
<!--Casca Branca-->		
<div class="bl"><div class="br"><div class="tl"><div class="tr"> 
<!--Começo conteúdo-->
<div id="conteudo" style="padding-left:10%; width:760px;">
		<div id="art_welcome">
		<img src="img/art_core_admin.jpg" alt="Bem-Vindo a &agrave;rea Administrativa da Imaging" width="324" height="295">		</div>
		<div id="nav_welcome">
			<ul>
				<li id="extrato">
					<asp:HyperLink id="HyperLink3" runat="server" NavigateUrl="extratomensal.aspx" ><h3>Extrato Financeiro</h3></asp:HyperLink>
					Agora você pode acessar os seus extratos financeiros detalhados &nbsp;diratamente aqui no site. Confira.
				</li>
				<li id="user">
					<asp:HyperLink id="HyperLink1" runat="server"  NavigateUrl="CadSocio.aspx"><h3>Dados Cadastrais</h3></asp:HyperLink>
					Mantenha os seus dados cadastrais atualizados atravé do link abaixo.
				</li>
			</ul>
		</div>
		<div class="clear"></div>
		<br/><br/><br/><br/><br/><br/><br/>
</div>
<!--Final conteúdo--> 
</div></div></div></div>

<!--Final Casca Branca-->	
</div>
</form>
</body>
</html>
