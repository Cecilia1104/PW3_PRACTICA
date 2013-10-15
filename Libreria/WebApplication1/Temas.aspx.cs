using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;

namespace WebApplication1
{
    public partial class Temas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
            //    GestionLibros glibros = new GestionLibros();
            //    lsttemas.DataTextField = "tema";
            //    lsttemas.DataValueField = "idTema";
            //    lsttemas.DataSource = glibros.GetTemas();
            //    lsttemas.DataBind();
            //}

            SqlConnection cn = new SqlConnection("Data Source=MICROSOFT\\SQLEXPRESS;Initial Catalog=libreria;Integrated Security=True");
            String cadenaSql;
            SqlDataAdapter adp = null;
            DataSet ds;
            cadenaSql = "Select * from Temas";
            ds = new DataSet();
            try
            {
                adp=new SqlDataAdapter(cadenaSql,cn);
                adp.Fill(ds,"temaslibros");
                foreach(DataRow dr in ds.Tables["temaslibros"].Rows)
                {
                    ListItem li=new ListItem(dr["tema"].ToString(),dr["idTema"].ToString());
                    lsttemas.Items.Add(li);
                }
            }
            catch(Exception ex)
            {
                this.Response.Write(ex.Message);
            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Libros.aspx?tema=" + lsttemas.SelectedValue);
            
        }

        protected void lsttemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}