using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Matrix
    {
        public readonly int Size;
        public int[,] Data { get; private set; }
        public HashSet<Range> RowRangeSet, ColRangeSet;

        protected Matrix(int size, HashSet<Range> rSet, HashSet<Range> cSet)
        {
            this.Size = size;
            this.RowRangeSet = rSet;
            this.ColRangeSet = cSet;
            this.Data = new int[size, size];
        }

        protected Matrix(int size, HashSet<Range> rSet, HashSet<Range> cSet, int[,] data)
        {
            this.Size = size;
            this.RowRangeSet = rSet;
            this.ColRangeSet = cSet;
            this.Data = data;
        }

        public Range FindRowRange(int row)
        {
            return
                this
                .RowRangeSet
                .First(r => Enumerable.Range(r.Begin, r.Count).Any(i => i == row));
        }

        public Range FindColRange(int col)
        {
            return
                this
                .ColRangeSet
                .First(c => Enumerable.Range(c.Begin, c.Count).Any(i => i == col));
        }

        public bool Check(int[] unit)
        {
            var set = new HashSet<int>(unit);
            return set.Count == this.Size;
        }

        public bool CheckRow(int row)
        {
            var unit = 
                Enumerable
                .Range(0, this.Size)
                .Select(col => this.Data[row, col])
                .ToArray();
            return this.Check(unit);
        }

        public bool CheckCol(int col)
        {
            var unit =
                Enumerable
                .Range(0, this.Size)
                .Select(row => this.Data[row, col])
                .ToArray();
            return this.Check(unit);
        }

        public bool CheckBox(int row, int col)
        {
            var rowRange = this.FindRowRange(row);
            var colRange = this.FindColRange(col);
            var unit = 
                from r in Enumerable.Range(rowRange.Begin, rowRange.Count)
                from c in Enumerable.Range(colRange.Begin, colRange.Count)
                select this.Data[r, c];
            return this.Check(unit.ToArray());
        }

        public bool IsSolved()
        {
            bool isSolved =
                Enumerable
                .Range(0, 9)
                .All(index => this.CheckRow(index) && this.CheckCol(index));

            foreach (var rowRange in this.RowRangeSet)
                foreach (var colRange in this.ColRangeSet)
                    foreach (var row in Enumerable.Range(rowRange.Begin, rowRange.Count))
                        foreach (var col in Enumerable.Range(colRange.Begin, colRange.Count))
                            if (isSolved)
                                isSolved = isSolved && this.CheckBox(row, col);
                            else
                                break;
            return isSolved;
        }

        public class Range
        {
            public int Begin, Count;
            public Range(int begin, int count)
            {
                this.Begin = begin;
                this.Count = count;
            }
        }
    }
}
