<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario2.aspx.cs" Inherits="_04d09.Formulario2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="Stylesheet" href="StyleSheet1.css" type="text/css" />
<%--Funcion de validacion en cliente--%>
<script type="text/javascript">
    function valExperiencia(sender, args) {
        var experiencia = args.Value.toLowerCase();
        if (experiencia.indexOf("despedido") != -1) {
            ars.IsValid = false;
        }
        else {
            args.IsValid = true;
        }
    }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="form">
    <h2>ALTA TARJETA DE CREDITO</h2>
     <div id="contenedor">
         Ejercicio 2: Validar:
         Dato obligatorio: Todos los campos - Nombre y repeticion de nombre :Coincidir - Cantidad de tarjeta: Numero entero menor a 3 - La persona debe ser mayor de 18 - La experiencia laboral no debe decir "despedido"
    </div>
    <%--Validar Nombre del titular--%>
        <asp:Label ID="lblnombre" runat="server" Text="Nombre del titular"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
         ErrorMessage="Ingrese Nombre" ControlToValidate="txtnombre" Display="Dynamic" Text="Campo Obligatorio"></asp:RequiredFieldValidator>
        <br/>
    <%--Valido el reingreso del titular--%>
        <asp:Label ID="lblrenombre" runat="server" Text="Reingrese nombre del titular"></asp:Label>
        <asp:TextBox ID="txtrenombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ErrorMessage="Ingrese Nombre" ControlToValidate="txtrenombre" Display="Dynamic" Text="Campo Obligatorio"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Deben ser iguales los nombres"
        ControlToCompare="txtnombre" ControlToValidate="txtrenombre" Display="Dynamic">Deben ser iguales los nombres</asp:CompareValidator>
        <br />
   <%--Valido la cantidad de tarjetas--%>
        <asp:Label ID="lblcantidad" runat="server" Text="Cantidad de tarjetas"></asp:Label>
        <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
         ErrorMessage="Ingrese cantidad" ControlToValidate="txtcantidad" Display="Dynamic" Text="Campo Obligatorio"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server"
         ErrorMessage="Debe ser entero y menor a 3" ControlToValidate="txtcantidad" Display="Dynamic" MaximumValue="3" MinimumValue="1" Type="Integer">Debe ser entero menor a 3</asp:RangeValidator>
        <br />
    <%--Valida la fecha de nacimiento--%>
        <asp:Label ID="lblfecha" runat="server" Text="Fecha de nacimiento(dd/mm/aaaa)"></asp:Label>
        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ErrorMessage="Ingrese fecha" ControlToValidate="txtfecha" Display="Dynamic" Text="Campo Obligatorio"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server"
         ErrorMessage="Fecha incorrecta" ControlToValidate="txtfecha" Display="Dynamic" MinimumValue="04/04/1920" Type="Date">Fecha incorrecta</asp:RangeValidator>
        <br />
    <%--Valida que se elegia un tipo de tarjeta--%>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:DropDownList ID="ddltarjeta" runat="server">
          <asp:ListItem Text="Seleccione una opcion" Value=""></asp:ListItem>
            <asp:ListItem Text="Visa" Value="1"></asp:ListItem>
            <asp:ListItem Text="MasterCard" Value="2"></asp:ListItem>  
            <asp:ListItem Text="American Express" Value="3"></asp:ListItem>    
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ErrorMessage="Elija una opcion" Display="Dynamic" ControlToValidate="ddltarjeta" Text="Campo Obligatorio" InitialValue=""></asp:RequiredFieldValidator>
       <br />
    <%--Valida la experiencia laboral --%>
        <asp:Label ID="lblexp" runat="server" Text="Experiencia Laboral"></asp:Label>
        <asp:TextBox ID="txtexp" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
         ErrorMessage="Ingrese su experiencia laboral" ControlToValidate="txtexp" Display="Dynamic" Text="Campo Obligatorio"></asp:RequiredFieldValidator>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="No debe ser despedido" ControlToValidate="txtexp" Display="Dynamic" ClientValidationFunction="valExperiencia"
        OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="true">No debe ser despedido</asp:CustomValidator>
        <br />
        <asp:Button ID="btenviar" runat="server" Text="Solicitar" OnClick="btnenviar_Click" />
        <asp:Button ID="Button1" runat="server" Text="Cancelar" CausesValidation="false" />
    <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
    </div>
    
    </form>
</body>
</html>
