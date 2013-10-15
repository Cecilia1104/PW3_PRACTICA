<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Nuevo.aspx.cs" Inherits="WebApplication1.Nuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>Agregar nuevo libro</h3>
    <asp:Label ID="lbltitulo" runat="server" Text="Titulo:"></asp:Label>
    <asp:TextBox ID="txttitulo" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblprecio" runat="server" Text="Precio:"></asp:Label>
    <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblautor" runat="server" Text="Autor:"></asp:Label>
    <asp:TextBox ID="txtautor" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lbltema" runat="server" Text="Tema"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource2" DataTextField="tema" DataValueField="tema" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cadLibreria %>" 
    SelectCommand="SELECT [tema] FROM [temas]"></asp:SqlDataSource>
    <br /><br />
    <asp:Button ID="btnagregar" runat="server" Text="Agregar" 
        onclick="btnagregar_Click" />
    <br />
     <asp:LinkButton ID="linkactualizar" runat="server" 
        onclick="linkactualizar_Click">Actualice los cambios!!</asp:LinkButton>


</asp:Content>
