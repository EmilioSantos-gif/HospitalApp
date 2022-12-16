using Caja.IntegracionWebService;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class frmPagoAnalisis : Form
    {
        //40219326994
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        Paciente pacienteGlobal;
        IntegracionWebServiceSoapClient clientIntegracion = new IntegracionWebServiceSoapClient();

        public frmPagoAnalisis(Paciente paciente)
        {
            InitializeComponent();
            this.pacienteGlobal = paciente;
            List<Analisis> analisis = clientIntegracion.GetAnalisis1().Where(a => a.NumHistMedico == paciente.NumHistMedico).ToList();
            DataTable tableAanalisis = ToDataTable<Analisis>(analisis);

            dgvAnalisis.DataSource = tableAanalisis;
        }

        public DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        //pago analisis
        private void button1_Click(object sender, EventArgs e)
        {
            var cellValue = dgvAnalisis.CurrentRow.Cells["IdAnalisis"].Value;
            if (cellValue != null)
            {
                int idAnalsis = int.Parse(cellValue.ToString());
                Analisis analisis = clientIntegracion.GetAnalisis(idAnalsis);
                analisis.Pago = "1";
                clientIntegracion.UpdateAnalisis(analisis);

                List<Analisis> analisisList = clientIntegracion.GetAnalisis1().Where(a => a.NumHistMedico == pacienteGlobal.NumHistMedico).ToList();
                DataTable tableAanalisis = ToDataTable<Analisis>(analisisList);

                dgvAnalisis.DataSource = tableAanalisis;

                CajaDBEntities ctx = new CajaDBEntities();

                Dia dia = ctx.Dia.Find(1);
                dia.Balance += analisis.Monto;
                ctx.SaveChanges();

                //actuzalizar balance en BD
                if (ctx.SaveChanges() > 0)
                {
                    log.Info($"Se pago el analisis de ID {analisis.IdAnalisis} por un monto de {analisis.Monto}");
                }


                //regsitrar pago

                Pago pago = new Pago
                {
                    NumHistMedico = pacienteGlobal.NumHistMedico,
                    Monto = analisis.Monto,
                    IsWeb = "0"
                };

                if (clientIntegracion.RegistrarPago(pago) > 0)
                {
                    log.Info($"Se registro un pago por el paciento ID {pacienteGlobal.IdPaciente} por un monto de {pago.Monto}");

                    Pago pagoRegistrado = clientIntegracion.GetPagos().OrderByDescending(p => p.IdPago).First();
                    //generar reporte 
                    frmFactura factura = new frmFactura();
                    factura.idPago = pagoRegistrado.IdPago;
                    factura.idUsuario = pacienteGlobal.IdUsuario;
                    factura.ShowDialog();
                }

            }
        }
    }
}
