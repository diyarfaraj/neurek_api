using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    [Table("Candidates")]
    public class Candidate
    {
        [ForeignKey("AppUser")]
        public int Id { get; set; }
        public AppUser AppUser { get; set; }
        public CandidateAbout CandidateAbout { get; set; }
    }
}
