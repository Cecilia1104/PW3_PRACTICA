<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContenidoPrincipal"><%--Site Master--%>
    <h2>Validaciones requeridas:</h2>
    <asp:BulletedList ID="BulletedList1" runat="server"> <%--Lista con el enunciado--%>
    <asp:ListItem>Que los campos requeridos sean: usuario, email y password</asp:ListItem>
    <asp:ListItem>Usuario: con longitud entre 4 y 8 caracteres</asp:ListItem>
    <asp:ListItem>Email: Con el formato de una direccion de mail</asp:ListItem>
    <asp:ListItem>Password: Primer caracter en Mayuscula y que tenga un numero</asp:ListItem>
    <asp:ListItem>Repita password: compara ambas contraseñas</asp:ListItem>
    <asp:ListItem>Boton que confirme su evento OnClick la validez de los campos del registro</asp:ListItem>
    <asp:ListItem>Se debe informar si el registro fue correcto</asp:ListItem>
    </asp:BulletedList>
    <br />

    <%--Resolucion--%>
    <h2>Registro de usuario:</h2>
    <asp:Label ID="lblnombre" runat="server" Text="Nombre:"></asp:Label>
    <div><asp:TextBox ID="txtnombre" runat="server"></asp:TextBox></div>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnombre" ErrorMessage="*Campo requerido"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="La longitud tiene que ser entre 4 y 8" ValidationExpression="[\S\s]{4,8}" ControlToValidate="txtnombre"></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="lblemail" runat="server" Text="E-mail:"></asp:Label>
    <div><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></div>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Campo requerido" ControlToValidate="txtemail"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Formato de E-mail no valido" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtemail"></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="lblpass" runat="server" Text="Password:"></asp:Label>
    <div><asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox></div> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Campo requerido" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="Ingreso erroneo, primer caracter en mayuscula y debe contener 1 numero" 
        ControlToValidate="txtpass" onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    <br />

    <asp:Label ID="lblrepass" runat="server" Text="Repetir Password:"></asp:Label>
    <div><asp:TextBox ID="txtrepass" runat="server" TextMode="Password"></asp:TextBox></div>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Campo requerido" ControlToValidate="txtrepass"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Ambas contraseñas deben coincidir" ControlToValidate="txtrepass" ControlToCompare="txtpass"></asp:CompareValidator>
    <br />

    <asp:Button ID="btnaceptar" runat="server" Text="Confirmar registro" 
        onclick="btnaceptar_Click" />
     <asp:Label ID="lblaceptar" runat="server" Text=""></asp:Label>
   
   
   
</asp:Content>

