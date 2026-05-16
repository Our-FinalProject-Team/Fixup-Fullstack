using AutoMapper;
using FixUp.Repository.Models;

using FixUp.Service.Dto;
using FixUp.Service.DTOs;

namespace FixUp.Service.Services
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Professional, ProfessionalDto>().ReverseMap().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)) // מיפוי שדות קיימים
           .IgnoreAllSourcePropertiesWithAnInaccessibleSetter(); ; 

            // מיפוי קטגוריות
            CreateMap<Category,CategoryDTO>() .ReverseMap();
           
            CreateMap<RequestCreateDto, Request>(); // מיצירה למודל
            CreateMap<Request, RequestDisplayDto>(); // מהמודל לתצוגה
        }
    }
}