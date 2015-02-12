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
                .First(r => Enumerable.Range(r.Begin, r.Count).Any(i => i == col));
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
