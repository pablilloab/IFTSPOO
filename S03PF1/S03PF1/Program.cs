namespace S03PF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S03PF01");

            Televisor tele1 = new Televisor("Philips", "Led", 40);
            Domicilio dom1 = new Domicilio("Avenida Siempre Viva", "742", "Spring");

            Persona facundo = new Persona("Facundo", dom1, tele1);
            Persona camila = new Persona("Camila", dom1, tele1 );

            if (tele1.verPrendido())
            {
                Console.WriteLine("El tele esta prendido");
            }
            else
            {
                Console.WriteLine("El tele esta apagado");
            }

            Console.WriteLine("Facu esta prendiendo el televisor");
            facundo.televisor.cambiarEstado();

            if (tele1.verPrendido())
            {
                Console.WriteLine("El tele esta prendido");
            }
            else
            {
                Console.WriteLine("El tele esta apagado");
            }

            Console.WriteLine(facundo.ToString());

        }
    }
}