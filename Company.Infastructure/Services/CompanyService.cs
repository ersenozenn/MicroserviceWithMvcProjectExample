using Company.Domain.DTOS;
using Company.Domain.Services;
using Company.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infastructure.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly CompanyDbContext db;
        public CompanyService(CompanyDbContext db) 
        {
            this.db = db;
        }
        public CompanyDTO GetCompanyByID(Guid Id)
        {
            if (Id==default(Guid))
            {
                return null;
            }
            var company=db.Companies.Find(Id);

            return company;
        }
    }
}
