﻿using System;
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

        #region branch new/edit
        private void gridStudentsOnRowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex != this.gridStudents.RowCount - 1)
            {
                var cells = this.gridStudents.Rows[e.RowIndex].Cells;
                
                //check if any cell is empty
                if(cells.Cast<DataGridViewCell>().Any(c => c.Value == null))
                {
                    e.Cancel = true;
                    MessageBox.Show("Empty cell");
                    return;
                }

                //check if id is not a number
                int id = 0;
                if(! Int32.TryParse( cells["Id"].Value.ToString(), out id))
                {
                    e.Cancel = true;
                    MessageBox.Show("Invalid Student Id");
                    this.gridStudents.ClearSelection();
                    cells["Id"].Selected = true;
                    return;
                }

                //check birth date
                DateTime birth;
                if(! DateTime.TryParse(cells["Birth"].Value.ToString(), out birth))
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

        private void gridPaperOnDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < this.gridPapers.Rows.Count - 1)
            {
                this.gridPapers.Rows[e.RowIndex].Selected = true;
                int paperCode = Convert.ToInt32(this.gridPapers.CurrentRow.Cells[1].Value.ToString());
                _EnrolledStudents.populateGrid(paperCode);
                _EnrolledStudents.ShowDialog();
            }
        }

        private void gridStudentsOnCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex < this.gridStudents.Rows.Count - 1 && !this.gridStudents.Rows[e.RowIndex].IsNewRow)
            {
                this.gridStudents.Rows[e.RowIndex].Selected = true;
                int studentId = Convert.ToInt32(this.gridStudents.CurrentRow.Cells[0].Value.ToString());
                _EnrolledPapers.populateGrid(studentId);
                _EnrolledPapers.ShowDialog();
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
