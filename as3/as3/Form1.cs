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


    public partial class Form1 : Form
    {

        private int elapsed;
        delegate bool lambda(int i);

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Images.Chile;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Images.Germany;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Images.Cameroon;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Images.Chile;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Images.Germany;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Images.Cameroon;
        }

        private void tick_EventHandler(object sender, EventArgs e)
        {
            ++elapsed;
            label1.Text = getTimeStr();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = groupBox2.Enabled = false;
            enableAllScoreButtons();
        }

        private void enableAllScoreButtons()
        {
            buttonLeftConversion.Enabled    =   buttonLeftDrop.Enabled  =   buttonLeftPenalty.Enabled   =   buttonLeftTry.Enabled   =   true;
            buttonRightConversion.Enabled   =   buttonRightDrop.Enabled =   buttonRightPenalty.Enabled  =   buttonRightTry.Enabled  =   true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private String getTimeStr()
        {
            lambda isTooShort = number => number < 10;
            var min = (isTooShort(elapsed / 60) ? "0" : "") + (elapsed / 60).ToString();
            var sec = (isTooShort(elapsed % 60) ? "0" : "") + (elapsed % 60).ToString();
            return min + ":" + sec;
        }
        
        private void buttonLeftTry_Click(object sender, EventArgs e)
        {

        }


    }
}
