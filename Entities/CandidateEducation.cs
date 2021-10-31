using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CandidateEducation
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string City { get; set; }
        public string EducationDescription { get; set; }
        public string LevelOfDegree { get; set; }
        public string MajoredIn { get; set; }
        public DateTime EducationStartDate { get; set; }
        public DateTime EducationEndDate { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
