using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neurek.Data;
using neurek.DTOs;
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
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidateDto>>> GetUsers()
        {
            var users = await _userRepository.GetCandidatesAsync();
            return Ok(users);
        }
        [HttpGet("{email}")]
        public async Task<ActionResult<CandidateDto>> GetUser( string email)
        {
            return await _userRepository.GetCandidateAsync(email);
            
        }
        [HttpGet("company/{email}")]
        public async Task<ActionResult<RecruterDto>> GetRecruter(string email)
        {
            return await _userRepository.GetRecruterAsync(email);

        }
    }
}
