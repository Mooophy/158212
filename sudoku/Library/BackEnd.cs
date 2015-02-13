using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public class BackEnd
    {
        public readonly List<int> PossibleSizes;
        public Matrix Matrix { get; private set; }

        public BackEnd()
        {
            this.PossibleSizes = new List<int> { 4, 6, 9 };
            this.Matrix = new Sudoku9();
        }

        public BackEnd(string path)
        {
            this.PossibleSizes = new List<int> { 4, 6, 9 };
            this.Matrix = this.MakeSudoku(path);
        }

        private Matrix MakeSudoku(string path)
        {
            var data = this.ReadFile(path);
            if (data.Length == 81)
                return new Sudoku9(data);
            else if (data.Length == 36)
                return new Sudoku6(data);
            else
                return new Sudoku4(data);
        }

        public int[,] ReadFile(string path)
        {
            try
            {
                using (var sr = new StreamReader(path))
                {
                    var firstLine = sr.ReadLine().Split(' ');
                    int size = 0;
                    if (! int.TryParse(firstLine[0], out size))
                        throw new InvalidDataException();
                    if (! this.PossibleSizes.Any(i => i == size))
                        throw new InvalidDataException();
                   
                    int[,] data = new int[size, size];
                    for (string[] line; sr.Peek() > 0; )
                    {
                        line = sr.ReadLine().Split(' ');
                        int row = 0, col = 0, val = 0;
                        int.TryParse(line[0], out row);
                        int.TryParse(line[1], out col);
                        int.TryParse(line[2], out val);
                        data.SetValue(val, row, col);
                    }
                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
