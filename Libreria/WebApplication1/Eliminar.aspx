<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="WebApplication1.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>Eliminar libro</h3>
    <asp:Label ID="lbleliminar" runat="server" Text="Seleccione el libro:"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
    </asp:DropDownList>
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cadLibreria %>" 
        SelectCommand="SELECT [titulo] FROM [libros]"></asp:SqlDataSource>
   
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    <br />
     <asp:LinkButton ID="linkactualizar" runat="server" 
        onclick="linkactualizar_Click">Actualice los cambios!!</asp:LinkButton>
</asp:Content>
