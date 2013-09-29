<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="ExamenesProfesor.aspx.cs" Inherits="TP_ExamenesEnLinea.ExamenesProfesor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="CrearExamenProfesor.aspx" class="btn btn-warning btn-lg">Crear Examen</a>
    <br />
    <br />
    <div class="nav-tabs breadcrumb col-md-offset-0">
        <h3>
            Estadisticas de Examenes</h3>
        <%-- ACA SE REEPLAZARA LUEGO POR UNA GRIDVIEW CON DATOS DESDE LA BASE DE DATOS--%>
        <div class="breadcrumb col-mg-2">
            <table class="table text-center table-condensed">
                <thead>
                    <tr>
                        <th>
                            Curso
                        </th>
                        <th>
                            Examen
                        </th>
                        <th>
                            Fecha y hora tope
                        </th>
                        <th>
                            Rindieron
                        </th>
                        <th>
                            Aprobados
                        </th>
                        <th>
                            Reprobados
                        </th>
                        <th>
                            Alumnos que Faltan
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            Matematica 1
                        </td>
                        <td>
                            Numeros complejos
                        </td>
                        <td>
                            20/09/2013 13:00
                        </td>
                        <td>
                            2
                        </td>
                        <td>
                            1
                        </td>
                        <td>
                            1
                        </td>
                        <td>
                            8
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Fisica 1
                        </td>
                        <td>
                            Estatica y dinamica
                        </td>
                        <td>
                            10/09/2013 16:30
                        </td>
                        <td>
                            25
                        </td>
                        <td>
                            15
                        </td>
                        <td>
                            10
                        </td>
                        <td>
                            10
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
</asp:Content>
