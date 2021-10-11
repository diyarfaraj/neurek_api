using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neurek.Data;
using neurek.Entities;
using neurek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Controllers
{
    [Authorize]
    
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            return Ok(users);
        }
        [HttpGet("{email}")]
        public async Task<ActionResult<AppUser>> GetUser( string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            return user;
        }
    }
}
