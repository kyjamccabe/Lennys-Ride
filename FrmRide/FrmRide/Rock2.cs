using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FrmRide
{
    class Rock2
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image rock2;//variable for the rock2's image

        public Rectangle rock2Rec;//variable for a rectangle to place our image in
        Random rnd = new Random();

        //Create a constructor (initialises the values of the fields)
        public Rock2()
        {
            x = 600;
            y = 315;
            width = 45;
            height = 60;
            rock2 = Image.FromFile("rock2.png");
            rock2Rec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void drawRock2(Graphics g)
        {
            g.DrawImage(rock2, rock2Rec);
        }

        public void moveRock2()
        {
            if (x <= -10)
            {
                x = 600 + rnd.Next(100, 600);
                rock2Rec.Location = new Point(x, y);
            }
            else
            {
                x -= 5;
                rock2Rec.Location = new Point(x, y);
            }
        }
    }
}
