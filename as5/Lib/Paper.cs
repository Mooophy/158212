using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Paper : IComparable
    {
        public readonly string Name;
        public readonly int Number;
        public readonly string Coordinator;

        /// <summary>
        /// Implementation for interface IComparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var other = obj as Paper;
            if (other != null)
                return this.Number.CompareTo(other.Number);
            else
                throw new ArgumentException("object is not a Paper");
        }

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

        public override string ToString()
        {
            return Name + " " + Number + " " + Coordinator;
        }
    }
}
