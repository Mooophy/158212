﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    
    public class SudokuNine : Matrix
    {
        List<Range> _Ranges;

        public SudokuNine()
            : base(9)
        {
            _Ranges = new List<Range> { new Range(0, 3), new Range(3, 6), new Range(6, 9) };
        }

        protected override bool CheckAll()
        {
            bool ret = true;
            
            //check all rows and cols
            for (int i = 0; i != _Data.Length; ++i)
                if (ret)
                    ret = ret && this.CheckRow(i) && this.CheckCol(i);
                else
                    goto Done;

            //check all regions
            foreach (var rowRange in _Ranges)
                foreach (var colRange in _Ranges)
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
            foreach (var row in Enumerable.Range(rowRange.Begin, rowRange.End))
                foreach (var col in Enumerable.Range(colRange.Begin, colRange.End))
                    if (_Data[row, col] != 0) set.Add(_Data[row, col]);
            return set.Count == _Data.Length;
        }

        protected override bool CheckRgn(int row, int col)
        {
            Func<int, Range> findRange = (i) =>
                _Ranges
                .Find(range => Enumerable.Range(range.Begin, range.End).Any(num => num == row));
            return this.CheckBox(findRange(row), findRange(col));
        }
    }
}
