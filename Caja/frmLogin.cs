using Caja.IntegracionWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frmLogin : Form
    {
        IntegracionWebServiceSoapClient clientIntegracion = new IntegracionWebServiceSoapClient();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuariotext, clave;

            usuariotext = txtUsuario.Text;
            clave = txtPassword.Text;

            Usuarios usuario = clientIntegracion.GetUsuarios()
                .Where(u => u.Username == usuariotext && u.Password == clave)
                .ToList()
                .FirstOrDefault();

            if (null != usuario)
            {
                frmPago pago = new frmPago();
                pago.ShowDialog();
            } else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
