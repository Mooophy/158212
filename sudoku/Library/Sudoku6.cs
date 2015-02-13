using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Sudoku6 : Library.Matrix
    {
        public Sudoku6()
            : base(6, new RRangeSet(), new CRangeSet())
        { }

        public Sudoku6(int[,] data)
            : base(6, new RRangeSet(), new CRangeSet(), data)
        { }

        public class RRangeSet : HashSet<Library.Matrix.Range>
        {
            public RRangeSet()
            {
                this.Add(new Matrix.Range(0, 2));
                this.Add(new Matrix.Range(2, 2));
                this.Add(new Matrix.Range(4, 2));
            }
        }

        public class CRangeSet : HashSet<Library.Matrix.Range>
        {
            public CRangeSet()
            {
                this.Add(new Matrix.Range(0, 3));
                this.Add(new Matrix.Range(3, 3));
            }
        }
    }
}
