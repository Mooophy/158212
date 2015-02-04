using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    /// <summary>
    /// Gneric Paper
    /// </summary>
    public class Paper<T> : IComparable<Paper<T>>
        where T : System.IComparable<T>
    {
        /// <summary>
        /// Properties
        /// </summary>
        public readonly T Code;
        public readonly string Name;
        public readonly string Coordinator;
        /// <summary>
        /// Implementation for interface IComparable
        /// </summary>
        /// <param name="obj">other</param>
        /// <returns></returns>
        public int CompareTo(Paper<T> other)
        {
            return other == null ? 1 : this.Code.CompareTo(other.Code);
        }
        /// <summary>
        /// Instance Ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="coodinator"></param>
        public Paper(T code, string name, string coodinator)
        {
            this.Code = code;
            this.Name = name;
            this.Coordinator = coodinator;
        }
        /// <summary>
        /// simpilified Ctor
        /// </summary>
        /// <param name="code"></param>
        public Paper(T code)
            :this(code,"_","_")
        { }
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
