using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    public class University
    {
        public SortedSet<Student<Int64>> Students { get; private set; }
        public SortedSet<Paper<Int64>> Papers { get; private set; }
        public SortedSet<Enrollment<Int64>> Enrollments { get; private set; }

        public University()
        {
            this.Students = new SortedSet<Student<Int64>>();
            this.Papers = new SortedSet<Paper<Int64>>();
            this.Enrollments = new SortedSet<Enrollment<Int64>>();
        }

        public void Add(Student<Int64> student)
        {
            Students.Add(student);
        }

        public void Add(Paper<Int64> paper)
        {
            Papers.Add(paper);
        }

        public void AddRange(IEnumerable<Student<Int64>> collection)
        {
            foreach (var elem in collection) 
                Students.Add(elem);
        }

        public void AddRange(IEnumerable<Paper<Int64>> collection)
        {
            foreach (var elem in collection) 
                Papers.Add(elem);
        }

        public void ImportStudents(string filename)
        {
            Func<string[], Student<Int64>> makeStudent = (line) =>
            {
                int id = Convert.ToInt32(line[0]);
                string name = line[1];
                DateTime birth = DateTime.Parse(line[2]);
                string address = line[3];
                return new Student<Int64>(id, name, birth, address);
            };

            try
            {
                using (var reader = new StreamReader(filename))
                    for (string[] line; reader.Peek() > 0; this.Add(makeStudent(line)))
                        line = reader.ReadLine().Split(',');
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " from Lib.University.cs");
            }
        }

        public void ImportPapers(string filename)
        {
            Func<string[], Paper<Int64>> makePaper = (line) =>
            {
                Int64 code = Convert.ToInt64(line[0]);
                string name = line[1];
                string coordinator = line[2];
                return new Paper<Int64>(code, name, coordinator);
            };

            try
            {
                using (var sr = new StreamReader(filename))
                    for (string[] line; sr.Peek() > 0; this.Add(makePaper(line)))
                        line = sr.ReadLine().Split(',');
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " from Lib.University.cs");
            }
        }

        public Student<Int64> FindStudent(Int64 studentId)
        {
            try
            {
                return Students.First(s => s.Id == studentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Paper<Int64> FindPaper(Int64 paperCode)
        {
            try
            {
                return this.Papers.First(p => p.Code == paperCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Student<Int64>> FindEnrolledByPaper(Int64 paperCode)
        {
            var data = from e in this.Enrollments 
                       where e.PaperCode == paperCode 
                       select this.FindStudent(e.StudentId);
            return data.ToList();
        }
        public List<Paper<Int64>> FindEnrolledByStudent(Int64 studentId)
        {
            var data = from e in this.Enrollments
                       where e.StudentId == studentId
                       select this.FindPaper(e.PaperCode);
            return data.ToList();
            //var student = FindStudent(studentId);
            //var ret = from entry in Enrollment where entry.Value.Contains(student) select entry.Key;
            //return ret.ToList();
        }
    }
}
