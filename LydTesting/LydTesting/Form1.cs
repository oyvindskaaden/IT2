using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LydTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sp = new SoundPlayer();

        private void btStart1_Click(object sender, EventArgs e)
        {

            sp.SoundLocation = @"C:\Users\Øyvind Skaaden\Downloads\14_Ukelele.wav";
            sp.Load();
            sp.Play();
        }

        private void btStart2_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
    }
}
