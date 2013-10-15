<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="WebApplication1.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblseleccionar" runat="server" Text="Seleccionar titulo:"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
        DataSourceID="SqlDataSource1" DataTextField="titulo" DataValueField="titulo">
    </asp:DropDownList>
 
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cadLibreria %>" 
        SelectCommand="SELECT [titulo] FROM [libros]"></asp:SqlDataSource>
 
    <br />
    <asp:Button ID="btndatos" runat="server" Text="Ver datos" 
        onclick="btndatos_Click" />
    <br /><br />
    <asp:Label ID="lbltitulo" runat="server" Text="Titulo"></asp:Label>
    <asp:TextBox ID="txttitulo" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblprecio" runat="server" Text="Precio:"></asp:Label>
    <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblautor" runat="server" Text="Autor:"></asp:Label>
    <asp:TextBox ID="txtautor" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="btnmodificar" runat="server" Text="Modificar" 
        onclick="btnmodificar_Click" />
    <br />
     <asp:LinkButton ID="linkactualizar" runat="server" 
        onclick="linkactualizar_Click">Actualice los cambios!!</asp:LinkButton>
</asp:Content>
