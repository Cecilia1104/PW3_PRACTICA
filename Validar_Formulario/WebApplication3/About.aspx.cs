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
		      if(Session["MiUsuario"]!=null)
			  {
            Usuario user = (Usuario)Session["MiUsuario"];
            Label1.Text = "\nUsuario:  " + user.Nombre + "\nEmail:" + user.Email + "\nPassword:" + user.Password;
			}
        }
		 protected void Button1_Click(object sender, EventArgs e)
        {

            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}
