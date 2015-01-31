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

        /// <summary>
        /// format : 
        ///     id,name,birthdate,address
        /// </summary>
        /// <param name="filename"></param>
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
                throw new Exception(ex.Message + " from Lib.University.cs");
            }
        }

        /// <summary>
        /// format:
        ///     name,number,coordinator
        /// </summary>
        /// <param name="filename"></param>
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
                using (var sr = new StreamReader(filename))
                    for (string[] line; sr.Peek() > 0; this.Add(makePaper(line)))
                        line = sr.ReadLine().Split(',');
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message + " from Lib.University.cs");
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
            return Enrollment.ContainsKey(paper) ? Enrollment[paper].ToList() : new List<Student>();
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

        /// <summary>
        /// format : 
        ///     paper number, student id
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool Enrol(string line)
        {
            string[] buff = line.Split(',');
            int paperNumber = 0, studentId = 0;
            if(! Int32.TryParse(buff[0],out paperNumber))
                throw new Exception(buff[0] + " is not a valid paper number");
            if(! Int32.TryParse(buff[1], out studentId))
                throw new Exception(buff[1] + " is not a valid student id");

            return this.Enrol(paperNumber, studentId);
        }

        /// <summary>
        /// load enrollment information from a csv file, format :
        ///     paper number, student id
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>number of enrollments successfully performed</returns>
        public int EnrolByFile(string filename)
        {
            int count = 0;
            try
            {
                using (var sr = new StreamReader(filename))
                    for (string info; sr.Peek() > 0; count += Enrol(info) ? 1 : 0)
                        info = sr.ReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "from Lib.University.cs");
            }
            return count;
        }

        public void ExportStudentsToFile(string path)
        {
            try
            {
                using (var sw = new StreamWriter(path, true))
                    foreach (var s in Students) sw.WriteLine(s.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " from Lib.University.cs");
            }
        }

        public void ExportPapersToFile(string path)
        {
            try
            {
                using (var sw = new StreamWriter(path, true))
                    foreach (var p in Papers) sw.WriteLine(p.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " from Lib.University.cs");
            }
        }


        public Paper FindPaper(int paperCode)
        {
            if (Papers.Count == 0)
                throw new Exception("Papers are empty");
            return Papers.First(p => p.Number == paperCode);
        }

        public Student FindStudent(int studentId)
        {
            return Students.First(s => s.Id == studentId);
        }

        public bool Export(string folder)
        {
            string now = DateTime.Now.ToFileTime().ToString();

            Func<bool> exportStudents = () =>
            {
                try
                {
                    using (var sr = new StreamWriter(@folder + "\\Students"  + now + ".csv"))
                        foreach (var student in this.Students) sr.WriteLine(student.ToString());
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            };

            Func<bool> exportPapers = () =>
            {
                try
                {
                    using (var sr = new StreamWriter(@folder + "\\Papers" + now + ".csv"))
                        foreach (var student in this.Papers) sr.WriteLine(student.ToString());
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            };

            Func<bool> exportEnrollment = () =>
            {
                try
                {
                    using (var sr = new StreamWriter(@folder + "\\Enrollment" + now + ".csv"))
                        foreach (var pair in this.Enrollment)
                            foreach (var student in pair.Value)
                                sr.WriteLine(pair.Key.Number + "," + student.Id);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            };

            return exportStudents() && exportPapers() && exportEnrollment();
        }
    }
}
