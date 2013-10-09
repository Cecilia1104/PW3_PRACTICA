using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];
            Label1.Text = "\nUsuario:  " + user.Nombre + "\nEmail:" + user.Email + "\nPassword:" + user.Password;
        }
    }
}
