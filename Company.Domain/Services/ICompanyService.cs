using Company.Domain.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Services
{
    public interface ICompanyService
    {
        CompanyDTO GetCompanyByID(Guid Id);
    }
}
