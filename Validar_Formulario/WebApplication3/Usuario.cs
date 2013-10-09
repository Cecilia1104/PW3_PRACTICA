using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Usuario
    {
        private string nombre;
        private string email;
        private string password;


        public string Nombre {

            get {

                return nombre;
            }
            set {

                nombre = value;

            
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

        public Usuario(string nombre, string email, string password)
        {
            this.nombre = nombre;
            this.email = email;
            this.password = password;
        
        
        }



    }
    
}