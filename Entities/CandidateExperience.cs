using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CandidateExperience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int YearsOfWorking { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
