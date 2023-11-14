using MySql.Data.MySqlClient;
using S04PF1.Data;
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
    public partial class ConfirmarPago : Form
    {
        public int IdCuota { get; }
        public DateTime Fecha { get; }
        public double Monto { get; }
        public string MedioPago { get; }

        public ConfirmarPago(int idCuota, DateTime fecha, double monto, string medioPago)
        {
            InitializeComponent();
            IdCuota = idCuota;
            Fecha = fecha;
            Monto = monto;
            MedioPago = medioPago;
        }

        private void lblCobroCuota_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmarPago_Load(object sender, EventArgs e)
        {
            lblFechaPago.Text = Fecha.ToString();
            lblMonto.Text = Monto.ToString();
            lblMedioPago.Text = MedioPago;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chk3Cuotas_CheckedChanged(object sender, EventArgs e)
        {
            double calcularDescuento = 0;

            if (chk3Cuotas.Checked)
            {
                if (double.TryParse(lblMonto.Text, out calcularDescuento))
                {
                    calcularDescuento -= calcularDescuento * 0.15;
                    lblMonto.Text = calcularDescuento.ToString();
                    lblMedioPago.Text = "cuotas";
                }
            }
            else
            {
                lblMonto.Text = Monto.ToString();
                lblMedioPago.Text = "contado";
            }


        }

        private void chk6Cuotas_CheckedChanged(object sender, EventArgs e)
        {
            double calcularDescuento = 0;

            if (chk6Cuotas.Checked)
            {
                if (double.TryParse(lblMonto.Text, out calcularDescuento))
                {
                    calcularDescuento -= calcularDescuento * 0.05;
                    lblMonto.Text = calcularDescuento.ToString();
                    lblMedioPago.Text = "cuotas";
                }
            }
            else
            {
                lblMonto.Text = Monto.ToString();
                lblMonto.Text = "contado";
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                //Parseo monto y fecha para poder ser utlizados en el update

                double.TryParse(lblMonto.Text, out double monto);
                string fecha = Fecha.ToString("yyyy-MM-dd");

                string query = $"update cuota set monto = {monto}, medioPago = '{MedioPago}', pagoRealizado = 1 where idCuota = {IdCuota} and fechaPago = '{fecha}';";

                //creo el command e indico que tipo de comando es
                MySqlCommand cmd = new MySqlCommand(query, con.getConnection());
                cmd.CommandType = CommandType.Text;

                //Abro conexion
                if (con.getConnection() != null)
                {
                    con.openConnection();
                }

                int actualizado = cmd.ExecuteNonQuery();

                if (actualizado > 0)
                {
                    MessageBox.Show("Pago Realizado", "Ok");
                }
                else
                {
                    MessageBox.Show("El Pago no se realizo", "Error");
                }

    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);
            }
        }
    }
}
