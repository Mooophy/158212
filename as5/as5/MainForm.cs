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
    /// <summary>
    /// custom part of abstraction for MainForm
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// fields
        /// </summary>
        private Lib.University _University;
        private EnrolledPapersForm _EnrolledPapers;
        private EnrolledStudentsForm _EnrolledStudents;
        private PapersList _PapersToChoose;
        /// <summary>
        /// Ctor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _University = new University();
            _EnrolledPapers = new EnrolledPapersForm(_University);
            _EnrolledStudents = new EnrolledStudentsForm(_University);
            _PapersToChoose = new PapersList();

            this.SetupGridStudents();
            this.SetupGridPapers();
        }

        #region functions
        /// <summary>
        /// init titles for grid students
        /// </summary>
        private void SetupGridStudents()
        {
            var titles = new string[] { "Id", "Name", "Birth", "Address" };
            foreach (var t in titles)
                this.gridStudents.Columns.Add(t, t);
        }
        /// <summary>
        /// populate grid students
        /// </summary>
        private void PopulateGridStudents()
        {
            this.gridStudents.Rows.Clear();
            foreach (var s in _University.Students)
                this.gridStudents.Rows.Add(new string[] { s.Id.ToString(), s.Name, s.BirthDate.ToString(), s.Address });
        }
        /// <summary>
        /// init grid papers
        /// </summary>
        private void SetupGridPapers()
        {
            var titles = new string[] { "Name", "Code", "Coordinator" };
            foreach (var t in titles)
                this.gridPapers.Columns.Add(t, t);
        }
        /// <summary>
        /// populate grid papers
        /// </summary>
        private void PopulateGridPapers()
        {
            this.gridPapers.Rows.Clear();
            foreach (var p in _University.Papers)
                this.gridPapers.Rows.Add(new string[] { p.Name, p.Number.ToString(), p.Coordinator });
        }
        /// <summary>
        /// import students
        /// </summary>
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
        /// <summary>
        /// import papers
        /// </summary>
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
        /// <summary>
        /// import enrollment infomation
        /// </summary>
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
                    MessageBox.Show("All data has been loaded without errors");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        /// <summary>
        /// validation checking for a row from grid papers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridPapersOnRowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == this.gridPapers.RowCount - 1)
                return;

            var cells = this.gridPapers.Rows[e.RowIndex].Cells;

            //check if any cell is empty
            if (cells.Cast<DataGridViewCell>().Any(c => c.Value == null))
            {
                e.Cancel = true;
                MessageBox.Show("Empty cell");
                return;
            }

            //check paper code
            int code = 0;
            if (!Int32.TryParse(cells["Code"].Value.ToString(), out code))
            {
                e.Cancel = true;
                MessageBox.Show("Invalid Paper Code");
                this.gridPapers.ClearSelection();
                cells["Code"].Selected = true;
                return;
            }

            //construct new paper and save
            string name = cells["Name"].Value.ToString();
            string coordinator = cells["Coordinator"].Value.ToString();
            var paper = new Paper(name, code, coordinator);
            _University.Add(paper);
        }
        /// <summary>
        /// validation checking for a row from grid students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridStudentsOnRowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == this.gridStudents.RowCount - 1)
                return;

            var cells = this.gridStudents.Rows[e.RowIndex].Cells;

            //check if any cell is empty
            if (cells.Cast<DataGridViewCell>().Any(c => c.Value == null))
            {
                e.Cancel = true;
                MessageBox.Show("Empty cell");
                return;
            }

            //check if id is not a number
            int id = 0;
            if (!Int32.TryParse(cells["Id"].Value.ToString(), out id))
            {
                e.Cancel = true;
                MessageBox.Show("Invalid Student Id");
                this.gridStudents.ClearSelection();
                cells["Id"].Selected = true;
                return;
            }

            //check birth date
            DateTime birth;
            if (!DateTime.TryParse(cells["Birth"].Value.ToString(), out birth))
            {
                e.Cancel = true;
                MessageBox.Show("Invalid Date");

                this.gridStudents.ClearSelection();
                cells["Birth"].Selected = true;
                return;
            }

            //creat new student and save.
            string name = cells["Name"].Value.ToString();
            string address = cells["Address"].Value.ToString();
            var student = new Student(id, name, birth, address);
            _University.Add(student);
        }
        /// <summary>
        /// when menu import students item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuImportStudentsClick(object sender, EventArgs e)
        {
            this.ImportStudents();
        }
        /// <summary>
        /// when menu import papers item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuImportPapersClick(object sender, EventArgs e)
        {
            this.ImportPapers();
        }
        /// <summary>
        /// when menu import enrollemnt information item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuImportEnrollmentClick(object sender, EventArgs e)
        {
            this.ImportEnrollment();

        }
        /// <summary>
        /// CTRL + W for grid papers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridPapersOnControlWPressed(object sender, KeyEventArgs e)
        {
             if(e.Control && e.KeyCode == Keys.W)
             {
                 if (this.gridPapers.CurrentRow.Cells["Code"].Value == null)
                     return;
                 int code = 0;
                 if (Int32.TryParse(this.gridPapers.CurrentRow.Cells["Code"].Value.ToString(), out code))
                 {
                     _EnrolledStudents.PopulateGrid(code);
                     _EnrolledStudents.ShowDialog();
                 }
             }
        }
        /// <summary>
        /// CTRL + W for grid students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridStudentsOnControlWPressed(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.W)
            {
                if (this.gridStudents.CurrentRow.Cells["Id"].Value == null)
                    return;
                int id = 0;
                if (Int32.TryParse(this.gridStudents.CurrentRow.Cells["Id"].Value.ToString(), out id))
                {
                    _EnrolledPapers.PopulateGrid(id);
                    _EnrolledPapers.ShowDialog();
                }
            }

            if(e.Control && e.KeyCode == Keys.A)
            {
                if (this.gridStudents.CurrentRow.Cells["Id"].Value == null)
                    return;

                var studentId = Convert.ToInt32(this.gridStudents.CurrentRow.Cells["Id"].Value);
                Func<int, string[]> availablePapers = (id) =>
                {
                    var PaperCodes = from p in _University.Papers
                                     where _University.FindEnrolledByStudent(id).Contains(p) == false
                                     select p.Number.ToString();
                    return PaperCodes.ToArray();
                };

                _PapersToChoose.Populate(availablePapers(studentId));
                _PapersToChoose.ShowDialog();
                var paperChosen = _PapersToChoose.GetSelectedPaperCode();

                if (paperChosen != null && _University.Enrol(paperChosen.Value, studentId))
                    MessageBox.Show("Student " + studentId + " enrolled paper" + paperChosen.Value);
                else
                    MessageBox.Show("Failed to enroll this paper");
            }
        }
        /// <summary>
        /// when menu exit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuExitClick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// when menu export click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuExportClick(object sender, EventArgs e)
        {
            var fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(_University.Export(fdb.SelectedPath) ? "Done" : "Failed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
