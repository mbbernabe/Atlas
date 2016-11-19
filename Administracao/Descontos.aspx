<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Descontos.aspx.vb" Inherits="AtlasRadioDiagnostico.Descontos1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
		<title>Descontos</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<LINK href="css/imaging_admin.css" type="text/css" rel="stylesheet"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<!-- <body MS_POSITIONING="GridLayout"> -->
		<script>
		  function controleRadionButton()
		  {
		    alert("rbtvalor "+document.forms[0].rbValor.cheched);
	  }
		  
		
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
		<div id="nav_extru">Home  &gt; Lançamentos &gt; Lançamento de Descontos</div>
	</div>
	<h2 style="margin-bottom:15px;">Descontos</h2>
	<table cellspacing="0" cellpadding="0" width="700" border="0">
      
      <tr>
        <td width="174" height="25" align="right" class="textoazul"><strong>M&ecirc;s:&nbsp;</strong></td>
        <td width="76" height="25" class="textoazul"><asp:dropdownlist id="ddlmes" runat="server" CssClass="textoazul" Width="124px"></asp:dropdownlist></td>
        <td  height="25" align="right" class="textoazul"><strong>Ano:&nbsp;</strong></td>
        <td width="297" height="25"><asp:textbox id="txtAno" runat="server" CssClass="textoazul" Width="35px"></asp:textbox>
            <asp:requiredfieldvalidator id="rfvAno" runat="server" CssClass="textoalerta" ControlToValidate="txtAno" ErrorMessage="O Ano &eacute; obrigat&oacute;rio."
										DESIGNTIMEDRAGDROP="132"></asp:requiredfieldvalidator></td>
      </tr>
      <tr>
        <td height="25" align="right" nowrap class="textoazul"><strong>Natureza do 
          desc.:&nbsp;</strong></td>
        <td class="textoazul" height="25"><asp:dropdownlist id=ddlNatDesconto 
                runat="server" CssClass="textoazul" Width="230px" AutoPostBack="True" 
                DataMember="NATUREZADESCONTO" DataValueField="CODNATDESC" 
                DataTextField="DSCNATDESC"></asp:dropdownlist></td>
        <td width="153" height="25" align="right" nowrap class="textoazul"><strong>Tipo de desc.:&nbsp;</strong></td>
        <td class="textoazul" height="25" style="padding-top:15px;"><div style="float:left;">
            <asp:dropdownlist id=ddlTipoDesconto runat="server" CssClass="textoazul" 
                Width="199px" AutoPostBack="True" DataMember="TIPODESCONTO" 
                DataValueField="CODTPDESCONTO" DataTextField="NOMTPDESCONTO"></asp:dropdownlist></div>
           <div style="width:200px; float:right;">
             <asp:RequiredFieldValidator ID="rfvTipoDesconto" runat="server" CssClass="textoalerta" ControlToValidate="ddlTipoDesconto"
										ErrorMessage="O Tipo de Desconto &eacute; Obrigat&oacute;rio."></asp:RequiredFieldValidator>
           </div></td>
      </tr>
	        <tr>
        <td class="textoazul" align="center" colspan="4">&nbsp;</td>
      </tr>
	  <tr>
			<td colspan="4" height="1" bgcolor="#FFE6BF"></td>
		</tr>
      <tr>
        <td class="textoazul" align="center" colspan="4">&nbsp;</td>
      </tr>
      <tr>
        <td class="textoazul" align="center" colspan="2"><asp:radiobutton id="rbValor" runat="server" AutoPostBack="True" Text="Valor" GroupName="PercentValor"
										Checked="True" Enabled="True"></asp:radiobutton>
          &nbsp;&nbsp;
          <asp:textbox id="txtValor" runat="server" Width="94px"></asp:textbox></td>
        <td class="textoazul" align="center" colspan="2"><asp:radiobutton id="rbPercentual" runat="server" AutoPostBack="True" Text="Percentual" GroupName="PercentValor"></asp:radiobutton>
          &nbsp;&nbsp;
          <asp:textbox id="txtPercentual" runat="server" Width="75px"></asp:textbox></td>
      </tr>
      <tr>
        <td class="textoalerta" align="center" colspan="2"><asp:customvalidator id="cvValor" runat="server" ControlToValidate="txtValor" ErrorMessage="O valor &eacute; obrigat&oacute;rio e deve ser um n&uacute;mero."></asp:customvalidator></td>
        <td class="textoalerta" align="center" colspan="2"><asp:customvalidator id="cvPercentual" runat="server" ErrorMessage="O percentual &eacute; obrigat&oacute;rio e deve ser um valor n&uacute;mero."></asp:customvalidator></td>
      </tr>
      <tr>
        <td class="textoazul" vAlign="middle" align="center" colSpan="2"><TABLE id="Table7" cellSpacing="0" cellPadding="0" width="250" border="0">
            <TR align="center">
              <TD class="textoazul"><asp:radiobutton id="rbRatear" runat="server" Text="Dividir o Valor" GroupName="grprateio" Checked="True"></asp:radiobutton></TD>
              <TD class="textoazul"><asp:radiobutton id="rbPropagar" runat="server" Text="Propagar o Valor" GroupName="grprateio"></asp:radiobutton></TD>
            </TR>
        </TABLE></td>
        <td class="textoazul" align="center" colspan="2"><TABLE id="Table2" cellspacing="0" cellPadding="0" width="300" border="0">
            <TR>
              <TD class="textoazul"><asp:radiobutton id="rbFatBruto" runat="server" Text="Fat. Bruto" GroupName="IncDesconto" Enabled="False"
													Checked="True"></asp:radiobutton></TD>
              <TD class="textoazul"><asp:radiobutton id="rbFatIRRF" runat="server" Text="Fat. - IRRF" GroupName="IncDesconto" Enabled="False"></asp:radiobutton></TD>
              <TD class="textoazul"><asp:radiobutton id="rbFatImpostos" runat="server" Text="Fat. - Impostos" GroupName="IncDesconto"
													Enabled="False"></asp:radiobutton></TD>
            </TR>
        </TABLE></td>
      </tr>
      <tr>
        <td class="textoazul"  valign="middle" align="center" colspan="2">&nbsp;</td>
        <td class="textoazul" align="center" colspan="2">&nbsp;</td>
      </tr>
	  <tr>
			<td colspan="4" height="1" bgcolor="#FFE6BF"></td>
		</tr>
      <tr>
        <td vAlign="middle" align="center" colspan="4" height="40"><asp:button id="btnPadrao" runat="server" Text="Padr&atilde;o" Width="120px"></asp:button>
          &nbsp;&nbsp;
          <asp:button id="btnGerarDescontos" runat="server"  Text="Gerar Descontos"  Width="120px"></asp:button>
          &nbsp;&nbsp;
          <asp:button id="btnValDiferentes" runat="server" Text="Valores Diferentes" Width="120px"></asp:button>
          &nbsp;&nbsp;
          <asp:button id="btnVoltar" runat="server"  Text="Voltar" Width="120px"></asp:button></td>
      </tr>
    </table>
	<h2>Sócios</h2>
	
	<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="700" border="0">
	<tr>
			<td colSpan="3" height="15"></td>
		</tr>
      
      <TR>
        <TD class="textoazul" width="220"><strong>Dispon&iacute;veis&nbsp;</strong></TD>
        <TD class="textoazul" width="60">&nbsp;</TD>
        <TD class="textoazul" width="354" colSpan="2"><strong>Selecionados&nbsp;</strong></TD>
      </TR>
      <TR>
        <TD class="textoazul" vAlign="top"><asp:listbox id="lsNaoInc" runat="server" CssClass="textoazul" Width="321px" SelectionMode="Multiple"
										Height="221"></asp:listbox></TD>
        <TD width="60" align="center" valign="top" class="textoazul" style="padding-top:15px;">
		<asp:button id="btnVaiTodos" runat="server"  Width="47px" CssClass="botao_2r" Height="32px"></asp:button>
        <br /><br />
        <asp:button id="btnVoltaTodo" runat="server" Width="47px" CssClass="botao_2l" Height="32px"></asp:button>
        <br /><br />
        <asp:button id="btnVaiUm" runat="server" width="47" cssclass="botao_1r" Height="32"></asp:button>
        <br /><br />
        <asp:button id="btnVoltaUm" runat="server" width="47px" CssClass="botao_1l" Height="32px"></asp:button></TD>
        <TD class="textoazul" vAlign="top" colspan="2"><asp:listbox id="lsInc" runat="server" CssClass="textoazul" Width="321px" SelectionMode="Multiple"
										Height="221px"></asp:listbox></TD>
      </TR>
    </TABLE>
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
