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
        private int elapsed;
        
        public MainForm()
        {
            InitializeComponent();
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
            timer.Start();
        }

        private void tick_eventHandler(object sender, EventArgs e)
        {
            lblElapsed.Text = c.elapsedToString(++elapsed);
        }
    }
}
