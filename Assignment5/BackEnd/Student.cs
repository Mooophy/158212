using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace BackEnd
{
    public class Student : IComparable
    {
        /// <summary>
        /// fields
        /// </summary>
        public readonly int Id;
        public readonly string Name;
        public readonly DateTime BirthDate;
        public readonly string Address;
        /// <summary>
        /// implementation for interface IComparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var other = obj as Student;
            if (other != null)
                return this.Id.CompareTo(other.Id);
            else
                throw new ArgumentException("object is not a Student");
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="address"></param>
        public Student(int id, string name, DateTime date, string address)
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
