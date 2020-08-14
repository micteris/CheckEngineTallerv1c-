using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckEngineTaller.Modelo;
using CheckEngineTaller.Servicios;

namespace CheckEngineTaller.Formularios
{
    
    public partial class mClientes : Form
    {
        public ServiciosCliente ServiciosClientes = new ServiciosCliente();
        public mClientes()
        {
            InitializeComponent();
        }
        private void mClientes_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region helper
        private void refrescar()
        {
            try
            {
                var clientes = ServiciosClientes.getClientes();
                dataGridView1.DataSource = clientes;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private int? getid()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //agregar
            Gestion.gcliente gcliente = new Gestion.gcliente();
            gcliente.ShowDialog();

            refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //editar
            int? id = getid();
            if (id!=null)
            {
                Gestion.gcliente gcliente = new Gestion.gcliente(id);
                gcliente.ShowDialog();
                
                refrescar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //eliminar
            int? id = getid();
            if (id == null)
            {
                DisplayErrorSelect();
                return;
            }
            var respuesta = ServiciosClientes.EliminarCliente(id);

            if (respuesta==false)
            {
                DisplayError();
                return;
            }
            refrescar();
        }
        private void DisplayErrorSelect()
        {
            MessageBox.Show("Seleccione un Cliente.");
        }

        private void DisplayError()
        {
            MessageBox.Show("Ha ocurrido un error.");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
