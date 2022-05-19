using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impiccato
{
    class Program
    {
        static void Main(string[] args)
        {
                //abbiamo creato oggetto im e ism 
                //ImpiccatoManager im = new ImpiccatoManager("benvenuti");
                ImpiccatoManager im = new ImpiccatoManager();
                ImpiccatoScreenManager ism = new ImpiccatoScreenManager(im);
                //string parola = "benvenuti";
                //Console.WriteLine("Ciao! Benvenuto al gioco!");
                //Console.WriteLine("          ");
                //Console.WriteLine(@"_____    ");
                //Console.WriteLine(@"|/    |  ");
                //Console.WriteLine(@"|     0  ");
                //Console.WriteLine(@"|    /|\ ");
                //Console.WriteLine(@"|    / \ ");
                //Console.WriteLine("         ");
                //Console.WriteLine($"Parola : {impiccato1.parolaMascherata}");

                //creamo questo metodo per aggiornare screen usando variabile
                ism.AggiornaSchermata();

                char tastoPremuto;
                //finche non hai trovato parola e non hai raggionuto a limite errori fai questo
                while (!im.ParolaTrovata() && !im.LimiteErroriRaggiunto())
                {
                    Console.Write("Premi un tasto: ");
                    tastoPremuto = Console.ReadKey().KeyChar;

                    if (im.ControllaCarattere(tastoPremuto))
                    {
                        im.ApplicaCarattere(tastoPremuto);

                    }
                    else
                    {
                        im.IncrementaErrori();
                    }
                    ism.AggiornaSchermata();

                }
                if (im.ParolaTrovata())
                {
                    Console.WriteLine("Complimenti! Hai vinto");

                }
                else
                {
                    Console.WriteLine("Oops! Non Hai vinto");

                }

                Console.ReadLine();
            }
        }
    
    
}
