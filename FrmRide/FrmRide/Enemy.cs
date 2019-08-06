using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FrmRide
{
    class Enemy
    {
        public int x, y, width, height;//variables for the rectangle
        public Image enemyImage;//variable for the planet's image

        public Rectangle enemyRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Enemy(int spacing)
        {
            x = spacing;
            y = 10;
            width = 50;
            height = 50;
            enemyImage = Image.FromFile("enemy.png");
            enemyRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void drawEnemy(Graphics g)
        {
            enemyRec = new Rectangle(x, y, width, height);
            g.DrawImage(enemyImage, enemyRec);
        }

    }
}
