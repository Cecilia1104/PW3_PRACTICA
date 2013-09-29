<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true"
    CodeBehind="ExamenesDisponiblesAlumnos.aspx.cs" Inherits="TP_ExamenesEnLinea.ExamenesDisponiblesAlumnos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="nav-tabs breadcrumb col-md-offset-0">
        <h3>
            Examenes disponibles</h3>
        <div class="breadcrumb col-mg-2">
            <table class="table table-striped table-hover">
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
                            Estado
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            Algebra 1
                        </td>
                        <td>
                            Numeros complejos
                        </td>
                        <td>
                            20/09/2013 13:00
                        </td>
                        <td>
                            <a href="PrevioExamenAlumno.aspx">Realizar examen</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Algebra 1
                        </td>
                        <td>
                            Polinomios
                        </td>
                        <td>
                            18/09/2013 20:00
                        </td>
                        <td>
                            Aprobado
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
                            Examen vencido
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
