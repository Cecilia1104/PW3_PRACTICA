<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="entity1610.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entity Framework</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Formulario </h3>
        <asp:Label ID="lblseleccion" runat="server" Text="Seleccion:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" 
            onclick="Button1_Click1" />
       <br />

        <asp:Label ID="lbltecnico" runat="server" Text="Tecnico:"></asp:Label>
        <asp:Label ID="labeltecnico" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lbljugadores" runat="server" Text="Jugadores:"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
         Promedio de edades:<br />
        <asp:Label ID="lbledad" runat="server" Text=""></asp:Label>
        <br /><br />
         Ingrese un Jugador [se incluye al final]<br />
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="Edad:"></asp:Label>
        <asp:TextBox ID="txted" runat="server"></asp:TextBox>
       
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true">
        <asp:ListItem Value="0" Text="Seleccione una seleccion"></asp:ListItem>
        <asp:ListItem Value="1"  >Argentina</asp:ListItem>
        <asp:ListItem Value="2">Uruguay</asp:ListItem>
        <asp:ListItem Value="3">Chile</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label10" runat="server" Text="Edad:"></asp:Label>
        <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Agregar" onclick="Button2_Click"/>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br /><br />
        Ingrese nombre del jugador para borrar: <br />
        <asp:TextBox ID="txtjugador" runat="server"></asp:TextBox>
        <asp:Button ID="Button4"
            runat="server" Text="Borrar" onclick="Button4_Click" />
        <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
        <br /><br />
       Ingresar seleccion y tecnico:<br />
        <asp:Label ID="Label4" runat="server" Text="Nombre seleccion:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Nombre Tecnico:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Apellido Tecnico:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Agregar" 
            onclick="Button3_Click" />
        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
        <br /><br />
        Baja de seleccion:<br />
        <asp:Label ID="Label8" runat="server" Text="Ingresar nombre de seleccion a eliminar:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="Eliminar" 
            onclick="Button5_Click" />
        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
        <br /><br />
     
    </div>
    </form>
</body>
</html>


