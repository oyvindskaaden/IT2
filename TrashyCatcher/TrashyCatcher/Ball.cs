using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashyCatcher
{
    class Ball
    {
        int xPos;
        int yPos;
        int a = 8;

        double dX;
        double dY;

        private PictureBox ball;
        string imgFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ball.png";



        public Ball() { }

        public Ball(int startX, int startY, double degrees, int force, Form form)
        {
            xPos = startX;
            yPos = startY;

            double phi = Math.PI * degrees / 180.0;
            dX = Math.Cos(phi) * force;
            dY = Math.Sin(phi) * force;

            Console.WriteLine(dX + " - " + dY);

            ball = new PictureBox();
            ball.Image = Image.FromFile(imgFile);
            ball.Size = new Size(50, 50);
            ball.Location = new Point(xPos, yPos);
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.BackColor = Color.Transparent;
            form.Controls.Add(ball);

        }

        public void Update()
        {

        }
    }
}
