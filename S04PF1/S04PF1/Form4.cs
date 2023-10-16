using S04PF1.Data;
using S04PF1.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S04PF1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Limpia los campos del ingreso con cadena vacia.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Reviso que los campos no esten vacios
            if(txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar completos");
            }
            else
            {

                ESocio socio = new ESocio();
                socio.nombre = txtNombre.Text;
                socio.apellido = txtApellido.Text;
                socio.dni = txtDni.Text;
                socio.telefono = txtTelefono.Text;
                socio.email = txtEmail.Text;

                //Llamada a Socio con el objeto socio.
                if(Socio.altaSocio(socio))
                {
                    MessageBox.Show("Alta de Socio Exitosa");
                }
                else
                {
                    MessageBox.Show("Socio existente");
                }
            }
        }
    }
}
