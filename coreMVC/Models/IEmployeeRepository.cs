using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVC.Models
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetEmployees();
        Employee GetEmployeeById(int employeeId);
        void AddEmployee(Employee employee);
    }
}
