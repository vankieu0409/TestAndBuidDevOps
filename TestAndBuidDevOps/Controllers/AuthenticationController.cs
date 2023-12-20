﻿using Domain.Dtos;
using Domain.Entities;
using Domain.ViewModels;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using IAuthenticationService = TestAndBuidDevOps.Services.Authentications.IAuthenticationService;

namespace TestAndBuidDevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthenticationController(IAuthenticationService authenticationService, IHttpContextAccessor httpContextAccessor)
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> RegisterAsync(CreateUserViewModel request)
        {
            var response = await _authenticationService.RegisterUser(request);
            return Ok(response);
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> LoginAsync(LoginUserViewModel request)
        {
            var response = await _authenticationService.Login(request);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPut("update")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> UpdateAsync(UpdateProfileVM request)
        {
            var response = await _authenticationService.Update(request);
            if (response)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("refresh-token")]
        [Authorize]
        public async Task<ActionResult<UserDto>> RefreshToken()
        {
            var check = _httpContextAccessor?.HttpContext?.Request.Cookies;
            var response = await _authenticationService.RefreshToken();
            if (response.Success)
                return Ok(response);

            return BadRequest(response.Message);
        }


        [HttpGet("/signin-google")]
        public async Task<IActionResult> SignInGoogle()
        {
            var result = await HttpContext.AuthenticateAsync("External");
            var claims = result.Principal.Claims.ToList();
            // Access the user's information from the claims
            // ...
            return Ok();
        }

        [HttpGet("/roles")]
        [AllowAnonymous]
        public async Task<List<RoleEntity>> GetRoleAsync()
        {
            return await _authenticationService.GetRoles();
        }


        [HttpGet("/Logout")]
        [Authorize]
        public async Task<IActionResult> SignIn()
        {

            return Ok(_authenticationService.Logout());
        }
    }
}
