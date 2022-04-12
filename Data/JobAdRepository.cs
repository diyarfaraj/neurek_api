using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        private readonly DataContext _context;

        public JobAdRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobAd>> GetJobAdsAsync()
        {
            return await _context.JobAds.ToListAsync();

        }

        public async Task<JobAd> GetSingleJobAdAsync(int jobAdId)
        {
            return await _context.JobAds.FindAsync(jobAdId);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(JobAd jobAd)
        {
            _context.Entry(jobAd).State = EntityState.Modified;
        }
    }
}
