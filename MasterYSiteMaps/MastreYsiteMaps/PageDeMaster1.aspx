<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageDeMaster1.aspx.cs" Inherits="MastreYsiteMaps.PageDeMaster1" MasterPageFile="~/MasterPage1.Master"%>
<%@ MasterType VirtualPath="~/MasterPage1.Master"%> <%--inclusion necesaria para crear relacion entre content page y master para poder acceder a sus propiedades en CodeFile: MasterPage.cs--%>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="Content2" runat="server">
    <p style="color:Fuchsia; font-size:20px;">es el encabezado...</p>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" ID="body" runat="server">
    es el cuerpo...
</asp:Content>
<asp:Content ContentPlaceHolderID="pie" ID="Content1" runat="server">
    es el pie..
</asp:Content>
