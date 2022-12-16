namespace Hospital
{
    partial class MainMenu
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
            this.Usuariosbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usuariosbtn
            // 
            this.Usuariosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Usuariosbtn.Location = new System.Drawing.Point(80, 59);
            this.Usuariosbtn.Name = "Usuariosbtn";
            this.Usuariosbtn.Size = new System.Drawing.Size(196, 28);
            this.Usuariosbtn.TabIndex = 0;
            this.Usuariosbtn.Text = "Usuarios";
            this.Usuariosbtn.UseVisualStyleBackColor = true;
            this.Usuariosbtn.Click += new System.EventHandler(this.Usuariosbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Usuariosbtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(80, 301);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(196, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "Cuentas y transacciones";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(80, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "Autorizaciones";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(80, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "Ingresos y Altas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(80, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Análisis";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(80, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Procedimientos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(80, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cuentas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(80, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pacientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el panel de administración deseado:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 381);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Usuariosbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}