<%@ Page Title="Acerca de nosotros" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="WebApplication3.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContenidoPrincipal">
    <h2>
         Bienvenido, estos son sus datos:
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </p>
	<asp:Button ID="Button1" runat="server" Text="Volver al formulario" onclick="Button1_Click" />
</asp:Content>
