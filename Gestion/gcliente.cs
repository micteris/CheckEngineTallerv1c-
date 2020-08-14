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

namespace CheckEngineTaller.Gestion
{
    public partial class gcliente : Form
    {
        public int? id;
        T_Cliente clitabla = null;
        public gcliente(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                CargaDatos();
                btnGuardarCl.Visible = false;
                btnActualizarCl.Visible = true;
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
            try
            {

                var service = new ServiciosCliente();

                var tCliente = new T_Cliente
                {
                    CI_Nombre1 = txtNombre1.Text,
                    CI_Nombre2 = txtNombre2.Text,
                    CI_Apellido1 = txtApellido1.Text,
                    CI_Apellido2 = txtApellido2.Text,
                    CI_Identificacion = txtIdentidad.Text,
                    CI_Telefono = txtTelefono.Text,
                    CI_Direccion = txtDireccion.Text
                };

                service.AgregarCliente(tCliente);

                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarCl_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ServiciosCliente();

                var tCliente = new T_Cliente
                {
                    CI_ID = id.Value,
                    CI_Nombre1 = txtNombre1.Text,
                    CI_Nombre2 = txtNombre2.Text,
                    CI_Apellido1 = txtApellido1.Text,
                    CI_Apellido2 = txtApellido2.Text,
                    CI_Identificacion = txtIdentidad.Text,
                    CI_Telefono = txtTelefono.Text,
                    CI_Direccion = txtDireccion.Text
                };

                service.EditarCliente(tCliente);

                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
