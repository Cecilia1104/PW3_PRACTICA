<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Cookies.aspx.cs" Inherits="_18d09.Cookies" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblValorCookie1" runat="server" Text="Label"></asp:Label><br />
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar en Cookie" 
        onclick="btnGuardar_Click" />
    <asp:Button
        ID="btnLeer" runat="server" Text="Leer Cookie" onclick="btnLeer_Click"/>
</asp:Content>
