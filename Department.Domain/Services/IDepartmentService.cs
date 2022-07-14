using Department.Domain.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Domain.Services
{
    public interface IDepartmentService
    {
        DepartmentDTO GetDepartmentByCompanyId(string companyId);
    }
}
