using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using neurek.DTOs;
using neurek.Entities;
using neurek.Helpers;
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

        public async Task<PagedList<CandidateDto>> GetCandidatesAsync(UserParams userParams)
        {
            var candidates = _context.Users.AsQueryable();


            candidates = candidates.Where(c => c.Email != userParams.CurrentUsername);

            return await PagedList<CandidateDto>.CreateAsync(
                candidates.Include(x => x.Skills)
                .Include(x => x.Educations)
                .Include(x => x.Experiences)
                .Include(x => x.Preferences)
                .ProjectTo<CandidateDto>(_mapper.ConfigurationProvider)
                .AsNoTracking(), 
                userParams.PageNumber, 
                userParams.PageSize);
        }

        public async Task<CandidateDto> GetCandidateAsync(string email)
        {
            return await _context.Users
                .Where(x => x.Email == email)
                .Include(x => x.Skills)
                .Include(x => x.Educations)
                .Include(x => x.Experiences)
                .Include(x => x.Preferences)
                .ProjectTo<CandidateDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<RecruterDto> GetRecruterAsync(string email)
        {
            var recruter = await _context.Users
                .Where(x => x.Company.Id > 0 && x.Email == email)
                .ProjectTo<RecruterDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
            return recruter;
        }
    }
}
