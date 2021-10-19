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
            CreateMap<AppUser, CandidateDto>();
                //.ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
                //.ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<PortfolioFile, PortfolioFileDto>();
            CreateMap<CandidateSkill, CandidateSkillDto>()
                .ForMember(dest => dest.DevIconName, opt => opt.MapFrom(src => src.Skills.DevIconName))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Skills.Name));
            CreateMap<CandidateEducation, CandidateEducationDto>();
            CreateMap<CandidateExperience, CandidateExperienceDto>();
            CreateMap<CandidatePreference, CandidatePreferenceDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<AppUser, RecruterDto>();
            CreateMap<CompanyBenefit, CompanyBenefitDto>();
            CreateMap<Skills, SkillsDto>();

        }
    }
}
