using Hospital.CWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    
    public partial class Login : Form
    {
        public int viewPW = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void IngresarBTN_Click(object sender, EventArgs e)
        {

            //Comparar las credenciales de los usuarios
            //HostpitalDBEntities db = new HostpitalDBEntities();

            CoreWebServiceSoapClient coreClient = new CoreWebServiceSoapClient();


            MainMenu mm = new MainMenu();
            Login lg = new Login();

            string usr = UsuarioTB.Text;
            string correo = UsuarioTB.Text;
            string pwhash = ComputeHash(PWTB.Text);

            Usuarios usuario = coreClient.GetUsuarios()
                .Where(u => u.Username == usr && u.Password == pwhash)
                .ToList()
                .FirstOrDefault();            
            
            if (null != usuario)
            {
                MessageBox.Show("Acceso Correcto. ¡Bienvenido!",
                                "Mensaje del sistema",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);

                
                lg.Hide();
                mm.Show();
            }
            else
            {
                MessageBox.Show("El usuario y la contraseña ingresada " +
                                "no coinciden con nuestros registros. "+
                                "Por favor, valide los datos e intente de nuevo", 
                                "Mensaje del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            
            
        }
        public static string ComputeHash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void VPWRB_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void VPWCB_CheckedChanged(object sender, EventArgs e)
        {
            switch (viewPW)
            {
                case 0:
                    PWTB.PasswordChar = '\0';
                    viewPW = 1;
                    break;
                case 1:
                    PWTB.PasswordChar = '*';
                    viewPW = 0;
                    break;
            }
        }
    }
}
