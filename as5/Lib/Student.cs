using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Student
    {
        public readonly int Id;
        public readonly string Name;
        public readonly DateTime BirthDate;
        public readonly string Address;
        
        /// <summary>
        /// Instance Ctor
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
            :this(student.Id,student.Name,student.BirthDate,student.Address)
        {}

        public override string ToString()
        {
            return "[" + this.Name + "](" + Id + ")("+ BirthDate + ")(" + Address +")";
        }


    }
}
