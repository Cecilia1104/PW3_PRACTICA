using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Facturador
    {
        public virtual void Facturar() { // Clase Padre. Al ser virtual puedo en sus clases hijas definirlas como override
        
        }

        public virtual string Saludo() {
            return "Hola";
        }
      
       
    }


}