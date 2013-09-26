<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="_18d09.Session" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       Usuario: <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
       <br />
       En sesion: <asp:Label ID="lblusuario" runat="server" Text=""></asp:Label>
       <br />
        <asp:Button ID="Button1" runat="server" Text="Iniciar" 
            onclick="Button1_Click" />
        <asp:Button ID="btncerrar" runat="server" Text="Cerrar" 
            onclick="btncerrar_Click" />
        
        <asp:Button ID="btnlimpiar" runat="server" Text="Limpiar Sesion" 
            onclick="btnlimpiar_Click" />
    </div>
    </form>
</body>
</html>
