using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Sudoku9 : Matrix
    {
        public Sudoku9()
            : base(9, new RangSet9(), new RangSet9())
        { }

        public Sudoku9(int[,] data)
            : base(9, new RangSet9(), new RangSet9(), data)
        { }

        public class RangSet9 : HashSet<Matrix.Range>
        {
            public RangSet9()
            {
                foreach (var num in Enumerable.Range(0, 3).Select(i => 3 * i))
                    this.Add(new Matrix.Range(num, 3));
            }
        }
    }
}
