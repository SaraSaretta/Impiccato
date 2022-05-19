using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impiccato
{
    class ImpiccatoManager
    {
        public string parola;
        public string parolaMascherata { get; set; }
        public int ErrNumber //cosi sul screen manager puo disegnare gli errori
        {
            get
            {
                return errNumber;
            }
        }
        private int errNumber { get; set; } //è privato perche non deve essere cambiato
        private int maxErrNumber;
        //creamo costruttore
        public ImpiccatoManager()
        {
            this.parola = GetParolaRandom();
            this.parolaMascherata = GetParolaMascherata();
            this.maxErrNumber = 5;

        }
        //i funzioni
        public void ApplicaCarattere(char tastoPremuto)
        {
            string newParolaMascherata = "";
            //scriviamo in questo modo per risolvere problema di minuscola e maiuscola
            string tastoPremutoMinuscolo = tastoPremuto.ToString().ToLower();
            for (int i = 0; i < parola.Length; i++)
            {
                if (tastoPremutoMinuscolo == parola[i].ToString())
                {
                    newParolaMascherata += parola[i];

                }
                else
                {
                    newParolaMascherata += parolaMascherata[i];
                }
            }
            parolaMascherata = newParolaMascherata;
        }
        public void IncrementaErrori()
        {
            errNumber++;
        }

        public bool ParolaTrovata()
        {
            return parola == parolaMascherata;
        }
        public bool LimiteErroriRaggiunto()
        {
            return ErrNumber == maxErrNumber;
        }
        public bool ControllaCarattere(char tastoPremuto)
        {
            string tastoPremutoMaiuscolo = tastoPremuto.ToString().ToUpper();
            string parolaMaiuscola = parola.ToString().ToUpper();
            return parolaMaiuscola.Contains(tastoPremutoMaiuscolo.ToString().ToUpper());

        }
        private string GetParolaMascherata()
        {
            string valoreRitornato = "";
            for (int i = 0; i < this.parola.Length; i++)
            {
                valoreRitornato += "-";

            }
            return valoreRitornato;
        }

        public string GetParolaRandom()
        {
            Random random = new Random();
            string[] elencoParole = System.IO.File.ReadAllLines(@"c:\Stage\Persona.txt");
            int index = random.Next(elencoParole.Length);
            string parolaRandom = elencoParole[index].ToLower();
            return parolaRandom;

        }
    }
}
