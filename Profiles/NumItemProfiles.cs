using AutoMapper;
using NumberAPI.DTOs;
using NumberAPI.Models;

namespace NumberAPI.Profiles
{
    public class NumItemProfiles : Profile
    {
        public NumItemProfiles()
        {
            CreateMap<NumItem, NumItemReadDto>();
            CreateMap<NumItemCreateDto, NumItem>();
        }
    }
}
