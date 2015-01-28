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

namespace as5
{
    public partial class MainForm : Form
    {
        Lib.University _uni;

        public MainForm()
        {
            InitializeComponent();
            _uni = new University();
        }

        #region functions
        private void DisplayStudents()
        {
            var data = from s in _uni.Students
                       select new { Id = s.Id, Name = s.Name, Birth = s.BirthDate.ToString(), Address = s.Address };
            grid.DataSource = data.ToArray();
        }

        private void DisplayPapers()
        {
            var data = from p in _uni.Papers
                       select new { Code = p.Number, Name = p.Name, Corrdinator = p.Coordinator };
            grid.DataSource = data.ToArray();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.DisplayStudents();
        }

        private void papersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.DisplayPapers();
        }
    }
}
