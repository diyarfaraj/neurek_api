using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class JobAd
    {
        public int JobAdId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Language> ProgrammingLanguages { get; set; }
        public ICollection<UserLike> Likes { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
