using Caja.HospitalServiceDBDataSetTableAdapters;
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
    public partial class frmReportePagos : Form
    {
        public frmReportePagos()
        {
            InitializeComponent();
        }

        private void frmReportePagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HospitalServiceDBDataSet.PagoYUsuario' table. You can move, or remove it, as needed.
            //rpvPagos.DataBindings.Clear();
            //rpvPagos.LocalReport.DataSources.Clear();
            this.PagoYUsuarioTableAdapter.Fill(this.HospitalServiceDBDataSet.PagoYUsuario);
            //this.rpvPagos.RefreshReport
            //DataTable dataTable = this.PagoYUsuarioTableAdapter.GetDataByIdPago(idPago);

            //ReportDataSource dataSource = new ReportDataSource("DataSet1", (DataTable) dataTable);

            //rpvPagos.LocalReport.DataSources.Add(dataSource);

            this.rpvPagos.RefreshReport();
            //40219326994
        }

    }
}
