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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            Form formulario = new AltaSocio();
            formulario.ShowDialog();
        }

        private void btnCargaActividad_Click(object sender, EventArgs e)
        {
            Form formulario = new AltaActividad();
            formulario.ShowDialog();
        }

        private void btnCobroCuota_Click(object sender, EventArgs e)
        {
            Form formulario = new CobroCuota();
            formulario.ShowDialog();
        }

        private void btnEntregaCarnet_Click(object sender, EventArgs e)
        {
            Form formulario = new Carnet();
            formulario.ShowDialog();
        }

        private void btnListadoVencimiento_Click(object sender, EventArgs e)
        {
            Form formulario = new ListadoDeudores();
            formulario.ShowDialog();
        }
    }
}
