using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DropDownList1.DataTextField = "titulo";
                DropDownList1.DataValueField = "idLibro";
                DropDownList1.DataSource = (DataTable)this.Session["libros"];
                DropDownList1.DataSourceID = null;
                DropDownList1.DataBind();
                DropDownList1.DataMember = "libros";
            }
        }
        protected void btndatos_Click(object sender, EventArgs e)
        {
            String idLibro = DropDownList1.SelectedValue;
            this.ViewState["idLibro"]=idLibro;
            if (idLibro != "")
            {
                DataRow[] filas = ((DataTable)this.Session["libros"]).Select("idLibro=" + idLibro);
                txttitulo.Text = filas[0]["titulo"].ToString();
                txtprecio.Text = filas[0]["precio"].ToString();
                txtautor.Text = filas[0]["autor"].ToString();
            }
            else
            {
                txttitulo.Text = "Libro no existe en la BD";
            }
        }
        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            String idLibro=this.ViewState["idLibro"].ToString();
            if (idLibro != "")
            {
                DataRow[] filas = ((DataTable)this.Session["libros"]).Select("idLibro=" + idLibro);
                filas[0]["titulo"] = txttitulo.Text;
                filas[0]["precio"] = decimal.Parse(txtprecio.Text);
                filas[0]["autor"] = txtautor.Text;
                
            }
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