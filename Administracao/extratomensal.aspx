<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="extratomensal.aspx.vb" Inherits="AtlasRadioDiagnostico.extratomensal" %>

<!DOCTYPE html PUBLIC "-//W3C//Dtd XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/Dtd/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Extrato Mensal</title>
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
										<div id="nav_extru">Home &gt; Relatórios &gt; Extrato Mensal</div>
										<div id="print"><a href="javascript:imprimir();"><img src="img/ico_print.gif" alt="Imprimir"/></a></div>
									</div>
									<h2>Extrato Mensal&nbsp;
										<asp:Label id="lblMesAno" runat="server" Width="56px"></asp:Label></h2>

                                    <div class="textoazul">
                                        <br />
                                            Atlas Serviços de Radioimaginologia Ltda <br />
                                            CNPJ 10.156.114/0001-89
                                        <br />
                                    </div>
									<table id="Table5" cellspacing="0" cellpadding="0" width="100%" border="0">
										<tr>
											<td colspan="3" height="15"></td>
										</tr>
										<tr>
											<td class="textoazul" align="right" width="54"><strong>Sócio:&nbsp;</strong></td>
											<td width="335" height="25" class="textoazul"><asp:dropdownlist id="ddlSocio" runat="server" CssClass="textoazul" Width="327px"  DataMember="SOCIO" DataTextField="NOME" DataValueField="CODSOCIO"></asp:dropdownlist></TD>
											<td valign="top" width="311" colspan="2" rowspan="4">
												<table id="Table4" style="HEIGHT: 75px" cellspacing="1" cellpadding="1" width="100%" border="0">
													<tr>
														<td class="textoazul" align="right" width="151" bgcolor="#fffaf2"><b>Faturamento Bruto:</b>&nbsp;</td>
														<td class="textoazul" width="153">&nbsp;&nbsp;
															<asp:Label ID="lblFatBruto" runat="server" Width="131px"></asp:Label></td>
													</tr>
													<tr>
														<td class="textoazul" align="right" width="151" bgcolor="#fffaf2"><b>IRRF:&nbsp;</b></td>
														<td class="textoazul">&nbsp;&nbsp;
															<asp:label id="lblIRRF" runat="server"></asp:label></td>
													</tr  >
													
													<tr>
														<td class="textoazul" align="right" width="151" bgcolor="#fffaf2"><b>Total a 
																receber:&nbsp;</b></td>
														<td class="textoazul">&nbsp;&nbsp;
															<asp:label id="lblSubSaldoParcial" runat="server"></asp:label></td>
													</tr>
													<tr>
														<td class="textoazul" align="right" width="151" bgcolor="#fffaf2"><b>Impostos:&nbsp;</b></td>
														<td class="textoazul">&nbsp;&nbsp;
															<asp:label id="lblImpostos" runat="server"></asp:label></td>
													</tr>
													<tr>
														<td class="textoazul" align="right" width="151" bgcolor="#fffaf2"><b>Total Fauramento:&nbsp;</b></td>
														<td class="textoazul">&nbsp;&nbsp; <b>
																<asp:label id="lblTotMenosImpostos" runat="server" Width="124px"></asp:label></b></td>
													</tr>
													<tr>
														<td class="textoazul" align="right" width="151"  bgcolor="#fffaf2"><b>Outras Remunerações:&nbsp;</b></td>
														<td class="textoazul">&nbsp;&nbsp;
															<asp:label id="lblOutrasRemuneracoes" runat="server"></asp:label></td>
													</tr>
													<tr>
														<td class="textoazul" align="right" width="151" bgcolor="#fffaf2"><b>Total:&nbsp;</b></td>
														<td class="textoazul">&nbsp;&nbsp; <b>
																<asp:label id="lblTotal" runat="server" Width="124px"></asp:label></b></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td class="textoazul" align="right" width="54"><strong>Mês:&nbsp;</strong></td>
											<td height="25"><asp:dropdownlist id="ddlMes" runat="server" CssClass="textoazul" Width="147px"></asp:dropdownlist></td>
										</tr>
										<tr>
											<td class="textoazul" align="right" width="54"><strong>Ano:&nbsp;</strong></td>
											<td height="25"><asp:textbox id="txtAno" runat="server" CssClass="textoazul" Width="80px"></asp:textbox></td>
										</tr>
										<tr>
											<td></td>
											<td height="40"><asp:button id="btnEnviar" runat="server" Text="Enviar"></asp:button></td>
										</tr>
									</table>
									<h2>Outros Descontos</h2>
									<table id="Table3" cellspacing="0" cellpadding="0" width="100%" border="0">
										<tr>
											<td colspan="4" height="15"></td>
										</tr>
										<tr>
											<td class="textoazul" align="right" width="1">&nbsp;</td>
											<td colspan="2"><asp:repeater id="Repeater1" runat="server">
													<HeaderTemplate>
														<!--	    <table cellSpacing="0" cellPadding="0" width="700" border="0">
													<tr>
														<td class="textoazul_grande" vAlign="bottom" height="40">Outros Descontos</td>
													</tr>
													<tr>
														<td bgColor="#d0ebf3" height="4"></td>
													</tr>
												</table>
									-->
													</HeaderTemplate>
													<ItemTemplate>
														<table width="700px" border="0" cellpadding="0" cellspacing="0">
															<tr>
																<td width="270" height="20" class="textoazul" align="right"><strong>
																		<%# DataBinder.Eval(Container.DataItem, "NaturezaDesconto")%>
																		:</strong>&nbsp;</td>
																<td width="411" height="20" class="textoazul"><%# DataBinder.Eval(Container.DataItem, "Valor")%></td>
															</tr>
															<tr>
																<td colspan="2" height="1" bgcolor="#FFE6BF"></td>
															</tr>
														</table>
													</ItemTemplate>
													<FooterTemplate>
														<!-- <table>
										    <tr>
												<td class="textoazul" align="right">&nbsp;</td>
												<TD class="textoazul" align="right" width="270" bgColor="#dddddd" height="18"><b>Total:&nbsp;</b></TD>
												<td class="textoazul" width="430" height="18">&nbsp;&nbsp; <strong>
														<asp:label id="lblTotOutrosDescontos" runat="server"></asp:label></strong></td>
												<td class="textoazul">&nbsp;</td>
											</tr>
											<tr>
												<td class="textoazul" align="right">&nbsp;</td>
												<TD class="textoazul" align="right" width="270" bgColor="#cccccc" height="18"><b>Total 
														a receber:</b>&nbsp;</TD>
												<td class="textoazul" height="18">&nbsp;&nbsp; <strong>
														<asp:label id="lblTotFinal" runat="server"></asp:label></strong></td>
												<td class="textoazul">&nbsp;</td>
											</tr>
											<tr>
												<td class="textoazul" align="right">&nbsp;</td>
												<TD class="textoazul" align="right" height="18">&nbsp;</TD>
												<td class="textoazul" height="18">&nbsp;</td>
												<td class="textoazul">&nbsp;</td>
											</tr>
										</table>
									-->
													</FooterTemplate>
												</asp:repeater></td>
											<td class="textoazul" width="1" colspan="2">&nbsp;</td>
										</tr>
										<tr>
											<td class="textoazul" align="right">&nbsp;</td>
											<td width="270" height="25" align="right" bgcolor="#fffaf2" class="textoazul"><b>Total:&nbsp;</b></TD>
											<td width="430" height="25" align="left" bgcolor="#fffaf2" class="textoazul">&nbsp;<strong>
													<asp:Label ID="lblTotOutrosDescontos" runat="server"></asp:Label>
												</strong>
											</td>
											<td class="textoazul">&nbsp;</td>
										</tr>
										<tr>
											<td class="textoazul" align="right">&nbsp;</td>
											<td width="270" height="25" align="right" bgcolor="#fffaf2" class="textoazul"><b>Total 
													a receber:</b>&nbsp;</td>
											<td height="25" align="left" bgcolor="#fffaf2" class="textoazul"><strong>&nbsp;
													<asp:label id="lblTotFinal" runat="server"></asp:label></strong></td>
											<td class="textoazul">&nbsp;</td>
										</tr>
										<tr>
											<td class="textoazul" align="right">&nbsp;</td>
											<td class="textoazul" align="right" height="18">&nbsp;</td>
											<td class="textoazul" height="18">&nbsp;</td>
											<td class="textoazul">&nbsp;</td>
										</tr>
									</table>
									<h2>Detalhes do Faturamento</h2>
									<br /> <br/>
									<h3>Faturamento</h3>
									<asp:datagrid id="grd" runat="server" Width="700px"  DataMember="DETALHEFATURAMENTO" AlternatingItemStyle-CssClass="textoazul" BorderWidth="0px" PageSize="1" DataKeyField="CODDETFATURAMENTO" AutoGenerateColumns="False">
										<AlternatingItemStyle CssClass="textoazul"></AlternatingItemStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="CODDETFATURAMENTO" SortExpression="CODDETFATURAMENTO"
												HeaderText="CODDETFATURAMENTO"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="CODFATURAMENTO" SortExpression="CODFATURAMENTO" HeaderText="CODFATURAMENTO"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="CODCLIENTE" SortExpression="CODCLIENTE" HeaderText="CODCLIENTE"></asp:BoundColumn>
											<asp:TemplateColumn>
												<HeaderStyle CssClass="textoazul_grande"></HeaderStyle>
												<ItemTemplate>
													<table cellspacing="0" cellpadding="0" width="700" border="0">
														<tr>
															<td bgcolor="#FFFAF2" height="1"></td>
														</tr>
													</table>
													<table width="700" border="0" id="tb_descontos">
														<tr>
															<th>
																Cliente</th>
															<th>
																Impostos sobre Faturamento</th>
														</tr>
														<tr>
															<td style="padding-left:5px;">
																<b>
																	<asp:Label id="Label1" runat="server" CssClass="textoazul" Width="100%"></asp:Label></b><br />
																<table id="Table11" cellspacing="1" cellpadding="1" width="300" border="0">
																	<tr>
																		<td class="textoazul" align="right" width="160" bgcolor="#FFFAF2">Faturamento 
																			Bruto:&nbsp;</TD>
																		<td>&nbsp;
																			<asp:Label id="Label2" runat="server" CssClass="textoazul"></asp:Label></TD>
																	</tr>
																	<tr>
																		<td class="textoazul" align="right" width="160" bgcolor="#FFFAF2">IRRF :&nbsp;</TD>
																		<td>&nbsp;
																			<asp:Label id="Label3" runat="server" CssClass="textoazul"></asp:Label></TD>
																	</tr>
																	<tr>
																		<td class="textoazul" align="right" width="160" bgcolor="#FFFAF2"><STRONG>Faturamento 
																				Líquido:&nbsp;</STRONG></TD>
																		<td>&nbsp;<B>
																				<asp:Label id="Label4" runat="server" CssClass="textoazul"></asp:Label></B></TD>
																	</tr>
																</table>
															</td>
															<td>
																<asp:DataGrid id="DataGrid1" runat="server" CssClass="textoazul padleft10" Width="100%"  DataMember="LANCAMENTO_DESCONTOS" DataKeyField="CODLANCDESCONTO" AutoGenerateColumns="False">
																	<Columns>
																		<asp:BoundColumn Visible="False" DataField="CODLANCDESCONTO" SortExpression="CODLANCDESCONTO" HeaderText="CODLANCDESCONTO"></asp:BoundColumn>
																		<asp:BoundColumn Visible="False" DataField="CODSOCIO" SortExpression="CODSOCIO" HeaderText="CODSOCIO"></asp:BoundColumn>
																		<asp:BoundColumn Visible="False" DataField="CODDETFATURAMENTO" SortExpression="CODDETFATURAMENTO"
																			HeaderText="CODDETFATURAMENTO"></asp:BoundColumn>
																		<asp:BoundColumn DataField="NOMTPDESCONTO" SortExpression="NOMTPDESCONTO" HeaderText="Tipo de Imposto"
																			HeaderStyle-CssClass="textoazul_pad10" HeaderStyle-BackColor="#FFFAF2"></asp:BoundColumn>
																		<asp:BoundColumn DataField="VALORDESCONTO" SortExpression="VALORDESCONTO" HeaderText="Valor" HeaderStyle-CssClass="textoazul_pad10"
																			HeaderStyle-BackColor="#FFFAF2" DataFormatString="R$ {0:N2}"></asp:BoundColumn>
																	</Columns>
																</asp:DataGrid>
															</td>
														</tr>
													</table>
												</ItemTemplate>
											</asp:TemplateColumn>
										</Columns>
									</asp:datagrid>
									
									
									<h3>Outras Remunerações</h3>
									
									<asp:Repeater id="RepeaterOutrasRemuneracoes" runat="server" 
                                        DataSourceID="SqlDataSource1">
														<HeaderTemplate>
														</HeaderTemplate>
														<ItemTemplate>
															<table width="450px" border="0" cellpadding="1" cellspacing="1">
																<tr>
																	<td width="250" class="textoazul" bgcolor="#FFFAF2" align="right"><%#DataBinder.Eval(Container.DataItem, "DESCTPREMUNERACAO")%>:&nbsp;</td>
																	<td width="200" class="textoazul"><b><%#FormatCurrency(DataBinder.Eval(Container.DataItem, "SOMA_VALOR"))%></b></td>
																</tr>
															</table>
														</ItemTemplate>
														<FooterTemplate>
														</FooterTemplate>
									</asp:Repeater>
									
									
							
									
									
									
						            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:atlasConnectionString %>" 
                                        SelectCommand="SELECT OUTRAS_REMUNERACOES.CODTPREMUNERACAO, TIPO_REMUNERACAO.DESCTPREMUNERACAO, SUM(OUTRAS_REMUNERACOES.VALOR) AS SOMA_VALOR FROM OUTRAS_REMUNERACOES INNER JOIN TIPO_REMUNERACAO ON OUTRAS_REMUNERACOES.CODTPREMUNERACAO = TIPO_REMUNERACAO.CODTPREMUNERACAO WHERE (OUTRAS_REMUNERACOES.MES = @MES) AND (OUTRAS_REMUNERACOES.ANO = @ANO) AND (OUTRAS_REMUNERACOES.CODSOCIO = @CODSOCIO) GROUP BY OUTRAS_REMUNERACOES.CODTPREMUNERACAO, TIPO_REMUNERACAO.DESCTPREMUNERACAO">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ddlMes" Name="MES" 
                                                PropertyName="SelectedValue" />
                                            <asp:ControlParameter ControlID="txtAno" Name="ANO" PropertyName="Text" />
                                            <asp:ControlParameter ControlID="ddlSocio" Name="CODSOCIO" 
                                                PropertyName="SelectedValue" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
									
									
							
									
									
									
						  <h2>Detalhes dos Descontos</h2>		
									
									<asp:datagrid id="grdOutrosDescontos" runat="server" CssClass="textoazul" Width="700px"  DataMember="NATUREZADESCONTO" AlternatingItemStyle-CssClass="textoazul" BorderWidth="0" DataKeyField="CODNATDESC" AutoGenerateColumns="False" Height="67px">
										<Columns>
											<asp:BoundColumn Visible="False" DataField="CODNATDESC" SortExpression="CODNATDESC" HeaderText="CODNATDESC"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="DSCNATDESC" SortExpression="DSCNATDESC" HeaderText="DSCNATDESC"></asp:BoundColumn>
											<asp:TemplateColumn HeaderStyle-BorderWidth="0">
												<ItemTemplate>
													<table width="700" border="0" cellspacing="0" cellpadding="0">
														<tr>
															<td>
																<asp:Label id="lbldscNatDesc" runat="server" Width="100%" CssClass="textoazul"></asp:Label></td>
														</tr>
														<tr>
															<td height="1" bgcolor="#FEA723"></td>
														</tr>
														<tr>
															<td height="4" bgcolor="#ffffff"></td>
														</tr>
													</table>
													<asp:Repeater id="Repeater2" runat="server">
														<HeaderTemplate>
														</HeaderTemplate>
														<ItemTemplate>
															<table width="450px" border="0" cellpadding="1" cellspacing="1">
																<tr>
																	<td width="250" class="textoazul" bgcolor="#FFFAF2" align="right"><%# DataBinder.Eval(Container.DataItem, "TipoDesconto")%>:&nbsp;</td>
																	<td width="200" class="textoazul"><b><%# FormatCurrency(DataBinder.Eval(Container.DataItem, "Valor"))%></b></td>
																</tr>
															</table>
														</ItemTemplate>
														<FooterTemplate>
														</FooterTemplate>
													</asp:Repeater>
													<table width="450px" border="0" cellpadding="1" cellspacing="1">
														<tr>
															<td>&nbsp;</td>
														</tr>
													</table>
												</ItemTemplate>
											</asp:TemplateColumn>
										</Columns>
									</asp:datagrid></td></tr></table>
								</div>
								<div class="clear"></div>
								<br/>
							</div>
							<!--Final conteúdo-->
						</div>
					</div>
				</div>
			</div>
			<!--Final Casca Branca-->
			<DIV></DIV>
		</form>
		<br/>
		<br/>
	</body>
</html>
