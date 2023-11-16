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
    public partial class Carnet : Form
    {
        public Carnet()
        {
            InitializeComponent();
        }

        private void lblCobroCuota_Click(object sender, EventArgs e)
        {

        }

        private void Carnet_Load(object sender, EventArgs e)
        {
            cargarInscripciones();
        }

        public void cargarInscripciones()
        {
            //TODO carga del data grid para las inscripciones.

            Connection con = new Connection();
            try
            {
                string query = "select i.idInscripcion, i.idSocio, s.nombre as nombre_socio, s.apellido as apellido_socio, a.descripcion as nombre_actividad, i.idCarnet, i.idCuota from inscripcion i join socios s on i.idSocio = s.idSocio join actividad a on i.idActividad = a.idActividad;";

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
                        int row = dtgvInscripcion.Rows.Add();
                        dtgvInscripcion.Rows[row].Cells[0].Value = reader.GetString(0);
                        dtgvInscripcion.Rows[row].Cells[1].Value = reader.GetString(1);
                        dtgvInscripcion.Rows[row].Cells[2].Value = reader.GetString(2);
                        dtgvInscripcion.Rows[row].Cells[3].Value = reader.GetString(3);
                        dtgvInscripcion.Rows[row].Cells[4].Value = reader.GetString(4);
                        dtgvInscripcion.Rows[row].Cells[5].Value = reader.GetString(5);
                        dtgvInscripcion.Rows[row].Cells[6].Value = reader.GetString(6);
                    }
                }
                else
                {
                    MessageBox.Show("No existen inscripciones - CONTACTE A SOPORTE");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception", e.Message);
            }
        }

        //este metodo al hacer click sobre el datagridview lleva los datos para la impresoin del carnet.


        private void dtgvInscripcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowNumber = e.RowIndex;
            if (rowNumber != -1)
            {
                //Capto los datos seleccionados en el dtgv para enviarlos al formulario.
                int.TryParse(dtgvInscripcion.Rows[rowNumber].Cells[5].Value.ToString(), out int idCarnet); //id Carnet
                string nombre = dtgvInscripcion.Rows[rowNumber].Cells[2].Value.ToString(); //nombre
                string apellido = dtgvInscripcion.Rows[rowNumber].Cells[3].Value.ToString(); //apellido
                string actividad = dtgvInscripcion.Rows[rowNumber].Cells[4].Value.ToString(); //actividad

                //fecha de hoy para dia de emision del carnet
                DateTime fecha = DateTime.Now;
                string fechaFormateada = fecha.ToString("dd-MM-yyyy");

                //TODO
                //crear el formulario de llamada

                ImprimirCarnet form = new ImprimirCarnet();

                form.SetDatos(idCarnet, nombre, apellido, actividad, fechaFormateada);
                form.ShowDialog();
            }
        }
    }
}
