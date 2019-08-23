using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FrmRide
{
    class Player
    {

        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image player;//variable for the player's image
        int count;
        Image[] images = new Image[9];

        public Rectangle playerRec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)
        public Player()
        {
            x = 10;
            y = 300;
            width = 70;
            height = 60;
            player = Image.FromFile("player.png");
            playerRec = new Rectangle(x, y, width, height);
        }

        //methods
        public void drawPlayer(Graphics g)
        {
            g.DrawImage(player, playerRec);
        }

        public void movePlayer(string move)
        {
            playerRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (playerRec.Location.X > 470) // is player within 50 of right side
                {

                    x = 470;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    playerRec.Location = new Point(x, y);
                }

            }

            if (move == "left")
            {
                if (playerRec.Location.X < 10) // is player within 10 of left side
                {

                    x = 10;
                    playerRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    playerRec.Location = new Point(x, y);
                }
            }
        }

        public void anim1()
        {
            for (int i = 1; i <= 8; i++)
            { 
                images[i] = Image.FromFile("walk" + i.ToString() + ".png");
            }
            player = images[1];            
        }

        public void anim2()
        {
            player = images[count];
            count++;
            if (count > 8)
            {
                count = 1;
            }
        }
    }
}
