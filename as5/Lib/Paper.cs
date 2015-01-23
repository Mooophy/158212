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

        /// <summary>
        /// Instance Ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="number"></param>
        /// <param name="coodinator"></param>
        public Paper(string name, int number, string coodinator)
        {
            Name = name;
            Number = number;
            Coordinator = coodinator;
        }

        public Paper(Paper other)
            :this(other.Name,other.Number,other.Coordinator)
        { }
    }
}
