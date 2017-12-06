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

        Form gameForm;

        int xPos;
        int yPos;

        int gameWidth;
        int gameHeight;
        
        // Margin for Bat fra kantene
        int size;
        int sizeFactor = 5;

        int batHeight;
        int batHeightFactor = 2;

        #endregion

        #region Konstruktører

        public Bat() { }

        public Bat(Form form, Char player, Boolean AI)
        {
            gameForm = form;
            gameWidth = gameForm.ClientRectangle.Width;
            gameHeight = gameForm.ClientRectangle.Height;

            size = gameWidth * sizeFactor / 100;

            batHeight = gameHeight * batHeightFactor / 10;

            yPos = (gameHeight / 2) - (batHeight / 2);
            
            switch (player)
            {
                case 'R': xPos = gameWidth - (2 * size); break;
                case 'L': xPos = size;  break;
            }

            Rectangle bat = new Rectangle(xPos, yPos, size, batHeight);
                        
        }
        #endregion
    }
}
