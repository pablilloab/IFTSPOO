using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S03PF1
{
    internal class Televisor
    {
        public string marca;
        public string modelo;
        public int pulgadas;
        public bool estado;
        public int numeroCanal;

        public Televisor (string marca,  string modelo, int pulgadas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.pulgadas = pulgadas;
            this.estado = false;
            this.numeroCanal = 1;
        } 

        public int obtenerCanalActual()
        {
            return numeroCanal;
        }

        public bool cambiarCanal (int canal)
        {
            if (canal < 1 || canal > 150)
            {
                return false;
            }
            else
            {
                this.numeroCanal = canal;
                return true;
            }
        }

        public bool verPrendido()
        {
            if (estado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void cambiarEstado()
        {
            this.estado = !estado;
        }

        public override string ToString()
        {
            return "Marca = " + this.marca + " " + "Modelo = " + this.modelo;
        }


    }
}
