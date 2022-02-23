using DataAccessContracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessImplementation.DAImplementation
{
    public class DAEmployee : IDAEmployee
    {
        private readonly EmployeeContext employeeContext;
        public DAEmployee(EmployeeContext _employeeContext)
        {
            employeeContext = _employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employeeContext.Employees.Add(employee);
            employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = employeeContext.Employees.Find(id);
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var emp = employeeContext.Employees.Find(employee.EmployeeId);
            if(emp!=null)
            {
                emp.Department = employee.Department;
                emp.EmployeeName = employee.EmployeeName;
                emp.DateofJoining = employee.DateofJoining;
                emp.PhotoFileName = employee.PhotoFileName;
                employeeContext.Employees.Update(emp);
                employeeContext.SaveChanges();
            }
            return employee;
        }

        public List<Employee> EmployeeList()
        {
            return employeeContext.Employees.ToList();
        }

        public Employee EmployeeName(int id)
        {
            return employeeContext.Employees.FirstOrDefault(x => x.EmployeeId == id);
        }
    }
}
