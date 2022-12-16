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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            MenuUsuarios mu = new MenuUsuarios();
            mu.Show();
        }
    }
}
