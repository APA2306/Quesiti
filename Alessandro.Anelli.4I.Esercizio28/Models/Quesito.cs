using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alessandro.Anelli._4I.Esercizio28.Models
{
    public abstract class Quesito
    {
        public string Domanda {get;set;}
        public string RispostaCorretta { get;set;}
        public int Punteggio { get;set;}

        public abstract int Ask(Quesito quesito , string Risposta);
    }

     public class QuesitoSiNo : Quesito
    {
        public QuesitoSiNo(string Domanda, string Risposta, int  Punteggio)
        {
            this.Domanda = Domanda;
            this.RispostaCorretta = Risposta;
            this.Punteggio = Punteggio;
        }
        public override int Ask(Quesito quesito, string risposta)
        {
            QuesitoSiNo q = quesito as QuesitoSiNo;
            if(risposta.ToLower() == "si" && risposta.ToLower() == "no")
            {

            }
            
            return quesito.Punteggio;
        }
    }

    public class QuesitoNumerico : Quesito
    {
        public QuesitoNumerico(string Domanda, string Risposta, int Punteggio)
        {
            this.Domanda = Domanda;
            this.RispostaCorretta = Risposta;
            this.Punteggio = Punteggio;
        }
        public override int Ask(Quesito quesito, string risposta)
        {
            return quesito.Punteggio;
        }
    }

    public class QuesitoMultiplo : Quesito
    {
        public QuesitoMultiplo(string Domanda, string Risposta, int Punteggio)
        {
            this.Domanda = Domanda;
            this.RispostaCorretta = Risposta;
            this.Punteggio = Punteggio;
        }
        public override int Ask(Quesito quesito, string risposta)
        {
            return quesito.Punteggio;
        }
    }
}
