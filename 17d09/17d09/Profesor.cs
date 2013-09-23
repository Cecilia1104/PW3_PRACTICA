using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17d09
{
    public class Profesor:Persona
    {
        public Profesor(string nombre, int edad, float altura)
        {
            this.nombre = nombre;
        }

        public override string Saludar()
        {
            
            return "Hi!!Soy un Profesor";
        }

        public override string DecirMiNombre()
        {

            return "Mi nombre es:" + this.nombre; //Se esta sobreescribiendo el metodo DecirMiNombre de Persona.cs

        }

    }
}