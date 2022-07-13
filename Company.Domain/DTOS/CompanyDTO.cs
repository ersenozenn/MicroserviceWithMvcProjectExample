using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.DTOS
{
    public class CompanyDTO
    {
        public Guid ID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string TaxAdmin { get; set; }
        public string TaxNumber { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }        
    }
}
