using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03A3
{
    internal class Alumno
    {
        private string nombre;
        private string apellido;
        private string tipo;
        private string numeroDocumento;

      
        public Alumno (string nombre, string apellido, string tipo, string numeroDocumento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Tipo = tipo;
            NumeroDocumento = numeroDocumento;
        }

        public string Nombre {
            get { return this.nombre; }            
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido;}
            set { this.apellido = value;}
        }

        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public string NumeroDocumento
        {
            get { return this.numeroDocumento;}
            set { this.numeroDocumento = value;}
        }

        public override string? ToString()
        {
            return "El alumno " + this.nombre + " " + this.apellido + " ha sido instanciado correctamente";
        }
    }
}
