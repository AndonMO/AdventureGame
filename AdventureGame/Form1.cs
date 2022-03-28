using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        bool key = false;
        bool stick = false;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
            DisplayPage();

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 101;
            }
            else if (page == 4)
            {
                int randValue = randGen.Next(1, 3);
                if (randValue == 1)
                {
                    page = 6;
                }
                else if (randValue == 2)
                {
                    page = 5;
                    key = true;
                }
            }
            else if (page == 5)
            {
                page = 8;
                stick = true;
            }
            else if (page == 6)
            {
                page = 101;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                int randValue = randGen.Next(1, 11);
                if (randValue == 1)
                {
                    page = 10;
                }
                else
                {
                    page = 11;
                }
            }
            else if (page == 10)
            {
                page = 301;
            }
            else if (page == 11)
            {
                page = 101;
            }
            else if (page == 12)
            {
                if (key == true)
                {
                    page = 13;
                }
                else
                {
                    page = 22;
                }
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 201;
            }
            else if (page == 16)
            {
                page = 101;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                if (stick == true)
                {
                    page = 17;
                }
                else
                {
                    page = 14;
                }    
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 301;
            }
            else if (page == 22)
            {
                page = 101;
            }
            else if (page == 101)
            {
                page = 1;
                stick = false;
                key = false;
            }
            else if (page == 201)
            {
                page = 1;
                stick = false;
                key = false;
            }
            else if (page == 301)
            {
                page = 101;
                stick = false;
                key = false;
            }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 8;
            }
            else if (page == 3)
            {
                page = 101;
            }
            else if (page == 4)
            {
                page = 2;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 101;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 13)
            {
                page = 13;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 101)
            {
                this.Close();
            }
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (stick == true)
            {
                page = 17;
            }
            else if (stick == false)
            {
                page = 18;
            }

            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wake up in a strange room you have never seen before. It looks drab and run down, the walls are made of brick and there is a single door. Do you go through the door?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.StartRoom;
                    break;

                case 2:
                    outputLabel.Text = "You go through the door, you are met with a long hallway that branches in two. One side is blocked by a chain fence. What do you do?";
                    option1Label.Text = "Go to the fence";
                    option2Label.Text = "Walk down the hallway";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.DarkHall;
                    break;

                case 3:
                    outputLabel.Text = "You stay in the stange room for days, no food no water, you die from dehydration. Maybe you should have tried to leave .. ?";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Button.Visible = false;
                    break;

                case 4:
                    outputLabel.Text = "You look through the fence spotting a key close on the other side. There is a stick nearby. Do you try and grab the key?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.FenceRoom;
                    break;

                case 5:
                    outputLabel.Text = "You grab the key successfully. Do you want to keep the stick?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.FenceRoom;
                    break;

                case 6:
                    outputLabel.Text = "You fail to grab the key and it slips out of reach, you become depressed you failed such a feat, curl into a ball and dont move again.";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.FenceRoom;
                    break;

                case 7:
                    outputLabel.Text = "You leave the stick and turn towards the other hallway";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.DarkHall;
                    break;

                case 8:
                    outputLabel.Text = "You walk down the hallway that never seems to end, you come across a window and you can see the night sky. Do you look out the window?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Window;
                    break;

                case 9:
                    outputLabel.Text = "You look out the window and a strong gust of wind comes out of nowhere pushing you out the window";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Window;
                    break;

                case 10:
                    outputLabel.Text = "You somehow survive the fall by landing in a tree. You win! you got the chance ending";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.WinScreen;
                    break;

                case 11:
                    outputLabel.Text = "You fall hundreds of feet and die on impact";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Forest;
                    break;

                case 12:
                    outputLabel.Text = "You decide you shouldn't look out the window. As you walk past you feel a gust of wind, it could have pushed you out the window... you continue walking down the hallway eventually coming across the door. Try to open it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.DarkHall;
                    break;

                case 13:
                    outputLabel.Text = "You try to open the door.... it wont budge. Try to use the key on it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Door;
                    break;

                case 14:
                    outputLabel.Text = "You put the key in and twist... with a click the door unlocks and you are greeted with green grass. There is only a barbed wire fence between you and freedom. The door suddenly locks behind you and you cant go back. What do you do?";
                    option1Label.Text = "Nothing";
                    option2Label.Text = "Jump the fence";
                    option3Label.Text = "Break the lock on the fence gate";
                    option3Button.Visible = true;
                    pictureBox.Image = Properties.Resources.Door;
                    break;

                case 15:
                    outputLabel.Text = "You decide the best course of action is to do nothing. all of a sudden several large men run out and knock you out";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.BarbedWire;
                    break;

                case 16:
                    outputLabel.Text = "You try jumping the barbed wire fence. Not smart. You cut yourself badly and slowly die";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.BarbedWire;
                    break;

                case 17:
                    outputLabel.Text = "You break the lock using all of your strength. Freedom at last... theres a car and a bike sitting there, which do you take?";
                    option1Label.Text = "Car";
                    option2Label.Text = "Bike";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Forest;
                    break;

                case 18:
                    outputLabel.Text = "You have nothing to break a lock with...";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.BarbedWire;
                    break;

                case 19:
                    outputLabel.Text = "You get in the car and find the keys!.... you dont know how to drive stick shift and decide to grab the bike";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Forest;
                    break;

                case 20:
                    outputLabel.Text = "You take the bike. Riding off into the sunset as you leave the behemoth brick building you were placed inside of";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Forest;
                    break;

                case 21:
                    outputLabel.Text = "You win!";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.WinScreen;
                    break;

                case 22:
                    outputLabel.Text = "You try to open the door.... it wont budge and you dont have a key. You are too tired and hungry to walk back and look for it. You die of thirst";
                    option1Label.Text = "Continue";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.Door;
                    break;

                case 101:
                    outputLabel.Text = "Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = null;
                    break;

                case 201:
                    outputLabel.Text = "You wake up back in the first room all of your items are gone. Do you go through the door?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.StartRoom;
                    break;

                case 301:
                    outputLabel.Text = "You got the escape ending! Congratulations, play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Button.Visible = false;
                    pictureBox.Image = Properties.Resources.WinScreen;
                    break;



            }
        }
    }
}
