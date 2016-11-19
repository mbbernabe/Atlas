<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="txtAno.ascx.vb" Inherits="AtlasRadioDiagnostico.txtAno1" %>
<asp:TextBox id="Text1" runat="server" Width="87px" MaxLength="4"></asp:TextBox>
<asp:RegularExpressionValidator id="revNumeros" runat="server" ErrorMessage="Digite o ano com 4 digitos. Ex. 2003" ControlToValidate="Text1" ValidationExpression="\d{4}"></asp:RegularExpressionValidator>
