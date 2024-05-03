using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        String[] ComputerOptions = { "Rock", "Paper", "Scissors" };
        Random random;
        int playerScore = 0;
        int computerScore = 0;
        
        private void bntRock_Click(object sender, EventArgs e)
        {
            lblPlayerScore.Text = playerScore.ToString();
            lblComputerScore.Text=computerScore.ToString();
            random = new Random();
            int randomIndex = random.Next(ComputerOptions.Length);
            txtComputerChoice.Text= ComputerOptions[randomIndex].ToString();
            switch(ComputerOptions[randomIndex]) 
            {
                case "Rock" : MessageBox.Show("Draw");
                                        break;
                case "Paper": MessageBox.Show("Computer wins!");
                    computerScore++;
                    lblComputerScore.Text = computerScore.ToString();
                    break;
                case "Scissors": MessageBox.Show("Player wins!");
                    playerScore++;
                    lblPlayerScore.Text=playerScore.ToString();
                    break;
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            lblPlayerScore.Text = playerScore.ToString();
            lblComputerScore.Text = computerScore.ToString();
            random = new Random();
            int randomIndex = random.Next(ComputerOptions.Length);
            txtComputerChoice.Text = ComputerOptions[randomIndex].ToString();
            switch (ComputerOptions[randomIndex])
            {
                case "Paper":
                    MessageBox.Show("Draw");
                    break;
                case "Scissors":
                    MessageBox.Show("Computer wins!");
                    computerScore++;
                    lblComputerScore.Text = computerScore.ToString();
                    break;
                case "Rock":
                    MessageBox.Show("Player wins!");
                    playerScore++;
                    lblPlayerScore.Text = playerScore.ToString();
                    break;
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            lblPlayerScore.Text = playerScore.ToString();
            lblComputerScore.Text = computerScore.ToString();
            random = new Random();
            int randomIndex = random.Next(ComputerOptions.Length);
            txtComputerChoice.Text = ComputerOptions[randomIndex].ToString();
            switch (ComputerOptions[randomIndex])
            {
                case "Scissors":
                    MessageBox.Show("Draw");
                    break;
                case "Rock":
                    MessageBox.Show("Computer wins!");
                    computerScore++;
                    lblComputerScore.Text = computerScore.ToString();
                    break;
                case "Paper":
                    MessageBox.Show("Player wins!");
                    playerScore++;
                    lblPlayerScore.Text = playerScore.ToString();
                    break;
            }
        }
    }
}
