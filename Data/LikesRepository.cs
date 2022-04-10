using Microsoft.EntityFrameworkCore;
using neurek.Entities;
using neurek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataContext _context;

        public LikesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<UserLike>> GetJobAdWithLikes(int jobAdId)
        {
            return await _context.Likes.Where(j => j.JobAdId == jobAdId).ToListAsync();
        }

        public async Task<UserLike> GetUserLikes(int userId, int jobId)
        {
            return await _context.Likes.FindAsync(userId, jobId);
        }

        public async Task<AppUser> GetUserWithLikes(int userId)
        {
            return await _context.Users
                .Include(x => x.LikedJobAds)
                .FirstOrDefaultAsync(x => x.Id == userId); 
        }

    }
}
