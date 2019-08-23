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
        Random rnd = new Random(); //Generate a random number

        //Create a constructor (initialises the values of the fields)
        public Rock2()
        {
            x = 900;
            y = 310;
            width = 50;
            height = 90;
            rock2 = Image.FromFile("rock2.png");
            rock2Rec = new Rectangle(x, y, width, height);
        }

        public void drawRock2(Graphics g)
        {
            g.DrawImage(rock2, rock2Rec); //Draw rock image
        }

        public void moveRock2()
        {
            if (x <= -50) //If rock is to the left of the screen
            {
                x = 500 + rnd.Next(50, 600); //Move back to a random position on the right
                rock2Rec.Location = new Point(x, y);
            }
            else //If rock is anywhere else
            {
                x -= 2; //Move 2 to the left
                rock2Rec.Location = new Point(x, y);
            }
        }
    }
}
