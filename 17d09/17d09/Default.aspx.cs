using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17d09
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Primer ejemplo, muestra el saludo junto al nombre y la edad del alumno:
            //Persona persona = new Persona(); no se puede instanciar una clase abstracta
            Alumno alumno = new Alumno("Pepe", 25);
            Label1.Text = "<h3>Saludo de Alumno</h3>" + alumno.Saludar();

            //Segundo ejemplo: Muestra idem anterior pero del profesor:

            Persona profe = new Profesor("Pepe", 25, 1.7f);
            Label2.Text = "<h3>Saludo de Profesor</h3>" + profe.Saludar();
            Label3.Text = profe.DecirMiNombre();



            //Otra forma de hacer el Primer ejemplo:
            //    Persona p = new Alumno ("Pedro", 21);
            //    MostrarMensaje(p);
            //    string msjAlumno = p.Saludar();

            //}
            //private void MostrarMensaje(Persona p)
            //{
            //    Label2.Text = p.Saludar();
            //}
        }
    }
}