using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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

        string pathDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string file = "myContacs.csv";
        string pathFile;

        char delimiter = ',';

        #endregion

        private void Adressebok_Load(object sender, EventArgs e)
        {
            pathFile = pathDocuments + "\\" + file;
            innData = new TextBox[] { tbNyFNavn, tbNyENavn, tbNyAddr };
            pLogin.Location = new Point(0,0);

            foreach( Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
                p.Location = pLogin.Location;
            }

            pShow.Location = new Point(0, 27);
            pLogin.Visible = true;

            numNr.Maximum = Decimal.MaxValue;
            numNyNr.Maximum = Decimal.MaxValue;

            /*
            bok.Add(new Oppføring("Øyvind", "Skaaden", 94981952, "Butterudveien 10"));
            bok.Add(new Oppføring("Torje", "Eikenes", 92938293, "Nibbaveien 10"));
            bok.Add(new Oppføring("Nibb", "Nibbsen", 42069420, "Nibbstveien 69"));
            */
            //WriteFile();
            ReadFile();

            Presenter();
        }
        

        private void btLogin_Click(object sender, EventArgs e)
        {
            ShowPanel(pShow);
            m1.Visible = true;

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            sokList.Rows.Clear();

            string search = tbSok.Text.ToUpper();
            int i = 0;
            foreach (Oppføring p in bok)
            {
                i++;
                if (p.Fornavn.ToUpper().Contains(search) || 
                    p.Etternavn.ToUpper().Contains(search)|| 
                    p.Adresse.ToUpper().Contains(search)|| 
                    Convert.ToString(p.Nummer).ToUpper().Contains(search))
                {
                    sokList.Rows.Add("" + i, p.Etternavn + ", " + p.Fornavn, Convert.ToString(p.Nummer), p.Adresse);
                }
            }
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
                bok.Add(new Oppføring(tbNyFNavn.Text, tbNyENavn.Text, Convert.ToInt32(numNyNr.Value), tbNyAddr.Text));
            }
            else if (!nyOpp)
            { 
                bok[index].Fornavn = tbNyFNavn.Text;
                bok[index].Etternavn = tbNyENavn.Text;
                bok[index].Nummer = numNyNr.Value;
                bok[index].Adresse = tbNyAddr.Text;
                bok[index].Favoritt = checkSave.Checked;
            }

            ShowPanel(pShow);
            WriteFile();
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
                labPlass.Text = "" + (index + 1);
            }
            catch
            {
                tbFNavn.Text = "Ingen lagrede adresser!";
            }
        }

        private void søkTM_Click(object sender, EventArgs e)
        {
            ShowPanel(pSok);
            btSok.PerformClick();
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
            nyOpp = false;
            btSave.Text = "Endre";
            ShowPanel(pNew);
        }

        private void mSlett_Click(object sender, EventArgs e)
        {

            bok.RemoveAt(index);
            index = 0;
            WriteFile();
            Presenter();
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

        private void Cancel(object sender, EventArgs e)
        {
            ShowPanel(pShow);
            Presenter();
        }

        private void getSearch(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(sokList.Rows[e.RowIndex].Cells[0].Value) - 1;
            Presenter();
            ShowPanel(pShow);
        }

        #endregion

        #region Lese og skrive til fil

        private void WriteFile()
        {
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile).Close();
            }

            File.WriteAllText(pathFile, "");

            using (StreamWriter sw = new StreamWriter(pathFile))
            {
                foreach (Oppføring p in bok)
                {
                    sw.WriteLine(p.Fornavn + delimiter + p.Etternavn + delimiter + p.Nummer + delimiter + p.Adresse + delimiter + p.Favoritt);
                }
            }
        }

        private void ReadFile()
        {
            if (File.Exists(pathFile))
            {
                bok.Clear();
                using(StreamReader sr = new StreamReader(pathFile))
                {
                    while (!sr.EndOfStream)
                    {
                        var data = sr.ReadLine().Split(delimiter);
                        bok.Add(new Oppføring(data[0], data[1], Convert.ToDecimal(data[2]), data[3], Convert.ToBoolean(data[4])));
                    }
                }
            }
            bok.Sort((x, y) => x.Etternavn.CompareTo(y.Etternavn));
        }
        

        #endregion
    }
}