using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuario ru = new RegistrarUsuario();
            ru.MdiParent = this;
            ru.Show();
        }
    }
}
