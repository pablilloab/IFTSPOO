using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S09A2
{
    internal class ProductoPerecedero : Producto
    {
        private int _diasACaducar;

        //Constructor de clase
        public ProductoPerecedero(string nombre, decimal precio, string tipo, int diasACaducar) : base(nombre, precio, tipo)
        {
            DiasACaducar = diasACaducar;
        }

        //Getter and Setters
        public int DiasACaducar { get => this._diasACaducar; set => this._diasACaducar = value; }

        //Mostrar Datos
        public override string? ToString()
        {
            return base.ToString() + "Dias a Caducar : " + DiasACaducar;
        }

        //Calcular Precio
        public new decimal calcularPrecioTotal(int cantidadDeProductos)
        {            
            return (this.Precio * cantidadDeProductos) / 4;
        }

    }
}
