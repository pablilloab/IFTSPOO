using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S09A2
{
    internal class ProductoNoPerecedero : Producto
    {
        private string _categoria;

        //Constructor de clase
        public ProductoNoPerecedero(string nombre, decimal precio, string tipo, string categoria) : base(nombre, precio, tipo)
        {
            Categoria = categoria;
        }

        //Getters and Setters
        public string Categoria { get => this._categoria; set => this._categoria = value; }


        //Mostrar Datos
        public override string? ToString()
        {
            return base.ToString() + "Categoria : " + Categoria;
        }
    }
}
