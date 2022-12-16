using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new RegistrarUsuario());


            //testCRUDUsuario();

        }

        //static HostpitalDBEntities context = new HostpitalDBEntities();

        static private void testCRUDUsuario()
        {



            //Usuarios user = DAOUsuario.getUsuario(7);
            /*
            DAOUsuario.DeleteUsuario(user);

            List<Usuarios> usuarios = new List<Usuarios>();

            //usuarios.Add(DAOUsuario.getUsuario(7));

            MessageBox.Show($"Cantidad usuarios: {usuarios.Count}");

            printUsuario(usuarios);


            user.Apellidos = "Marchena";
           */
            //DAOUsuario.UpdateUsuario(user);
            

/*




            List<Usuarios> usuarios= DAOUsuario.GetUsuarios();

            MessageBox.Show($"Cantidad usuarios: {usuarios.Count}");

            printUsuario(usuarios);

            
            Usuarios usuarios = new Usuarios
            {
                Username = "francisco123",
                Password = "1234",
                Cedula = "64645435",
                Nombres = "Francisco",
                Apellidos = "Santos",
                Telefono = "8296300000",
                Correo = "francisco@gmail.com",
                Direccion = "Las cañitas",
                Sexo = "M",
                IDRol = 3
            };

            //context.Usuarios.Add(usuarios);
            
            
            if (DAOUsuario.RegistrarUsuario(usuarios) == 1)
            //if (context.SaveChanges() == 1)
            {
                MessageBox.Show("Guardado correctamente");
            } else
            {
                MessageBox.Show("No se guardo");

            }
            */

        }
        /*
        static public void printUsuario(List<Usuarios> us)
        {
            string cadena = "";

            foreach(Usuarios u in us)
            {
                cadena += $" {u.Id} {u.Nombres} {u.Apellidos}\n";
            }

            MessageBox.Show(cadena);
        }
        */
        /*
        static private void testCuenta()
        {
            Cuenta cuenta = new Cuenta
            {

            };
        }
        */
    }
}
