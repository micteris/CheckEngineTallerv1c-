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
namespace CheckEngineTaller.Gestion
{
    public partial class gcliente : Form
    {
        public int? id;
        T_Cliente clitabla = null;
        public gcliente(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
        }
        private void CargaDatos()
        {
            using (DBTallerEntities2 db = new DBTallerEntities2())
            {
                clitabla = db.T_Cliente.Find(id);
                txtNombre1.Text = clitabla.CI_Nombre1;
                txtNombre2.Text = clitabla.CI_Nombre2;
                txtApellido1.Text = clitabla.CI_Apellido1;
                txtApellido2.Text = clitabla.CI_Apellido2;
                txtIdentidad.Text = clitabla.CI_Identificacion;
                txtTelefono.Text = clitabla.CI_Telefono;
                txtDireccion.Text = clitabla.CI_Direccion;
            }
        }
        private void btnGuardarCl_Click(object sender, EventArgs e)
        {
            using (DBTallerEntities2 db = new DBTallerEntities2())
            {
                if (id==null)
                    clitabla = new T_Cliente();

                //T_Cliente tcliente = new T_Cliente();
                clitabla.CI_Nombre1 = txtNombre1.Text;
                clitabla.CI_Nombre2 = txtNombre2.Text;
                clitabla.CI_Apellido1 = txtApellido1.Text;
                clitabla.CI_Apellido2 = txtApellido2.Text;
                clitabla.CI_Identificacion = txtIdentidad.Text;
                clitabla.CI_Telefono = txtTelefono.Text;
                clitabla.CI_Direccion = txtDireccion.Text;

                if(id==null)
                    db.T_Cliente.Add(clitabla);
                else
                {
                    db.Entry(clitabla).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();

                this.Close();

            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
