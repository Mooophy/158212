using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace Rugby
{
    using Images = global::Rugby.Properties.Resources;
    public partial class MainForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Lib.Controller c = new Controller();
        private string nationLeft = "Chile", nationRight="Germany";
        private int elapsed, scoreLeft, scoreRight;
        
        public MainForm()
        {
            InitializeComponent();
            operateOnAllScoreButtons(false);
        }

        void operateOnAllScoreButtons(bool b)
        {
            btnConversionLeft.Enabled   =   btnConversionRight.Enabled  =   b;
            btnDropLeft.Enabled         =   btnDropRight.Enabled        =   b;
            btnPenaltyLeft.Enabled      =   btnPenaltyRight.Enabled     =   b;
            btnTryLeft.Enabled          =   btnTryRight.Enabled         =   b;
        }

        private void rbtnChileLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Chile;
            nationLeft = "Chile";
        }

        private void rbtnGermanyLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Germany;
            nationLeft = "Germany";
        }

        private void rbtnCameroonLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Cameroon;
            nationLeft = "Cameroon";
        }

        private void rbtnChileRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Chile;
            nationRight = "Chile";
        }

        private void rbtnGermanyRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Germany;
            nationRight = "Germany";
        }

        private void rbtnCameroonRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Cameroon;
            nationRight = "Cameroon";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (nationLeft == nationRight)
            {
                MessageBox.Show("The two sides cann't be the same nation.", "Note!");
                return;
            }
            boxLeft.Enabled = boxRight.Enabled = btnStart.Enabled = false;
            btnStop.Enabled = true;
            operateOnAllScoreButtons(true);
            timer.Start();
            c = new Controller(nationLeft, nationRight);
        }

        private void tick_eventHandler(object sender, EventArgs e)
        {
            lblElapsed.Text = c.elapsedToString(++elapsed);
        }

        private void btnTryLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(0)).ToString();
            log.AppendText(c.makeLog(true, 0, lblElapsed.Text) + "\n");
        }

        private void btnConversionLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(1)).ToString();
            log.AppendText(c.makeLog(true, 1, lblElapsed.Text) + "\n");
        }

        private void btnPenaltyLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(2)).ToString();
            log.AppendText(c.makeLog(true, 2, lblElapsed.Text) + "\n");
        }

        private void btnDropLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(3)).ToString();
            log.AppendText(c.makeLog(true, 3, lblElapsed.Text) + "\n");
        }

        private void btnTryRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(0)).ToString();
            log.AppendText(c.makeLog(false, 0, lblElapsed.Text) + "\n");
        }

        private void btnConversionRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(1)).ToString();
            log.AppendText(c.makeLog(false, 1, lblElapsed.Text) + "\n");
        }

        private void btnPenaltyRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(2)).ToString();
            log.AppendText(c.makeLog(false, 2, lblElapsed.Text) + "\n");
        }

        private void btnDropRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(3)).ToString();
            log.AppendText(c.makeLog(false, 3, lblElapsed.Text) + "\n");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            int l = scoreLeft, r = scoreRight;
            string msg = l == r ? "A Tie." : l > r ? (nationLeft + " Won!") : (nationRight + " Won!");
            msg += " " + "Final score " + lblScoreLeft.Text + " : " + lblScoreRight.Text;
            MessageBox.Show(msg,"Result");
            this.Close();
        }
    }
}
