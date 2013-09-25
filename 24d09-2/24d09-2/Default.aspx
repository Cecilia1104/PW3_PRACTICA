<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="_24d09_2._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource1">
    </asp:DropDownList>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    <asp:Button ID="Button1" runat="server" Text="Button" 
    onclick="Button1_Click" />


</asp:Content>
