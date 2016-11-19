<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="nav.aspx.vb" Inherits="AtlasRadioDiagnostico.nav1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

	<head>
		<title>nav</title>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache"/>
		<META HTTP-EQUIV="Expires" CONTENT="-1"/>
		<META HTTP-EQUIV="Cache-control" CONTENT="no-store"/>
		<link href="css/imaging_admin.css" rel="stylesheet" type="text/css"/>
	</head>
<body >
<div id="wrap">
<div  style="width: 96%; text-align:left; padding-right:10px;">
<div id="topo">

<div style="float:left; background-color:#FFFFFF; margin-top:10; margin-bottom:18px; margin-left:10px;" >
		<h1>&nbsp;</h1>
</div>

<div id="navegacao">
	<ul>
		<li style="border-right:1px solid #FFFFFF;"><a href="#" class="tit">Lançamentos</a> 
			<ul>
				<li><a href="Faturamento.aspx" target="main">Faturamento</a></li>
				<li><a href="ListaDescontos.aspx" target="main">Descontos</a></li>
				<!--<li><a href="listaDespesa.aspx" target="main">Despesas</a></li>-->
				<li><a href="../Manutencao.aspx" target="main">Despesas</a></li>
			</ul>		
		</li>
		<li style="border-right:1px solid #FFFFFF;"><a href="#" class="tit">Descontos</a>
			<ul>
				<li><a href="TipoDesconto.aspx" target="main">Tipo Desconto</a></li>
				<li><a href="NaturezaDesconto.aspx" target="main">Nat. Desconto</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
			</ul>					
		</li>
		<li style="border-right:1px solid #FFFFFF;"><a href="#" class="tit">Despesas</a>
			<ul>
			<!--	<li><a href="TipoDespesa.aspx" target="main">Tipo Despesa</a></li> -->
				<li><a href="../Manutencao.aspx" target="main">Tipo Despesa</a></li>				
				<!--<li><a href="NaturezaDespesa.aspx" target="main">Nat. Despesa</a></li>-->
				<li><a href="../Manutencao.aspx" target="main">Nat. Despesa</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
			</ul>
		</li>
		<li style="border-right:1px solid #FFFFFF;"><a href="#" class="tit">Cadastro</a>
			<ul>
				<li><a href="listaClientes.aspx" target="main">Clientes</a></li>
				<li><a href="listasocio.aspx" target="main">Sócios</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
			</ul>
		</li>
		<li style="border-right:1px solid #FFFFFF;"><a href="#" target="main" class="tit">Extrato</a>
			<ul>
				<li><a href="extratomensal.aspx" target="main">Extrato Mensal</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
			</ul>
		</li>
		<li><a href="#" class="tit">Sair</a>
			<ul>
				<li><a href="../DesejaSair.aspx" target="_top" >Encerrar Seção</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
				<li><a href="#" class="blank" target="main">&nbsp;</a></li>
			</ul>

		</li>
	</ul>
</div>
<br/><br/><br/><br/><br/><br/><br/><br/>
</div>
</div>
</div>
</body>
</html>