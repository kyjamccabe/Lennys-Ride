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

        bool left, right, jump, reset;
        bool text;
        bool bugfix;
        int Gravity = 1;
        int YSpeed = 20;
        int score = 0;
        int highscore = 0;
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
            player.anim1();
        }

        private void frmRide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { jump = true; }
            if (e.KeyData == Keys.R) { reset = true;  }
        }

        private void frmRide_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.R) { reset = false; }
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
                bugfix = true;
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
                    bugfix = false;
                    player.movePlayer(move);
                }
            } 
            
            if (player.y > 301)
            {
                player.y = 300;
            }

            pnlGame.Invalidate(); //makes the paint event fire to redraw the panel
        }

        private void tmrRock_Tick(object sender, EventArgs e)
        {
            rock.moveRock();
            rock2.moveRock2();
            coin.moveCoin();

            if (score > highscore)
            {
                lblHighscore.Text = txtName.Text + ": " + score.ToString();
                highscore = score;
            }

            if (rock.rockRec.IntersectsWith(rock2.rock2Rec))
            {
                rock2.x = 550;
            }

            if (player.playerRec.IntersectsWith(rock.rockRec))
            {
                tmrRock.Enabled = false;
                tmrPlayer.Enabled = false;
                tmrAnim.Enabled = false;
                tmrReset.Enabled = true;
                mnuStart.Enabled = false;
            }

            if (player.playerRec.IntersectsWith(rock2.rock2Rec))
            {
                tmrRock.Enabled = false;
                tmrPlayer.Enabled = false;
                tmrAnim.Enabled = false;
                tmrReset.Enabled = true;
                mnuStart.Enabled = false;
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

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text == true)
            {
                tmrRock.Enabled = true;
                tmrPlayer.Enabled = true;
                txtName.ReadOnly = true;
            }
            else
            {
                lblError.Text = "Please enter text";
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            text = true;
            lblError.Text = "";
        }

        private void frmRide_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Big Lenny's Wild Ride. \nUse the arrow keys to move. \nAvoid the rocks and get the coins. \nEnter your name so youre highscore can be recorded. \nYou only have one life, so use it wisely. \nEnjoy!","Instructions");
        }

        private void mnuStop_Click(object sender, EventArgs e)
        {
            tmrRock.Enabled = false;
            tmrPlayer.Enabled = false;
            tmrAnim.Enabled = false;
        }

        private void tmrAnim_Tick(object sender, EventArgs e)
        {
            player.anim2();
            Invalidate();
        }

        private void tmrReset_Tick(object sender, EventArgs e)
        {
            if (tmrRock.Enabled == false && tmrPlayer.Enabled == false)
            {
                lblRestart.Visible = true;

                if (reset == true)
                {
                    restart();
                }
            }
        }

        private void speed()
        {
            if (score >= 5)
            {
                rock2.x -= 2;
                rock.x -= 2;
                tmrAnim.Interval = 50;
            }

            if (score >= 10)
            {
                rock2.x -= 2;
                rock.x -= 2;
                tmrAnim.Interval = 25;
            }

            if (score >= 15)
            {
                rock2.x -= 2;
                rock.x -= 2;
                tmrAnim.Interval = 12;
            }

            if (score >= 20)
            {
                rock2.x -= 2;
                rock.x -= 2;
                tmrAnim.Interval = 6;
            }
        }

        private void restart()
        {
            rock.x = 550;
            rock2.x = 900;
            player.x = 10;

            if (bugfix == true)
            {
                player.y = 200;
            }
            else
            {
                player.y = 300;
            }

            coin.x = 550;
            coin.y = 315;
            score = 0;
            tmrRock.Enabled = true;
            tmrPlayer.Enabled = true;
            tmrAnim.Enabled = true;
            tmrReset.Enabled = false;
            rock.moveRock();
            rock2.moveRock2();
            coin.moveCoin();
            player.movePlayer(move);
            lblRestart.Visible = false;
        }
    }
}
