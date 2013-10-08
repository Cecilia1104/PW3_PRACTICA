using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public abstract class Persona
    {
        protected String nombre;
        protected String apellido;
        protected DateTime fecha;

        public Persona(String nombre, String apellido, DateTime fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
        }
        public abstract String ObtenerFirma();
        public abstract String ObtenerProfesion();
    }
}