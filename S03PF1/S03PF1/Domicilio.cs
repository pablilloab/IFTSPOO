using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03PF1
{
    internal class Domicilio
    {
        public string calle;
        public string numero;
        public string barrio;

        public Domicilio (string calle, string numero, string barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }

        public override string ToString()
        {
            return "Calle = " + this.calle + " Numero = " + this.numero + " Barrio = " + this.barrio;
        }

    }
}
