using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.DTOs
{
    public class CandidateDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; } 
        public bool Deleted { get; set; }
        public List<CandidateSkillDto> Skills { get; set; }
        public List<CandidateEducationDto> Educations { get; set; }
        public List<CandidateExperienceDto> Experiences { get; set; }
        public List<CandidatePreferenceDto> Preferences { get; set; }
        public List<PortfolioFileDto> CandidateFiles { get; set; }
        public List<PhotoDto> Photos { get; set; }
    }
}
