using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MastreYsiteMaps
{
    public partial class PageDeMaster1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //primer ejemplo de como acceder a control de master desde control content
            TextBox txtMaster = (TextBox)Master.FindControl("txtmaster");
            txtMaster.Text = "Acceso Autorizado";

            //segundo ejemplo de como acceder a control de master desde control content
            //((TextBox)Master.FindControl(txtmaster)).text = "Acceso autorizado";
            //Master.AsignarTexto = "Bienvenido";
        }
    }
}