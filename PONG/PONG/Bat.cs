using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PONG
{
    class Bat
    {
        #region Variabler


        int xPos;
        int yPos;

        int gameWidth;
        int gameHeight;
        
        // Margin for Bat fra kantene
        int size;
        int sizeFactor = 3;

        // Bool for hvilken spiller det er
        Boolean leftPlayer;

        int batHeight;
        int batHeightFactor = 3;

        PictureBox bat = new PictureBox();

        #endregion

        #region Konstruktører

        public Bat() { }

        public Bat(Form form, Char player, Boolean AI)
        {
            gameWidth = form.ClientRectangle.Width;
            gameHeight = form.ClientRectangle.Height;

            size = gameWidth * sizeFactor / 100;

            batHeight = gameHeight * batHeightFactor / 10;

            yPos = (gameHeight / 2) - (batHeight / 2);
            
            switch (player)
            {
                case 'R': xPos = gameWidth - (2 * size); leftPlayer = false; break;
                case 'L': xPos = size; leftPlayer = true; break;
            }

            bat.Image = Properties.Resources.pixel;
            bat.Size = new Size(size, batHeight);
            bat.SizeMode = PictureBoxSizeMode.StretchImage;
            bat.Location = new Point(xPos, yPos);

            form.Controls.Add(bat);
                        
        }
        #endregion

        #region Public metoder

        public void UpdateSize(Form form)
        {

            gameWidth = form.ClientRectangle.Width;
            gameHeight = form.ClientRectangle.Height;

            size = gameWidth * sizeFactor / 100;

            batHeight = gameHeight * batHeightFactor / 10;

            yPos = (gameHeight / 2) - (batHeight / 2);

            if (leftPlayer)
                xPos = gameWidth - (2 * size);
            else
                xPos = size;
            
            bat.Size = new Size(size, batHeight);
            bat.Location = new Point(xPos, yPos);
            
        }
        #endregion
    }
}
