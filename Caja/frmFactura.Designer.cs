
namespace Caja
{
    partial class frmFactura
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
            this.PagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalServiceDBDataSet = new Caja.HospitalServiceDBDataSet();
            this.rpvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PagoTableAdapter = new Caja.HospitalServiceDBDataSetTableAdapters.PagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalServiceDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PagoBindingSource
            // 
            this.PagoBindingSource.DataMember = "Pago";
            this.PagoBindingSource.DataSource = this.HospitalServiceDBDataSet;
            // 
            // HospitalServiceDBDataSet
            // 
            this.HospitalServiceDBDataSet.DataSetName = "HospitalServiceDBDataSet";
            this.HospitalServiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvFactura
            // 
            this.rpvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PagoBindingSource;
            this.rpvFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFactura.LocalReport.ReportEmbeddedResource = "Caja.rptFactura.rdlc";
            this.rpvFactura.Location = new System.Drawing.Point(0, 0);
            this.rpvFactura.Name = "rpvFactura";
            this.rpvFactura.ServerReport.BearerToken = null;
            this.rpvFactura.Size = new System.Drawing.Size(922, 727);
            this.rpvFactura.TabIndex = 0;
            // 
            // PagoTableAdapter
            // 
            this.PagoTableAdapter.ClearBeforeFill = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 727);
            this.Controls.Add(this.rpvFactura);
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalServiceDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFactura;
        private System.Windows.Forms.BindingSource PagoBindingSource;
        private HospitalServiceDBDataSet HospitalServiceDBDataSet;
        private HospitalServiceDBDataSetTableAdapters.PagoTableAdapter PagoTableAdapter;
    }
}