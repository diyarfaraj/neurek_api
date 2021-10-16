using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using neurek.DTOs;
using neurek.Entities;
using neurek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByEmailAsync(string email)
        {
            return await _context.Users
                .Include(x=>x.Photos)
                .SingleOrDefaultAsync(x => x.Email == email);
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                .Include(x=>x.Photos)
                .ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public async Task<IEnumerable<CandidateDto>> GetCandidatesAsync()
        {
            return await _context.Users.ProjectTo<CandidateDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<CandidateDto> GetCandidateAsync(string email)
        {
            return await _context.Users
                .Where(x => x.Email == email)
                .ProjectTo<CandidateDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }
    }
}
