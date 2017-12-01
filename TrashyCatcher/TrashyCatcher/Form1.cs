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

        List<Ball> baller = new List<Ball>();

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            //baller.Clear();
            //baller.Add(new Ball(rnd.Next(this.Width), rnd.Next(this.Height), 40, 40, this));

            baller.Add(new Ball(40, 100 ,rnd.Next(89), rnd.Next(10,100), this));
        }

        private void Update(object sender, EventArgs e)
        {
            //baller[0].Update();
            foreach (Ball b in baller)
            {
                b.Update(this);
            }
        }

        private void Spill_Load(object sender, EventArgs e)
        {
            tick.Start();
        }
    }
}
