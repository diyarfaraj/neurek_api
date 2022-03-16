using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using neurek.Data;
using neurek.DTOs;
using neurek.Entities;
using neurek.Extensions;
using neurek.Helpers;
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
        public async Task<ActionResult<IEnumerable<CandidateDto>>> GetUsers([FromQuery]UserParams userParams)
        {
            var users = await _userRepository.GetCandidatesAsync(userParams);
            Response.AddPaginationHeader(users.CurentPage, users.PageSize, users.TotalCount, users.TotalPages);
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

        [HttpPut("set-main-photo/{photoId}")]
        public async Task<ActionResult> SetMainPhoto(int photoId)
        {
            var user = await _userRepository.GetUserByEmailAsync(User.GetUserEmail());
            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);
            if (photo.IsMain)
            {
                return BadRequest("This is already your main photo");
            }

            var currentMain = user.Photos.FirstOrDefault(x => x.IsMain);
            if(currentMain != null)
            {
                currentMain.IsMain = false; 
            }
            photo.IsMain = true;
            if (await _userRepository.SaveAllAsync()) return NoContent();

            return BadRequest("Failed to set main photo");
        }

        [HttpDelete("delete-photo/{photoId}")]
        public async Task<ActionResult> DeletePhoto(int photoId)
        {
            var user = await _userRepository.GetUserByEmailAsync(User.GetUserEmail());
            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);
            if (photo == null) return NotFound();
            if (photo.IsMain) return BadRequest("You can't delete your main photo");
            if(photo.PublicId != null) 
            {
                var result = await _photoService.DeletePhotoAsync(photo.PublicId);
                if (result.Error != null) return BadRequest(result.Error.Message);
            }
            user.Photos.Remove(photo);
            if (await _userRepository.SaveAllAsync()) return Ok();
            return BadRequest("Could not remove photo");
        }
    }
}
