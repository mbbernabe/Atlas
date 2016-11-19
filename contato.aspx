<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="contato.aspx.vb" Inherits="AtlasRadioDiagnostico.contato" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
  <head>
		<title>Atlas - Contato</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1"/>
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1"/>
		<meta name="vs_defaultClientScript" content="JavaScript"/>
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5"/>
		<link rel="stylesheet" type="text/css" href="App_Themes/Default/site_conceitual.css"/>
		
	<script type="text/javascript" language="javascript">
		 function validarEmail(param){
			if (!checkEmail(param)){
			   alert("Email inválido.");
			   document.forms[0].email.focus();			
			}
		 } 
		  function validarFormTela(){
		    var mensagem = ""
			var field 
			var fieldFocus
			var ret = true
			var form
			
			form = document.forms[0]
			
			//Nome
			field = document.getElementById("txtNome");			
			if (!validarRequerido(field.value)){
//			   alert("Nome é obregatório");
			   mensagem = mensagem + " - Nome é obrigatório. \n"
			   if (fieldFocus == undefined){
			    fieldFocus = field;
			   }
			   ret=false;
			}	
		
           //Email
			field = document.getElementById("txtEmail");			
			if (!validarRequerido(field.value)){
			   //alert("O email é obrigatório");
			   mensagem = mensagem + " - O Email é obrigatório. \n"
   			   if (fieldFocus == undefined){
			    fieldFocus = field;
			   }
			   ret=false;
			}		

        
           //Mensagem
			field = document.getElementById("txtMensagem");			
			if (!validarRequerido(field.value)){
			   //alert("A Mensagem é obrigatória");
			   mensagem = mensagem + " - A Mensagem é obrigatória. \n"

   			   if (fieldFocus == undefined){
			    fieldFocus = field;
			   }
			   ret=false;
			}			    
			  
			   if (fieldFocus != undefined){
			   mensagem = " Os seguintes problemas  foram encontrados ao processar a página: \n\n" + mensagem
			   alert(mensagem)
			   fieldFocus.focus()				
			   } 
			   else{
			     form.submit();
			   }
  		   }
		  
		  function validarRequerido(valor){
		     var isValid = true
			  if (trim(valor).length == 0) {
				  isValid = false;
				}
			   
			  return isValid;			 
			  
			  
	    } //  function validarRequerido

		
		</script>
</head>
	<body>
		<div id="main">
			<div id="topo">
				<img alt="logo" src="ImagensAtlas/ATLAS_LOGO2.jpg"> <img alt="Atlas Serviços de Radiodiagnóstico" src="ImagensAtlas/AtlasNome.png">
			</div>
			<div id="nav">
				<a href="default.aspx">Home</a>&nbsp;|&nbsp; <a href="empresa.htm">Empresa</a>&nbsp;|&nbsp;
				<a href="servicos.htm">Serviços</a>&nbsp;|&nbsp; <a href="contato.aspx">Contato</a>&nbsp;|&nbsp;
				<a href="novoLogin.aspx">Login</a><br>
			</div>
			<div style=" BACKGROUND-COLOR:white; WIDTH:100%">
				<div id="mininav"><img src="imagens/contato.jpg" 
                        style="width: 228px; height: 239px">
				</div>
				<div id="form">
					<h1>Fale conosco</h1>
					<div style="WIDTH:350px">
						No intuito de estreitar ainda mais o nosso relacionamento, por favor preencha o 
						formulário abaixo com seus dados, para que possamos entrar em contato o mais 
						breve possível. Com este contato inicial, podemos agendar uma reunião e 
						discutir soluções para a sua empresa.
					</div>
					<form id="Form1" method="post" runat="server" onsubmit="javascript:validarFormTela();">
						<input TYPE="hidden" NAME="assunto" SIZE="24" Value="Contato através do site" ID="Text3"><br>
						<label for="nome">Nome:</label>
						<asp:TextBox id="txtNome" CssClass="textocinza" runat="server"></asp:TextBox>
						<br>
						<label for="empresa">Empresa:</label><asp:TextBox id="txtEmpresa" CssClass="textocinza" runat="server"></asp:TextBox><br>
						Entre somente com números para informar o ddd e o telefone ex: 2129723451<br>
						<label for="telefone">Telefone:</label>
						<asp:TextBox id="txtTelefone" CssClass="textocinza" runat="server" onclick="javascript:getIt(this);" /><br>
						<label for="email">Email:</label>
						<asp:TextBox id="txtEmail" CssClass="textocinza" runat="server" onclick="javascript:validarEmail(this.value);" /><br>
						<label for="cidade">Cidade:</label>
						<asp:TextBox id="txtCidade" CssClass="textocinza" runat="server"></asp:TextBox><br>
						<label for="Estado">Estado:</label><asp:TextBox id="TxtEstado"  CssClass="textocinza" runat="server"></asp:TextBox>
						<br>
						<label for="mensagem">Mensagem:</label><asp:TextBox id="txtMensagem"  Columns="82" Rows="4" runat="server" TextMode="MultiLine" Height="140px"
							Width="281px"></asp:TextBox>
						<br>
						<label for="enviar">&nbsp;</label>
						<asp:Button id="btnEnviar" CssClass="botao_azul" runat="server"  Text="Enviar"></asp:Button>
						&nbsp; <input name="Limpar" type="reset" class="botao_azul" value="Limpar">&nbsp;
						<br>
						&nbsp;
					</form>
				</div>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
				<br>
			</div>
		<div id="conteudo_d"></div>
		<div id="footer">
			<a href="default.aspx">Home</a>&nbsp;|&nbsp;
			<a href="empresa.htm">Empresa</a>&nbsp;|&nbsp;
			<a href="servicos.htm">Serviços</a>&nbsp;|&nbsp;
			<a href="contato.aspx">Contato</a>&nbsp;|&nbsp;
			<a href="novoLogin.aspx">Login</a><br>
			© Copyright Atlas Radiodiagnóstico
		</div>
	</div>
	</body>
</html>

