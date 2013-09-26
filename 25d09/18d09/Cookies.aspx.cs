using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18d09
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //HttpCookie cook = new HttpCookie("usuario");
            //cook["user"] = txtNombre.Text;
            Response.Cookies["user"].Value = txtNombre.Text;
            //lblValorCookie1.Text = cook["user"];
        }

        protected void btnLeer_Click(object sender, EventArgs e)
        {
            String valor = String.Format(Request.Cookies["user"].Value);
            lblValorCookie1.Text = valor;

        }
    }
}