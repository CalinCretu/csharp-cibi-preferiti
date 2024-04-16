using System;

namespace CibiPreferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Dichiaro l'Array di stringhe
            string[] CibiPreferiti = ["Pasta", "Secondi", "Pesci", "Pizza", "Lasagne", "Sushi", "Agnellini", "Verdure", "Insalate", "Risotti"];

            Console.WriteLine("La lunghezza della classifica è di " + CibiPreferiti.Length + " " + "posizioni");
                // Aggiungo questo Console. per avere un risultato comprensibile in console
            Console.WriteLine("La classifica dei Cibi preferiti è:");
            
            for (var i=0; i<CibiPreferiti.Length; i++)
            {              
                Console.WriteLine((i+1) + "º" + " " + CibiPreferiti[i]);
            }

            Console.WriteLine("Il cibo preferito è: " + CibiPreferiti[0]);
                // Per prendere l'ultimo elemento dell'array bisogna prendere la sua lunghezza e diminuire di 1
                // Per far stampare la stringa bisogna prendere l'array e richiedergli il valore dell'ultimo elemento
            Console.WriteLine("Il cibo meno gradito è: " + CibiPreferiti[CibiPreferiti.Length - 1]);

                // troviamo gli elementi al centro della classifica
            int posizioneCentrale = CibiPreferiti.Length / 2;

            Console.WriteLine("La Prima posizione centrale è: " + CibiPreferiti[posizioneCentrale - 1]);

            Console.WriteLine("La Seconda posizione centrale è: " + CibiPreferiti[posizioneCentrale]);

                // Console.ReadKey();
        }
    }
}