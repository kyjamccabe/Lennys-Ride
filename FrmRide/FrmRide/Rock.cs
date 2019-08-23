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
        Random rnd = new Random(); //Generate a random number
        
        //Create a constructor (initialises the values of the fields)
        public Rock()
        {
            x = 550;
            y = 315;
            width = 50;
            height = 40;
            rock = Image.FromFile("rock1.png");
            rockRec = new Rectangle(x, y, width, height);
        }
        
        public void drawRock(Graphics g)
        {
            g.DrawImage(rock, rockRec); //Draw rock image
        }

        public void moveRock()
        {
            if (x <= -50) //If rock is to the left of the screen
            {
                x = 500 + rnd.Next(100, 600); //Move back to a random position on the right
                rockRec.Location = new Point(x, y);
            }
            else //If rock is anywhere else
            {
                x -= 2; //Move 2 to the left
                rockRec.Location = new Point(x, y);
            }
        }
    }
}
