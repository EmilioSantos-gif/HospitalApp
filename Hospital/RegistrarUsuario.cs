using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class RegistrarUsuario : Form
    {
        public int viewPW = 0;
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void Registrobtn_Click(object sender, EventArgs e)
        {
            try
            {
                CWS.CoreWebServiceSoapClient CWSSC = new CWS.CoreWebServiceSoapClient();
                CWS.Usuarios usuario = new CWS.Usuarios();

                usuario.Nombres = NombreTB.Text;
                usuario.Apellidos = ApellidoTB.Text;
                usuario.Cedula = CedulaTB.Text;
                usuario.Sexo = SRCB.SelectedIndex.ToString();
                usuario.Telefono = TelTB.Text;
                usuario.Direccion = DirTB.Text;

                CWS.Usuarios user = CWSSC.GetUsuarios().Where(u => u.Username == usrNameTB.Text).ToList().FirstOrDefault();

                if (null == user)
                {
                    usuario.Username = usrNameTB.Text;
                } else
                {
                        MessageBox.Show("Mensaje del Sistema",
                                        "¡El nombre de usuario ingresado ya existe!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        throw new Exception("¡El usuario ya existe!");
                }



                //bregando lo de la contraseña

                bool verificacion = validation(PWTB.Text, CPWTB.Text);

                if (!verificacion)
                {
                    usuario.Password = Login.ComputeHash(PWTB.Text);

                    usuario.IDRol = 1;
                    usuario.Estado = true;
                    usuario.Correo = CorreoTB.Text;

                    if(CWSSC.RegistrarUsuarios(usuario) > 0)
                    {
                        MessageBox.Show("Usuario registrado satisfactoriamente");
                    } else
                    {
                        MessageBox.Show("Hubo un problema al registrar el usuario");
                    }

                }
                else
                {
                    MessageBox.Show("Mensaje del Sistema",
                                    "Revise que cumpla los requerimientos siguientes: " +
                                    "- Ambos campos de contraseña coinciden" +
                                    "- Tiene más de 8 caracteres" +
                                    "- Contiene Mayúsculas" +
                                    "- Contiene Números y caracteres especiales ",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    throw new Exception("Contraseña no cumple con los parámetros mínimos");
                }
                    
            } catch
            {

            }

        }
        private static bool validation(string pw, string pwc)
        {
            string specialCh = "0123456789"+@"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();

            foreach (char ch in specialChArray)
            {
                if (pw.Contains(ch))
                    return true;
                else
                    return false;
            }
            if (pw.Length < 8 || pw.Length > 14)
                return false;
            else if (!pw.Any(char.IsUpper))
                return false;
            else if (!pw.Any(char.IsLower))
                return false;
            else if (pw.Contains(" "))
                return false;
            else if (pw != pwc)
                return false;
            else
                return true;
            
            
        }

        private void ShowPWCB_CheckedChanged(object sender, EventArgs e)
        {
            switch (viewPW)
            {
                case 0:
                    PWTB.PasswordChar = '\0';
                    CPWTB.PasswordChar = '\0';
                    viewPW = 1;
                    break;
                case 1:
                    PWTB.PasswordChar = '*';
                    CPWTB.PasswordChar = '*';
                    viewPW = 0;
                    break;
            }
        }
    }
}
