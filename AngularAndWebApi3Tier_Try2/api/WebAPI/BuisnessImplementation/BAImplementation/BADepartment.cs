using BuisnessContracts.BAInterfaces;
using DataAccessContracts.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessImplementation.BAImplementation
{
    public class BADepartment:IBADepartment
    {
        public readonly IDADepartment DADepartment;
        public BADepartment(IDADepartment _DADepartment)
        {
            DADepartment = _DADepartment;
        }

        public Department AddDepartment(Department department)
        {
            return DADepartment.AddDepartment(department);
        }

        public void DeleteDepartment(int id)
        {
            DADepartment.DeleteDepartment(id);
        }

        public List<Department> DepartmentList()
        {
            return DADepartment.DepartmentList();
        }

        public Department DepartmentName(int id)
        {
            return DADepartment.DepartmentName(id);
        }

        public Department EditDepartment(Department department)
        {
            return DADepartment.EditDepartment(department);
        }
    }
}
