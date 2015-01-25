using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class University
    {
        public SortedSet<Student> Students { get; private set; }
        public SortedSet<Paper> Papers { get; private set; }
        public Dictionary<Paper, SortedSet<Student>> Enrollment { get; private set; }

        public University() 
        {
            Students = new SortedSet<Student>();
            Papers = new SortedSet<Paper>();
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
            foreach(var elem in collection) Students.Add(elem);
        }

        public void AddRange(IEnumerable<Paper> collection)
        {
            foreach (var elem in collection) Papers.Add(elem);
        }

        public IEnumerable<Student> Find(Paper paper)
        {
            return Enrollment.ContainsKey(paper) ? Enrollment[paper].AsEnumerable() : (new Student[0]).AsEnumerable();
        }

        public IEnumerable<Paper> Find(Student student)
        {
            return from entry in Enrollment where entry.Value.Contains(student) select entry.Key;
        }

        public bool Enrol(Paper paper, Student student)
        {
            if (!Papers.Contains(paper) || !Students.Contains(student) || paper == null || student == null)
                return false;
            if (Enrollment.Keys.Contains(paper))
                Enrollment[paper].Add(student);
            else
                Enrollment[paper] = new SortedSet<Student>();
            return true;
        }

        public bool Enrol(int paperCode, int studentId)
        {
            return Enrol(FindPaper(paperCode), FindStudent(studentId));
        }

        public Paper FindPaper(int paperCode)
        {
            return Papers.First(p => p.Number == paperCode);
        }

        public Student FindStudent(int studentId)
        {
            return Students.First(s => s.Id == studentId);
        }
    }
}
