namespace S09A2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo Producto Perecedero (1 dia a caducar)");

            ProductoPerecedero perecedero1 = new ProductoPerecedero("Manteca", 100, "Lácteos", 1);

            Console.WriteLine("Total perecedero1 " + perecedero1.calcularPrecioTotal(5));

            Console.WriteLine("Creo Producto No Perecedero");

            ProductoNoPerecedero noPerecedero1 = new ProductoNoPerecedero("Arroz", 50, "Legumbres", "Precios Cuidados");

            Console.WriteLine("Total noPerecedero1 " + noPerecedero1.calcularPrecioTotal(2));
        }
    }
}