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
        int IComparable.CompareTo(object obj)
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
            Id = id;
            Name = name;
            BirthDate = date;
            Address = address;
        }
        /// <summary>
        /// Copy Ctor
        /// </summary>
        /// <param name="student"></param>
        public Student(Student student)
            : this(student.Id, student.Name, student.BirthDate, student.Address)
        { }
        /// <summary>
        /// overrided ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Id + "," + Name + "," + BirthDate + "," + Address;
        }
    }
}
