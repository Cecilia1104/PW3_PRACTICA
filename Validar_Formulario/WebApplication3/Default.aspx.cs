using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page
    {
        //Informar si el registro se realizo correctamente:
        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblaceptar.Text = "Bienvenido,Campos validados con exito!!";
            }
            else
            {
                lblaceptar.Text = "";

            }
        }

        //Valido password para el registro de usuario:
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool tieneNumero = false;
            bool tieneMayusc = false;
            char[] cadena = args.Value.ToCharArray();
            tieneMayusc = Char.IsUpper(cadena[0]);//Indica si el carácter comienza con una letra mayúscula.
            foreach (char Item in cadena)
            {
                tieneNumero = char.IsNumber(Item); //comprueba si contiene al menos 1 numero
            }
            if (tieneMayusc && tieneNumero)
            {
                args.IsValid = true; //si cumple con las condiciones devuelve true al validar con el boton "registrar"
            }
            else
            {
                args.IsValid = false;
            }

        }

    }
}
