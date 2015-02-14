using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Sudoku
{
    public class SButton : Button 
    {
        public int Value { get; private set; }
        public readonly int UpperLimit, LowerLimit;
        public readonly int Row, Col;
        public SButton(int buttonSize, int upperLimit, int lowerLimit, int row, int col)
            : base()
        {
            this.Size = new System.Drawing.Size(buttonSize, buttonSize);
            this.Value = 0;
            this.UpperLimit = upperLimit;
            this.LowerLimit = lowerLimit;
            this.Row = row;
            this.Col = col;
            this.Text = this.Value.ToString();
            this.MouseWheel += this.OnMouseWheelMoving;
        }

        private void OnMouseWheelMoving(object sender, MouseEventArgs e)
        {
            if(this.Value == this.LowerLimit && e.Delta < 0)
                return;
            if(this.Value == this.UpperLimit && e.Delta > 0)
                return;

            this.Value += (e.Delta > 0) ? 1 : -1;
            this.Text = this.Value.ToString();
        }
    }
}
