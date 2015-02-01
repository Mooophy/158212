using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    /// <summary>
    /// Paper
    /// </summary>
    public class Paper : IComparable
    {
        /// <summary>
        /// Properties
        /// </summary>
        public readonly int Code;
        public readonly string Name;
        public readonly string Coordinator;
        /// <summary>
        /// Implementation for interface IComparable
        /// </summary>
        /// <param name="obj">other</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var other = obj as Paper;
            if (other != null)
                return this.Code.CompareTo(other.Code);
            else
                throw new ArgumentException("object is not a Paper");
        }
        /// <summary>
        /// Instance Ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="coodinator"></param>
        public Paper(int code, string name, string coodinator)
        {
            this.Code = code;
            this.Name = name;
            this.Coordinator = coodinator;
        }
        /// <summary>
        /// Overrided ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return this.Code + "," + this.Name + "," + this.Coordinator;
        }
    }
}
