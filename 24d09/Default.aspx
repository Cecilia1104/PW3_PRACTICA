<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="FullName" AutoPostBack="true"
        DataValueField="EmployeeID" DataSourceID="SqlDataSource1">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>"
        
        SelectCommand="SELECT [EmployeeID],  [LastName]+' '+[FirstName] as 'FullName' FROM [Employees] ORDER BY [LastName]">
    </asp:SqlDataSource>
    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2"
        DataTextField="ShippedDate" DataValueField="OrderID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString%>"
        SelectCommand="SELECT [OrderID], [ShippedDate] FROM [Orders] WHERE ([EmployeeID] = @EmployeeID)">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="EmployeeID" PropertyName="SelectedValue"
                Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
