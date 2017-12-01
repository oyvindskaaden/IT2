using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashyCatcher
{
    public partial class Spill : Form
    {
        public Spill()
        {
            InitializeComponent();
        }

        Ball ball1;

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            ball1 = new Ball(rnd.Next(this.Width), rnd.Next(this.Height), 40, 40, this);
        }
    }
}
