using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace choseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        //page tracker
        int page = 1;
        Random random = new Random();
        double chance = 0;
        public Form1()
        {
            InitializeComponent();
            // initial message 
            descriptionLabel.Text = "pick your class";
            choice1Button.Text = "Mage";
            choice2Button.Text = "Fighter";
            choice3Button.Text = "Wretch";
        }

        private void choice1Button_Click(object sender, EventArgs e)
        {
            //checks what page your on 
            //goes to the coreect page for option one 
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                chance = random.Next(1, 101);
                if (chance > 10)
                {
                    page = 22;
                }
                else
                {
                    page = 23;
                }
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }
            //--------------------------------------------
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 27;
            }
            else if (page == 27)
            {
                page = 31;
            }
            else if (page == 28)
            {
                page = 30;
            }
            else if (page == 29)
            {
                page = 31;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 31)
            {
                chance = random.Next(1, 101);
                if (chance > 1)
                {
                    page = 33;
                }
                else
                {
                    page = 34;
                }
            }
            else if (page == 32)
            {
                page = 1;
            }
            else if (page == 33)
            {
                page = 1;
            }
            else if (page == 34)
            {
                page = 1;
            }

            //displays text based in page
            switch (page)
            {
                case 1:
                    descriptionLabel.Text = "chose your class";
                    choice1Button.Text = "Mage";
                    choice2Button.Text = "Fighter";
                    choice3Button.Text = "wretch";
                    break;
                case 2:

                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies you are holding a staff with knowledge of one spell clothed in cloth";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "Hit with staff";
                    choice2Button.Text = "shoot spell";

                    break;
                case 3:

                    descriptionLabel.Text = "your flimsy mage arms can't swing hard enough and so your staff bounces harmlessly off the zombie and it turns then process to eat you.  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";
                    break;
                case 4:
                    descriptionLabel.Text = "the bolt of magic you send out tears a hole straight through the zombie ";

                    Thread.Sleep(2000);

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "Right";
                    choice2Button.Text = "Left";

                    break;
                case 5:
                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a bag full of coins sitting at the end";
                    choice1Button.Text = "Turn around";
                    choice2Button.Text = "Pick up the coin";

                    break;
                case 6:
                    descriptionLabel.Text = "it appears your cowardice has attracted more zombies you get mauled and die. Play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 8:
                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "go right";
                    choice2Button.Text = "run at the zombie";
                    break;
                case 9:

                    descriptionLabel.Text = " the path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 10:

                    descriptionLabel.Text = "you're able to summon the strength to doge the bolt that wizzes by your face and you proceed to kill the zombie. behind the zombie is a magical campfire that gives you a sense of safety.  play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 11:

                    descriptionLabel.Text = "as you try to run towards the crossbow your flimsy mage legs fail on you and you fall. the zombie process to shoot you with the crossbow. play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 12:
                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies up holding a battle axe and a Woden shield clothed in fur";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "throw axe";
                    choice2Button.Text = "attack its legs";
                    break;
                case 13:
                    descriptionLabel.Text = "the zombie falls as your axe impales its stomach. you approach it to retrieve your axe and the zombie process to grab you and kill you.  play again?";

                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 14:

                    descriptionLabel.Text = "as you  cleave its legs from underneath the zombie it collapses and you walk past it.";

                    Refresh();
                    Thread.Sleep(2000);

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "Right";
                    choice2Button.Text = "Left";


                    break;
                case 15:

                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a bag full of coins sitting at the end";
                    choice1Button.Text = "Turn around";
                    choice2Button.Text = "Pick up the coin";

                    break;
                case 16:

                    descriptionLabel.Text = "it appears your cowardice has attracted more zombies.";
                    choice1Button.Text = "reclaim your honour";
                    choice2Button.Text = "accept your fate";

                    break;
                case 17:

                    descriptionLabel.Text = "you relies your lost honour and accept your life as forfeit. play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 18:

                    descriptionLabel.Text = "your hurt honour is too much to over come and you get defeated in battle. play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 19:


                    descriptionLabel.Text = "you pick up the coin which opens a sealed door. the door leads to a magical campfire that gives you a sense of safety  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 20:

                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "go right";
                    choice2Button.Text = "run at the zombie";

                    break;
                case 21:

                    descriptionLabel.Text = " The path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 22:

                    descriptionLabel.Text = "You charge forward with your shield raised and you let out a guttural cry as a arrows impact your shield. then you proceed to kill the zombie. behind the zombie is a magical campfire that gives you a sense of safety  play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 23:

                    descriptionLabel.Text = "As you run towards the crossbow an arrow hits straight through the shield and you die.  play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    //_______________________________________________________________________

                    break;
                case 24:
                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies you only have a club and are scarsely clothed.";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "Hit with club";
                    choice2Button.Text = "walk past it";
                    break;
                case 25:
                    descriptionLabel.Text = "the zombie visibly quakes in fear as you walk past it falls to its knees ";

                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 26:

                    descriptionLabel.Text = "your club crashes devastatingly down on its head as it seems to crumple under you might.";
                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 27:

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "go left";
                    choice2Button.Text = "go right";

                    break;
                case 28:

                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a full set of armour  sitting at the end";
                    choice1Button.Text = "put on armour";
                    choice2Button.Text = "turn around";

                    break;
                case 29:

                    descriptionLabel.Text = "you turn around and walk till you";
                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 30:

                    descriptionLabel.Text = "your cowardliness not to face a challenge has attracted more zombies you get mauled and die.  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 31:


                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "run at the zombie";
                    choice2Button.Text = "go right";

                    break;
                case 32:

                    descriptionLabel.Text = " The path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 33:

                    descriptionLabel.Text = "you charge forward with your club raised and you let out a guttural cry as you hit arrows out of your way. then you proceed to kill the zombie with a brutal attack. behind the zombie is a magical campfire that gives you a sense of safety . play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 34:

                    descriptionLabel.Text = "as you run towards the crossbow an arrow hits home as you fall and you die.   play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 99:
                    descriptionLabel.Text = "thank you for playing";
                    choice1Button.Text = "";
                    choice2Button.Text = "";
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }

        }

        private void choice2Button_Click(object sender, EventArgs e)
        {
            //checks what page your on 
            //goes to the coreect page for option one 

            if (page == 1)
            {
                page = 12;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                chance = random.Next(1, 101);
                if (chance > 90)
                {
                    page = 10;
                }
                else
                {
                    page = 11;
                }
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 20;
            }
            else if (page == 15)
            {
                page = 19;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                chance = random.Next(1, 101);
                if (chance > 10)
                {
                    page = 22;
                }
                else
                {
                    page = 23;
                }
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }

            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 27;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 31;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 31)
            {
                page = 32;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }

            //displays text based in page

            switch (page)
            {
                case 1:
                    descriptionLabel.Text = "chose your class";
                    choice1Button.Text = "Mage";
                    choice2Button.Text = "Fighter";
                    choice3Button.Text = "wretch";
                    break;
                case 2:

                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies you are holding a staff with knowledge of one spell clothed in cloth";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "Hit with staff";
                    choice2Button.Text = "shoot spell";

                    break;
                case 3:

                    descriptionLabel.Text = "your flimsy mage arms can't swing hard enough and so your staff bounces harmlessly off the zombie and it turns then process to eat you.  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";
                    break;
                case 4:
                    descriptionLabel.Text = "the bolt of magic you send out tears a hole straight through the zombie ";

                    Thread.Sleep(2000);

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "Right";
                    choice2Button.Text = "Left";

                    break;
                case 5:
                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a bag full of coins sitting at the end";
                    choice1Button.Text = "Turn around";
                    choice2Button.Text = "Pick up the coin";

                    break;
                case 6:
                    descriptionLabel.Text = "it appears your cowardice has attracted more zombies you get mauled and die. Play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 8:
                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "go right";
                    choice2Button.Text = "run at the zombie";
                    break;
                case 9:

                    descriptionLabel.Text = " the path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 10:

                    descriptionLabel.Text = "you're able to summon the strength to doge the bolt that wizzes by your face and you proceed to kill the zombie. behind the zombie is a magical campfire that gives you a sense of safety.  play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 11:

                    descriptionLabel.Text = "as you try to run towards the crossbow your flimsy mage legs fail on you and you fall. the zombie process to shoot you with the crossbow. play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 12:
                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies up holding a battle axe and a Woden shield clothed in fur";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "throw axe";
                    choice2Button.Text = "attack its legs";
                    break;
                case 13:
                    descriptionLabel.Text = "the zombie falls as your axe impales its stomach. you approach it to retrieve your axe and the zombie process to grab you and kill you.  play again?";

                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 14:

                    descriptionLabel.Text = "as you  cleave its legs from underneath the zombie it collapses and you walk past it.";

                    Refresh();
                    Thread.Sleep(2000);

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "Right";
                    choice2Button.Text = "Left";


                    break;
                case 15:

                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a bag full of coins sitting at the end";
                    choice1Button.Text = "Turn around";
                    choice2Button.Text = "Pick up the coin";

                    break;
                case 16:

                    descriptionLabel.Text = "it appears your cowardice has attracted more zombies.";
                    choice1Button.Text = "reclaim your honour";
                    choice2Button.Text = "accept your fate";

                    break;
                case 17:

                    descriptionLabel.Text = "you relies your lost honour and accept your life as forfeit. play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 18:

                    descriptionLabel.Text = "your hurt honour is too much to over come and you get defeated in battle. play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 19:


                    descriptionLabel.Text = "you pick up the coin which opens a sealed door. the door leads to a magical campfire that gives you a sense of safety  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 20:

                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "go right";
                    choice2Button.Text = "run at the zombie";

                    break;
                case 21:

                    descriptionLabel.Text = " The path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 22:

                    descriptionLabel.Text = "You charge forward with your shield raised and you let out a guttural cry as a arrows impact your shield. then you proceed to kill the zombie. behind the zombie is a magical campfire that gives you a sense of safety  play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 23:

                    descriptionLabel.Text = "As you run towards the crossbow an arrow hits straight through the shield and you die.  play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    //_______________________________________________________________________

                    break;
                case 24:
                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies you only have a club and are scarsely clothed.";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "Hit with club";
                    choice2Button.Text = "walk past it";
                    break;
                case 25:
                    descriptionLabel.Text = "the zombie visibly quakes in fear as you walk past it falls to its knees ";

                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 26:

                    descriptionLabel.Text = "your club crashes devastatingly down on its head as it seems to crumple under you might.";
                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 27:

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "go left";
                    choice2Button.Text = "go right";

                    break;
                case 28:

                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a full set of armour  sitting at the end";
                    choice1Button.Text = "put on armour";
                    choice2Button.Text = "turn around";

                    break;
                case 29:

                    descriptionLabel.Text = "you turn around and walk till you";
                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 30:

                    descriptionLabel.Text = "your cowardliness not to face a challenge has attracted more zombies you get mauled and die.  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 31:


                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "run at the zombie";
                    choice2Button.Text = "go right";

                    break;
                case 32:

                    descriptionLabel.Text = " The path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 33:

                    descriptionLabel.Text = "you charge forward with your club raised and you let out a guttural cry as you hit arrows out of your way. then you proceed to kill the zombie with a brutal attack. behind the zombie is a magical campfire that gives you a sense of safety . play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 34:

                    descriptionLabel.Text = "as you run towards the crossbow an arrow hits home as you fall and you die.   play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 99:
                    descriptionLabel.Text = "thank you for playing";
                    choice1Button.Text = "";
                    choice2Button.Text = "";
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void choice3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 27;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                page = 29;
            }
            else if (page == 29)
            {
                page = 31;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 31)
            {
                page = 32;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }

            //displays text based in page

            switch (page)
            {
                case 1:
                    descriptionLabel.Text = "chose your class";
                    choice1Button.Text = "Mage";
                    choice2Button.Text = "Fighter";
                    choice3Button.Text = "wretch";
                    break;
                case 2:

                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies you are holding a staff with knowledge of one spell clothed in cloth";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "Hit with staff";
                    choice2Button.Text = "shoot spell";

                    break;
                case 3:

                    descriptionLabel.Text = "your flimsy mage arms can't swing hard enough and so your staff bounces harmlessly off the zombie and it turns then process to eat you.  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";
                    break;
                case 4:
                    descriptionLabel.Text = "the bolt of magic you send out tears a hole straight through the zombie ";

                    Thread.Sleep(2000);

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "Right";
                    choice2Button.Text = "Left";

                    break;
                case 5:
                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a bag full of coins sitting at the end";
                    choice1Button.Text = "Turn around";
                    choice2Button.Text = "Pick up the coin";

                    break;
                case 6:
                    descriptionLabel.Text = "it appears your cowardice has attracted more zombies you get mauled and die. Play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 8:
                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "go right";
                    choice2Button.Text = "run at the zombie";
                    break;
                case 9:

                    descriptionLabel.Text = " the path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 10:

                    descriptionLabel.Text = "you're able to summon the strength to doge the bolt that wizzes by your face and you proceed to kill the zombie. behind the zombie is a magical campfire that gives you a sense of safety.  play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 11:

                    descriptionLabel.Text = "as you try to run towards the crossbow your flimsy mage legs fail on you and you fall. the zombie process to shoot you with the crossbow. play agian?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 12:
                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies up holding a battle axe and a Woden shield clothed in fur";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "throw axe";
                    choice2Button.Text = "attack its legs";
                    break;
                case 13:
                    descriptionLabel.Text = "the zombie falls as your axe impales its stomach. you approach it to retrieve your axe and the zombie process to grab you and kill you.  play again?";

                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 14:

                    descriptionLabel.Text = "as you  cleave its legs from underneath the zombie it collapses and you walk past it.";

                    Refresh();
                    Thread.Sleep(2000);

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "Right";
                    choice2Button.Text = "Left";


                    break;
                case 15:

                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a bag full of coins sitting at the end";
                    choice1Button.Text = "Turn around";
                    choice2Button.Text = "Pick up the coin";

                    break;
                case 16:

                    descriptionLabel.Text = "it appears your cowardice has attracted more zombies.";
                    choice1Button.Text = "reclaim your honour";
                    choice2Button.Text = "accept your fate";

                    break;
                case 17:

                    descriptionLabel.Text = "you relies your lost honour and accept your life as forfeit. play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 18:

                    descriptionLabel.Text = "your hurt honour is too much to over come and you get defeated in battle. play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 19:


                    descriptionLabel.Text = "you pick up the coin which opens a sealed door. the door leads to a magical campfire that gives you a sense of safety  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 20:

                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "go right";
                    choice2Button.Text = "run at the zombie";

                    break;
                case 21:

                    descriptionLabel.Text = " The path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 22:

                    descriptionLabel.Text = "You charge forward with your shield raised and you let out a guttural cry as a arrows impact your shield. then you proceed to kill the zombie. behind the zombie is a magical campfire that gives you a sense of safety  play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 23:

                    descriptionLabel.Text = "As you run towards the crossbow an arrow hits straight through the shield and you die.  play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    //_______________________________________________________________________

                    break;
                case 24:
                    descriptionLabel.Text = "you wake up in an unknown cemetery";

                    choice1Button.Enabled = false;
                    choice2Button.Enabled = false;
                    choice3Button.Enabled = false;

                    Thread.Sleep(2000);
                    Refresh();


                    descriptionLabel.Text = "you relies you only have a club and are scarsely clothed.";


                    Thread.Sleep(2000);
                    Refresh();

                    descriptionLabel.Text = "you see a zombie stumbling towards you";

                    Thread.Sleep(2000);



                    choice1Button.Enabled = true;
                    choice2Button.Enabled = true;
                    choice3Button.Enabled = true;

                    choice1Button.Text = "Hit with club";
                    choice2Button.Text = "walk past it";
                    break;
                case 25:
                    descriptionLabel.Text = "the zombie visibly quakes in fear as you walk past it falls to its knees ";

                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 26:

                    descriptionLabel.Text = "your club crashes devastatingly down on its head as it seems to crumple under you might.";
                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 27:

                    descriptionLabel.Text = "as you walk past the zombie there appears to be two directions to go.";
                    choice1Button.Text = "go left";
                    choice2Button.Text = "go right";

                    break;
                case 28:

                    descriptionLabel.Text = "the path winds around a corner and leads to a dead end with a full set of armour  sitting at the end";
                    choice1Button.Text = "put on armour";
                    choice2Button.Text = "turn around";

                    break;
                case 29:

                    descriptionLabel.Text = "you turn around and walk till you";
                    choice1Button.Text = "press to continue";
                    choice2Button.Text = "";

                    break;
                case 30:

                    descriptionLabel.Text = "your cowardliness not to face a challenge has attracted more zombies you get mauled and die.  play again?";
                    choice1Button.Text = "yes";
                    choice2Button.Text = "no";

                    break;
                case 31:


                    descriptionLabel.Text = "you see a  zombie with a crossbow aimed right at you you also see a path to your right that leads through a set of rocks.";
                    choice1Button.Text = "run at the zombie";
                    choice2Button.Text = "go right";

                    break;
                case 32:

                    descriptionLabel.Text = " The path through the rocks leads to a magical campfire that gives you a sense of safety. play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 33:

                    descriptionLabel.Text = "you charge forward with your club raised and you let out a guttural cry as you hit arrows out of your way. then you proceed to kill the zombie with a brutal attack. behind the zombie is a magical campfire that gives you a sense of safety . play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 34:

                    descriptionLabel.Text = "as you run towards the crossbow an arrow hits home as you fall and you die.   play agian?";
                    choice1Button.Text = "Yes";
                    choice2Button.Text = "No";

                    break;
                case 99:
                    descriptionLabel.Text = "thank you for playing";
                    choice1Button.Text = "";
                    choice2Button.Text = "";
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
