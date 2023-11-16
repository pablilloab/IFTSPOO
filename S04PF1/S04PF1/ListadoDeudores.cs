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
    public partial class ListadoDeudores : Form
    {
        public ListadoDeudores()
        {
            InitializeComponent();
        }

        private void lblCarnet_Click(object sender, EventArgs e)
        {

        }

        private void ListadoDeudores_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                string query = "select i.idSocio, s.nombre, s.apellido from inscripcion i " +
                    "inner join socios s on i.idSocio = s.idSocio where i.idCuota in " +
                    "(select idCuota from cuota where fechaPago <= curdate() and pagoRealizado = 0);";

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
                        int row = dtgvDeudores.Rows.Add();
                        dtgvDeudores.Rows[row].Cells[0].Value = reader.GetString(0);
                        dtgvDeudores.Rows[row].Cells[1].Value = reader.GetString(1);
                        dtgvDeudores.Rows[row].Cells[2].Value = reader.GetString(2);
                        //dtgvDeudores.Rows[row].Cells[3].Value = reader.GetString(3);
                        //dtgvDeudores.Rows[row].Cells[4].Value = reader.GetString(4);
                    }
                }
                else
                {
                    MessageBox.Show("No existen deudores");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);
            }
        }
    }
}
