<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Temas.aspx.cs" Inherits="WebApplication1.Temas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="lsttemas" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="tema" DataValueField="tema" 
        onselectedindexchanged="lsttemas_SelectedIndexChanged" >
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cadLibreria %>" 
        SelectCommand="SELECT [tema] FROM [temas]"></asp:SqlDataSource>
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Ver Productos</asp:LinkButton>
</asp:Content>
