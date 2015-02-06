using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    public partial class Form1 : Form
    {
        Button[,] _Matrix = new Button[9, 9];
        void InitMatrix()
        {
            foreach (var row in Enumerable.Range(0, 9))
            {
                foreach (var col in Enumerable.Range(0, 9))
                {
                    var b = new Button();
                    b.Text = (row + col).ToString();
                    b.ForeColor = Color.Red;
                    b.Size = new Size(50, 50);
                    b.Location = new Point(row * 55, col * 55);
                    _Matrix[row, col] = b;
                    this.Controls.Add(b);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.InitMatrix();
        }
    }
}
