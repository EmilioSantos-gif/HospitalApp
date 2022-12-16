using Caja.HospitalServiceDBDataSetTableAdapters;
using Caja.IntegracionWebService;
using Microsoft.Reporting.WinForms;
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
    public partial class frmFactura : Form
    {
        public int idPago;
        public int idUsuario;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HospitalServiceDBDataSet.Pago' table. You can move, or remove it, as needed.
            //this.PagoTableAdapter.Fill(this.HospitalServiceDBDataSet.Pago);
            //this.rpvFactura.RefreshReport();

            rpvFactura.DataBindings.Clear();
            DataTable facturaDataTable = this.PagoTableAdapter.GetDataBy(idPago);

            UsuariosTableAdapter usuarioTableAdapter = new UsuariosTableAdapter();
            DataTable usuarioDataTable = usuarioTableAdapter.GetDataBy(idUsuario);

            ReportDataSource dataSourcePago = new ReportDataSource("DataSet1", (DataTable) facturaDataTable);
            ReportDataSource dataSourceUsuario = new ReportDataSource("DataSetUsuario", usuarioDataTable);

            rpvFactura.LocalReport.DataSources.Clear();
            rpvFactura.LocalReport.DataSources.Add(dataSourcePago);
            rpvFactura.LocalReport.DataSources.Add(dataSourceUsuario);

            this.rpvFactura.RefreshReport();
            //40219326994

        }
    }
}
