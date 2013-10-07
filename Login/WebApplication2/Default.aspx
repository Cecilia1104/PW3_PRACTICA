<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

 <h3> Usuario autentificado:</h3>
     <asp:Label ID="Welcome" runat="server" />
      <asp:Button ID="Submit1" OnClick="Signout_Click" 
       Text="Sign Out" runat="server" />


</asp:Content>
