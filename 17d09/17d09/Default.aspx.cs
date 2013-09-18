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
            //Persona persona = new Persona();
            //Alumno alumno = new Alumno("Pepe", 25);
            //Label1.Text = "<h3>Saludo de Alumno</h3>"+ alumno.Saludar();
            //Profesor profe = new Profesor();

            //Label2.Text = "<h3>Saludo de Profesor</h3>"+ profe.Saludar();

            Persona p;
            p = new Alumno("Pedro", 21);
           // MostrarMensaje(p);
            //string msjAlumno = p.Saludar();
            
            //Persona profe = new Profesor("Pepe",25,1.7f);
            // Label2.Text = profe.DecirMiNombre();
           
              MostrarMensaje(p);
            //string msjProfesor = p.Saludar();
            //Label1.Text = msjAlumno;
            //Label2.Text = msjProfesor;
        }
        private void MostrarMensaje(Persona p)
        {
            Label1.Text = p.Saludar();
        }
    }
}
