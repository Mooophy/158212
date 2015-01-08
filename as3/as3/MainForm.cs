﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace as3
{
    using Images = global::as3.Properties.Resources;

    public partial class MainForm : Form
    {
        private int elapsed, scoreLeft, scoreRight;
        private string leftNation = "Cameroon", rightNation = "Germany";
        delegate bool lambda(int i);

        public MainForm()
        {
            InitializeComponent();
        }

        private void tick_EventHandler(object sender, EventArgs e)
        {
            ++elapsed;
            labelElapsed.Text = getTimeStr();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (leftNation == rightNation)
            {
                MessageBox.Show("The two sides cann't be the same nation.","Note!");
                return;
            }
            timer.Start();
            groupBoxLeft.Enabled = groupBoxRight.Enabled = buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            enableAllScoreButtons();
        }

        private void enableAllScoreButtons()
        {
            buttonLeftConversion.Enabled    =   buttonLeftDrop.Enabled  =   buttonLeftPenalty.Enabled   =   buttonLeftTry.Enabled   =   true;
            buttonRightConversion.Enabled   =   buttonRightDrop.Enabled =   buttonRightPenalty.Enabled  =   buttonRightTry.Enabled  =   true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            int l = scoreLeft, r = scoreRight;
            string gameResult = labelLeftScore.Text + " : " + labelRightScore.Text + "  ";
            gameResult += l==r ? "A Tie" :  l>r ? (leftNation + " Won!") : (rightNation + " Won!");
            MessageBox.Show(gameResult, "Result");
            this.Close();
        }

        private String getTimeStr()
        {
            lambda isTooShort = number => number < 10;
            var min = (isTooShort(elapsed / 60) ? "0" : "") + (elapsed / 60).ToString();
            var sec = (isTooShort(elapsed % 60) ? "0" : "") + (elapsed % 60).ToString();
            return min + ":" + sec;
        }

        delegate int map(int scoreType);
        delegate string str(string nation, int scoreType);
        private void score(int scoreType, bool isLeft)
        {
            map getPoints = t => {
                if (t == 0)             return 5;   //try
                if (t == 1)             return 2;   //conversion
                if (t == 2 || t == 3)   return 3;   //drop and penalty
                return 0;
            };

            str make = (string n, int t) => {
                string scoreName = t == 0 ? "try" : t == 1 ? "conversion" : t == 2 ? "drop" : "penalty";
                return n + " scores a " + scoreName + " at " + labelElapsed.Text + ".\n";
            };

            if (isLeft)
            {
                labelLeftScore.Text = (scoreLeft += getPoints(scoreType)).ToString();
                log.AppendText(make(leftNation, scoreType));
            }
            else
            {
                labelRightScore.Text= (scoreRight+= getPoints(scoreType)).ToString();
                log.AppendText(make(rightNation, scoreType));
            }
        }

        private void radioButtonLeftChile_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxLeft.Image = Images.Chile;
            leftNation = "Chile";
        }

        private void radioButtonLeftGermany_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxLeft.Image = Images.Germany;
            leftNation = "Germany";
        }

        private void radioButtonLeftCameroon_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxLeft.Image = Images.Cameroon;
            leftNation = "Cameroon";
        }

        private void radioButtonRightChile_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxRight.Image = Images.Chile;
            rightNation = "Chile";
        }

        private void radioButtonRightGermany_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxRight.Image = Images.Germany;
            rightNation = "Germany";
        }

        private void radioButtonRightCameroon_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxRight.Image = Images.Cameroon;
            rightNation = "Cameroon";
        }

        private void buttonLeftTry_Click(object sender, EventArgs e)
        {
            score(0, true);
        }

        private void buttonLeftConversion_Click(object sender, EventArgs e)
        {
            score(1, true);
        }

        private void buttonLeftPenalty_Click(object sender, EventArgs e)
        {
            score(2, true);
        }

        private void buttonLeftDrop_Click(object sender, EventArgs e)
        {
            score(3, true);
        }

        private void buttonRightTry_Click(object sender, EventArgs e)
        {
            score(0, false);
        }

        private void buttonRightConversion_Click(object sender, EventArgs e)
        {
            score(1, false);
        }

        private void buttonRightPenalty_Click(object sender, EventArgs e)
        {
            score(2, false);
        }

        private void buttonRightDrop_Click(object sender, EventArgs e)
        {
            score(3, false);
        }
    }
}