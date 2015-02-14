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

        public GamePanel(string path)
        {
            InitializeComponent();
            this.BackEnd = new BackEnd(path);
            this.Size = new Size(50 * this.BackEnd.Matrix.Size, 50 * this.BackEnd.Matrix.Size);
        }
    }
}
