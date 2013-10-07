using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }


        //Boton de confirmacion de login para un usuario especifico:
        protected void btningresar_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text=="cecilia") &&
                 (txtpass.Text== "123"))
            {
               
                FormsAuthentication.RedirectFromLoginPage
                   (txtusuario.Text, Persist.Checked);
               
               
            }
            else
            {
                lblconfirmar.Text = "Datos incorrectos";
            }
        }

        ////Boton de confirmacion de login:
        //protected void btningresar_Click(object sender, EventArgs e)
        //{
        //    if (Page.IsValid)
        //    {

        //        lblconfirmar.Text = "Ingreso correcto";
        //    }
        //    else
        //    {
        //        lblconfirmar.Text = "";
        //    }

        //}

        //Función que permite limpiar todos los controles de una página Web
        //recursivamente. Útil cuando en la página existen varios controles
        //evita tener que limpiar uno por uno. 
        public void CleanControl(ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                
                    //Esta linea detécta un Control que contenga otros Controles
                    //Así ningún control se quedará sin ser limpiado.
                    CleanControl(control.Controls);
            }
        }


        //Evento del control Button Limpiar controles de la página ASPX

        protected void btnborrar_Click(object sender, EventArgs e)
        {
            //Cuando se llama el método limpiar se pasa como parámetro 
            //la colección de controles de la página Web.
            CleanControl(this.Controls);
        }
    }
}