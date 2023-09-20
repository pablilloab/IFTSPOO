using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S07TPI
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        //Constructor de clase
        public Libro (string titulo, string autor, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
        }

        //Getter y Setters
        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public string Editorial
        {
            get { return this.editorial; }
            set { this.editorial = value; }
        }

        //Override metodo ToString
        public override string? ToString()
        {
            return "Titulo: " + Titulo + " Autor: " + Autor + " Editorial: " + Editorial;
        }
    }
}
