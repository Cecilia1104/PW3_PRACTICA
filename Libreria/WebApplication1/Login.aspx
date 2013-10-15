<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>Login</h3>
    <asp:Label ID="lblusuario" runat="server" Text="Usuario"></asp:Label>
    <br />
    <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="lblcontraseña" runat="server" Text="Contraseña"></asp:Label>
    <br />
    <asp:TextBox ID="txtcontraseña" runat="server" TextMode="Password"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btningresar" runat="server" Text="Ingresar" 
        onclick="btningresar_Click" />
   <br />
   <a href="Registro.aspx">Registrese aqui</a>
    <asp:Label ID="lblresultados" runat="server" Text=""></asp:Label>
</asp:Content>
