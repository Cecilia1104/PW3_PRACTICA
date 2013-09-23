<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="_17d09._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        ASP.NET
    </h2>
   
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /><br />

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
</asp:Content>
