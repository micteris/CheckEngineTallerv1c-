using CheckEngineTaller.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckEngineTaller.formularios
{
    public partial class principal : Form
    {
        public principal(string nombre)
        {
            InitializeComponent();
            lblidentificador.Text = nombre;
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void GestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mClientes mClientes = new mClientes();
            mClientes.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mVehiculos mVehiculos = new mVehiculos();
            mVehiculos.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mProyectos mProyectos = new mProyectos();
            mProyectos.Show();
        }

        private void estacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mEstacion mEstacion = new mEstacion();
            mEstacion.Show();
        }

        private void empToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mEmpleados mEmpleados = new mEmpleados();
            mEmpleados.Show();
        }

        private void mecanicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mMecanicos mMecanicos = new mMecanicos();
            mMecanicos.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mCaja mCaja = new mCaja();
            mCaja.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mProveedor mProveedor = new mProveedor();
            mProveedor.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mProductos mProductos = new mProductos();
            mProductos.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mPedidos mPedidos = new mPedidos();
            mPedidos.Show();
        }
    }
}
