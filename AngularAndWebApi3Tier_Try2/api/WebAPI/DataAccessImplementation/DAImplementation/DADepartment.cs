using DataAccessContracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessImplementation.DAImplementation
{
    public class DADepartment:IDADepartment
    {
        public readonly EmployeeContext employeeContext;
        public DADepartment(EmployeeContext _employeeContext)
        {
            employeeContext = _employeeContext;
        }
        public List<Department> DepartmentList()
        {
            return employeeContext.Departments.ToList();
        }

        public Department DepartmentName(int id)
        {
            return employeeContext.Departments.FirstOrDefault(x => x.DepartmentId == id);
        }

        public Department AddDepartment(Department department)
        {
            employeeContext.Departments.Add(department);
            employeeContext.SaveChanges();
            return department;
        }

        public void DeleteDepartment(int id)
        {
            Department department = employeeContext.Departments.Find(id);
            employeeContext.Departments.Remove(department);
            employeeContext.SaveChanges();

        }

        public Department EditDepartment(Department department)
        {
            var existingDepartment = employeeContext.Departments.Find(department.DepartmentId);
            if (existingDepartment != null)
            {
                existingDepartment.DepartmentName = department.DepartmentName;
                employeeContext.Departments.Update(existingDepartment);
                employeeContext.SaveChanges();
            }
            return department;
        }

        //public Department EditDepartment(int id)
        //{
        //    Department department = employeeContext.Departments.Find(id);
        //    if (department != null)
        //    {
        //        return Redirect("/Edit");
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //public Department EditDepartment(Department department)
        //{
        //    employeeContext.Update(department);
        //    employeeContext.SaveChanges();
        //    return department;
        //}
    }
}
