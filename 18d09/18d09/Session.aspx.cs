using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18d09
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           var ID = Session.SessionID;
           Session["miUser"] = txtusuario.Text;
           lblusuario.Text = Session["miUser"].ToString();
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
           
                Session.Clear();
        }

        protected void btncerrar_Click(object sender, EventArgs e)
        {
                Session.Abandon();
           
        }
    }
}