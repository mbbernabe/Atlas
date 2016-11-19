<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="novoLogin.aspx.vb" Inherits="AtlasRadioDiagnostico.novoLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

	<head>
		<title>Atlas Radiodiagóstico</title>
		<link rel="stylesheet" type="text/css" href="App_Themes/Default/site_conceitual.css"/>
			<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
			<script type="text/javascript" language="Javascript">
		
<!--
  function abre(url) {
    alert(1);
    window.open(url,"_blank","resizable=yes,toolbar=no,status=yes,menubar=no,scrollbars=yes,width=500,height=420,top=0,left=0")
    }
  //-->
			</script>
	</head>
	<body>
		<div id="main">
			<div id="topo">
				<img alt="logo" src="ImagensAtlas/ATLAS_LOGO2.jpg"> <img alt="Atlas Serviços de Radiodiagnóstico" src="ImagensAtlas/AtlasNome.png"/>
			</div>
			<div id="nav">
				<a href="default.aspx">Home</a>&nbsp;|&nbsp; <a href="empresa.htm">Empresa</a>&nbsp;|&nbsp;
				<a href="servicos.htm">Serviços</a>&nbsp;|&nbsp; <a href="contato.html">Contato</a>&nbsp;|&nbsp;
				<a href="novoLogin.aspx">Login</a><br/>
			</div>
			<form id="Form1" method="post" runat="server">
				<div id="login">
					<img alt="login" src="imagens/tit_login.gif"/>
					<asp:hyperlink id="HyperLink1" runat="server" NavigateUrl="Administracao" Visible="False">Administração</asp:hyperlink><asp:hyperlink id="hlk" runat="server" Visible="False">Sócio</asp:hyperlink>
					<p>Preencha os campos
						<br>
						abaixo e clique em ENVIAR.</p>
					<span>NOME DO USUÁRIO</span><br/>
					<asp:textbox id="txtNome" runat="server" CssClass="form_usuario" Width="139px"></asp:textbox><br/>
					<span>SENHA</span><br/>
					<asp:textbox id="txtSenha" runat="server" CssClass="form_senha" Width="139px" TextMode="Password"></asp:textbox><br/>
					<asp:Label ID="lblLoginInvalido" runat="server" Visible="False" CssClass="alerta" ForeColor="Red">Login inválido.<br />Tente novamente!<br /></asp:Label>
					<asp:button id="btnEnviar" runat="server" CssClass="but_login" Text="Enviar"></asp:button><br/>
					<a class="textoazul_peq" href="recuperaSenha.aspx">Esqueceu sua senha?</a><br/>
					<br/>
				</div>
			</form>
			<div id="conteudo_d"></div>
			<div id="footer">
				<a href="default.aspx">Home</a>&nbsp;|&nbsp; <a href="empresa.htm">Empresa</a>&nbsp;|&nbsp;
				<a href="servicos.htm">Serviços</a>&nbsp;|&nbsp; <a href="contato.html">Contato</a>&nbsp;|&nbsp;
				<a href="novoLogin.aspx">Login</a><br/>
				© Copyright Atlas Radiodiagnóstico
			</div>
		</div>
	</body>
</html>
