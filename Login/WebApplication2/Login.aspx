<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
<h2>Login de usuario:</h2><br />
    <asp:Label ID="lblusuario" runat="server" Text="Nombre de usuario:"></asp:Label>
    <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo obligatorio" ControlToValidate="txtusuario"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="lblpass" runat="server" Text="Ingrese su password"></asp:Label>
    <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo obligatorio" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
    <br /><br />

    <asp:Button ID="btningresar" runat="server" Text="Ingresar" 
        onclick="btningresar_Click" />
        <br />
    <asp:Label ID="Label1" runat="server" Text="Remember me?"></asp:Label>
    <asp:CheckBox ID="Persist" runat="server" />
    <br />
    <asp:Button ID="btnborrar" runat="server" Text="Borrar" 
        onclick="btnborrar_Click" />
    <asp:Label ID="lblconfirmar" runat="server" Text=""></asp:Label>
</asp:Content>
