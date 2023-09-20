namespace S07TPI
{
    internal class TestBiblioteca
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instanciando una biblioteca nueva");
            Biblioteca miBiblioteca = new Biblioteca();

            Console.WriteLine("Agrego Libros a la biblioteca");
            Console.WriteLine(miBiblioteca.agregarLibro("Harry Potter y la piedra filosofal", "JK Rownling", "Ateneo"));
            Console.WriteLine(miBiblioteca.agregarLibro("Programacion I", "IFTS29", "IFTS29"));
            Console.WriteLine(miBiblioteca.agregarLibro("Programacion II", "IFTS29", "IFTS29"));
            Console.WriteLine(miBiblioteca.agregarLibro("Programacion III", "IFTS29", "IFTS29"));

            Console.WriteLine("Intento agregar libro dupliado");
            Console.WriteLine(miBiblioteca.agregarLibro("Programacion I", "IFTS29", "IFTS29"));

            Console.WriteLine("Agrego Lector");
            Console.WriteLine(miBiblioteca.altaLector("Pablo", "29123456"));

            Console.WriteLine("Agrego Lector duplicado");
            Console.WriteLine(miBiblioteca.altaLector("Pablo", "29123456"));

            Console.WriteLine("Presto Libro 1");
            Console.WriteLine(miBiblioteca.prestarLibro("Programacion I", "29123456"));
            Console.WriteLine("Presto Libro 2");
            Console.WriteLine(miBiblioteca.prestarLibro("Programacion II", "29123456"));
            Console.WriteLine("Presto Libro 3");
            Console.WriteLine(miBiblioteca.prestarLibro("Programacion III", "29123456"));

            Console.WriteLine("Presto Libro 4 - error por tope de libros");
            Console.WriteLine(miBiblioteca.prestarLibro("Harry Potter y la piedra filosofal", "29123456"));

            Console.WriteLine("Presto Libro inexistente");
            Console.WriteLine(miBiblioteca.prestarLibro("Programation", "29123456"));

            Console.WriteLine("Presto Libro a lector inxistente");
            Console.WriteLine(miBiblioteca.prestarLibro("Programacion I", "29456"));



        }
    }
}