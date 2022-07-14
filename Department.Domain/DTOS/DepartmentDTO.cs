using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Domain.DTOS
{
    public class DepartmentDTO
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }    
        public string DepartmentDescription { get; set; }        
        public Guid CompanyId { get; set; }
        public Guid ParentId { get; set; }
    }
}
