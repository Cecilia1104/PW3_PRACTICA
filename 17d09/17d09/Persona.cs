using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17d09
{
    public abstract  class Persona
    {
        protected string nombre;
        protected int edad;
        protected float altura;

        public Persona(string nombre, int edad):this()
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public Persona()
        {
            this.altura = 1.7f;
        }
        public abstract string Saludar();

        public virtual string DecirMiNombre() 
        {
            return this.nombre;
        }
            
    }

}