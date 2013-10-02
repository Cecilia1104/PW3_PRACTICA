using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _24d09_2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            AccesoDatos acceso = new AccesoDatos();

            String conexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            String query = "SELECT * FROM Employees";
            CommandType com = CommandType.Text;
            //genero un string, una query y un command type para crear la consulta:
            DataSet datos = acceso.Ejecutar(conexion, query, com);
            

            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataAdapter data = new SqlDataAdapter(comando);
            //DataSet ds = new DataSet();

            //conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            ////se obtiene la ruta de configuracion para la conexion

            //conexion.Open();

            //comando.Connection = conexion;
            //comando.CommandText = "SELECT * FROM Employees";
            //comando.CommandType = CommandType.Text;

            //data.Fill(ds);

            ////DataSource:propiedad - DataBind():metodo => en el dropdownlist

            DropDownList1.DataSource = datos;
            DropDownList1.DataTextField = "FirstName";
            DropDownList1.DataValueField ="EmployeeID";
            DropDownList1.DataBind();

        }
    }
}
