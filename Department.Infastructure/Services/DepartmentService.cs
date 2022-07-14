using Department.Domain.DTOS;
using Department.Domain.Services;
using Department.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Infastructure.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DepartmentDbContext db;
        public DepartmentService(DepartmentDbContext db)
        {
            this.db = db;
        }
    
        public DepartmentDTO GetDepartmentByCompanyId(Guid companyId)
        {
            if (companyId == default(Guid))
            {
                return null;
            }
            var department = db.Departments.FirstOrDefault(d => d.CompanyId == companyId); ;

            return department;
        }
    }
}
