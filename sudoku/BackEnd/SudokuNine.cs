using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class SudokuNine : Matrix
    {
        public readonly List<Range> Ranges;

        public SudokuNine()
            : base(9)
        {
            this.Ranges = new List<Range> { new Range(0, 3), new Range(3, 3), new Range(6, 3) };
        }

        public SudokuNine(int [,] data)
            : base(9)
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
            foreach (var rowRange in this.Ranges)
                foreach (var colRange in this.Ranges)
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

        protected override bool CheckRgn(int row, int col)//bug found still working on
        {
            Func<int, Range> findRange = (i) =>
                this.Ranges.First();
                //.First(range => Enumerable.Range(range.Begin, range.Count).Any(n => n == i));
                //.Find(range => Enumerable.Range(range.Begin, range.Count).Any(num => num == i));

            var rowRange = findRange(row);
            var colRange = findRange(col);

            if (rowRange == null)
                throw new Exception("not found");

            if (colRange == null)
                throw new Exception("not found");

            return this.CheckBox(rowRange, colRange);
        }
    }
}
