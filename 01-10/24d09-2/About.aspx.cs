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
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AccesoDatos ac = new AccesoDatos();
            String conexion = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            String query = "ObtenerDatos";
            CommandType command = CommandType.StoredProcedure;


          
            DataSet dato = ac.Ejecutar(conexion, query, command);


            DropDownList1.DataSource = dato;
            DropDownList1.DataTextField = "BirthDate";
            DropDownList1.DataValueField = "EmployeeID";
            DropDownList1.DataBind();

        }
    }
}
