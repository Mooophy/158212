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
        public SButton(int size)
            : base()
        {
            this.Size = new System.Drawing.Size(size, size);
            this.MouseWheel += this.OnMouseWheelMoving;
            this.Text = this.Value.ToString();
        }

        private void OnMouseWheelMoving(object sender, MouseEventArgs e)
        {
            if(this.Value <= -9 && e.Delta < 0)
                return;
            if (this.Value >= 9 && e.Delta > 0)
                return;

            this.Value += (e.Delta > 0) ? 1 : -1;
            this.Text = this.Value.ToString();
        }
    }
}
