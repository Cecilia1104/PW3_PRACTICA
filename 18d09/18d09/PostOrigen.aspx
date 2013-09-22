<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="PostOrigen.aspx.cs" Inherits="_18d09._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
        <asp:TextBox ID="txtpost" runat="server"></asp:TextBox>
        <asp:Button PostBackUrl="~/PostDestino.aspx" runat="server" Text="Enviar" 
            onclick="Unnamed1_Click"/>
  
   
  
</asp:Content>
