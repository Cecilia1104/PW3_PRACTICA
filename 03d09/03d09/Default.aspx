<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="_03d09._Default" %>
<%@ MasterType VirtualPath="~/MasterPage.Master" %> <%--Inclusion necesaria para crear relacion entre content page y master page,o sea, que una Content Page puede crear una referencia a la Master Page mediante esta directiva--%>

<asp:Content ID="Encabezado" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
  <p style="color:Fuchsia; font-size: 209x;">
    Es el encabezado
  </p>
</asp:Content>

<asp:Content ID="Body" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <p>
       Es el cuerpo del sitio.
    </p>
</asp:Content>

<asp:Content ID="Pie" runat="server" ContentPlaceHolderID="pie">
   <p>
    Es el pie de pagina.
   </p>
</asp:Content>
