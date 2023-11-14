using MySql.Data.MySqlClient;
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
    public partial class CobroCuota : Form
    {
        public CobroCuota()
        {
            InitializeComponent();
        }

        private void lblAltaActividad_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Busca las cuotas del socio ingresado y las carga en el DATAGRID
            if (int.TryParse(txtCodSocio.Text, out int id))
            {
                Connection con = new Connection();
                try
                {
                    string query = $"select c.fechaPago, c.monto, c.medioPago, c.pagoRealizado from cuota c inner join inscripcion i where i.idSocio = {id} and c.idCuota = i.idCuota;";

                    //creo el command e indico que tipo de comando es
                    MySqlCommand cmd = new MySqlCommand(query, con.getConnection());
                    cmd.CommandType = CommandType.Text;

                    //Abro conexion
                    if (con.getConnection() != null)
                    {
                        con.openConnection();
                    }

                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int row = dtgvCuota.Rows.Add();
                            dtgvCuota.Rows[row].Cells[0].Value = reader.GetString(0);
                            dtgvCuota.Rows[row].Cells[1].Value = reader.GetString(1);
                            dtgvCuota.Rows[row].Cells[2].Value = reader.GetString(2);
                            dtgvCuota.Rows[row].Cells[3].Value = reader.GetString(3);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existen cuotas - CONTACTE A SOPORTE");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception", ex.Message);
                }
                //*********************************
            }
            else
            {
                MessageBox.Show("Codigo de socio inválido", "Algo salió mal");
            }

        }

        private void dtgvCuota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //abro el formulario con los datos de la cuota seleccionada para registrar el pago
            //se tiene en cuanta bonificaciones por pago en 3 y 6 cuotas
            int rowNumber = e.RowIndex;
            if (rowNumber != -1)
            {
                //guardo los datos de la cuota

                string fecha = dtgvCuota.Rows[rowNumber].Cells[0].Value.ToString();
                double.TryParse(dtgvCuota.Rows[rowNumber].Cells[1].Value.ToString(), out double monto);
                string medioPago = dtgvCuota.Rows[rowNumber].Cells[2].Value.ToString();

                //TODO
                //crear el formulariuo de llamada
               
                        
                    

            }

        }
    }
}
