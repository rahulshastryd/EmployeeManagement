using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessContracts.Interfaces
{
    public interface IDAEmployee
    {
        List<Employee> EmployeeList();
        Employee EmployeeName(int id);
        Employee AddEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee EditEmployee(Employee employee);
    }
}
