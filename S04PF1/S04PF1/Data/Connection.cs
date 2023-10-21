
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04PF1.Data
{
    internal class Connection
    {
        //Creo mi variable del tipo connection
        private  MySqlConnection con;

        //Datos DB
        private string server = "localhost";
        private string db = "club_deportivo";
        private string user = "root";
        private string password = "coqui123";
        private string port = "3306";
        private string stringConnection;

        //Constructor de clase
        public Connection()
        {
            //Armo la cadena de conexion
            stringConnection = "Database=" + db +
                ";DataSource=" + server +
                ";User Id=" + user + ";Password=" + password +
                ";Port=" + port;             
        }

        public  MySqlConnection getConnection()
        {
            if (con == null)
            {
                con = new MySqlConnection(stringConnection);
                //con.Open();
            }

            return con;
        }

        public bool openConnection()
        {
            try
            {
                MySqlConnection con = getConnection();
                con.Open();
                return true;

            }catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void closeConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
