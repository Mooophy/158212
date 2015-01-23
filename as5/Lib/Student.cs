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
        
        public Student(int id, string name, DateTime date, string address)
        {
            Id = id;
            Name = name;
            BirthDate = date;
            Address = address;
        }
        
        public override string ToString()
        {
            return "[" + this.Name + "](" + Id + ")("+ BirthDate + ")(" + Address +")";
        }


    }
}
