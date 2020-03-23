using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string ArraySize;
            int[] MyArray;
            int i;
            int Read;

            //Proposer à l'utilisateur de faire un tableau :
            Console.WriteLine("Bonjour, vous voulez un tableau de quelle taille ?\n");
            //Transformer le tout en entier
            ArraySize = Console.ReadLine();
            Read = Int32.Parse(ArraySize);
            //Le tableau va prendre la taille X
            MyArray = new int[Read];
            Console.WriteLine("Voila un tableau de "+ArraySize+" cases : \n");
            for (i = 0; i < Read; i++) {
                //Afficher le tableau
                Console.WriteLine(i+1 );
            }
        }
    }
}
