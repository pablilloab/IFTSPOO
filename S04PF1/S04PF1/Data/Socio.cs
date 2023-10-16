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

        public static bool altaSocio(ESocio socio)
        {
            try
            {
                //creo el command e indico que tipo de comando es
                MySqlCommand cmd = new MySqlCommand("NuevoSocio", con.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                //agrego los parametros para la ejecucion del comando, los valores estan en el obk ESocio que llega al método                
                cmd.Parameters.Add("Nom", MySqlDbType.VarChar).Value = socio.nombre;
                cmd.Parameters.Add("Ape", MySqlDbType.VarChar).Value = socio.apellido;
                cmd.Parameters.Add("Dni", MySqlDbType.VarChar).Value = socio.dni;
                cmd.Parameters.Add("Tel", MySqlDbType.VarChar).Value = socio.telefono;
                cmd.Parameters.Add("Email", MySqlDbType.VarChar).Value = socio.email;

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
