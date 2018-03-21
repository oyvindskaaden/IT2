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

namespace ChartTing
{
    public partial class karakterviser : Form
    {
        public karakterviser()
        {
            InitializeComponent();
        }

        #region Globale variabler
        string file = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Karakterer.csv" ;
        char delimiter = ',';
        List<Karakterer> Data = new List<Karakterer>();
        string[] navn;
        #endregion

        private void karakterviser_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                int currentLine = 0;
                while (!sr.EndOfStream)
                {
                    string read = sr.ReadLine();
                    var data = read.Split(delimiter);

                    if (currentLine != 0)
                    {
                        int[] kar = new int[data.Length - 1];

                        for(int i = 1; i < data.Length; i++)
                            kar[i - 1] = Convert.ToInt32(data[i]);

                        Data.Add(new Karakterer(data[0], kar));
                    }
                    else
                        navn = data;
                    currentLine++;

                }

            }

            foreach (Karakterer k in Data)
            {
                chartKarakterer.Series.Add(k.Name);
                checkData.Items.Add(k.Name);
                for (int i = 0; i<k.Karakter.Length; i++)
                {
                    //chartKarakterer.ChartAreas[0].Axes[1].CustomLabels.Add(navn[i])
                    chartKarakterer.Series[k.Name].Points.AddXY(i, k.Karakter[i]);
                }
                chartKarakterer.Series[chartKarakterer.Series.Count - 1].Enabled = false;
            }

        }

        private void ShowList(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            checkData.Visible = c.Checked;
        }

        private void ChangeData(object sender, EventArgs e)
        {
            for (int i = 0; i < checkData.Items.Count; i++) {
                chartKarakterer.Series[i].Enabled = checkData.GetItemChecked(i);
            }
        }
    }
}
