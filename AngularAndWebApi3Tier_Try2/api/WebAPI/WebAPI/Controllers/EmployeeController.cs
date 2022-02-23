using BuisnessContracts.BAInterfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        private readonly IBAEmployee bAEmployee;
        public EmployeeController(IBAEmployee _bAEmployee,IWebHostEnvironment ienv)
        {
            bAEmployee = _bAEmployee;
            _env = ienv;
        }
        [Route("Get")]
        [HttpGet]
        public JsonResult EmployeeList()
        {
            return new JsonResult(bAEmployee.EmployeeList());
        }
        [Route("GetEmpById/{id}")]
        [HttpGet]
        public JsonResult GetEmployee(int id)
        {
            return new JsonResult(bAEmployee.EmployeeName(id));
        }

        [Route("Delete/{id}")]
        [HttpDelete]
        public JsonResult DeleteEmployee(int id)
        {
            bAEmployee.DeleteEmployee(id);
            return new JsonResult("Deleted sucessfully");
        }

        [Route("Edit")]
        [HttpPut]
        public JsonResult Update(Employee employee)
        {
            return new JsonResult(bAEmployee.EditEmployee(employee));
        }
        [Route("Add")]
        [HttpPost]
        public JsonResult AddDepartment(Employee employee)
        {
            return new JsonResult(bAEmployee.AddEmployee(employee));
        }

        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Photos/" + filename;

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(filename);

            }
            catch (Exception)
            {
                return new JsonResult("anonymous.png");
            }
        }

    }
}
