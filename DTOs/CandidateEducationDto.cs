using System;

namespace neurek.DTOs
{
    public class CandidateEducationDto
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string City { get; set; }
        public string EducationDescription { get; set; }
        public string LevelOfDegree { get; set; }
        public DateTime EducationStartDate { get; set; }
        public DateTime EducationEndDate { get; set; }
        public string MajoredIn { get; set; }
    }
}