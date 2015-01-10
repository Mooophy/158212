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
        List<string> Data = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this experiment suggests that string should be the interface between UI and Controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var sr = new StreamReader(openFileDialog.FileName))
                    {
                        string[] content = sr.ReadLine().Split(' ');
                        Data.AddRange(content);
                        foreach (var str in Data)   MessageBox.Show(str);
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
