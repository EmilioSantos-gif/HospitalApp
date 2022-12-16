
namespace Caja
{
    partial class frmPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnPagoAnalisis = new System.Windows.Forms.Button();
            this.btnPagoProcedimiento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalanceInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIniciarDia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Documento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(139, 123);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(135, 22);
            this.txtDocumentoCliente.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(30, 151);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(244, 41);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnPagoAnalisis
            // 
            this.btnPagoAnalisis.Location = new System.Drawing.Point(165, 214);
            this.btnPagoAnalisis.Name = "btnPagoAnalisis";
            this.btnPagoAnalisis.Size = new System.Drawing.Size(135, 63);
            this.btnPagoAnalisis.TabIndex = 4;
            this.btnPagoAnalisis.Text = "Pagar Analisis";
            this.btnPagoAnalisis.UseVisualStyleBackColor = true;
            this.btnPagoAnalisis.Click += new System.EventHandler(this.btnPagoAnalisis_Click);
            // 
            // btnPagoProcedimiento
            // 
            this.btnPagoProcedimiento.Location = new System.Drawing.Point(306, 214);
            this.btnPagoProcedimiento.Name = "btnPagoProcedimiento";
            this.btnPagoProcedimiento.Size = new System.Drawing.Size(137, 63);
            this.btnPagoProcedimiento.TabIndex = 5;
            this.btnPagoProcedimiento.Text = "Pagar Procedimiento";
            this.btnPagoProcedimiento.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido del cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(306, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(13, 17);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "-";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(306, 167);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(13, 17);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "-";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(30, 214);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 63);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refrescar balance";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Balance del dia";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(306, 43);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(13, 17);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "-";
            // 
            // txtBalanceInicio
            // 
            this.txtBalanceInicio.Location = new System.Drawing.Point(139, 26);
            this.txtBalanceInicio.Name = "txtBalanceInicio";
            this.txtBalanceInicio.Size = new System.Drawing.Size(135, 22);
            this.txtBalanceInicio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Balance Inicio";
            // 
            // btnIniciarDia
            // 
            this.btnIniciarDia.Location = new System.Drawing.Point(30, 54);
            this.btnIniciarDia.Name = "btnIniciarDia";
            this.btnIniciarDia.Size = new System.Drawing.Size(244, 41);
            this.btnIniciarDia.TabIndex = 15;
            this.btnIniciarDia.Text = "Iniciar dia";
            this.btnIniciarDia.UseVisualStyleBackColor = true;
            this.btnIniciarDia.Click += new System.EventHandler(this.btnIniciarDia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reporte de pagos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciarDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBalanceInicio);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPagoProcedimiento);
            this.Controls.Add(this.btnPagoAnalisis);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtDocumentoCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmPago";
            this.Text = "frmPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnPagoAnalisis;
        private System.Windows.Forms.Button btnPagoProcedimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalanceInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIniciarDia;
        private System.Windows.Forms.Button button1;
    }
}