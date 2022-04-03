using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.DTOs
{
    public class LikeDto
    {
        public int Id { get; set; }
        public int JobAdId { get; set; }
        public int CompanyId  { get; set; }
        public ICollection<LanguageDto> ProgrammingLanguages { get; set; }
    }
}
