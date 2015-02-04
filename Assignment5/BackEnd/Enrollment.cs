using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    /// <summary>
    /// Generic Enrollment relationship
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Enrollment<T> : IComparable<Enrollment<T>> 
        where T : IComparable<T>
    {
        /// <summary>
        /// Property
        /// </summary>
        public readonly T PaperCode, StudentId;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="code"></param>
        /// <param name="id"></param>
        public Enrollment(T code, T id)
        {
            this.PaperCode = code;
            this.StudentId = id;
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="student"></param>
        public Enrollment(Paper<T> paper, Student<T> student)
        {
            this.PaperCode = paper.Code;
            this.StudentId = student.Id;
        }
        /// <summary>
        /// overriding ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.PaperCode + "," + this.StudentId;
        }
        /// <summary>
        /// implementation for interface IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Enrollment<T> other)
        {
            if (this.PaperCode.CompareTo(other.PaperCode) != 0)
                return this.PaperCode.CompareTo(other.PaperCode);
            else
                return this.StudentId.CompareTo(other.StudentId);
        }
    }
}
