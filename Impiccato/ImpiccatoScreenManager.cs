using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impiccato
{
    class ImpiccatoScreenManager
    {
        //definire proprietà
        public ImpiccatoManager im { get; set; }
        //costruttore
        public ImpiccatoScreenManager(ImpiccatoManager impiccatoManager)
        {
            this.im = impiccatoManager;
        }
        //string parola = "benvenuti";
        //Console.WriteLine("Ciao! Benvenuto al gioco!");
        //Console.WriteLine("          ");
        //Console.WriteLine(@"_____    ");
        //Console.WriteLine(@"|/    |  ");
        //Console.WriteLine(@"|     0  ");
        //Console.WriteLine(@"|    /|\ ");
        //Console.WriteLine(@"|    / \ ");
        //Console.WriteLine("         ");
        //Console.WriteLine($"Parola : {im.parolaMascherata}");
        //funzione
        public void AggiornaSchermata()
        {
            Console.Clear();
            Console.WriteLine("Ciao! Benvenuto al gioco!");
            Console.WriteLine("  ");
            Console.WriteLine(@"_____    ");
            Console.WriteLine(@"|/   |  ");

            switch (im.ErrNumber)
            {
                case 0:
                    Console.WriteLine(@"|          ");
                    Console.WriteLine(@"|          ");
                    Console.WriteLine(@"|          ");
                    break;

                case 1:
                    Console.WriteLine(@"|    0   ");
                    Console.WriteLine(@"|        ");
                    Console.WriteLine(@"|        ");
                    break;
                case 2:
                    Console.WriteLine(@"|    0   ");
                    Console.WriteLine(@"|   /|   ");
                    Console.WriteLine(@"|        ");
                    break;
                case 3:
                    Console.WriteLine(@"|    0    ");
                    Console.WriteLine(@"|   /|\   ");
                    Console.WriteLine(@"|         ");
                    break;
                case 4:
                    Console.WriteLine(@"|    0    ");
                    Console.WriteLine(@"|   /|\   ");
                    Console.WriteLine(@"|   /     ");
                    break;
                case 5:
                    Console.WriteLine(@"|    0    ");
                    Console.WriteLine(@"|   /|\   ");
                    Console.WriteLine(@"|   / \   ");
                    break;

                default:
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine($"Parola : {im.parolaMascherata}");

        }
    }
}
