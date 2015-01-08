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
        /// Logic controller
        /// </summary>
        private Lib.Controller c = new Controller();
        public MainForm()
        {
            InitializeComponent();
        }

        private void rbtnChileLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Chile;
        }

        private void rbtnGermanyLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Germany;
        }

        private void rbtnCameroonLeft_CheckedChanged(object sender, EventArgs e)
        {
            picLeft.Image = Images.Cameroon;
        }

        private void rbtnChileRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Chile;
        }

        private void rbtnGermanyRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Germany;
        }

        private void rbtnCameroonRight_CheckedChanged(object sender, EventArgs e)
        {
            picRight.Image = Images.Germany;
        }
    }
}
