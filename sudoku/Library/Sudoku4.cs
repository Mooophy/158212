using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Sudoku4 : Library.Matrix
    {
        public Sudoku4()
            : base(4, new RangeSet4(), new RangeSet4())
        { }

        public Sudoku4(int[,] data)
            : base(4, new RangeSet4(), new RangeSet4(), data)
        {}

        public class RangeSet4 : HashSet<Matrix.Range>
        {
            public RangeSet4()
            {
                this.Add(new Matrix.Range(0, 2));
                this.Add(new Matrix.Range(2, 2));
            }
        }
    }
}
