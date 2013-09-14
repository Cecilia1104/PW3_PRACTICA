using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Facturador fa = new FacturadorArgentina();
            String msj = fa.Saludo();

            Facturador fac = new Facturador();
            String msj2 = fac.Saludo();

            Label1.Text = msj2;

            Facturador fachi = new FacturadorChina();
            fa.Facturar();
        }
    }
}