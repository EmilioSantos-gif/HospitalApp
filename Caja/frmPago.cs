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
    public partial class frmPago : Form
    {
        //40219326994
        Paciente paciente = null;
        public frmPago()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cedula = txtDocumentoCliente.Text;
            paciente = buscarPaciente(cedula);

            if (paciente != null)
            {
                //TODO: Mostrar datos del paciente
                MessageBox.Show($"Bienvenido!");
            }

        }

        private Paciente buscarPaciente(string cedula)
        {
            IntegracionWebServiceSoapClient clientIntegracion = new IntegracionWebServiceSoapClient();

            Usuarios userPaciente = clientIntegracion.GetUsuarios().Where(u => u.Cedula == cedula).FirstOrDefault();

            if (userPaciente != null)
            {
                Paciente paciente = clientIntegracion.GetPacientes().Where(p => p.IdUsuario == userPaciente.Id).FirstOrDefault();
                if (paciente != null)
                {
                    lblNombre.Text = userPaciente.Nombres;
                    lblApellido.Text = userPaciente.Apellidos;
                    return paciente;
                }
                else
                {
                    MessageBox.Show("Este documento no corresponde a un paciente");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Numero de documento no registrado");
                return null;
            }
        }

        private void btnPagoAnalisis_Click(object sender, EventArgs e)
        {
            if (paciente != null)
            {
                frmPagoAnalisis frm = new frmPagoAnalisis (paciente);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe buscar un paciente");
            }
        }

        private void btnIniciarDia_Click(object sender, EventArgs e)
        {
            CajaDBEntities context = new CajaDBEntities();

            decimal balance;

            if(decimal.TryParse(txtBalanceInicio.Text, out balance))
            {
                Dia dia = context.Dia.Find(1);
                dia.Balance = balance;
                var a = context.SaveChanges();

                lblBalance.Text = balance.ToString();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CajaDBEntities context = new CajaDBEntities();
            Dia dia = context.Dia.Find(1);
            lblBalance.Text = dia.Balance.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportePagos frmReporte = new frmReportePagos();
            frmReporte.ShowDialog();
        }
    }
}
