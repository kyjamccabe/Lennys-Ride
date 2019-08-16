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
        Random rnd = new Random();

        //Create a constructor (initialises the values of the fields)
        public Coin()
        {
            x = 520;
            y = 315;
            width = 30;
            height = 30;
            coin = Image.FromFile("coin.png");
            coinRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void drawCoin(Graphics g)
        {
            g.DrawImage(coin, coinRec);
        }

        public void moveCoin()
        {
            if (x <= -50)
            {
                x = 500 + rnd.Next(100, 600);
                coinRec.Location = new Point(x, y);
            }
            else
            {
                x -= 5;
                coinRec.Location = new Point(x, y);
            }
            if (x == 500)
            {
                y = 200 + rnd.Next(-10, 10);
            }
        }
    }
}
