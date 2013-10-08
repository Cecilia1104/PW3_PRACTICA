using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Profesor: Persona
    {
        String categoria;
        DateTime horas;
        public Profesor(String categoria, DateTime horas, String nombre, String apellido, DateTime fecha) :
            base(nombre, apellido, fecha)
        {
            this.categoria = categoria;
            this.horas = horas;
        }
        public override String ObtenerFirma()
        {
            return "La firma es:" + " " + apellido + " " + nombre;

        }
        public override string ObtenerProfesion()
        {
            return "La profesion es : Profesor" + " " +"La categoria es:"+categoria;
        }
        public string ObtenerEdad(DateTime fecha)
        {
            int edad = DateTime.Today.Year - fecha.Year;
            return "La edad del profesor es:" + " " + edad;

        }
        public string MostrarHoras(DateTime horas)
        {
            int hs = horas.Hour - DateTime.Today.Hour;
            return "Las horas semanales del profesor son:" + " " + hs;

        }
    }
}