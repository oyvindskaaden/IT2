using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OppgaverUke36
{
    public partial class oppgaver_uke36 : Form
    {
        public oppgaver_uke36()
        {
            InitializeComponent();

            // Kode som skal kjøres på starten
            antForsok.Text = "Antall forsøk igjen: " + _antForsok;
            label5.Text = "Skriv inn ett tall mellom 0 og " + maksVerdi + " for å gjette hva maskinen har valgt";
        }

        #region Oppgave 1

        // Variabel som sier hvilken status knappen har
        bool toggle = true;
        long antKlikk;
        bool popo = false;

        private void btTog_Click(object sender, EventArgs e)
        {
            antKlikk++;
            // Sjekker hvilken knappeversjon som skal settes
            if (toggle)
            {
                // Setter teksten i knappen til "Bæææ!"
                btTog.Text = "Bæææ!";
                // Setter fargen til knappen til Rød
                btTog.BackColor = Color.Blue;
                toggle = false;
            }
            else
            {
                btTog.Text = "Buuuu!";
                btTog.BackColor = Color.Red;
                toggle = true;
            }

            if (antKlikk == 1000)
            {
                btTog.Text = "FRIHET!!!!";
                btTog.Enabled = false;
                btTog.BackColor = Color.Green;
                popoKommer.Text = "";
                ulovlig.Text = "Vil du prøve å rømme fra popo igjen? Klikk her!";
            }

            if (antKlikk % 7 == 0 && !popo)
            {
                popoKommer.Text = "Popo Kommer!!!!";
                popo = true;
            }
            else if (antKlikk % 7 == 0 && popo)
            {
                popoKommer.Text = "";
                popo = false;
            }
        }

        private void labelClick(object sender, MouseEventArgs e)
        {
            antKlikk = 0;
            btTog.Text = "TRYKK MEG!!!!";
            btTog.BackColor = Color.Transparent;
            btTog.Enabled = true;
            popo = false;
            ulovlig.Text = "";
        }

        #endregion

        #region Oppgave 2

        const int maksForsok = 5;
        int _antForsok = maksForsok;
        const int maksVerdi = 50;

        Random randomTall = new Random();

        int maskinTall;

        private void btGjett_Click(object sender, EventArgs e)
        {

            if (IsDigitsOnly(gjettInn.Text))
            {
                int userTall = Convert.ToInt16(gjettInn.Text);

                _antForsok--;

                if (_antForsok == 0)
                {
                    gjettRes.Text = "Du har brukt opp dine forsøk! Tallet var: " + maskinTall + ". Vennligst trykk nytt spill";
                    btGjett.Enabled = false;
                }

                if (userTall == maskinTall)
                {
                    gjettRes.Text = "Du gjettet riktig! Tallet var: " + userTall;
                    btGjett.Enabled = false;
                }
                else if (userTall < maskinTall && _antForsok > 0)
                {
                    gjettRes.Text = "Svaret ditt er for lavt!";
                }
                else if (userTall > maskinTall && _antForsok > 0)
                {
                    gjettRes.Text = "Svaret ditt er for høyt!";
                }
                

                antForsok.Text = "Antall forsøk igjen: " + _antForsok;

                
            }
            else
            {
                gjettRes.Text = "Du skrev ikke inn ett tall!";
            }
        }

        private void btNytt_Click(object sender, EventArgs e)
        {
            maskinTall = randomTall.Next(maksVerdi);
            btGjett.Enabled = true;
            _antForsok = maksForsok;
            gjettInn.Text = "0";
            gjettInn.Enabled = true;
            gjettRes.Text = "";
            antForsok.Text = "Antall forsøk igjen: " + _antForsok;
            nyttLabel.Text = "";
        }

        #endregion

        #region Oppgave 3

        private void btPar_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(parOdd.Text))
            {
                if (parOdd.Text != "")
                {
                    int p = Convert.ToInt16(parOdd.Text.Substring(parOdd.Text.Length - 1));

                    if (p % 2 == 0)
                    {
                        parOutbx.Text = "Tallet: " + parOdd.Text + " er et partall!";
                    }
                    else
                    {
                        parOutbx.Text = "Tallet: " + parOdd.Text + " er er oddetall!";
                    }
                }
            }
            else
            {
                parOutbx.Text = "Du skrev ikke inn ett tall!";
            }
            
        }

        private void parOdd_TextChanged(object sender, EventArgs e)
        {
            btPar.PerformClick();
        }

        #endregion

        #region Oppgave 5
        
        private void btConv_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(convInn.Text))
            {
                int sekunder = Convert.ToInt32(convInn.Text);
                int dager = sekunder / 86400;
                sekunder = sekunder - (dager * 86400);
                int timer = sekunder / 3600;
                sekunder = sekunder - (timer * 3600);
                int minutter = sekunder / 60;
                sekunder = sekunder - (minutter * 60);

                string day;
                if (dager == 1)
                {
                    day = "" + dager + " dag, ";
                }
                else
                {
                    day = "" + dager + " dager, ";
                }
                

                string hour = "" + timer;
                string min = "" + minutter;
                string sek = "" + sekunder;


                if (timer < 10)
                {
                    hour = "0" + timer;
                }
                else
                {
                    hour = "" + timer;
                }
                if (minutter < 10)
                {
                    min = "0" + minutter;
                }
                else
                {
                    min = "" + minutter;
                }
                if (sekunder < 10)
                {
                    sek = "0" + sekunder;
                }
                else
                {
                    sek = "" + sekunder;
                }

                convOut.Text = day + hour + "timer, " + min + " minutter, " + sek + " sekunder";
            }
            else
            {
                convOut.Text = "Du skrev ikke inn ett tall!";
            }
            
            
        }

        #endregion

        //Funksjon som sjekker om en string kun har tall i seg
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        
    }
}
