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
    /// <summary>
    /// EnrolledPapersForm
    /// </summary>
    internal class EnrolledPapersForm : Form
    {
        /// <summary>
        /// fields
        /// </summary>
        private DataGridView _Grid;
        private University _University;
        /// <summary>
        /// init, by vs
        /// </summary>
        private void InitializeComponent()
        {
            this._Grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this._Grid.AllowUserToAddRows = false;
            this._Grid.AllowUserToDeleteRows = false;
            this._Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Grid.Location = new System.Drawing.Point(0, 0);
            this._Grid.Name = "grid";
            this._Grid.ReadOnly = true;
            this._Grid.RowTemplate.Height = 23;
            this._Grid.Size = new System.Drawing.Size(595, 262);
            this._Grid.TabIndex = 0;
            // 
            // EnrolledPapersForm
            // 
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this._Grid);
            this.Name = "EnrolledPapersForm";
            ((System.ComponentModel.ISupportInitialize)(this._Grid)).EndInit();
            this.ResumeLayout(false);
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="u"></param>
        public EnrolledPapersForm(University u)
        {
            InitializeComponent();
            _University = u;
            this.SetupGrid();
        }
        /// <summary>
        /// setup grid
        /// </summary>
        private void SetupGrid()
        {
            var titles = new string[] { "Name", "Code", "Coordinator" };
            foreach (var t in titles)
                this._Grid.Columns.Add(t, t);
        }
        /// <summary>
        /// populate grid
        /// </summary>
        /// <param name="studentId"></param>
        internal void PopulateGrid(int studentId)
        {
            this._Grid.Rows.Clear();
            this._Grid.Refresh();
            var enrolledPapers = _University.FindEnrolledByStudent(studentId);
            foreach (var p in enrolledPapers)
                this._Grid.Rows.Add(new string[] { p.Name, p.Number.ToString(), p.Coordinator });

            var student = _University.FindStudent(studentId);
            this.Text = "Papers " + student.Name + " " + student.Id + " has enrolled";
        }
    }
}
