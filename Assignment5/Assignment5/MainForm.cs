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
            this.InitializeComponent();

            _Uni = new BackEnd.University();
            this.SetupGrids();
        }

        private void RightClickOnGrid(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _ContextMenuStrip.Show(MousePosition);
                (_GridPapers.Focused ? _GridStudents : _GridPapers).ClearSelection();
            }
        }

        /// <summary>
        /// import students event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _StudentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var count = _Uni.ImportStudents(_OpenFileDialog.FileName);
                    this.UpdateGrids();
                    MessageBox.Show(count + " students loaded.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void _PapersToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var count = _Uni.ImportPapers(_OpenFileDialog.FileName);
                    this.UpdateGrids();
                    MessageBox.Show(count + " papers loaded.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void _EnrollmentsToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (_Uni.Papers.Count == 0 || _Uni.Students.Count == 0)
            {
                MessageBox.Show("Please import students and papers first.");
                return;
            }

            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var count = _Uni.ImportEnrollments(_OpenFileDialog.FileName);
                    MessageBox.Show(count + " pieces of enrollments info loaed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exportToolStripMenuItemClick(object sender, EventArgs e)
        {
            var fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(_Uni.ExportAllData(fdb.SelectedPath) ? "Done" : "Failed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
