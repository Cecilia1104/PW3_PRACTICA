<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="AdminProfesor.aspx.cs" Inherits="TP_ExamenesEnLinea.AdminProfesor" %>

<%@ Register Src="~/Fecha.ascx" TagName="Calendario" TagPrefix="fec" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="nav-tabs breadcrumb col-md-offset-0">
        <h3>
            Alta de Curso</h3>
        <div class="breadcrumb col-mg-2">
            <div class="formio">
                <div class="control-group">
                    <asp:Label ID="lblmail" runat="server" class="control-label" Text="Nombre Curso"></asp:Label>
                    <div>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un nombre para el curso"
                        ControlToValidate="TextBox1" Display="Dynamic" CssClass="text-danger" Text="*Campo obligatorio"></asp:RequiredFieldValidator>
                </div>
                <div class="control-group">
                    <div class="controls">
                        <asp:Label ID="Label1" runat="server" Text="Estado Activo:"></asp:Label>
                        <asp:CheckBoxList ID="check" runat="server">
                            <asp:ListItem Selected="True">Verdadero</asp:ListItem>
                            <asp:ListItem>Falso</asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div class="control-group">
                    Fecha Inicio
                    <fec:Calendario ID="fecini" runat="server"></fec:Calendario>
                    <br />
                    Fecha Fin
                    <fec:Calendario ID="fecfin" runat="server"></fec:Calendario>
                </div>
                <div class="control-group">
                    <asp:Label ID="lblmails" runat="server" class="control-label" Text="Email Alumnos"></asp:Label>
                    <div class="controls">
                        <asp:TextBox ID="TextBox2" runat="server" MaxLength="140" Rows="6" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="controls">
                    <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="Crear Curso" />
                    <asp:Button ID="btncancelar" runat="server" CssClass="btn btn-inverse" Text="Cancelar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
