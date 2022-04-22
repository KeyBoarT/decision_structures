using System;

namespace decision_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decision Structures (Karar Yapıları)
            // if, else, elseif, ternary

            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın !");
            }

            else if (time >= 18)
            {
                Console.WriteLine("İyi günler !");
            }
            else
            {
                Console.WriteLine("iyi geceler !");
            }


            //Ternary
            string sonuc = time >= 6 && time < 11 ? "Günaydın !" : time <= 18 ? "İyi Günler !" : "İyi Geceler !";
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
