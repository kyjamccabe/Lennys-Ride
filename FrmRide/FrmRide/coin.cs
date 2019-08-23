using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FrmRide
{
    class Coin
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image coin;//variable for the coin's image

        public Rectangle coinRec;//variable for a rectangle to place our image in
        Random rnd = new Random(); //Generate random number

        //Create a constructor (initialises the values of the fields)
        public Coin()
        {
            x = 550;
            y = 315;
            width = 30;
            height = 30;
            coin = Image.FromFile("coin.png");
            coinRec = new Rectangle(x, y, width, height);
        }

        public void drawCoin(Graphics g)
        {
            g.DrawImage(coin, coinRec); //Draw coin image
        }

        public void moveCoin()
        {
            if (x <= -50) //If coin is to the left of the screen
            {
                x = 500 + rnd.Next(100, 600); //Move to a random position on the right
                coinRec.Location = new Point(x, y);
            }
            else //If coin is anywhere else
            {
                x -= 5; //Move coin 5 to the left
                coinRec.Location = new Point(x, y);
            }
            if (x == 540) //If coin is to the right of the screen
            {
                y = 200 + rnd.Next(-10, 10); //Move to a random y position between -10 and 10 difference to the old one
            }
        }
    }
}
