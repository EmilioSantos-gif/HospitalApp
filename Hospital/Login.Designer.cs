namespace Hospital
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.Usuariolbl = new System.Windows.Forms.Label();
            this.PWlbl = new System.Windows.Forms.Label();
            this.PWTB = new System.Windows.Forms.TextBox();
            this.IngresarBTN = new System.Windows.Forms.Button();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.VPWCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsuarioTB.Location = new System.Drawing.Point(74, 195);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(181, 26);
            this.UsuarioTB.TabIndex = 0;
            // 
            // Usuariolbl
            // 
            this.Usuariolbl.AutoSize = true;
            this.Usuariolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Usuariolbl.Location = new System.Drawing.Point(71, 172);
            this.Usuariolbl.Name = "Usuariolbl";
            this.Usuariolbl.Size = new System.Drawing.Size(64, 20);
            this.Usuariolbl.TabIndex = 1;
            this.Usuariolbl.Text = "Usuario";
            // 
            // PWlbl
            // 
            this.PWlbl.AutoSize = true;
            this.PWlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PWlbl.Location = new System.Drawing.Point(71, 225);
            this.PWlbl.Name = "PWlbl";
            this.PWlbl.Size = new System.Drawing.Size(92, 20);
            this.PWlbl.TabIndex = 3;
            this.PWlbl.Text = "Contraseña";
            // 
            // PWTB
            // 
            this.PWTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PWTB.Location = new System.Drawing.Point(74, 248);
            this.PWTB.Name = "PWTB";
            this.PWTB.PasswordChar = '*';
            this.PWTB.Size = new System.Drawing.Size(181, 26);
            this.PWTB.TabIndex = 2;
            // 
            // IngresarBTN
            // 
            this.IngresarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IngresarBTN.Location = new System.Drawing.Point(175, 303);
            this.IngresarBTN.Name = "IngresarBTN";
            this.IngresarBTN.Size = new System.Drawing.Size(80, 29);
            this.IngresarBTN.TabIndex = 4;
            this.IngresarBTN.Text = "Ingresar";
            this.IngresarBTN.UseVisualStyleBackColor = true;
            this.IngresarBTN.Click += new System.EventHandler(this.IngresarBTN_Click);
            // 
            // LogoPB
            // 
            this.LogoPB.Image = ((System.Drawing.Image)(resources.GetObject("LogoPB.Image")));
            this.LogoPB.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoPB.InitialImage")));
            this.LogoPB.Location = new System.Drawing.Point(74, 30);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(181, 129);
            this.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPB.TabIndex = 5;
            this.LogoPB.TabStop = false;
            // 
            // VPWCB
            // 
            this.VPWCB.AutoSize = true;
            this.VPWCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VPWCB.Location = new System.Drawing.Point(75, 280);
            this.VPWCB.Name = "VPWCB";
            this.VPWCB.Size = new System.Drawing.Size(99, 17);
            this.VPWCB.TabIndex = 7;
            this.VPWCB.Text = "Ver Contraseña";
            this.VPWCB.UseVisualStyleBackColor = true;
            this.VPWCB.CheckedChanged += new System.EventHandler(this.VPWCB_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.VPWCB);
            this.Controls.Add(this.LogoPB);
            this.Controls.Add(this.IngresarBTN);
            this.Controls.Add(this.PWlbl);
            this.Controls.Add(this.PWTB);
            this.Controls.Add(this.Usuariolbl);
            this.Controls.Add(this.UsuarioTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.Label Usuariolbl;
        private System.Windows.Forms.Label PWlbl;
        private System.Windows.Forms.TextBox PWTB;
        private System.Windows.Forms.Button IngresarBTN;
        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.CheckBox VPWCB;
    }
}

