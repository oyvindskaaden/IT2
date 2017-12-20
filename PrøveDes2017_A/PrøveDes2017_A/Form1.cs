using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrøveDes2017_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        #region O1 Animasjon

        private void luke20_Click(object sender, EventArgs e)
        {
            if ((string)luke20.Tag == "Lukket")
            {
                luke20.Image = Properties.Resources.God_Jul_gifanim;
                luke20.BackColor = Color.White;
                luke20.Tag = "Åpnet";
            } else
            {
                luke20.Tag = "Lukket";
                luke20.Image = Properties.Resources._20;
                luke20.BackColor = Color.Transparent;
            }
        }

        #endregion

        #region O2 Array

        // Chars som skal sammenliknes
        char sisteBok = 'e';
        char forsteBok = 'S';


        private void btO2_Click(object sender, EventArgs e)
        {
            //Variabler som passer på antall ganger kriteriene i oppgaven holder
            int ant1 = 0, ant2 = 0;

            string[] steder = { "Rud", "Kolsås", "Vettre", "Skui", "Sandvia", "Hosle" };

            // Sjekker siste bokstav
            foreach (string s in steder)
            {
                if (s[s.Length - 1] == sisteBok)
                    ant1++;
            }

            // Sjekker første bokstav
            for (int i = 0; i < steder.Length; i++)
            {
                if (steder[i][steder[i].Length - 1] == sisteBok)
                    ant2++;
            }

            // Printer til lables
            lbO2a.Text = "" + ant1;
            lbO2b.Text = "" + ant2;
        }

        #endregion

        #region O3 Funksjoner
        string a = "God";
        string b = "Jul";
        string c = "";

        private void Hilsen()
        {
            c = a + " " + b;
        }

        private void Hilsen(string d)
        {
            c = d + " " + a + " " + b;
        }

        private decimal Gjennomsnitt(int[] t)
        {
            decimal s = 0;
            int ant = 0;

            foreach (int i in t)
            {
                s += i;
                ant++;
            }

            return s / ant;
        }

        private void btO3a_Click(object sender, EventArgs e)
        {
            Hilsen();
            lbO3a.Text = Convert.ToString(c);
        }

        private void btO3b_Click(object sender, EventArgs e)
        {
            Hilsen("HoHo");
            lbO3b.Text = Convert.ToString(c);
        }

        private void btO3c_Click(object sender, EventArgs e)
        {
            int[] tall = {2,5,7,8,9,12};
            lbO3c.Text = Convert.ToString(Gjennomsnitt(tall));
        }

        #endregion

        #region O4 Forklar kode

        // Koden under sorterer ut de oppføringene som inneholder textBox1 og legger de i listBox1. 
        // Dersom du klikker på en av oppføringene i listBox1 vil mer info bli printet ut i richTextBox1

        // Definerer den todimensjonale listen personer med personinfo, fornavn etternavn og nummer i global string variabel.
        string[,] personer = { { "Roar", "Holmsen", "3456" }, { "Kari", "Imsen", "345699" }, { "Ola", "Jansen", "13123456" }, { "Kari", "Jeppsen", "0768556" }, { "Mari", "Ek", "987667" }, { "Per", "Faust", "998877654" } };
        // Int for å holde styr på hvor mange oppføringer det er i listBox1 i global int variabel
        int[] s;

        // Clickevent for btO4
        private void btO4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Tømmer listBox1 så vi kan starte med en tom listBox
            s = new int[personer.Length]; // Definerer s som et int-array med lengde lik lengden av arrayet personer
            int x = -1; // Lager lokal variabel som kun skal inkrementere når if-løkken er sann

            // For-løkke som går gjennom alle navn gruppene. 
            for (int i = 0; i < personer.GetLength(0); i++)
            {
                // Denne if-løkken sjekker om det som er skrevet i textbox1 er inneholdt i nummeret til en av oppføringene
                if (personer[i, 2].Contains(textBox1.Text))
                {
                    // Hvis textbox1 er inneholdt i oppføringen som sjekkes vil x inkrementere og plasseringen av oppføringen er lagret i variabelen s
                    x++;
                    s[x] = i; // Ved plassering 'x' i 's' legg til 'i'.
                    // Legger til oppføringen i listBox1 som inneholdt textBox1
                    listBox1.Items.Add(personer[i, 0] + ", " + personer[i, 2]);
                }
            }
        }

        // Dersom en bruker klikker på en av oppføringene i listBox1 vil denne eventen skje
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Henter ut linjen du klikket på og viser oppføringen i richTextBox1 med mer info.
            int i = s[listBox1.SelectedIndex]; // Definerer lokalvariabel og gir den verdien til plassering av oppføring i personer (trengs ikke)
            // Linjen under legger til info i richTextBox1 ved plassering 'i'. (Her er ikke 'i' brukt men fungerer på samme måte, men mye lengre
            richTextBox1.Text = personer[s[listBox1.SelectedIndex], 0] + ", " + personer[s[listBox1.SelectedIndex], 1] + ", " + personer[s[listBox1.SelectedIndex], 2];
            // Linjen over kunne vært skrevet:
            // richTextBox1.Text = personer[i, 0] + ", " + personer[i, 1] + ", " + personer[i, 2];
        }

        #endregion

        #region O5 Global og lokal variabel

        // Fra koden i oppgave 4 oppgir du en variabel som er global og en som er lokal.
        // Fyll ut ditt valg i linjene under:

        // Eks. på en global variabel: 
        // int[] s;

        // Eks. på en lokal variabel: 
        // int x = -1;

        #endregion

    }
}