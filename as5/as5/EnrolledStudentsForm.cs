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
    internal class EnrolledStudentsForm : Form
    {

        private DataGridView grid;
        private University _University;

        public EnrolledStudentsForm(University u)
        {
            this.InitializeComponent();
            _University = u;
            this.SetupGrid();
        }

        private void SetupGrid()
        {
            var titles = new string[] { "Id", "Name", "Birth", "Address" };
            foreach (var t in titles)
                this.grid.Columns.Add(t, t);
        }

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
            // EnrolledStudentsForm
            // 
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this.grid);
            this.Name = "EnrolledStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }

        internal void populateGrid(int paperCode)
        {
            this.grid.Rows.Clear();
            this.grid.Refresh();

            var students = _University.FindEnrolledByPaper(paperCode);
            foreach (var s in students)
                this.grid.Rows.Add(new string[] { s.Id.ToString(), s.Name, s.BirthDate.ToString(), s.Address });
        }
    }
}
