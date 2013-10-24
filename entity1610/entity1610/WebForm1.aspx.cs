using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace entity1610
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        PruebaEntities1 ctx = new PruebaEntities1();

        protected void Page_Load(object sender, EventArgs e)
        { 
           //Se enlazan los datos de la base de datos con el DropDownList
            if (!IsPostBack)
            {
                cargarDDl();
            }
           
        }

        private void cargarDDl()
        {
            var selecciones = ctx.Seleccion.ToList();
            DropDownList1.DataSource = selecciones;
            DropDownList1.DataTextField = "nombre";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
           
            int opcion = Convert.ToInt32(DropDownList1.SelectedValue);

            var tec = (from te in ctx.Tecnico
                       where te.idseleccion == opcion
                       select te.nombre).FirstOrDefault();
            lbltecnico.Text = tec;
            lbltecnico.DataBind();

            var grid = (from ju in ctx.Jugador
                        where ju.idseleccion == opcion
                        select ju).ToList();
            GridView1.DataSource = grid; //CARGO GRILLA JUGADOR.
            GridView1.DataBind();  

             //Promedio de edades:
            var edad = (from ju in ctx.Jugador
                        where ju.idseleccion == opcion
                        select ju.edad).Average();
           
            lbledad.Text = "La edad es promedio por seleccion es:" + edad;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //insertar
            Jugador jugador = new Jugador();
            jugador.nombre= txtnombre.Text;
            jugador.apellido = txtapellido.Text;
            jugador.idseleccion = DropDownList2.SelectedIndex;
            jugador.edad = Convert.ToInt32(txted.Text);
            ctx.Jugador.AddObject(jugador);
            ctx.SaveChanges();
            Label2.Text = "Cargado correctamente";
  

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string nom = txtjugador.Text;
            var borrar = (from n in ctx.Jugador
                          where n.nombre.StartsWith(nom)
                          select n).Single();
          
            ctx.DeleteObject(borrar);
            lblmensaje.Text = "Jugador eliminado correctamente";
            ctx.SaveChanges();
        }

        //Insertar seleccion y tecnico
        protected void Button3_Click(object sender, EventArgs e)
        {
            Seleccion seleccion = new Seleccion();
            Tecnico tecnico = new Tecnico();
            seleccion.nombre = TextBox1.Text;
            ctx.Seleccion.AddObject(seleccion);

            tecnico.nombre = TextBox2.Text;
            tecnico.apellido = TextBox3.Text;
            ctx.Tecnico.AddObject(tecnico);
            ctx.SaveChanges();
            Label7.Text = "Ingresado correctamente";



        }

        //Borrar seleccion, jugador y tecnico
        protected void Button5_Click(object sender, EventArgs e)
        {
            string sel = TextBox4.Text;
            int idSel = (from n in ctx.Seleccion
                         where n.nombre == sel
                         select n.id).FirstOrDefault();

            var borra = (from sl in ctx.Seleccion
                         where sl.nombre.StartsWith(sel)
                         select sl).Single();

            foreach (var tec in borra.Tecnico.ToList()) {
                ctx.Tecnico.DeleteObject(tec);
            }

            foreach (var jug in borra.Jugador.ToList()) {
                ctx.Jugador.DeleteObject(jug);
            }

           
            ctx.DeleteObject(borra);
            ctx.SaveChanges();
            Label9.Text = "Borro todo";
             
        }

      

     
    }
}

//Consultar jugadores y tecnicos segun seleccion
//dar de alta jugadores
//dar de  baja jugadores
//dar de alta una seleccion y tecnico
//calcular edad promedio de jugadores.Agregar campo edad.

//Tranferir jugador de selecion a otra.(falta)
