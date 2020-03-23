using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;

            //Proposer à l'utilisateur de faire un tableau :
            Console.WriteLine("Bonjour, a qui ai-je l'honneur ?\n");
            Name = Console.ReadLine();

            Console.WriteLine("Bonjour "+Name);

        }
    }
}
