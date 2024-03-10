using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissor_Application
{
    public partial class Form2 : Form
    {
        string Player, Computer; //Objects Playing
        string[] Choices = { "Rock", "Paper", "Scissor" }; //The options or weapons
        Random Random = new Random(); //For computer to pick
        int ComputerRandom; //When Computer picks

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Rock_Click(object sender, EventArgs e)
        {
            Player = "Rock"; 
            ComputerRandom = Random.Next(0, 3);//Pick one of the choices
            Computer = Choices[ComputerRandom];
            if (PlayerBox.Visible)
            {
                PlayerRock.Visible = true;
                PlayerPaper.Visible = false;
                PlayerScissor.Visible = false;
            }
            ComputerImages();
            Game();
        }
        private void Paper_Click(object sender, EventArgs e)
        {
            Player = "Paper";
            ComputerRandom = Random.Next(0, 3);
            Computer = Choices[ComputerRandom];
            if (PlayerBox.Visible)
            {
                PlayerRock.Visible = false;
                PlayerPaper.Visible = true;
                PlayerScissor.Visible = false;
            }
            ComputerImages();
            Game();
        }
        private void Scissor_Click(object sender, EventArgs e)
        {
            Player = "Scissor";
            ComputerRandom = Random.Next(0, 3);
            Computer = Choices[ComputerRandom];
            if (PlayerBox.Visible)
            {
                PlayerRock.Visible = false;
                PlayerPaper.Visible = false;
                PlayerScissor.Visible = true;
            }
            ComputerImages();
            Game();
        }
        void Game()
        {
            //Rock
            if (Player == "Rock" && Computer == "Rock")
                MessageBox.Show("Tie!");
            else if (Player == "Rock" && Computer == "Paper")
                MessageBox.Show("Player Lose!");
            else if (Player == "Rock" && Computer == "Scissor")
                MessageBox.Show("Player Won!");
            //Paper
            if (Player == "Paper" && Computer == "Paper")
                MessageBox.Show("Tie!");
            else if (Player == "Paper" && Computer == "Scissor")
                MessageBox.Show("Player Lose!");
            else if (Player == "Paper" && Computer == "Rock")
                MessageBox.Show("Player Won!");
            //Scissor
            if (Player == "Scissor" && Computer == "Scissor")
                MessageBox.Show("Tie!");
            else if (Player == "Scissor" && Computer == "Rock")
                MessageBox.Show("Player Lose!");
            else if (Player == "Scissor" && Computer == "Paper")
                MessageBox.Show("Player Won!");
        }
        private void ComputerImages()
        {
            if (Computer == "Rock")
            {
                ComputerRock.Visible = true;
                ComputerPaper.Visible = false;
                ComputerScissor.Visible = false;

            }
            else if (Computer == "Paper")
            {
                ComputerRock.Visible = false;
                ComputerPaper.Visible = true;
                ComputerScissor.Visible = false;
            }
            else if (Computer == "Scissor")
            {
                ComputerRock.Visible = false;
                ComputerPaper.Visible = false;
                ComputerScissor.Visible = true;
            }
        }
    }
}
