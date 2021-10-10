using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Entities
{
    public class CompanyUser
    {
        [ForeignKey("AppUser")]

        public int Id { get; set; }
        public AppUser AppUser { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }


    }
}
