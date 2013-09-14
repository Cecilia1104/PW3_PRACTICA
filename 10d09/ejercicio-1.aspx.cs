using Ejemplos.POO.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ejercicio_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var linea1 = new Linea();

        linea1.PuntoA = new Punto(0, 0);
        linea1.PuntoB = new Punto(1, 0);

        lblResultado.Text += "<h2>Linea Inicial</h2>";
        lblResultado.Text += linea1.Mostrar();
        lblResultado.Text += "<BR />";

        lblResultado.Text += "<h2>Mueve Arriba 2.9</h2>";
        linea1.MueveArriba(2.9);
        lblResultado.Text += linea1.Mostrar();

        lblResultado.Text += "<h2>Mueve Abajo 1.2</h2>";
        linea1.MueveAbajo(1.2);
        lblResultado.Text += linea1.Mostrar();

        lblResultado.Text += "<h2>Mueve Der 4.1</h2>";
        linea1.MueveDerecha(4.1);
        lblResultado.Text += linea1.Mostrar();

        lblResultado.Text += "<h2>Mueve Izq 0.5</h2>";
        linea1.MueveIzquierda(0.5);
        lblResultado.Text += linea1.Mostrar();

        //en vez de concatenar usando += muchas veces, se puede utilizar la clase StringBuilder
        //con el metodo AppendLine, solo hacer una asignacion al label
        //var sb = new System.Text.StringBuilder();
        //sb.AppendLine(linea1.Mostrar());
        //n veces
        //lblResultado.Text = sb.ToString();
    }

}