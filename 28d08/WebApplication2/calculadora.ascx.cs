using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
             lblresultado.Text = "0";
        }

        protected void btnsumar_Click(object sender, EventArgs e)
        {
            int anterior = Int32.Parse(lblresultado.Text);
            int operando = Int32.Parse(txtentrada.Text);
            int resultado = anterior + operando;
            lblresultado.Text = Convert.ToString(resultado); 

        }
        /*Al seleccionar una opcion tiene que ejecutar una accion. Si es decimal pasar la suma a decimal
        y si es binario a binario*/
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*switch (DropDownList1.SelectedValue)
            {
              
                case "decimal" :
                    lblresultado.Text = Convert.ToString(resultado);
                    break;
                case "binario" :
                      lblresultado.Text = Convert.ToString(resultado, 2); 
                    break;
            }*/
            

        
        }
    }
}