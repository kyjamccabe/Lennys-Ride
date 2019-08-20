using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FrmRide
{
    class Rock
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image rock;//variable for the rock's image

        public Rectangle rockRec;//variable for a rectangle to place our image in
        Random rnd = new Random();
        
        //Create a constructor (initialises the values of the fields)
        public Rock()
        {
            x = 500;
            y = 315;
            width = 50;
            height = 40;
            rock = Image.FromFile("rock1.png");
            rockRec = new Rectangle(x, y, width, height);
        }
        
        // Methods for the Planet class
        public void drawRock(Graphics g)
        {
            g.DrawImage(rock, rockRec);
        }

        public void moveRock()
        {
            if (x <= -50)
            {
                x = 500 + rnd.Next(100, 600);
                rockRec.Location = new Point(x, y);
            }
            else
            {
                x -= 2;
                rockRec.Location = new Point(x, y);
            }
        }
    }
}
