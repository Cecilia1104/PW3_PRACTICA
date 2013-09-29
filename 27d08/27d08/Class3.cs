//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace _27d08
//{
//    class Class3  //conversiones de tipo de datos: ir comentando por partes para probarlo
//    {


//        static void Main(string[] args)
//        {


//            string palabra = "hola";
//            Convertir(palabra);
//            ConvertirAEntero(palabra);
//            ConvertirTres(palabra);


//        }
//        //Convertir con Parse
//        static void Convertir(string palabra)
//        {
//            int valor = int.Parse(palabra);
//            Console.Write("Conversion");
//            Console.WriteLine(valor);
//            Console.Read();

//        }
//        //Convertir version basica -  
//        static void ConvertirAEntero(string palabra)
//        {
//            int devuelve = System.Convert.ToInt32(palabra);
//            Console.WriteLine(devuelve);
//            Console.Read();
//        }
//        //Convertir con TryParse
//        static void ConvertirTres(string palabra)
//        {
//            int final;
//            bool ret = int.TryParse(palabra, out final);
//            Console.WriteLine(ret);
//            Console.Read();


//        }
//    }
//}
          

