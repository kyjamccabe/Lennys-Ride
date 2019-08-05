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
        public Image rockImage;//variable for the planet's image

        public Rectangle rockRec;//variable for a rectangle to place our image in
        public int score;
        
        //Create a constructor (initialises the values of the fields)
        public Rock()
        {
            x = 500;
            y = 315;
            width = 50;
            height = 40;
            rockImage = Image.FromFile("rock1.png");
            rockRec = new Rectangle(x, y, width, height);
        }
        
        // Methods for the Planet class
        public void drawRock(Graphics g)
        {
            g.DrawImage(rockImage, rockRec);
        }

        public void moveRock()
        {
            x -= 5;
            rockRec.Location = new Point(x, y);
        }

    }
}
