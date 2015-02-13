using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Sudoku6
    {
        public class RowRangeSet : HashSet<Matrix.Range>
        {
            public RowRangeSet()
            {
                this.Add(new Matrix.Range(0, 2));
                this.Add(new Matrix.Range(2, 2));
                this.Add(new Matrix.Range(4, 2));
            }
        }

        public class ColRangeSet : HashSet<Matrix.Range>
        {
            public ColRangeSet()
            {
                this.Add(new Matrix.Range(0, 3));
                this.Add(new Matrix.Range(3, 3));
            }
        }
    }
}
