using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string JobTtitle { get; set; }
        public string CompanyName { get; set; }
        public string JobDescription { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}
