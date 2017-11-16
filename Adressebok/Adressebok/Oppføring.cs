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
        private decimal nr;
        private string adresse;
        private bool star = false;
        
        #region Konstruktør

        public Oppføring()
        {

        }

        public Oppføring(string fornavn, string etternavn, decimal nummer, string adr)
        {
            fNavn = fornavn;
            eNavn = etternavn;
            nr = nummer;
            adresse = adr;
        }

        public Oppføring(string fornavn, string etternavn, decimal nummer, string adr, bool favorite)
        {
            fNavn = fornavn;
            eNavn = etternavn;
            nr = nummer;
            adresse = adr;
            star = favorite;
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
        
        public decimal Nummer
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
