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

        }

        private void DoSearch(object sender, EventArgs e)
        {

        }

        private void Presenter()
        {
            try
            {
                tbFNavn.Text = bok[index].Fornavn;
                tbENavn.Text = bok[index].Etternavn;
                tbNr.Text = "" + bok[index].Nummer;
                tbAddr.Text = bok[index].Adresse;
            }
            catch
            {
                tbFNavn.Text = "Ingen lagrede adresser!";
            }
        }
    }
}
