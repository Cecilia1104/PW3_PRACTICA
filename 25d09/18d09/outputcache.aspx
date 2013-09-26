<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="outputcache.aspx.cs" Inherits="_18d09.outputcache" %>
<%@ OutputCache Duration="20" VaryByParam="Parametro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <a href="outputcache.aspx?Parametro=1">Link 1</a>
    <br />
    <a href="outputcache.aspx?Parametro=2">Link 2</a>
    <br />
    <a href="outputcache.aspx?Parametro=3">Link 3</a>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Substitution ID="sc" runat="server" MethodName="SinCache" />
</asp:Content>
