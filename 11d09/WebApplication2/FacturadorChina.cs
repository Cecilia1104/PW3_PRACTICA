using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class FacturadorChina : Facturador
    {
        public override void Facturar()
        {
            base.Facturar(); //base es una palabra reservada, devuelve una referencia al objeto actual semejante a this. Los accesos a ella son tratados como si el verdadero tipo fuese el de su clase base.     
        }

        public override String Saludo()
        {
            base.Saludo();
            return "China";
        }

    }
}