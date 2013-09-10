<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="_04d09.Formulario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="Stylesheet" href="StyleSheet1.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="form">
    <h2>FORMULARIO:</h2>
    <div id="contenedor">
         Ejercicio 1: Validar:
         Dato obligario: Nombre -
         Formato Correcto: Direccion de mail
    </div>
    <%--Ingresar nombre--%>
        <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Campo Obligatorior" ControlToValidate="txtnombre">Campo Obligatorio</asp:RequiredFieldValidator>
        <br />
    <%--Ingresar correo electronico--%>
        <asp:Label ID="lblmail" runat="server" Text="Correo"></asp:Label>
        <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
         ErrorMessage="Formato Incorrecto" ControlToValidate="txtmail" Display="Dynamic"
         ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
         <br />

         <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_click" />
    </div>
    <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
