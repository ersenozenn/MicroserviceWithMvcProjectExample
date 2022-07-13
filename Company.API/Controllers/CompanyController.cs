using Company.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService CompanyService;
        public CompanyController(ICompanyService companyService)
        {
            CompanyService = companyService;
        }
        public ActionResult Get(Guid Id)
        {
            var company=CompanyService.GetCompanyByID(Id);
            return Ok(company);
        }
    }
}
