using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CandidateLanguages
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
