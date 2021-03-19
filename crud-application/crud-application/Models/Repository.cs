using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_application.Models
{
    public static class Repository
    {
        private static List<Student> allStudents = new List<Student>();
        public static IEnumerable<Student> AllEmpoyees
        {
            get { return allStudents; }
        }
        public static void Create(Student employee)
        {
            allStudents.Add(employee);
        }
    }
}
