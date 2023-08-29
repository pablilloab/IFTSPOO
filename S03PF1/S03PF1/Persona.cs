using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03PF1
{
    internal class Persona
    {
        public string nombre;
        public Domicilio domicilio;
        public Televisor televisor;

        public Persona(string nombre, Domicilio domicilio, Televisor televisor)
        { 
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.televisor = televisor;
        }

        public override string ToString()
        {
            return "Nombre = " + this.nombre + " " + "Domicilio = " + this.domicilio.ToString() + " " + this.televisor.ToString();
        }

    }
}
