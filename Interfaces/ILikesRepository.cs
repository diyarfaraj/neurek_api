using neurek.DTOs;
using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLikes(int userId, int JobId);
        Task<List<UserLike>> GetJobAdWithLikes(int JobAdId);
        Task<AppUser> GetUserWithLikes(int userId);
    }
}
