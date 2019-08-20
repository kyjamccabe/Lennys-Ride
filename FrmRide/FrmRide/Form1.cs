﻿using System;
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
        int score = 0;
        bool NotOnGround = true;
        string move;

        Graphics g; //declare a graphics object called g
        Player player = new Player();
        Rock rock = new Rock(); //create the object, planet1
        Rock2 rock2 = new Rock2();
        Coin coin = new Coin();
        Random rnd = new Random();


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

        private void tmrRock_Tick(object sender, EventArgs e)
        {
            rock.moveRock();
            rock2.moveRock2();
            coin.moveCoin();

            if (rock.rockRec.IntersectsWith(rock2.rock2Rec))
            {
                rock2.x = 550;
            }

            if (player.playerRec.IntersectsWith(rock.rockRec))
            {
                tmrRock.Enabled = false;
                tmrPlayer.Enabled = false;
            }

            if (player.playerRec.IntersectsWith(rock2.rock2Rec))
            {
                tmrRock.Enabled = false;
                tmrPlayer.Enabled = false;
            }

            if (player.playerRec.IntersectsWith(coin.coinRec))
            {
                score += 1;
                lblScore.Text = score.ToString();
                coin.x = 500 + rnd.Next(100, 600);
            }

            speed();

            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            player.drawPlayer(g);
            rock.drawRock(g);
            rock2.drawRock2(g);
            coin.drawCoin(g);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrRock.Enabled = true;
            tmrPlayer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrRock.Enabled = false;
            tmrPlayer.Enabled = false;
        }

        private void speed()
        {
            if (score >= 5)
            {
                rock2.x -= 2;
                rock.x -= 2;
            }

            if (score >= 10)
            {
                rock2.x -= 2;
                rock.x -= 2;
            }

            if (score >= 15)
            {
                rock2.x -= 2;
                rock.x -= 2;
            }

            if (score >= 20)
            {
                rock2.x -= 2;
                rock.x -= 2;
            }
        }
    }
}
