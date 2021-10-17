using neurek.DTOs;
using neurek.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;
        public bool Deleted { get; set; }
        public List<CandidateSkill> Skills { get; set; }
        public List<CandidateEducation> Educations { get; set; }
        public List<CandidateExperience> Experiences { get; set; }
        public List<PortfolioFile> CandidateFiles { get; set; }
        public List<CandidatePreference> Preferences { get; set; }
        public Company Company { get; set; }
        public List<Photo> Photos { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
