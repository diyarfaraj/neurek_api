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
        private readonly IJobAdRepository _jobAdRepository;

        public LikesController(IUserRepository userRepository, ILikesRepository likesRepository, IJobAdRepository jobAdRepository)
        {
            _userRepository = userRepository;
            _likesRepository = likesRepository;
            _jobAdRepository = jobAdRepository;
        }

        [HttpPost("{jobAdId}")]
        public async Task<ActionResult> AddLike(int jobAdId)
        {
            //create IJobAd repo
            var userId = User.GetUserId();
            var likedJobAd =  await _jobAdRepository.GetSingleJobAdAsync(jobAdId);

            if (userId == null) return NotFound();

            var alreadyLiked = await _likesRepository.GetJobAdWithLikes(jobAdId); //see if user has liked this add before, if true return bad req, change the methid to take in userId also
            //


        }
    }
}
