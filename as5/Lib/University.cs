using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class University
    {
        public List<Student> Students { get; private set; }
        public List<Paper> Papers { get; private set; }
        public Dictionary<Paper, SortedSet<Student>> Enrollment { get; private set; }

        public University() 
        {
            Students = new List<Student>();
            Papers = new List<Paper>();
            Enrollment = new Dictionary<Paper, SortedSet<Student>>();
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public void Add(Paper paper)
        {
            Papers.Add(paper);
        }

        public void AddRange(IEnumerable<Student> collection)
        {
            Students.AddRange(collection);
        }

        public void AddRange(IEnumerable<Paper> collection)
        {
            Papers.AddRange(collection);
        }

        public IEnumerable<Student> find(Paper paper)
        {
            return Enrollment.ContainsKey(paper) ? Enrollment[paper].ToArray() : new Student[0];
        }

        public IEnumerable<Paper> find(Student student)
        {
            return from entry in Enrollment where entry.Value.Contains(student) select entry.Key;
        }
    }
}
