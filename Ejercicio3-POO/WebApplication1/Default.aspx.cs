using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante(2,Convert.ToDateTime("10/04/2013"),"Agusto", "Martinez", Convert.ToDateTime("21/05/1989"));
            Label1.Text =  estudiante.ObtenerFirma();
            Label2.Text = estudiante.ObtenerProfesion();
            Label3.Text = estudiante.ObtenerEdad(Convert.ToDateTime("21/05/1989"));
            Label8.Text = estudiante.PromedioAño(2,Convert.ToDateTime("10/04/2013"));
          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor("Titular", Convert.ToDateTime("10:00:00"), "Ruben", "Aguirre", Convert.ToDateTime("10/10/1983"));
            Label4.Text = profesor.ObtenerFirma();
            Label5.Text = profesor.ObtenerProfesion();
            Label6.Text = profesor.ObtenerEdad(Convert.ToDateTime("10/10/1983"));
            Label7.Text = profesor.MostrarHoras(Convert.ToDateTime("10:00:00"));
        }
    }
}
