<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="CursosProfesor.aspx.cs" Inherits="TP_ExamenesEnLinea.CursosProfesor" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="AdminProfesor.aspx" class="btn btn-warning btn-lg">Crear curso</a>
    <br />
    <br />
    <div class="nav-tabs breadcrumb col-md-offset-0">
        <h3>
            Grilla Cursos</h3>
        <%--
    ACA SE REEPLAZARA LUEGO POR UNA GRIDVIEW CON DATOS DESDE LA BASE DE DATOS--%>
        <div class="breadcrumb col-mg-2">
            <table class="table table-striped table-hover">
                <thead>
                    <tr>
                        <th>
                            Curso
                        </th>
                        <th>
                            Activo
                        </th>
                        <th>
                            Cantidad de alumnos
                        </th>
                        <th>
                            Fecha inicio
                        </th>
                        <th>
                            Fecha fin
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            Matematica 1
                        </td>
                        <td>
                            si
                        </td>
                        <td>
                            10
                        </td>
                        <td>
                            15/08/2013
                        </td>
                        <td>
                            05/12/2013
                        </td>
                        <td>
                            <a href="EditarCursoProfesor.aspx" class="icon-pencil"></a>
                        </td>
                        <td>
                            <a href="BorrarCursoProfesor.aspx" class="icon-remove-sign"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Taller 2
                        </td>
                        <td>
                            No
                        </td>
                        <td>
                            0
                        </td>
                        <td>
                            11/04/2013
                        </td>
                        <td>
                            20/07/2013
                        </td>
                        <td>
                            <a href="EditarCursoProfesor.aspx" class="icon-pencil"></a>
                        </td>
                        <td>
                            <a href="BorrarCursoProfesor.aspx" class="icon-remove-sign"></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Fisica 1
                        </td>
                        <td>
                            si
                        </td>
                        <td>
                            35
                        </td>
                        <td>
                            15/06/2013
                        </td>
                        <td>
                            10/10/2013
                        </td>
                        <td>
                            <a href="EditarCursoProfesor.aspx" class="icon-pencil"></a>
                        </td>
                        <td>
                            <a href="BorrarCursoProfesor.aspx" class="icon-remove-sign"></a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <br />
    </div>
</asp:Content>
