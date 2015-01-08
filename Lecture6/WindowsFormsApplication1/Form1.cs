using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Stopwatch s;
        public Form1()
        {
            InitializeComponent();
            s = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "The time is now " + System.DateTime.Now.ToString();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog1.FileName;
                MessageBox.Show(fileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            s.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Stop();
            MessageBox.Show(s.Elapsed.ToString());
        }
    }
}
