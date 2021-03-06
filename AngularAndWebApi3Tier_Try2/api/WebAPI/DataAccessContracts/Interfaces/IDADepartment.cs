using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessContracts.Interfaces
{
    public interface IDADepartment
    {
        List<Department> DepartmentList();
        Department DepartmentName(int id);
        Department AddDepartment(Department department);
        void DeleteDepartment(int id);
        Department EditDepartment(Department department);
    }
}
