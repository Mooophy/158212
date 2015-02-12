using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Range
    {
        public readonly int Begin, Count;
        public Range(int b, int c)
        {
            Begin = b;
            Count = c;
        }
    }

    public abstract class Matrix
    {
        protected int[,] _Data;
        public readonly List<Range> RowRanges, ColRanges;

        public Matrix(int size, List<Range> rRanges, List<Range> cRanges)
        {
            _Data = new int[size, size];
            this.RowRanges = rRanges;
            this.ColRanges = cRanges;
        }

        protected bool CheckRow(int row)
        {
            var set = new HashSet<int>();
            for (int col = 0; col != _Data.GetLength(0); ++col)
                if (_Data[row, col] != 0) set.Add(_Data[row, col]);
            return set.Count == _Data.GetLength(0);
        }

        protected bool CheckCol(int col)
        {
            var set = new HashSet<int>();
            for (int row = 0; row != _Data.GetLength(0); ++row)
                if (_Data[row, col] != 0) set.Add(_Data[row, col]);
            return set.Count == _Data.GetLength(0);
        }

        protected abstract bool CheckRgn(int row, int col);
        protected abstract bool CheckAll();

        public Tuple<bool, bool, bool, bool> SetValue(int row, int col, int val)
        {
            _Data[row, col] = val;
            var isValidRow = this.CheckRow(row);
            var isValidCol = this.CheckCol(col);
            var isValidRgn = this.CheckRgn(row, col);
            var isValidAll = isValidRow && isValidCol && isValidRgn && this.CheckAll(); 
            return Tuple.Create(isValidRow, isValidCol, isValidRgn, isValidAll);
        }
    }
}
