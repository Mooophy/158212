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
        private Lib.University _University;
        private EnrolledPapersForm _EnrolledPapers;
        private EnrolledStudentsForm _EnrolledStudents;

        public MainForm()
        {
            InitializeComponent();

            _University = new University();
            _EnrolledPapers = new EnrolledPapersForm(_University);
            _EnrolledStudents = new EnrolledStudentsForm(_University);

            this.SetupGridStudents();
            this.SetupGridPapers();
        }

        #region functions
        private void SetupGridStudents()
        {

            var titles = new string[] { "Id", "Name", "Birth", "Address" };
            foreach (var t in titles)
                this.gridStudents.Columns.Add(t, t);
        }

        private void PopulateGridStudents()
        {
            this.gridStudents.Rows.Clear();
            foreach (var s in _University.Students)
                this.gridStudents.Rows.Add(new string[] { s.Id.ToString(), s.Name, s.BirthDate.ToString(), s.Address });
        }

        private void SetupGridPapers()
        {
            var titles = new string[] { "Name", "Code", "Coordinator" };
            foreach (var t in titles)
                this.gridPapers.Columns.Add(t, t);
        }

        private void PopulateGridPapers()
        {
            this.gridPapers.Rows.Clear();
            foreach (var p in _University.Papers)
                this.gridPapers.Rows.Add(new string[] { p.Name, p.Number.ToString(), p.Coordinator });
        }

        private void ImportStudents()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _University.AddStudentsByFile(openFileDialog.FileName);
                    this.PopulateGridStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ImportPapers()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _University.AddPapersByFile(openFileDialog.FileName);
                    this.PopulateGridPapers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ImportEnrollment()
        {
            if (_University.Students.Count == 0)
            {
                MessageBox.Show("Please import students and papers first.");
                return;
            }

            if (_University.Papers.Count == 0)
            {
                MessageBox.Show("Please import students and papers first.");
                return;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _University.EnrolByFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void menuImportStudents_Click(object sender, EventArgs e)
        {
            this.ImportStudents();
        }

        private void menuImportPapers_Click(object sender, EventArgs e)
        {
            this.ImportPapers();
        }

        private void menuImportEnrollment_Click(object sender, EventArgs e)
        {
            this.ImportEnrollment();
        }

        private void gridStudentsOnKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _EnrolledPapers.ShowDialog();
            }
        }

        private void gridPapersOnKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _EnrolledStudents.ShowDialog();
            }
        }
    }
}
