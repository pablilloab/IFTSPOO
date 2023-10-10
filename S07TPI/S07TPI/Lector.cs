using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S07TPI
{
    internal class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> prestamoLibros;
        private int cantPrestamos;

        //Constructor de clase
        public Lector(string nombre, string dni)
        {
            prestamoLibros = new List<Libro>();
            Nombre = nombre;
            Dni = dni;
            CantPrestamos = 0;
        }

        //Getter and Setters
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public int CantPrestamos
        {
            get { return cantPrestamos; }
            set { this.cantPrestamos = value; }
        }

        public void setLibro (Libro libro)
        {
            prestamoLibros.Add(libro);
        }

        //Override toString
        public override string? ToString()
        {
            return "Nombre Lector: " + Nombre + " Dni: " + Dni + "Prestamos: " + CantPrestamos;
        }
    }
        
}
