<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
       Ejercicio de POO
    </h2>
    <asp:Button ID="Button1" runat="server" Text="Para Estudiantes" onclick="Button1_Click" 
        style="height: 26px" />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
    <br /><br />
    <asp:Button ID="Button2" runat="server" Text="Para Profesores" 
        onclick="Button2_Click" />
    <br />
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
 
</asp:Content>
