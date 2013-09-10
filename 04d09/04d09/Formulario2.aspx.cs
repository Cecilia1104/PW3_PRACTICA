using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04d09
{
    public partial class Formulario2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidator2.MaximumValue = DateTime.Now.AddYears(-18).ToShortDateString();
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmensaje.Text = "Formulario compleado correctamente";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string experiencia = args.Value.ToLower();
            if (experiencia.IndexOf("despedido") != -1)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
      
    }
}