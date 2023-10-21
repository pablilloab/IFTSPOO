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
    internal class Socio
    {
        private static Connection con = new Connection();

        public static bool altaSocio(ESocio socio, EApto apto)
        {
            try
            {
                //creo el command e indico que tipo de comando es
                MySqlCommand cmd = new MySqlCommand("NuevoSocio", con.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                //agrego los parametros para la ejecucion del comando, los valores estan en el obj ESocio que llega al método                
                cmd.Parameters.Add("Nom", MySqlDbType.VarChar).Value = socio.nombre;
                cmd.Parameters.Add("Ape", MySqlDbType.VarChar).Value = socio.apellido;
                cmd.Parameters.Add("inDni", MySqlDbType.Int64).Value = socio.dni;
                cmd.Parameters.Add("Tel", MySqlDbType.VarChar).Value = socio.telefono;
                cmd.Parameters.Add("Email", MySqlDbType.VarChar).Value = socio.email;

                //agrego los parametros para la ejecucion del comando, los valores estan en el obj EApto que llega al método                
                cmd.Parameters.Add("historiaM", MySqlDbType.VarChar).Value = apto.historiaM;
                cmd.Parameters.Add("fecha", MySqlDbType.VarChar).Value = apto.fecha;
                cmd.Parameters.Add("alto", MySqlDbType.Decimal).Value = apto.alto;
                cmd.Parameters.Add("peso", MySqlDbType.Decimal).Value = apto.peso;
                
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

            }catch (MySqlException e)
            {
                MessageBox.Show("Exception", e.Message);

            }finally
            { 
                con.closeConnection();
            }

            return false;

        }
    }
}
