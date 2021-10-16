using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CandidatePreference
    {
        public int Id { get; set; }
        public int SalaryPerMonth { get; set; }
        public string NoticeOfPeriod { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}
