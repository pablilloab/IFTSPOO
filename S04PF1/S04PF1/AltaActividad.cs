using MySql.Data.MySqlClient;
using S04PF1.Data;
using S04PF1.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S04PF1
{
    public partial class AltaActividad : Form
    {
        //Variables para StoredProcedure.
        double monto = 0;
        int tiempo = 0;
        int dia = 0;
        EInscripcion inscripcion = new EInscripcion();
        bool datosValidos = true;

        public AltaActividad()
        {
            InitializeComponent();
        }

        private void lblAltaSocios_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con este metodo capto la actividad seleccionada
            int rowNumber = e.RowIndex;
            if (rowNumber != -1)
            {
                if (int.TryParse(dtgvActividad.Rows[rowNumber].Cells[0].Value.ToString(), out int actividadParseada))
                {
                    inscripcion.IdActividad = actividadParseada;
                }
                
                if(double.TryParse(dtgvActividad.Rows[rowNumber].Cells[3].Value.ToString(), out double montoParseado))
                {
                    monto = montoParseado;
                }

                MessageBox.Show("Actividad Seleccionada " + dtgvActividad.Rows[rowNumber].Cells[1].Value.ToString());
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        public void CargarActividades()
        {
            Connection con = new Connection();
            try
            {
                string query = "select a.idActividad, a.descripcion, a.horario, a.costo_mensual, a.costo_diario from actividad a;";

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
                        int row = dtgvActividad.Rows.Add();
                        dtgvActividad.Rows[row].Cells[0].Value = reader.GetString(0);
                        dtgvActividad.Rows[row].Cells[1].Value = reader.GetString(1);
                        dtgvActividad.Rows[row].Cells[2].Value = reader.GetString(2);
                        dtgvActividad.Rows[row].Cells[3].Value = reader.GetString(3);
                        dtgvActividad.Rows[row].Cells[4].Value = reader.GetString(4);
                    }
                }
                else
                {
                    MessageBox.Show("No existen actividades - CONTACTE A SOPORTE");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception", e.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Id de Socio.
            if (int.Parse(txtCodSocio.Text) != 0)
            {
                inscripcion.IdSocio = int.Parse(txtCodSocio.Text);
            }
            else
            {
                datosValidos = false;
            }

            //Tiempo.
            if(int.Parse(txtTiempo.Text) != 0)
            {
                tiempo = int.Parse(txtTiempo.Text);
            }
            else
            {
                datosValidos = false;
            }

            //Check si es x dia.
            if(chkDia.Checked)
            {
                dia = 1;
            }

            //Hago la llamada al StoredProcedure si todos los datos estan cargados.
            if (datosValidos) 
            {
                if(Inscripcion.altaActividad(inscripcion, tiempo, dia, monto))
                {
                    MessageBox.Show("Actividad cargada correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un problema al cargar la actividad.");
                }
            }
            else
            {
                MessageBox.Show("Revise los datos y vuelva a intentarlo");
            }
        }
    }
}

