using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace BackEnd
{
    public class Student<T> : IComparable<Student<T>>
        where T : System.IComparable<T>
    {
        /// <summary>
        /// fields
        /// </summary>
        public readonly T Id;
        public readonly string Name;
        public readonly DateTime BirthDate;
        public readonly string Address;
        /// <summary>
        /// implementation for interface IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns>int</returns>
        public int CompareTo(Student<T> other)
        {
            return other == null ? 1 : this.Id.CompareTo(other.Id);
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="address"></param>
        public Student(T id, string name, DateTime date, string address)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = date;
            this.Address = address;
        }
        /// <summary>
        /// overrided ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return this.Id + "," + this.Name + "," + this.BirthDate + "," + this.Address;
        }
    }
}
