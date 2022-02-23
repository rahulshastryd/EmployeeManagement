using BuisnessContracts.BAInterfaces;
using DataAccessContracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessImplementation.BAImplementation
{
    public class BAEmployee : IBAEmployee
    {
        private readonly IDAEmployee dAEmployee;
        public BAEmployee(IDAEmployee _dAEmployee)
        {
            dAEmployee = _dAEmployee;
        }
        public Employee AddEmployee(Employee employee)
        {
            return dAEmployee.AddEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            dAEmployee.DeleteEmployee(id);
        }

        public Employee EditEmployee(Employee employee)
        {
            return dAEmployee.EditEmployee(employee);
        }

        public List<Employee> EmployeeList()
        {
            return dAEmployee.EmployeeList();
        }

        public Employee EmployeeName(int id)
        {
            return dAEmployee.EmployeeName(id);
        }
    }
}
