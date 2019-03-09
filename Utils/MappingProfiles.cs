using System;
using AutoMapper;
using crushtown_heroes_API.Models.DTOs;
using crushtown_heroes_API.Models.Entities;

namespace crushtown_heroes_API.Utils
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //CreateMap<ApplicationUser, LoginDto>().ReverseMap();
        }
    }
}