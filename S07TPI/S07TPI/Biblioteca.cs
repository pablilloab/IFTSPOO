using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace S07TPI
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        private const int CANTIDAD_PRESTAMOS = 3;

        public Biblioteca ()
        {
            this.libros = new List<Libro> ();
            this.lectores = new List<Lector> ();
        }

        //Metodo que busca libro por titulo, en caso de encontralo retorna el indice
        //en caso de no encontrarlo retorna -1
        private int buscarLibro (string titulo)
        {
            int i = 0;
            while (i < libros.Count) 
            {
                if (libros[i].Titulo.Equals(titulo))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        //Metodo que busca el titulo que se desea agregar, devuelve true si es satisfactoria
        //devuelve false en caso de que el libro ya este en la biblioteca.
        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            if (buscarLibro(titulo) == -1)
            {
                Libro libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                return true;
            } else
            {
                return false;
            }
        }

        //Metodo que busca el libro por titulo y lo elimina de la coleccion. Retorna true en caso satisfactorio
        //retorn false en caso de no encontrar el libro.
        public bool eliminarLibro (string titulo)
        {
            int indice = buscarLibro(titulo);
            if (indice >= 0)
            {
                libros.RemoveAt(indice);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para listar todos los libros de la biblioteca
        public void listarLibros()
        {
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        //Metodo para buscar Lector por dni
        private int buscarLector(string dni)
        {
            int i = 0;
            while (i < lectores.Count)
            {
                if (lectores[i].Dni.Equals(dni))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        //Metodo para dar de alta lectores en caso de no encotrarlo en la coleccion.
        public bool altaLector (string nombre, string dni)
        {
            if (buscarLector(dni) == -1)
            {
                Lector lector = new Lector(nombre, dni);
                lectores.Add(lector);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para prestar Libro
        public string prestarLibro (string titulo, string dni)
        {
            int indiceLector = buscarLector(dni);
            int indiceLibro = buscarLibro(titulo);
            if(indiceLector >= 0)
            {
                if (indiceLibro >= 0)
                {
                    if (lectores[indiceLector].CantPrestamos < CANTIDAD_PRESTAMOS)
                    {
                        lectores[indiceLector].setLibro(libros[indiceLibro]);
                        lectores[indiceLector].CantPrestamos++;
                        libros.RemoveAt(indiceLibro);
                        return "Prestamo Exitoso";
                    }
                    else
                    {
                        return "Tope de Prestamo Alcanzado";
                    }
                    
                }
                else
                {
                    return "Libro Inexistente";
                }
            }
            else
            {
                return "Lector Inexistente";
            }
        }
    }
}
