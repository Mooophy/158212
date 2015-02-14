using System;
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
        private GamePanel _GamePanel;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                _GamePanel = new GamePanel(_OpenFileDialog.FileName);
                _GamePanel.ShowDialog();
            }
        }
    }
}
