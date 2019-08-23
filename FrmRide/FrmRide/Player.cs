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

        //Declare fields to use in the class
        public int x, y, width, height;//Variables for the rectangle
        public Image player;//Variable for the player's image
        int count;
        Image[] images = new Image[9]; //Declare array

        public Rectangle playerRec;//Variable for a rectangle to place our image in
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

        public void drawPlayer(Graphics g)
        {
            g.DrawImage(player, playerRec); //Draw player image
        }

        public void movePlayer(string move)
        {
            playerRec.Location = new Point(x, y); //Move playerrec to the x and y values

            if (move == "right") //If right arrow is pressed
            {
                if (playerRec.Location.X > 470) //If player is within 50 of right side
                {
                    x = 470; //Stop moving
                    playerRec.Location = new Point(x, y);
                }
                else //If player is anywhere else
                {
                    x += 5; //Move 5 to the right
                    playerRec.Location = new Point(x, y);
                }

            }

            if (move == "left") //If left arrow pressed
            {
                if (playerRec.Location.X < 10) //If player within 10 of left side
                {

                    x = 10; //Stop moving
                    playerRec.Location = new Point(x, y);
                }
                else //If player is anywhere else
                {
                    x -= 5; //Move 5 to the left
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
