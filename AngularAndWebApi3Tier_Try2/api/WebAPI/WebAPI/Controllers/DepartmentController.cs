using BuisnessContracts.BAInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IBADepartment bADepartment;
        public DepartmentController(IBADepartment _bADepartment)
        {
            bADepartment = _bADepartment;
        }
        [Route("Get")]
        [HttpGet]
        public JsonResult DepartmentList()
        {
            return new JsonResult(bADepartment.DepartmentList());
        }
        [Route("GetDeptById/{id}")]
        [HttpGet]
        public JsonResult GetDepartment(int id)
        {
            return new JsonResult(bADepartment.DepartmentName(id));
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public JsonResult DeleteDepartment(int id)
        {
            bADepartment.DeleteDepartment(id);
            return new JsonResult("deleted Successfully");
        }

        [Route("Edit")]
        [HttpPut]
        public JsonResult Update(Department department)
        {
            return new JsonResult(bADepartment.EditDepartment(department));
        }
        [Route("Add")]
        [HttpPost]
        public JsonResult AddDepartment(Department department)
        {
            return new JsonResult(bADepartment.AddDepartment(department));
        }
    }
}
