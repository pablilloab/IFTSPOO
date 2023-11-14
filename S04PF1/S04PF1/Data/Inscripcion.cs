using MySql.Data.MySqlClient;
using S04PF1.Entitites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04PF1.Data
{
    internal class Inscripcion
    {
        private static Connection con = new Connection();

        public static bool altaActividad(EInscripcion ins, int tiempo, int dia, double monto)
        {
            try
            {
                //creo el command e indico que tipo de comando es
                MySqlCommand cmd = new MySqlCommand("AltaActividad", con.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                //agrego los parametros para la ejecucion del comando, los valores estan en el obj EInscripcion que llega al método
                //el resto de valores e pasan por parametro.
                //Id de actividad
                cmd.Parameters.Add("IdAct", MySqlDbType.Int64).Value = ins.IdActividad;
                //Id de socio
                cmd.Parameters.Add("IdSoc", MySqlDbType.Int64).Value = ins.IdSocio;

                cmd.Parameters.Add("Tiempo", MySqlDbType.Int64).Value = tiempo;
                cmd.Parameters.Add("Dia", MySqlDbType.Int64).Value = dia;
                cmd.Parameters.Add("Monto", MySqlDbType.Double).Value = monto;              

                //parametros para el resultado que es el campo out de mi SP
                var resultado = cmd.Parameters.Add("rta", MySqlDbType.Int64);
                resultado.Direction = ParameterDirection.Output;

                //Abro conexion
                if (con.getConnection() != null)
                {
                    con.openConnection();
                }

                cmd.ExecuteNonQuery();

                int esValido = Convert.ToInt32(resultado.Value);

                if (esValido == 0)
                {
                    return false;
                }

                return true;

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message, "Algo salio mal");

            }
            finally
            {
                con.closeConnection();
            }

            return false;

        }
    }
}

