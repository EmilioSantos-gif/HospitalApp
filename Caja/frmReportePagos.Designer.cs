
namespace Caja
{
    partial class frmReportePagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvPagos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HospitalServiceDBDataSet = new Caja.HospitalServiceDBDataSet();
            this.PagoYUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagoYUsuarioTableAdapter = new Caja.HospitalServiceDBDataSetTableAdapters.PagoYUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalServiceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagoYUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvPagos
            // 
            this.rpvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PagoYUsuarioBindingSource;
            this.rpvPagos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPagos.LocalReport.ReportEmbeddedResource = "Caja.rptPagos.rdlc";
            this.rpvPagos.Location = new System.Drawing.Point(0, 0);
            this.rpvPagos.Name = "rpvPagos";
            this.rpvPagos.ServerReport.BearerToken = null;
            this.rpvPagos.Size = new System.Drawing.Size(1215, 507);
            this.rpvPagos.TabIndex = 0;
            // 
            // HospitalServiceDBDataSet
            // 
            this.HospitalServiceDBDataSet.DataSetName = "HospitalServiceDBDataSet";
            this.HospitalServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagoYUsuarioBindingSource
            // 
            this.PagoYUsuarioBindingSource.DataMember = "PagoYUsuario";
            this.PagoYUsuarioBindingSource.DataSource = this.HospitalServiceDBDataSet;
            // 
            // PagoYUsuarioTableAdapter
            // 
            this.PagoYUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 507);
            this.Controls.Add(this.rpvPagos);
            this.Name = "frmReportePagos";
            this.Text = "frmReportePagos";
            this.Load += new System.EventHandler(this.frmReportePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalServiceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagoYUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPagos;
        private System.Windows.Forms.BindingSource PagoYUsuarioBindingSource;
        private HospitalServiceDBDataSet HospitalServiceDBDataSet;
        private HospitalServiceDBDataSetTableAdapters.PagoYUsuarioTableAdapter PagoYUsuarioTableAdapter;
    }
}