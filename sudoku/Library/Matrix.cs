using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Matrix
    {
        public readonly int Count;
        public int[,] Data { get; private set; }
        public HashSet<Range> RowRangeSet, ColRangeSet;
        
        protected Matrix(int size, HashSet<Range> rSet, HashSet<Range> cSet)
        {
            this.Count = size;
            this.RowRangeSet = rSet;
            this.ColRangeSet = cSet;
            this.Data = new int[size, size];
        }
        
        protected Matrix(int size, HashSet<Range> rSet, HashSet<Range> cSet, int[,] data)
        {
            this.Count = size;
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
            return set.Count == this.Count && set.All(i => i != 0);
        }
        
        public bool CheckRow(int row)
        {
            var unit = 
                Enumerable
                .Range(0, this.Count)
                .Select(col => this.Data[row, col])
                .ToArray();
            return this.Check(unit);
        }
        
        public bool CheckCol(int col)
        {
            var unit =
                Enumerable
                .Range(0, this.Count)
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
                .Range(0, this.Count)
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
        
        public FeedBack SetValue(int val, int row, int col)// modified
        {
            this.Data.SetValue(val, row, col);
            return this.ReadStates();

            //var isValidRow = this.CheckRow(row);
            //var isValidCol = this.CheckCol(col);
            //var isValidBox = this.CheckBox(row, col);
            //var isSolved = isValidRow && isValidCol && isValidBox;
            //if (isSolved)
            //    isSolved = this.IsSolved();
            //return new Result(isValidRow, isValidCol, isValidBox, isSolved);
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
        
        private FeedBack ReadStates()
        {
            FeedBack reply = new FeedBack();

            foreach (var row in Enumerable.Range(0, this.Count).Where(row => this.CheckRow(row)))
                reply.ValidRowSet.Add(row);
            foreach (var col in Enumerable.Range(0, this.Count).Where(col => this.CheckCol(col)))
                reply.ValidColSet.Add(col);
            reply.IsSolved = this.IsSolved();

            return reply;
        }

        public class Result //to delete
        {
            public readonly bool VaildRow, ValidCol, ValidBox, IsSolved;
            public Result(bool vr, bool vc, bool vb, bool isSv)
            {
                this.VaildRow = vr;
                this.ValidCol = vc;
                this.ValidBox = vb;
                this.IsSolved = isSv;
            }
        }


        public class FeedBack
        {
            public HashSet<int> ValidRowSet { get; private set; }
            public HashSet<int> ValidColSet { get; private set; }
            public bool IsSolved { get; set; }

            public FeedBack()
            {
                this.ValidRowSet = new HashSet<int>();
                this.ValidColSet = new HashSet<int>();
                this.IsSolved = false;
            }

            public FeedBack(HashSet<int> vrs, HashSet<int> vcs, bool isSolved)
            {
                this.ValidRowSet = vrs;
                this.ValidColSet = vcs;
                this.IsSolved = isSolved;
            }
        }
    }
}
