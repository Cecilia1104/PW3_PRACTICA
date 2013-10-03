<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploEntity.aspx.cs" Inherits="WebApplication3.EjemploEntity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Trae el nombre de todos los empleados:
        <asp:DropDownList DataTextField="Nombre" DataValueField="ID" ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        Ingrese un nombre [se incluye al final]<br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txt" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        Actualizar el primer registro<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Actualizar Nombre" 
            onclick="Button3_Click" /><br />

            Trae el primer registro<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="MostrarPrimero" onclick="Button2_Click" /><br />

        Ingrese nombre para borrar: <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button4"
            runat="server" Text="Borrar" onclick="Button4_Click" />
        <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
