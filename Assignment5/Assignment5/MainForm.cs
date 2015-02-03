using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace Assignment5
{
    using S = BackEnd.Student<long>;
    using P = BackEnd.Paper<long>;
    using E = BackEnd.Enrollment<long>;
    public partial class MainForm : Form
    {
        private BackEnd.University _Uni;

        public MainForm()
        {
            InitializeComponent();

            _Uni = new BackEnd.University();
        }

        #region functions

        #endregion
    }
}
