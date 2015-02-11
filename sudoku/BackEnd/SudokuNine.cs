using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class SudokuNine : Matrix
    {
        public SudokuNine()
            : base(9, new List<Range> { new Range(0, 3), new Range(3, 3), new Range(6, 3) })
        {   }

        public SudokuNine(int [,] data)
            : this()
        {
            _Data = data;
        }

        protected override bool CheckAll()
        {
            bool ret = true;
            
            //check all rows and cols
            for (int i = 0; i != _Data.GetLength(0); ++i)
                if (ret)
                    ret = ret && this.CheckRow(i) && this.CheckCol(i);
                else
                    goto Done;

            //check all regions
            foreach (var rowRange in this._Ranges)
                foreach (var colRange in this._Ranges)
                    if (ret)
                        ret = ret && this.CheckBox(rowRange, colRange);
                    else
                        goto Done;
            Done:
            return ret;
        }

        private bool CheckBox(Range rowRange, Range colRange)
        {
            var set = new HashSet<int>();
            foreach (var row in Enumerable.Range(rowRange.Begin, rowRange.Count))
                foreach (var col in Enumerable.Range(colRange.Begin, colRange.Count))
                    if (_Data[row, col] != 0) set.Add(_Data[row, col]);
            return set.Count == _Data.GetLength(0);
        }

        protected override bool CheckRgn(int row, int col)
        {
            Func<int, Range> findRange = (i) =>
                this._Ranges
                .Find(range => Enumerable.Range(range.Begin, range.Count).Any(num => num == i));
            return this.CheckBox(findRange(row), findRange(col));
        }
    }
}
