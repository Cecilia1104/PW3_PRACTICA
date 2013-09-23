using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17d09
{
    public class Alumno:Persona
    {
        public Alumno(string nombre, int edad) : base(nombre, edad) //Hereda de Persona, el nombre y la edad.
        { 
        }
        public override string Saludar()
        {
            return "hola, soy un alumno" + " " + nombre +" "+edad;
        }
          
    }
}