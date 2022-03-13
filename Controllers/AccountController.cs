using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neurek.Data;
using neurek.DTOs;
using neurek.Entities;
using neurek.Interfaces;
using neurek.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace neurek.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenSevice;
        private readonly IMapper _mapper;

        public AccountController(DataContext context, ITokenService tokenSevice, IMapper mapper)
        {
            _context = context;
            _tokenSevice = tokenSevice;
           _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            if (await UserExists(registerDto.Email))
            {
                return BadRequest("Email already in use");
            }

            var user = _mapper.Map<AppUser>(registerDto);
            using var hmac = new HMACSHA512();

            user.Email = registerDto.Email.ToLower();
            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password));
            user.PasswordSalt = hmac.Key;
            
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new UserDto
            {
                Email = user.Email,
                Token = _tokenSevice.CreateToken(user)
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users
                .Include(p => p.Photos)
                .SingleOrDefaultAsync(x => x.Email == loginDto.Email.ToLower());
                
            if(user == null)
            {
                return Unauthorized("Invalid email");
            }

            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if(computedHash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Wrong password");
                }
            }

            return new UserDto
            {
                Email = user.Email,
                Token = _tokenSevice.CreateToken(user),
                PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.Url  
            };
            
        }


        private async Task<bool> UserExists(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email.ToLower());
        }
    }
}
