﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neurek.Data;
using neurek.DTOs;
using neurek.Entities;
using neurek.Extensions;
using neurek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace neurek.Controllers
{
    [Authorize]
    
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPhotoService _photoService;

        public UsersController(IUserRepository userRepository, IMapper mapper, IPhotoService photoService)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _photoService = photoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidateDto>>> GetUsers()
        {
            var users = await _userRepository.GetCandidatesAsync();
            return Ok(users);
        }
        [HttpGet("{email}", Name ="GetUser")]
        public async Task<ActionResult<CandidateDto>> GetUser( string email)
        {
            return await _userRepository.GetCandidateAsync(email);
            
        }
        [HttpGet("company/{email}")]
        public async Task<ActionResult<RecruterDto>> GetRecruter(string email)
        {
            return await _userRepository.GetRecruterAsync(email);

        }

        [HttpPut]
        public async Task<ActionResult> UpdateCandidate(CandidateUpdateDto candidateUpdateDto)
        {
            var candidate = await _userRepository.GetUserByEmailAsync(User.GetUserEmail());

            _mapper.Map(candidateUpdateDto, candidate);
            _userRepository.Update(candidate);
            if (await _userRepository.SaveAllAsync()) return NoContent();
            return BadRequest("failed to update user");
        }

        [HttpPost("add-photo")]
        public async Task<ActionResult<PhotoDto>> AddPhoto(IFormFile file)
        {
            var user = await _userRepository.GetUserByEmailAsync(User.GetUserEmail());
            var result = await _photoService.AddPhotoAsync(file);
            if (result.Error != null) return BadRequest(result.Error.Message);
            var photo = new Photo
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };

            if(user.Photos.Count == 0)
            {
                photo.IsMain = true;
            }

            user.Photos.Add(photo);
            if (await _userRepository.SaveAllAsync())
            {
                return CreatedAtRoute("GetUser", new { email = user.Email},_mapper.Map<PhotoDto>(photo));

            }

            return BadRequest("problem adding photo");
        }
    }
}
