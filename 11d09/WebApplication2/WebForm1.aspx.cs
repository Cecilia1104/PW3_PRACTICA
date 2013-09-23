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
           
            Facturador fac = new Facturador();
            String msj1 = fac.Saludo();

            //Para el facturador de Argentina:
            Facturador fa = new FacturadorArgentina();
            String msj2 = fa.Saludo();

            Label1.Text = String.Format("{0} {1}", msj1, msj2);

            //Para el facturador de China:
            Facturador fachi = new FacturadorChina();
            String msj3 = fachi.Saludo();

            Label2.Text = String.Format("{0} {1}", msj1, msj3);


        }
    }
}