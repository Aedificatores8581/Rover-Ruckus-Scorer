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
            if (oneLandedButton.Checked)
            {
                autoScore += 30;
            } else if (twoLandedButton.Checked)
            {
                autoScore += 60;
            }

            if (oneMarkerPlacedButton.Checked)
            {
                autoScore += 15;
            } else if (twoMarkersPlacedButton.Checked)
            {
                autoScore += 30;
            }

            if (oneAutoParkedButton.Checked)
            {
                autoScore += 10;
            } else if (twoAutoParkedButton.Checked)
            {
                autoScore += 20;
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
            if (oneLatchedButton.Checked)
            {
                endGameScore += 50;
            } else if (twoLatchedButton.Checked)
            {
                endGameScore += 100;
            }

            if (onePartiallyParkedButton.Checked)
            {
                endGameScore += 15;
            } else if (twoPartiallyParkedButton.Checked)
            {
                endGameScore += 30;
            }

            if (oneTotallyParkedButton.Checked)
            {
                endGameScore += 25;
            } else if(twoTotallyParkedButton.Checked)
            {
                endGameScore += 50;
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
