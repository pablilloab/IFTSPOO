
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
        bool correcto = false;
        private int mensaje;
        //esta variable estatica la utilizamos para pedir los datos de conexion de la db una unica vez.
        private static int cargaDatosDB = 0;
       

        //Datos DB
        //private string server = "localhost";
        //private string db = "club_deportivo";
        //private string user = "root";
        //private string password = "coqui123";
        //private string port = "3306";
        private string stringConnection;

        //*******************************************************************************
        //*       SOLICITO LOS DATOS PARA LA CONEXION A LA DB                           *
        //*******************************************************************************

        private void pedirDatos()
        {
            while(correcto != true)
            {
                DatosDB.server = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el servidor", "Datos para conectar a la DB");
                DatosDB.db = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la DB", "Datos para conectar a la DB");
                DatosDB.user = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el usuario", "Datos para conectar a la DB");
                DatosDB.password = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña", "Datos para conectar a la DB");
                DatosDB.port = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el puerto", "Datos para conectar a la DB");

                mensaje = (int)MessageBox.Show("Si ingreso fue: SERVIDOR = " + DatosDB.server + " DB = " + DatosDB.db + " USER = " + DatosDB.user + " PASS = " + DatosDB.password + " PORT = " + DatosDB.port,
                                               "SYSTEM ALERT!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(mensaje != 6)
                {
                    MessageBox.Show("Ingrese los datos nuevamente");
                    correcto = false;
                }
                else
                {
                    cargaDatosDB++;
                    correcto = true;    
                }
            }
        }

        //*******************************************************************************

        //Constructor de clase
        public Connection()
        {
            //solicito los datos solo si es a primer ejecucion del programa.
            if(cargaDatosDB == 0) 
            { 
                pedirDatos();
            }


            //Armo la cadena de conexion
            stringConnection = "Database=" + DatosDB.db +
                ";DataSource=" + DatosDB.server +
                ";User Id=" + DatosDB.user + ";Password=" + DatosDB.password +
                ";Port=" + DatosDB.port;             
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
