using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public void AddStudentsByFile(string filename)
        {
            Func<string[], Student> makeStudent = (string[] line) =>
            {
                int id = Convert.ToInt32(line[0]);
                string name = line[1];
                DateTime birth = DateTime.Parse(line[2]);
                string address = line[3];
                return new Student(id, name, birth, address);
            };

            try
            {
                using (var reader = new StreamReader(filename)) 
                    for (string[] line; reader.Peek() > 0; this.Add(makeStudent(line)))
                        line = reader.ReadLine().Split(',');
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "from Lib.University.cs");
            }
        }

        public void AddPapersByFile(string filename)
        {
            Func<string[], Paper> makePaper = (string[] line) =>
            {
                string name = line[0];
                int number = Convert.ToInt32(line[1]);
                string coordinator = line[2];
                return new Paper(name, number, coordinator);
            };

            try
            {
                using (var reader = new StreamReader(filename))
                    for (string[] line; reader.Peek() > 0; this.Add(makePaper(line)))
                        line = reader.ReadLine().Split(',');
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + "from Lib.University.cs");
            }
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

        public List<Student> FindEnrolledByPaper(int paperNumber)
        {
            var paper = FindPaper(paperNumber);
            return Enrollment.ContainsKey(paper) ? Enrollment[paper].ToList() : (new Student[0]).ToList();
        }

        public List<Paper> FindEnrolledByStudent(int studentId)
        {
            var student = FindStudent(studentId);
            var ret = from entry in Enrollment where entry.Value.Contains(student) select entry.Key;
            return ret.ToList();
        }

        public bool Enrol(int paperCode, int studentId)
        {
            var paper = FindPaper(paperCode);
            var student = FindStudent(studentId);

            if (!Papers.Contains(paper) || !Students.Contains(student) || paper == null || student == null)
                return false;
            if (Enrollment.Keys.Contains(paper))
                Enrollment[paper].Add(student);
            else
                Enrollment[paper] = new SortedSet<Student> { student };
            return true;
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
