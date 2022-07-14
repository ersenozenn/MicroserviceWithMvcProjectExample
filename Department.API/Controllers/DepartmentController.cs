using Department.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Department.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService DepartmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            DepartmentService = departmentService;
        }
    
        public ActionResult GetByCompanyId(Guid companyId)
        {
            var department = DepartmentService.GetDepartmentByCompanyId(companyId); 
            return Ok(department);
        }
    }
}
