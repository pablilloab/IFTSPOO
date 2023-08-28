using System;

namespace HolaMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int EDAD_MINIMA = 16;
            int edad;
            Console.WriteLine("Ingese la edad");
            edad = int.Parse(Console.ReadLine());
            if (edad < EDAD_MINIMA)
            {
                Console.WriteLine("No podes votar");
            }
            else
            {
                Console.WriteLine("Podes votar");
            }

        }
    }
}
