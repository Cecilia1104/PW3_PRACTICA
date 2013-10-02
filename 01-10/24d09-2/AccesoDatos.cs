using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace _24d09_2
{
    public class AccesoDatos
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
    }
}