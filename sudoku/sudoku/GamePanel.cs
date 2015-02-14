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
            this.Init(path);
        }

        private void Init(string path)
        {
            this.BackEnd = new BackEnd(path);

            int sz = 100 * this.BackEnd.Matrix.Count;
            this.Size = new Size(sz, sz);
            this.Board = new SButton[sz, sz];

            foreach (var row in Enumerable.Range(0, this.BackEnd.Matrix.Count))
            {
                foreach (var col in Enumerable.Range(0, this.BackEnd.Matrix.Count))
                {
                    Board[row, col] = new SButton(100, this.BackEnd.Matrix.Count, this.BackEnd.Matrix.Count * (-1));
                    this.Controls.Add(Board[row, col]);
                }
            }
        }
    }
}
