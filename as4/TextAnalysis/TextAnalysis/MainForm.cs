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
using Lib;


namespace TextAnalysis
{
    public partial class MainForm : Form
    {
        Lib.Controller backend;

        /// <summary>
        /// Refer to a post on SO :
        /// http://stackoverflow.com/questions/3419159/how-to-get-all-child-controls-of-a-windows-forms-form-of-a-specific-type-button
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany( ctrl => GetAll(ctrl, type))
                                        .Concat(controls)
                                        .Where(c => c.GetType() == type);
        }

        void DisableAllButtons()
        {
            foreach (var c in GetAll(this, typeof(Button)))
                c.Enabled = false;
        }

        void EnableAllButtons()
        {
            foreach (var c in GetAll(this, typeof(Button)))
                c.Enabled = true;
        }

        public MainForm()
        {
            InitializeComponent();
            DisableAllButtons();
        }

        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                    using (var sr = new StreamReader(openFileDialog.FileName))
                    {
                        var data = new List<string>();
                        while (sr.Peek() > 0)
                            data.AddRange(sr.ReadLine().Split(' '));
                        backend = new Lib.Controller(data);
                    }
                    EnableAllButtons();
                    display.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("exception : " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnByLength_Click(object sender, EventArgs e)
        {
            int len;
            if(int.TryParse(txtLength.Text, out len))
            {
                string s = "The words that have length " + len.ToString() + " : \n";
                foreach (var w in backend.LookupByLength(len)) 
                    s += "'" + w + "'";
                display.AppendText(s + ".\n");
            }
            else
            {
                MessageBox.Show("Please enter a lenth.");
            }
        }

        private void btnByWord_Click(object sender, EventArgs e)
        {
            if(txtWord.Text.Length != 0)
            {
                string s = "The word '" + txtWord.Text + "' occurs ";
                s += backend.HowOften(txtWord.Text).ToString() + " times.\n";
                display.AppendText(s);
            }
            else
            {
                MessageBox.Show("Please enter a word.");
            }
        }

        private void btnMostCommon_Click(object sender, EventArgs e)
        {
            var mc = backend.MostCommon();
            string s = "The most common word" + (mc.Item2.Count>2 ? "s are :\n" : " is ");
            foreach( var w in mc.Item2)
                s += "'" + w + "'";
            s += " (" + mc.Item1.ToString() + " times).\n";
            display.AppendText(s);
        }

        private void btnLongest_Click(object sender, EventArgs e)
        {
            var longestTuple = backend.Longest();
            string s = "The longest word" + (longestTuple.Item2.Count > 2 ? "s are :\n" : " is ");
            foreach (var word in longestTuple.Item2)
                s += "'" + word + "'";
            s += " (length is " + longestTuple.Item1.ToString() + ").\n";
            display.AppendText(s);
        }

        private void btnShortest_Click(object sender, EventArgs e)
        {
            var shortestTuple = backend.Shortest();
            string s = "The shortest word" + (shortestTuple.Item2.Count > 2 ? "s are :\n" : " is ");
            foreach (var word in shortestTuple.Item2)
                s += "'" + word + "'";
            s += " (length is " + shortestTuple.Item1.ToString() + ").\n";
            display.AppendText(s);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            display.AppendText("The average length : " + backend.Average().ToString() + "\r\n");
        }
    }
}
