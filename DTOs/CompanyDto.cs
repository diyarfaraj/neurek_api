using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.DTOs
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int YearFoundedIn { get; set; }
        public List<RecruterDto> Recruters { get; set; }
        public List<PhotoDto> Photos { get; set; }
    }
}
