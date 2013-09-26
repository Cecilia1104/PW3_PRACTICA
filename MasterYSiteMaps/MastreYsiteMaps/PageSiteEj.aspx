<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageSiteEj.aspx.cs" Inherits="MastreYsiteMaps.PageSiteEj" MasterPageFile="~/MasterPage1.Master"%>

<asp:Content runat="server" ID="cont" ContentPlaceHolderID="ContentPlaceHolder1">
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/PageDeMaster1.aspx"/>
<h2>Sitemap con menu</h2>
<asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
</asp:Menu><br />
<h2>Sitemap con TreeView</h2><br />
    <asp:TreeView ID="TreeView1" runat="server">
    </asp:TreeView>
</asp:Content>