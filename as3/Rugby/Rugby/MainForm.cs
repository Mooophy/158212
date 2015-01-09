﻿﻿/*  
 *  class Main form for solution Rugby 
 *  by Boxi Zhang 12238967 
 *  for Assignment III, 159.212 Application Software Development Summer 2014 
 */

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
    //type aliasing
    using Images = global::Rugby.Properties.Resources;

    /// <summary>
    /// MainForm 
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private Lib.Controller c = new Controller();
        private string nationLeft = "Chile", nationRight="Germany";
        private int elapsed, scoreLeft, scoreRight;
        
        /// <summary>
        /// default Ctor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            operateOnAllScoreButtons(false);
        }

        /// <summary>
        /// enable or disable all score buttons
        /// </summary>
        /// <param name="b">left or not</param>
        void operateOnAllScoreButtons(bool b)
        {
            btnConversionLeft.Enabled   =   btnConversionRight.Enabled  =   b;
            btnDropLeft.Enabled         =   btnDropRight.Enabled        =   b;
            btnPenaltyLeft.Enabled      =   btnPenaltyRight.Enabled     =   b;
            btnTryLeft.Enabled          =   btnTryRight.Enabled         =   b;
        }

        /// <summary>
        /// event handler for left radio button Chile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnChileLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Chile;
            nationLeft = "Chile";
        }

        /// <summary>
        /// event handler for left Germany
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnGermanyLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Germany;
            nationLeft = "Germany";
        }

        /// <summary>
        /// event handler for left Cameroon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnCameroonLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Cameroon;
            nationLeft = "Cameroon";
        }

        /// <summary>
        /// event handler for right Chile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnChileRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Chile;
            nationRight = "Chile";
        }

        /// <summary>
        /// event handler for right Germany
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnGermanyRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Germany;
            nationRight = "Germany";
        }

        /// <summary>
        /// event handler for right Cameroon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnCameroonRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Cameroon;
            nationRight = "Cameroon";
        }

        /// <summary>
        /// event handler for start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// event handler for timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tick_eventHandler(object sender, EventArgs e)
        {
            lblElapsed.Text = c.elapsedToString(++elapsed);
        }

        /// <summary>
        /// event handler for left try 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTryLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(0)).ToString();
            log.AppendText(c.makeLog(true, 0, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for left conversion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConversionLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(1)).ToString();
            log.AppendText(c.makeLog(true, 1, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for left penalty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPenaltyLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(2)).ToString();
            log.AppendText(c.makeLog(true, 2, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for left drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDropLeft_Click(object sender, EventArgs e)
        {
            lblScoreLeft.Text = (scoreLeft += c.mapPoints(3)).ToString();
            log.AppendText(c.makeLog(true, 3, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for right try
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTryRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(0)).ToString();
            log.AppendText(c.makeLog(false, 0, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for right conversion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConversionRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(1)).ToString();
            log.AppendText(c.makeLog(false, 1, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for right penalty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPenaltyRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(2)).ToString();
            log.AppendText(c.makeLog(false, 2, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for right drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDropRight_Click(object sender, EventArgs e)
        {
            lblScoreRight.Text = (scoreRight += c.mapPoints(3)).ToString();
            log.AppendText(c.makeLog(false, 3, lblElapsed.Text) + "\n");
        }

        /// <summary>
        /// event handler for stop button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
