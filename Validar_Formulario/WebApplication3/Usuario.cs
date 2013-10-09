using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Usuario
    {
        //Encapsular un campo de un objeto con get y set.
        //Variables:
        private string nombre; 
        private string email;
        private string password;

        //Propiedades:
        public string Nombre {

            get {

                return nombre; //metodo de lectura
            }
            set {

                nombre = value; //metodo de escritura

            
            }
        
        
        }
        public string Email
        {

            get
            {

                return email;
            }
            set
            {

                email = value;


            }


        }

        public string Password
        {

            get
            {

                return password;
            }
            set
            {

                password = value;


            }


        }

        //Constructor:
        public Usuario(string nombre, string email, string password)
        {
            this.nombre = nombre;
            this.email = email;
            this.password = password;
        
        
        }



    }
    
}