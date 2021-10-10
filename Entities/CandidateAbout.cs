using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CandidateAbout
    {
        [ForeignKey("Candidate")]

        public int Id { get; set; }
        public Candidate Candidate { get; set; }
        public string TypeOfEmployment { get; set; }
        public bool FullTimeEmployment { get; set; }
        public string RemoteWork { get; set; }
        public string AboutMe { get; set; }

    }
}
