<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio.aspx.cs" Inherits="WebApplication2._Default" %>


<%@ Register src="calculadora.ascx" tagname="calculadora" tagprefix="uc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora</title>
</head>
<body>
<span>Suma los numeros ingresados y permite pasarlos a decimal o binario:</span>
    <form id="form1" runat="server">
    
   
    <uc1:calculadora ID="calculadora1" runat="server" />
    
   
    </form>
</body>
</html>
