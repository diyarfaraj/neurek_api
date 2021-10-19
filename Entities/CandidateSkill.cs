using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CandidateSkill
    {
        public int Id { get; set; }
        public int YearsOfExperience { get; set; }
        public Skills Skills { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
