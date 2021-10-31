using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.DTOs
{
    public class CandidateUpdateDto
    {
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public List<CandidateSkill> Skills { get; set; }
        public List<CandidateEducation> Educations { get; set; }
        public List<CandidateExperience> Experiences { get; set; }
        public List<CandidatePreference> Preferences { get; set; }
        public List<CandidateLanguages> Languages { get; set; }
        public List<PortfolioFile> CandidateFiles { get; set; }
    }
}
