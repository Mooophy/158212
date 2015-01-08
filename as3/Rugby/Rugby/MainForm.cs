using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace Rugby
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Logic controller
        /// </summary>
        private Lib.Controller c = new Controller();

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
