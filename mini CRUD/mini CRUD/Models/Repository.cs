using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mini_CRUD.Models
{
    public static class Repository
    {
        private static List<Employee> allEmpoyees = new List<Employee>();
        public static IEnumerable<Employee> AllEmpoyees
        {
            get { return allEmpoyees; }
        }
        public static void Create(Employee employee)
        {
            allEmpoyees.Add(employee);
        }
    }
}
