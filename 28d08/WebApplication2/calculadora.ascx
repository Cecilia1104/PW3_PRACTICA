<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="calculadora.ascx.cs" Inherits="WebApplication2.WebUserControl1" %>
 <asp:TextBox ID="txtentrada" runat="server"></asp:TextBox>
    <asp:Button ID="btnsumar" runat="server" Text="Sumar" 
        onclick="btnsumar_Click" />
    <br />Resultado: <asp:Label ID="lblresultado" runat="server" Text="Resultado:"></asp:Label>

   <br /> <asp:DropDownList ID="DropDownList1" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
     
     <asp:ListItem Value="decimal">Decimal</asp:ListItem>
     <asp:ListItem Value="binario">Binario</asp:ListItem>
    </asp:DropDownList>
    
 
