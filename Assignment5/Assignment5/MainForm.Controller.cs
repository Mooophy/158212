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
    using S = BackEnd.Student<long>;
    using P = BackEnd.Paper<long>;
    using E = BackEnd.Enrollment<long>;

    public partial class MainForm
    {
        private void SetupGrids()
        {
            foreach (var title in new string[] { "Code", "Name", "Coordinator" })
                _GridPapers.Columns.Add(title, title);

            foreach (var title in new string[] { "Id", "Name", "Birth", "Address" })
                _GridStudents.Columns.Add(title, title);
        }

        private void UpdateGrids()
        {
            _GridPapers.Rows.Clear();
            foreach (var p in _Uni.Papers)
                _GridPapers.Rows.Add(p.ToString().Split(','));

            _GridStudents.Rows.Clear();
            foreach (var s in _Uni.Students)
                _GridStudents.Rows.Add(s.ToString().Split(','));
        }

        private void SetAlternatingRowStyles(Color first, Color second)
        {
            _GridPapers.RowsDefaultCellStyle.BackColor = first;
            _GridStudents.RowsDefaultCellStyle.BackColor = first;

            _GridPapers.AlternatingRowsDefaultCellStyle.BackColor = second;
            _GridStudents.AlternatingRowsDefaultCellStyle.BackColor = second;
        }

        private long PopulateEnrolledStudents(DataGridView grid, long code)
        {
            grid.Columns.Clear();
            foreach (var title in new string[] { "Id", "Name", "Birth", "Address" })
                grid.Columns.Add(title, title);

            int idx = 0;
            foreach (var s in _Uni.FindEnrolledByPaper(code))
                idx = grid.Rows.Add(s.ToString().Split(','));
            return idx;
        }
    }
}
