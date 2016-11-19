<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DesejaSair.aspx.vb" Inherits="AtlasRadioDiagnostico.DesejaSair1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
<title>Atlas Radiodiagnóstico</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0"/>
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0"/>
		<meta name="vs_defaultClientScript" content="JavaScript"/>
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5"/>
		
    <link href="App_Themes/Default/site_conceitual.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<form id="Form1" method="post" runat="server" class="padtop20">
		<div id="login">
			<br/>
			<P><strong>Deseja realmente sair?</strong></P>
			<br/>
				<asp:Button id="btnSim" runat="server" CssClass="botaopesquisar" Text="Sim"></asp:Button>&nbsp;
				<asp:Button id="btnNao" runat="server" CssClass="botaopesquisar" Text="Não"></asp:Button>
			<br/><br/>
		</div>
		</form>
	</body>
</html>
