using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: Make it so it can do many robots
namespace Rover_Ruckus_Scorer
{
    public partial class ScorerForm : Form
    {
        public ScorerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the score of a practice match with one robot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcButton_Click(object sender, EventArgs e)
        {
            int autoScore       = 0, 
                teleScore       = 0, 
                endGameScore    = 0,
                totalScore      = 0;
            
            // Autonomous calculations
            if (landedCheckBox.Checked)
            {
                autoScore += 30;
            }

            if (claimedCheckBox.Checked)
            {
                autoScore += 15;
            }

            if (autoParkedCheckBox.Checked)
            {
                autoScore += 10;
            }

            if (goldKnockedCheckBox.Checked && !silverKnockedCheckBox.Checked)
            {
                autoScore += 25;
            }



            // TeleOp calc
            try
            {
                teleScore = Int32.Parse(depotScoredTextBox.Text) + Int32.Parse(cargoScoredTextBox.Text);
            }
            catch (FormatException fe) {
                MessageBox.Show("Oh no. . . Oh no no no no no no no no no no\n" +
                    "no no no no no no no no no. You've misunderstood\n" +
                    "Oh no no no no no no no no no no no no no no.\n\n\n\n\nI think you get what I mean.");

                return;
            }
            

            // End Game calc
            if (latchedCheckBox.Checked)
            {
                endGameScore += 50;
            }

            if (partialParkCheckBox.Checked)
            {
                endGameScore += 15;
            }

            if (totalParkCheckBox.Checked)
            {
                endGameScore += 25;
            }

            // Final
            totalScore = autoScore + teleScore + endGameScore;

            autoScoreTextBox.Text = autoScore.ToString();
            teleopScoreTextBox.Text = teleScore.ToString();
            endGameScoreTextBox.Text = endGameScore.ToString();
            totalScoreTextBox.Text = totalScore.ToString();
        }
    }
}
