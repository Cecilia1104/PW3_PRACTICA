using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Nuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                String cadenaSql;
                String cadenaCon;
                SqlDataAdapter adp =null;
                DataSet ds;
                ConnectionStringSettings settinglibreria;
                settinglibreria = ConfigurationManager.ConnectionStrings["cadLibreria"];
                cadenaCon=settinglibreria.ConnectionString;
                cadenaSql="Select * from Temas";
                ds = new DataSet();
                adp=new SqlDataAdapter(cadenaSql,cadenaCon);
                adp.Fill(ds,"temaslibros");
                DropDownList1.DataTextField="tema";
                DropDownList1.DataValueField="idTema";
                DropDownList1.DataSourceID = null; //agregado para que ande el DataBind()
                DropDownList1.DataSource=ds.Tables["temaslibros"];
                DropDownList1.DataBind();
                DropDownList1.DataMember = "Temas"; //agregado para que ande el DataBind()
            }
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            DataTable libros = (DataTable)this.Session["libros"];
            DataRow dr = libros.NewRow();
            dr["idTema"] = int.Parse(DropDownList1.SelectedValue);
            dr["titulo"] = txttitulo.Text;
            dr["precio"] = decimal.Parse(txtprecio.Text);
            dr["autor"] = txtautor.Text;
            libros.Rows.Add(dr);
          
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

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