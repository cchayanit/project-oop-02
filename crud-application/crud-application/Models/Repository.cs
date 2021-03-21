using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace crud_application.Models
{
    public static class Repository
    {
        private static readonly List<Student> allStudents = new List<Student>();
        public static IEnumerable<Student> AllStudents
        {
            get { return allStudents; }
        }
        public static void Create(Student student)
        {
            allStudents.Add(student);
        }

        public static void Delete(Student student)
        {
            allStudents.Remove(student);
        }
    }
}
