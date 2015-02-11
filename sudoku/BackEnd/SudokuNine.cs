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
            : base(9)
        {}

        protected override bool CheckAll()
        {
            bool ret = true;
            
            for (int i = 0; i != _Data.Length; ++i)
                if (ret)
                    ret = ret && this.CheckRow(i) && this.CheckCol(i);
                else
                    goto Done;


            var ranges = new List<Tuple<int, int>> { Tuple.Create(0, 3), Tuple.Create(3, 6), Tuple.Create(6, 9) };
            foreach (var rowRange in ranges)
            {
                foreach (var colRange in ranges)
                {
                    if (ret)
                    {
                        var set = new HashSet<int>();
                        for (int row = rowRange.Item1; row != rowRange.Item2; ++row)
                            for (int col = colRange.Item1; col != colRange.Item2; ++col)
                                if (_Data[row, col] != 0) set.Add(_Data[row, col]);
                        ret = ret && (set.Count == _Data.Length);
                    }
                    else
                        goto Done;
                }
            }       

            Done:
            return ret;
        }

        protected override bool CheckRgn(int row, int col)
        {
            throw new NotImplementedException();
        }
    }
}
