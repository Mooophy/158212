// for lower abstraction level

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
    //type aliasing
    using S = BackEnd.Student<long>;
    using P = BackEnd.Paper<long>;
    using E = BackEnd.Enrollment<long>;
    /// <summary>
    /// functions used as lower abstraction layer in this class
    /// </summary>
    public partial class MainForm
    {
        /// <summary>
        /// update data for the two grid views
        /// </summary>
        void UpdateGrids()
        {
            _GridPapers.Rows.Clear();
            foreach (var p in _Uni.Papers)
                _GridPapers.Rows.Add(p.ToString().Split(','));

            _GridStudents.Rows.Clear();
            foreach (var s in _Uni.Students)
                _GridStudents.Rows.Add(s.ToString().Split(','));
        }
        /// <summary>
        /// set alternating colors for the two grid views
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        void SetAlternatingRowStyles(Color first, Color second)
        {
            _GridPapers.RowsDefaultCellStyle.BackColor = first;
            _GridStudents.RowsDefaultCellStyle.BackColor = first;

            _GridPapers.AlternatingRowsDefaultCellStyle.BackColor = second;
            _GridStudents.AlternatingRowsDefaultCellStyle.BackColor = second;
        }
        /// <summary>
        /// setup columns to hold info for students
        /// </summary>
        /// <param name="grid"></param>
        void SetupColumnsFittingStudents(DataGridView grid)
        {
            grid.Columns.Clear();
            foreach (var title in new string[] { "Id", "Name", "Birth", "Address" })
                grid.Columns.Add(title, title);
        }
        /// <summary>
        /// setup columns to hold info for papers
        /// </summary>
        /// <param name="grid"></param>
        void SetupColumnsFittingPapers(DataGridView grid)
        {
            grid.Columns.Clear();
            foreach (var title in new string[] { "Code", "Name", "Coordinator" })
                grid.Columns.Add(title, title);
        }
        /// <summary>
        /// fill with enrolled students for a paper
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        long PopulateEnrolledStudents(DataGridView grid, long code)
        {
            this.SetupColumnsFittingStudents(grid);
            int idx = 0;
            foreach (var s in _Uni.FindEnrolledByPaper(code))
                idx = grid.Rows.Add(s.ToString().Split(','));
            return idx;
        }
        /// <summary>
        /// filled enrolled papers for a student
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        long PopulateEnrolledPapers(DataGridView grid, long id)
        {
            this.SetupColumnsFittingPapers(grid);
            int idx = 0;
            foreach (var p in _Uni.FindEnrolledByStudent(id))
                idx = grid.Rows.Add(p.ToString().Split(','));
            return idx;
        }
        /// <summary>
        /// fill available students into a grid view
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        long PopulateAvailableStudents(DataGridView grid, long code)
        {
            this.SetupColumnsFittingStudents(grid);
            grid.Rows.Clear();

            var availableStudents =
                _Uni.Students
                .Where(s => !_Uni.FindEnrolledByPaper(code).Contains(s));
            long idx = 0;
            foreach (var s in availableStudents)
                idx = grid.Rows.Add(s.ToString().Split(','));
            return idx;
        }
        /// <summary>
        /// fill available papers to a grid view
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        long PopulateAvailablePapers(DataGridView grid, long id)
        {
            this.SetupColumnsFittingPapers(grid);
            grid.Rows.Clear();

            var availablePapers =
                _Uni.Papers
                .Where(p => !_Uni.FindEnrolledByStudent(id).Contains(p));
            long idx = 0;
            foreach (var p in availablePapers)
                idx = grid.Rows.Add(p.ToString().Split(','));
            return idx;
        }
    }
}
