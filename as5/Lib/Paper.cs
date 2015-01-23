using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Paper
    {
        public readonly string Name;
        public readonly int Number;
        public readonly string Coordinator;

        public Paper(string name, int number, string coodinator)
        {
            Name = name;
            Number = number;
            Coordinator = coodinator;
        }
    }
}
