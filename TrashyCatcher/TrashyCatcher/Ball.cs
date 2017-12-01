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

        double a = 0.9;
        double dX;
        double dY;

        private PictureBox ball;
        string imgFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ball.png";

        public Ball() { }

        public Ball(int startX, int startY, double degrees, int force, Form form)
        {
            xPos = startX;
            yPos = form.Height - startY;

            double phi = Math.PI * degrees / 180.0;
            dX = Math.Cos(phi) * force/2;
            dY = Math.Sin(phi) * force/2;

            Console.WriteLine(dX + " - " + dY);

            ball = new PictureBox();
            ball.Image = Image.FromFile(imgFile);
            ball.Size = new Size(50, 50);
            ball.Location = new Point(xPos, yPos);
            ball.SizeMode = PictureBoxSizeMode.Zoom;
            ball.BackColor = Color.Transparent;
            ball.Anchor = AnchorStyles.None;
            form.Controls.Add(ball);
        }

        public void Update(Form form)
        {
            xPos = ball.Location.X + (int)dX;
            yPos = ball.Location.Y - (int)dY;
            dY -= a;
            if (xPos > form.Width + 25 || yPos > form.Height + 25)
            {
                Delete(form);
            }
            ball.Location = new Point(xPos, yPos);
        }
        private void Delete(Form form)
        {
            form.Controls.Remove(ball);
        }
    }
}
