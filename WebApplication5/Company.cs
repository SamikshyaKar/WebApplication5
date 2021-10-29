using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> EmployeeLists;
        public Company()
        {
            EmployeeLists = new List<Employee>();
            EmployeeLists.Add(new Employee() { ID = 1, Name = "Amu", Gender = "M" });
            EmployeeLists.Add(new Employee() { ID = 2, Name = "Samu", Gender = "F" });
            EmployeeLists.Add(new Employee() { ID = 3, Name = "Amu", Gender = "M" });
            EmployeeLists.Add(new Employee() { ID = 4, Name = "Samu", Gender = "F" });
            EmployeeLists.Add(new Employee() { ID = 5, Name = "Amu", Gender = "M" });
            EmployeeLists.Add(new Employee() { ID = 6, Name = "Samu", Gender = "F" });


        }

        public string this[int empID]
        {
            get { return EmployeeLists.FirstOrDefault(emp => emp.ID == empID).Name; }

            set { EmployeeLists.FirstOrDefault(emp => emp.ID == empID).Name = value; }

        }




    }
}