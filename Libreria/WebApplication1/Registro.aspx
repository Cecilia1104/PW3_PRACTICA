<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebApplication1.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>Registro de usuarios</h3>
    <asp:Label ID="lblnombre" runat="server" Text="Nombre usuario:"></asp:Label>
    <br />
    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="lblcontraseña" runat="server" Text="Contraseña:"></asp:Label>
    <br />
    <asp:TextBox ID="txtcontraseña" runat="server" TextMode="Password"></asp:TextBox>
    <br /><br />
    <asp:Label ID="lblcorreo" runat="server" Text="Correo electronico:"></asp:Label>
    <br />
    <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="lbltelefono" runat="server" Text="Telefono"></asp:Label>
    <br />
    <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnaceptar" runat="server" Text="Registrar" 
        onclick="btnaceptar_Click" />
    <asp:Label ID="lblresultado" runat="server" Text=""></asp:Label>
    <br />
    <a href="Login.aspx">Ir al login</a>
</asp:Content>
