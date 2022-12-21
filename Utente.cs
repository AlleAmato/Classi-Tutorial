using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_Tutorial
{
    public class Utente
    {
        //parametri
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        private string _cognome;
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        private int? _eta;
        public int? Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }
        //costruttore vuoto
        public Utente()
        {
            _nome = "";
            _cognome = "";
            _eta = null;
        }

        //costruttore con solo nme e cognome
        public Utente(string nome, string cognome) : this()
        // prima di questo così esegue il costruttore senza parametri e mette già a null l'età
        {
            this._nome = nome;
            this._cognome = cognome;
        }


        //costruttore completo
        public Utente(string nome, string cognome, int? eta) : this(nome, cognome) //perchè non riesce a prendere questi parametri dal costruttore prcedenti
        //faccio prendere dal costruttore prima titolo e autore
        {
            this._eta = eta;
        }

        //metodo
        public void MostraUtente()
        {
            Console.WriteLine($"{Nome} {Cognome}");
        }

    }
}
