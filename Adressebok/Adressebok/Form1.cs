using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressebok
{
    public partial class adressebok : Form
    {
        public adressebok()
        {
            InitializeComponent();
        }

        #region Globale variabler

        int index = 0;

        bool edited = false;
        bool present = false;

        List<Oppføring> bok = new List<Oppføring>();

        #endregion

        private void Adressebok_Load(object sender, EventArgs e)
        {
            foreach( Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
                p.Location = pLogin.Location;
            }

            pLogin.Visible = true;

            bok.Add(new Oppføring("Øyvind", "Skaaden", 94981952, "Butterudveien 10"));
            bok.Add(new Oppføring("Torje", "Eikenes", 92938293, "Nibbaveien 10"));
            bok.Add(new Oppføring("Nibb", "Nibbsen", 42069420, "Nibbstveien 69"));

            Presenter();
        }
        

        private void btLogin_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            pShow.Visible = true;

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            pShow.Visible = false;
            pSok.Visible = true;
        }

        private void btNav(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Text)
            {
                case "<--":
                    index--;
                    if (index < 0)
                        index = 0;
                    break;
                case "-->":
                    index++;
                    if (index >= bok.Count)
                        index = bok.Count - 1;
                    break;
            }
            Presenter();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            btSave.Visible = false;
            btNy.Visible = true;

            if (!edited && index == bok.Count)
            {
                bok.Add(new Oppføring(tbFNavn.Text, tbENavn.Text, Convert.ToInt32(tbNr.Text), tbAddr.Text));
            }
            else if (edited)
            {
                tbFNavn.Text = bok[index].Fornavn;
                tbENavn.Text = bok[index].Etternavn;
                tbNr.Text = "" + bok[index].Nummer;
                tbAddr.Text = bok[index].Adresse;
                starCheck.Checked = bok[index].Favoritt;
            }

            edited = false;
        }

        private void DoSearch(object sender, EventArgs e)
        {

        }

        private void Presenter()
        {
            present = true;
            try
            {
                tbFNavn.Text = bok[index].Fornavn;
                tbENavn.Text = bok[index].Etternavn;
                tbNr.Text = "" + bok[index].Nummer;
                tbAddr.Text = bok[index].Adresse;
                starCheck.Checked = bok[index].Favoritt;
            }
            catch
            {
                tbFNavn.Text = "Ingen lagrede adresser!";
            }
        }

        private void updateFav(object sender, EventArgs e)
        {
            bok[index].Favoritt = starCheck.Checked; 
            Presenter();

        }

        private void btNy_Click(object sender, EventArgs e)
        {
            index = bok.Count;

            tbFNavn.Text = "";
            tbENavn.Text = "";
            tbNr.Text = "";
            tbAddr.Text = "";
            starCheck.Checked = false;

        }

        private void chBt(object sender, EventArgs e)
        {
        }

        private void chBt(object sender, KeyPressEventArgs e)
        {

            if (!present)
            {
                btNy.Visible = false;
                btSave.Visible = true;
                edited = true;
                    
                if (index != bok.Count)
                {
                    btSave.Text = "Lagre endringer";
                }
                else if (index == bok.Count)
                {
                    btSave.Text = "Lagre ny";
                }
            }
            present = false;
        }
    }
}
