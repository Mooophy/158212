﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainForm : Form
    {
        //public SButton Button; // for testing
        private GamePanel GamePanel;
        public MainForm()
        {
            InitializeComponent();

            this.GamePanel = new GamePanel(@"s4.txt");
            this.GamePanel.ShowDialog();
            //this.Button = new SButton(50, 9, -9);
            //this.Controls.Add(this.Button);
        }
    }
}
