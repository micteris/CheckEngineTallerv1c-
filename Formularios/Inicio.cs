using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Permissions;
using CheckEngineTaller.formularios;
using CheckEngineTaller.Gestion;
//using CheckEngineTaller.model;

namespace CheckEngineTaller
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=DBTaller;Integrated Security=True");
        public void log(string Usuario, string Password)
        {
            try
            {
                connect.Open();
                SqlCommand comm = new SqlCommand("Select E_Usuario from T_Empleado where E_Usuario = @usuario and E_Password = @contra", connect);
                comm.Parameters.AddWithValue("usuario", Usuario);
                comm.Parameters.AddWithValue("contra", Password);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    var principal = new principal(dt.Rows[0][0].ToString());
                    principal.Show();                 
                }
                else
                {
                    MessageBox.Show("Usuario o Password erroneo");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
            }
            finally
            {
                connect.Close();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log(this.txtUsuario.Text, this.txtPassword.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(((Int32)Keys.Enter)))
                txtPassword.Focus();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            gPassword gPassword = new gPassword();
            gPassword.Show();
        }
    }
}
