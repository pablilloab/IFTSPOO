using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S04PF1.Data
{
    internal class Users
    {
        private static Connection con = new Connection();

        public static bool validarUsuario(string username, string password)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("checkLogin", con.getConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("Usu", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("Pass", MySqlDbType.VarChar).Value = password;

                var resultado = cmd.Parameters.Add("resultado", MySqlDbType.Int64);
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
                MessageBox.Show("Exception" + e.Message);
            }
            finally
            {
                con.closeConnection();
            }

            return false;
        }
    }
}
