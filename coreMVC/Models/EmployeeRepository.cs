using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models
{
    public class EmployeeRepository: IEmployeeRepository
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmployeeId=101, Name = "Kartik Sharma", Salary=30000, Designation="Manager"},
            new Employee(){EmployeeId=102, Name = "Shubham Sharma", Salary=34000, Designation="Developer"},
            new Employee(){EmployeeId=103, Name = "Kartik Aryan", Salary=50000, Designation="Manager"},
            new Employee(){EmployeeId=104, Name = "Swati Malik", Salary=40000, Designation="Developer"},
            new Employee(){EmployeeId=105, Name = "Riya Chauhan", Salary=60000, Designation="Tester"},
        };
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }
        public IList<Employee> GetEmployees()
        {
            return employees;
        }

    }
}
