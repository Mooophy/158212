﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Sudoku
{
    public partial class GamePanel : Form
    {
        internal BackEnd BackEnd;
        internal SButton[,] Board;

        public GamePanel(string path)
        {
            InitializeComponent();
            this.BackEnd = new BackEnd(path);
            this.Init();
        }

        private void Init()
        {
            int buttonSize = 80;
            this.Size = new Size((buttonSize + 4) * this.BackEnd.Matrix.Count, 
                                 (buttonSize + 8) * this.BackEnd.Matrix.Count);
            this.Board = new SButton[this.BackEnd.Matrix.Count, this.BackEnd.Matrix.Count];

            foreach (var row in Enumerable.Range(0, this.BackEnd.Matrix.Count))
            {
                foreach (var col in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                {
                    var sbutton = new SButton(buttonSize, this.BackEnd.Matrix.Count, row, col);

                    sbutton.Location = new Point(col * buttonSize, row * buttonSize);
                    sbutton.MouseWheel += this.SetValue;
                    sbutton.Text = this.BackEnd.Matrix.Data[row, col].ToString();
                    Board[row, col] = sbutton;
                    this.Controls.Add(Board[row, col]);
                }
            }
        }

        private void SetValue(object sender, MouseEventArgs e)
        {
            var sButton = sender as SButton;
            var result = this.BackEnd.Matrix.SetValue(sButton.Value, sButton.Row, sButton.Col);

            if (result.VaildRow)
                foreach (var col in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                    this.Board[sButton.Row, col].MarkWithColor();
            if (result.ValidCol)
                foreach (var row in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                    this.Board[row, sButton.Col].MarkWithColor();
            if (result.IsSolved)
            { 
                MessageBox.Show("SOLVED!!");
                this.Close();
            }
        }
    }
}
