using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    public partial class PONG : Form
    {
        public PONG()
        {
            InitializeComponent();
        }

        #region Variabler

        Bat bats;
        #endregion 

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'n': bats = new Bat(this, 'R', false); break;
            }
        }
    }
}
