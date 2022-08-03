using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Data.Dto;
using UserAPI.Models;

namespace UserAPI.Services
{
    public class CreateRecord
    {
        private IMapper _mapper; 
        private UserManager<IdentityUser> _userManager; 

        public CreateRecord(IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public Result UserRegister(CreateUserDto createDto)
        {
            User user = _mapper.Map<User>(createDto);
            IdentityUser userIdentity = _mapper.Map<IdentityUser>(user);
            var resultIdentity = _userManager.CreateAsync(userIdentity, createDto.Password);
            if (resultIdentity.Result.Succeeded) return Result.Ok();
            return Result.Fail("Error");
        }
    }
}
