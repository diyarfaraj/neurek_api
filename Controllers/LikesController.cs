using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using neurek.Extensions;
using neurek.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Controllers
{
    [Authorize]
    public class LikesController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly ILikesRepository _likesRepository;

        public LikesController(IUserRepository userRepository, ILikesRepository likesRepository)
        {
            _userRepository = userRepository;
            _likesRepository = likesRepository;
        }

        [HttpPost("{jobAdId}")]
        public async Task<ActionResult> AddLike(int jobAdId)
        {
            //create IJobAd repo
            var userId = User.GetUserId();
            var likedJobAd = _likesRepository.get
        }
    }
}
