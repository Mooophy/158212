using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    internal abstract class Matrix
    {
        protected int[,] _Data;

        public Matrix(int size)
        {
            _Data = new int[size, size];
        }

        protected bool CheckRow(int row)
        {
            var set = new HashSet<int>();
            for (int col = 0; col != _Data.Length; ++col)
                if (_Data[row, col] != 0) set.Add(_Data[row, col]);
            return set.Count == _Data.Length;
        }

        protected bool CheckCol(int col)
        {
            var set = new HashSet<int>();
            for (int row = 0; row != _Data.Length; ++row)
                if (_Data[row, col] != 0) set.Add(_Data[row, col]);
            return set.Count == _Data.Length;
        }

        protected abstract bool CheckRgn(int row, int col);
        protected abstract bool CheckAll();

        public Tuple<bool, bool, bool, bool> SetValue(int row, int col, int val)
        {
            _Data[row, col] = val;
            var isValidRow = this.CheckRow(row);
            var isValidCol = this.CheckCol(col);
            var isValidRgn = this.CheckRgn(row, col);
            var isValidAll = isValidRow && isValidCol && isValidRgn ? this.CheckAll() : false;
            return Tuple.Create(isValidRow, isValidCol, isValidRgn, isValidAll);
        }
    }
}
