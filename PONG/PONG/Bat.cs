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
        decimal yPos;

        // Hastighet og faktor for å regne det ut
        int speed;
        int speedFactor = 1;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        /// <param name="player"></param>
        /// <param name="AI"></param>
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

            speed = gameHeight * speedFactor / 100;

            bat.Image = Properties.Resources.pixel;
            bat.Size = new Size(size, batHeight);
            bat.SizeMode = PictureBoxSizeMode.StretchImage;
            bat.Location = new Point(xPos, Convert.ToInt32(yPos));

            form.Controls.Add(bat);
                        
        }
        #endregion

        #region Public metoder

        /// <summary>
        /// Updates the size, position and the speeds for the bat
        /// </summary>
        /// <param name="form">Form you call this from</param>
        public void UpdateSize(Form form)
        {

            int oldHeight = gameHeight;
            int oldBatH = batHeight;

            gameWidth = form.ClientRectangle.Width;
            gameHeight = form.ClientRectangle.Height;

            size = gameWidth * sizeFactor / 100;

            batHeight = gameHeight * batHeightFactor / 10;

            yPos = (gameHeight * yPos) / oldHeight;
            //yPos = (gameHeight / 2) - (batHeight / 2);

            Console.WriteLine(yPos);
            if (!leftPlayer)
                xPos = gameWidth - (2 * size);
            else
                xPos = size;

            speed = gameHeight * speedFactor / 100;
            
            bat.Size = new Size(size, batHeight);
            UpdatePos(xPos, Convert.ToInt32(yPos));
            
        }

        /// <summary>
        /// Moves the bat up
        /// </summary>
        public void MoveUp()
        {
            if (yPos >= speed)
            {
                yPos -= speed;
            }
            UpdatePos(xPos, Convert.ToInt32(yPos));
        }

        /// <summary>
        /// Moves the bat down
        /// </summary>
        public void MoveDown()
        {
            if (yPos <= (gameHeight - batHeight - speed))
            {
                yPos += speed;
            }
            UpdatePos(xPos, Convert.ToInt32(yPos));
        }

        /// <summary>
        /// Updates the position of the bat
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void UpdatePos(int x, int y)
        {
            bat.Location = new Point(x, y);
        }
        #endregion
    }
}
