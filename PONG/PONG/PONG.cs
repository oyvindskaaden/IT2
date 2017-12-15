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

        Bat[] bats;
        #endregion 

        private void PressedKey(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W: bats[1].MoveUp(); break;
                case Keys.S: bats[1].MoveDown(); break;
                case Keys.Up: bats[0].MoveUp(); break;
                case Keys.Down: bats[0].MoveDown(); break;
            }
        }

        private void PONG_Load(object sender, EventArgs e)
        {
            bats = new Bat[2] { new Bat(this, 'R', false), new Bat(this, 'L', false) };
        }

        private void resizeGame(object sender, EventArgs e)
        {
            foreach(Bat b in bats)
            {
                b.UpdateSize(this);
            }
        }

    }
}
