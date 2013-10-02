using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dominio;


namespace AccesoDatos
{
    public class Acceso
    {
        public DataSet Ejecutar(String conexionString, String comando, CommandType tipoComando)
        {
            SqlConnection conexion = new SqlConnection(); //varie la bd a ejecutar
            SqlCommand com = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            conexion.ConnectionString = conexionString;
            conexion.Open();

            com.Connection = conexion; 
            com.CommandText = comando; //vario la query, el stored procedure
            com.CommandType = tipoComando; //idem anterior


            data.Fill(ds);
            return ds; //retorna dato lleno a memoria
        }

        public List<Empleado> ObtenerEmpleados()
        {
            String cs = System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            String cm = "SELECT * FROM Employees";
            CommandType com = CommandType.Text;
        
            DataSet ds = Ejecutar(cs, cm, com);
           //mapear lo que devuelve dataset:
           List<Empleado> empleado= new List<Empleado>();
           foreach (DataRow dr in ds.Tables[0].Rows)
           {
               Empleado e = new Empleado();
               e.Nombre = (String)dr["FirstName"];
               empleado.Add(e); //genero un objeto empleado por cada fila

           }
            return empleado;

           
         }

    }
}
