using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressebok
{
    class Oppføring
    {
        private string fNavn;
        private string eNavn;
        private int nr;
        private string adresse;
        private bool star;
        
        #region Konstruktør

        public Oppføring()
        {

        }

        public Oppføring(string f, string e, int n, string a)
        {
            fNavn = f;
            eNavn = e;
            nr = n;
            adresse = a;
        }
        #endregion

        #region Set-Get-Metoder
        public string Fornavn
        {
            get { return fNavn; }
            set { fNavn = value; }
        }

        public string Etternavn
        {
            get { return eNavn; }
            set { eNavn = value; }
        }
        
        public int Nummer
        {
            get { return nr; }
            set { nr = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public bool Favoritt
        {
            get { return star; }
            set { star = value; }
        }
        #endregion

        #region Private metoder

        #endregion
    }
}
