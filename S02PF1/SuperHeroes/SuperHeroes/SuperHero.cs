using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    internal class SuperHero
    {
        private String nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        //Constructor de clase
        public SuperHero(String nombre, int fuerza, int resistencia, int superpoderes)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Resistencia = resistencia;
            Superpoderes = superpoderes;
        }

        //Comienzo de Getter y Setters
        private String Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == "")
                {
                    this.nombre = "J. Doe";
                }
                else
                {
                    this.nombre = value;
                }

            }

        }

        private int Fuerza
        {
            get
            {
                return fuerza;
            }
            set
            {
                if (value < 0)
                {
                    this.fuerza = 0;
                }
                else if (value > 100)
                {
                    this.fuerza = 100;
                }
                else
                {
                    this.fuerza = value;
                }
            }            
        }

        private int Resistencia
        {
            get
            {
                return resistencia;
            }
            set
            {
                if (value < 0)
                {
                    this.resistencia = 0;
                }
                else if (value > 100)
                {
                    this.resistencia = 100;
                }
                else
                {
                    this.resistencia = value;
                }
            }
        }

        private int Superpoderes
        {
            get
            {
                return superpoderes;
            }
            set
            {
                if (value < 0)
                {
                    this.superpoderes = 0;
                }
                else if (value > 100)
                {
                    this.superpoderes = 100;
                }
                else
                {
                    this.superpoderes = value;
                }
            }
        }

        //Metodo Competir
        public void competir (SuperHero superhero)
        {
            int puntoP1 = 0;
            int puntoP2 = 0;

            if (this.fuerza > superhero.Fuerza)
            {
                puntoP1++;
            }
            else
            {
                puntoP2++;
            }

            if (this.resistencia > superhero.Resistencia)
            {
                puntoP2++;
            }
            else
            {
                puntoP2++;
            }

            if (this.superpoderes > superhero.Superpoderes)
            {
                puntoP1++;
            }
            else
            {
                puntoP2++;
            }

            if (puntoP1 > puntoP2)
            {
                Console.WriteLine("VICTORIA");
            }
            else
            {
                Console.WriteLine("DERROTA");
            }
        }
    }
}
