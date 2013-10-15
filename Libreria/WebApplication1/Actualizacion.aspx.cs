using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class Actualizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnactualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=MICROSOFT\\SQLEXPRESS;Initial Catalog=libreria;Integrated Security=True");
            SqlParameter sp;
            SqlCommand cmd;
            String cadenaSql="actualizaPrecios";
            try
            {
                cn.Open();
                cmd = new SqlCommand(cadenaSql,cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@codigo",int.Parse(txtcodigo.Text)));
                cmd.Parameters.Add(new SqlParameter("@precio",decimal.Parse(txtprecio.Text)));
                sp=new SqlParameter();
                sp.ParameterName="@result";
                sp.SqlDbType=SqlDbType.Int;
                sp.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sp);
                cmd.ExecuteNonQuery();
                if(int.Parse(sp.Value.ToString())>0)
                {
                    lblactualizado.Text="Precio actualizado";
                }
                else
                {
                    lblactualizado.Text="No existe ningun libro con ese codigo";
                }
            }
            catch(Exception ex)
            {
                lblactualizado.Text="Error en el registro"+ex.Message;
            }
            finally
            {
                cn.Close();
            }
        }
        }
    }
