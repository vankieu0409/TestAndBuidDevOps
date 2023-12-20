using Domain.Dtos;
using Domain.Entities;
using Domain.ViewModels;

using AutoMapper;

namespace TestAndBuidDevOps.Extensions.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, UserEntity>().ReverseMap();
        CreateMap<UpdateProfileVM, UserEntity>().ReverseMap();
        CreateMap<ProductAdminDto, ProductEntity>().ReverseMap();
    }
}