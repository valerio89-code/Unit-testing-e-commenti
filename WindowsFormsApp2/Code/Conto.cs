using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Code
{
    public class Conto
    {
        //Classe che rappresenta un conto
        public Conto(int saldoIniziale)
        {
            Saldo = saldoIniziale;
        }

        public int Saldo { get; set; }

        public void PrelevaSoldi(int prelievo)
        {
            if (Saldo > prelievo)
            {
                Saldo -= prelievo;
            }
            else
            {
                throw new Exception("Saldo non sufficiente");
            }
        }

        /// <summary>
        /// Restituisce il saldo espresso in dollari
        /// </summary>
        /// <param name="tassoConversione">Tasso di conversione euro-dollaro</param>
        /// <param name="applicaTassoMassimo">True per applicare il tasso di conversione massimo salvato</param>
        /// <returns>Intero che rappresenta il saldo</returns>
        public int RecuperaSaldoInDollari(int tassoConversione, bool applicaTassoMassimo)
        {
            return Saldo * tassoConversione;
        }
    }
}
