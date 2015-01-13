﻿using System;
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
using TextAnalysis;


namespace TextAnalysis
{
    public partial class MainForm : Form
    {
        TextAnalysis.Controller _backEnd;

        #region functions
        void DisableAllButtons()
        {
            foreach (var c in AllControls.Get(this, typeof(Button)))
                c.Enabled = false;
        }

        void EnableAllButtons()
        {
            foreach (var c in AllControls.Get(this, typeof(Button)))
                c.Enabled = true;
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
            DisableAllButtons();
        }

        #region event handlers
        void openToolStripMenuItemClick(object sender, EventArgs e)
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
                        _backEnd = new TextAnalysis.Controller(data);
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

        private void exitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnByLengthClick(object sender, EventArgs e)
        {
            int len;
            if(int.TryParse(txtLength.Text, out len))
            {
                string s = "The words that have length " + len.ToString() + " : \n";
                foreach (var w in _backEnd.LookupByLength(len)) 
                    s += "'" + w + "'";
                display.AppendText(s + ".\n");
            }
            else
            {
                MessageBox.Show("Please enter a lenth.");
            }
        }

        private void btnByWordClick(object sender, EventArgs e)
        {
            if(txtWord.Text.Length != 0)
            {
                string s = "The word '" + txtWord.Text + "' occurs ";
                s += _backEnd.HowOften(txtWord.Text).ToString() + " times.\n";
                display.AppendText(s);
            }
            else
            {
                MessageBox.Show("Please enter a word.");
            }
        }

        private void btnMostCommonClick(object sender, EventArgs e)
        {
            var mc = _backEnd.MostCommon();
            string s = "The most common word" + (mc.Item2.Count>2 ? "s are :\n" : " is ");
            foreach( var w in mc.Item2)
                s += "'" + w + "'";
            s += " (" + mc.Item1.ToString() + " times).\n";
            display.AppendText(s);
        }

        private void btnLongestClick(object sender, EventArgs e)
        {
            var longestTuple = _backEnd.Longest();
            string s = "The longest word" + (longestTuple.Item2.Count > 2 ? "s are :\n" : " is ");
            foreach (var word in longestTuple.Item2)
                s += "'" + word + "'";
            s += " (length is " + longestTuple.Item1.ToString() + ").\n";
            display.AppendText(s);
        }

        private void btnShortestClick(object sender, EventArgs e)
        {
            var shortestTuple = _backEnd.Shortest();
            string s = "The shortest word" + (shortestTuple.Item2.Count > 2 ? "s are :\n" : " is ");
            foreach (var word in shortestTuple.Item2)
                s += "'" + word + "'";
            s += " (length is " + shortestTuple.Item1.ToString() + ").\n";
            display.AppendText(s);
        }

        private void btnAverageClick(object sender, EventArgs e)
        {
            display.AppendText("The average length : " + _backEnd.Average().ToString() + "\r\n");
        }
        #endregion
    }
}
