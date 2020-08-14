using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckEngineTaller.Formularios
{
    public partial class mPedidos : Form
    {
        public mPedidos()
        {
            InitializeComponent();
        }

        private void refresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
