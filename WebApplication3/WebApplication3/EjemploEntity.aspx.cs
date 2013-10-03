using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class EjemploEntity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Se enlazan los datos de la base de datos con el DropDownList
            BD_EntityFrameworkEntities2 Context = new BD_EntityFrameworkEntities2();
            var Clientes = from c in Context.Empleados select c;
            DropDownList1.DataSource = Clientes;
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //insert
            BD_EntityFrameworkEntities2 ctx = new BD_EntityFrameworkEntities2();
            Empleado emp = new Empleado();
            emp.Nombre = txt.Text;
            ctx.Empleados.AddObject(emp);
            ctx.SaveChanges(); //graba en la bd
            Label2.Text = emp.Nombre;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //trae el ultimo empleado
            BD_EntityFrameworkEntities2 ctx = new BD_EntityFrameworkEntities2();
            //Empleado emp = new Empleado();
            var emps = (from es in ctx.Empleados
                       select es.Nombre).FirstOrDefault();
            TextBox1.Text = emps;
            ctx.SaveChanges();
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
                //actualiza siempre el primero
                BD_EntityFrameworkEntities2 ctx = new BD_EntityFrameworkEntities2();

                var emp = (from mod in ctx.Empleados
                           select mod).FirstOrDefault();
                emp.Nombre = TextBox2.Text;
                ctx.SaveChanges();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string valor = TextBox3.Text;
            BD_EntityFrameworkEntities2 ctx = new BD_EntityFrameworkEntities2();
            var borrar = (from n in ctx.Empleados
                         where n.Nombre.StartsWith(valor)
                         select n).Single();
            ctx.DeleteObject(borrar);
            lblmensaje.Text = "Registro eliminado correctamente";
            ctx.SaveChanges();
            
        }
    }
}