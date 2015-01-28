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
        private Lib.University _uni;

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

        private void ImportStudents()
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                {
                    _uni.AddStudentsByFile(openFileDialog.FileName);
                }
                catch(Exception ex)
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
                    _uni.AddPapersByFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ImportEnrollment()
        {
            if(_uni.Students.Count == 0)
            {
                MessageBox.Show("Please import students and papers first.");
                return;
            }

            if(_uni.Papers.Count == 0)
            {
                MessageBox.Show("Please import students and papers first.");
                return;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _uni.EnrolByFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        
        private void gridCell_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var curr = grid.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
            grid.ClearSelection();
            grid.Rows[e.RowIndex].Selected = true;
            //
            //here to show the enrollment form
            //
            //MessageBox.Show(e.RowIndex + " : " + e.ColumnIndex);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuViewStudents_Click(object sender, EventArgs e)
        {
            this.DisplayStudents();
        }

        private void menuViewPapers_Click(object sender, EventArgs e)
        {
            this.DisplayPapers();
        }

        private void menuImportStudents_Click(object sender, EventArgs e)
        {
            this.ImportStudents();
            this.DisplayStudents();
        }

        private void menuImportPapers_Click(object sender, EventArgs e)
        {
            this.ImportPapers();
            this.DisplayPapers();
        }

        private void menuImportEnrollment_Click(object sender, EventArgs e)
        {
            this.ImportEnrollment();
        }
    }
}
