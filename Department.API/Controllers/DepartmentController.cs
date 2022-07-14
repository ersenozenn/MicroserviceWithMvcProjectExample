using Department.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Department.API.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService DepartmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            DepartmentService = departmentService;
        }       
        public ActionResult Get()
        {
            var department = DepartmentService.GetDepartmentByCompanyId("IT"); 
            return Ok(department);
        }
    }
}
