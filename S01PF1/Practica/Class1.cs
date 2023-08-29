using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; } 
        }

        public Persona (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getEdad()
        {
            return this.edad;
        }

        
    }
}
