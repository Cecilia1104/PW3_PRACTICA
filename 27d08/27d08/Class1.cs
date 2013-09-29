using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27d08
{
    class Class1
    {
        static void Main(string[] args)
        {

            string s = "123456789";
            Manipular(ref s);
        }
        static void Manipular(ref string s)
        {

            s = s.Substring(0, 4);
            //return s;
            Console.Write("Separa la cadena: 123456789 en 4 caracteres: \n");
            Console.WriteLine(s);
            Console.Read();

        }
    }
}
