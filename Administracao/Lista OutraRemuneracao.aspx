<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Lista OutraRemuneracao.aspx.vb" Inherits="AtlasRadioDiagnostico.Lista_OutraRemuneracao" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
 	<title>Lista de Outras Remuneracões</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
		<link href="css/imaging_admin.css" type="text/css" rel="stylesheet"/>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
		<meta http-equiv="Pragma" content="no-cache"/>
		<meta http-equiv="Expires" content="-1"/>
		<meta http-equiv="Cache-control" content="no-store"/>
		<script language="JavaScript" type="text/JavaScript">
<!--

function checkdeltodos(field)

{

		var i;

		var todos;
		var Ehfiltro;
		todos = true;

		for (i = 0; i < field.length; i++)
		{ 
			Ehfiltro = false;
			Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarTpOutraRemuneracao"));
			Ehfiltro = (Ehfiltro || (field[i].name == "chkfiltrarSocio"));
			Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarAno"));
			Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarMes"));
			if (!Ehfiltro)
			{
				if ((field.list.name != field[i].name) && (field[i].type == 'checkbox'))
					todos = (todos && field[i].checked);
			}
		}

		field.list.checked = todos

}



function md(field)

{

checado=document.forms[0].list.checked == true;

		if (!checado) 
			{

				var i;

				for (i = 0; i < field.length; i++) 
					{
					Ehfiltro = false;
					Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarTpOutraRemuneracao"));
					Ehfiltro = (Ehfiltro || (field[i].name == "chkfiltrarSocio"));
					Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarAno"));
					Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarMes"));
					if (!Ehfiltro)
						{
						field[i].checked = false;
						}
					}
			}
		else 
			{

				var i;

				for (i = 0; i < field.length; i++) 
					{
					Ehfiltro = false;
					Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarTpOutraRemuneracao"));
					Ehfiltro = (Ehfiltro || (field[i].name == "chkfiltrarSocio"));
					Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarAno"));
					Ehfiltro = (Ehfiltro || (field[i].name == "chkFiltrarMes"));
					if (!Ehfiltro)
						{
						field[i].checked = true;
						}
					}
			}
}

function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);


function imprimir(){  
    window.print();
}

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
		<div id="nav_extru">Home &gt; Lançamentos &gt; Faturmento &gt; Outras Remuneracões</div>
		<div id="print"><a href="javascript:imprimir();"><img src="img/ico_print.gif" alt="Imprimir"></a></div>
	</div>
	<h2>Outras Remunerações</h2>
	<table cellspacing="0" cellpadding="0" width="700" border="0">
							<tr>
								<td colspan="3">&nbsp;</td>
							</tr>
							<tr>
								<td width="107" height="30" align="right" class="textoazul"><strong>Mês:&nbsp;</strong></td>
								<td width="354" height="26"><asp:dropdownlist id="ddlmes" runat="server" CssClass="textoazul"></asp:dropdownlist></td>
								<td width="239" height="26" class="textoazul"><asp:CheckBox ID="chkFiltrarMes" 
                                        runat="server" CssClass="textoazul" Text="Participar do Filtro" Checked="True"></asp:CheckBox></td>
							</tr>
							<tr>
								<td colspan="3" bgColor="#FFE6BF"></td>
							</tr>
							<tr>
								<td height="30" align="right" class="textoazul"><strong>Ano:&nbsp;</strong></td>
								<td height="26">
                                    <asp:TextBox ID="txtAno" runat="server" Width="79px"></asp:TextBox>
                                </td>
								<td height="26" class="textoazul"><asp:checkbox id="chkFiltrarAno" runat="server" 
                                        CssClass="textoazul" Text="Participar do Filtro" Checked="True"></asp:checkbox></td>
							</tr>
							<tr>
								<td colspan="3" bgColor="#FFE6BF"></td>
							</tr>
							<tr>
								<td height="30" align="right" class="textoazul"><strong>Sócio:&nbsp;</strong></td>
								<td height="26"><asp:dropdownlist id=ddlSocio runat="server" CssClass="textoazul" 
                                        DataMember="SOCIO" DataTextField="NOME" DataValueField="CODSOCIO" Width="335px">
									</asp:dropdownlist></td>
								<td height="26" class="textoazul"><asp:checkbox id="chkfiltrarSocio" runat="server" CssClass="textoazul" Text="Participar do Filtro"></asp:checkbox></td>
							</tr>
							<tr>
								<td colspan="3" bgcolor="#FFE6BF"></td>
							</tr>
							<tr>
								<td height="30" align="right" class="textoazul"><strong>Tipo&nbsp; Remuneração:&nbsp;</strong></td>
								<td height="26">
                                    <asp:dropdownlist id="ddlTpOutraRemuneracao" runat="server" 
                                        CssClass="textoazul" DataMember="TIPO_REMUNERACAO" DataTextField="DESCTPREMUNERACAO" 
                                        DataValueField="CODTPREMUNERACAO" Width="335px">
									</asp:dropdownlist>
                                    
                                </td>
								<td height="26" class="textoazul"><asp:checkbox id="chkFiltrarTpOutraRemuneracao" 
                                        runat="server" CssClass="textoazul" Text="Participar do Filtro"></asp:checkbox></td>
							</tr>
							<tr>
								<td colspan="3" bgcolor="#FFE6BF"></td>
							</tr>
							<tr>
								<td height="30" align="right" class="textoazul"><strong>Valor:&nbsp;&nbsp; </td>
								<td height="26">
                                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox></td>
								<td height="26" class="textoazul">&nbsp;</td>
							</tr>
							<tr>
								<td colspan="3" bgcolor="#FFE6BF"></td>
							</tr>
							<tr>
								<td height="40" align="right">&nbsp;</td>
								<td><asp:button id="bntAplicarFiltro" runat="server" Text="Pesquisar"></asp:button>&nbsp;&nbsp;<asp:button 
                                        id="btnAdicionarOutraRemuneracao" runat="server" Text="Adicionar"></asp:button>&nbsp;</td>
								<td>&nbsp;</td>
							</tr>
			  </table>
						<h2>Lista de Remunerações</h2>
						<table width="99%" border="0" cellspacing="0" cellpadding="0">
							<tr>
							  <td width="20%" align="right "class="textoazul" ><input type="checkbox" id="list" name="list" value="true" onClick="md(this.form)"/>Selecionar todos</td>
							  <td width="80%" height="35" align="right">
                                  <asp:button id="btnExcluirMarcados" runat="server"  Text="Excluir"></asp:button></td>
							</tr>
			  </table>
						<asp:datagrid id="grd" runat="server" CssClass="textoazul" 
        DataMember="LANCAMENTO_DESCONTOS" Width="99%" BackColor="#DDDDDD" 
        AllowPaging="True" AutoGenerateColumns="False" BorderColor="White" 
        BorderWidth="0px" ForeColor="#336699" CellPadding="1" GridLines="Horizontal" 
        AlternatingItemStyle-BackColor="#FFFAF2" 
        AlternatingItemStyle-CssClass="textoazul" DataKeyField="CODOUTRASREMUNERACOES" 
        PageSize="20">
							<SelectedItemStyle Font-Bold="True"  ForeColor="White" BackColor="#FFFAF2"></SelectedItemStyle>
							<AlternatingItemStyle CssClass="textoazul" BackColor="#FFFAF2"></AlternatingItemStyle>
							<ItemStyle ForeColor="#336699" BackColor="White"></ItemStyle>
							<FooterStyle ForeColor="#336699" BackColor="#ffffff"></FooterStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="CODOUTRASREMUNERACOES" SortExpression="CODOUTRASREMUNERACOES" ReadOnly="True"
									HeaderText="CODOUTRASREMUNERACOES" HeaderStyle-BackColor="#FFFAF2">
<HeaderStyle BackColor="#FFFAF2"></HeaderStyle>
                                </asp:BoundColumn>
								<asp:TemplateColumn><ItemTemplate>
										<asp:CheckBox id="CheckBox1" runat="server" onClick="checkdeltodos(this.form)"></asp:CheckBox>
									
</ItemTemplate>

<HeaderStyle BackColor="#FEA723" Height="25px"></HeaderStyle>

								<HeaderStyle Height="25px" BackColor="#FEA723"></HeaderStyle>
									<ItemTemplate>
										<asp:CheckBox id="CheckBox1" runat="server" onClick="checkdeltodos(this.form)"></asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="CODSOCIO" SortExpression="CODSOCIO" HeaderText="CODSOCIO"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="S&#243;cio">
									<HeaderStyle Height="25px" CssClass="header_tbl" HorizontalAlign="Left"></HeaderStyle>
									<ItemStyle CssClass="textoazul"></ItemStyle>
									<ItemTemplate>
										<asp:Label id="Label2" runat="server"></asp:Label>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:Label id="lblEditNomeSocio" runat="server"></asp:Label>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="CODTPREMUNERACAO" SortExpression="CODTPREMUNERACAO" HeaderText="CODTPREMUNERACAO"></asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Tipo Rem.">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle CssClass="textoazul padleft10" HorizontalAlign="Left" Height="25px"></ItemStyle>
									<ItemTemplate>
										<asp:Label id="lblTpDesconto" runat="server"></asp:Label>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="MES" SortExpression="MES" HeaderText="M&#234;s">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle CssClass="textoazul" HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="ANO" SortExpression="ANO" HeaderText="Ano">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle CssClass="textoazul" HorizontalAlign="Center"></ItemStyle>
								</asp:BoundColumn>
								
							
								<asp:BoundColumn DataField="VALOR" SortExpression="VALOR" HeaderText="Val. Rem."
									DataFormatString="{0:N2}">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle CssClass="textoazul padright10" HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
								
								<asp:ButtonColumn Text="Excluir" HeaderText="Excluir" CommandName="Delete">
									<HeaderStyle CssClass="header_tbl"></HeaderStyle>
									<ItemStyle HorizontalAlign="Center" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></ItemStyle>
								</asp:ButtonColumn>
							
							
							
							
							
							</Columns>
							<PagerStyle Position="Bottom" Height="30px" Mode="NumericPages" ForeColor="#618CB4" BackColor="#FFFFFF"></PagerStyle>
						</asp:datagrid>
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
