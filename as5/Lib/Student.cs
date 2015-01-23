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
        
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public override string ToString()
        {
            return "[" + this.Name + "](" + Id + ")";
        }


    }
}
