<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Actualizacion.aspx.cs" Inherits="WebApplication1.Actualizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>Actualizar datos de un libro</h3>
    <asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
    <asp:TextBox ID="txtcodigo" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblprecio" runat="server" Text="Precio"></asp:Label>
    <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnactualizar" runat="server" Text="Actualizar" 
        onclick="btnactualizar_Click" />
    <asp:Label ID="lblactualizado" runat="server" Text=""></asp:Label>
</asp:Content>
