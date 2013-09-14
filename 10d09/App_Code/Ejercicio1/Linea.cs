using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplos.POO.Ejercicio1
{
    public class Linea
    {
        public Punto PuntoA { get; set; }
        public Punto PuntoB { get; set; }

        public Linea()
        {
            PuntoA = new Punto(0, 0);
            PuntoB = new Punto(0, 0);
        }

        public Linea(Punto puntoA, Punto puntoB)
        {
            PuntoA = puntoA;
            PuntoB = puntoB;
        }

        private void Mover(double cantidadX, double cantidadY)
        {
            PuntoA.X += cantidadX;
            PuntoB.X += cantidadX;

            PuntoA.Y += cantidadY;
            PuntoB.Y += cantidadY;
        }

        public void MueveDerecha(double cantidad)
        {
            PuntoA.X += cantidad;
            PuntoB.X += cantidad;
        }

        public void MueveIzquierda(double cantidad)
        {
            PuntoA.X -= cantidad;
            PuntoB.X -= cantidad;
        }

        public void MueveArriba(double cantidad)
        {
            PuntoA.Y += cantidad;
            PuntoB.Y += cantidad;
        }

        public void MueveAbajo(double cantidad)
        {
            PuntoA.Y -= cantidad;
            PuntoB.Y -= cantidad;
        }

        public string Mostrar()
        {
            return string.Format("La linea se encuentra entre los puntos ({0} ; {1}) y ({2} ; {3})", PuntoA.X, PuntoA.Y, PuntoB.X, PuntoB.Y);
        }                  
    }
}
