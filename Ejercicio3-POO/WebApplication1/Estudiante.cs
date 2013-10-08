using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Estudiante : Persona
    {
        int cantidad;
        DateTime fechaIngreso;

        public Estudiante(int cantidad, DateTime fechaIngreso, String nombre, String apellido, DateTime fecha)
            : base(nombre, apellido, fecha)
        {
            this.cantidad = cantidad;
            this.fechaIngreso = fechaIngreso;

        }
        public override String ObtenerFirma()
        {
            return "La firma es:" + " " + apellido + " " + nombre+" "+" " +"La cantidad de materias aprobadas es:"+" "+cantidad;

        }
        public override string ObtenerProfesion()
        {
            return "La profesion es : Estudiante";
        }
        public string ObtenerEdad(DateTime fecha)
        {
            int edad = DateTime.Today.Year - fecha.Year;
            return "La edad del estudiante es:" +" " + edad;

        }
        //No me termina de cerrar la idea del promedio:
        public string PromedioAño(int cantidad, DateTime fechaIngreso)
        {
            int variable = DateTime.Today.Month - fechaIngreso.Month;
            int prom = (12 * cantidad) / variable;
            return "El promedio de materias aprobadas es:" + prom;
        }
       
    }
    }