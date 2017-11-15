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

        bool nyOpp = false;

        TextBox[] innData;

        List<Oppføring> bok = new List<Oppføring>();

        #endregion

        private void Adressebok_Load(object sender, EventArgs e)
        {
            innData = new TextBox[] { tbNyFNavn, tbNyENavn, tbNyAddr };
            pLogin.Location = new Point(0,0);

            foreach( Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
                p.Location = pLogin.Location;
            }

            pShow.Location = new Point(0, 27);
            pLogin.Visible = true;

            bok.Add(new Oppføring("Øyvind", "Skaaden", 94981952, "Butterudveien 10"));
            bok.Add(new Oppføring("Torje", "Eikenes", 92938293, "Nibbaveien 10"));
            bok.Add(new Oppføring("Nibb", "Nibbsen", 42069420, "Nibbstveien 69"));

            Presenter();
        }
        

        private void btLogin_Click(object sender, EventArgs e)
        {
            ShowPanel(pShow);
            m1.Visible = true;

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            ShowPanel(pSok);
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
            if (nyOpp)
            {
                index = bok.Count;
                bok.Add(new Oppføring(tbFNavn.Text, tbENavn.Text, Convert.ToInt32(numNr.Value), tbAddr.Text));
            }
            else if (!nyOpp)
            { 
                tbFNavn.Text = bok[index].Fornavn;
                tbENavn.Text = bok[index].Etternavn;
                numNr.Value = bok[index].Nummer;
                tbAddr.Text = bok[index].Adresse;
                starCheck.Checked = bok[index].Favoritt;
            }

            ShowPanel(pShow);
            Presenter();
        }

        private void Presenter()
        {
            try
            {
                tbFNavn.Text = bok[index].Fornavn;
                tbENavn.Text = bok[index].Etternavn;
                numNr.Value = bok[index].Nummer;
                tbAddr.Text = bok[index].Adresse;
                starCheck.Checked = bok[index].Favoritt;
            }
            catch
            {
                tbFNavn.Text = "Ingen lagrede adresser!";
            }
        }

        private void søkTM_Click(object sender, EventArgs e)
        {

        }

        private void newOpp_Click(object sender, EventArgs e)
        {
            nyOpp = true;
            ClearTB();
            btSave.Text = "Lagre ny";
            ShowPanel(pNew);
        }

        private void chOpp_Click(object sender, EventArgs e)
        {
            getNyTB();
            btSave.Text = "Endre";
            ShowPanel(pNew);
        }

        private void mSlett_Click(object sender, EventArgs e)
        {

        }

        #region Egene metoder

        // Skjuler alle paneler i form1, og viser det angitte panelet
        private void ShowPanel(Panel p)
        {
            foreach(Panel pa in this.Controls.OfType<Panel>())
            {
                pa.Visible = false;
            }
            p.Visible = true;
        }

        private void ClearTB()
        {
            foreach (TextBox tb in innData)
            {
                tb.Text = "";
            }
            numNyNr.Value = 0;
        }

        private void getNyTB()
        {
            tbNyFNavn.Text = bok[index].Fornavn;
            tbNyENavn.Text = bok[index].Etternavn;
            numNyNr.Value = bok[index].Nummer;
            tbNyAddr.Text = bok[index].Adresse;
            checkSave.Checked = bok[index].Favoritt;
        }

        #endregion
    }
}
