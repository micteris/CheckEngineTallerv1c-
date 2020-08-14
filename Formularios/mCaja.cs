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
//using CheckEngineTaller.Servicios;

namespace CheckEngineTaller.Formularios
{
    public partial class mCaja : Form
    {
        public int? id;
        T_Empleado Oprovedor = null;
        public mCaja()
        {
            InitializeComponent();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region helper
        private void refrescar()
        {
            using (DBTallerEntities2 db = new DBTallerEntities2())
            {
                var ls = from d in db.T_Caja
                         select d;
                dataGridView1.DataSource = ls.ToList();
            }
            /*
            try
            {
               // var caja = Servicios.getServicios();
               // dataGridView1.DataSource = caja;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
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
            Gestion.gCajacs gCaja = new Gestion.gCajacs();
            gCaja.ShowDialog();
            refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*//editar
            int? id = getid();
            if (id!=null)
            {
                Gestion.gCajacs frmtabla = new Gestion.gCajacs(id);
                frmtabla.ShowDialog();

                //refrescar();
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //eliminar
            /*
            int? id = getid();
            if (id == null)
            {
                DisplayErrorSeleccion();
                return;
            }
            DisplayError();
            var resp*/
        }
    }
}
