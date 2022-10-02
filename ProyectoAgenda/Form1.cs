using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Contacto contacto = new Contacto();
            dgvContactos.DataSource = contacto.ObtenerContactos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto();
                contacto.Nombre = txtNombre.Text;
                contacto.Email = txtEmail.Text;
                contacto.Telefono = txtTelefono.Text;
                contacto.Activo = chkActivo.Checked;
                contacto.AgregarContacto();
                MessageBox.Show("Contacto Agregado");

                dgvContactos.DataSource = null;
                dgvContactos.DataSource = contacto.ObtenerContactos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
