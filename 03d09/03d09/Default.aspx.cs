using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03d09
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Primera Forma: Acceder a la Master Page desde la Content Page(Default.aspx)
            //TextBox txtMaster = (TextBox)Master.FindControl("txtmaster");
            //txtMaster.Text = "Accedo Autorizado";

            //Segunda Forma:
            ((TextBox)Master.FindControl("txtmaster")).Text = "Acceso autorizado 2";

            //Master.AsignarTexto = "Bienvenido";

        }
    }
}
