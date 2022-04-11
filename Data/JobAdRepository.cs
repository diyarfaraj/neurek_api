using neurek.Entities;
using neurek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Data
{
    public class JobAdRepository : IJobAdRepository
    {
        public Task<IEnumerable<JobAd>> GetJobAdsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(JobAd jobAd)
        {
            throw new NotImplementedException();
        }
    }
}
