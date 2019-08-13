using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmRide
{
    public partial class frmRide : Form
    {

        bool left, right;
        bool jump;
        int Gravity = 1;
        int YSpeed = 20;
        bool NotOnGround = true;
        string move;

        Graphics g; //declare a graphics object called g
        Player player = new Player();
        Rock rock1 = new Rock(); //create the object, planet1


        public frmRide()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
        }

        private void frmRide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { jump = true; }
        }

        private void frmRide_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.movePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.movePlayer(move);
            }
            if (jump == true)
            {
                move = "jump";
                if (NotOnGround == true)
                {
                    YSpeed = YSpeed - Gravity;
                    player.y = player.y - YSpeed;
                    player.movePlayer(move);
                }
                if (player.y < 300)
                {
                    NotOnGround = true;
                    player.movePlayer(move);
                }
                if (player.y == 300)
                {
                    YSpeed = 20;
                    jump = false;
                    player.movePlayer(move);
                }
            }
            pnlGame.Invalidate(); //makes the paint event fire to redraw the panel
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            player.drawPlayer(g);
            rock1.drawRock(g);
        }
    }
}
