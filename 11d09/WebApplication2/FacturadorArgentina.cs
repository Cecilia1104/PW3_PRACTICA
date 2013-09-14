using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class FacturadorArgentina : Facturador
    {
        public override void Facturar() {
            base.Facturar();
        }

        public override String Saludo() {
            base.Saludo();
            return "Argentina";
        }
    }
}