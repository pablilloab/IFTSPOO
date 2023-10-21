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
            //Borro datos de Socio
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

            //Borro datos de Apto
            txtHistoriaM.Text = "";
            txtFecha.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Reviso que los campos no esten vacios
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtHistoriaM.Text == "" ||
                txtFecha.Text == "" || txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Todos los campos deben estar completos");
            }
            else
            {

                ESocio socio = new ESocio();
                socio.nombre = txtNombre.Text;
                socio.apellido = txtApellido.Text;
                socio.dni = int.Parse(txtDni.Text);
                socio.telefono = txtTelefono.Text;
                socio.email = txtEmail.Text;

                EApto apto = new EApto();
                apto.historiaM = txtHistoriaM.Text;
                apto.fecha = txtFecha.Text;
                apto.alto = decimal.Parse(txtAltura.Text);
                apto.peso = decimal.Parse(txtPeso.Text);

                //Llamada a Socio con el objeto socio.
                if (Socio.altaSocio(socio, apto))
                {
                    MessageBox.Show("Alta de Socio Exitosa");
                }
                else
                {
                    MessageBox.Show("Socio existente");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblAltaSocios_Click(object sender, EventArgs e)
        {

        }
    }
}
