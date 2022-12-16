namespace Hospital
{
    partial class RegistrarUsuario
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
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.SRCB = new System.Windows.Forms.ComboBox();
            this.LeerGB = new System.Windows.Forms.GroupBox();
            this.Dirlbl = new System.Windows.Forms.Label();
            this.DirTB = new System.Windows.Forms.TextBox();
            this.Tellbl = new System.Windows.Forms.Label();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.SexoCB = new System.Windows.Forms.Label();
            this.Cedulalbl = new System.Windows.Forms.Label();
            this.CedulaTB = new System.Windows.Forms.TextBox();
            this.Apellidolbl = new System.Windows.Forms.Label();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsrGB = new System.Windows.Forms.GroupBox();
            this.Registrobtn = new System.Windows.Forms.Button();
            this.CPWlbl = new System.Windows.Forms.Label();
            this.CPWTB = new System.Windows.Forms.TextBox();
            this.ShowPWCB = new System.Windows.Forms.CheckBox();
            this.PWlbl = new System.Windows.Forms.Label();
            this.PWTB = new System.Windows.Forms.TextBox();
            this.usrNameTB = new System.Windows.Forms.TextBox();
            this.usrNamelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoTB = new System.Windows.Forms.TextBox();
            this.LeerGB.SuspendLayout();
            this.UsrGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nombrelbl.Location = new System.Drawing.Point(20, 23);
            this.Nombrelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(91, 25);
            this.Nombrelbl.TabIndex = 0;
            this.Nombrelbl.Text = "Nombres";
            // 
            // NombreTB
            // 
            this.NombreTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NombreTB.Location = new System.Drawing.Point(25, 52);
            this.NombreTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(347, 30);
            this.NombreTB.TabIndex = 1;
            // 
            // SRCB
            // 
            this.SRCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SRCB.FormattingEnabled = true;
            this.SRCB.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SRCB.Location = new System.Drawing.Point(25, 244);
            this.SRCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SRCB.Name = "SRCB";
            this.SRCB.Size = new System.Drawing.Size(91, 33);
            this.SRCB.TabIndex = 2;
            // 
            // LeerGB
            // 
            this.LeerGB.Controls.Add(this.CorreoTB);
            this.LeerGB.Controls.Add(this.label3);
            this.LeerGB.Controls.Add(this.Dirlbl);
            this.LeerGB.Controls.Add(this.DirTB);
            this.LeerGB.Controls.Add(this.Tellbl);
            this.LeerGB.Controls.Add(this.TelTB);
            this.LeerGB.Controls.Add(this.SexoCB);
            this.LeerGB.Controls.Add(this.Cedulalbl);
            this.LeerGB.Controls.Add(this.CedulaTB);
            this.LeerGB.Controls.Add(this.Apellidolbl);
            this.LeerGB.Controls.Add(this.ApellidoTB);
            this.LeerGB.Controls.Add(this.Nombrelbl);
            this.LeerGB.Controls.Add(this.SRCB);
            this.LeerGB.Controls.Add(this.NombreTB);
            this.LeerGB.Location = new System.Drawing.Point(16, 27);
            this.LeerGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeerGB.Name = "LeerGB";
            this.LeerGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeerGB.Size = new System.Drawing.Size(411, 482);
            this.LeerGB.TabIndex = 3;
            this.LeerGB.TabStop = false;
            // 
            // Dirlbl
            // 
            this.Dirlbl.AutoSize = true;
            this.Dirlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dirlbl.Location = new System.Drawing.Point(20, 357);
            this.Dirlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dirlbl.Name = "Dirlbl";
            this.Dirlbl.Size = new System.Drawing.Size(93, 25);
            this.Dirlbl.TabIndex = 11;
            this.Dirlbl.Text = "Dirección";
            // 
            // DirTB
            // 
            this.DirTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DirTB.Location = new System.Drawing.Point(25, 385);
            this.DirTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DirTB.Multiline = true;
            this.DirTB.Name = "DirTB";
            this.DirTB.Size = new System.Drawing.Size(347, 85);
            this.DirTB.TabIndex = 12;
            // 
            // Tellbl
            // 
            this.Tellbl.AutoSize = true;
            this.Tellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tellbl.Location = new System.Drawing.Point(20, 293);
            this.Tellbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tellbl.Name = "Tellbl";
            this.Tellbl.Size = new System.Drawing.Size(89, 25);
            this.Tellbl.TabIndex = 9;
            this.Tellbl.Text = "Telefono";
            // 
            // TelTB
            // 
            this.TelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TelTB.Location = new System.Drawing.Point(25, 321);
            this.TelTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(347, 30);
            this.TelTB.TabIndex = 10;
            // 
            // SexoCB
            // 
            this.SexoCB.AutoSize = true;
            this.SexoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SexoCB.Location = new System.Drawing.Point(20, 215);
            this.SexoCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SexoCB.Name = "SexoCB";
            this.SexoCB.Size = new System.Drawing.Size(58, 25);
            this.SexoCB.TabIndex = 7;
            this.SexoCB.Text = "Sexo";
            // 
            // Cedulalbl
            // 
            this.Cedulalbl.AutoSize = true;
            this.Cedulalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cedulalbl.Location = new System.Drawing.Point(20, 151);
            this.Cedulalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cedulalbl.Name = "Cedulalbl";
            this.Cedulalbl.Size = new System.Drawing.Size(75, 25);
            this.Cedulalbl.TabIndex = 5;
            this.Cedulalbl.Text = "Cédula";
            // 
            // CedulaTB
            // 
            this.CedulaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CedulaTB.Location = new System.Drawing.Point(25, 180);
            this.CedulaTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CedulaTB.Name = "CedulaTB";
            this.CedulaTB.Size = new System.Drawing.Size(347, 30);
            this.CedulaTB.TabIndex = 6;
            // 
            // Apellidolbl
            // 
            this.Apellidolbl.AutoSize = true;
            this.Apellidolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Apellidolbl.Location = new System.Drawing.Point(20, 87);
            this.Apellidolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Apellidolbl.Name = "Apellidolbl";
            this.Apellidolbl.Size = new System.Drawing.Size(92, 25);
            this.Apellidolbl.TabIndex = 3;
            this.Apellidolbl.Text = "Apellidos";
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ApellidoTB.Location = new System.Drawing.Point(25, 116);
            this.ApellidoTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(347, 30);
            this.ApellidoTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datos personales";
            // 
            // UsrGB
            // 
            this.UsrGB.Controls.Add(this.Registrobtn);
            this.UsrGB.Controls.Add(this.CPWlbl);
            this.UsrGB.Controls.Add(this.CPWTB);
            this.UsrGB.Controls.Add(this.ShowPWCB);
            this.UsrGB.Controls.Add(this.PWlbl);
            this.UsrGB.Controls.Add(this.PWTB);
            this.UsrGB.Controls.Add(this.usrNameTB);
            this.UsrGB.Controls.Add(this.usrNamelbl);
            this.UsrGB.Location = new System.Drawing.Point(435, 27);
            this.UsrGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsrGB.Name = "UsrGB";
            this.UsrGB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsrGB.Size = new System.Drawing.Size(388, 482);
            this.UsrGB.TabIndex = 10;
            this.UsrGB.TabStop = false;
            // 
            // Registrobtn
            // 
            this.Registrobtn.BackColor = System.Drawing.Color.YellowGreen;
            this.Registrobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Registrobtn.Location = new System.Drawing.Point(237, 407);
            this.Registrobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Registrobtn.Name = "Registrobtn";
            this.Registrobtn.Size = new System.Drawing.Size(131, 46);
            this.Registrobtn.TabIndex = 20;
            this.Registrobtn.Text = "Guardar";
            this.Registrobtn.UseVisualStyleBackColor = false;
            this.Registrobtn.Click += new System.EventHandler(this.Registrobtn_Click);
            // 
            // CPWlbl
            // 
            this.CPWlbl.AutoSize = true;
            this.CPWlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CPWlbl.Location = new System.Drawing.Point(15, 151);
            this.CPWlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPWlbl.Name = "CPWlbl";
            this.CPWlbl.Size = new System.Drawing.Size(204, 25);
            this.CPWlbl.TabIndex = 18;
            this.CPWlbl.Text = "Confirmar Contraseña";
            // 
            // CPWTB
            // 
            this.CPWTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CPWTB.Location = new System.Drawing.Point(20, 180);
            this.CPWTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CPWTB.Name = "CPWTB";
            this.CPWTB.PasswordChar = '*';
            this.CPWTB.Size = new System.Drawing.Size(347, 30);
            this.CPWTB.TabIndex = 19;
            // 
            // ShowPWCB
            // 
            this.ShowPWCB.AutoSize = true;
            this.ShowPWCB.Location = new System.Drawing.Point(20, 229);
            this.ShowPWCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowPWCB.Name = "ShowPWCB";
            this.ShowPWCB.Size = new System.Drawing.Size(155, 21);
            this.ShowPWCB.TabIndex = 17;
            this.ShowPWCB.Text = "Mostrar Contraseña";
            this.ShowPWCB.UseVisualStyleBackColor = true;
            this.ShowPWCB.CheckedChanged += new System.EventHandler(this.ShowPWCB_CheckedChanged);
            // 
            // PWlbl
            // 
            this.PWlbl.AutoSize = true;
            this.PWlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PWlbl.Location = new System.Drawing.Point(15, 87);
            this.PWlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PWlbl.Name = "PWlbl";
            this.PWlbl.Size = new System.Drawing.Size(114, 25);
            this.PWlbl.TabIndex = 15;
            this.PWlbl.Text = "Contraseña";
            // 
            // PWTB
            // 
            this.PWTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PWTB.Location = new System.Drawing.Point(20, 116);
            this.PWTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PWTB.Name = "PWTB";
            this.PWTB.PasswordChar = '*';
            this.PWTB.Size = new System.Drawing.Size(347, 30);
            this.PWTB.TabIndex = 16;
            // 
            // usrNameTB
            // 
            this.usrNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrNameTB.Location = new System.Drawing.Point(20, 52);
            this.usrNameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrNameTB.Name = "usrNameTB";
            this.usrNameTB.Size = new System.Drawing.Size(347, 30);
            this.usrNameTB.TabIndex = 14;
            // 
            // usrNamelbl
            // 
            this.usrNamelbl.AutoSize = true;
            this.usrNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrNamelbl.Location = new System.Drawing.Point(15, 23);
            this.usrNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usrNamelbl.Name = "usrNamelbl";
            this.usrNamelbl.Size = new System.Drawing.Size(177, 25);
            this.usrNamelbl.TabIndex = 13;
            this.usrNamelbl.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datos de Inicio de sesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(155, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo";
            // 
            // CorreoTB
            // 
            this.CorreoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CorreoTB.Location = new System.Drawing.Point(160, 247);
            this.CorreoTB.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoTB.Name = "CorreoTB";
            this.CorreoTB.Size = new System.Drawing.Size(212, 30);
            this.CorreoTB.TabIndex = 12;
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsrGB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeerGB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.LeerGB.ResumeLayout(false);
            this.LeerGB.PerformLayout();
            this.UsrGB.ResumeLayout(false);
            this.UsrGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombrelbl;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.ComboBox SRCB;
        private System.Windows.Forms.GroupBox LeerGB;
        private System.Windows.Forms.Label Apellidolbl;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.Label SexoCB;
        private System.Windows.Forms.Label Cedulalbl;
        private System.Windows.Forms.TextBox CedulaTB;
        private System.Windows.Forms.Label Dirlbl;
        private System.Windows.Forms.TextBox DirTB;
        private System.Windows.Forms.Label Tellbl;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UsrGB;
        private System.Windows.Forms.CheckBox ShowPWCB;
        private System.Windows.Forms.Label PWlbl;
        private System.Windows.Forms.TextBox PWTB;
        private System.Windows.Forms.TextBox usrNameTB;
        private System.Windows.Forms.Label usrNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registrobtn;
        private System.Windows.Forms.Label CPWlbl;
        private System.Windows.Forms.TextBox CPWTB;
        private System.Windows.Forms.TextBox CorreoTB;
        private System.Windows.Forms.Label label3;
    }
}