using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;

namespace as5
{
    internal class EnrolledPapersForm : Form
    {

        private DataGridView grid;
        private University _University;

        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 23;
            this.grid.Size = new System.Drawing.Size(595, 262);
            this.grid.TabIndex = 0;
            // 
            // EnrolledPapersForm
            // 
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this.grid);
            this.Name = "EnrolledPapersForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        public EnrolledPapersForm(University u)
        {
            InitializeComponent();
            _University = u;
            this.SetupGrid();
        }
        private void SetupGrid()
        {
            var titles = new string[] { "Name", "Code", "Coordinator" };
            foreach (var t in titles)
                this.grid.Columns.Add(t, t);
        }

        internal void populateGrid(int studentId)
        {
            this.grid.Rows.Clear();
            this.grid.Refresh();
            var enrolledPapers = _University.FindEnrolledByStudent(studentId);
            foreach (var p in enrolledPapers)
                this.grid.Rows.Add(new string[] { p.Name, p.Number.ToString(), p.Coordinator });

            var student = _University.FindStudent(studentId);
            this.Text = "Papers " + student.Name + " " + student.Id + " has enrolled";
        }

    }
}
