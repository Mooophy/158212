using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace TextAnalysis
{
    public partial class MainForm : Form
    {
        List<string> Data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Stream fs = null;
                try
                {
                    using (var sr = new StreamReader(openFileDialog.FileName))
                    {
                        string[] content = sr.ReadToEnd().Split('\n');
                        MessageBox.Show(content[0]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
    }
}
