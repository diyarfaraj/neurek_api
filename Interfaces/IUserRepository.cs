using neurek.DTOs;
using neurek.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByEmailAsync(string email);
        Task<IEnumerable<CandidateDto>> GetCandidatesAsync();
        Task<CandidateDto> GetCandidateAsync(string email);
        Task<RecruterDto> GetRecruterAsync(string email);
    }
}
