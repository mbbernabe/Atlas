<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DescontosValDif.aspx.vb" Inherits="AtlasRadioDiagnostico.DescontosValoresDiferentes" %>
<%@ Register TagPrefix="uc1" TagName="cboMes" Src="../Controles/cboMes.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
		<title>Desconto2</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR"/>
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE"/>
		<meta content="JavaScript" name="vs_defaultClientScript"/>
		<link href="../css/imaging.css" type="text/css" rel="stylesheet"/>
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
</head>
	<body class="padleft40 padtop20" bgColor="#d0ebf3" leftMargin="0" topMargin="0" marginwidth="0"
		marginheight="0">
		<form id="Form1" method="post" runat="server">
			<table id="Table3" cellSpacing="0" cellPadding="0" width="700" align="center" bgColor="#ffffff"
				border="0">
				<tr height="10">
					<td width="11"><IMG height="10" src="../imagens/left_top.gif" width="11"></td>
					<td></td>
					<td width="11"><IMG height="10" src="../imagens/right_top.gif" width="11"></td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td vAlign="top">
						<table cellSpacing="0" cellPadding="0" width="700" border="0">
							<tr>
								<td height="20">&nbsp;</td>
							</tr>
							<tr>
								<td class="textoazul" vAlign="top" height="30">home &gt; Lançamentos &gt; Descontos</td>
							</tr>
							<tr>
								<td class="textoazul_grande" height="20">Descontos</td>
							</tr>
							<tr>
								<td bgColor="#d0ebf3" height="4"></td>
							</tr>
						</table>
						<table cellSpacing="0" cellPadding="0" width="700" border="0">
							<tr>
								<td colSpan="4">&nbsp;</td>
							</tr>
							<tr>
								<td class="textoazul" style="HEIGHT: 25px" align="right" width="150" height="25">Mês:&nbsp;</td>
								<td class="textoazul" style="HEIGHT: 25px" height="25"><uc1:cbomes id="CboMes1" CssClass="textoazul" runat="server"></uc1:cbomes></td>
								<td class="textoazul" style="HEIGHT: 25px" align="right" width="150" height="25">Ano:&nbsp;</td>
								<td style="HEIGHT: 25px" height="25"><asp:textbox id="txtAno" runat="server" CssClass="textoazul" Width="35px"></asp:textbox><asp:requiredfieldvalidator id="rfvAno" runat="server" CssClass="textoalerta" ControlToValidate="txtAno" ErrorMessage="O Ano é obrigatório."
										DESIGNTIMEDRAGDROP="132"></asp:requiredfieldvalidator></td>
							</tr>
							<tr>
								<td class="textoazul" align="right" width="150" height="25">Natureza do 
									desconto:&nbsp;</td>
								<td class="textoazul" height="25"><asp:dropdownlist id=ddlNatDesconto 
                                        runat="server" CssClass="textoazul" Width="230px" AutoPostBack="True" 
                                        DataMember="NATUREZADESCONTO" DataValueField="CODNATDESC" 
                                        DataTextField="DSCNATDESC"></asp:dropdownlist></td>
								<td class="textoazul" align="right" width="150" height="25">Tipo de desconto:&nbsp;</td>
								<td class="textoazul" vAlign="bottom" height="25">
                                    <asp:dropdownlist id=ddlTipoDesconto runat="server" CssClass="textoazul" 
                                        Width="199px" AutoPostBack="True" DataMember="TIPODESCONTO" 
                                        DataValueField="CODTPDESCONTO" DataTextField="NOMTPDESCONTO"></asp:dropdownlist><asp:requiredfieldvalidator id="rfvTipoDesconto" runat="server" CssClass="textoalerta" ControlToValidate="ddlTipoDesconto"
										ErrorMessage="O Tipo de Desconto é Obrigatório."></asp:requiredfieldvalidator></td>
							</tr>
							<tr>
								<td class="textoazul" align="center" colSpan="4">&nbsp;
									<asp:button id="btnGerarDescontos" runat="server" CssClass="botao_verde_gra" Text="Gerar Descontos"></asp:button>&nbsp;&nbsp;
									<asp:button id="btnVoltar" runat="server" CssClass="botao_azul" Text="Voltar"></asp:button>
								</td>
							</tr>
							<tr>
								<td class="textoazul" align="center" colSpan="2">&nbsp;&nbsp;</td>
								<td class="textoazul" align="center" colSpan="2">&nbsp;&nbsp;</td>
							</tr>
							<tr>
								<td class="textoalerta" align="center" colSpan="2"></td>
								<td class="textoalerta" align="center" colSpan="2"></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
					</td>
					<td>
						<asp:datagrid  Width="700px" BackColor="#DDDDDD" AllowPaging="True" 
                            AutoGenerateColumns="False" BorderColor="White" BorderWidth="0px" 
                            ForeColor="#336699" CellPadding="1" GridLines="Horizontal" 
                            AlternatingItemStyle-BackColor="#E9E9E9" 
                            AlternatingItemStyle-CssClass="textoazul"  PageSize="20" id=grd runat="server" 
                            CssClass="textoazul" DataMember="SOCIO"  DataKeyField="CODSOCIO">
							<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#EEEEEE"></SelectedItemStyle>
							<AlternatingItemStyle CssClass="textoazul" BackColor="#E9E9E9"></AlternatingItemStyle>
							<ItemStyle ForeColor="#336699" BackColor="White"></ItemStyle>
							<FooterStyle Height="30px" ForeColor="#336699" BackColor="#DDDDDD"></FooterStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="CODSOCIO" SortExpression="CODSOCIO" HeaderText="CODSOCIO"></asp:BoundColumn>
								<asp:BoundColumn DataField="NOME" SortExpression="NOME" HeaderText="S&#243;cio">
									<HeaderStyle Height="70%" CssClass="textoazul_pad10" BackColor="#E9E9E9"></HeaderStyle>
								</asp:BoundColumn>
								<asp:TemplateColumn HeaderText="Valor Desconto">
									<HeaderStyle Height="30%" CssClass="textoazul_pad10" BackColor="#E9E9E9"></HeaderStyle>
									<ItemTemplate>
										<asp:TextBox id="TextBox1" runat="server" Width="202px"></asp:TextBox>
									</ItemTemplate>
								</asp:TemplateColumn>
							</Columns>
						</asp:datagrid>
					</td>
				</tr>
			</table>
			<P></P>
		</form>
	</body>
</html>
