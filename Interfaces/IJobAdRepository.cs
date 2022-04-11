using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Interfaces
{
    public interface IJobAdRepository
    {
        void Update(JobAd jobAd);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<JobAd>> GetJobAdsAsync();
    }
}
