using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _18d09
{
    public partial class QueryString1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String texto = Textbox1.Text;

            Response.Redirect("QueryString2.aspx?texto="+texto);
            //Response.Redirect("QueryString2.aspx?texto="+texto+"&otro="+otro); viaje da datos por url
        }
    }
}