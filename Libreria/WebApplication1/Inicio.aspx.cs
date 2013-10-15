using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["libros"] == null)
            {
                Welcome.Text = "Bienvenido, " + Context.User.Identity.Name;
                String cadenaCon;
                String cadenaSql;
                SqlDataAdapter adp = null;
                DataSet ds;
                ConnectionStringSettings settingLibreria;
                settingLibreria = ConfigurationManager.ConnectionStrings["cadlibreria"];
                cadenaCon = settingLibreria.ConnectionString;
                cadenaSql = "select *  from Libros";
                ds = new DataSet();
                adp = new SqlDataAdapter(cadenaSql, cadenaCon);
                adp.Fill(ds, "libros");
                this.Session["libros"] = ds.Tables["libros"];
                this.Session["adapter"] = adp;

            }
        }

        protected void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        

    }
}