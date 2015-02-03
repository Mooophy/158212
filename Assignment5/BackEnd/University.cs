﻿using System;
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

        public bool Add(Student<Int64> student)
        {
            return this.Students.Add(student);
        }

        public bool Add(Paper<Int64> paper)
        {
            return this.Papers.Add(paper);
        }

        public void AddRange(IEnumerable<Student<Int64>> collection)
        {
            foreach (var elem in collection) 
                this.Students.Add(elem);
        }

        public void AddRange(IEnumerable<Paper<Int64>> collection)
        {
            foreach (var elem in collection)
                this.Papers.Add(elem);
        }

        public long ImportStudents(string filename)
        {
            Func<string[], Student<Int64>> makeStudent = (line) =>
            {
                var id = Convert.ToInt64(line[0]);
                string name = line[1];
                DateTime birth = DateTime.Parse(line[2]);
                string address = line[3];
                return new Student<Int64>(id, name, birth, address);
            };

            try
            {
                long count = 0;
                foreach (var line in Utilities.ReadFrom(filename))
                    count += this.Add(makeStudent(line.Split(','))) ? 1 : 0; 
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long ImportPapers(string filename)
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
                long count = 0;
                foreach(var line in Utilities.ReadFrom(filename))
                    count += this.Add(makePaper(line.Split(','))) ? 1 : 0;
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long ImportEnrollments(string path)
        {
            try
            {
                long count = 0;
                foreach(var line in Utilities.ReadFrom(path))
                    count += this.Enrol(line) ? 1 : 0;
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
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
            return 
                this.Enrollments
                .Where(e => e.PaperCode == paperCode)
                .Select(e => this.FindStudent(e.StudentId))
                .ToList();
        }

        public List<Paper<Int64>> FindEnrolledByStudent(Int64 studentId)
        {
            var data = from e in this.Enrollments
                       where e.StudentId == studentId
                       select this.FindPaper(e.PaperCode);
            return data.ToList();
        }

        public bool Enrol(Int64 paperCode, Int64 studentId)
        {
            if(this.Papers.Contains(this.FindPaper(paperCode)) 
                && this.Students.Contains(this.FindStudent(studentId)))
                return this.Enrollments.Add(new Enrollment<long>(paperCode, studentId));
            else
                return false;
        }

        public bool Enrol(string line)
        {
            string[] buff = line.Split(',');
            long paperCode = 0, studentId = 0;
            if (! long.TryParse(buff[0], out paperCode))
                throw new Exception(buff[0] + " is not a valid paper code");
            if (! long.TryParse(buff[1], out studentId))
                throw new Exception(buff[1] + " is not a valid student id");
            return this.Enrol(paperCode, studentId);
        }

        public bool Export<T>(SortedSet<T> set, string folder, string filename, string fileExtention)
        {
            try
            {
                string path = @folder + "\\" + filename + "." + fileExtention;
                using (var sw = new StreamWriter(path))
                    foreach (var element in set) 
                        sw.WriteLine(element.ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExportAllData(string folder)
        {
            string now = DateTime.Now.ToFileTime().ToString();
            var ret = true;
            ret = ret && this.Export<Student<long>>(this.Students, folder, "Students" + now, "csv");
            ret = ret && this.Export<Paper<long>>(this.Papers, folder, "Papers" + now, "csv");
            ret = ret && this.Export<Enrollment<long>>(this.Enrollments, folder, "Enrollments" + now, "csv");
            return ret;
        }
    }
}
