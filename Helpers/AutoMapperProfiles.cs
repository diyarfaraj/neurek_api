using AutoMapper;
using neurek.DTOs;
using neurek.Entities;
using neurek.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neurek.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, CandidateDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<PortfolioFile, PortfolioFileDto>();
            CreateMap<CandidateSkill, CandidateSkillDto>();
            CreateMap<CandidateEducation, CandidateEducationDto>();
            CreateMap<CandidateExperience, CandidateExperienceDto>();
        }
    }
}
