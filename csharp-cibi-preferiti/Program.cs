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

                // trovo gli elementi al centro della classifica
            int posizioneCentrale = CibiPreferiti.Length / 2;
                // stampo l'elemento centrale
            Console.WriteLine("La Seconda posizione centrale è: " + CibiPreferiti[posizioneCentrale]);
            // stampo un secondo elemento centrale nel caso l'array sia composto da un numero pari di elementi
            if (CibiPreferiti.Length % 2 == 0)
            {
                Console.WriteLine("La posizione centrale precedente è: " + CibiPreferiti[posizioneCentrale - 1]);
            }
        }
    }
}