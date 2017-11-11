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

        List<Oppføring> bok = new List<Oppføring>();

        private void Adressebok_Load(object sender, EventArgs e)
        {
            foreach( Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
                p.Location = pLogin.Location;
            }

            pLogin.Visible = true;


            bok.Add(new Oppføring("Øyvind", "Skaaden", 94981952, "Butterudveien 10"));
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            pShow.Visible = true;

            tbFNavn.Text = bok[0].Fornavn;
            tbENavn.Text = bok[0].Etternavn;
            tbNr.Text = "" + bok[0].Nummer;
            tbAddr.Text = bok[0].Adresse;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            pShow.Visible = false;
            pSok.Visible = true;
        }

        private void btNav(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void DoSearch(object sender, EventArgs e)
        {

        }
    }
}
