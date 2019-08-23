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

        //Variables
        bool left, right, jump, reset;
        bool text;
        bool bugfix;
        int Gravity = 1;
        int YSpeed = 20;
        int score = 0;
        int highscore = 0;
        bool NotOnGround = true;
        string move;

        Graphics g; //Declare a graphics object called g
        Player player = new Player(); //Create a player object
        Rock rock = new Rock(); //Create a rock object
        Rock2 rock2 = new Rock2(); //Create a rock2 object
        Coin coin = new Coin(); //Create a coin object
        Random rnd = new Random(); //Generate a random number


        public frmRide()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true }); //Stops panel from flickering
            player.anim1(); //Calls to anim1 in the player class
        }

        private void frmRide_KeyDown(object sender, KeyEventArgs e)
        {
            //Sets keys to make variables true
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { jump = true; }
            if (e.KeyData == Keys.R) { reset = true;  }
        }

        private void frmRide_KeyUp(object sender, KeyEventArgs e)
        {
            //Sets variables to false when keys are released
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.R) { reset = false; }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if (right) //If right arrow key pressed
            {
                move = "right"; //Set the move string to right
                player.movePlayer(move); //Call to movePlayer in the player class
            }
            if (left) //If left arrow key pressed
            {
                move = "left"; //Set the move string to left
                player.movePlayer(move);
            }
            if (jump == true) //If up arrow key pressed
            {
                move = "jump"; //Set move to jump
                bugfix = true; //Set bugfix to true
                if (NotOnGround == true) //If the player isn't on the ground
                {
                    YSpeed = YSpeed - Gravity; //Slows creates acceleration when going down, deceleration when going up
                    player.y = player.y - YSpeed; //Moves player according to YSpeed
                    player.movePlayer(move); //Code for movement
                }
                if (player.y < 300) //If the player is above the ground
                {
                    NotOnGround = true;
                    player.movePlayer(move);
                }

                if (player.y == 300) //If the player is on the ground
                {
                    YSpeed = 20; //Reset YSpeed
                    jump = false; 
                    bugfix = false;
                    player.movePlayer(move);
                }
            }

            pnlGame.Invalidate(); //Makes the paint event fire to redraw the panel
        }

        private void tmrRock_Tick(object sender, EventArgs e)
        {
            //Code to move the different objects
            rock.moveRock();
            rock2.moveRock2();
            coin.moveCoin();

            if (score > highscore)
            {
                lblHighscore.Text = txtName.Text + ": " + score.ToString(); //lblHighscore displays name then score, with a semicolon in between
                highscore = score; //Set highscore to score
            }

            if (rock.rockRec.IntersectsWith(rock2.rock2Rec)) //If the rocks are inside of eachother
            {
                rock2.x = 550; //Move rock2
            }

            if (player.playerRec.IntersectsWith(rock.rockRec)) //If player hits the rock
            {
                //Disable all timers, but enable tmrReset. Disable start button
                tmrRock.Enabled = false;
                tmrPlayer.Enabled = false;
                tmrAnim.Enabled = false;
                tmrReset.Enabled = true;
                mnuStart.Enabled = false;
            }

            if (player.playerRec.IntersectsWith(rock2.rock2Rec))
            {
                //Same as above
                tmrRock.Enabled = false;
                tmrPlayer.Enabled = false;
                tmrAnim.Enabled = false;
                tmrReset.Enabled = true;
                mnuStart.Enabled = false;
            }

            if (player.playerRec.IntersectsWith(coin.coinRec)) //If the player hits a coin
            {
                score ++; //Score goes up one
                lblScore.Text = score.ToString(); //lblScore displays the score
                coin.x = 500 + rnd.Next(100, 600); //Move the coin back to the beginning
            }

            speed(); //Call to speed

            pnlGame.Invalidate();//Makes the paint event fire to redraw the panel
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //Get the graphics used to paint on the panel control
            g = e.Graphics;
            player.drawPlayer(g);
            rock.drawRock(g);
            rock2.drawRock2(g);
            coin.drawCoin(g);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e) //If start is clicked
        {
            if (text == true) //If text is entered in the text box
            {
                tmrRock.Enabled = true; //Enable the timers
                tmrPlayer.Enabled = true;
                tmrAnim.Enabled = true;
                txtName.ReadOnly = true; //Disable entering text into the text box
            }
            else //If no text is in the box
            {
                lblError.Text = "Please enter text"; //Show an error message
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e) //When a key is pressed inside the text box
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) //If the key is a letter
            {
                e.Handled = true; //Accept the key
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e) //When text box text is changed
        {
            text = true;
            lblError.Text = ""; //Clears error message
        }

        private void frmRide_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Big Lenny's Wild Ride. \nUse the arrow keys to move. \nAvoid the rocks and get the coins. \nEnter your name so youre highscore can be recorded. \nYou only have one life, so use it wisely. \nEnjoy!","Instructions"); //Display this message on game start
        }

        private void mnuStop_Click(object sender, EventArgs e) //When stop is clicked
        {
            //Disable timers, enable start button
            tmrRock.Enabled = false; 
            tmrPlayer.Enabled = false;
            tmrAnim.Enabled = false;
            mnuStart.Enabled = true;
        }

        private void tmrAnim_Tick(object sender, EventArgs e)
        {
            player.anim2(); //Call to anim2          
        }

        private void tmrReset_Tick(object sender, EventArgs e)
        {
            if (tmrRock.Enabled == false && tmrPlayer.Enabled == false) //If both timers are disabled
            {
                lblRestart.Visible = true; //Show instructions for restarting

                if (reset == true) //If R is pressed
                {
                    restart(); //Call to restart
                }
            }
        }

        private void speed() //Increasing speed function
        {
            if (score >= 5) //If score is more than 5
            {
                rock2.x -= 2; //Speed up by 2
                rock.x -= 2; //Speed up by 2
                tmrAnim.Interval = 50; //Decrease tmrAnim interval so animation speeds up
            }

            //Do this every 5 score
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

        private void restart() //Reset function
        {
            //Reset positions
            rock.x = 550; 
            rock2.x = 900;
            player.x = 10;

            if (bugfix == true) //If the player is in the air
            {
                player.y = 200; //Reset a little above ground
            }
            else //If the player is on the ground
            {
                player.y = 300; //Reset on the ground
            }            

            //Reset positions. score, start timers
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
            lblRestart.Visible = false; //Hide restart instructions
        }
    }
}
