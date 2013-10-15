<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplication1.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h3>Panel de control</h3>
     <asp:Label ID="Welcome" runat="server" />
     <br />
    <a href="Nuevo.aspx">Añadir libro</a>
    <br />
    <a href="Eliminar.aspx">Eliminar libro</a>
    <br />
    <a href="Modificar.aspx">Modificar libro</a>
    <br />
    <a href="Actualizacion.aspx">Actualizar libro - Primera implementacion</a>
    <br />
    <a href="Temas.aspx">Listado de libros por tema</a>
   <br /><br />
   <asp:Button ID="Submit1" OnClick="Signout_Click" 
       Text="Sign Out" runat="server" />

</asp:Content>
