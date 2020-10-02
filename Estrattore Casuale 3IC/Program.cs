using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Estrattore_Casuale_3IC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Estrattore Casuale 3IC";

            Random casuale = new Random();
            List<string> alunni = new List<string> 
            {"Angioletti Gabriele", "Bellini Pietro", "Cantoni Vadim", "Chen Yongjiang", "Della Muzia Leone", "El Karrouti Othman", "Esposito Matteo", "Facoetti Francesco", "Fasolini Davide", "Gomez Mamani Jonatan Samuel", "Guerrini Andrea", "Iavazzo Elia", "Iurkevych Vladyslav", "La Viola Massimiliano", "Longhi Lorenzo", "Malachini Alessandro", "Manzoni Jacopo", "Moscheni Christian", "Musitelli Fabio", "Rota Daniel", "Sawo Shory", "Scaburri Francesco", "Suarez Soto Christian Rodrigo Ed", "Toma Emanuele"};
            List<string> estratti = new List<string>();
            string estratto = default;
            int daEstrarre = default, loop = default;
            do
            {
                Console.Clear();
                Console.Write($"Inserisci il numero di alunni da estrarre [1-{alunni.Count}]: ");
                int.TryParse(Console.ReadLine(), out daEstrarre);
            } while (daEstrarre <= 0 || daEstrarre > alunni.Count);
            
            while(loop < daEstrarre)
            {
                estratto = alunni[casuale.Next(0, alunni.Count)];
                if (!estratti.Contains(estratto))
                {
                    estratti.Add(estratto);
                    loop++;
                }
            }

            loop = 0;
            Console.WriteLine("\nSono usciti: \n");
            while (loop < estratti.Count) {
                Console.WriteLine(" - " + estratti[loop]);
                loop++;
            }

            Console.WriteLine("\nPremi un tasto per terminare...");
            Console.ReadKey();
        }
    }
}
