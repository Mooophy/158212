using System;
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
            this.Board = new SButton[this.BackEnd.Matrix.Count, this.BackEnd.Matrix.Count];
            this.InitButtonsAndSetNewSize();
        }

        private void InitButtonsAndSetNewSize()
        {
            int buttonSize = 80;

            //init sbuttons
            foreach (var row in Enumerable.Range(0, this.BackEnd.Matrix.Count))
            {
                foreach (var col in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                {
                    var sbutton = new SButton(buttonSize, this.BackEnd.Matrix.Count, row, col);
                    sbutton.Location = new Point(col * buttonSize, row * buttonSize);
                    sbutton.Text = this.BackEnd.Matrix.Data[row, col].ToString();
                    sbutton.MouseWheel += this.SetValue;
                    
                    this.Board[row, col] = sbutton;
                    this.Controls.Add(sbutton);
                }
            }

            //set new size for this form
            this.Size = new Size((buttonSize + 4) * this.BackEnd.Matrix.Count, (buttonSize + 8) * this.BackEnd.Matrix.Count);
        }

        private void SetValue(object sender, MouseEventArgs e)//modified
        {
            var sButton = sender as SButton;
            var feedback = this.BackEnd.Matrix.SetValue(sButton.Value, sButton.Row, sButton.Col);
            this.HandleResult(feedback, sButton);
        }

        private void HandleResult(Matrix.FeedBack feedback, SButton sButton)
        {
            foreach (var row in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                foreach (var col in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                    if (feedback.ValidRowSet.Contains(row) || feedback.ValidColSet.Contains(col))
                        this.Board[row, col].MarkWithColor();
                    else
                        this.Board[row, col].UnmarkWithColor();

            if (feedback.IsSolved)
            {
                MessageBox.Show("SOLVED!!");
                this.Close();
            }
        }
    }
}
