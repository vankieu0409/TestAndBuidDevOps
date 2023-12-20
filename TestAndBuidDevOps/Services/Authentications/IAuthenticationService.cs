﻿using Domain.Dtos;
using Domain.Entities;
using Domain.ViewModels;

namespace TestAndBuidDevOps.Services.Authentications;

public interface IAuthenticationService
{
    public Task<UserDto> Login(LoginUserViewModel request);
    public Task<UserDto> RegisterUser(CreateUserViewModel request);
    public Task<bool> Update(UpdateProfileVM resquest);
    public Task<UserDto> RefreshToken();
    string CreateToken(UserEntity user);
    RefreshTokenDto CreateRefreshToken();
    public void SetRefreshToken(RefreshTokenDto refreshToken, UserEntity user);
    public bool Logout();
    public void UpdateRoles(RoleEntity role);
    public Task<IList<string>> GetRolesOfUser(UserEntity user);

    public Task<List<RoleEntity>> GetRoles();
}