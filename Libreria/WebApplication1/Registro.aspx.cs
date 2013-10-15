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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source=MICROSOFT\\SQLEXPRESS;Initial Catalog=libreria;Integrated Security=True");
            String query = "Insert into clientes(usuario,password,email,telefono) values (@usuario,@password,@email,@telefono)";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@usuario", txtnombre.Text);
                cmd.Parameters.AddWithValue("@password", txtcontraseña.Text);
                cmd.Parameters.AddWithValue("@email", txtcorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
                
                cmd.ExecuteNonQuery();
                lblresultado.Text = "Registro existoso";
            }
            catch (Exception ex)
            {
                lblresultado.Text = "Error" + ex.Message;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}