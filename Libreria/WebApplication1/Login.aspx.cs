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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=MICROSOFT\\SQLEXPRESS;Initial Catalog=libreria;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dr;
            String query = "select usuario from clientes where usuario =@usuario and password=@password";
            
            try
            {
                cn.Open();
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
                cmd.Parameters.AddWithValue("@password", txtcontraseña.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    this.Response.Redirect("Inicio.aspx");
                else
                    lblresultados.Text = "Datos incorrectos!";
            }
            catch (Exception ex)
            {
                lblresultados.Text = ex.Message;
            }
            finally
            {
                cn.Close();
            }
        
        }
    }
}