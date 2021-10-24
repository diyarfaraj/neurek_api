using System;

namespace neurek.DTOs
{
    public class CandidateExperienceDto
    {
        public int Id { get; set; }
        public string JobTtitle { get; set; }
        public string CompanyName { get; set; }
        public string JobDescription { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public bool CurrentJob { get; set; }
    }
}