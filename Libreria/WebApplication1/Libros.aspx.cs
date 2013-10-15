using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Libros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            String cadenaSql;
            SqlConnection cn = new SqlConnection("Data Source=MICROSOFT\\SQLEXPRESS;Initial Catalog=libreria;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            cadenaSql = "Select * from libros where idTema=";
            cadenaSql+=this.Request.QueryString["tema"];
            try
            {
                cn.Open();
                cmd = new SqlCommand(cadenaSql, cn);
                dr = cmd.ExecuteReader();
                lblproductos.Text = "<table align='center' width='60%' border='1'>";
                lblproductos.Text += "<tr><th>Libros</th>";
                lblproductos.Text += "<th>Precio</th>";
                lblproductos.Text += "<th>Autor</th></tr>";

                while (dr.Read())
                {
                    lblproductos.Text += "<tr><td>" + dr["titulo"].ToString() + "</td>";
                    lblproductos.Text += "<td>" + dr["precio"].ToString() + "</td>";
                    lblproductos.Text += "<td>" + dr["autor"].ToString() + "</td></tr>";
                }
                lblproductos.Text += "</table>";
            }
            catch (Exception ex)
            {
                lblproductos.Text = "Error en la lectura de datos" + ex.Message;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}