﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
   public class Empleado
    {
       public String nombre; //variable
       public String Nombre //propiedad
       {
           get { return nombre; }
           set { nombre = value; }
         }           
    }
}
