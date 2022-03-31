using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int YearFoundedIn { get; set; }
        public List<Photo> Photos { get; set; }
        public List<CompanyBenefit> Benefits { get; set; }
        public List<JobAd> JobAds { get; set; }



    }
}
