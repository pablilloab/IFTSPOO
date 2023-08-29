namespace SuperHeroes
{
    internal class Test
    {
        static void Main(string[] args)
        {
            SuperHero superHeroe1 = new SuperHero("Batman", 90, 70, 0);
            SuperHero superHeroe2 = new SuperHero("Superman", 95, 60, 70);

            
            superHeroe1.competir(superHeroe2);

            superHeroe2.competir(superHeroe1);
        }
    }
}