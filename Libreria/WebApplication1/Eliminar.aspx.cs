using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DropDownList1.DataTextField = "titulo";
                DropDownList1.DataValueField = "idLibro";
                DropDownList1.DataSourceID = null;
                DropDownList1.DataSource = (DataTable)this.Session["libros"];
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String idLibro = DropDownList1.SelectedValue;
            DataRow[] filas = ((DataTable)this.Session["libros"]).Select("idLibro=" + idLibro);
            filas[0].Delete();
            DropDownList1.DataSourceID = null;
            DropDownList1.DataSource=(DataTable)this.Session["libros"];
            DropDownList1.DataBind();
            
        }

        protected void linkactualizar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = (SqlDataAdapter)this.Session["adapter"];
            DataTable libros = (DataTable)this.Session["libros"];
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(adp);
                adp.Update(libros);
                this.Response.Redirect("Inicio.aspx");
            }
            catch (Exception ex)
            {
                this.Response.Write("Error en la actualizacion" + ex.Message);
            }
        }
    }
}