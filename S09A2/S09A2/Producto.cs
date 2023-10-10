using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S09A2
{
    internal class Producto
    {
        private string _nombre;
        private decimal _precio;
        private string _tipo;

        //Constructor de clase
        public Producto(string nombre, decimal precio, string tipo)
        {
            Nombre = nombre;
            Precio = precio;
            Tipo = tipo;
        }

        //Getters and Setters
        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public decimal Precio { get => this._precio; set => this._precio = value; }
        public string Tipo { get => this._tipo; set => this._tipo = value; }

        //Mostrar Datos
        public override string? ToString()
        {
            return "Nombre : " + Nombre + "Precio : " + Precio + "Tipo : " + Tipo;
        }
        
        //Calcular Precio
        public decimal calcularPrecioTotal(int cantidadDeProductos)
        {            
            return this.Precio * cantidadDeProductos;
        }

    }
}
