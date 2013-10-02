using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using AccesoDatos;

namespace Servicio
{
   public class EmpleadoServicio
    {
       public List<Empleado> ObtenerEmpleados()
       {
           Acceso ac = new Acceso();
           return ac.ObtenerEmpleados();
       }
    }
}
