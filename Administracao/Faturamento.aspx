<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Faturamento.aspx.vb" Inherits="AtlasRadioDiagnostico.Faturamento1" %>
<%@ Register TagPrefix="uc1" TagName="txtAno" Src="../Controles/txtAno.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cboConfirmação" Src="../Controles/cboConfirmação.ascx" %>
<%@ Register TagPrefix="uc1" TagName="cboMes" Src="../Controles/cboMes.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Faturamento</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
		<link href="css/imaging_admin.css" type="text/css" rel="stylesheet"/>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"/>
		<script language="JavaScript" type="text/JavaScript">
<!--
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
										<div id="nav_extru">Home &gt; Lançamentos &gt; Faturamento</div>
										<div id="print"><a href="javascript:imprimir();"><img src="img/ico_print.gif" alt="Imprimir"></a></div>
									</div>
									<h2>Faturamento</h2>
									<table width="610" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td colspan="3" height="15">
                                                <asp:LinkButton ID="LinkButton1" runat="server" 
                                                    PostBackUrl="~/Administracao/TipoOutrasRemu.aspx">Tipo Outras Remunerações</asp:LinkButton><br />
                                                <asp:LinkButton ID="LinkButton2" runat="server" 
                                                    PostBackUrl="~/Administracao/Lista OutraRemuneracao.aspx">Outras Remunerações</asp:LinkButton>
                                                  <hr />  
                                            </td>
										</tr>
										<tr>
											<td colspan="3"><asp:textbox id="txtData" runat="server" Visible="False" CssClass="textoazul"></asp:textbox></td>
										</tr>
										<tr>
											<td width="105" height="30" align="right" class="textoazul"><strong>Nota Fiscal 
													Nº:&nbsp;</strong></td>
											<td width="339" height="30" class="textoazul"><asp:textbox id="txtNota" runat="server" CssClass="textoazul"></asp:textbox></td>
											<td width="166" height="30" class="textoazul"><asp:CheckBox ID="chkFiltrarNumNota" runat="server" Text="Participar do filtro"></asp:CheckBox></td>
										</tr>
										<tr>
											<td colspan="3" bgcolor="#ffe6bf"></td>
										</tr>
										<tr>
											<td height="30" align="right" class="textoazul"><strong>Cliente:&nbsp;</strong></td>
											<td height="30" class="textoazul"><asp:dropdownlist id="ddlCliente" runat="server" 
                                                    CssClass="textoazul" DataValueField="CODCLIENTE" DataTextField="NOME" 
                                                    Width="300px"></asp:dropdownlist></td>
											<td height="30" class="textoazul"><asp:checkbox id="chkFiltrarCliente" runat="server" Text="Participar do filtro"></asp:checkbox></td>
										</tr>
										<tr>
											<td colspan="3" bgColor="#ffe6bf"></td>
										</tr>
										<tr>
											<td height="30" align="right" class="textoazul"><strong>Mês:&nbsp;</strong></td>
											<td height="30" class="textoazul"><uc1:cbomes id="CboMes1" runat="server" CssClass="textoazul"></uc1:cbomes></td>
											<td height="30" class="textoazul"><asp:checkbox id="chkFiltrarMes" runat="server" 
                                                    Text="Participar do filtro" Checked="True"></asp:checkbox></td>
										</tr>
										<tr>
											<td colspan="3" bgColor="#ffe6bf"></td>
										</tr>
										<tr>
											<td height="30" align="right" class="textoazul"><strong>Ano:&nbsp;</strong></td>
											<td height="30" class="textoazul"><uc1:txtano id="TxtAno1" runat="server" CssClass="textoazul"></uc1:txtano></td>
											<td height="30" class="textoazul"><asp:CheckBox ID="chkFiltrarAno" runat="server" 
                                                    Text="Participar do filtro" Checked="True"></asp:CheckBox></td>
										</tr>
										<tr>
											<td colspan="3" bgcolor="#ffe6bf"></td>
										</tr>
										<tr>
											<td height="30" align="right" class="textoazul"><strong>Confirmação:&nbsp;</strong></td>
											<td height="30" class="textoazul"><uc1:cboconfirmação id="CboConfirmação1" runat="server" CssClass="textoazul"></uc1:cboconfirmação></td>
											<td height="30" class="textoazul"><asp:checkbox id="chkFiltrarCofirmacao" runat="server" Text="Participar do filtro"></asp:checkbox></td>
										</tr>
										<tr>
											<td colspan="3" height="1" bgcolor="#ffe6bf"></td>
										</tr>
										<tr vAlign="bottom" align="center">
											<td height="40"></td>
											<td height="40" align="left"><asp:button id="btnPesquisar" runat="server" Text="Pesquisar"></asp:button>
												&nbsp;&nbsp;
												<asp:button id="bntNovo" runat="server" Text="Novo"></asp:button></td>
											<td height="40">&nbsp;</td>
										</tr>
									</table>
									<h2>Relação de Notas Fiscais</h2>
									<table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td height="35" align="right"><asp:button id="btnExcluirMarcados" runat="server" Text="Excluir"></asp:button>&nbsp;&nbsp;<asp:button id="btnConfCanc" runat="server" Text="Conf./Canc." Width="95px"></asp:button>&nbsp;&nbsp;<asp:button id="btnRecalcularNota" runat="server" Text="Recalcular"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;</td>
										</tr>
									</table>
									<!-- grid -->
									<!-- <selecteditemstyle Font-Bold="True" ForeColor="White" BackColor="#EEEEEE"></selecteditemstyle>
                      <itemstyle ForeColor="#336699" BackColor="#DDDDDD"></itemstyle>
                      <headerstyle Font-Bold="True" ForeColor="White" BackColor="#336699" height="30px"></headerstyle>
                      <footerstyle ForeColor="#336699" BackColor="#DDDDDD" height="30px"></footerstyle> -->
									<!-- grid -->
									<!-- <pagerstyle ForeColor="#DDDDDD" BackColor="#336699" Mode="NumericPages" height="18px"></pagerstyle> -->
									<asp:DataGrid ID="grdFaturamento" runat="server" CssClass="textoazul" 
                                        Width="99%" PageSize="6" AllowPaging="True" AutoGenerateColumns="False" 
                                        DataMember="FATURAMENTO" DataKeyField="CODFATURAMENTO" BorderWidth="0px" 
                                        AlternatingItemStyle-BackColor="#FFFAF2" 
                                        AlternatingItemStyle-CssClass="textoazul">
										<selecteditemstyle Font-Bold="True" HorizontalAlign="Center" ForeColor="White" BackColor="#FFFAF2"></selecteditemstyle>
										<edititemstyle HorizontalAlign="Center"></edititemstyle>
										<alternatingitemstyle HorizontalAlign="Center" CssClass="textoazul" BackColor="#FFFAF2"></alternatingitemstyle>
										<itemstyle HorizontalAlign="Center" ForeColor="#336699" BackColor="White"></itemstyle>
										<footerstyle ForeColor="#336699" BackColor="#ffffff"></footerstyle>
										<columns>
											<asp:BoundColumn Visible="False" DataField="CODFATURAMENTO" SortExpression="CODFATURAMENTO" ReadOnly="True"
												HeaderText="CODFATURAMENTO"></asp:BoundColumn>
											<asp:TemplateColumn>
												<headerstyle width="30px" height="25px" horizontalAlign="Center" Font-Bold="true" ForeColor="#FFFFFF"
													backcolor="#FEA723"></headerstyle>
												<itemstyle></itemstyle>
												<itemtemplate>
													<asp:CheckBox ID="chkSelecao" runat="server" h></asp:CheckBox>
												</itemtemplate>
											</asp:TemplateColumn>
											<asp:HyperLinkColumn DataNavigateUrlField="CODFATURAMENTO" DataNavigateUrlFormatString="DetFat.aspx?cod={0}"
												DataTextField="NUMNF" sortexpression="NUMNF" headertext="Nota Fiscal">
												<headerstyle CssClass="header_tbl"></headerstyle>
												<itemstyle></itemstyle>
											</asp:HyperLinkColumn>
											<asp:BoundColumn DataField="DTFATURAMENTO" SortExpression="DTFATURAMENTO" ReadOnly="True" HeaderText="Data"
												DataFormatString="{0:dd/MM/yyyy}">
												<headerstyle CssClass="header_tbl"></headerstyle>
												<itemstyle></itemstyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="VALORFATURAMENTOBRUTO" SortExpression="VALORFATURAMENTOBRUTO" ReadOnly="True"
												HeaderText="Valor" DataFormatString="{0:N2}">
												<headerstyle CssClass="header_tbl"></headerstyle>
												<itemstyle></itemstyle>
											</asp:BoundColumn>
											<asp:ButtonColumn Text="Excluir" HeaderText="&#160;&#160;Excluir&#160;&#160;" CommandName="Delete">
												<headerstyle CssClass="header_tbl"></headerstyle>
												<ItemStyle HorizontalAlign="Center" Font-Bold="true" ForeColor="#990000" Font-Size="11px"></ItemStyle>
											</asp:ButtonColumn>
											<asp:TemplateColumn HeaderText="OK">
												<headerstyle CssClass="header_tbl"></headerstyle>
												<itemtemplate>
													<table id="Table9" style="HEIGHT: 24px" cellspacing="1" cellpadding="1" width="100%" border="0">
														<tr>
															<td align="middle">
																<asp:Image ID="Image2" runat="server" Width="16px" Height="16px"></asp:Image></td>
														</tr>
													</table>
												</itemtemplate>
											</asp:TemplateColumn>
											<asp:ButtonColumn Text="Confirmar/Cancelar" HeaderText="Confirmar/Cancelar" CommandName="Confirmar">
												<headerstyle CssClass="header_tbl"></headerstyle>
												<ItemStyle HorizontalAlign="Center" Font-Bold="true" ForeColor="#1CAC13" Font-Size="11px"></ItemStyle>
											</asp:ButtonColumn>
											<asp:BoundColumn Visible="False" DataField="AUDITADO" SortExpression="AUDITADO" HeaderText="AUDITADO"></asp:BoundColumn>
										</columns>
										<PagerStyle Position="Bottom" Height="30px" Mode="NumericPages" ForeColor="#618CB4" BackColor="#FFFFFF"></PagerStyle>
									</asp:DataGrid>
									<asp:Label Font-Bold="true" BackColor="#618CB4" ForeColor="#FFFFFF" HorizontalAlign="Center"
										BorderWidth="3px" BorderColor="#618CB4" id="lblPaginaCorrente" runat="server" /></TD></TR></TABLE>
								</div>
								<div class="clear"></div>
								<br>
							</div>
							<!--Final conteúdo-->
						</div>
					</div>
				</div>
			</div>
			<!--Final Casca Branca-->
			<DIV></DIV>
		</form>
		<br>
		<br>
	</body>
</html>
